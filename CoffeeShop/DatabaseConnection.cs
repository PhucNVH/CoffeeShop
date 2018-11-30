using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.IO;
namespace CoffeeShop
{

    static class DatabaseConnection
    {
        //khai báo chuỗi kết nối database
        static String ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|MyCoffeeDB.mdb;Jet OLEDB:Database Password=coffeeshoppassword;";
        static OleDbConnection cn;
        static OleDbCommand cmd = new OleDbCommand();

        //hàm thực hiện các thao tác với database, nếu thành công trả về true, nếu lỗi trả về false
        public static bool update(string query)
        {
            if (query == "") return false;
            try
            {
                cn = new OleDbConnection(ConnectionString);
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                cn.Close();
                return false;
            }
        }

        //hàm trả về datarow thông tin của một user
        public static DataRow getAStaffInfo(String username)
        {
            cn = new OleDbConnection(ConnectionString);
            cn.Open();
            String query = "select Username,[Password],Fullname,PhoneNumber,BirthDay,Suspended from taikhoan where Username='" + username + "'";
            cmd.Connection = cn;
            cmd.CommandText = query;
            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            cn.Close();
            if (dt != null) return dt.Rows[0];
            return null;
        }
        //hàm trả về thông tin tất cả user trừ user hiện tại
        public static DataTable getStaffInfo(String currentUser = "admin")
        {
            cn.Open();
            cmd.Connection = cn;
            String query = "select Username,Fullname,PhoneNumber,Suspended,Birthday from taikhoan where not username = '" + currentUser + "'";
            DataTable dt = new DataTable();
            cmd.Connection = cn;
            cmd.CommandText = query;
            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            oda.Fill(dt);
            cn.Close();
            return dt;
        }
        //hàm kiểm tra tài khoản, nếu là admin trả về 1, nếu nhân viên trả về 0
        //nếu không có thông tin trả về -1
        public static int checkAccount(String username, String password)
        {
            try
            {

                cn = new OleDbConnection(ConnectionString);
                cn.Open();
                cmd.Connection = cn;
                password = password.Replace("'", "''");
                string command = "Select * From Taikhoan where Username='" + username + "' and Password='" + password + "';";
                cmd.CommandText = command;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    string userType = "";
                    foreach (DataRow dr in dt.Rows)
                    {
                        userType = dr["username"].ToString();
                        if (dr["Suspended"].ToString() == "True" && userType != "admin") return -1;
                    }

                    if (username == userType)
                    {
                        if (userType == "admin") return 1;
                        else return 0;
                    }
                }
                return -1;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); return -1; }
            finally
            { cn.Close(); }
        }

        //tạo tài khoản với các thông tin username,password,Birthday
        public static bool createAccount(String username, String password,String Birthday)
        {
            try
            {
                cn = new OleDbConnection(ConnectionString);
                cn.Open();
                cmd.Connection = cn;
                username = username.Replace("'", "''");
                password = password.Replace("'", "''");
                string importData = "Insert into Taikhoan (Username, [Password],BirthDay) values (" + "'" + username + "' , '" + password + "','" + Birthday +"');";
                cmd.CommandText = importData;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            { return false; }
            finally { cn.Close(); }
        }
        //overload hàm create account với  đầy đủ thông tin tài khoản
        public static bool createAccount(String username, String password, String Fullname, String Phonenum,String Birthday)
        {
            try
            {
                cn = new OleDbConnection(ConnectionString);
                cn.Open();
                cmd.Connection = cn;
                if (Phonenum == "") Phonenum = "0";
                string importData = "Insert into Taikhoan (Username, [Password], Fullname,Phonenumber,BirthDay) values (" + "'" + username + "' , '" + password + "' , '" + Fullname + "' , '" + Phonenum + "','" +Birthday+ "' ) ; " ;
                cmd.CommandText = importData;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); return false; }
            finally { cn.Close(); }
        }
        //hàm trả về datatable doanhthu
        public static DataTable getDoanhthu()
        {
            try
            {
                cn.Open();
                String query = "select * from Doanhthu";
                DataTable dt = new DataTable();
                cmd.Connection = cn;
                cmd.CommandText = query;
                OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                oda.Fill(dt);
                cn.Close();
                if (dt.Rows[0] == null) throw new Exception();
                return dt;
            }
            catch(Exception) { return null; }
        }
        //hàm trả về datatable menu
        public static DataTable getMenuInfo()
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                String query = "select * from sanpham";
                cmd.Connection = cn;
                cmd.CommandText = query;
                OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                oda.Fill(dt);
                cn.Close();
                return dt;
            }
            catch (Exception) { cn.Close(); return dt; }
        }
        //hàm trả về datarow chưa thông tin 1 sản phẩm
        public static DataRow getAProductInfo(int ID)
        {

            cn = new OleDbConnection(ConnectionString);
            cn.Open();
            String query = "select * from sanpham where ID=" + ID + "";
            cmd.Connection = cn;
            cmd.CommandText = query;
            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            cn.Close();
            if (dt != null) return dt.Rows[0];
            return null;
        }
        //hàm thêm vào doanhthu tổng tiền từ hóa đơn
        public static void addDoanhthu()
        {
            cn = new OleDbConnection(ConnectionString);
            cn.Open();
            String query = "select * from hoadon ";
            cmd.Connection = cn;
            cmd.CommandText = query;
            cmd.CommandText = query;
            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            cn.Close();
            int total = 0;
            String date = dt.Rows[0]["Time"].ToString().Substring(0, 10);
            foreach (DataRow dr in dt.Rows)
            {
                total += int.Parse(dr["Total"].ToString());

            }
            query = "insert into doanhthu ([Time],Amount) values ('" + date + "'," + total + ")";
            cn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        //trả về datatable hóa đơn
        public static DataTable getHoadonInfo()
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                String query = "select * from hoadon";
                cmd.Connection = cn;
                cmd.CommandText = query;
                OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                oda.Fill(dt);

                cn.Close();
                if(dt.Rows[0]==null) throw new Exception(); 
                return dt;
            }
            catch (Exception) { cn.Close(); return null; }
        }
        //trả về đường dẫn đến file csv
        public static String MDBtoCSV()
        {
            String path = Directory.GetCurrentDirectory() + @"\thongke.csv";
            DataTable dt = new DataTable();
            try
            {
                StringBuilder csv = new StringBuilder();
                csv.AppendLine("ID,Date,Amount");

                cn.Open();
                String query = "select * from doanhthu";
                cmd.Connection = cn;
                cmd.CommandText = query;
                OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                oda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    String newLine = string.Format("{0},{1},{2}\n", dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                    csv.AppendLine(newLine);
                }
                if (File.Exists(path)) File.Delete(path);
                File.AppendAllText(path, csv.ToString());
                cn.Close();
                return path;
            }
            catch (Exception ex) { cn.Close(); MessageBox.Show(ex.ToString()); return "Error"; }

        }

        //kiểm tra có tin nhắn mới đến không
        // nếu có trả về tất cả username người gửi
        //nếu không trả về none
        public static String isNewMessage(String receiver)
        {
            String result = "none";
            try
            {
                List<string> username = new List<string>() ; 
                cn.Open();
                String query = "select sender from Message where (receiver = '" + receiver + "' or receiver='all' ) and newMess = true";
                cmd.Connection = cn;
                cmd.CommandText = query;
                DataTable dt = new DataTable();
                OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                oda.Fill(dt);
                if (dt != null) result = "";
                foreach (DataRow dr in dt.Rows)
                {
                    string current = dr[0].ToString();
                    if(username.Contains(current)) continue;
                    result += dr[0] + "  ";
                    username.Add(dr[0].ToString());
                }
                cn.Close();
                return result;
            }
            catch (Exception ex) { cn.Close(); MessageBox.Show(ex.ToString()); return "error"; }
        }

        //trả về datatable chứa tin nhắn giữa thisUser và otherUser
        public static DataTable readMessage(String thisUser, String otherUser)
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();

                String query = "select * from Message where (sender = '" + thisUser + "' and receiver = '" + otherUser + "') or (sender = '" + otherUser + "' and receiver = '" + thisUser + "')";
                if(otherUser == "admin") query = "select * from Message where (sender = '" + thisUser + "' and receiver = 'admin') or (sender = 'admin' and receiver = '" + thisUser + "') or (sender = 'admin' and receiver = 'all')";
                if(thisUser == "admin") query = "select * from Message where (sender = '" + otherUser + "' and receiver = 'admin') or (sender = 'admin' and receiver = '" + otherUser + "') or (sender = 'admin' and receiver = 'all')";
                cmd.Connection = cn;
                cmd.CommandText = query;
                OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                oda.Fill(dt);
                cn.Close();
                if (dt != null)
                {
                    cn.Open();
                    query = "update message set newMess = false where  sender = '" + otherUser + "' and receiver = '" + thisUser + "'";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    return dt;
                }
                return dt;

            }
            catch (Exception ex) { cn.Close(); MessageBox.Show(ex.ToString()); return dt; }
        }
        public static void sendMessage(String sender, String receiver, String message)
        {
            try
            {
                cn.Open();
                //escape kí tự đặc biệt trong sql
                message = message.Replace("'", "''");
                String query = "insert into message (sender,receiver,message,newMess) values ('" + sender + "','" + receiver + "','" + @message + "', true)";
                cmd.Connection = cn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex) { cn.Close(); MessageBox.Show(ex.ToString()); }
        }

        //hàm trả về Datatable chứa thông tin khu vực từ tableInfo
        public static DataTable getZoneInfo()
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                String query = "select Distinct [zone] from tableInfo";
                cmd.Connection = cn;
                cmd.CommandText = query;
                OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                oda.Fill(dt);
                cn.Close();
                return dt;
            }
            catch (Exception ex) { cn.Close(); MessageBox.Show(ex.ToString()); return dt; }
        }
        //hàm trả về Datatable chứa thông tin bàn từ tableInfo
        public static DataTable getTableInfo(String name,bool isFull)
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                String query = "select * from tableInfo where ([zone] = '" +name+ "') and (isFull = "+isFull+")";
                cmd.Connection = cn;
                cmd.CommandText = query;
                OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                oda.Fill(dt);
                cn.Close();
                return dt;
            }
            catch (Exception ex) { cn.Close(); MessageBox.Show(ex.ToString()); return dt; }
        }

        //trả về thông tin của bàn từ table Hoadon
        public static String getBill(String name)
        {
            DataTable dt = new DataTable();
            try
            {
                String total = "0";
                String query = "select * from hoadon where (tableName = '" + name + "')";
                cmd.Connection = cn;
                cmd.CommandText = query;
                OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                oda.Fill(dt);
                total = dt.Rows[0]["Total"].ToString();
                cn.Close();
                return total;
            }
            catch (Exception ex) { cn.Close(); MessageBox.Show(ex.ToString()); return "error"; }

        }
    }
}