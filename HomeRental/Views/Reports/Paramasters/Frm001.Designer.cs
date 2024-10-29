namespace HomeRental.Views.Reports.Paramasters
{
    partial class Frm001
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dteFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dteToDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToDate.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dteToDate);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.dteFromDate);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tham số báo cáo";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 38);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Từ ngày:";
            // 
            // dteFromDate
            // 
            this.dteFromDate.EditValue = null;
            this.dteFromDate.Location = new System.Drawing.Point(89, 35);
            this.dteFromDate.Name = "dteFromDate";
            this.dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFromDate.Size = new System.Drawing.Size(214, 26);
            this.dteFromDate.TabIndex = 1;
            // 
            // dteToDate
            // 
            this.dteToDate.EditValue = null;
            this.dteToDate.Location = new System.Drawing.Point(392, 35);
            this.dteToDate.Name = "dteToDate";
            this.dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteToDate.Size = new System.Drawing.Size(214, 26);
            this.dteToDate.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(321, 38);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Từ ngày:";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(503, 126);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(135, 34);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "Hủy bỏ";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(362, 126);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(135, 34);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "Xem";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Frm001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 176);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm001";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo danh thu";
            this.Load += new System.EventHandler(this.Frm001_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dteToDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dteFromDate;
        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private DevExpress.XtraEditors.SimpleButton btnView;
    }
}