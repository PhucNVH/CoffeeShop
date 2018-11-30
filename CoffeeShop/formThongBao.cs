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
    //Form thông báo dùng hiển thị các thông báo trong các form khác
    public partial class formThongBao : Form
    {
        public formThongBao(String text,bool isPositive)
        {
            InitializeComponent();
            //kiểm tra ý nghĩa thông báo nếu isPositive==true image thông báo là tick
            //nếu không image thông báo là X
            if (isPositive) pictureBox1.Image = Properties.Resources.tick_1_;
            else pictureBox1.Image = Properties.Resources.nope_1_;
            //kiểm tra có từ "CSV" không (dùng trong form Admin, xuất file CSV)
            //để tạo textbox cho  người dùng copy đường dẫn file CSV
            //nếu không hiển thị thông báo bình thường
            if (text.Contains("CSV")) {
                TextBox tbCSV = new TextBox();
                tbCSV.Text = text.Substring(25);
                lbThongbao.Text = text.Substring(0, 25);
                tbCSV.Location = new Point(80,80);
                this.Controls.Add(tbCSV);
            }
            else lbThongbao.Text = text;
            //nếu text quá dài, thay đổi size của form
            if (text.Length > 40) this.Size = new Size(350,150);
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
