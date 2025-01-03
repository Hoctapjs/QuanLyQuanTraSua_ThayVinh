﻿using System;
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
            RegisterFormClosedEvent();


            //userid = GetUserID(username, connect);



        }

        private void RegisterFormClosedEvent()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.FormClosed += new FormClosedEventHandler(Home_FormClosed);
                }
            }
        }

        private bool AreAllFormsClosed()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this && form.Visible)
                {
                    return false;
                }
            }
            return true;
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (AreAllFormsClosed())
            {
                // Hiển thị form mong muốn khi tất cả các form khác đã đóng
                Main main = new Main();
                main.ShowDialog();

            }
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

        //private void Xoatatca_id_sessions(string userId, string connectionString1)
        //{
        //    string connectionString = connectionString1;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        string query = "use QuanLyTraSuaDB2; delete from Users_ID_Store; delete from UserSessions";

        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.ExecuteNonQuery(); // Thực hiện lệnh SQL
        //        }
        //    }
        //}

        private void Home_Load(object sender, EventArgs e)
        {
            btn_export.Visible = false;
            btn_import.Visible = false;
            btn_capnhat_view.Visible = false;
            btn_user_id.Visible = false;
            btn_phien.Visible = false;
            btn_sanpham.Visible = false;
            btn_nhanvien.Visible = false;
            btn_congthuc.Visible = false;
            btn_nguyenlieu.Visible = false;
            btn_phanquyen.Visible = false;
            lbl_username.Text = username;
            if (username == "sa")
            {
                btn_export.Visible = true;
                btn_import.Visible = true;
                btn_capnhat_view.Visible = true;
                btn_user_id.Visible = true;
                btn_phien.Visible = true;
                btn_sanpham.Visible = true;
                btn_nhanvien.Visible = true;
                btn_congthuc.Visible = true;
                btn_nguyenlieu.Visible = true;
                btn_phanquyen.Visible = true;
            }

            userid = GetUserID(username, connect);
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000;

            // Gán sự kiện Tick cho Timer
            timer.Tick += Timer_Tick;
            timer.Start();


            // Kiểm tra trạng thái đăng nhập trước khi bắt đầu Timer
            //CheckUserLoginStatus(userid, connect);
        }

        private void btn_khach_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Bắt đầu thao tác với Khách hàng!");
                    Home ho = this;
                    ho.Hide();
                    KhachHang kh = new KhachHang();
                    kh.connect = connect;
                    kh.username = username;
                    kh.ShowDialog();
                    ho.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
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
            //using (SqlConnection connection = new SqlConnection(connect))
            //{
            //    try
            //    {
            //        connection.Open();
            //        string query = "SELECT * FROM NHANVIEN";
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

            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Bắt đầu thao tác với Nhân viên!");
                    Home ho = this;
                    ho.Hide();
                    NhanVien nv = new NhanVien();
                    nv.connect = connect;
                    nv.username = username;
                    nv.ShowDialog();
                    ho.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
            }
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(connect))
            //{
            //    try
            //    {
            //        connection.Open();
            //        string query = "SELECT * FROM DONHANG";
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

            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Bắt đầu thao tác với Đơn Hàng!");
                    Home ho = this;
                    ho.Hide();
                    DonHang dh = new DonHang();
                    dh.connect = connect;
                    dh.username = username;
                    dh.ShowDialog();
                    ho.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
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
                string query = "EXEC sp_GetUserIDByUsername @Username;";
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
                string query = "EXEC sp_UpdateUserSessionStatus @IsLoggedIn, @UserID;";
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
                    string query = "EXEC sp_GetAllUserSessions;";
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
                string query = "EXEC sp_GetIsLoggedInByUserID @UserID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    return (bool)await command.ExecuteScalarAsync();
                }
            }
        }


        private void btn_chitietdh_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(connect))
            //{
            //    try
            //    {
            //        connection.Open();
            //        string query = "SELECT * FROM CHITIETDONHANG";
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

            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Bắt đầu thao tác với Chi tiết đơn hàng!");
                    Home ho = this;
                    ho.Hide();
                    ChiTietDonHang ctdh = new ChiTietDonHang();
                    ctdh.connect = connect;
                    ctdh.username = username;
                    ctdh.ShowDialog();
                    ho.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
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
                    string query = "EXEC sp_GetAllUsersIDStore;";
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
                    string query = "EXEC sp_GetAllUserSessions;";
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

        private void btn_DangXuat_Click(object sender, EventArgs e)
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

        private void btn_DangXuat_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_sanpham_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_khach_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_chitietdh_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_import_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_phien_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_nhanvien_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_hoadon_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_export_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_user_id_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_capnhat_view_Click(object sender, EventArgs e)
        {

        }

        private void btn_congthuc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Bắt đầu thao tác với Công Thức!");
                    Home ho = this;
                    ho.Hide();
                    CongThuc ct = new CongThuc();
                    ct.connect = connect;
                    ct.username = username;
                    ct.ShowDialog();
                    ho.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
            }
        }

        private void btn_nguyenlieu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Bắt đầu thao tác với Nguyên Liệu!");
                    Home ho = this;
                    ho.Hide();
                    NguyenLieu nl = new NguyenLieu();
                    nl.connect = connect;
                    nl.username = username;
                    nl.ShowDialog();
                    ho.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
            }
        }

        private void Home_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_phanquyen_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Bắt đầu thao tác với Phân Quyền!");
                    Home ho = this;
                    ho.Hide();
                    PhanQuyen pq = new PhanQuyen();
                    pq.connect = connect;
                    pq.username = username;
                    pq.ShowDialog();
                    ho.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập");
            }
        }
    }
}

