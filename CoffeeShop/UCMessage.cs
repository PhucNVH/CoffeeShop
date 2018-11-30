using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class UCMessage : UserControl
    {
        String currentUser;
        public UCMessage(String username)
        {
            //khởi tạo username của user hiện tại
            this.currentUser = username;
            InitializeComponent();
            pnAdmin.Hide();
        }

        //event button Gửi được click
        private void btnSend_Click(object sender, EventArgs e)
        {
            //nếu text khác rỗng
            if (txtMessage.Text != "")
            {
                //truyền gọi hàm gửi tin nhắn và truyền username người nhận,người gửi, text
                DatabaseConnection.sendMessage(currentUser, cbListUsername.SelectedValue.ToString(), txtMessage.Text);
                //add đoạn tin nhắn vừa gửi vào listview chatbox 
                string[] arrItem = { currentUser + ":", txtMessage.Text };
                ListViewItem newItem = new ListViewItem(arrItem);
                lvMessage.Items.Add(newItem);
            }
            txtMessage.Text = "";
        }

        private void cbListUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mỗi khi đổi index của combobox, xóa chatbox
            lvMessage.Clear();
            if (currentUser == "admin")
            {
                //chỉnh sửa thông số listview nếu là admin
                adminLvSize();
            }
            else
            {
                //thông số listview của các user khác
                lvMessage.Columns.Add("", 60);
                lvMessage.Columns.Add("", 530);
            }
            lvMessage.View = View.Details;
            //đọc các tin nhắn trước đó ở database
            DataTable messageData = DatabaseConnection.readMessage(currentUser, cbListUsername.SelectedValue.ToString());
            foreach (DataRow dr in messageData.Rows)
            {
                string[] arrItem = { dr["sender"].ToString() + ":", dr["message"].ToString() };
                ListViewItem newItem = new ListViewItem(arrItem);
                lvMessage.Items.Add(newItem);
            }
        }

        private void UCMessage_Load(object sender, EventArgs e)
        {
            lbNewMess.Text = "New Message: " + DatabaseConnection.isNewMessage(currentUser);
            cbListUsername.DataSource = DatabaseConnection.getStaffInfo(currentUser);
            cbListUsername.ValueMember = "username";
            cbListUsername.DisplayMember = "username";
            // nếu user hiện tại là admin, hiển thị panel của admin
            if (currentUser == "admin") { adminMessage(); }
        }
        private void adminMessage()
        {
            //tạo các thông số cho admin
            //đưa panel admin lên
            lbNewMess.Location = new Point(520, 12);
            pnAdmin.Show();
            pnAdmin.BringToFront();
            txtMessage.Size = new Size(400, 35);
            lvMessage.Size = new Size(400, 240);
            lvMessage.Columns[0].Width = 60;
            lvMessage.Columns[1].Width = 330;
        }
        private void adminLvSize()
        {
            lvMessage.Columns.Add("", 60);
            lvMessage.Columns.Add("", 330);
        }

        //tạo event gửi toàn bộ của admin
        private void btnSendAll_Click(object sender, EventArgs e)
        {
            if (txtAdminMessage.Text != "") DatabaseConnection.sendMessage("admin", "all", "(Toàn bộ)  " + txtAdminMessage.Text);
            txtAdminMessage.Text = "";
        }
    }
}
