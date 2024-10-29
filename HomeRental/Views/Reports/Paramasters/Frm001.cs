using DevExpress.XtraEditors;
using HomeRental.Presenters.Reports;
using HomeRental.Views.Reports.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeRental.Views.Reports.Paramasters
{
    public partial class Frm001 : XtraForm
    {
        readonly ReportPresenter _reportPresenter;

        public Frm001()
        {
            InitializeComponent();

            _reportPresenter = new ReportPresenter();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var result = _reportPresenter.GetRpt001(dteFromDate.DateTime.Date, dteToDate.DateTime.Date);
            if (result.Items != null && result.Items.Count > 0)
            {
                var rpt = new Frp001() 
                { 
                    DataSource = result.Items
                };

                var frm = new FrmPrintPreviews(rpt);
            }
            else
            {
                MessageBox.Show("Không cáo dữ liệu báo cáo!", "Thông báo");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm001_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // Lấy ngày đầu tiên của tháng
            DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
            // Lấy ngày cuối cùng của tháng
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            dteFromDate.EditValue = firstDayOfMonth;
            dteToDate.EditValue = lastDayOfMonth;
        }
    }
}