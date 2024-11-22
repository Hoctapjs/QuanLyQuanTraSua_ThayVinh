namespace UngDung
{
    partial class PhanQuyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_quyen = new System.Windows.Forms.ComboBox();
            this.btn_capquyen = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cbo_username = new System.Windows.Forms.ComboBox();
            this.btn_thuhoiquyen = new System.Windows.Forms.Button();
            this.cbo_role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_xemquyen = new System.Windows.Forms.Button();
            this.txt_rolename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_thuhoiquyen_role = new System.Windows.Forms.Button();
            this.btn_capquyen_role = new System.Windows.Forms.Button();
            this.btn_tao_role = new System.Windows.Forms.Button();
            this.btn_themuser_role = new System.Windows.Forms.Button();
            this.btn_xoauser_role = new System.Windows.Forms.Button();
            this.btn_xem_user_trong_role = new System.Windows.Forms.Button();
            this.btn_xemrole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(238, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân Quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            // 
            // cbo_quyen
            // 
            this.cbo_quyen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_quyen.FormattingEnabled = true;
            this.cbo_quyen.Location = new System.Drawing.Point(167, 126);
            this.cbo_quyen.Name = "cbo_quyen";
            this.cbo_quyen.Size = new System.Drawing.Size(688, 43);
            this.cbo_quyen.TabIndex = 4;
            // 
            // btn_capquyen
            // 
            this.btn_capquyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_capquyen.Location = new System.Drawing.Point(879, 143);
            this.btn_capquyen.Name = "btn_capquyen";
            this.btn_capquyen.Size = new System.Drawing.Size(276, 52);
            this.btn_capquyen.TabIndex = 5;
            this.btn_capquyen.Text = "Cấp Quyền User";
            this.btn_capquyen.UseVisualStyleBackColor = true;
            this.btn_capquyen.Click += new System.EventHandler(this.btn_capquyen_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thoat.Location = new System.Drawing.Point(881, 395);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(276, 52);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbo_username
            // 
            this.cbo_username.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_username.FormattingEnabled = true;
            this.cbo_username.Location = new System.Drawing.Point(167, 189);
            this.cbo_username.Name = "cbo_username";
            this.cbo_username.Size = new System.Drawing.Size(688, 43);
            this.cbo_username.TabIndex = 7;
            // 
            // btn_thuhoiquyen
            // 
            this.btn_thuhoiquyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thuhoiquyen.Location = new System.Drawing.Point(880, 206);
            this.btn_thuhoiquyen.Name = "btn_thuhoiquyen";
            this.btn_thuhoiquyen.Size = new System.Drawing.Size(276, 52);
            this.btn_thuhoiquyen.TabIndex = 8;
            this.btn_thuhoiquyen.Text = "Thu Hồi Quyền User";
            this.btn_thuhoiquyen.UseVisualStyleBackColor = true;
            this.btn_thuhoiquyen.Click += new System.EventHandler(this.btn_thuhoiquyen_Click);
            // 
            // cbo_role
            // 
            this.cbo_role.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_role.FormattingEnabled = true;
            this.cbo_role.Location = new System.Drawing.Point(167, 255);
            this.cbo_role.Name = "cbo_role";
            this.cbo_role.Size = new System.Drawing.Size(688, 43);
            this.cbo_role.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(81, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Role";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 506);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 217);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_xemquyen
            // 
            this.btn_xemquyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xemquyen.Location = new System.Drawing.Point(881, 17);
            this.btn_xemquyen.Name = "btn_xemquyen";
            this.btn_xemquyen.Size = new System.Drawing.Size(276, 52);
            this.btn_xemquyen.TabIndex = 12;
            this.btn_xemquyen.Text = "Xem Quyền";
            this.btn_xemquyen.UseVisualStyleBackColor = true;
            this.btn_xemquyen.Click += new System.EventHandler(this.btn_xemquyen_Click);
            // 
            // txt_rolename
            // 
            this.txt_rolename.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_rolename.Location = new System.Drawing.Point(167, 321);
            this.txt_rolename.Name = "txt_rolename";
            this.txt_rolename.Size = new System.Drawing.Size(688, 41);
            this.txt_rolename.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "RoleName";
            // 
            // btn_thuhoiquyen_role
            // 
            this.btn_thuhoiquyen_role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thuhoiquyen_role.Location = new System.Drawing.Point(880, 332);
            this.btn_thuhoiquyen_role.Name = "btn_thuhoiquyen_role";
            this.btn_thuhoiquyen_role.Size = new System.Drawing.Size(276, 52);
            this.btn_thuhoiquyen_role.TabIndex = 16;
            this.btn_thuhoiquyen_role.Text = "Thu Hồi Quyền Role";
            this.btn_thuhoiquyen_role.UseVisualStyleBackColor = true;
            this.btn_thuhoiquyen_role.Click += new System.EventHandler(this.btn_thuhoiquyen_role_Click);
            // 
            // btn_capquyen_role
            // 
            this.btn_capquyen_role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_capquyen_role.Location = new System.Drawing.Point(879, 269);
            this.btn_capquyen_role.Name = "btn_capquyen_role";
            this.btn_capquyen_role.Size = new System.Drawing.Size(276, 52);
            this.btn_capquyen_role.TabIndex = 15;
            this.btn_capquyen_role.Text = "Cấp Quyền Role";
            this.btn_capquyen_role.UseVisualStyleBackColor = true;
            this.btn_capquyen_role.Click += new System.EventHandler(this.btn_capquyen_role_Click);
            // 
            // btn_tao_role
            // 
            this.btn_tao_role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tao_role.Location = new System.Drawing.Point(12, 399);
            this.btn_tao_role.Name = "btn_tao_role";
            this.btn_tao_role.Size = new System.Drawing.Size(169, 52);
            this.btn_tao_role.TabIndex = 17;
            this.btn_tao_role.Text = "Tạo Role";
            this.btn_tao_role.UseVisualStyleBackColor = true;
            this.btn_tao_role.Click += new System.EventHandler(this.btn_tao_role_Click);
            // 
            // btn_themuser_role
            // 
            this.btn_themuser_role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_themuser_role.Location = new System.Drawing.Point(195, 399);
            this.btn_themuser_role.Name = "btn_themuser_role";
            this.btn_themuser_role.Size = new System.Drawing.Size(209, 52);
            this.btn_themuser_role.TabIndex = 18;
            this.btn_themuser_role.Text = "Thêm User vào Role";
            this.btn_themuser_role.UseVisualStyleBackColor = true;
            this.btn_themuser_role.Click += new System.EventHandler(this.btn_themuser_role_Click);
            // 
            // btn_xoauser_role
            // 
            this.btn_xoauser_role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xoauser_role.Location = new System.Drawing.Point(418, 399);
            this.btn_xoauser_role.Name = "btn_xoauser_role";
            this.btn_xoauser_role.Size = new System.Drawing.Size(209, 52);
            this.btn_xoauser_role.TabIndex = 19;
            this.btn_xoauser_role.Text = "Xóa User khỏi Role";
            this.btn_xoauser_role.UseVisualStyleBackColor = true;
            this.btn_xoauser_role.Click += new System.EventHandler(this.btn_xoauser_role_Click);
            // 
            // btn_xem_user_trong_role
            // 
            this.btn_xem_user_trong_role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xem_user_trong_role.Location = new System.Drawing.Point(641, 399);
            this.btn_xem_user_trong_role.Name = "btn_xem_user_trong_role";
            this.btn_xem_user_trong_role.Size = new System.Drawing.Size(212, 52);
            this.btn_xem_user_trong_role.TabIndex = 20;
            this.btn_xem_user_trong_role.Text = "Xem User Trong Role";
            this.btn_xem_user_trong_role.UseVisualStyleBackColor = true;
            this.btn_xem_user_trong_role.Click += new System.EventHandler(this.btn_xem_user_trong_role_Click);
            // 
            // btn_xemrole
            // 
            this.btn_xemrole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xemrole.Location = new System.Drawing.Point(881, 80);
            this.btn_xemrole.Name = "btn_xemrole";
            this.btn_xemrole.Size = new System.Drawing.Size(276, 52);
            this.btn_xemrole.TabIndex = 21;
            this.btn_xemrole.Text = "Xem Role";
            this.btn_xemrole.UseVisualStyleBackColor = true;
            this.btn_xemrole.Click += new System.EventHandler(this.btn_xemrole_Click);
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UngDung.Properties.Resources.Layer_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1171, 735);
            this.Controls.Add(this.btn_xemrole);
            this.Controls.Add(this.btn_xem_user_trong_role);
            this.Controls.Add(this.btn_xoauser_role);
            this.Controls.Add(this.btn_themuser_role);
            this.Controls.Add(this.btn_tao_role);
            this.Controls.Add(this.btn_thuhoiquyen_role);
            this.Controls.Add(this.btn_capquyen_role);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_rolename);
            this.Controls.Add(this.btn_xemquyen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbo_role);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_thuhoiquyen);
            this.Controls.Add(this.cbo_username);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_capquyen);
            this.Controls.Add(this.cbo_quyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "PhanQuyen";
            this.Text = "PhanQuyen";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbo_quyen;
        private Button btn_capquyen;
        private Button btn_thoat;
        private ComboBox cbo_username;
        private Button btn_thuhoiquyen;
        private ComboBox cbo_role;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btn_xemquyen;
        private TextBox txt_rolename;
        private Label label5;
        private Button btn_thuhoiquyen_role;
        private Button btn_capquyen_role;
        private Button btn_tao_role;
        private Button btn_themuser_role;
        private Button btn_xoauser_role;
        private Button btn_xem_user_trong_role;
        private Button btn_xemrole;
    }
}