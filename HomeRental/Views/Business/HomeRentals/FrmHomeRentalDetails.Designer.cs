namespace HomeRental.Views.Business.HomeRentals
{
    partial class FrmHomeRentalDetails
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbbFacing = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.spnPrice = new DevExpress.XtraEditors.SpinEdit();
            this.spnFloor = new DevExpress.XtraEditors.SpinEdit();
            this.spnArea = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbFacing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFloor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnArea.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(301, 287);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(380, 287);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(112, 147);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(343, 66);
            this.txtAddress.TabIndex = 32;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 149);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Địa chỉ:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(112, 53);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(142, 20);
            this.txtCode.TabIndex = 26;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 55);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Mã nhà: (*)";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(93, 8);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(290, 25);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "THÔNG TIN NHÀ CHO THUÊ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(112, 77);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(343, 66);
            this.txtDescription.TabIndex = 42;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 79);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Mô tả nhà:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(266, 219);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 45;
            this.labelControl7.Text = "Diện tích: (*)";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 219);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 13);
            this.labelControl6.TabIndex = 43;
            this.labelControl6.Text = "Giá theo tháng: (*)";
            // 
            // cbbFacing
            // 
            this.cbbFacing.EditValue = "Đông";
            this.cbbFacing.Location = new System.Drawing.Point(331, 241);
            this.cbbFacing.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFacing.Name = "cbbFacing";
            this.cbbFacing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbFacing.Properties.Items.AddRange(new object[] {
            "Đông",
            "Tây",
            "Bắc",
            "Nam",
            "Đông Bắc",
            "Tây Bắc",
            "Tây Nam",
            "Đông Nam"});
            this.cbbFacing.Size = new System.Drawing.Size(124, 20);
            this.cbbFacing.TabIndex = 50;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(266, 243);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 49;
            this.labelControl4.Text = "Hướng: (*)";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(15, 243);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 13);
            this.labelControl8.TabIndex = 47;
            this.labelControl8.Text = "Tầng: (*)";
            // 
            // spnPrice
            // 
            this.spnPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPrice.Location = new System.Drawing.Point(112, 217);
            this.spnPrice.Name = "spnPrice";
            this.spnPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnPrice.Size = new System.Drawing.Size(142, 20);
            this.spnPrice.TabIndex = 51;
            // 
            // spnFloor
            // 
            this.spnFloor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnFloor.Location = new System.Drawing.Point(112, 241);
            this.spnFloor.Name = "spnFloor";
            this.spnFloor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnFloor.Size = new System.Drawing.Size(142, 20);
            this.spnFloor.TabIndex = 52;
            // 
            // spnArea
            // 
            this.spnArea.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnArea.Location = new System.Drawing.Point(331, 217);
            this.spnArea.Name = "spnArea";
            this.spnArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnArea.Size = new System.Drawing.Size(124, 20);
            this.spnArea.TabIndex = 53;
            // 
            // FrmHomeRentalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 319);
            this.Controls.Add(this.spnArea);
            this.Controls.Add(this.spnFloor);
            this.Controls.Add(this.spnPrice);
            this.Controls.Add(this.cbbFacing);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHomeRentalDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cho thuê";
            this.Load += new System.EventHandler(this.FrmHomeRentalDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbFacing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFloor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnArea.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cbbFacing;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SpinEdit spnPrice;
        private DevExpress.XtraEditors.SpinEdit spnFloor;
        private DevExpress.XtraEditors.SpinEdit spnArea;
    }
}