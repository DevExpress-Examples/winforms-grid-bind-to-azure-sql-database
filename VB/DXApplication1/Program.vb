Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.UserSkins
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DXApplication.Data

Namespace DXApplication
	Friend Module Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            ConnectionSettings.SetUp("your_server_name.database.windows.net", "your_login", "your_password", "your_database_name")
            ConnectionSettings.SelectQuery = "SELECT * FROM SalesLT.Product"
            EFDataProvider.PreInitContext()

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Main())
        End Sub
    End Module
End Namespace
