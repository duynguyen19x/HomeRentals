namespace HomeRental.Views.Business.CustomerHomeRentals
{
    partial class FrmCustomerHomeRentalDetails
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbbCustomer = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbbHomeRental = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spnHomeRentalPrice = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.spnHomeRentalArea = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtHomeRentalDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.spnHomeRentalFloor = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtHomeRentalFacingName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dteFromDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerHomeRentalCode = new DevExpress.XtraEditors.TextEdit();
            this.dteToDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.spnAmount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHomeRental.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHomeRentalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHomeRentalArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomeRentalDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHomeRentalFloor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomeRentalFacingName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerHomeRentalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(746, 441);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(862, 441);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(168, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(666, 39);
            this.labelControl1.TabIndex = 54;
            this.labelControl1.Text = "THÔNG TIN KHÁCH HÀNG ĐẶT THUÊ NHÀ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 115);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 19);
            this.labelControl2.TabIndex = 61;
            this.labelControl2.Text = "Mã khách hàng: (*)";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(411, 115);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(119, 19);
            this.labelControl3.TabIndex = 63;
            this.labelControl3.Text = "Tên khách hàng:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(536, 113);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(438, 26);
            this.txtCustomerName.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 148);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 19);
            this.labelControl4.TabIndex = 65;
            this.labelControl4.Text = "Mã nhà: (*)";
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.Location = new System.Drawing.Point(168, 113);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbCustomer.Properties.NullText = "";
            this.cbbCustomer.Properties.PopupView = this.gridLookUpEdit1View;
            this.cbbCustomer.Size = new System.Drawing.Size(213, 26);
            this.cbbCustomer.TabIndex = 3;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.DetailHeight = 349;
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cbbHomeRental
            // 
            this.cbbHomeRental.Location = new System.Drawing.Point(168, 145);
            this.cbbHomeRental.Name = "cbbHomeRental";
            this.cbbHomeRental.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbHomeRental.Properties.NullText = "";
            this.cbbHomeRental.Properties.PopupView = this.gridView1;
            this.cbbHomeRental.Size = new System.Drawing.Size(213, 26);
            this.cbbHomeRental.TabIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 349;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(411, 149);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(112, 19);
            this.labelControl5.TabIndex = 69;
            this.labelControl5.Text = "Đơn giá (ngày):";
            // 
            // spnHomeRentalPrice
            // 
            this.spnHomeRentalPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnHomeRentalPrice.Location = new System.Drawing.Point(536, 145);
            this.spnHomeRentalPrice.Name = "spnHomeRentalPrice";
            this.spnHomeRentalPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnHomeRentalPrice.Properties.ReadOnly = true;
            this.spnHomeRentalPrice.Size = new System.Drawing.Size(162, 28);
            this.spnHomeRentalPrice.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(738, 151);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 19);
            this.labelControl6.TabIndex = 71;
            this.labelControl6.Text = "Diện tích:";
            // 
            // spnHomeRentalArea
            // 
            this.spnHomeRentalArea.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnHomeRentalArea.Location = new System.Drawing.Point(812, 145);
            this.spnHomeRentalArea.Name = "spnHomeRentalArea";
            this.spnHomeRentalArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnHomeRentalArea.Properties.ReadOnly = true;
            this.spnHomeRentalArea.Size = new System.Drawing.Size(162, 28);
            this.spnHomeRentalArea.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(24, 183);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(76, 19);
            this.labelControl7.TabIndex = 73;
            this.labelControl7.Text = "Mô tả nhà:";
            // 
            // txtHomeRentalDescription
            // 
            this.txtHomeRentalDescription.Location = new System.Drawing.Point(168, 178);
            this.txtHomeRentalDescription.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtHomeRentalDescription.Name = "txtHomeRentalDescription";
            this.txtHomeRentalDescription.Properties.ReadOnly = true;
            this.txtHomeRentalDescription.Size = new System.Drawing.Size(806, 26);
            this.txtHomeRentalDescription.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(24, 216);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(73, 19);
            this.labelControl8.TabIndex = 75;
            this.labelControl8.Text = "Tầng nhà:";
            // 
            // spnHomeRentalFloor
            // 
            this.spnHomeRentalFloor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnHomeRentalFloor.Location = new System.Drawing.Point(168, 210);
            this.spnHomeRentalFloor.Name = "spnHomeRentalFloor";
            this.spnHomeRentalFloor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnHomeRentalFloor.Properties.ReadOnly = true;
            this.spnHomeRentalFloor.Size = new System.Drawing.Size(213, 28);
            this.spnHomeRentalFloor.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(411, 215);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(85, 19);
            this.labelControl9.TabIndex = 77;
            this.labelControl9.Text = "Hướng nhà:";
            // 
            // txtHomeRentalFacingName
            // 
            this.txtHomeRentalFacingName.Location = new System.Drawing.Point(536, 213);
            this.txtHomeRentalFacingName.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtHomeRentalFacingName.Name = "txtHomeRentalFacingName";
            this.txtHomeRentalFacingName.Properties.ReadOnly = true;
            this.txtHomeRentalFacingName.Size = new System.Drawing.Size(438, 26);
            this.txtHomeRentalFacingName.TabIndex = 9;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(24, 248);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(104, 19);
            this.labelControl10.TabIndex = 79;
            this.labelControl10.Text = "Ngày thuê (*):";
            // 
            // dteFromDate
            // 
            this.dteFromDate.EditValue = null;
            this.dteFromDate.Location = new System.Drawing.Point(168, 246);
            this.dteFromDate.Name = "dteFromDate";
            this.dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFromDate.Size = new System.Drawing.Size(213, 26);
            this.dteFromDate.TabIndex = 10;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(24, 83);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(119, 19);
            this.labelControl11.TabIndex = 81;
            this.labelControl11.Text = "Mã thuê nhà (*):";
            // 
            // txtCustomerHomeRentalCode
            // 
            this.txtCustomerHomeRentalCode.Location = new System.Drawing.Point(168, 80);
            this.txtCustomerHomeRentalCode.Name = "txtCustomerHomeRentalCode";
            this.txtCustomerHomeRentalCode.Size = new System.Drawing.Size(213, 26);
            this.txtCustomerHomeRentalCode.TabIndex = 0;
            // 
            // dteToDate
            // 
            this.dteToDate.EditValue = null;
            this.dteToDate.Location = new System.Drawing.Point(536, 246);
            this.dteToDate.Name = "dteToDate";
            this.dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteToDate.Properties.ReadOnly = true;
            this.dteToDate.Size = new System.Drawing.Size(162, 26);
            this.dteToDate.TabIndex = 82;
            this.dteToDate.EditValueChanged += new System.EventHandler(this.dteToDate_EditValueChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(411, 248);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(66, 19);
            this.labelControl12.TabIndex = 83;
            this.labelControl12.Text = "Ngày trả:";
            // 
            // spnAmount
            // 
            this.spnAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnAmount.Location = new System.Drawing.Point(812, 246);
            this.spnAmount.Name = "spnAmount";
            this.spnAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnAmount.Properties.ReadOnly = true;
            this.spnAmount.Size = new System.Drawing.Size(162, 28);
            this.spnAmount.TabIndex = 11;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(738, 251);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(48, 19);
            this.labelControl13.TabIndex = 85;
            this.labelControl13.Text = "T/tiền:";
            // 
            // FrmCustomerHomeRentalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 488);
            this.Controls.Add(this.spnAmount);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.dteToDate);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txtCustomerHomeRentalCode);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.dteFromDate);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtHomeRentalFacingName);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.spnHomeRentalFloor);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtHomeRentalDescription);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.spnHomeRentalArea);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.spnHomeRentalPrice);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cbbHomeRental);
            this.Controls.Add(this.cbbCustomer);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomerHomeRentalDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng thuê nhà";
            this.Load += new System.EventHandler(this.FrmCustomerHomeRentalDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHomeRental.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHomeRentalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHomeRentalArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomeRentalDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHomeRentalFloor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomeRentalFacingName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerHomeRentalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnAmount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GridLookUpEdit cbbCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit cbbHomeRental;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit spnHomeRentalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit spnHomeRentalArea;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtHomeRentalDescription;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SpinEdit spnHomeRentalFloor;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtHomeRentalFacingName;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit dteFromDate;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtCustomerHomeRentalCode;
        private DevExpress.XtraEditors.DateEdit dteToDate;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SpinEdit spnAmount;
        private DevExpress.XtraEditors.LabelControl labelControl13;
    }
}