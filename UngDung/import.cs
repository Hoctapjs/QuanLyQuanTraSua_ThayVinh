using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

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
            // Khởi tạo OpenFileDialog để người dùng chọn file CSV
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";  // Lọc để chỉ chọn file CSV
            openFileDialog.Title = "Chọn File CSV";

            // Kiểm tra nếu người dùng chọn file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string csvFilePath = openFileDialog.FileName;  // Lấy đường dẫn của file đã chọn
                string tableName = txt_tenbang.Text;  // Lấy tên bảng từ người dùng
                string connectionString = connect;  // Chuỗi kết nối

                // Đọc cấu trúc của file CSV và tạo bảng
                CreateTableFromCSV(csvFilePath, connectionString, tableName);

                // Sử dụng BCP để nhập dữ liệu (không có dòng tiêu đề)
                string csvFileWithoutHeader = @"D:\chua file xlsx\csv\KHACH_noheader.csv";  // Định nghĩa đường dẫn mới cho file CSV không có tiêu đề
                RemoveHeader(csvFilePath, csvFileWithoutHeader);  // Xóa dòng tiêu đề
                ImportDataWithBCP(csvFileWithoutHeader, tableName, connectionString);
            }
        }

        // Hàm tạo bảng tự động từ CSV
        private void CreateTableFromCSV(string csvFilePath, string connectionString, string tableName)
        {
            try
            {
                // Đọc file CSV và lấy dòng đầu tiên (tên cột)
                var lines = File.ReadAllLines(csvFilePath);
                var headers = lines[0].Split(',');

                StringBuilder createTableQuery = new StringBuilder();
                createTableQuery.AppendLine($"CREATE TABLE {tableName} (");

                // Duyệt qua các cột và xác định kiểu dữ liệu (VD: NVARCHAR cho tất cả cột)
                foreach (var header in headers)
                {
                    createTableQuery.AppendLine($"{header.Trim()} NVARCHAR(255),");
                }

                // Loại bỏ dấu phẩy cuối cùng và đóng câu lệnh
                createTableQuery.Remove(createTableQuery.Length - 3, 3);
                createTableQuery.AppendLine(");");

                // Kết nối SQL Server và thực thi câu lệnh tạo bảng
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(createTableQuery.ToString(), conn);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Bảng đã được tạo thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo bảng: " + ex.Message);
            }
        }

        // Hàm xóa dòng tiêu đề và lưu vào file mới
        private void RemoveHeader(string originalFile, string newFile)
        {
            var lines = File.ReadAllLines(originalFile).Skip(1); // Bỏ qua dòng đầu tiên
            File.WriteAllLines(newFile, lines); // Lưu lại file không có dòng đầu tiên
        }

        // Hàm sử dụng BCP để nhập dữ liệu vào bảng
        private void ImportDataWithBCP(string csvFilePath, string tableName, string connectionString)
        {
            try
            {
                string bcpCommand = $@"bcp {tableName} in ""{csvFilePath}"" -c -t, -S -d QuanLyTraSuaDB2 -T -C 65001";
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/C {bcpCommand}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                MessageBox.Show("Dữ liệu đã được import thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi import dữ liệu: " + ex.Message);
            }
        }














    }
}
