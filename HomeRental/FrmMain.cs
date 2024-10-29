using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using HomeRental.Presenters.Systems;
using HomeRental.Views.Business.CustomerHomeRentals;
using HomeRental.Views.Business.Customers;
using HomeRental.Views.Business.HomeRentals;
using HomeRental.Views.Business.Users;
using HomeRental.Views.Reports.Paramasters;
using HomeRental.Views.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HomeRental
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly LogoutPresenter _logoutPresenter;
        private readonly DatabasePresenter _databasePresenter;
        private readonly FrmLogin _frmLogin;

        public FrmMain()
        {
            InitializeComponent();
            _logoutPresenter = new LogoutPresenter();
            _databasePresenter = new DatabasePresenter();
        }

        public FrmMain(FrmLogin frmLogin) : this()
        {
            _frmLogin = frmLogin;
        }

        #region Member
        public bool IsRestart { get; set; }
        #endregion

        #region Function

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _frmLogin.Hide();
            IsRestart = false;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsRestart)
            {
                _logoutPresenter.CloseConnectDatabase();
                Application.Exit();
            }
            else
            {
                this.Close();
            }
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

        #region Danh mục
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
        #endregion

        #region Nhà cho thuê
        private void btnCustomerHomeRental_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmCustomerHomeRentals();
            TabCreate(frm);
        }

        private void btnNotRented_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmCustomerHomeNotRentals();
            TabCreate(frm);
        }
        #endregion

        #region Hệ thống
        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog() { Title = "Chọn file dữ liệu để tiến hành khôi phục CSDL", Filter = "SQL Server Backup Files (*.bak)|*.bak" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Lấy đường dẫn đầy đủ của file đã chọn
                        string filePath = openFileDialog.FileName;

                        // Lấy tên file từ đường dẫn
                        string databaseName = Path.GetFileName(filePath);

                        var serverName = string.Empty;
                        var userName = string.Empty;
                        var password = string.Empty;

                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        if (ConfigurationManager.AppSettings["ServerName"] != null)
                            serverName = config.AppSettings.Settings["ServerName"].Value;

                        if (ConfigurationManager.AppSettings["UserName"] != null)
                            userName = config.AppSettings.Settings["UserName"].Value;

                        if (ConfigurationManager.AppSettings["Password"] != null)
                            password = config.AppSettings.Settings["Password"].Value;

                        var result = _databasePresenter.RestoreDatabase(serverName, userName, password, databaseName, filePath);
                        if (result.Success)
                        {
                            if (ConfigurationManager.AppSettings["ServerName"] == null)
                                config.AppSettings.Settings.Add("ServerName", serverName);
                            else
                                config.AppSettings.Settings["ServerName"].Value = serverName;

                            if (ConfigurationManager.AppSettings["DatabaseName"] == null)
                                config.AppSettings.Settings.Add("DatabaseName", databaseName);
                            else
                                config.AppSettings.Settings["DatabaseName"].Value = databaseName;

                            if (ConfigurationManager.AppSettings["UserName"] == null)
                                config.AppSettings.Settings.Add("UserName", userName);
                            else
                                config.AppSettings.Settings["UserName"].Value = userName;

                            if (ConfigurationManager.AppSettings["Password"] == null)
                                config.AppSettings.Settings.Add("Password", password);
                            else
                                config.AppSettings.Settings["Password"].Value = password;

                            // Lưu thay đổi
                            config.Save(ConfigurationSaveMode.Modified);
                            ConfigurationManager.RefreshSection("appSettings");

                            XtraMessageBox.Show("Khôi phục cơ sở dữ liệu thành công.\n Chương trình sẽ khởi động lại. Vui lòng đăng nhập lại!",
                                "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            IsRestart = true;
                            this.Close();
                            _frmLogin.ShowDialog();
                        }
                        else if (result.Message != null)
                        {
                            XtraMessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateDatabase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog() { Description = "Chọn đường dẫn để sao lưu dữ liệu" })
                {
                    if (DialogResult.OK == fbd.ShowDialog())
                    {
                        var serverName = string.Empty;
                        var databaseName = string.Empty;
                        var userName = string.Empty;
                        var password = string.Empty;

                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        if (ConfigurationManager.AppSettings["ServerName"] != null)
                            serverName = config.AppSettings.Settings["ServerName"].Value;

                        if (ConfigurationManager.AppSettings["DatabaseName"] != null)
                            databaseName = config.AppSettings.Settings["DatabaseName"].Value + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");

                        if (ConfigurationManager.AppSettings["UserName"] != null)
                            userName = config.AppSettings.Settings["UserName"].Value;

                        if (ConfigurationManager.AppSettings["Password"] != null)
                            password = config.AppSettings.Settings["Password"].Value;

                        var result = _databasePresenter.BackupDatabase(serverName, userName, password, databaseName, fbd.SelectedPath);
                        if (result.Success)
                        {
                            XtraMessageBox.Show("Tạo thành công bản sao lưu hệ thống tại '" + fbd.SelectedPath + "\\" + databaseName + "'.",
                                "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else if (result.Message != null)
                        {
                            XtraMessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        #region Reports
        private void btnRevenue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new Frm001();
        }
        #endregion

        #endregion


    }
}
