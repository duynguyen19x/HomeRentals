﻿namespace HomeRental.Views.Business.CustomerHomeRentals
{
    partial class FrmCustomerHomeNotRentals
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
            this.grcHomeRental = new DevExpress.XtraGrid.GridControl();
            this.grvHomeRental = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grcHomeRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHomeRental)).BeginInit();
            this.SuspendLayout();
            // 
            // grcHomeRental
            // 
            this.grcHomeRental.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcHomeRental.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grcHomeRental.Location = new System.Drawing.Point(36, 90);
            this.grcHomeRental.MainView = this.grvHomeRental;
            this.grcHomeRental.Margin = new System.Windows.Forms.Padding(22);
            this.grcHomeRental.Name = "grcHomeRental";
            this.grcHomeRental.Size = new System.Drawing.Size(1332, 514);
            this.grcHomeRental.TabIndex = 17;
            this.grcHomeRental.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHomeRental});
            // 
            // grvHomeRental
            // 
            this.grvHomeRental.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.grvHomeRental.DetailHeight = 512;
            this.grvHomeRental.GridControl = this.grcHomeRental;
            this.grvHomeRental.Name = "grvHomeRental";
            this.grvHomeRental.OptionsEditForm.PopupEditFormWidth = 2700;
            this.grvHomeRental.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.grvHomeRental.OptionsView.ShowGroupPanel = false;
            this.grvHomeRental.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhà";
            this.gridColumn1.FieldName = "HomeRentalCode";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 130;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Địa chỉ";
            this.gridColumn2.FieldName = "HomeRentalAddress";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 276;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mô tả";
            this.gridColumn3.FieldName = "HomeRentalDescription";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 451;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn giá";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "HomeRentalPrice";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 178;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Diện tích";
            this.gridColumn5.FieldName = "HomeRentalArea";
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 133;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tầng";
            this.gridColumn6.FieldName = "HomeRentalFloor";
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 157;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Hướng";
            this.gridColumn7.FieldName = "HomeRentalFacing";
            this.gridColumn7.MinWidth = 30;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 112;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(1256, 35);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(36, 27);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(22, 4, 4, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(425, 39);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Danh sách nhà chưa cho thuê";
            // 
            // FrmCustomerHomeNotRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 631);
            this.Controls.Add(this.grcHomeRental);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmCustomerHomeNotRentals";
            this.Text = "FrmCustomerHomeNotRentals";
            this.Load += new System.EventHandler(this.FrmCustomerHomeNotRentals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcHomeRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHomeRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcHomeRental;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHomeRental;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.LabelControl lblTitle;
    }
}