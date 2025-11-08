namespace Hệ_Thống_Quản_Lý_Thông_Tin_Game
{
    partial class Register_Form
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
            this.txtTenDK = new System.Windows.Forms.TextBox();
            this.txtMKDK = new System.Windows.Forms.TextBox();
            this.txtCMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.rdoUser = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbRegister = new System.Windows.Forms.TabPage();
            this.tbLogin = new System.Windows.Forms.TabPage();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoLUser = new System.Windows.Forms.RadioButton();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMKDN = new System.Windows.Forms.TextBox();
            this.rdoLAdmin = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbRegister.SuspendLayout();
            this.tbLogin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng ký";
            // 
            // txtTenDK
            // 
            this.txtTenDK.Location = new System.Drawing.Point(19, 53);
            this.txtTenDK.Name = "txtTenDK";
            this.txtTenDK.Size = new System.Drawing.Size(223, 22);
            this.txtTenDK.TabIndex = 1;
            // 
            // txtMKDK
            // 
            this.txtMKDK.Location = new System.Drawing.Point(19, 103);
            this.txtMKDK.Name = "txtMKDK";
            this.txtMKDK.Size = new System.Drawing.Size(223, 22);
            this.txtMKDK.TabIndex = 1;
            // 
            // txtCMK
            // 
            this.txtCMK.Location = new System.Drawing.Point(19, 152);
            this.txtCMK.Name = "txtCMK";
            this.txtCMK.Size = new System.Drawing.Size(223, 22);
            this.txtCMK.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoUser);
            this.groupBox1.Controls.Add(this.rdoAdmin);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnDangKy);
            this.groupBox1.Controls.Add(this.txtTenDK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCMK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMKDK);
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng ký";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(47, 219);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(128, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(19, 180);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(66, 20);
            this.rdoAdmin.TabIndex = 4;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Admin";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // rdoUser
            // 
            this.rdoUser.AutoSize = true;
            this.rdoUser.Location = new System.Drawing.Point(128, 180);
            this.rdoUser.Name = "rdoUser";
            this.rdoUser.Size = new System.Drawing.Size(57, 20);
            this.rdoUser.TabIndex = 4;
            this.rdoUser.TabStop = true;
            this.rdoUser.Text = "User";
            this.rdoUser.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbRegister);
            this.tabControl1.Controls.Add(this.tbLogin);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(407, 321);
            this.tabControl1.TabIndex = 4;
            // 
            // tbRegister
            // 
            this.tbRegister.Controls.Add(this.groupBox1);
            this.tbRegister.Location = new System.Drawing.Point(4, 25);
            this.tbRegister.Name = "tbRegister";
            this.tbRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegister.Size = new System.Drawing.Size(399, 292);
            this.tbRegister.TabIndex = 0;
            this.tbRegister.Text = "tabRegister";
            this.tbRegister.UseVisualStyleBackColor = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Controls.Add(this.groupBox2);
            this.tbLogin.Location = new System.Drawing.Point(4, 25);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbLogin.Size = new System.Drawing.Size(399, 292);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "tabLogin";
            this.tbLogin.UseVisualStyleBackColor = true;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(25, 48);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(195, 22);
            this.txtTenDN.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDangNhap);
            this.groupBox2.Controls.Add(this.rdoLAdmin);
            this.groupBox2.Controls.Add(this.rdoLUser);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMKDN);
            this.groupBox2.Controls.Add(this.txtTenDN);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên đăng nhập";
            // 
            // rdoLUser
            // 
            this.rdoLUser.AutoSize = true;
            this.rdoLUser.Location = new System.Drawing.Point(137, 140);
            this.rdoLUser.Name = "rdoLUser";
            this.rdoLUser.Size = new System.Drawing.Size(57, 20);
            this.rdoLUser.TabIndex = 2;
            this.rdoLUser.TabStop = true;
            this.rdoLUser.Text = "User";
            this.rdoLUser.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(76, 166);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(89, 23);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mật khẩu";
            // 
            // txtMKDN
            // 
            this.txtMKDN.Location = new System.Drawing.Point(25, 102);
            this.txtMKDN.Name = "txtMKDN";
            this.txtMKDN.Size = new System.Drawing.Size(195, 22);
            this.txtMKDN.TabIndex = 0;
            // 
            // rdoLAdmin
            // 
            this.rdoLAdmin.AutoSize = true;
            this.rdoLAdmin.Location = new System.Drawing.Point(28, 140);
            this.rdoLAdmin.Name = "rdoLAdmin";
            this.rdoLAdmin.Size = new System.Drawing.Size(66, 20);
            this.rdoLAdmin.TabIndex = 2;
            this.rdoLAdmin.TabStop = true;
            this.rdoLAdmin.Text = "Admin";
            this.rdoLAdmin.UseVisualStyleBackColor = true;
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 349);
            this.Controls.Add(this.tabControl1);
            this.Name = "Register_Form";
            this.Text = "Register_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbRegister.ResumeLayout(false);
            this.tbLogin.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDK;
        private System.Windows.Forms.TextBox txtMKDK;
        private System.Windows.Forms.TextBox txtCMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.RadioButton rdoUser;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbRegister;
        private System.Windows.Forms.TabPage tbLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.RadioButton rdoLUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMKDN;
        private System.Windows.Forms.RadioButton rdoLAdmin;
    }
}