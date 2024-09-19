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

namespace UngDung
{
    public partial class import : Form
    {
        public import()
        {
            InitializeComponent();
        }

        public string connect;
        public string username;
        List<string> rowsList;


        private void import_Load(object sender, EventArgs e)
        {
            btn_export.Enabled = false;
            btn_import.Enabled = false;
            lbl_username.Text = username;
            if (username == "sa")
            {
                btn_export.Enabled = true;
                btn_import.Enabled = true;
            }
            string connectionString = connect;
        }

        private void btn_thoat_im_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Quay lại Home!");
                    // Mở form chính hoặc thực hiện hành động khác sau khi đăng nhập thành công
                    import im = this;
                    im.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connect;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    im.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi quay lại");
            }
        }

        private void btn_submit_import_Click(object sender, EventArgs e)
        {
            string connectionString = connect;
            string database_name = "QuanLyTraSuaDB2";
            string tableName = txt_tenbang.Text;


            string filePath = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file đã chọn
                    filePath = openFileDialog.FileName;
                }
            }

            // Đọc dữ liệu từ file XLSX
            DataTable dataTable = new DataTable();
            using (XLWorkbook workbook = new XLWorkbook(filePath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1);
                bool firstRow = true;
                foreach (IXLRow row in worksheet.Rows())
                {
                    if (firstRow)
                    {
                        foreach (IXLCell cell in row.Cells())
                        {
                            dataTable.Columns.Add(cell.Value.ToString());
                        }
                        firstRow = false;
                    }
                    else
                    {
                        dataTable.Rows.Add();
                        int i = 0;
                        foreach (IXLCell cell in row.Cells())
                        {
                            dataTable.Rows[dataTable.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                    }
                }
            }

            // Tạo câu lệnh SQL để tạo bảng
            string createTableQuery = $"CREATE TABLE {tableName} (";

            foreach (DataColumn column in dataTable.Columns)
            {
                createTableQuery += $"{column.ColumnName} NVARCHAR(MAX),";
            }

            createTableQuery = createTableQuery.TrimEnd(',') + ")";

            // Kết nối tới cơ sở dữ liệu và tạo bảng
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //// Kiểm tra nếu bảng đã tồn tại và xóa nếu cần (tùy chọn)
                //string dropTableQuery = $"IF OBJECT_ID('{tableName}', 'U') IS NOT NULL DROP TABLE {tableName}";
                //using (SqlCommand dropCommand = new SqlCommand(dropTableQuery, connection))
                //{
                //    dropCommand.ExecuteNonQuery();
                //}

                // Tạo bảng mới
                using (SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }

                // Chèn dữ liệu vào bảng vừa tạo
                foreach (DataRow row in dataTable.Rows)
                {
                    var columnNames = string.Join(", ", dataTable.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
                    var parameters = string.Join(", ", dataTable.Columns.Cast<DataColumn>().Select(c => "@" + c.ColumnName));

                    string query = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameters})";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            command.Parameters.AddWithValue("@" + column.ColumnName, row[column]);
                        }
                        command.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Dữ liệu đã được import vào cơ sở dữ liệu.");
        }
    }
}
