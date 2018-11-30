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
    public partial class UCThongke : UserControl
    {
        public UCThongke()
        {
            InitializeComponent();
        }

        private void btnSheet_Click(object sender, EventArgs e)
        {
            
            pnSheet.BringToFront();
        }


        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            //gọi hàm trả về đường dẫn tới file CSV doanhthu
            String path = DatabaseConnection.MDBtoCSV();
            formThongBao thongBao = new formThongBao("Đường dẫn đến file CSV: \n" + path,true);
        }


        private void UCThongke_Load(object sender, EventArgs e)
        {
            //đưa panel doanhthu lên đầu
            loadChart();
            pnSheet.BringToFront();
        }

        private void btnLineChart_Click(object sender, EventArgs e)
        {
            //đưa panel chart lên đầu
            loadChart();
            pnThongke.BringToFront();
        }
        private void loadChart()
        {
            //load dữ liệu vào datagridview Doanhthu
            DataTable dt = DatabaseConnection.getDoanhthu();
            dgvDoanhthu.DataSource = dt;
            int tongDoanhthu = 0;
            if (dt == null)
            {
                MessageBox.Show("Chưa có dữ liệu doanh thu");
                return;
            }
            //tính tổng doanh thu trong thág
            foreach (DataRow dr in dt.Rows)
            {
                tongDoanhthu += int.Parse(dr["Amount"].ToString());
            }
            lblDoanhthu.Text = "Tổng doanh thu là: " + tongDoanhthu.ToString() + "VND";
            //xóa tât cả các điểm trên biểu đồ nếu có
            chart1.Series["Doanhthu"].Points.Clear();
            chart2.Series[0].Points.Clear();
            //vẽ biểu đồ
            try
            {
                String ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|MyCoffeeDB.mdb;Jet OLEDB:Database Password=coffeeshoppassword;";
                OleDbConnection cn = new OleDbConnection(ConnectionString);
                cn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                String query1 = "Select * from Doanhthu;";
                String query2 = "Select * from Thongke order by SellingQuantity DESC;";
                cmd.CommandText = query1;
                OleDbDataReader dr1 = cmd.ExecuteReader();
                //biến dùng tìm doanh thu cao nhất, thấp nhất
                int max = 0;
                int min = int.MaxValue;
                String maxDate = "";
                String minDate = "";
                while (dr1.Read())
                {
                    chart1.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
                    //tìm doanh thu cao nhất, thấp nhất
                    if (int.Parse(dr1["Amount"].ToString()) > max) { max = int.Parse(dr1["Amount"].ToString()); maxDate = dr1["Time"].ToString().Substring(0, 10); }
                    if (int.Parse(dr1["Amount"].ToString()) < min) { min = int.Parse(dr1["Amount"].ToString()); minDate = dr1["Time"].ToString().Substring(0, 10); }
                    //thêm điểm vào biểu đồ đường
                    chart1.Series["Doanhthu"].Points.AddXY(dr1["Time"].ToString().Substring(0, 10), int.Parse(dr1["Amount"].ToString()) / 1000);
                }
                cn.Close();
                label1.Text = "Cao nhất: " + max.ToString() + " VND \nNgày " + maxDate;
                label2.Text = "Thấp nhất: " + min.ToString() + " VND \nNgày " + minDate;
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = query2;
                OleDbDataReader dr2 = cmd.ExecuteReader();
                int counter = 0;
                int OtherQuantity = 0;
                while (dr2.Read())
                {
                    //vẽ 6 món được bán nhiều nhất
                    if (counter >= 6) OtherQuantity += int.Parse(dr2["SellingQuantity"].ToString());
                    else chart2.Series[0].Points.AddXY(dr2["ProductName"], dr2["SellingQuantity"]);
                    counter++;
                }
                // các món còn lại thêm vào Khác
                chart2.Series[0].Points.AddXY("Khác", OtherQuantity);
                //disable nhãn trên biểu đồ tròn
                chart2.Series[0]["PieLabelStyle"] = "Disabled";
                cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
