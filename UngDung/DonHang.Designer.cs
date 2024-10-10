namespace UngDung
{
    partial class DonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txt_madonhangmuonsua = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_ngaydonhang = new TextBox();
            txt_manhanvien = new TextBox();
            txt_makhachhang = new TextBox();
            txt_madonhang = new TextBox();
            lbl_username = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btn_thoat = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_donhang = new Button();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Layer_11;
            panel1.Controls.Add(btn_thoat);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lbl_username);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 1050);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_madonhangmuonsua);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_ngaydonhang);
            groupBox1.Controls.Add(txt_manhanvien);
            groupBox1.Controls.Add(txt_makhachhang);
            groupBox1.Controls.Add(txt_madonhang);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(30, 78);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(984, 392);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đơn Hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(508, 278);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(271, 32);
            label6.TabIndex = 13;
            label6.Text = "Mã đơn hàng muốn sửa";
            // 
            // txt_madonhangmuonsua
            // 
            txt_madonhangmuonsua.Location = new Point(508, 328);
            txt_madonhangmuonsua.Margin = new Padding(4, 4, 4, 4);
            txt_madonhangmuonsua.Name = "txt_madonhangmuonsua";
            txt_madonhangmuonsua.Size = new Size(434, 39);
            txt_madonhangmuonsua.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 164);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(219, 32);
            label4.TabIndex = 7;
            label4.Text = "Ngày lập đơn hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 164);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 6;
            label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 5;
            label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 4;
            label1.Text = "Mã đơn hàng";
            // 
            // txt_ngaydonhang
            // 
            txt_ngaydonhang.Location = new Point(508, 216);
            txt_ngaydonhang.Margin = new Padding(4, 4, 4, 4);
            txt_ngaydonhang.Name = "txt_ngaydonhang";
            txt_ngaydonhang.Size = new Size(434, 39);
            txt_ngaydonhang.TabIndex = 3;
            // 
            // txt_manhanvien
            // 
            txt_manhanvien.Location = new Point(38, 216);
            txt_manhanvien.Margin = new Padding(4, 4, 4, 4);
            txt_manhanvien.Name = "txt_manhanvien";
            txt_manhanvien.Size = new Size(434, 39);
            txt_manhanvien.TabIndex = 2;
            // 
            // txt_makhachhang
            // 
            txt_makhachhang.Location = new Point(508, 102);
            txt_makhachhang.Margin = new Padding(4, 4, 4, 4);
            txt_makhachhang.Name = "txt_makhachhang";
            txt_makhachhang.Size = new Size(434, 39);
            txt_makhachhang.TabIndex = 1;
            // 
            // txt_madonhang
            // 
            txt_madonhang.Location = new Point(38, 102);
            txt_madonhang.Margin = new Padding(4, 4, 4, 4);
            txt_madonhang.Name = "txt_madonhang";
            txt_madonhang.Size = new Size(434, 39);
            txt_madonhang.TabIndex = 0;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.BackColor = Color.LightGreen;
            lbl_username.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.Location = new Point(30, 15);
            lbl_username.Margin = new Padding(4, 0, 4, 0);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(97, 41);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 515);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(984, 504);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1033, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 1050);
            panel2.TabIndex = 1;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.FromArgb(96, 187, 146);
            btn_thoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thoat.ForeColor = Color.White;
            btn_thoat.Location = new Point(722, 6);
            btn_thoat.Margin = new Padding(4, 4, 4, 4);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(292, 64);
            btn_thoat.TabIndex = 8;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_donhang);
            flowLayoutPanel1.Controls.Add(btn_them);
            flowLayoutPanel1.Controls.Add(btn_xoa);
            flowLayoutPanel1.Controls.Add(btn_sua);
            flowLayoutPanel1.Location = new Point(26, 166);
            flowLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(296, 780);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btn_donhang
            // 
            btn_donhang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_donhang.BackColor = Color.FromArgb(96, 187, 146);
            btn_donhang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_donhang.ForeColor = Color.White;
            btn_donhang.Location = new Point(4, 4);
            btn_donhang.Margin = new Padding(4, 4, 4, 4);
            btn_donhang.Name = "btn_donhang";
            btn_donhang.Size = new Size(292, 64);
            btn_donhang.TabIndex = 9;
            btn_donhang.Text = "Đơn Hàng";
            btn_donhang.UseVisualStyleBackColor = false;
            btn_donhang.Click += btn_donhang_Click;
            // 
            // btn_them
            // 
            btn_them.BackColor = Color.FromArgb(96, 187, 146);
            btn_them.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.ForeColor = Color.White;
            btn_them.Location = new Point(4, 76);
            btn_them.Margin = new Padding(4, 4, 4, 4);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(292, 64);
            btn_them.TabIndex = 13;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = Color.FromArgb(96, 187, 146);
            btn_xoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoa.ForeColor = Color.White;
            btn_xoa.Location = new Point(4, 148);
            btn_xoa.Margin = new Padding(4, 4, 4, 4);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(292, 64);
            btn_xoa.TabIndex = 14;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.FromArgb(96, 187, 146);
            btn_sua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.ForeColor = Color.White;
            btn_sua.Location = new Point(4, 220);
            btn_sua.Margin = new Padding(4, 4, 4, 4);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(292, 64);
            btn_sua.TabIndex = 15;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Turquoise;
            pictureBox1.Image = Properties.Resources.Layer_2;
            pictureBox1.Location = new Point(26, 15);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // DonHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 1050);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "DonHang";
            Text = "Đơn Hàng";
            Load += sanpham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_xoa;
        private Label label6;
        private TextBox txt_madonhangmuonsua;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_ngaydonhang;
        private Button btn_donhang;
        private Button btn_them;
        private Button btn_thoat;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_sua;
        private Panel panel2;
        private TextBox txt_manhanvien;
        private Label lbl_username;
        private TextBox txt_makhachhang;
        private TextBox txt_madonhang;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
    }
}