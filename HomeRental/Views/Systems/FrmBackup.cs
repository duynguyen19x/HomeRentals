using DevExpress.XtraEditors;
using HomeRental.Presenters.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeRental.Views.Systems
{
    public partial class FrmBackup : XtraForm
    {
        private readonly DatabasePresenter _databasePresenter;

        public FrmBackup()
        {
            InitializeComponent();
            _databasePresenter = new DatabasePresenter();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                if (BeforeCreateDatabase())
                {
                    var result = _databasePresenter.BackupDatabase(txtServerName.Text, txtUserName.Text, txtPassword.Text, txtDatabaseName.Text, btnUrl.Text);

                    if (result.Success)
                    {
                        XtraMessageBox.Show("Tạo thành công bản sao lưu hệ thống tại '" + btnUrl.Text + "'.",
                            "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (result.Message != null)
                    {
                        XtraMessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Arrow;
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private bool BeforeCreateDatabase()
        {
            var lst = new List<string>();

            if (txtServerName.Text.Length < 1)
                lst.Add("Địa chỉ CSDL");
            if (txtDatabaseName.Text.Length < 1)
                lst.Add("Tên CSDL");
            if (txtUserName.Text.Length < 1)
                lst.Add("Tài khoản");
            if (txtPassword.Text.Length < 1)
                lst.Add("Mật khẩu");
            if (btnUrl.Text.Length < 1)
                lst.Add("Chưa có tên Đường dẫn lưu file Backup");

            if (lst.Count > 0)
            {
                MessageBox.Show(string.Format("[{0}] không được để trống!", string.Join(",", lst)), "Thông báo");
                return false;
            }

            return true;
        }

        private void btnUrl_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e != null)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    if (DialogResult.OK == fbd.ShowDialog())
                        btnUrl.Text = fbd.SelectedPath;
                }
            }
        }
    }
}