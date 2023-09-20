<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/223140673/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T834862)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WinForms Data Grid - Bind to Azure SQL data

This example fetches data from the [Azure SQL data base](https://azure.microsoft.com/en-us/services/sql-database/) and displays it in the [GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl).

> **Note**
>
> To bind any data set to a data-aware control, the data set must implement the `IList` or `IListSource` interface. Read the following help topic for additional information: [Data Binding](https://docs.devexpress.com/WindowsForms/634/controls-and-libraries/data-grid/data-binding).

This example contains sample **AdventureWorksLT** data. To generate a sample database identical to the one used in this example, follow the [Quickstart: Create a single database in Azure SQL Database using the Azure portal, PowerShell, and Azure CLI](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-single-database-get-started?tabs=azure-portal) Microsoft article.

Ribbon UI commands allow you to bind to a sample Azure database using one of the following methods:

* direct binding to a standard **DataTable** object;
* binding with a DevExpress [SqlDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.SqlDataSource) component;
* binding with an **Entity Framework** model.

![WinForms Application](grid.png)

Do the following to run this example:

* [create a server-level firewall rule for your database](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-server-level-firewall-rule);
* specify connection settings in the `Main` method:

  ```csharp
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
  ```


## Documentation

* [Bind to Azure SQL Database](https://docs.devexpress.com/WindowsForms/401443/common-features/data-binding/bind-to-azure-data)
