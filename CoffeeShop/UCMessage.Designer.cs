namespace CoffeeShop
{
    partial class UCMessage
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lbNewMess = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lvMessage = new System.Windows.Forms.ListView();
            this.Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbReceiver = new System.Windows.Forms.Label();
            this.cbListUsername = new System.Windows.Forms.ComboBox();
            this.pnAdmin = new System.Windows.Forms.Panel();
            this.txtAdminMessage = new System.Windows.Forms.TextBox();
            this.btnSendAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(14, 251);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(600, 35);
            this.txtMessage.TabIndex = 16;
            // 
            // lbNewMess
            // 
            this.lbNewMess.AutoSize = true;
            this.lbNewMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMess.Location = new System.Drawing.Point(374, 17);
            this.lbNewMess.Name = "lbNewMess";
            this.lbNewMess.Size = new System.Drawing.Size(115, 18);
            this.lbNewMess.TabIndex = 15;
            this.lbNewMess.Text = "New Messages:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(14, 292);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 34);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lvMessage
            // 
            this.lvMessage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sender,
            this.Message});
            this.lvMessage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvMessage.Location = new System.Drawing.Point(13, 4);
            this.lvMessage.Name = "lvMessage";
            this.lvMessage.Size = new System.Drawing.Size(600, 241);
            this.lvMessage.TabIndex = 13;
            this.lvMessage.UseCompatibleStateImageBehavior = false;
            // 
            // Sender
            // 
            this.Sender.Text = "";
            // 
            // Message
            // 
            this.Message.Text = "";
            // 
            // lbReceiver
            // 
            this.lbReceiver.AutoSize = true;
            this.lbReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceiver.Location = new System.Drawing.Point(3, 17);
            this.lbReceiver.Name = "lbReceiver";
            this.lbReceiver.Size = new System.Drawing.Size(83, 18);
            this.lbReceiver.TabIndex = 12;
            this.lbReceiver.Text = "Người nhận";
            // 
            // cbListUsername
            // 
            this.cbListUsername.FormattingEnabled = true;
            this.cbListUsername.Location = new System.Drawing.Point(92, 14);
            this.cbListUsername.Name = "cbListUsername";
            this.cbListUsername.Size = new System.Drawing.Size(260, 21);
            this.cbListUsername.TabIndex = 11;
            this.cbListUsername.SelectedIndexChanged += new System.EventHandler(this.cbListUsername_SelectedIndexChanged);
            // 
            // pnAdmin
            // 
            this.pnAdmin.Controls.Add(this.btnSendAll);
            this.pnAdmin.Controls.Add(this.txtAdminMessage);
            this.pnAdmin.Location = new System.Drawing.Point(514, 41);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(384, 356);
            this.pnAdmin.TabIndex = 17;
            // 
            // txtAdminMessage
            // 
            this.txtAdminMessage.Location = new System.Drawing.Point(18, 4);
            this.txtAdminMessage.Multiline = true;
            this.txtAdminMessage.Name = "txtAdminMessage";
            this.txtAdminMessage.Size = new System.Drawing.Size(350, 282);
            this.txtAdminMessage.TabIndex = 17;
            // 
            // btnSendAll
            // 
            this.btnSendAll.Location = new System.Drawing.Point(152, 292);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(86, 34);
            this.btnSendAll.TabIndex = 18;
            this.btnSendAll.Text = "Gửi toàn bộ";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvMessage);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(78, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 338);
            this.panel1.TabIndex = 18;
            // 
            // UCMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbNewMess);
            this.Controls.Add(this.lbReceiver);
            this.Controls.Add(this.cbListUsername);
            this.Name = "UCMessage";
            this.Size = new System.Drawing.Size(900, 400);
            this.Load += new System.EventHandler(this.UCMessage_Load);
            this.pnAdmin.ResumeLayout(false);
            this.pnAdmin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lbNewMess;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListView lvMessage;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.Label lbReceiver;
        private System.Windows.Forms.ComboBox cbListUsername;
        private System.Windows.Forms.Panel pnAdmin;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.TextBox txtAdminMessage;
        private System.Windows.Forms.Panel panel1;
    }
}
