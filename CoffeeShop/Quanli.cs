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
    public partial class Quanli : Form
    {
        
        public Quanli()
        {
            InitializeComponent();
        }

        private void Quanli_Load(object sender, EventArgs e)
        {
            //tạo tạo event click để khởi tạo tab đầu tiên
            tabAdmin_SelectedIndexChanged("initial", e);
        }

        
        private void linkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //nếu linklabel được click trả về DialogResult và close;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kiểm tra có event có được gọi từ hàm load hay không 
            if (sender == "Initial") tabAdmin.SelectedTab = tabAdmin.TabPages["tabSanpham"];
            /* Sau đó:
            -Kiểm tra tab hiện tại để tạo usercontrol phù hợp
            -Tạo location phù hợp
            -Clear các control trên tab hiện tại nếu có
            -Add usercontrol vừa tạo */
            if (tabAdmin.SelectedTab == tabAdmin.TabPages["tabSanpham"])
            {

                UCQuanliSanpham Sanpham = new UCQuanliSanpham();
                Sanpham.Location = new Point(0, 0);
                tabSanpham.Controls.Clear();
                tabSanpham.Controls.Add(Sanpham);
            }
            else if (tabAdmin.SelectedTab == tabAdmin.TabPages["tabThongke"])
            {
                UCThongke Thongke = new UCThongke();
                Thongke.Location = new Point(0, 0);
                tabThongke.Controls.Clear();
                tabThongke.Controls.Add(Thongke);
            }
            else if (tabAdmin.SelectedTab == tabAdmin.TabPages["tabNhanvien"])
            {
                
                UCQuanliNhanvien Nhanvien = new UCQuanliNhanvien();
                Nhanvien.Location = new Point(50, 50);
                tabNhanvien.Controls.Clear();
                tabNhanvien.Controls.Add(Nhanvien);

            }
            else if (tabAdmin.SelectedTab == tabAdmin.TabPages["tabTinnhan"])
            {
                //tạo đối tượng Tinnhan với thông số của admin
                UCMessage Tinnhan = new UCMessage("admin");
                Tinnhan.Location = new Point(40, 20);

                tabTinnhan.Controls.Clear();
                tabTinnhan.Controls.Add(Tinnhan);
            }
            else if (tabAdmin.SelectedTab == tabAdmin.TabPages["tabThongtin"])
            {
                //tạo đối tượng Thongtin với thông số của admin
                UCChangeInfo Thongtin = new UCChangeInfo("admin");
                Thongtin.Location = new Point(100, 50);
                tabThongtin.Controls.Clear();
                tabThongtin.Controls.Add(Thongtin);
            }
        }



    }
}
