namespace CoffeeShop
{
    partial class UCQuanliNhanvien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.pnThongtinNV = new System.Windows.Forms.Panel();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDoiThongTinTK = new System.Windows.Forms.Panel();
            this.lblViewUN = new System.Windows.Forms.Label();
            this.txtViewUN = new System.Windows.Forms.TextBox();
            this.cbIsSuspended = new System.Windows.Forms.CheckBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChangePassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtChangeFullname = new System.Windows.Forms.TextBox();
            this.txtChangePhoneNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbListAccount = new System.Windows.Forms.ComboBox();
            this.pnTaoTKMoi = new System.Windows.Forms.Panel();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.dpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPhonenum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dpDoiNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.pnThongtinNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.pnDoiThongTinTK.SuspendLayout();
            this.pnTaoTKMoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(54, 39);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(85, 44);
            this.btnInfo.TabIndex = 17;
            this.btnInfo.Text = "Xem thông tin";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(54, 171);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(85, 42);
            this.btnChangeInfo.TabIndex = 19;
            this.btnChangeInfo.Text = "Thay đổi thông tin";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(54, 104);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(85, 45);
            this.btnNewAccount.TabIndex = 18;
            this.btnNewAccount.Text = "Tạo tài khoản mới";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // pnThongtinNV
            // 
            this.pnThongtinNV.BackColor = System.Drawing.Color.White;
            this.pnThongtinNV.Controls.Add(this.dgvStaff);
            this.pnThongtinNV.Location = new System.Drawing.Point(237, 12);
            this.pnThongtinNV.Name = "pnThongtinNV";
            this.pnThongtinNV.Size = new System.Drawing.Size(713, 385);
            this.pnThongtinNV.TabIndex = 21;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Username,
            this.Column2});
            this.dgvStaff.Location = new System.Drawing.Point(26, 3);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.Size = new System.Drawing.Size(645, 345);
            this.dgvStaff.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Fullname";
            this.Column1.HeaderText = "FullName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "PhoneNumber";
            this.Column2.HeaderText = "Phone Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // pnDoiThongTinTK
            // 
            this.pnDoiThongTinTK.BackColor = System.Drawing.Color.White;
            this.pnDoiThongTinTK.Controls.Add(this.label1);
            this.pnDoiThongTinTK.Controls.Add(this.dpDoiNgaysinh);
            this.pnDoiThongTinTK.Controls.Add(this.lblViewUN);
            this.pnDoiThongTinTK.Controls.Add(this.txtViewUN);
            this.pnDoiThongTinTK.Controls.Add(this.cbIsSuspended);
            this.pnDoiThongTinTK.Controls.Add(this.lblChangePassword);
            this.pnDoiThongTinTK.Controls.Add(this.label4);
            this.pnDoiThongTinTK.Controls.Add(this.txtChangePassword);
            this.pnDoiThongTinTK.Controls.Add(this.label6);
            this.pnDoiThongTinTK.Controls.Add(this.btnChange);
            this.pnDoiThongTinTK.Controls.Add(this.txtChangeFullname);
            this.pnDoiThongTinTK.Controls.Add(this.txtChangePhoneNum);
            this.pnDoiThongTinTK.Controls.Add(this.label3);
            this.pnDoiThongTinTK.Controls.Add(this.cbListAccount);
            this.pnDoiThongTinTK.Location = new System.Drawing.Point(234, 3);
            this.pnDoiThongTinTK.Name = "pnDoiThongTinTK";
            this.pnDoiThongTinTK.Size = new System.Drawing.Size(713, 385);
            this.pnDoiThongTinTK.TabIndex = 22;
            // 
            // lblViewUN
            // 
            this.lblViewUN.AutoSize = true;
            this.lblViewUN.Location = new System.Drawing.Point(20, 68);
            this.lblViewUN.Name = "lblViewUN";
            this.lblViewUN.Size = new System.Drawing.Size(55, 13);
            this.lblViewUN.TabIndex = 27;
            this.lblViewUN.Text = "Username";
            // 
            // txtViewUN
            // 
            this.txtViewUN.Location = new System.Drawing.Point(108, 61);
            this.txtViewUN.Name = "txtViewUN";
            this.txtViewUN.ReadOnly = true;
            this.txtViewUN.Size = new System.Drawing.Size(100, 20);
            this.txtViewUN.TabIndex = 1;
            // 
            // cbIsSuspended
            // 
            this.cbIsSuspended.AutoSize = true;
            this.cbIsSuspended.Location = new System.Drawing.Point(260, 146);
            this.cbIsSuspended.Name = "cbIsSuspended";
            this.cbIsSuspended.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbIsSuspended.Size = new System.Drawing.Size(98, 17);
            this.cbIsSuspended.TabIndex = 5;
            this.cbIsSuspended.Text = "Khóa tài khoản";
            this.cbIsSuspended.UseVisualStyleBackColor = true;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Location = new System.Drawing.Point(20, 153);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(53, 13);
            this.lblChangePassword.TabIndex = 24;
            this.lblChangePassword.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "PhoneNumber";
            // 
            // txtChangePassword
            // 
            this.txtChangePassword.Location = new System.Drawing.Point(108, 146);
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.PasswordChar = '●';
            this.txtChangePassword.Size = new System.Drawing.Size(100, 20);
            this.txtChangePassword.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fullname";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(108, 177);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtChangeFullname
            // 
            this.txtChangeFullname.Location = new System.Drawing.Point(338, 58);
            this.txtChangeFullname.Name = "txtChangeFullname";
            this.txtChangeFullname.Size = new System.Drawing.Size(100, 20);
            this.txtChangeFullname.TabIndex = 3;
            // 
            // txtChangePhoneNum
            // 
            this.txtChangePhoneNum.Location = new System.Drawing.Point(108, 102);
            this.txtChangePhoneNum.Name = "txtChangePhoneNum";
            this.txtChangePhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txtChangePhoneNum.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên tài khoản";
            // 
            // cbListAccount
            // 
            this.cbListAccount.DisplayMember = "Username";
            this.cbListAccount.FormattingEnabled = true;
            this.cbListAccount.Location = new System.Drawing.Point(108, 26);
            this.cbListAccount.Name = "cbListAccount";
            this.cbListAccount.Size = new System.Drawing.Size(121, 21);
            this.cbListAccount.TabIndex = 0;
            this.cbListAccount.ValueMember = "Username";
            this.cbListAccount.SelectedIndexChanged += new System.EventHandler(this.cbListAccount_SelectedIndexChanged);
            // 
            // pnTaoTKMoi
            // 
            this.pnTaoTKMoi.BackColor = System.Drawing.Color.White;
            this.pnTaoTKMoi.Controls.Add(this.lbNgaySinh);
            this.pnTaoTKMoi.Controls.Add(this.dpNgaySinh);
            this.pnTaoTKMoi.Controls.Add(this.txtPassword2);
            this.pnTaoTKMoi.Controls.Add(this.lblPassword2);
            this.pnTaoTKMoi.Controls.Add(this.lblUsername);
            this.pnTaoTKMoi.Controls.Add(this.lblPhoneNumber);
            this.pnTaoTKMoi.Controls.Add(this.txtUsername);
            this.pnTaoTKMoi.Controls.Add(this.txtPassword);
            this.pnTaoTKMoi.Controls.Add(this.lblFullname);
            this.pnTaoTKMoi.Controls.Add(this.btnCreate);
            this.pnTaoTKMoi.Controls.Add(this.txtFullname);
            this.pnTaoTKMoi.Controls.Add(this.lblPassword);
            this.pnTaoTKMoi.Controls.Add(this.txtPhonenum);
            this.pnTaoTKMoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTaoTKMoi.Location = new System.Drawing.Point(237, 0);
            this.pnTaoTKMoi.Name = "pnTaoTKMoi";
            this.pnTaoTKMoi.Size = new System.Drawing.Size(713, 400);
            this.pnTaoTKMoi.TabIndex = 20;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(260, 125);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaySinh.TabIndex = 16;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // dpNgaySinh
            // 
            this.dpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNgaySinh.Location = new System.Drawing.Point(344, 118);
            this.dpNgaySinh.Name = "dpNgaySinh";
            this.dpNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.dpNgaySinh.TabIndex = 15;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(116, 118);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '●';
            this.txtPassword2.Size = new System.Drawing.Size(116, 20);
            this.txtPassword2.TabIndex = 2;
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(23, 125);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(95, 13);
            this.lblPassword2.TabIndex = 14;
            this.lblPassword2.Text = "Nhập lại Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(23, 46);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(260, 86);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(75, 13);
            this.lblPhoneNumber.TabIndex = 12;
            this.lblPhoneNumber.Text = "PhoneNumber";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(116, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(116, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(116, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(260, 46);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(49, 13);
            this.lblFullname.TabIndex = 9;
            this.lblFullname.Text = "Fullname";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(137, 163);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 33);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(344, 39);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(100, 20);
            this.txtFullname.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtPhonenum
            // 
            this.txtPhonenum.Location = new System.Drawing.Point(344, 78);
            this.txtPhonenum.Name = "txtPhonenum";
            this.txtPhonenum.Size = new System.Drawing.Size(100, 20);
            this.txtPhonenum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ngày sinh";
            // 
            // dpDoiNgaysinh
            // 
            this.dpDoiNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDoiNgaysinh.Location = new System.Drawing.Point(338, 99);
            this.dpDoiNgaysinh.Name = "dpDoiNgaysinh";
            this.dpDoiNgaysinh.Size = new System.Drawing.Size(100, 20);
            this.dpDoiNgaysinh.TabIndex = 4;
            // 
            // UCQuanliNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.pnThongtinNV);
            this.Controls.Add(this.pnTaoTKMoi);
            this.Controls.Add(this.pnDoiThongTinTK);
            this.Name = "UCQuanliNhanvien";
            this.Size = new System.Drawing.Size(950, 400);
            this.Load += new System.EventHandler(this.UCNhanvienManager_Load);
            this.pnThongtinNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.pnDoiThongTinTK.ResumeLayout(false);
            this.pnDoiThongTinTK.PerformLayout();
            this.pnTaoTKMoi.ResumeLayout(false);
            this.pnTaoTKMoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Panel pnThongtinNV;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel pnDoiThongTinTK;
        private System.Windows.Forms.Label lblViewUN;
        private System.Windows.Forms.TextBox txtViewUN;
        private System.Windows.Forms.CheckBox cbIsSuspended;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChangePassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtChangeFullname;
        private System.Windows.Forms.TextBox txtChangePhoneNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbListAccount;
        private System.Windows.Forms.Panel pnTaoTKMoi;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPhonenum;
        private System.Windows.Forms.DateTimePicker dpNgaySinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpDoiNgaysinh;
    }
}
