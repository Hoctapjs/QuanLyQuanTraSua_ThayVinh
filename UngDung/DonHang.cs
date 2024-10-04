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
    public partial class DonHang : Form
    {
        public DonHang()
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
                    string query = "EXEC XEM_VIEW_DONHANG";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                    return;
                }
            }

            string query_before = $@"SELECT DONHANG.MADH FROM DONHANG";

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
            string madh = txt_madonhang.Text;
            string makh = txt_makhachhang.Text;
            string manv = txt_manhanvien.Text;
            string ngaydonhang = txt_ngaydonhang.Text;
            //string diachi = txt_diachi.Text;


            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                if (manv == row)
                {
                    MessageBox.Show($"Đã tồn tại đơn hàng có mã: {madh}", "Thông báo");
                    txt_madonhang.Clear();
                    txt_makhachhang.Clear();
                    txt_manhanvien.Clear();
                    txt_ngaydonhang.Clear();
                    //txt_diachi.Clear();
                    return;
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = $"INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH) VALUES ('{madh}', '{makh}', '{manv}', '{ngaydonhang}');";

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
                    string query = "EXEC XEM_VIEW_DONHANG";
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
            txt_madonhang.Clear();
            txt_makhachhang.Clear();
            txt_manhanvien.Clear();
            txt_ngaydonhang.Clear();
            //txt_diachi.Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string madh = txt_madonhang.Text;
            string makh = txt_makhachhang.Text;
            string manv = txt_manhanvien.Text;
            string ngaydonhang = txt_ngaydonhang.Text;
            //string diachi = txt_diachi.Text;

            if (madh.Length == 0)
            {
                MessageBox.Show($"cần mã đơn hàng để xóa", "Thông báo");
                txt_madonhang.Clear();
                txt_makhachhang.Clear();
                txt_manhanvien.Clear();
                txt_ngaydonhang.Clear();
                //txt_diachi.Clear();
                return;
            }

            //foreach (var row in rowsList)
            //{
            //    //cbo_danhsach_table.Items.Add(row);
            //    if (masp != row)
            //    {
            //        MessageBox.Show($"Không tồn tại đơn hàng có mã khớp với mã cần xóa: {masp}", "Thông báo");
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
                    string query = $"DELETE FROM DONHANG WHERE MADH='{madh}'";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bạn không thể xóa đơn hàng có thông tin trong các bảng khác");
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_VIEW_DONHANG";
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
                if (madh == row)
                {
                    MessageBox.Show($"Đã xóa đơn hàng có mã: {madh}", "Thông báo");
                    rowsList.Remove(row);
                    txt_madonhang.Clear();
                    txt_makhachhang.Clear();
                    txt_manhanvien.Clear();
                    txt_ngaydonhang.Clear();
                    //txt_diachi.Clear();
                    return;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string madh = txt_madonhang.Text;
            string makh = txt_makhachhang.Text;
            string manv = txt_manhanvien.Text;
            string ngaydonhang = txt_ngaydonhang.Text;
            //string diachi = txt_diachi.Text;
            string madh_sua = txt_madonhangmuonsua.Text;

            //if (masp.Length == 0)
            //{
            //    MessageBox.Show($"cần mã đơn hàng để xóa", "Thông báo");
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
                    string query = "UPDATE DONHANG SET MAKH = @makh, MANV = @manv, NGAYDH = @ngaydonhang WHERE MADH = @madhsua;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@makh", makh);
                        cmd.Parameters.AddWithValue("@manv", manv);
                        cmd.Parameters.AddWithValue("@ngaydonhang", ngaydonhang);
                        //cmd.Parameters.AddWithValue("@diachi", diachi);
                        cmd.Parameters.AddWithValue("@madhsua", madh_sua);


                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật đơn hàng thành công.");
                            txt_madonhang.Clear();
                            txt_makhachhang.Clear();
                            txt_manhanvien.Clear();
                            txt_ngaydonhang.Clear();
                            //txt_diachi.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy đơn hàng để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception and possibly log it
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật đơn hàng. {ex}");
                    // Log the exception (not shown here)
                }
            }


            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_VIEW_DONHANG";
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
                    DonHang dh = this;
                    dh.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connectionString;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    dh.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
            }
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_VIEW_DONHANG";
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
    }
}
