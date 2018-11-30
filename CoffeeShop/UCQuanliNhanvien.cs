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
    public partial class UCQuanliNhanvien : UserControl
    {
        public UCQuanliNhanvien()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            pnThongtinNV.BringToFront();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            pnTaoTKMoi.BringToFront();
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            
            //tạo combo box để chọn tên nhân viên cần đổi thông tin
            cbListAccount.DataSource = DatabaseConnection.getStaffInfo();
            cbListAccount.DisplayMember = "Fullname";
            cbListAccount.ValueMember = "username";
            //đưa panel Đổi thông tin lên đầu
            pnDoiThongTinTK.BringToFront();
        }

        private void UCNhanvienManager_Load(object sender, EventArgs e)
        {
            //load datagridview Nhanvien
            dgvStaff.DataSource = DatabaseConnection.getStaffInfo();
            dgvStaff.Update();
            dgvStaff.Refresh();
            
        }
        private void cbListAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chọn tên nhân viên nào thì các textbox sẽ hiển thị thông tin nhân viên đó
            DataRow dr = DatabaseConnection.getAStaffInfo(cbListAccount.SelectedValue.ToString());
            txtChangePassword.Text = dr["password"].ToString();
            txtChangeFullname.Text = dr["Fullname"].ToString();
            txtChangePhoneNum.Text = dr["Phonenumber"].ToString();
            txtViewUN.Text = dr["Username"].ToString();
            cbIsSuspended.Checked = bool.Parse(dr["Suspended"].ToString());
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //nếu button Change được click update các thông tin của nhân viên đang được chọn
            String newPass = txtChangePassword.Text;
            String newName = txtChangeFullname.Text;
            String newPhone = txtChangePhoneNum.Text;
            String birthDay = dpDoiNgaysinh.Value.ToShortDateString();
            if (newPhone == "") newPhone = "0";
            bool isSuspended = cbIsSuspended.Checked;
            String updateQuery = "UPDATE taikhoan Set [password] = '" + newPass + "', Fullname='" + newName + "', Phonenumber='" + newPhone + "', Suspended=" + isSuspended + " Where Username='" + txtViewUN.Text + "','"+ birthDay + "'";
            bool result = DatabaseConnection.update(updateQuery);
            if (result) { formThongBao ThongBao = new formThongBao("Cập nhật thông tin thành công", true); }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassword2.Text)
            {
                bool a;
                //tạo tài khoản có đầy đủ thông tin
                if (txtFullname.Text != "" || txtPhonenum.Text != "") a = DatabaseConnection.createAccount(txtUsername.Text, txtPassword.Text, txtFullname.Text, txtPhonenum.Text,dpNgaySinh.Value.ToShortDateString());
                //tạo tài khoản có chỉ có thông tin về mật khẩu, tên tài khoản
                else a = DatabaseConnection.createAccount(txtUsername.Text, txtPassword.Text,dpNgaySinh.Value.ToShortDateString());
                //kiểm tra kết quả trả về từ hàm createAccount và đưa ra thông báo xác nhận
                if (a)
                {
                    formThongBao ThongBao = new formThongBao("Tài khoản đã được tạo", true);
                    dgvStaff.DataSource = DatabaseConnection.getStaffInfo();
                    dgvStaff.Update();
                    dgvStaff.Refresh();
                    //update datagridview Staff
                }
                else { formThongBao ThongBao = new formThongBao("Tài khoản đã tồn tại, xin nhập lại thông tin tài khoản", false); }
            }
            else { formThongBao ThongBao = new formThongBao("Mật khẩu không trùng khớp", false); }
        }
    }
}
