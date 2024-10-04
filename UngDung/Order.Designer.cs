namespace UngDung
{
    partial class Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_thucuong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sanpham_sua = new System.Windows.Forms.TextBox();
            this.btn_sanpham_tim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sanpham_trangthai = new System.Windows.Forms.TextBox();
            this.txt_sanpham_giatien = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sanpham = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_mon_chuadathang = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UngDung.Properties.Resources.Layer_11;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 1053);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbo_thucuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_sanpham_sua);
            this.groupBox1.Controls.Add(this.btn_sanpham_tim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_sanpham_trangthai);
            this.groupBox1.Controls.Add(this.txt_sanpham_giatien);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(24, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 420);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // cbo_thucuong
            // 
            this.cbo_thucuong.FormattingEnabled = true;
            this.cbo_thucuong.Location = new System.Drawing.Point(30, 82);
            this.cbo_thucuong.Name = "cbo_thucuong";
            this.cbo_thucuong.Size = new System.Drawing.Size(348, 36);
            this.cbo_thucuong.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng";
            // 
            // txt_sanpham_sua
            // 
            this.txt_sanpham_sua.Location = new System.Drawing.Point(30, 262);
            this.txt_sanpham_sua.Name = "txt_sanpham_sua";
            this.txt_sanpham_sua.Size = new System.Drawing.Size(348, 34);
            this.txt_sanpham_sua.TabIndex = 10;
            // 
            // btn_sanpham_tim
            // 
            this.btn_sanpham_tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_sanpham_tim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sanpham_tim.ForeColor = System.Drawing.Color.White;
            this.btn_sanpham_tim.Location = new System.Drawing.Point(406, 245);
            this.btn_sanpham_tim.Name = "btn_sanpham_tim";
            this.btn_sanpham_tim.Size = new System.Drawing.Size(234, 51);
            this.btn_sanpham_tim.TabIndex = 9;
            this.btn_sanpham_tim.Text = "Tìm";
            this.btn_sanpham_tim.UseVisualStyleBackColor = false;
            this.btn_sanpham_tim.Click += new System.EventHandler(this.btn_sanpham_tim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txt_sanpham_trangthai
            // 
            this.txt_sanpham_trangthai.Location = new System.Drawing.Point(406, 173);
            this.txt_sanpham_trangthai.Name = "txt_sanpham_trangthai";
            this.txt_sanpham_trangthai.ReadOnly = true;
            this.txt_sanpham_trangthai.Size = new System.Drawing.Size(348, 34);
            this.txt_sanpham_trangthai.TabIndex = 3;
            // 
            // txt_sanpham_giatien
            // 
            this.txt_sanpham_giatien.Location = new System.Drawing.Point(30, 173);
            this.txt_sanpham_giatien.Name = "txt_sanpham_giatien";
            this.txt_sanpham_giatien.ReadOnly = true;
            this.txt_sanpham_giatien.Size = new System.Drawing.Size(348, 34);
            this.txt_sanpham_giatien.TabIndex = 2;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.LightGreen;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(24, 12);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 35);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 512);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(787, 516);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_thoat);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(827, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 1053);
            this.panel2.TabIndex = 1;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(21, 790);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(234, 51);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_sanpham);
            this.flowLayoutPanel1.Controls.Add(this.btn_them);
            this.flowLayoutPanel1.Controls.Add(this.btn_xoa);
            this.flowLayoutPanel1.Controls.Add(this.btn_sua);
            this.flowLayoutPanel1.Controls.Add(this.btn_mon_chuadathang);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 133);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 624);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_sanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_sanpham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sanpham.ForeColor = System.Drawing.Color.White;
            this.btn_sanpham.Location = new System.Drawing.Point(3, 3);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Size = new System.Drawing.Size(234, 51);
            this.btn_sanpham.TabIndex = 9;
            this.btn_sanpham.Text = "Sản Phẩm";
            this.btn_sanpham.UseVisualStyleBackColor = false;
            this.btn_sanpham.Click += new System.EventHandler(this.btn_sanpham_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(3, 60);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(234, 51);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(3, 117);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(234, 51);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(3, 174);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(234, 51);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_mon_chuadathang
            // 
            this.btn_mon_chuadathang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_mon_chuadathang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_mon_chuadathang.ForeColor = System.Drawing.Color.White;
            this.btn_mon_chuadathang.Location = new System.Drawing.Point(3, 231);
            this.btn_mon_chuadathang.Name = "btn_mon_chuadathang";
            this.btn_mon_chuadathang.Size = new System.Drawing.Size(234, 51);
            this.btn_mon_chuadathang.TabIndex = 16;
            this.btn_mon_chuadathang.Text = "Món Chưa Đặt Hàng";
            this.btn_mon_chuadathang.UseVisualStyleBackColor = false;
            this.btn_mon_chuadathang.Click += new System.EventHandler(this.btn_mon_chuadathang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.Image = global::UngDung.Properties.Resources.Layer_2;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 1053);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.sanpham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_thoat;
        private Button btn_sanpham;
        private Label label5;
        private TextBox txt_sanpham_sua;
        private Button btn_sanpham_tim;
        private Button btn_them;
        private Button btn_xoa;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_sua;
        private Button btn_mon_chuadathang;
        private PictureBox pictureBox1;
        private TextBox txt_sanpham_giatien;
        private Label lbl_username;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Panel panel2;
        private Panel panel1;
        private ComboBox cbo_thucuong;
        private Label label4;
        private TextBox txt_sanpham_trangthai;
    }
}