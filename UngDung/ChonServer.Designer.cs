namespace UngDung
{
    partial class ChonServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonServer));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_local = new System.Windows.Forms.Button();
            this.btn_ip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_servername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết Nối Bằng Local";
            // 
            // btn_local
            // 
            this.btn_local.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_local.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_local.ForeColor = System.Drawing.Color.White;
            this.btn_local.Location = new System.Drawing.Point(88, 99);
            this.btn_local.Name = "btn_local";
            this.btn_local.Size = new System.Drawing.Size(630, 65);
            this.btn_local.TabIndex = 1;
            this.btn_local.Text = "Kết nối";
            this.btn_local.UseVisualStyleBackColor = false;
            this.btn_local.Click += new System.EventHandler(this.btn_local_Click);
            // 
            // btn_ip
            // 
            this.btn_ip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_ip.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ip.ForeColor = System.Drawing.Color.White;
            this.btn_ip.Location = new System.Drawing.Point(88, 423);
            this.btn_ip.Name = "btn_ip";
            this.btn_ip.Size = new System.Drawing.Size(630, 65);
            this.btn_ip.TabIndex = 2;
            this.btn_ip.Text = "Kết nối";
            this.btn_ip.UseVisualStyleBackColor = false;
            this.btn_ip.Click += new System.EventHandler(this.btn_ip_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(277, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết Nối Bằng IP";
            // 
            // txt_ip
            // 
            this.txt_ip.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ip.Location = new System.Drawing.Point(252, 279);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.PlaceholderText = "192.168.1.17";
            this.txt_ip.Size = new System.Drawing.Size(466, 41);
            this.txt_ip.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(88, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(88, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập server";
            // 
            // txt_servername
            // 
            this.txt_servername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_servername.Location = new System.Drawing.Point(252, 356);
            this.txt_servername.Name = "txt_servername";
            this.txt_servername.PlaceholderText = "SQLSEVER2012";
            this.txt_servername.Size = new System.Drawing.Size(466, 41);
            this.txt_servername.TabIndex = 6;
            // 
            // ChonServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_servername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ip);
            this.Controls.Add(this.btn_local);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChonServer";
            this.Text = "ChonServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_local;
        private Button btn_ip;
        private Label label2;
        private TextBox txt_ip;
        private Label label3;
        private Label label4;
        private TextBox txt_servername;
    }
}