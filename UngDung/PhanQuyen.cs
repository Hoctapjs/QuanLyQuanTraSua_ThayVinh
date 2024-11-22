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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UngDung
{
    public partial class PhanQuyen : Form
    {
        public PhanQuyen()
        {
            InitializeComponent();
        }

        public string connect;
        public string username;
        List<string> rowsList;


        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            string query = "EXEC sp_GetQuyenSQL";

            using (SqlConnection conn = new SqlConnection(connect))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();

                // Nạp dữ liệu vào DataSet
                adapter.Fill(ds, "Permissions");

                // Thiết lập DataSource cho ComboBox
                cbo_quyen.DataSource = ds.Tables["Permissions"];
                cbo_quyen.DisplayMember = "MoTa";   // Cột hiển thị
                cbo_quyen.ValueMember = "MaQuyen";  // Giá trị thực

                // Mở tùy chọn chọn item đầu tiên nếu cần
                if (cbo_quyen.Items.Count > 0)
                {
                    cbo_quyen.SelectedIndex = 0;
                }
            }

            string query1 = "EXEC sp_GetDatabasePrincipals;";

            using (SqlConnection conn = new SqlConnection(connect))
            {
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, conn);
                DataSet ds1 = new DataSet();

                // Nạp dữ liệu vào DataSet
                adapter1.Fill(ds1, "Name");

                // Thiết lập DataSource cho ComboBox
                cbo_username.DataSource = ds1.Tables["Name"];
                cbo_username.DisplayMember = "name";   // Cột hiển thị
                cbo_username.ValueMember = "name";  // Giá trị thực

                // Mở tùy chọn chọn item đầu tiên nếu cần
                if (cbo_username.Items.Count > 0)
                {
                    cbo_username.SelectedIndex = 0;
                }
            }

            //string query2 = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'QuanLyTraSuaDB2';";

            //using (SqlConnection conn = new SqlConnection(connect))
            //{
            //    SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);
            //    DataSet ds2 = new DataSet();

            //    // Nạp dữ liệu vào DataSet
            //    adapter2.Fill(ds2, "Table");

            //    // Thiết lập DataSource cho ComboBox
            //    cbo_role.DataSource = ds2.Tables["Table"];
            //    cbo_role.DisplayMember = "TABLE_NAME";   // Cột hiển thị
            //    cbo_role.ValueMember = "TABLE_NAME";  // Giá trị thực

            //    // Mở tùy chọn chọn item đầu tiên nếu cần
            //    if (cbo_role.Items.Count > 0)
            //    {
            //        cbo_role.SelectedIndex = 0;
            //    }
            //}

            string query3 = "EXEC sp_GetRoleNames;";

            using (SqlConnection conn = new SqlConnection(connect))
            {
                SqlDataAdapter adapter3 = new SqlDataAdapter(query3, conn);
                DataSet ds3 = new DataSet();

                // Nạp dữ liệu vào DataSet
                adapter3.Fill(ds3, "role");

                // Thiết lập DataSource cho ComboBox
                cbo_role.DataSource = ds3.Tables["role"];
                cbo_role.DisplayMember = "RoleName";   // Cột hiển thị
                cbo_role.ValueMember = "RoleName";  // Giá trị thực

                // Mở tùy chọn chọn item đầu tiên nếu cần
                if (cbo_role.Items.Count > 0)
                {
                    cbo_role.SelectedIndex = 0;
                }
            }
        }

        private void btn_capquyen_Click(object sender, EventArgs e)
        {
            string query = "EXEC sp_GetLenhSQLByMaQuyen @MaQuyen";
            int maquyen = int.Parse(cbo_quyen.SelectedValue.ToString());
            string username = cbo_username.SelectedValue.ToString();
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                // Lấy câu lệnh SQL mẫu
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaQuyen", maquyen);
                string sqlTemplate = (string)cmd.ExecuteScalar();

                // Thay thế @username trong câu lệnh
                string sqlCommand = sqlTemplate.Replace("@username", username);

                // Thực thi câu lệnh SQL
                SqlCommand grantCmd = new SqlCommand(sqlCommand, conn);
                grantCmd.ExecuteNonQuery();

                MessageBox.Show("Bạn đã cấp phát quyền thành công");
                XemQuyen();
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

                    // Mở form chính hoặc thực hiện hành động khác sau khi đăng nhập thành công
                    PhanQuyen pq = this;
                    pq.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connectionString;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    pq.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi quay lại");
            }
        }

        private void btn_thuhoiquyen_Click(object sender, EventArgs e)
        {
            string query = "EXEC sp_GetLenhREVOKEByMaQuyen @MaQuyen;";
            int maquyen = int.Parse(cbo_quyen.SelectedValue.ToString());
            string username = cbo_username.SelectedValue.ToString();
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                // Lấy câu lệnh SQL mẫu
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaQuyen", maquyen);
                string sqlTemplate = (string)cmd.ExecuteScalar();

                // Thay thế @username trong câu lệnh
                string sqlCommand = sqlTemplate.Replace("@username", username);

                // Thực thi câu lệnh SQL
                SqlCommand grantCmd = new SqlCommand(sqlCommand, conn);
                grantCmd.ExecuteNonQuery();

                MessageBox.Show("Bạn đã thu hồi quyền thành công");
                XemQuyen();
            }
        }

        private void btn_xemquyen_Click(object sender, EventArgs e)
        {
            XemQuyen();
        }

        private void XemQuyen()
        {
            string query = "EXEC sp_GetUserPermissions @user;";
            int maquyen = int.Parse(cbo_quyen.SelectedValue.ToString());
            string username = cbo_username.SelectedValue.ToString();
            string table = cbo_role.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(connect))
            {
                SqlDataAdapter adapter2 = new SqlDataAdapter(query, conn);
                adapter2.SelectCommand.Parameters.AddWithValue("@user", username);
                DataSet ds2 = new DataSet();

                // Nạp dữ liệu vào DataSet
                adapter2.Fill(ds2, "quyen");

                // Thiết lập DataSource cho ComboBox
                dataGridView1.DataSource = ds2.Tables["quyen"];
            }
        }

        private void XemRole()
        {
            int maquyen = int.Parse(cbo_quyen.SelectedValue.ToString());
            string username = cbo_username.SelectedValue.ToString();
            string rolename = cbo_role.SelectedValue.ToString();

            string query = $"EXEC sp_GetRolePermissions '{rolename}';";

            

            using (SqlConnection conn = new SqlConnection(connect))
            {
                SqlDataAdapter adapter2 = new SqlDataAdapter(query, conn);
                //adapter2.SelectCommand.Parameters.AddWithValue("@user", username);
                DataSet ds2 = new DataSet();

                // Nạp dữ liệu vào DataSet
                adapter2.Fill(ds2, "role");

                // Thiết lập DataSource cho ComboBox
                dataGridView1.DataSource = ds2.Tables["role"];
            }
        }

        private void XemNguoiDungTrongRole()
        {
            int maquyen = int.Parse(cbo_quyen.SelectedValue.ToString());
            string username = cbo_username.SelectedValue.ToString();
            string rolename = cbo_role.SelectedValue.ToString();
            string query = $"EXEC sp_GetUsersByRole '{rolename}'";

            using (SqlConnection conn = new SqlConnection(connect))
            {
                SqlDataAdapter adapter2 = new SqlDataAdapter(query, conn);
                //adapter2.SelectCommand.Parameters.AddWithValue("@user", username);
                DataSet ds2 = new DataSet();

                // Nạp dữ liệu vào DataSet
                adapter2.Fill(ds2, "roleuser");

                // Thiết lập DataSource cho ComboBox
                dataGridView1.DataSource = ds2.Tables["roleuser"];
            }
        }

        private void btn_xemrole_Click(object sender, EventArgs e)
        {
            XemRole();
        }

        private void btn_tao_role_Click(object sender, EventArgs e)
        {
            int maquyen = int.Parse(cbo_quyen.SelectedValue.ToString());
            string rolename = txt_rolename.Text.ToString();
            string query = $"EXEC sp_CreateRole {rolename};";
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                // Lấy câu lệnh SQL mẫu
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Bạn đã tạo role {rolename} thành công");
                XemRole();
            }
        }

        private void btn_themuser_role_Click(object sender, EventArgs e)
        {
            int maquyen = int.Parse(cbo_quyen.SelectedValue.ToString());
            string username = cbo_username.SelectedValue.ToString();
            string rolename = cbo_role.SelectedValue.ToString();
            string query = $"EXEC sp_AddMemberToRole {rolename}, {username};";
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                // Lấy câu lệnh SQL mẫu
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Bạn đã thêm người dùng {username} vào Role: {rolename} thành công");
                XemNguoiDungTrongRole();
            }
        }

        private void btn_xoauser_role_Click(object sender, EventArgs e)
        {
            int maquyen = int.Parse(cbo_quyen.SelectedValue.ToString());
            string username = cbo_username.SelectedValue.ToString();
            string rolename = cbo_role.SelectedValue.ToString();
            string query = $"EXEC sp_RemoveMemberFromRole {rolename}, {username};";
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                // Lấy câu lệnh SQL mẫu
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Bạn đã xóa người dùng {username} khỏi Role: {rolename} thành công");
                XemNguoiDungTrongRole();
            }
        }

        private void btn_xem_user_trong_role_Click(object sender, EventArgs e)
        {
            XemNguoiDungTrongRole();
        }

        private void btn_capquyen_role_Click(object sender, EventArgs e)
        {
            string query = "EXEC sp_GetLenhSQLByMaQuyen @MaQuyen";
            string tenquyen = cbo_quyen.Text.ToString();

            int maquyen = int.Parse(cbo_quyen.SelectedValue.ToString());
            string username = cbo_username.SelectedValue.ToString();
            string roleid = cbo_role.SelectedValue.ToString();
            string rolename = cbo_role.Text.ToString();
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                // Lấy câu lệnh SQL mẫu
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaQuyen", maquyen);
                string sqlTemplate = (string)cmd.ExecuteScalar();

                // Thay thế @username trong câu lệnh
                string sqlCommand = sqlTemplate.Replace("@username", roleid);

                // Thực thi câu lệnh SQL
                SqlCommand grantCmd = new SqlCommand(sqlCommand, conn);
                grantCmd.ExecuteNonQuery();

                MessageBox.Show($"Bạn đã cấp quyền {tenquyen} cho role {rolename} thành công");
                XemRole();
            }
        }

        private void btn_thuhoiquyen_role_Click(object sender, EventArgs e)
        {
            string query = "EXEC sp_GetLenhREVOKEByMaQuyen @MaQuyen;";
            string tenquyen = cbo_quyen.Text.ToString();
            int maquyen = int.Parse(cbo_quyen.SelectedValue.ToString());
            string userid = cbo_username.SelectedValue.ToString();
            string roleid = cbo_role.SelectedValue.ToString();
            string rolename = cbo_role.Text.ToString();
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                // Lấy câu lệnh SQL mẫu
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaQuyen", maquyen);
                string sqlTemplate = (string)cmd.ExecuteScalar();

                // Thay thế @username trong câu lệnh
                string sqlCommand = sqlTemplate.Replace("@username", roleid);

                // Thực thi câu lệnh SQL
                SqlCommand grantCmd = new SqlCommand(sqlCommand, conn);
                grantCmd.ExecuteNonQuery();

                MessageBox.Show($"Bạn đã thu hồi quyền {tenquyen} cho role {rolename} thành công");
                XemRole();
            }
        }
    }
}
