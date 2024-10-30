using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using HomeRental.Views.Reports;
using HomeRental.Views.Reports.Documents;
using HomeRental.Views.Systems;
using Services;
using System;
using System.Windows.Forms;
using Utilities.Commons;

namespace HomeRental
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ObjectMapper.CreateMapper();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SkinManager.EnableFormSkins();
            BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle(System.Configuration.ConfigurationManager.AppSettings["SkinName"].ToString());

            //UserSession.UserName = "Bố đời thiên hạ => OK";
            //UserSession.Address = "Bốn bể là nhà";
            //UserSession.PhoneNumber = "0988.222.999";

            //var rpt = new RptDocument001(new HomeRentals.Models.Business.CustomerHomeRentalModel()
            //{
            //    RentalStartDate = DateTime.Now,
            //    CustomerName = "Bố đời thiên hạ",
            //    HomeRentalArea = 100,
            //    HomeRentalPrice = 100000,
            //    CustomerPhoneNumber = "0988.888.999",
            //    CustomerAddress = "Hà Nội không vội được đâu"
            //});
            //var frm = new FrmPrintPreviews(rpt);

            Application.Run(new FrmLogin());
        }
    }
}
