namespace UngDung
{
    partial class export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(export));
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            btn_submit_export_all = new Button();
            btn_submit_export = new Button();
            cbo_danhsach_table = new ComboBox();
            label2 = new Label();
            lbl_username = new Label();
            panel2 = new Panel();
            btn_thoat = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_sanpham = new Button();
            btn_nhanvien = new Button();
            btn_khach = new Button();
            btn_hoadon = new Button();
            btn_chitietdh = new Button();
            btn_export = new Button();
            btn_import = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Layer_11;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btn_thoat);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lbl_username);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 789);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(25, 79);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1002, 630);
            panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_submit_export_all);
            groupBox1.Controls.Add(btn_submit_export);
            groupBox1.Controls.Add(cbo_danhsach_table);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 25);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(959, 218);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Export Table";
            // 
            // btn_submit_export_all
            // 
            btn_submit_export_all.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_submit_export_all.BackColor = Color.FromArgb(96, 187, 146);
            btn_submit_export_all.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_submit_export_all.ForeColor = Color.White;
            btn_submit_export_all.Location = new Point(704, 84);
            btn_submit_export_all.Margin = new Padding(4, 4, 4, 4);
            btn_submit_export_all.Name = "btn_submit_export_all";
            btn_submit_export_all.Size = new Size(235, 54);
            btn_submit_export_all.TabIndex = 6;
            btn_submit_export_all.Text = "Export All";
            btn_submit_export_all.UseVisualStyleBackColor = false;
            btn_submit_export_all.Click += btn_submit_export_all_Click;
            // 
            // btn_submit_export
            // 
            btn_submit_export.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_submit_export.BackColor = Color.FromArgb(96, 187, 146);
            btn_submit_export.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_submit_export.ForeColor = Color.White;
            btn_submit_export.Location = new Point(704, 145);
            btn_submit_export.Margin = new Padding(4, 4, 4, 4);
            btn_submit_export.Name = "btn_submit_export";
            btn_submit_export.Size = new Size(235, 54);
            btn_submit_export.TabIndex = 5;
            btn_submit_export.Text = "Export";
            btn_submit_export.UseVisualStyleBackColor = false;
            btn_submit_export.Click += btn_submit_export_Click_1;
            // 
            // cbo_danhsach_table
            // 
            cbo_danhsach_table.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbo_danhsach_table.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_danhsach_table.FormattingEnabled = true;
            cbo_danhsach_table.ItemHeight = 41;
            cbo_danhsach_table.Location = new Point(38, 145);
            cbo_danhsach_table.Margin = new Padding(4, 4, 4, 4);
            cbo_danhsach_table.Name = "cbo_danhsach_table";
            cbo_danhsach_table.Size = new Size(643, 49);
            cbo_danhsach_table.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(96, 187, 146);
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(320, 41);
            label2.TabIndex = 3;
            label2.Text = "Chọn Table cần Export:";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.BackColor = Color.LightGreen;
            lbl_username.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.Location = new Point(25, 15);
            lbl_username.Margin = new Padding(4, 0, 4, 0);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(97, 41);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "label1";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(1041, -14);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 802);
            panel2.TabIndex = 1;
            // 
            // btn_thoat
            // 
            btn_thoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_thoat.BackColor = Color.FromArgb(96, 187, 146);
            btn_thoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thoat.ForeColor = Color.White;
            btn_thoat.Location = new Point(731, 7);
            btn_thoat.Margin = new Padding(4, 4, 4, 4);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(296, 64);
            btn_thoat.TabIndex = 9;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Turquoise;
            pictureBox1.Image = Properties.Resources.Layer_2;
            pictureBox1.Location = new Point(19, 29);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            flowLayoutPanel1.Location = new Point(19, 172);
            flowLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(296, 509);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btn_sanpham
            // 
            btn_sanpham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_sanpham.BackColor = Color.FromArgb(96, 187, 146);
            btn_sanpham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sanpham.ForeColor = Color.White;
            btn_sanpham.Location = new Point(4, 4);
            btn_sanpham.Margin = new Padding(4, 4, 4, 4);
            btn_sanpham.Name = "btn_sanpham";
            btn_sanpham.Size = new Size(292, 64);
            btn_sanpham.TabIndex = 9;
            btn_sanpham.Text = "Sản Phẩm";
            btn_sanpham.UseVisualStyleBackColor = false;
            // 
            // btn_nhanvien
            // 
            btn_nhanvien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_nhanvien.BackColor = Color.FromArgb(96, 187, 146);
            btn_nhanvien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nhanvien.ForeColor = Color.White;
            btn_nhanvien.Location = new Point(4, 76);
            btn_nhanvien.Margin = new Padding(4, 4, 4, 4);
            btn_nhanvien.Name = "btn_nhanvien";
            btn_nhanvien.Size = new Size(292, 64);
            btn_nhanvien.TabIndex = 7;
            btn_nhanvien.Text = "Nhân Viên";
            btn_nhanvien.UseVisualStyleBackColor = false;
            // 
            // btn_khach
            // 
            btn_khach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_khach.BackColor = Color.FromArgb(96, 187, 146);
            btn_khach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_khach.ForeColor = Color.White;
            btn_khach.Location = new Point(4, 148);
            btn_khach.Margin = new Padding(4, 4, 4, 4);
            btn_khach.Name = "btn_khach";
            btn_khach.Size = new Size(292, 64);
            btn_khach.TabIndex = 8;
            btn_khach.Text = "Khách";
            btn_khach.UseVisualStyleBackColor = false;
            // 
            // btn_hoadon
            // 
            btn_hoadon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_hoadon.BackColor = Color.FromArgb(96, 187, 146);
            btn_hoadon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_hoadon.ForeColor = Color.White;
            btn_hoadon.Location = new Point(4, 220);
            btn_hoadon.Margin = new Padding(4, 4, 4, 4);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Size = new Size(292, 64);
            btn_hoadon.TabIndex = 6;
            btn_hoadon.Text = "Hóa Đơn";
            btn_hoadon.UseVisualStyleBackColor = false;
            // 
            // btn_chitietdh
            // 
            btn_chitietdh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_chitietdh.BackColor = Color.FromArgb(96, 187, 146);
            btn_chitietdh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_chitietdh.ForeColor = Color.White;
            btn_chitietdh.Location = new Point(4, 292);
            btn_chitietdh.Margin = new Padding(4, 4, 4, 4);
            btn_chitietdh.Name = "btn_chitietdh";
            btn_chitietdh.Size = new Size(292, 64);
            btn_chitietdh.TabIndex = 10;
            btn_chitietdh.Text = "Chi Tiết DH";
            btn_chitietdh.UseVisualStyleBackColor = false;
            // 
            // btn_export
            // 
            btn_export.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_export.BackColor = Color.FromArgb(96, 187, 146);
            btn_export.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_export.ForeColor = Color.White;
            btn_export.Location = new Point(4, 364);
            btn_export.Margin = new Padding(4, 4, 4, 4);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(292, 64);
            btn_export.TabIndex = 11;
            btn_export.Text = "Export to XLS";
            btn_export.UseVisualStyleBackColor = false;
            // 
            // btn_import
            // 
            btn_import.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_import.BackColor = Color.FromArgb(96, 187, 146);
            btn_import.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_import.ForeColor = Color.White;
            btn_import.Location = new Point(4, 436);
            btn_import.Margin = new Padding(4, 4, 4, 4);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(292, 64);
            btn_import.TabIndex = 12;
            btn_import.Text = "Import from XLS";
            btn_import.UseVisualStyleBackColor = false;
            // 
            // export
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 789);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "export";
            Text = "export";
            Load += export_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_sanpham;
        private Button btn_nhanvien;
        private Button btn_khach;
        private Button btn_hoadon;
        private Button btn_chitietdh;
        private Button btn_export;
        private Button btn_import;
        private PictureBox pictureBox1;
        private Label lbl_username;
        private Button btn_thoat;
        private Panel panel3;
        private GroupBox groupBox1;
        private Button btn_submit_export;
        private ComboBox cbo_danhsach_table;
        private Label label2;
        private Button btn_submit_export_all;
    }
}