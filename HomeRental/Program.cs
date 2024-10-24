﻿using DevExpress.Entity.Model.Metadata;
using DevExpress.Skins;
using DevExpress.UserSkins;
using HomeRental.Views.Systems;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Application.Run(new FrmLogin());
        }
    }
}
