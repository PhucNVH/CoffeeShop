namespace CoffeeShop
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.linkThoat = new System.Windows.Forms.LinkLabel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabNhanvien = new System.Windows.Forms.TabControl();
            this.tabThanhtoan = new System.Windows.Forms.TabPage();
            this.tabTinnhan = new System.Windows.Forms.TabPage();
            this.tabThongtin = new System.Windows.Forms.TabPage();
            this.tabNhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkThoat
            // 
            this.linkThoat.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkThoat.AutoSize = true;
            this.linkThoat.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkThoat.Location = new System.Drawing.Point(77, 9);
            this.linkThoat.Name = "linkThoat";
            this.linkThoat.Size = new System.Drawing.Size(37, 13);
            this.linkThoat.TabIndex = 5;
            this.linkThoat.TabStop = true;
            this.linkThoat.Text = "(thoát)";
            this.linkThoat.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkThoat_LinkClicked);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(35, 13);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Chào ";
            // 
            // tabNhanvien
            // 
            this.tabNhanvien.Controls.Add(this.tabThanhtoan);
            this.tabNhanvien.Controls.Add(this.tabTinnhan);
            this.tabNhanvien.Controls.Add(this.tabThongtin);
            this.tabNhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNhanvien.ItemSize = new System.Drawing.Size(60, 30);
            this.tabNhanvien.Location = new System.Drawing.Point(0, 25);
            this.tabNhanvien.Name = "tabNhanvien";
            this.tabNhanvien.SelectedIndex = 0;
            this.tabNhanvien.Size = new System.Drawing.Size(984, 456);
            this.tabNhanvien.TabIndex = 6;
            this.tabNhanvien.SelectedIndexChanged += new System.EventHandler(this.tabNhanvien_SelectedIndexChanged);
            // 
            // tabThanhtoan
            // 
            this.tabThanhtoan.Location = new System.Drawing.Point(4, 34);
            this.tabThanhtoan.Name = "tabThanhtoan";
            this.tabThanhtoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabThanhtoan.Size = new System.Drawing.Size(976, 418);
            this.tabThanhtoan.TabIndex = 0;
            this.tabThanhtoan.Text = "Gọi món";
            this.tabThanhtoan.UseVisualStyleBackColor = true;
            // 
            // tabTinnhan
            // 
            this.tabTinnhan.Location = new System.Drawing.Point(4, 34);
            this.tabTinnhan.Name = "tabTinnhan";
            this.tabTinnhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabTinnhan.Size = new System.Drawing.Size(976, 407);
            this.tabTinnhan.TabIndex = 1;
            this.tabTinnhan.Text = "Tin nhắn";
            this.tabTinnhan.UseVisualStyleBackColor = true;
            // 
            // tabThongtin
            // 
            this.tabThongtin.Location = new System.Drawing.Point(4, 34);
            this.tabThongtin.Name = "tabThongtin";
            this.tabThongtin.Size = new System.Drawing.Size(976, 418);
            this.tabThongtin.TabIndex = 2;
            this.tabThongtin.Text = "Thông tin";
            this.tabThongtin.UseVisualStyleBackColor = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.tabNhanvien);
            this.Controls.Add(this.linkThoat);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoffeeShop NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tabNhanvien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkThoat;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl tabNhanvien;
        private System.Windows.Forms.TabPage tabThanhtoan;
        private System.Windows.Forms.TabPage tabTinnhan;
        private System.Windows.Forms.TabPage tabThongtin;
    }
}