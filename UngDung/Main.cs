using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDung;

namespace UngDung
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            Main main = this;
            main.Hide();
            DangNhap_sql loginForm = new DangNhap_sql();
            loginForm.ShowDialog();
            main.Close();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            Main main = this;
            main.Hide();
            Form1 registerForm = new Form1();
            registerForm.ShowDialog();
            main.Close();
        }
    }
}
