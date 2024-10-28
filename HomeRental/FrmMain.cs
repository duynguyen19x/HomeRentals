using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using HomeRental.Presenters.Systems;
using HomeRental.Views.Business.CustomerHomeRentals;
using HomeRental.Views.Business.Customers;
using HomeRental.Views.Business.HomeRentals;
using HomeRental.Views.Business.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HomeRental
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LogoutPresenter _logoutPresenter;

        public FrmMain()
        {
            InitializeComponent();
            _logoutPresenter = new LogoutPresenter();
        }

        #region Function

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logoutPresenter.CloseConnectDatabase();
            Application.Exit();
        }

        private void TabCreate(XtraForm frm, string tabTitle = null)
        {
            var tabPageSelected = GetTabPageSelected("tab_" + frm.Name);
            if (tabPageSelected != null)
            {
                xtraTabControl.SelectedTabPage = tabPageSelected;
                xtraTabControl.SelectedTabPage.Text = tabTitle ?? frm.Text;
            }
            else
            {
                XtraTabPage tabPage = new XtraTabPage { Text = tabTitle ?? frm.Text };
                tabPage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                tabPage.AutoScroll = true;
                tabPage.AutoScrollMargin = new Size(20, 20);
                tabPage.AutoScrollMinSize = new Size(tabPage.Width, tabPage.Height);
                tabPage.Name = "tab_" + frm.Name;

                xtraTabControl.TabPages.Add(tabPage);
                xtraTabControl.SelectedTabPage = tabPage;

                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private XtraTabPage GetTabPageSelected(string frmName)
        {
            return xtraTabControl.TabPages.FirstOrDefault(f => f.Name == frmName);
        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                XtraTabControl TabControl = (XtraTabControl)sender;
                int i = TabControl.SelectedTabPageIndex;
                TabControl.TabPages[i].Dispose();
                if (i > 0)
                    TabControl.SelectedTabPageIndex = i - 1;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmUsers();
            TabCreate(frm);
        }

        private void btnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmCustomers();
            TabCreate(frm);
        }

        private void btnHomeRental_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmHomeRentals();
            TabCreate(frm);
        }

        private void btnCustomerHomeRental_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmCustomerHomeRentals();
            TabCreate(frm);
        }

        private void skinRibbonGalleryBarItem_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            if (e != null && e.Item != null && e.Item.Value != null)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("SkinName");
                //config.AppSettings.Settings.Add("SkinName", UserLookAndFeel.Default.ActiveSkinName);
                config.AppSettings.Settings.Add("SkinName", e.Item.Value.ToString());
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        #endregion
    }
}
