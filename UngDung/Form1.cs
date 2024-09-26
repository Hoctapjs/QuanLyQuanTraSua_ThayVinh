using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UngDung
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=LAPTOP-2IRIHD28\SQLSEVER2012;Initial Catalog=QuanLyTraSuaDB2;Persist Security Info=True;User ID=son;Password=123";




        public Form1()
        {
            InitializeComponent();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            string username = txttendangnhap.Text;
            string password = txtmatkhau.Text;
            string re_password = txtxacnhanmatkhau.Text;

            if (username.Length > 100)
            {
                MessageBox.Show("Tên người dùng không được dài quá 100 ký tự.");
                txttendangnhap.Focus();
                return;
            }

            if (password != re_password)
            {
                MessageBox.Show("Mật khẩu của bạn chưa khớp, vui lòng nhập lại!");
                txtmatkhau.Clear();
                txtxacnhanmatkhau.Clear();
                txtmatkhau.Focus();
                return;
            }

            // Tạo hash và salt cho mật khẩu
            //byte[] passwordHash, passwordSalt;
            //CreatePasswordHash(password, out passwordHash, out passwordSalt);

            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    string query = "INSERT INTO Users (Username, PasswordHash, PasswordSalt) VALUES (@Username, @PasswordHash, @PasswordSalt)";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.Parameters.AddWithValue("@Username", username);
            //    cmd.Parameters.AddWithValue("@PasswordHash", password);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();

            //    MessageBox.Show("Đăng ký thành công!");
            //}


            // giả sử thêm mới

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo LOGIN trước
                    string createLoginCommand = "EXEC CreateLogin @username, @password";
                    SqlCommand cmd = new SqlCommand(createLoginCommand, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();

                    // Tạo USER sau khi đã có LOGIN
                    string createUserCommand = "CreateUserForLogin @username, @loginname";
                    SqlCommand cmd1 = new SqlCommand(createUserCommand, connection);

                    // Thêm các tham số cho câu lệnh SQL
                    cmd1.Parameters.AddWithValue("@username", username);
                    cmd1.Parameters.AddWithValue("@loginname", username);

                    cmd1.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 15150) // Kiểm tra lỗi user đã tồn tại
                    {
                        MessageBox.Show("User đã tồn tại!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi tạo user: " + ex.Message);
                    }
                }
                finally
                {
                    connection.Close();
                }
                MessageBox.Show("Bạn đã đăng ký thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private void btn_dk_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = this;
                form1.Hide();
                ChonServer chonsv = new ChonServer();
                chonsv.ShowDialog();
                form1.Close();
            }
            catch (Exception)
            {

            }
        }
    }

}
