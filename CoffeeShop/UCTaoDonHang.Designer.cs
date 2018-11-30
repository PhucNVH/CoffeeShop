namespace CoffeeShop
{
    partial class UCTaoDonHang
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
            this.btnDonhang = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.pnDonhang = new System.Windows.Forms.Panel();
            this.lbBan = new System.Windows.Forms.Label();
            this.lbKhu = new System.Windows.Forms.Label();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.lbList = new System.Windows.Forms.Label();
            this.cbKhu = new System.Windows.Forms.ComboBox();
            this.txtDiscountPrice = new System.Windows.Forms.TextBox();
            this.lbHoaDon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbListMenu = new System.Windows.Forms.ComboBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDonHangMoi = new System.Windows.Forms.Button();
            this.lbTong = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nbSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.pnThanhToan = new System.Windows.Forms.Panel();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.cbZone = new System.Windows.Forms.ComboBox();
            this.pnDonhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).BeginInit();
            this.pnThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDonhang
            // 
            this.btnDonhang.Location = new System.Drawing.Point(31, 15);
            this.btnDonhang.Name = "btnDonhang";
            this.btnDonhang.Size = new System.Drawing.Size(89, 23);
            this.btnDonhang.TabIndex = 32;
            this.btnDonhang.Text = "Đơn hàng mới";
            this.btnDonhang.UseVisualStyleBackColor = true;
            this.btnDonhang.Click += new System.EventHandler(this.btnDonhang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(138, 15);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 33;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // pnDonhang
            // 
            this.pnDonhang.Controls.Add(this.lbBan);
            this.pnDonhang.Controls.Add(this.lbKhu);
            this.pnDonhang.Controls.Add(this.cbBan);
            this.pnDonhang.Controls.Add(this.lbList);
            this.pnDonhang.Controls.Add(this.cbKhu);
            this.pnDonhang.Controls.Add(this.txtDiscountPrice);
            this.pnDonhang.Controls.Add(this.lbHoaDon);
            this.pnDonhang.Controls.Add(this.label2);
            this.pnDonhang.Controls.Add(this.cbListMenu);
            this.pnDonhang.Controls.Add(this.txtDiscount);
            this.pnDonhang.Controls.Add(this.btnFinish);
            this.pnDonhang.Controls.Add(this.label1);
            this.pnDonhang.Controls.Add(this.btnDonHangMoi);
            this.pnDonhang.Controls.Add(this.lbTong);
            this.pnDonhang.Controls.Add(this.btnAdd);
            this.pnDonhang.Controls.Add(this.lvHoaDon);
            this.pnDonhang.Controls.Add(this.nbSoLuong);
            this.pnDonhang.Controls.Add(this.lbPrice);
            this.pnDonhang.Controls.Add(this.txtPrice);
            this.pnDonhang.Controls.Add(this.lbStock);
            this.pnDonhang.Controls.Add(this.txtStock);
            this.pnDonhang.Location = new System.Drawing.Point(9, 44);
            this.pnDonhang.Name = "pnDonhang";
            this.pnDonhang.Size = new System.Drawing.Size(888, 323);
            this.pnDonhang.TabIndex = 30;
            // 
            // lbBan
            // 
            this.lbBan.AutoSize = true;
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.Location = new System.Drawing.Point(290, 14);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(38, 20);
            this.lbBan.TabIndex = 26;
            this.lbBan.Text = "Bàn";
            // 
            // lbKhu
            // 
            this.lbKhu.AutoSize = true;
            this.lbKhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhu.Location = new System.Drawing.Point(24, 14);
            this.lbKhu.Name = "lbKhu";
            this.lbKhu.Size = new System.Drawing.Size(65, 20);
            this.lbKhu.TabIndex = 25;
            this.lbKhu.Text = "Khu vực";
            // 
            // cbBan
            // 
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Location = new System.Drawing.Point(347, 13);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(60, 21);
            this.cbBan.TabIndex = 1;
            // 
            // lbList
            // 
            this.lbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Location = new System.Drawing.Point(19, 66);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(119, 32);
            this.lbList.TabIndex = 11;
            this.lbList.Text = "Danh sách món";
            this.lbList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbKhu
            // 
            this.cbKhu.FormattingEnabled = true;
            this.cbKhu.Location = new System.Drawing.Point(144, 13);
            this.cbKhu.Name = "cbKhu";
            this.cbKhu.Size = new System.Drawing.Size(121, 21);
            this.cbKhu.TabIndex = 2;
            this.cbKhu.SelectedIndexChanged += new System.EventHandler(this.cbKhu_SelectedIndexChanged);
            // 
            // txtDiscountPrice
            // 
            this.txtDiscountPrice.Location = new System.Drawing.Point(144, 199);
            this.txtDiscountPrice.Name = "txtDiscountPrice";
            this.txtDiscountPrice.ReadOnly = true;
            this.txtDiscountPrice.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountPrice.TabIndex = 24;
            // 
            // lbHoaDon
            // 
            this.lbHoaDon.AutoSize = true;
            this.lbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoaDon.Location = new System.Drawing.Point(439, 14);
            this.lbHoaDon.Name = "lbHoaDon";
            this.lbHoaDon.Size = new System.Drawing.Size(73, 20);
            this.lbHoaDon.TabIndex = 0;
            this.lbHoaDon.Text = "Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Giá đã giảm";
            // 
            // cbListMenu
            // 
            this.cbListMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListMenu.FormattingEnabled = true;
            this.cbListMenu.Location = new System.Drawing.Point(144, 66);
            this.cbListMenu.Name = "cbListMenu";
            this.cbListMenu.Size = new System.Drawing.Size(149, 28);
            this.cbListMenu.TabIndex = 2;
            this.cbListMenu.SelectedIndexChanged += new System.EventHandler(this.cbListMenu_SelectedIndexChanged);
            this.cbListMenu.SelectionChangeCommitted += new System.EventHandler(this.cbListMenu_SelectionChangeCommitted);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(347, 143);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(84, 20);
            this.txtDiscount.TabIndex = 22;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(528, 256);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 39);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Hoàn tất";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Discount";
            // 
            // btnDonHangMoi
            // 
            this.btnDonHangMoi.Location = new System.Drawing.Point(654, 256);
            this.btnDonHangMoi.Name = "btnDonHangMoi";
            this.btnDonHangMoi.Size = new System.Drawing.Size(83, 39);
            this.btnDonHangMoi.TabIndex = 6;
            this.btnDonHangMoi.Text = "Đơn hàng mới";
            this.btnDonHangMoi.UseVisualStyleBackColor = true;
            this.btnDonHangMoi.Click += new System.EventHandler(this.btnDonHangMoi_Click);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(524, 233);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(53, 20);
            this.lbTong.TabIndex = 18;
            this.lbTong.Text = "Tổng: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(144, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chQuantity,
            this.chPrice,
            this.chTotal});
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.Location = new System.Drawing.Point(518, 13);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(343, 199);
            this.lvHoaDon.TabIndex = 17;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 30;
            // 
            // chName
            // 
            this.chName.Text = "Tên sản phẩm";
            this.chName.Width = 100;
            // 
            // chQuantity
            // 
            this.chQuantity.Text = "Số lượng";
            // 
            // chPrice
            // 
            this.chPrice.Text = "Đơn giá";
            // 
            // chTotal
            // 
            this.chTotal.Text = "Tổng";
            this.chTotal.Width = 70;
            // 
            // nbSoLuong
            // 
            this.nbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbSoLuong.Location = new System.Drawing.Point(347, 67);
            this.nbSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSoLuong.Name = "nbSoLuong";
            this.nbSoLuong.Size = new System.Drawing.Size(40, 26);
            this.nbSoLuong.TabIndex = 9;
            this.nbSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(25, 145);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(63, 18);
            this.lbPrice.TabIndex = 15;
            this.lbPrice.Text = "Giá Tiền";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(144, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(245, 200);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(96, 18);
            this.lbStock.TabIndex = 14;
            this.lbStock.Text = "Số lượng còn";
            this.lbStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(347, 196);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(84, 20);
            this.txtStock.TabIndex = 13;
            // 
            // pnThanhToan
            // 
            this.pnThanhToan.BackColor = System.Drawing.Color.White;
            this.pnThanhToan.Controls.Add(this.txtBill);
            this.pnThanhToan.Controls.Add(this.btnXacnhan);
            this.pnThanhToan.Controls.Add(this.pictureBox1);
            this.pnThanhToan.Controls.Add(this.label6);
            this.pnThanhToan.Controls.Add(this.label4);
            this.pnThanhToan.Controls.Add(this.label5);
            this.pnThanhToan.Controls.Add(this.cbTable);
            this.pnThanhToan.Controls.Add(this.cbZone);
            this.pnThanhToan.Location = new System.Drawing.Point(9, 44);
            this.pnThanhToan.Name = "pnThanhToan";
            this.pnThanhToan.Size = new System.Drawing.Size(888, 336);
            this.pnThanhToan.TabIndex = 31;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(143, 142);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(121, 20);
            this.txtBill.TabIndex = 36;
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Location = new System.Drawing.Point(144, 203);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(102, 47);
            this.btnXacnhan.TabIndex = 35;
            this.btnXacnhan.Text = "Thanh Toán";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeShop.Properties.Resources.thank_customer;
            this.pictureBox1.Location = new System.Drawing.Point(382, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 280);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tổng: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Bàn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Khu vực";
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(144, 98);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(121, 21);
            this.cbTable.TabIndex = 27;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // cbZone
            // 
            this.cbZone.FormattingEnabled = true;
            this.cbZone.Location = new System.Drawing.Point(144, 56);
            this.cbZone.Name = "cbZone";
            this.cbZone.Size = new System.Drawing.Size(121, 21);
            this.cbZone.TabIndex = 28;
            this.cbZone.SelectedIndexChanged += new System.EventHandler(this.cbZone_SelectedIndexChanged);
            // 
            // UCTaoDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDonhang);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.pnDonhang);
            this.Controls.Add(this.pnThanhToan);
            this.Name = "UCTaoDonHang";
            this.Size = new System.Drawing.Size(950, 410);
            this.Load += new System.EventHandler(this.UCTaoDonHang_Load);
            this.pnDonhang.ResumeLayout(false);
            this.pnDonhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).EndInit();
            this.pnThanhToan.ResumeLayout(false);
            this.pnThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDonhang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel pnDonhang;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label lbKhu;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.ComboBox cbKhu;
        private System.Windows.Forms.TextBox txtDiscountPrice;
        private System.Windows.Forms.Label lbHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbListMenu;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDonHangMoi;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chQuantity;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.NumericUpDown nbSoLuong;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Panel pnThanhToan;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.ComboBox cbZone;
    }
}
