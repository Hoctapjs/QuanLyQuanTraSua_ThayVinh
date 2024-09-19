namespace UngDung
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.txtmatkhau1 = new System.Windows.Forms.TextBox();
            this.txttendangnhap1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmatkhau1
            // 
            this.txtmatkhau1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmatkhau1.Location = new System.Drawing.Point(39, 186);
            this.txtmatkhau1.Name = "txtmatkhau1";
            this.txtmatkhau1.PasswordChar = '*';
            this.txtmatkhau1.PlaceholderText = "Mật Khẩu";
            this.txtmatkhau1.Size = new System.Drawing.Size(396, 34);
            this.txtmatkhau1.TabIndex = 7;
            this.txtmatkhau1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttendangnhap1
            // 
            this.txttendangnhap1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttendangnhap1.Location = new System.Drawing.Point(39, 124);
            this.txttendangnhap1.Name = "txttendangnhap1";
            this.txttendangnhap1.PlaceholderText = "Tên Đăng Nhập";
            this.txttendangnhap1.Size = new System.Drawing.Size(396, 34);
            this.txttendangnhap1.TabIndex = 6;
            this.txttendangnhap1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.label1.Location = new System.Drawing.Point(119, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đăng Nhập";
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btndangnhap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndangnhap.ForeColor = System.Drawing.Color.White;
            this.btndangnhap.Location = new System.Drawing.Point(39, 246);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(396, 59);
            this.btndangnhap.TabIndex = 8;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 338);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtmatkhau1);
            this.Controls.Add(this.txttendangnhap1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtmatkhau1;
        private TextBox txttendangnhap1;
        private Label label1;
        private Button btndangnhap;
    }
}