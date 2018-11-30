using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class NhanVien : Form
    {
        String nhanvienUsername;
        public NhanVien(String username)
        {
            // khởi tạo form với username được truyền từ form đăng nhập
            this.nhanvienUsername = username;
            InitializeComponent();
            
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            //tạo tạo event click để khởi tạo tab đầu tiên
            tabNhanvien_SelectedIndexChanged("initial", e);
            lblWelcome.Text += nhanvienUsername;
        }
        private void tabNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kiểm tra có event có được gọi từ hàm load hay không, nếu có khởi tạo tabThanhtoan
            if (sender == "Initial") tabNhanvien.SelectedTab = tabNhanvien.TabPages["tabThanhtoan"];
            /* Sau đó:
            -Kiểm tra tab hiện tại để tạo usercontrol phù hợp
            -Tạo location phù hợp
            -Clear các control trên tab hiện tại nếu có
            -Add usercontrol vừa tạo */
            if (tabNhanvien.SelectedTab == tabNhanvien.TabPages["tabThanhtoan"])
            {
                
                UCTaoDonHang Donhang = new UCTaoDonHang(nhanvienUsername);
                Donhang.Location = new Point(0, 0);
                tabThanhtoan.Controls.Clear();
                tabThanhtoan.Controls.Add(Donhang);
            }
            else if (tabNhanvien.SelectedTab == tabNhanvien.TabPages["tabTinnhan"])
            {
               
                UCMessage Tinnhan = new UCMessage(nhanvienUsername);
                Tinnhan.Location = new Point(100, 0);
                Tinnhan.BringToFront();
                tabTinnhan.Controls.Clear();
                tabTinnhan.Controls.Add(Tinnhan);

            }
            else if (tabNhanvien.SelectedTab == tabNhanvien.TabPages["tabThongtin"])
            {
                UCChangeInfo Thongtin = new UCChangeInfo(nhanvienUsername);
                Thongtin.Location = new Point(100, 50);
                tabThongtin.Controls.Clear();
                tabThongtin.Controls.Add(Thongtin);
            }
        }

        private void linkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //nếu linklabel được click trả về DialogResult và close;
            this.DialogResult=DialogResult.Yes;
            this.Close();
        }
    }
}