using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDung
{
    public partial class ChonServer : Form
    {
        public ChonServer()
        {
            InitializeComponent();
        }

        private void btn_local_Click(object sender, EventArgs e)
        {
            ChonServer chonsv = this;
            chonsv.Hide();
            DangNhap_sql loginForm = new DangNhap_sql();
            loginForm.ip_con = false;
            loginForm.ShowDialog();
            chonsv.Close();
        }

        private void btn_ip_Click(object sender, EventArgs e)
        {
            string ip = txt_ip.Text;
            string server_name = txt_servername.Text;

            try
            {
                ChonServer chonsv = this;
                chonsv.Hide();
                DangNhap_sql loginForm = new DangNhap_sql();
                loginForm.ip = ip;
                loginForm.server_name = server_name;
                loginForm.ip_con = true;
                loginForm.ShowDialog();
                chonsv.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
