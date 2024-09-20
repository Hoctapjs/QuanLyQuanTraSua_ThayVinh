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
    public partial class ChiTietDonHang : Form
    {
        public ChiTietDonHang()
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
                    string query = "EXEC XEM_VIEW_CHITIETDONHANG";
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

            string query_before = $@"SELECT MADH, MASP FROM V_CHITIETDONHANG";

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
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string madh = txt_madonhang.Text;
            string masp = txt_masanpham.Text;
            string manv = txt_manhanvien.Text;
            string soluong = txt_soluong.Text;
            int soluong_num = int.Parse(soluong);
            //string diachi = txt_diachi.Text;


            foreach (var row in rowsList)
            {
                // Tách các giá trị trong hàng
                var values = row.Split(", ");
                if (values[0] == madh && values[1] == masp)
                {
                    MessageBox.Show($"Đã tồn tại đơn hàng có mã: {madh} và mã sản phẩm: {masp}", "Thông báo");
                    txt_madonhang.Clear();
                    txt_masanpham.Clear();
                    txt_manhanvien.Clear();
                    txt_soluong.Clear();
                    return;
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = $"INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG) VALUES ('{madh}', '{masp}', '{manv}', '{soluong_num}');";

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
                    string query = "EXEC XEM_VIEW_CHITIETDONHANG";
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
            txt_masanpham.Clear();
            txt_manhanvien.Clear();
            txt_soluong.Clear();
            //txt_diachi.Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string madh = txt_madonhang.Text;
            string masp = txt_masanpham.Text;
            string manv = txt_manhanvien.Text;
            string soluong = txt_soluong.Text;
            //string diachi = txt_diachi.Text;

            if (madh.Length == 0 && masp.Length == 0)
            {
                MessageBox.Show($"cần mã đơn hàng và mã sản phẩm để xóa", "Thông báo");
                txt_madonhang.Clear();
                txt_masanpham.Clear();
                txt_manhanvien.Clear();
                txt_soluong.Clear();
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
                    string query = $"DELETE FROM CHITIETDONHANG WHERE MADH='{madh}' AND MASP='{masp}'";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bạn không thể xóa chi tiết đơn hàng có thông tin trong các bảng khác");
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_VIEW_CHITIETDONHANG";
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

            string query_before = $@"SELECT MADH, MASP FROM V_CHITIETDONHANG";

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
            }

            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                var values = row.Split(", ");
                if (values[0] == madh && values[1] == masp)
                {
                    MessageBox.Show($"Đã xóa đơn hàng có mã: {madh} và mã sản phẩm: {masp}", "Thông báo");
                    txt_madonhang.Clear();
                    txt_masanpham.Clear();
                    txt_manhanvien.Clear();
                    txt_soluong.Clear();
                    return;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string madh = txt_madonhang.Text;
            string makh = txt_masanpham.Text;
            string manv = txt_manhanvien.Text;
            string soluong = txt_soluong.Text;
            int soluong_num = int.Parse(soluong);
            //string diachi = txt_diachi.Text;
            string madh_sua = txt_madonhangmuonsua.Text;
            string masp_sua = txt_masanphammuonsua.Text;


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
                    string query = "UPDATE CHITIETDONHANG SET MANV = @manv, SOLUONG = @soluong WHERE MADH = @madhsua AND MASP = @maspsua;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@madhsua", madh_sua);
                        cmd.Parameters.AddWithValue("@maspsua", masp_sua);
                        cmd.Parameters.AddWithValue("@manv", manv);
                        //cmd.Parameters.AddWithValue("@diachi", diachi);
                        cmd.Parameters.AddWithValue("@soluong", soluong_num);


                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật đơn hàng thành công.");
                            txt_madonhang.Clear();
                            txt_masanpham.Clear();
                            txt_manhanvien.Clear();
                            txt_soluong.Clear();
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
                    string query = "EXEC XEM_VIEW_CHITIETDONHANG";
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
                    ChiTietDonHang ctdh = this;
                    ctdh.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connectionString;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    ctdh.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
            }
        }

        private void btn_chitietdonhang_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_VIEW_CHITIETDONHANG";
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
