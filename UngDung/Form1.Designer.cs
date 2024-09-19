namespace UngDung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtxacnhanmatkhau = new System.Windows.Forms.TextBox();
            this.btndangky = new System.Windows.Forms.Button();
            this.btn_dk_dangnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.label1.Location = new System.Drawing.Point(151, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttendangnhap.Location = new System.Drawing.Point(37, 115);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.PlaceholderText = "Tên Đăng Nhập";
            this.txttendangnhap.Size = new System.Drawing.Size(396, 34);
            this.txttendangnhap.TabIndex = 1;
            this.txttendangnhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmatkhau.Location = new System.Drawing.Point(37, 169);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.PlaceholderText = "Mật Khẩu";
            this.txtmatkhau.Size = new System.Drawing.Size(396, 34);
            this.txtmatkhau.TabIndex = 2;
            this.txtmatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtxacnhanmatkhau
            // 
            this.txtxacnhanmatkhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtxacnhanmatkhau.Location = new System.Drawing.Point(37, 223);
            this.txtxacnhanmatkhau.Name = "txtxacnhanmatkhau";
            this.txtxacnhanmatkhau.PasswordChar = '*';
            this.txtxacnhanmatkhau.PlaceholderText = "Xác Nhận Mật Khẩu";
            this.txtxacnhanmatkhau.Size = new System.Drawing.Size(396, 34);
            this.txtxacnhanmatkhau.TabIndex = 3;
            this.txtxacnhanmatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btndangky
            // 
            this.btndangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btndangky.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndangky.ForeColor = System.Drawing.Color.White;
            this.btndangky.Location = new System.Drawing.Point(37, 277);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(396, 55);
            this.btndangky.TabIndex = 4;
            this.btndangky.Text = "Đăng Ký";
            this.btndangky.UseVisualStyleBackColor = false;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // btn_dk_dangnhap
            // 
            this.btn_dk_dangnhap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dk_dangnhap.Location = new System.Drawing.Point(37, 400);
            this.btn_dk_dangnhap.Name = "btn_dk_dangnhap";
            this.btn_dk_dangnhap.Size = new System.Drawing.Size(396, 55);
            this.btn_dk_dangnhap.TabIndex = 5;
            this.btn_dk_dangnhap.Text = "Đăng Nhập";
            this.btn_dk_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dk_dangnhap.Click += new System.EventHandler(this.btn_dk_dangnhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(89, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nếu bạn đã đăng ký thành công";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dk_dangnhap);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.txtxacnhanmatkhau);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txttendangnhap;
        private TextBox txtmatkhau;
        private TextBox txtxacnhanmatkhau;
        private Button btndangky;
        private Button btn_dk_dangnhap;
        private Label label2;
    }
}