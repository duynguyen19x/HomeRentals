namespace HomeRental.Views.Systems
{
    partial class FrmConnection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtDatabaseName = new DevExpress.XtraEditors.TextEdit();
            this.txtServerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateDatabase = new DevExpress.XtraEditors.SimpleButton();
            this.btnConnectDatabase = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtDatabaseName);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(597, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kết nối";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(132, 149);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(438, 26);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(132, 109);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(438, 26);
            this.txtUserName.TabIndex = 6;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(132, 69);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(438, 26);
            this.txtDatabaseName.TabIndex = 5;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(132, 29);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(438, 26);
            this.txtServerName.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 154);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(22, 5, 4, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Mật khẩu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 114);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(22, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tài khoản:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 74);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(22, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên CSDL:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 34);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(22, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Địa chỉ CSDL:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(468, 243);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Location = new System.Drawing.Point(312, 243);
            this.btnCreateDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(147, 35);
            this.btnCreateDatabase.TabIndex = 2;
            this.btnCreateDatabase.Text = "Tạo CSDL";
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // btnConnectDatabase
            // 
            this.btnConnectDatabase.Location = new System.Drawing.Point(156, 243);
            this.btnConnectDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnectDatabase.Name = "btnConnectDatabase";
            this.btnConnectDatabase.Size = new System.Drawing.Size(147, 35);
            this.btnConnectDatabase.TabIndex = 3;
            this.btnConnectDatabase.Text = "Kết nối CSDL";
            this.btnConnectDatabase.Click += new System.EventHandler(this.btnConnectDatabase_Click);
            // 
            // FrmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 297);
            this.Controls.Add(this.btnConnectDatabase);
            this.Controls.Add(this.btnCreateDatabase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConnection";
            this.Text = "Kết nối cơ sở dữ liệu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtDatabaseName;
        private DevExpress.XtraEditors.TextEdit txtServerName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnCreateDatabase;
        private DevExpress.XtraEditors.SimpleButton btnConnectDatabase;
    }
}