namespace CoffeeShop
{
    partial class Quanli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanli));
            this.linkThoat = new System.Windows.Forms.LinkLabel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabSanpham = new System.Windows.Forms.TabPage();
            this.tabThongke = new System.Windows.Forms.TabPage();
            this.tabNhanvien = new System.Windows.Forms.TabPage();
            this.tabTinnhan = new System.Windows.Forms.TabPage();
            this.tabThongtin = new System.Windows.Forms.TabPage();
            this.tabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkThoat
            // 
            this.linkThoat.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkThoat.AutoSize = true;
            this.linkThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkThoat.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkThoat.Location = new System.Drawing.Point(95, 4);
            this.linkThoat.Name = "linkThoat";
            this.linkThoat.Size = new System.Drawing.Size(50, 17);
            this.linkThoat.TabIndex = 4;
            this.linkThoat.TabStop = true;
            this.linkThoat.Text = "(thoát)";
            this.linkThoat.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkThoat_LinkClicked);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(1, 4);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(88, 18);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Chào admin";
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabSanpham);
            this.tabAdmin.Controls.Add(this.tabThongke);
            this.tabAdmin.Controls.Add(this.tabNhanvien);
            this.tabAdmin.Controls.Add(this.tabTinnhan);
            this.tabAdmin.Controls.Add(this.tabThongtin);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdmin.ItemSize = new System.Drawing.Size(60, 25);
            this.tabAdmin.Location = new System.Drawing.Point(0, 25);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(984, 456);
            this.tabAdmin.TabIndex = 5;
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            // 
            // tabSanpham
            // 
            this.tabSanpham.Location = new System.Drawing.Point(4, 29);
            this.tabSanpham.Name = "tabSanpham";
            this.tabSanpham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanpham.Size = new System.Drawing.Size(976, 423);
            this.tabSanpham.TabIndex = 0;
            this.tabSanpham.Text = "Sản phẩm";
            this.tabSanpham.UseVisualStyleBackColor = true;
            // 
            // tabThongke
            // 
            this.tabThongke.Location = new System.Drawing.Point(4, 29);
            this.tabThongke.Name = "tabThongke";
            this.tabThongke.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongke.Size = new System.Drawing.Size(976, 423);
            this.tabThongke.TabIndex = 1;
            this.tabThongke.Text = "Thống kê";
            this.tabThongke.UseVisualStyleBackColor = true;
            // 
            // tabNhanvien
            // 
            this.tabNhanvien.Location = new System.Drawing.Point(4, 29);
            this.tabNhanvien.Name = "tabNhanvien";
            this.tabNhanvien.Size = new System.Drawing.Size(976, 423);
            this.tabNhanvien.TabIndex = 2;
            this.tabNhanvien.Text = "Nhân viên";
            this.tabNhanvien.UseVisualStyleBackColor = true;
            // 
            // tabTinnhan
            // 
            this.tabTinnhan.Location = new System.Drawing.Point(4, 29);
            this.tabTinnhan.Name = "tabTinnhan";
            this.tabTinnhan.Size = new System.Drawing.Size(976, 423);
            this.tabTinnhan.TabIndex = 3;
            this.tabTinnhan.Text = "Tin nhắn";
            this.tabTinnhan.UseVisualStyleBackColor = true;
            // 
            // tabThongtin
            // 
            this.tabThongtin.Location = new System.Drawing.Point(4, 29);
            this.tabThongtin.Name = "tabThongtin";
            this.tabThongtin.Size = new System.Drawing.Size(976, 423);
            this.tabThongtin.TabIndex = 4;
            this.tabThongtin.Text = "Đổi thông tin";
            this.tabThongtin.UseVisualStyleBackColor = true;
            // 
            // Quanli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.linkThoat);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Quanli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coffeeshop QuanLi";
            this.Load += new System.EventHandler(this.Quanli_Load);
            this.tabAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkThoat;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabSanpham;
        private System.Windows.Forms.TabPage tabThongke;
        private System.Windows.Forms.TabPage tabNhanvien;
        private System.Windows.Forms.TabPage tabTinnhan;
        private System.Windows.Forms.TabPage tabThongtin;
    }
}