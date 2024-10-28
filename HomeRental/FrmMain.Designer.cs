namespace HomeRental
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnUser = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnHomeRental = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateDatabase = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnCustomerHomeRental = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rplUserGrpup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnUser,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btnCustomer,
            this.btnHomeRental,
            this.btnCreateDatabase,
            this.btnRestore,
            this.btnBackup,
            this.skinRibbonGalleryBarItem,
            this.btnCustomerHomeRental});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1176, 158);
            // 
            // btnUser
            // 
            this.btnUser.Caption = "Người dùng";
            this.btnUser.Id = 1;
            this.btnUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUser.ImageOptions.LargeImage")));
            this.btnUser.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnUser.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnUser.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnUser.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnUser.Name = "btnUser";
            this.btnUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUser_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "Khách hàng";
            this.btnCustomer.Id = 6;
            this.btnCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ImageOptions.LargeImage")));
            this.btnCustomer.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnCustomer.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnCustomer.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnCustomer.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // btnHomeRental
            // 
            this.btnHomeRental.Caption = "Nhà cho thuê";
            this.btnHomeRental.Id = 7;
            this.btnHomeRental.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeRental.ImageOptions.Image")));
            this.btnHomeRental.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHomeRental.ImageOptions.LargeImage")));
            this.btnHomeRental.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnHomeRental.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnHomeRental.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnHomeRental.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnHomeRental.Name = "btnHomeRental";
            this.btnHomeRental.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHomeRental_ItemClick);
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Caption = "Khởi tạo CSDL";
            this.btnCreateDatabase.Id = 8;
            this.btnCreateDatabase.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCreateDatabase.ImageOptions.LargeImage")));
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Khôi phục CSDL";
            this.btnRestore.Id = 9;
            this.btnRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.LargeImage")));
            this.btnRestore.Name = "btnRestore";
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu CSDL";
            this.btnBackup.Id = 10;
            this.btnBackup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.LargeImage")));
            this.btnBackup.Name = "btnBackup";
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Caption = "Giao diện";
            this.skinRibbonGalleryBarItem.Id = 11;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            this.skinRibbonGalleryBarItem.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.skinRibbonGalleryBarItem_GalleryItemClick);
            // 
            // btnCustomerHomeRental
            // 
            this.btnCustomerHomeRental.Caption = "Thuê nhà";
            this.btnCustomerHomeRental.Id = 12;
            this.btnCustomerHomeRental.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.btnCustomerHomeRental.Name = "btnCustomerHomeRental";
            this.btnCustomerHomeRental.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomerHomeRental_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rplUserGrpup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh mục";
            // 
            // rplUserGrpup
            // 
            this.rplUserGrpup.ItemLinks.Add(this.btnUser);
            this.rplUserGrpup.ItemLinks.Add(this.btnCustomer);
            this.rplUserGrpup.ItemLinks.Add(this.btnHomeRental);
            this.rplUserGrpup.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.rplUserGrpup.Name = "rplUserGrpup";
            this.rplUserGrpup.Text = "Quản lý người dùng";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Nhà cho thuê";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCustomerHomeRental);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý nhà cho thuê";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCreateDatabase);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRestore);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBackup);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Cơ sở dữ liệu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Giao diện";
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 158);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.Size = new System.Drawing.Size(1176, 488);
            this.xtraTabControl.TabIndex = 3;
            this.xtraTabControl.CloseButtonClick += new System.EventHandler(this.xtraTabControl_CloseButtonClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 646);
            this.Controls.Add(this.xtraTabControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THUÊ NHÀ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rplUserGrpup;
        private DevExpress.XtraBars.BarButtonItem btnUser;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.XtraBars.BarButtonItem btnHomeRental;
        private DevExpress.XtraBars.BarButtonItem btnCreateDatabase;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.BarButtonItem btnCustomerHomeRental;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}

