using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

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
                    export ex = this;
                    ex.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connect;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    ex.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show($"Lỗi quay lại");
            }
        }

        private void export_Load(object sender, EventArgs e)
        {
            btn_export.Enabled = false;
            lbl_username.Text = username;

            string connectionString = connect;
            string query_before = $@"USE QuanLyTraSuaDB2 SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'QuanLyTraSuaDB2';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query_before, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                rowsList = new List<string>();
                foreach (DataRow row in dataTable.Rows)
                {
                    string rowString = string.Join(", ", row.ItemArray);
                    rowsList.Add(rowString);
                }

                foreach (var row in rowsList)
                {
                    cbo_danhsach_table.Items.Add(row);
                }
            }
        }

        private void btn_submit_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            saveFileDialog.Title = "Chọn nơi lưu file CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string csvFilePath = saveFileDialog.FileName;
                string tableName = cbo_danhsach_table.SelectedItem.ToString();

                // Thực hiện các lệnh BCP
                ExecuteBCPCommand(tableName, csvFilePath);
            }
        }

        public void ExecuteBCPCommand(string table, string csvFilePath)
        {
            string exportServer = "LAPTOP-2IRIHD28\\SQLSEVER2012";
            string exportDb = "QuanLyTraSuaDB2";
            string exportTable = table;

            // Lệnh để xuất tên cột vào file HeadersOnly.csv
            string command1 = $"bcp \"DECLARE @colnames VARCHAR(max); SELECT @colnames = COALESCE(@colnames + ',', '') + column_name FROM {exportDb}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='{exportTable}'; SELECT @colnames;\" queryout HeadersOnly.csv -c -T -S{exportServer}";

            // Lệnh để xuất dữ liệu của bảng vào TableDataWithoutHeaders.csv
            string command2 = $"bcp {exportDb}.dbo.{exportTable} out TableDataWithoutHeaders.csv -c -t, -T -S{exportServer} -C 65001";

            // Lệnh để ghép hai file thành file CSV cuối cùng ở vị trí mà người dùng đã chọn
            string command3 = $"cmd.exe /c copy /b HeadersOnly.csv+TableDataWithoutHeaders.csv \"{csvFilePath}\"";

            // Lệnh để xóa các file tạm
            string command4 = "cmd.exe /c del HeadersOnly.csv";
            string command5 = "cmd.exe /c del TableDataWithoutHeaders.csv";

            // Thực thi các lệnh
            ExecuteCommand(command1);
            ExecuteCommand(command2);
            ExecuteCommand(command3);
            ExecuteCommand(command4);
            ExecuteCommand(command5);
        }

        private void ExecuteCommand(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + command;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            if (!string.IsNullOrEmpty(output))
            {
                Console.WriteLine("Output: " + output);
            }

            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine("Error: " + error);
            }
        }

    }
}





