using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CoffeeShop
{

    public partial class CoffeeShop : Form
    {
        //tạo biến đếm và list image để dùng cho việc thay đổi ảnh
        int counter = 1;
        List<Image> img = new List<Image>();
        public CoffeeShop()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e) //xử lí event click button đăng nhập
        {
            //kiểm tra tài khoản
            int accountType = DatabaseConnection.checkAccount(txtUsername.Text, txtPassword.Text);
            //nếu tài khoản loại 1 (admin)
            if (accountType == 1) 
            {
                this.txtPassword.Text = "";
                this.txtUsername.Text = "";     
                this.Hide();
                //tạo form admin
                Quanli admin = new Quanli();
                admin.ShowDialog();
                //kiểm tra nếu thoát bằng linklabel thì trở về form đăng nhập nếu không thoát luôn
                if (admin.DialogResult != DialogResult.Yes) this.Close(); 
                this.Show();
            }
            //nếu tài khoản loại 0 (nhân viên)
            else if (accountType == 0) {
                // tạo đối tượng nhân viên theo tên đăng nhập
                NhanVien nhanvien = new NhanVien(txtUsername.Text);
                this.txtPassword.Text = "";
                this.txtUsername.Text = "";
                this.Hide();
                nhanvien.ShowDialog();
                //kiểm tra nếu thoát bằng linklabel thì trở về form đăng nhập nếu không thoát luôn
                if (nhanvien.DialogResult != DialogResult.Yes) this.Close();
                this.Show();
            }
            //nếu khác 2 loại tài khoản trên báo lỗi đăng nhập
            else MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
        }
        //event mỗi lần đồng hồ tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            //đổi image
            pictureBox1.Image = img[counter];
            //kiểm tra biến đếm ở cuối list image không nếu có trở về đầu
            if (counter++ == 2) counter = 0;
            //đổi thời gian trên label ngày tháng
            lblDateTime.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToShortTimeString();
        }

        //event load form
        private void Form1_Load(object sender, EventArgs e)
        {
            //tạo label xem ngày tháng
            lblDateTime.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToShortTimeString();
            //add image trong resources vào list image để hiển thị
            img.Add(Properties.Resources.coffee0);
            img.Add(Properties.Resources.coffee1);
            img.Add(Properties.Resources.coffee2);
            //đồng hồ chạy
            timer1.Start();
        }
        

    }
}
