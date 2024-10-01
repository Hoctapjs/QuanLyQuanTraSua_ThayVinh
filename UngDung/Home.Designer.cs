namespace UngDung
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_sanpham = new Button();
            btn_nhanvien = new Button();
            btn_khach = new Button();
            btn_hoadon = new Button();
            btn_chitietdh = new Button();
            btn_export = new Button();
            btn_import = new Button();
            btn_user_id = new Button();
            btn_phien = new Button();
            btn_capnhat_view = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel2 = new Panel();
            lbl_username = new Label();
            dataGridView1 = new DataGridView();
            btn_DangXuat = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1033, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 1050);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_sanpham);
            flowLayoutPanel1.Controls.Add(btn_nhanvien);
            flowLayoutPanel1.Controls.Add(btn_khach);
            flowLayoutPanel1.Controls.Add(btn_hoadon);
            flowLayoutPanel1.Controls.Add(btn_chitietdh);
            flowLayoutPanel1.Controls.Add(btn_export);
            flowLayoutPanel1.Controls.Add(btn_import);
            flowLayoutPanel1.Controls.Add(btn_user_id);
            flowLayoutPanel1.Controls.Add(btn_phien);
            flowLayoutPanel1.Controls.Add(btn_capnhat_view);
            flowLayoutPanel1.Location = new Point(21, 155);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(296, 938);
            flowLayoutPanel1.TabIndex = 6;
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
            // btn_nhanvien
            // 
            btn_nhanvien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_nhanvien.BackColor = Color.FromArgb(96, 187, 146);
            btn_nhanvien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nhanvien.ForeColor = Color.White;
            btn_nhanvien.Location = new Point(4, 76);
            btn_nhanvien.Margin = new Padding(4);
            btn_nhanvien.Name = "btn_nhanvien";
            btn_nhanvien.Size = new Size(292, 64);
            btn_nhanvien.TabIndex = 7;
            btn_nhanvien.Text = "Nhân Viên";
            btn_nhanvien.UseVisualStyleBackColor = false;
            btn_nhanvien.Click += btn_nhanvien_Click;
            // 
            // btn_khach
            // 
            btn_khach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_khach.BackColor = Color.FromArgb(96, 187, 146);
            btn_khach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_khach.ForeColor = Color.White;
            btn_khach.Location = new Point(4, 148);
            btn_khach.Margin = new Padding(4);
            btn_khach.Name = "btn_khach";
            btn_khach.Size = new Size(292, 64);
            btn_khach.TabIndex = 8;
            btn_khach.Text = "Khách";
            btn_khach.UseVisualStyleBackColor = false;
            btn_khach.Click += btn_khach_Click;
            // 
            // btn_hoadon
            // 
            btn_hoadon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_hoadon.BackColor = Color.FromArgb(96, 187, 146);
            btn_hoadon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_hoadon.ForeColor = Color.White;
            btn_hoadon.Location = new Point(4, 220);
            btn_hoadon.Margin = new Padding(4);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Size = new Size(292, 64);
            btn_hoadon.TabIndex = 6;
            btn_hoadon.Text = "Đơn Hàng";
            btn_hoadon.UseVisualStyleBackColor = false;
            btn_hoadon.Click += btn_hoadon_Click;
            // 
            // btn_chitietdh
            // 
            btn_chitietdh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_chitietdh.BackColor = Color.FromArgb(96, 187, 146);
            btn_chitietdh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_chitietdh.ForeColor = Color.White;
            btn_chitietdh.Location = new Point(4, 292);
            btn_chitietdh.Margin = new Padding(4);
            btn_chitietdh.Name = "btn_chitietdh";
            btn_chitietdh.Size = new Size(292, 64);
            btn_chitietdh.TabIndex = 10;
            btn_chitietdh.Text = "Chi Tiết DH";
            btn_chitietdh.UseVisualStyleBackColor = false;
            btn_chitietdh.Click += btn_chitietdh_Click;
            // 
            // btn_export
            // 
            btn_export.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_export.BackColor = Color.FromArgb(96, 187, 146);
            btn_export.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_export.ForeColor = Color.White;
            btn_export.Location = new Point(4, 364);
            btn_export.Margin = new Padding(4);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(292, 64);
            btn_export.TabIndex = 11;
            btn_export.Text = "Export to XLS";
            btn_export.UseVisualStyleBackColor = false;
            btn_export.Click += btn_export_Click;
            // 
            // btn_import
            // 
            btn_import.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_import.BackColor = Color.FromArgb(96, 187, 146);
            btn_import.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_import.ForeColor = Color.White;
            btn_import.Location = new Point(4, 436);
            btn_import.Margin = new Padding(4);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(292, 64);
            btn_import.TabIndex = 12;
            btn_import.Text = "Import from XLS";
            btn_import.UseVisualStyleBackColor = false;
            btn_import.Click += btn_import_Click;
            // 
            // btn_user_id
            // 
            btn_user_id.BackColor = Color.FromArgb(96, 187, 146);
            btn_user_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_user_id.ForeColor = Color.White;
            btn_user_id.Location = new Point(4, 508);
            btn_user_id.Margin = new Padding(4);
            btn_user_id.Name = "btn_user_id";
            btn_user_id.Size = new Size(292, 64);
            btn_user_id.TabIndex = 16;
            btn_user_id.Text = "User_id";
            btn_user_id.UseVisualStyleBackColor = false;
            btn_user_id.Click += btn_user_id_Click;
            // 
            // btn_phien
            // 
            btn_phien.BackColor = Color.FromArgb(96, 187, 146);
            btn_phien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_phien.ForeColor = Color.White;
            btn_phien.Location = new Point(4, 580);
            btn_phien.Margin = new Padding(4);
            btn_phien.Name = "btn_phien";
            btn_phien.Size = new Size(292, 64);
            btn_phien.TabIndex = 17;
            btn_phien.Text = "Phiên";
            btn_phien.UseVisualStyleBackColor = false;
            btn_phien.Click += btn_phien_Click;
            // 
            // btn_capnhat_view
            // 
            btn_capnhat_view.BackColor = Color.FromArgb(96, 187, 146);
            btn_capnhat_view.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_capnhat_view.ForeColor = Color.White;
            btn_capnhat_view.Location = new Point(4, 652);
            btn_capnhat_view.Margin = new Padding(4);
            btn_capnhat_view.Name = "btn_capnhat_view";
            btn_capnhat_view.Size = new Size(292, 64);
            btn_capnhat_view.TabIndex = 18;
            btn_capnhat_view.Text = "Cập Nhật View";
            btn_capnhat_view.UseVisualStyleBackColor = false;
            btn_capnhat_view.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Turquoise;
            pictureBox1.Image = Properties.Resources.Layer_2;
            pictureBox1.Location = new Point(21, 15);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(96, 187, 146);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(712, -113);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(296, 64);
            button1.TabIndex = 0;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.BackgroundImage = Properties.Resources.Layer_11;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(lbl_username);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_DangXuat);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1033, 1050);
            panel2.TabIndex = 1;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.Location = new Point(25, 28);
            lbl_username.Margin = new Padding(4, 0, 4, 0);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(97, 41);
            lbl_username.TabIndex = 2;
            lbl_username.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 99);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(983, 555);
            dataGridView1.TabIndex = 0;
            // 
            // btn_DangXuat
            // 
            btn_DangXuat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_DangXuat.BackColor = Color.FromArgb(96, 187, 146);
            btn_DangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DangXuat.ForeColor = Color.White;
            btn_DangXuat.Location = new Point(716, 19);
            btn_DangXuat.Margin = new Padding(4);
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.Size = new Size(292, 64);
            btn_DangXuat.TabIndex = 19;
            btn_DangXuat.Text = "Đăng xuất";
            btn_DangXuat.UseVisualStyleBackColor = false;
            btn_DangXuat.Click += btn_DangXuat_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 1050);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Home";
            Text = "Home";
            FormClosed += Home_FormClosed;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_sanpham;
        private Button btn_nhanvien;
        private Button btn_khach;
        private Button btn_hoadon;
        private DataGridView dataGridView1;
        private Button btn_chitietdh;
        private Label lbl_username;
        private Button btn_export;
        private Button btn_import;
        private Button btn_user_id;
        private Button btn_phien;
        private Button btn_capnhat_view;
        private Button btn_DangXuat;
    }
}