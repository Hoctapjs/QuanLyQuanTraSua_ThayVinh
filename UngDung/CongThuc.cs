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
    public partial class CongThuc : Form
    {
        public CongThuc()
        {
            InitializeComponent();
        }

        public string connect;
        public string username;
        List<string> rowsList;

        string masp;
        string manl;
        string soluong;

        private void CongThuc_Load(object sender, EventArgs e)
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
                    string query = "EXEC PROC_XEM_BANG_CONGTHUC";
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

            string query_before = $@"EXEC PROC_LAY_MASP_TU_SP_SANPHAM";

            string connectionString = connect;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query_before, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Tạo một danh sách để lưu các hàng dưới dạng chuỗi
                rowsList = new List<string>();

                //for (int i = 0; i < rowsList.Count(); i++)
                //{
                //    string rowString = rowsList[i] /*string.Join(", ", rowsList[i])*/;
                //    rowsList.Add(rowString);
                //}

                // Duyệt qua các hàng trong DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    // Chuyển đổi mỗi hàng thành chuỗi và thêm vào danh sách
                    string rowString = string.Join(", ", row.ItemArray);
                    rowsList.Add(rowString);
                }

                cbo_congthuc_masp.DataSource = rowsList;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string manl = txt_congthuc_manl.Text;
            string soluong = txt_congthuc_soluong.Text;

            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                if (masp == row)
                {
                    MessageBox.Show($"Đã tồn tại sản phẩm có mã: {masp}", "Thông báo");

                    txt_congthuc_manl.Clear();
                    txt_congthuc_soluong.Clear();
                    return;
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "PROC_InsertCongThuc @masp, @manl, @soluong";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Truyền tham số cho thủ tục

                    cmd.Parameters.AddWithValue("@manl", manl);
                    cmd.Parameters.AddWithValue("@soluong", soluong);

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
                    string query = "EXEC PROC_XEM_BANG_CONGTHUC";
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


            txt_congthuc_manl.Clear();
            txt_congthuc_soluong.Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }
        private void btn_congthuc_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC PROC_XEM_BANG_CONGTHUC";
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
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
                    CongThuc congthuc = this;
                    congthuc.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connectionString;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    congthuc.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi quay lại");
            }
        }
        //Chưa được
        private void btn_congthuc_tim_Click(object sender, EventArgs e)
        {
            string manl = txt_congthuc_manl.Text;
            string soluong = txt_congthuc_soluong.Text;

            if (masp.Length == 0 && masp.Length != 0)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        string query = "SelectCongThucByMa @masp";
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
            }

            txt_congthuc_manl.Clear();
            txt_congthuc_soluong.Clear();
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_congthuc_Click_1(object sender, EventArgs e)
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

        private void btn_congthuc_tim_Click_1(object sender, EventArgs e)
        {

        }

        private void CongThuc_Load_1(object sender, EventArgs e)
        {

        }
    }
}
