using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDung
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        public string connect;
        public string username;
        List<string> rowsList;


        private void sanpham_Load(object sender, EventArgs e)
        {
            lbl_username.Text = username;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            if (username == "sa")
            {
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;
            }
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM KHACH";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                }
            }

            string query_before = $@"SELECT KHACH.MAKH FROM KHACH";

            string connectionString = connect;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query_before, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Tạo một danh sách để lưu các hàng dưới dạng chuỗi
                rowsList = new List<string>();

                // Duyệt qua các hàng trong DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    // Chuyển đổi mỗi hàng thành chuỗi và thêm vào danh sách
                    string rowString = string.Join(", ", row.ItemArray);
                    rowsList.Add(rowString);
                }

                //// Hiển thị kết quả
                //foreach (var row in rowsList)
                //{
                //    cbo_danhsach_table.Items.Add(row);
                //}

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string makh = txt_ma.Text;
            string hoten = txt_ten.Text;
            string sodienthoai = txt_sodienthoai.Text;
            string email = txt_email.Text;
            string diachi = txt_diachi.Text;


            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                if (makh == row)
                {
                    MessageBox.Show($"Đã tồn tại khách hàng có mã: {makh}", "Thông báo");
                    txt_ma.Clear();
                    txt_ten.Clear();
                    txt_sodienthoai.Clear();
                    txt_email.Clear();
                    txt_diachi.Clear();
                    return;
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = $"INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI) VALUES ('{makh}', N'{hoten}', '{sodienthoai}', '{email}', N'{diachi}');";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi {ex}");
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM KHACH";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                }
            }
            txt_ma.Clear();
            txt_ten.Clear();
            txt_sodienthoai.Clear();
            txt_email.Clear();
            txt_diachi.Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string makh = txt_ma.Text;
            string hoten = txt_ten.Text;
            string sodienthoai = txt_sodienthoai.Text;
            string email = txt_email.Text;
            string diachi = txt_diachi.Text;

            if (makh.Length == 0)
            {
                MessageBox.Show($"cần mã khách hàng để xóa", "Thông báo");
                txt_ma.Clear();
                txt_ten.Clear();
                txt_sodienthoai.Clear();
                txt_email.Clear();
                txt_diachi.Clear();
                return;
            }

            //foreach (var row in rowsList)
            //{
            //    //cbo_danhsach_table.Items.Add(row);
            //    if (masp != row)
            //    {
            //        MessageBox.Show($"Không tồn tại khách hàng có mã khớp với mã cần xóa: {masp}", "Thông báo");
            //        txt_ma.Clear();
            //        txt_ten.Clear();
            //        txt_giatien.Clear();
            //        txt_trangthai.Clear();
            //        return;
            //    }
            //}

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = $"DELETE FROM KHACH WHERE MAKH='{makh}'";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bạn không thể xóa khách hàng có thông tin trong các bảng khác");
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM KHACH";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                }
            }

            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                if (makh == row)
                {
                    MessageBox.Show($"Đã xóa khách hàng có mã: {makh}", "Thông báo");
                    rowsList.Remove(row);
                    txt_ma.Clear();
                    txt_ten.Clear();
                    txt_sodienthoai.Clear();
                    txt_email.Clear();
                    txt_diachi.Clear();
                    return;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string makh = txt_ma.Text;
            string hoten = txt_ten.Text;
            string sodienthoai = txt_sodienthoai.Text;
            string email = txt_email.Text;
            string diachi = txt_diachi.Text;
            string makh_sua = txt_makhachhangsua.Text;

            //if (masp.Length == 0)
            //{
            //    MessageBox.Show($"cần mã khách hàng để xóa", "Thông báo");
            //    txt_ma.Clear();
            //    txt_ten.Clear();
            //    txt_giatien.Clear();
            //    txt_trangthai.Clear();
            //    return;
            //}

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE KHACH SET HOTEN = @hoten, SODIENTHOAI = @sodienthoai, EMAIL = @email, DIACHI = @diachi WHERE MAKH = @makhsua;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@hoten", hoten);
                        cmd.Parameters.AddWithValue("@sodienthoai", sodienthoai);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@diachi", diachi);
                        cmd.Parameters.AddWithValue("@makhsua", makh_sua);


                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật khách hàng thành công.");
                            txt_ma.Clear();
                            txt_ten.Clear();
                            txt_sodienthoai.Clear();
                            txt_email.Clear();
                            txt_diachi.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception and possibly log it
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật khách hàng. {ex}");
                    // Log the exception (not shown here)
                }
            }


            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM KHACH";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            string connectionString = connect;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Quay lại trang chủ Home!");

                    //Logout(userid, connectionString);
                    //IsUserLoggedIn(userid, connectionString);


                    // Mở form chính hoặc thực hiện hành động khác sau khi đăng nhập thành công
                    KhachHang kh = this;
                    kh.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connectionString;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    kh.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
            }
        }

        private void btn_timdon_Click(object sender, EventArgs e)
        {
            string makh = txt_ma.Text;
            if (makh.Length != 0)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        string query = $"SELECT * FROM DONHANG dh WHERE dh.MADH IN ( SELECT DONHANG.MADH FROM DONHANG JOIN KHACH k ON k.MAKH = DONHANG.MAKH WHERE k.MAKH IN ('{makh}') )";

                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi {ex}");
                    }
                }

                //using (SqlConnection connection = new SqlConnection(connect))
                //{
                //    try
                //    {
                //        connection.Open();
                //        string query = "SELECT * FROM SANPHAM";
                //        SqlCommand command = new SqlCommand(query, connection);
                //        SqlDataAdapter adapter = new SqlDataAdapter(command);
                //        DataTable dataTable = new DataTable();
                //        adapter.Fill(dataTable);

                //        dataGridView1.DataSource = dataTable;
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                //    }
                //}
            }
        }
    }
}
