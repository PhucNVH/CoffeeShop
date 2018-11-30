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
    public partial class UCChangeInfo : UserControl
    {
        String Username;
        public UCChangeInfo(String currentUsername)
        {
            InitializeComponent();
            //Lưu username được truyền từ form
            this.Username = currentUsername;
        }

        private void UCChangeInfo_Load(object sender, EventArgs e)
        {
            //lấy dữ liệu từ database theo username
            DataRow UserDr = DatabaseConnection.getAStaffInfo(this.Username);
            //hiển thị các thông tin cơ bản
            txtUserBirthday.Text = DateTime.Parse(UserDr["BirthDay"].ToString()).ToShortDateString();
            txtUserFullname.Text = UserDr["Fullname"].ToString();
            txtUserPhoneNum.Text = UserDr["PhoneNumber"].ToString();
            txtUsername.Text = this.Username;
        }

        private void txtUserChangeInfo_Click(object sender, EventArgs e)
        {

            String UserPass = txtUserPassword1.Text;
            //nếu 2 ô password không trùng báo lỗi
            if (txtUserPassword1.Text != txtUserPassword2.Text) { MessageBox.Show("Mật khẩu không đúng"); return; }
            //nếu để trống yêu cầu người dùng nhập pass để kiểm tra
            if (txtUserPassword1.Text == "") { formThongBao ThongBao = new formThongBao("Nếu không tạo mật khẩu mới \n Nhập mật khẩu để xác minh", false); return; }
            //tạo query update database
            String updateQuery = "UPDATE taikhoan Set [password] = '" + UserPass + "', Fullname='" + txtUserFullname.Text + "', Phonenumber=" + int.Parse(txtUserPhoneNum.Text) + " Where username='" + this.Username + "'";
            //gọi hàm update database
            bool result = DatabaseConnection.update(updateQuery);
            if (result) { formThongBao ThongBao = new formThongBao("Cập nhật thông tin thành công", true); }
            else { formThongBao ThongBao = new formThongBao("Xin nhập lại thông tin", false); }
        }


    }
}
