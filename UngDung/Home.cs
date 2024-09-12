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
using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;

namespace UngDung
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            //userid = GetUserID(username, connect);


            
        }

        public string connect;
        public string username;
        public string userid;
        private System.Windows.Forms.Timer timer;

        private async void CheckUserLoginStatus(string userid, string connect)
        {
            bool check = await IsUserLoggedIn(userid, connect);
            if (check)
            {
                // Bắt đầu Timer nếu người dùng vẫn đang đăng nhập
                timer.Start();
            }
            else
            {
                // Đăng xuất nếu người dùng không còn đăng nhập
                Dangxuattatca(userid, connect);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Dangxuattatca(userid, connect);
        }

        private async void Dangxuattatca(string userid, string connect)
        {
            bool check = await IsUserLoggedIn(userid, connect);
            if (!check)
            {
                Hide();
                //using (Main main = new Main())
                //{
                //    main.ShowDialog();
                //}
                Close();
                timer.Stop();
            }
        }

        private void Xoatatca_id_sessions(string userId, string connectionString1)
        {
            string connectionString = connectionString1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "use QuanLyTraSuaDB2; delete from Users_ID_Store; delete from UserSessions";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery(); // Thực hiện lệnh SQL
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btn_export.Enabled = false;
            btn_import.Enabled = false;
            lbl_username.Text = username;
            if (username == "sa")
            {
                btn_export.Enabled = true;
                btn_import.Enabled = true;
            }

            userid = GetUserID(username, connect);
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20000;

            // Gán sự kiện Tick cho Timer
            timer.Tick += Timer_Tick;
            timer.Start();


            // Kiểm tra trạng thái đăng nhập trước khi bắt đầu Timer
            //CheckUserLoginStatus(userid, connect);
        }

        private void btn_khach_Click(object sender, EventArgs e)
        {
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

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Bắt đầu thao tác với Sản phẩm!");
                    Home ho = this;
                    ho.Hide();
                    sanpham sp = new sanpham();
                    sp.connect = connect;
                    sp.username = username;
                    sp.ShowDialog();
                    ho.Close();
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
                    string query = "SELECT * FROM NHANVIEN";
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

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM DONHANG";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (userid == null)
            {
                MessageBox.Show("userid là null ở home");
            }
            if (connect == null)
            {
                MessageBox.Show("connect là null ở home");
            }

            Logout(userid, connect);
        }

        public string GetUserID(string username, string connectionString1)
        {
            if (connectionString1 == null)
            {
                MessageBox.Show("connectionString1 null");
                return "";
            }
            string connectionString = connectionString1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserID FROM Users_ID_Store WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    return command.ExecuteScalar().ToString();
                }
            }
        }

        public void Logout(string userId, string connectionString1)
        {

            string connectionString = connectionString1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE UserSessions SET IsLoggedIn = @IsLoggedIn WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IsLoggedIn", false);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.ExecuteNonQuery();
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM UserSessions";
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

        public async Task<bool> IsUserLoggedIn(string userId, string connectionString1)
        {
            if (string.IsNullOrEmpty(connectionString1))
            {
                throw new InvalidOperationException("The ConnectionString property has not been initialized.");
            }

            using (SqlConnection connection = new SqlConnection(connectionString1))
            {
                await connection.OpenAsync();
                string query = "SELECT IsLoggedIn FROM UserSessions WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    return (bool)await command.ExecuteScalarAsync();
                }
            }
        }


        private void btn_chitietdh_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM CHITIETDONHANG";
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

        private void btn_export_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Bắt đầu thực hiện export!");
                    Home ho = this;
                    ho.Hide();
                    export ex = new export();
                    ex.connect = connect;
                    ex.username = username;
                    ex.ShowDialog();
                    ho.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Bắt đầu thực hiện import!");
                    Home ho = this;
                    ho.Hide();
                    import im = new import();
                    im.connect = connect;
                    im.username = username;
                    im.ShowDialog();
                    ho.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
            }
        }

        private void btn_user_id_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Users_ID_Store";
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

        private void btn_phien_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM UserSessions";
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

