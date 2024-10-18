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
    public partial class NguyenLieu : Form
    {
        public NguyenLieu()
        {
            InitializeComponent();
        }

        public string connect;
        public string username;
        List<string> rowsList;

        private void NguyenLieu_Load(object sender, EventArgs e)
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
                    string query = "EXEC PROC_XEM_BANG_NGUYENLIEU";
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

            string query_before = $@"EXEC PROC_LAY_MANL_TU_NGUYENLIEU";

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

        private void btn_nguyenlieu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC PROC_XEM_BANG_NGUYENLIEU";
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            string manl = txt_nguyenlieu_ma.Text;
            string tennl = txt_nguyenlieu_ten.Text;
            string dvt = txt_nguyenlieu_donvitinh.Text;
            string soluong_hientai = txt_nguyenlieu_soluonghientai.Text;
            string min_soluong = txt_nguyenlieu_soluongmin.Text;

            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                if (manl == row)
                {
                    MessageBox.Show($"Đã tồn tại nguyên liệu có mã: {manl}", "Thông báo");
                    txt_nguyenlieu_ma.Clear();
                    txt_nguyenlieu_ten.Clear();
                    txt_nguyenlieu_donvitinh.Clear();
                    txt_nguyenlieu_soluonghientai.Clear();
                    txt_nguyenlieu_soluongmin.Clear();
                    return;
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "PROC_InsertNguyenLieu @manl, @tennl, @dvt, @soluong_hientai, @min_soluong";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Truyền tham số cho thủ tục
                    cmd.Parameters.AddWithValue("@manl", manl);
                    cmd.Parameters.AddWithValue("@tennl", tennl);
                    cmd.Parameters.AddWithValue("@dvt", dvt);
                    cmd.Parameters.AddWithValue("@soluong_hientai", soluong_hientai);
                    cmd.Parameters.AddWithValue("@min_soluong", min_soluong);

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
                    string query = "EXEC PROC_XEM_BANG_NGUYENLIEU";
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
            txt_nguyenlieu_ma.Clear();
            txt_nguyenlieu_ten.Clear();
            txt_nguyenlieu_donvitinh.Clear();
            txt_nguyenlieu_soluonghientai.Clear();
            txt_nguyenlieu_soluongmin.Clear();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string manl = txt_nguyenlieu_ma.Text;
            string tennl = txt_nguyenlieu_ten.Text;
            string dvt = txt_nguyenlieu_donvitinh.Text;
            string soluong_hientai = txt_nguyenlieu_soluonghientai.Text;
            string min_soluong = txt_nguyenlieu_soluongmin.Text;

            if (manl.Length == 0)
            {
                MessageBox.Show($"cần mã nguyên liệu để xóa", "Thông báo");
                txt_nguyenlieu_ma.Clear();
                txt_nguyenlieu_ten.Clear();
                txt_nguyenlieu_donvitinh.Clear();
                txt_nguyenlieu_soluonghientai.Clear();
                txt_nguyenlieu_soluongmin.Clear();
                return;
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = $"PROC_DeleteNguyenLieu @manl";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@manl", manl);
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
                    string query = "EXEC PROC_XEM_BANG_NGUYENLIEU";
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
                if (manl == row)
                {
                    MessageBox.Show($"Đã xóa sản phẩm có mã: {manl}", "Thông báo");
                    rowsList.Remove(row);
                    txt_nguyenlieu_ma.Clear();
                    txt_nguyenlieu_ten.Clear();
                    txt_nguyenlieu_donvitinh.Clear();
                    txt_nguyenlieu_soluonghientai.Clear();
                    txt_nguyenlieu_soluongmin.Clear();
                    return;
                }
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string manl_sua = txt_nguyenlieu_ma.Text;
            string tennl = txt_nguyenlieu_ten.Text;
            string dvt = txt_nguyenlieu_donvitinh.Text;
            string soluong_hientai = txt_nguyenlieu_soluonghientai.Text;
            string min_soluong = txt_nguyenlieu_soluongmin.Text;

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC PROC_UpdateNguyenLieu @manl_sua, @tennl, @dvt, @soluong_hientai, @min_soluong ;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@manl_sua", manl_sua);
                        cmd.Parameters.AddWithValue("@tennl", tennl);
                        cmd.Parameters.AddWithValue("@dvt", dvt);
                        cmd.Parameters.AddWithValue("@soluong_hientai", soluong_hientai);
                        cmd.Parameters.AddWithValue("@min_soluong", min_soluong);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật nguyên liệu thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nguyên liệu để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception and possibly log it
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật nguyên liệu. {ex}");
                    // Log the exception (not shown here)
                }
            }


            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC PROC_XEM_BANG_NGUYENLIEU";
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

        private void btn_nguyenlieu_tim_Click(object sender, EventArgs e)
        {
            string manl = txt_nguyenlieu_ma.Text.Trim();
            string tennl = txt_nguyenlieu_ten.Text.Trim();
            string dvt = txt_nguyenlieu_donvitinh.Text.Trim();
            string soluong_hientai = txt_nguyenlieu_soluonghientai.Text.Trim();
            string min_soluong = txt_nguyenlieu_soluongmin.Text.Trim();


            if (manl.Length == 0 && tennl.Length != 0)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        string query = "SelectNguyenLieuByTen @tennl";
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@tennl", tennl);

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
            }

            if (tennl.Length == 0 && manl.Length != 0)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        string query = $"SelectNguyenLieuByMa @manl";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@manl", manl);
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
            }
            txt_nguyenlieu_ma.Clear();
            txt_nguyenlieu_ten.Clear();
            txt_nguyenlieu_donvitinh.Clear();
            txt_nguyenlieu_soluonghientai.Clear();
            txt_nguyenlieu_soluongmin.Clear();
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

                    // Mở form chính hoặc thực hiện hành động khác sau khi đăng nhập thành công
                    NguyenLieu nl = this;
                    nl.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connectionString;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    nl.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi quay lại");
            }

        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_nguyenlieu_tim_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_nguyenlieu_Click_1(object sender, EventArgs e)
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

        private void NguyenLieu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
