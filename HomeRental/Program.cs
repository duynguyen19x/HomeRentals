using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using HomeRental.Views.Systems;
using Services;
using System;
using System.Windows.Forms;

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

            Application.Run(new FrmBackup());
        }
    }
}
