# How to bind Data Grid to Azure SQL data


This example illustrates how to fetch data from the [Azure SQL data base](https://azure.microsoft.com/en-us/services/sql-database/) and show it in the [GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl).

Note that in order to bind any data set to a data-aware control, this data set must implement either the **IList** or **IListSource** interface. Refer to the [Data Binding](https://docs.devexpress.com/WindowsForms/634/controls-and-libraries/data-grid/data-binding) help article to learn more.

This example contains the sample **AdventureWorksLT** data. To generate a sample database identical to the one used in this example, follow the [Quickstart: Create a single database in Azure SQL Database using the Azure portal, PowerShell, and Azure CLI](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-single-database-get-started?tabs=azure-portal) Microsoft article.

Three Ribbon buttons allow you to choose between the following data binding modes:

* standard **SqlDataAdapter** component;
* DevExpress [SqlDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.SqlDataSource) component;
* **Entity Framework** model;

![alt text](grid.png)

To run this example, you need to:
* [create a server-level firewall rule for your database](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-server-level-firewall-rule);
* specify your connection settings in the **Main** method.
> ![alt text](code.png)
