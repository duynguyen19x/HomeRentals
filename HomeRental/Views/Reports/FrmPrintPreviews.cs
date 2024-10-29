using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeRental.Views.Reports
{
    public partial class FrmPrintPreviews : XtraForm
    {
        public FrmPrintPreviews()
        {
            InitializeComponent();
        }

        public FrmPrintPreviews(XtraReport report) : this()
        {
            documentViewer.DocumentSource = report;
            documentViewer.InitiateDocumentCreation();
            documentViewer.PrintingSystem = report.PrintingSystem;

            report.CreateDocument();
            this.ShowDialog();
        }
    }
}