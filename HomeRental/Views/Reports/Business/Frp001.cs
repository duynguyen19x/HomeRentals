using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace HomeRental.Views.Reports.Business
{
    public partial class Frp001 : DevExpress.XtraReports.UI.XtraReport
    {
        public Frp001()
        {
            InitializeComponent();
        }

        public Frp001(DateTime fromDate, DateTime toDate)
        {
            txtTime.Text = string.Format("Từ ngày: {0} - đến ngày: {1}", fromDate.ToString("dd/MM/yyyy"), toDate.ToString("dd/MM/yyyy"));
        }
    }
}
