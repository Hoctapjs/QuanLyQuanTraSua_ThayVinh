using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient;


namespace UngDung
{
    public partial class DangNhap_sql : Form
    {
        public DangNhap_sql()
        {
            InitializeComponent();
        }

        private void DangNhap_sql_Load(object sender, EventArgs e)
        {

        }

        public string ip;
        public string server_name;
        public bool ip_con;
        string connectionString;


        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_usernamesql.Text;
            string password = txt_passwordsql.Text;

            // Cấu hình chuỗi kết nối
            if (ip_con == true)
            {
                connectionString = $@"
                Data Source={ip};Initial Catalog=QuanLyTraSuaDB2;
                User ID={username};
                Password={password};";
            }
            else
            {
                connectionString = $@"
                Data Source=LAPTOP-2IRIHD28\SQLSEVER2012;Initial Catalog=QuanLyTraSuaDB2;
                User ID={username}; 
                Password={password};";
            }
            

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Đăng nhập thành công!");

                    AddNewUser(username, connectionString);
                    string userid = GetUserID(username, connectionString);
                    Login(userid, connectionString);
                    //Logout(userid, connectionString);
                    //IsUserLoggedIn(userid, connectionString);


                    // Mở form chính hoặc thực hiện hành động khác sau khi đăng nhập thành công
                    DangNhap_sql dn = this;
                    dn.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connectionString;
                    homeForm.username = username;
                    homeForm.userid = userid;
                    homeForm.ShowDialog();
                    dn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập: {ex}");
            }
        }

        public string GetUserID(string username, string connectionString1)
        {
            string connectionString = connectionString1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "EXEC LAY_USER_ID @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    return command.ExecuteScalar().ToString();
                }
            }
        }

        public void AddNewUser(string username, string connectionString1)
        {
            string connectionString = connectionString1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "EXEC THEM_USER_MOI_DANGNHAPSQL @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.ExecuteNonQuery();
                }
            }
        }

        //public void Login(string userId, string connectionString1)
        //{
        //    string connectionString = connectionString1;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        string sessionId = Guid.NewGuid().ToString();
        //        string query = "INSERT INTO UserSessions (SessionID, UserID, LoginTime, IsLoggedIn) VALUES (@SessionID, @UserID, @LoginTime, @IsLoggedIn)";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@SessionID", sessionId);
        //            command.Parameters.AddWithValue("@UserID", userId);
        //            command.Parameters.AddWithValue("@LoginTime", DateTime.Now);
        //            command.Parameters.AddWithValue("@IsLoggedIn", true);
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}

        public void Login(string userId, string connectionString1)
        {
            using (SqlConnection connection = new SqlConnection(connectionString1))
            {
                connection.Open();
                string checkQuery = "LOGIN_CHECK_QUERY_DANGNHAPSQL @UserID";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@UserID", userId);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // Update existing record
                        string updateQuery = "EXEC LOGIN_UPDATE_QUERY_DANGNHAPSQL @UserID, @IsLoggedIn";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@IsLoggedIn", true);
                            updateCommand.Parameters.AddWithValue("@UserID", userId);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Insert new record
                        //string insertQuery = "INSERT INTO UserSessions (UserID, IsLoggedIn) VALUES (@UserID, @IsLoggedIn)";
                        //using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        //{
                        //    insertCommand.Parameters.AddWithValue("@UserID", userId);
                        //    insertCommand.Parameters.AddWithValue("@IsLoggedIn", true);
                        //    insertCommand.ExecuteNonQuery();
                        //}

                        string sessionId = Guid.NewGuid().ToString();
                        string query = "EXEC LOGIN_INSERT_QUERY_DANGNHAPSQL @SessionID, @UserID, @LoginTime, @IsLoggedIn";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SessionID", sessionId);
                            command.Parameters.AddWithValue("@UserID", userId);
                            command.Parameters.AddWithValue("@LoginTime", DateTime.Now);
                            command.Parameters.AddWithValue("@IsLoggedIn", true);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }


        public void Logout(string userId, string connectionString1)
        {
            string connectionString = connectionString1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "LOGOUT_UPDATE_QUERY_DANGNHAPSQL @UserID, @IsLoggedIn ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IsLoggedIn", false);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool IsUserLoggedIn(string userId, string connectionString1)
        {
            string connectionString = connectionString1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "IsUserLoggedIn_DANGNHAPSQL @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    return (bool)command.ExecuteScalar();
                }
            }
        }


    }
}
