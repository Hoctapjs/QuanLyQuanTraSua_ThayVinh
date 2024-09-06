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
        public bool ip_con;

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_usernamesql.Text;
            string password = txt_passwordsql.Text;

            // Cấu hình chuỗi kết nối
            string connectionString;
            if (ip_con == true)
            {
                connectionString = $@"
                Data Source={ip}\SQLSEVER2012;Initial Catalog=QuanLyTraSuaDB2;
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
                    // Mở form chính hoặc thực hiện hành động khác sau khi đăng nhập thành công
                    DangNhap_sql dn = this;
                    dn.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connectionString;
                    homeForm.ShowDialog();
                    dn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi đăng nhập: {ex.Message}");
            }
        }
    }
}
