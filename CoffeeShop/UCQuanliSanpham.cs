using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace CoffeeShop
{

    public partial class UCQuanliSanpham : UserControl
    {
        DataTable dt = new DataTable();
        public UCQuanliSanpham()
        {
            InitializeComponent();
        }

        private void UCQuanliSanpham_Load(object sender, EventArgs e)
        {
            loadDGVSanpham();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // khi button Update  được click, delete tất cả thông tin trong table Sanpham của database
            //Sau đó thêm lại vào database thông tin sản phẩm trong datagridview
            String dropTable = "delete from sanpham;";
            DatabaseConnection.update(dropTable);
            for (int i = 0; i < dgvSanPham.RowCount - 1; i++)
            {
                String updateQuery = "insert into sanpham (ID,ProductName,Price,Type,Stock,Discount) Values  (" + dgvSanPham.Rows[i].Cells[0].Value + ",'" + dgvSanPham.Rows[i].Cells[1].Value.ToString() + "'," + dgvSanPham.Rows[i].Cells[2].Value + ",'" + dgvSanPham.Rows[i].Cells[3].Value.ToString() + "'," + dgvSanPham.Rows[i].Cells[4].Value + "," + dgvSanPham.Rows[i].Cells[5].Value + ")";
                DatabaseConnection.update(updateQuery);
            }
            formThongBao ThongBao = new formThongBao("Cập nhật thông tin sản phẩm thành công", true);
            dgvSanPham.Refresh();
        }
        public void loadDGVSanpham()
        {
            dgvSanPham.Refresh();
            lblThongbao.Text = "Cần thêm: ";
            dt = DatabaseConnection.getMenuInfo();
            dgvSanPham.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {   //kiểm tra nếu Stock=0 thì hiện thông báo
                if (dr["Stock"].ToString() == "0") lblThongbao.Text = lblThongbao.Text + dr["ProductName"].ToString() + " ";
            }
        }
    }
}
