using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DXApplication.Data;

namespace DXApplication {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            ConnectionSettings.SetUp("your_server_name.database.windows.net", "your_login", "your_password", "your_database_name");
            ConnectionSettings.SelectQuery = "SELECT * FROM SalesLT.Product";
            EFDataProvider.PreInitContext();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
