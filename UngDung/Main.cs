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
            RegisterFormClosedEvent();
        }

        private void RegisterFormClosedEvent()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.FormClosed += new FormClosedEventHandler(Main_FormClosed);
                }
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            Main main = this;
            main.Hide();
            ChonServer loginForm = new ChonServer();
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

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (AreAllFormsClosed())
            {
                // Hiển thị form mong muốn khi tất cả các form khác đã đóng
                Form desiredForm = new Main();
                desiredForm.Show();
            }
        }

        private bool AreAllFormsClosed()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this && form.Visible)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
