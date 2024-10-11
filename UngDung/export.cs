using ClosedXML.Excel;
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
    public partial class export : Form
    {
        public export()
        {
            InitializeComponent();
        }

        public string connect;
        public string username;
        List<string> rowsList;

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    MessageBox.Show("Quay lại Home!");
                    // Mở form chính hoặc thực hiện hành động khác sau khi đăng nhập thành công
                    export ex = this;
                    ex.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connect;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    ex.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi quay lại");
            }
        }

        private void export_Load(object sender, EventArgs e)
        {
            btn_export.Enabled = false;
            btn_import.Enabled = false;
            btn_submit_export_all.Visible = false;
            btn_chitietdh.Enabled = false;
            btn_hoadon.Enabled = false;
            btn_khach.Enabled = false;
            btn_nhanvien.Enabled = false;
            btn_sanpham.Enabled = false;
            lbl_username.Text = username;
            if (username == "sa")
            {
                btn_export.Enabled = false;
                btn_import.Enabled = false;
            }
            string connectionString = connect;

            string query_before = $@"use QuanLyTraSuaDB2 SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'QuanLyTraSuaDB2';";


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

                // Hiển thị kết quả
                foreach (var row in rowsList)
                {
                    cbo_danhsach_table.Items.Add(row);
                }

            }
        }

        private void btn_submit_export_Click(object sender, EventArgs e)
        {
            //string connectionString = connect;

            //string query_before = $@"use QuanLyTraSuaDB2 SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'QuanLyTraSuaDB2';";


            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlDataAdapter adapter = new SqlDataAdapter(query_before, connection);
            //    DataTable dataTable = new DataTable();
            //    adapter.Fill(dataTable);

            //    // Tạo một danh sách để lưu các hàng dưới dạng chuỗi
            //    List<string> rowsList = new List<string>();

            //    // Duyệt qua các hàng trong DataTable
            //    foreach (DataRow row in dataTable.Rows)
            //    {
            //        // Chuyển đổi mỗi hàng thành chuỗi và thêm vào danh sách
            //        string rowString = string.Join(", ", row.ItemArray);
            //        rowsList.Add(rowString);
            //    }

            //    // Hiển thị kết quả
            //    foreach (var row in rowsList)
            //    {
            //        cbo_danhsach_table.Items.Add(row);
            //    }

            //}

            string connectionString = connect;
            string ex_path = "";

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn thư mục đã chọn
                    ex_path = folderBrowserDialog.SelectedPath;
                }
            }



            string table = cbo_danhsach_table.Text;

            //string path = @"{ex_path}\{table}.xlsx";


            string query = $@"SELECT * FROM {table}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                using (XLWorkbook workbook = new XLWorkbook())
                {

                    workbook.Worksheets.Add(dataTable, table);
                    // Lưu file tại vị trí cụ thể
                    workbook.SaveAs($@"{ex_path}\{table}.xlsx");
                }
            }

            MessageBox.Show($"Dữ liệu đã được xuất ra file {table}.xlsx");
        }

        private void btn_submit_export_all_Click(object sender, EventArgs e)
        {
            string connectionString = connect;
            string ex_path = "";
            string database_name = "QuanLyTraSuaDB2";


            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn thư mục đã chọn
                    ex_path = folderBrowserDialog.SelectedPath;
                }
            }
            using (XLWorkbook workbook = new XLWorkbook())
            {
                foreach (var table in rowsList)
                {
                    string table_name = table;

                    //string path = @"{ex_path}\{table}.xlsx";


                    string query = $@"SELECT * FROM {table_name}";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);


                        workbook.Worksheets.Add(dataTable, table_name);
                        // Lưu file tại vị trí cụ thể
                    }
                }
                workbook.SaveAs($@"{ex_path}\{database_name}.xlsx");
            }
            MessageBox.Show($"Đã xuất tất cả các bảng vào file {database_name}.xlsx");
        }

        private void btn_submit_export_Click_1(object sender, EventArgs e)
        {
            // Khởi tạo SaveFileDialog để người dùng chọn nơi lưu file CSV
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";  // Lọc để chỉ chọn file CSV
            saveFileDialog.Title = "Chọn nơi lưu file CSV";

            // Kiểm tra nếu người dùng chọn nơi lưu file
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string csvFilePath = saveFileDialog.FileName;  // Lấy đường dẫn của file đã chọn
                string tableName = cbo_danhsach_table.SelectedItem.ToString();  // Lấy tên bảng từ người dùng
                string connectionString = connect;  // Chuỗi kết nối

                // Thực hiện export dữ liệu từ bảng vào file CSV
                ExportDataToCSV(tableName, connectionString, csvFilePath);
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            //// Khởi tạo SaveFileDialog để người dùng chọn nơi lưu file CSV
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";  // Lọc để chỉ chọn file CSV
            //saveFileDialog.Title = "Chọn nơi lưu file CSV";

            //// Kiểm tra nếu người dùng chọn nơi lưu file
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string csvFilePath = saveFileDialog.FileName;  // Lấy đường dẫn của file đã chọn
            //    string tableName = txt_tenbang.Text;  // Lấy tên bảng từ người dùng
            //    string connectionString = connect;  // Chuỗi kết nối

            //    // Thực hiện export dữ liệu từ bảng vào file CSV
            //    ExportDataToCSV(tableName, connectionString, csvFilePath);
        }

        // Hàm export dữ liệu từ bảng SQL Server ra file CSV
        private void ExportDataToCSV(string tableName, string connectionString, string csvFilePath)
        {
            try
            {
                // Kết nối với SQL Server và thực thi truy vấn lấy dữ liệu
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"SELECT * FROM {tableName}";  // Truy vấn lấy toàn bộ dữ liệu từ bảng
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Sử dụng StreamWriter để ghi dữ liệu vào file CSV
                    using (StreamWriter writer = new StreamWriter(csvFilePath, false, Encoding.UTF8))
                    {
                        // Ghi tên cột vào dòng đầu tiên
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            writer.Write(reader.GetName(i));  // Ghi tên cột
                            if (i < reader.FieldCount - 1)
                                writer.Write(",");  // Thêm dấu phẩy giữa các tên cột
                        }
                        writer.WriteLine();  // Kết thúc dòng tên cột

                        // Ghi dữ liệu vào các dòng tiếp theo
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                writer.Write(reader[i].ToString());  // Ghi dữ liệu của mỗi cột
                                if (i < reader.FieldCount - 1)
                                    writer.Write(",");  // Thêm dấu phẩy giữa các giá trị cột
                            }
                            writer.WriteLine();  // Kết thúc một dòng dữ liệu
                        }
                    }
                }

                MessageBox.Show("Dữ liệu đã được export thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi export dữ liệu: " + ex.Message);
            }
        }

        private void export_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_submit_export_Click_2(object sender, EventArgs e)
        {

        }
    }

    


    //private void btn_thoat_Click_1(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        using (SqlConnection connection = new SqlConnection(connect))
    //        {
    //            connection.Open();
    //            MessageBox.Show("Quay lại Home!");
    //            // Mở form chính hoặc thực hiện hành động khác sau khi đăng nhập thành công
    //            export ex = this;
    //            ex.Hide();
    //            Home homeForm = new Home();
    //            homeForm.connect = connect;
    //            homeForm.username = username;
    //            homeForm.ShowDialog();
    //            ex.Close();
    //        }
    //    }
    //    catch (SqlException ex)
    //    {
    //        MessageBox.Show($"Lỗi quay lại");
    //    }
    //}
}

