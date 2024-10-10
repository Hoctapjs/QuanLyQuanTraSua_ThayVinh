namespace UngDung
{
    partial class sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sanpham));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txt_makhachhang = new TextBox();
            label5 = new Label();
            txt_sanpham_sua = new TextBox();
            btn_sanpham_tim = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_sanpham_trangthai = new TextBox();
            txt_sanpham_giatien = new TextBox();
            txt_sanpham_ten = new TextBox();
            txt_sanpham_ma = new TextBox();
            lbl_username = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btn_thoat = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_sanpham = new Button();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_mon_chuadathang = new Button();
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
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btn_thoat);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lbl_username);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 1050);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_makhachhang);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_sanpham_sua);
            groupBox1.Controls.Add(btn_sanpham_tim);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_sanpham_trangthai);
            groupBox1.Controls.Add(txt_sanpham_giatien);
            groupBox1.Controls.Add(txt_sanpham_ten);
            groupBox1.Controls.Add(txt_sanpham_ma);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(30, 78);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(984, 531);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 391);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(281, 32);
            label6.TabIndex = 13;
            label6.Text = "Tìm theo mã khách hàng";
            // 
            // txt_makhachhang
            // 
            txt_makhachhang.Location = new Point(38, 441);
            txt_makhachhang.Margin = new Padding(4);
            txt_makhachhang.Name = "txt_makhachhang";
            txt_makhachhang.Size = new Size(434, 39);
            txt_makhachhang.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 278);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(260, 32);
            label5.TabIndex = 11;
            label5.Text = "Sửa theo mã sản phẩm";
            // 
            // txt_sanpham_sua
            // 
            txt_sanpham_sua.Location = new Point(38, 328);
            txt_sanpham_sua.Margin = new Padding(4);
            txt_sanpham_sua.Name = "txt_sanpham_sua";
            txt_sanpham_sua.Size = new Size(434, 39);
            txt_sanpham_sua.TabIndex = 10;
            // 
            // btn_sanpham_tim
            // 
            btn_sanpham_tim.BackColor = Color.FromArgb(96, 187, 146);
            btn_sanpham_tim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sanpham_tim.ForeColor = Color.White;
            btn_sanpham_tim.Location = new Point(508, 306);
            btn_sanpham_tim.Margin = new Padding(4);
            btn_sanpham_tim.Name = "btn_sanpham_tim";
            btn_sanpham_tim.Size = new Size(292, 64);
            btn_sanpham_tim.TabIndex = 9;
            btn_sanpham_tim.Text = "Tìm";
            btn_sanpham_tim.UseVisualStyleBackColor = false;
            btn_sanpham_tim.Click += btn_sanpham_tim_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 164);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 32);
            label4.TabIndex = 7;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 164);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 6;
            label3.Text = "Giá tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 32);
            label2.TabIndex = 5;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 4;
            label1.Text = "Mã sản phẩm";
            // 
            // txt_sanpham_trangthai
            // 
            txt_sanpham_trangthai.Location = new Point(508, 216);
            txt_sanpham_trangthai.Margin = new Padding(4);
            txt_sanpham_trangthai.Name = "txt_sanpham_trangthai";
            txt_sanpham_trangthai.Size = new Size(434, 39);
            txt_sanpham_trangthai.TabIndex = 3;
            // 
            // txt_sanpham_giatien
            // 
            txt_sanpham_giatien.Location = new Point(38, 216);
            txt_sanpham_giatien.Margin = new Padding(4);
            txt_sanpham_giatien.Name = "txt_sanpham_giatien";
            txt_sanpham_giatien.Size = new Size(434, 39);
            txt_sanpham_giatien.TabIndex = 2;
            // 
            // txt_sanpham_ten
            // 
            txt_sanpham_ten.Location = new Point(508, 102);
            txt_sanpham_ten.Margin = new Padding(4);
            txt_sanpham_ten.Name = "txt_sanpham_ten";
            txt_sanpham_ten.Size = new Size(434, 39);
            txt_sanpham_ten.TabIndex = 1;
            // 
            // txt_sanpham_ma
            // 
            txt_sanpham_ma.Location = new Point(38, 102);
            txt_sanpham_ma.Margin = new Padding(4);
            txt_sanpham_ma.Name = "txt_sanpham_ma";
            txt_sanpham_ma.Size = new Size(434, 39);
            txt_sanpham_ma.TabIndex = 0;
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
            dataGridView1.Location = new Point(30, 640);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(984, 379);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1033, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 1050);
            panel2.TabIndex = 1;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.FromArgb(96, 187, 146);
            btn_thoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thoat.ForeColor = Color.White;
            btn_thoat.Location = new Point(722, 7);
            btn_thoat.Margin = new Padding(4);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(292, 64);
            btn_thoat.TabIndex = 8;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_sanpham);
            flowLayoutPanel1.Controls.Add(btn_them);
            flowLayoutPanel1.Controls.Add(btn_xoa);
            flowLayoutPanel1.Controls.Add(btn_sua);
            flowLayoutPanel1.Controls.Add(btn_mon_chuadathang);
            flowLayoutPanel1.Location = new Point(26, 166);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(296, 780);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btn_sanpham
            // 
            btn_sanpham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_sanpham.BackColor = Color.FromArgb(96, 187, 146);
            btn_sanpham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sanpham.ForeColor = Color.White;
            btn_sanpham.Location = new Point(4, 4);
            btn_sanpham.Margin = new Padding(4);
            btn_sanpham.Name = "btn_sanpham";
            btn_sanpham.Size = new Size(292, 64);
            btn_sanpham.TabIndex = 9;
            btn_sanpham.Text = "Sản Phẩm";
            btn_sanpham.UseVisualStyleBackColor = false;
            btn_sanpham.Click += btn_sanpham_Click;
            // 
            // btn_them
            // 
            btn_them.BackColor = Color.FromArgb(96, 187, 146);
            btn_them.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.ForeColor = Color.White;
            btn_them.Location = new Point(4, 76);
            btn_them.Margin = new Padding(4);
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
            btn_xoa.Margin = new Padding(4);
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
            btn_sua.Margin = new Padding(4);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(292, 64);
            btn_sua.TabIndex = 15;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_mon_chuadathang
            // 
            btn_mon_chuadathang.BackColor = Color.FromArgb(96, 187, 146);
            btn_mon_chuadathang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_mon_chuadathang.ForeColor = Color.White;
            btn_mon_chuadathang.Location = new Point(4, 292);
            btn_mon_chuadathang.Margin = new Padding(4);
            btn_mon_chuadathang.Name = "btn_mon_chuadathang";
            btn_mon_chuadathang.Size = new Size(292, 64);
            btn_mon_chuadathang.TabIndex = 16;
            btn_mon_chuadathang.Text = "Món Chưa Đặt Hàng";
            btn_mon_chuadathang.UseVisualStyleBackColor = false;
            btn_mon_chuadathang.Click += btn_mon_chuadathang_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Turquoise;
            pictureBox1.Image = Properties.Resources.Layer_2;
            pictureBox1.Location = new Point(26, 15);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // sanpham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 1050);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "sanpham";
            Text = "sanpham";
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

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_sanpham;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_thoat;
        private DataGridView dataGridView1;
        private Label lbl_username;
        private GroupBox groupBox1;
        private Button btn_sanpham_tim;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_sanpham_trangthai;
        private TextBox txt_sanpham_giatien;
        private TextBox txt_sanpham_ten;
        private TextBox txt_sanpham_ma;
        private Label label5;
        private TextBox txt_sanpham_sua;
        private Button btn_mon_chuadathang;
        private Label label6;
        private TextBox txt_makhachhang;
    }
}