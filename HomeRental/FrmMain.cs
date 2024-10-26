﻿using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using HomeRental.Views.Business.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeRental
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Function

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
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

        #endregion

        private void btnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
