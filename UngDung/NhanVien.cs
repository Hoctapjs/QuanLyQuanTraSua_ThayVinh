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
    public partial class NhanVien : Form
    {
        public NhanVien()
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
                    string query = "EXEC XEM_BANG_NHANVIEN";
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

            string query_before = $@"SELECT NHANVIEN.MANV FROM NHANVIEN";

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
            string manv = txt_ma.Text;
            string hoten = txt_ten.Text;
            string sodienthoai = txt_sodienthoai.Text;
            string gioitinh = txt_gioitinh.Text;
            string diachi = txt_diachi.Text;


            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                if (manv == row)
                {
                    MessageBox.Show($"Đã tồn tại nhân viên có mã: {manv}", "Thông báo");
                    txt_ma.Clear();
                    txt_ten.Clear();
                    txt_sodienthoai.Clear();
                    txt_gioitinh.Clear();
                    txt_diachi.Clear();
                    return;
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = $"INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI) VALUES ('{manv}', N'{hoten}', '{gioitinh}', '{diachi}', N'{sodienthoai}');";

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
                    string query = "EXEC XEM_BANG_NHANVIEN";
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
            txt_ma.Clear();
            txt_ten.Clear();
            txt_sodienthoai.Clear();
            txt_gioitinh.Clear();
            txt_diachi.Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string manv = txt_ma.Text;
            string hoten = txt_ten.Text;
            string sodienthoai = txt_sodienthoai.Text;
            string gioitinh = txt_gioitinh.Text;
            string diachi = txt_diachi.Text;

            if (manv.Length == 0)
            {
                MessageBox.Show($"cần mã nhân viên để xóa", "Thông báo");
                txt_ma.Clear();
                txt_ten.Clear();
                txt_sodienthoai.Clear();
                txt_gioitinh.Clear();
                txt_diachi.Clear();
                return;
            }

            //foreach (var row in rowsList)
            //{
            //    //cbo_danhsach_table.Items.Add(row);
            //    if (masp != row)
            //    {
            //        MessageBox.Show($"Không tồn tại nhân viên có mã khớp với mã cần xóa: {masp}", "Thông báo");
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
                    string query = $"DELETE FROM NHANVIEN WHERE MAKH='{manv}'";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bạn không thể xóa nhân viên có thông tin trong các bảng khác");
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_NHANVIEN";
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

            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                if (manv == row)
                {
                    MessageBox.Show($"Đã xóa nhân viên có mã: {manv}", "Thông báo");
                    rowsList.Remove(row);
                    txt_ma.Clear();
                    txt_ten.Clear();
                    txt_sodienthoai.Clear();
                    txt_gioitinh.Clear();
                    txt_diachi.Clear();
                    return;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string manv = txt_ma.Text;
            string hoten = txt_ten.Text;
            string sodienthoai = txt_sodienthoai.Text;
            string gioitinh = txt_gioitinh.Text;
            string diachi = txt_diachi.Text;
            string manv_sua = txt_manhanviensua.Text;

            //if (masp.Length == 0)
            //{
            //    MessageBox.Show($"cần mã nhân viên để xóa", "Thông báo");
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
                    string query = "UPDATE NHANVIEN SET HOTEN = @hoten, SODIENTHOAI = @sodienthoai, GIOITINH = @gioitinh, DIACHI = @diachi WHERE MANV = @manvsua;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@hoten", hoten);
                        cmd.Parameters.AddWithValue("@sodienthoai", sodienthoai);
                        cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                        cmd.Parameters.AddWithValue("@diachi", diachi);
                        cmd.Parameters.AddWithValue("@manvsua", manv_sua);


                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật nhân viên thành công.");
                            txt_ma.Clear();
                            txt_ten.Clear();
                            txt_sodienthoai.Clear();
                            txt_gioitinh.Clear();
                            txt_diachi.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception and possibly log it
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật nhân viên. {ex}");
                    // Log the exception (not shown here)
                }
            }


            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_NHANVIEN";
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
                    NhanVien nv = this;
                    nv.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connectionString;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    nv.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
            }
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_NHANVIEN";
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
        }
    }
}
