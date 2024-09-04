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
using System.Security.Cryptography;

namespace UngDung
{
    public partial class DangNhap : Form
    {
        private string connectionString = @"Data Source=LAPTOP-2IRIHD28\SQLSEVER2012;Initial Catalog=QuanLyTraSuaDB2;Integrated Security=True";

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string username = txttendangnhap1.Text;
            string password = txtmatkhau1.Text;

            if (LoginUser(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Chuyển hướng tới trang chính của ứng dụng
                DangNhap dn = this;
                dn.Hide();
                Home homeForm = new Home();
                homeForm.ShowDialog();
                dn.Close();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác.");
            }
        }

        private bool LoginUser(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT PasswordHash, PasswordSalt FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    byte[] storedHash = (byte[])reader["PasswordHash"];
                    byte[] storedSalt = (byte[])reader["PasswordSalt"];
                    return VerifyPasswordHash(password, storedHash, storedSalt);
                }
            }
            return false;
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(storedHash);
            }
        }
    }
}
