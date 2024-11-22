using DocumentFormat.OpenXml.Office.Word;
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
    public partial class sanpham : Form
    {
        public sanpham()
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
                    string query = "EXEC XEM_BANG_SANPHAM";
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

            string query_before = $@"EXEC LAY_MASP_TU_SP_SANPHAM";

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
            // phương thức thêm sản phẩm

            // kiểm tra hàng đã tồn tại chưa bằng cách kiểm tra trong rowlist

            // row list sẽ được lấy từ cơ sở dữ liệu mỗi khi form được load hay xong 1 chức năng thay đổi db

            string masp = txt_sanpham_ma.Text;
            string tensp = txt_sanpham_ten.Text;
            string giatien = txt_sanpham_giatien.Text;
            string trangthai = txt_sanpham_trangthai.Text;

            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                if (masp == row)
                {
                    MessageBox.Show($"Đã tồn tại sản phẩm có mã: {masp}", "Thông báo");
                    txt_sanpham_ma.Clear();
                    txt_sanpham_ten.Clear();
                    txt_sanpham_giatien.Clear();
                    txt_sanpham_trangthai.Clear();
                    return;
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                // gọi thủ tục chứa câu lệnh insert
                try
                {
                    connection.Open();
                    string query = "InsertSanPham @masp, @tensp, @giatien, @trangthai";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Truyền tham số cho thủ tục
                    cmd.Parameters.AddWithValue("@masp", masp);
                    cmd.Parameters.AddWithValue("@tensp", tensp);
                    cmd.Parameters.AddWithValue("@giatien", giatien);
                    cmd.Parameters.AddWithValue("@trangthai", trangthai);

                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi {ex}");
                }
            }

            // load lại datagridview mỗi khi thêm thành công

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_SANPHAM";
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

            // làm mới các textbox nhập liệu
            txt_sanpham_ma.Clear();
            txt_sanpham_ten.Clear();
            txt_sanpham_giatien.Clear();
            txt_sanpham_trangthai.Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string masp = txt_sanpham_ma.Text;
            string tensp = txt_sanpham_ten.Text;
            string giatien = txt_sanpham_giatien.Text;
            string trangthai = txt_sanpham_trangthai.Text;

            if (masp.Length == 0)
            {
                MessageBox.Show($"cần mã sản phẩm để xóa", "Thông báo");
                txt_sanpham_ma.Clear();
                txt_sanpham_ten.Clear();
                txt_sanpham_giatien.Clear();
                txt_sanpham_trangthai.Clear();
                return;
            }

            //foreach (var row in rowsList)
            //{
            //    //cbo_danhsach_table.Items.Add(row);
            //    if (masp != row)
            //    {
            //        MessageBox.Show($"Không tồn tại sản phẩm có mã khớp với mã cần xóa: {masp}", "Thông báo");
            //        txt_sanpham_ma.Clear();
            //        txt_sanpham_ten.Clear();
            //        txt_sanpham_giatien.Clear();
            //        txt_sanpham_trangthai.Clear();
            //        return;
            //    }
            //}

            // gọi thủ tục chứa lệnh xóa

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = $"DeleteSanPham @masp";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@masp", masp);
                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi {ex}");
                }
            }

            // gọi thủ tục load lại datagridview

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_SANPHAM";
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

            // xóa trong list
            
            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                if (masp == row)
                {
                    MessageBox.Show($"Đã xóa sản phẩm có mã: {masp}", "Thông báo");
                    rowsList.Remove(row);
                    txt_sanpham_ma.Clear();
                    txt_sanpham_ten.Clear();
                    txt_sanpham_giatien.Clear();
                    txt_sanpham_trangthai.Clear();
                    return;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string masp = txt_sanpham_ma.Text;
            string tensp = txt_sanpham_ten.Text;
            string giatien = txt_sanpham_giatien.Text;
            string trangthai = txt_sanpham_trangthai.Text;
            string masp_sua = txt_sanpham_sua.Text;

            //if (masp.Length == 0)
            //{
            //    MessageBox.Show($"cần mã sản phẩm để xóa", "Thông báo");
            //    txt_sanpham_ma.Clear();
            //    txt_sanpham_ten.Clear();
            //    txt_sanpham_giatien.Clear();
            //    txt_sanpham_trangthai.Clear();
            //    return;
            //}

           // gọi thủ tục chứa câu lệnh update

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC UpdateSanPham @masp_sua, @tensp, @giatien, @trangthai ;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@tensp", tensp);
                        cmd.Parameters.AddWithValue("@giatien", giatien);
                        cmd.Parameters.AddWithValue("@trangthai", trangthai);
                        cmd.Parameters.AddWithValue("@masp_sua", masp_sua);

                        // thực thi câu lệnh và thông báo kết quả
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật sản phẩm thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception and possibly log it
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật sản phẩm. {ex}");
                    // Log the exception (not shown here)
                }
            }

            // gọi thủ tục làm mới datagridview

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_SANPHAM";
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
                    MessageBox.Show("Quay lại Trang Chủ Home!");

                    //Logout(userid, connectionString);
                    //IsUserLoggedIn(userid, connectionString);


                    // Mở form chính hoặc thực hiện hành động khác sau khi đăng nhập thành công
                    sanpham sp = this;
                    sp.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connectionString;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    sp.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi quay lại");
            }
        }

        private void btn_sanpham_tim_Click(object sender, EventArgs e)
        {
            string masp = txt_sanpham_ma.Text.Trim();
            string tensp = txt_sanpham_ten.Text.Trim();
            string giatien = txt_sanpham_giatien.Text.Trim();
            string trangthai = txt_sanpham_trangthai.Text.Trim();
            string makh = txt_makhachhang.Text.Trim();

            //foreach (var row in rowsList)
            //{
            //    //cbo_danhsach_table.Items.Add(row);
            //    if (masp == row)
            //    {
            //        MessageBox.Show($"Đã tồn tại sản phẩm có mã: {masp}", "Thông báo");
            //        txt_sanpham_ma.Clear();
            //        txt_sanpham_ten.Clear();
            //        txt_sanpham_giatien.Clear();
            //        txt_sanpham_trangthai.Clear();
            //        return;
            //    }
            //}


            if (masp.Length == 0 && tensp.Length != 0)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        string query = "SelectSanPhamByTen @tensp";
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@tensp", tensp);

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

            if (tensp.Length == 0 && masp.Length != 0)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        string query = $"SelectSanPhamByMa @masp";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@masp", masp);
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

            if (makh.Length != 0)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        string query = "SelectDonHangByMaKhach @makh";
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@makh", makh);
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


            txt_sanpham_ma.Clear();
            txt_sanpham_ten.Clear();
            txt_sanpham_giatien.Clear();
            txt_sanpham_trangthai.Clear();
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_SANPHAM";
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

        private void btn_mon_chuadathang_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                // phương thức dùng truy vấn lồng, truy vấn lồng được gọi từ thủ tục

                try
                {
                    connection.Open();
                    string query = "SelectSanPhamNotInChiTietDonHang";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
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

        private void btn_laytrangthaisp_Click(object sender, EventArgs e)
        {
            // gọi hàm truyền vào mã sản phẩm và nhận về trạng thái của sản phẩm đó
            string masp = txt_sanpham_ma.Text;
            using (SqlConnection connection = new SqlConnection(connect))
            {
                string query = "SELECT dbo.LayTrangThaiSanPham(@MASP) AS TrangThai";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MASP", masp);

                connection.Open();
                string result = command.ExecuteScalar().ToString();
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Không Tìm Thấy");
                }
                else
                {
                    MessageBox.Show($"Trạng thái của sản phẩm {masp} là: " + result);
                }
            }
        }

        private void btn_laygiabansp_Click(object sender, EventArgs e)
        {
            // gọi hàm truyền vào mã sản phẩm và nhận về giá bán của sản phẩm đó
            string masp = txt_sanpham_ma.Text;
            using (SqlConnection connection = new SqlConnection(connect))
            {
                string query = "SELECT dbo.LayGiaBanSanPham(@MASP) AS GiaBan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MASP", masp);

                connection.Open();
                var result = command.ExecuteScalar().ToString();
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Không Tìm Thấy");
                }
                else
                {
                    MessageBox.Show($"Giá bản của sản phẩm {masp} là: " + result);
                }
            }
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_sanpham_tim_Click_1(object sender, EventArgs e)
        {

        }

        private void sanpham_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_sanpham_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_mon_chuadathang_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hàm dùng thủ tục chứa truy vấn lồng tương quan
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC PRO_SANPHAM_GIAMAX";
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
