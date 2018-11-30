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
    public partial class UCTaoDonHang : UserControl
    {
        // tạo các thuộc tính của 1 hóa đơn
        int countID = 0;
        int tongtien = 0;
        public UCTaoDonHang(String username)
        {
            InitializeComponent();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (txtBill.Text == "") return;
            String query;
            DialogResult dgr = new DialogResult();
            dgr = MessageBox.Show("Xác nhận thanh toán", "Warning", MessageBoxButtons.OKCancel);
            //nếu đã xác nhận thanh toán
            //đưa trạng thái isFull của tableInfo về false và isPaid của hoadon về true
            if (dgr == DialogResult.OK)
            {
                query = "update hoadon set isPaid = true where tableName = '" + cbTable.SelectedValue.ToString() + "' and isPaid = false";
                DatabaseConnection.update(query);
                query = "update tableInfo set isFull = false where tableName = '" + cbTable.SelectedValue.ToString() + "'";
                DatabaseConnection.update(query);
                txtBill.Text = "";
            }
        }

        private void cbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////lấy thông tin về bàn ở Zone được chọn
            cbTable.DataSource = DatabaseConnection.getTableInfo(cbZone.SelectedValue.ToString(), true);
            cbTable.ValueMember = "TableName";
            cbTable.DisplayMember = "TableName";
            txtBill.Text = "";
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBill.Text = DatabaseConnection.getBill(cbTable.SelectedValue.ToString());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // lấy thông tin khu
            cbZone.DataSource = DatabaseConnection.getZoneInfo();
            cbZone.ValueMember = "Zone";
            cbZone.DisplayMember = "Zone";
            pnThanhToan.BringToFront();
        }

        private void btnDonhang_Click(object sender, EventArgs e)
        {
            pnDonhang.BringToFront();
        }

        private void UCTaoDonHang_Load(object sender, EventArgs e)
        {

            lvHoaDon.View = View.Details;
            newHoaDon();
        }

        private void cbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //khi chọn một index từ combobox Khu
            //lấy thông tin bàn từ khu đó đưa vào combobox Ban
            cbBan.DataSource = DatabaseConnection.getTableInfo(cbKhu.SelectedValue.ToString(), false);
            cbBan.DisplayMember = "TableName";
            cbBan.ValueMember = "TableName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra số lượng có còn đủ hay không
                if (nbSoLuong.Value > int.Parse(txtStock.Text)) { MessageBox.Show("Không đủ sản phẩm"); return; }
                countID++;
                //tính số tiền cho món vừa chọn
                int total = int.Parse(txtDiscountPrice.Text) * int.Parse((nbSoLuong.Value.ToString()).ToString());
                //thêm vào listview Hóa đơn thông tin về món vừa chọn
                string[] arrItem = { countID.ToString(), cbListMenu.GetItemText(this.cbListMenu.SelectedItem), nbSoLuong.Value.ToString(), txtDiscountPrice.Text, total.ToString() };
                ListViewItem newItem = new ListViewItem(arrItem);
                lvHoaDon.Items.Add(newItem);
                //tính tổng tất cả các món
                tongtien += total;
                lbTong.Text = "Tổng: " + tongtien.ToString();
                //giảm số lượng còn lại của món đó
                txtStock.Text = (int.Parse(txtStock.Text) - nbSoLuong.Value).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                countID--;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult dgr = new DialogResult();
            dgr = MessageBox.Show("Xác nhận đơn hàng", "Warning", MessageBoxButtons.OKCancel);
            if (dgr == DialogResult.OK)
            {
                clearHoadon(); //clear hóa đơn khi qua ngày mới
                
                sender = "thanhtoan";
                if (lvHoaDon.Items.Count != 0)
                {
                    //thêm vào table hóa đơn thông tin của hóa đơn hiện tại, set trạng trái isPaid là false
                    //set trạng thái bàn là full
                    DateTime now = DateTime.Now;
                    String query = "Insert into hoadon ([Time],Total,TableName,isPaid) values ( '" + now.ToShortDateString() + "', " + int.Parse(lbTong.Text.Substring(6)) + ",'" + cbBan.SelectedValue.ToString() + "',false)";
                    DatabaseConnection.update(query);
                    query = "Update tableInfo set isFull = true where tableName = '" + cbBan.SelectedValue.ToString() + "'";
                    DatabaseConnection.update(query);
                    //với mỗi món trong hóa đơn hiện tại
                    //trong table thống kê tăng số lượng bán ra
                    //trong table sanpham giảm số lượng còn lại
                    foreach (ListViewItem lvItems in lvHoaDon.Items)
                    {
                        String productName = lvItems.SubItems[1].Text;
                        int Quantity = int.Parse(lvItems.SubItems[2].Text);
                        query = "Update thongke set SellingQuantity = SellingQuantity + '" + Quantity + "' Where ProductName = '" + productName + "'";
                        DatabaseConnection.update(query);
                        query = "Update sanpham set Stock = Stock - '" + Quantity + "' Where ProductName = '" + productName + "'";
                        DatabaseConnection.update(query);
                    }
                    btnDonHangMoi_Click(sender, e);
                }
            }
        }

        private void btnDonHangMoi_Click(object sender, EventArgs e)
        {
            DialogResult dgr = DialogResult.OK;
            if (sender != "thanhtoan") dgr = MessageBox.Show("Bạn có muốn tạo hóa đơn mới", "Warning", MessageBoxButtons.OKCancel);
            if (dgr == DialogResult.OK)
            {
                //tạo đơn hàng mới, chỉnh sửa các thông số của listview  Hoadon
                newHoaDon();
                lbTong.Text = "Tổng: ";
                lvHoaDon.Clear();
                lvHoaDon.Columns.Add("ID", 60);
                lvHoaDon.Columns.Add("Tên sản phẩm", 120);
                lvHoaDon.Columns.Add("Số lượng", 80);
                lvHoaDon.Columns.Add("Đơn giá", 70);
                lvHoaDon.Columns.Add("Tổng", 80);
                lvHoaDon.View = View.Details;
            }
            else return;
        }
        private void clearHoadon()
        {
            //lấy thông tin từ table hoadon, doanhthu của database để kiểm tra ngày tháng
            //nếu table không có thông tin trả về null
            DataTable dtHoaDon = DatabaseConnection.getHoadonInfo();
            DataTable dtDoanhthu = DatabaseConnection.getDoanhthu();
            String Month;
            
            if (dtDoanhthu != null) Month = dtDoanhthu.Rows[0]["Time"].ToString().Substring(3, 2);
            else Month = "";
            //nếu qua tháng mới clear table doanhthu
            if (Month != DateTime.Now.ToShortDateString().Substring(3, 2) )
            {
                String query = "delete from doanhthu";
                DatabaseConnection.update(query);
            }
            //nếu table Hoadon không có dữ liệu trở về
            if (dtHoaDon == null) return;
            String Date = dtHoaDon.Rows[0]["Time"].ToString().Substring(0, 10);
            //nếu qua ngày mới đưa tổng doanh thu ngày vào table doanhthu,clear table hóa đơn
            //đưa tất cả bàn trở về trạng thái trống
            if (Date != DateTime.Today.ToShortDateString())
            {
                //gọi hàm chuyển tổng doanh thu ngày trong table hoadon vào table doanhthu
                DatabaseConnection.addDoanhthu();
                String query = "delete from hoadon";
                DatabaseConnection.update(query);
                query = "update tableInfo set isFull = false";
                DatabaseConnection.update(query);
            }
        }
        private void newHoaDon()
        {
            //lấy thông tin từ database và đưa vào các combobox
            //đưa thông số(số món,tiền) của hóa đơn về 0
            countID = 0;
            cbKhu.DataSource = DatabaseConnection.getZoneInfo();
            cbKhu.DisplayMember = "Zone";
            cbKhu.ValueMember = "Zone";
            cbListMenu.DataSource = DatabaseConnection.getMenuInfo();
            cbListMenu.DisplayMember = "ProductName";
            cbListMenu.ValueMember = "ID";
            tongtien = 0;

        }

        private void cbListMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbListMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //mỗi lần chọn tên món sẽ lấy thông tin của món đó, đưa vào các textbox
            DataRow drSanpham = DatabaseConnection.getAProductInfo(int.Parse(cbListMenu.SelectedValue.ToString()));
            txtStock.Text = drSanpham["Stock"].ToString();
            txtPrice.Text = drSanpham["Price"].ToString();
            txtDiscount.Text = drSanpham["Discount"].ToString();
            double price = double.Parse(drSanpham["Price"].ToString());
            //tính giá sau khi đã giảm
            double priceDiscount = price * (1 - double.Parse(txtDiscount.Text) / 100);
            txtDiscountPrice.Text = priceDiscount.ToString();
            //chọn giá trị số lượng mặc định là 1
            nbSoLuong.Value = 1;
        }
    }
}
