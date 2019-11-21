Imports DevExpress.XtraBars.Ribbon
Imports DXApplication.Data

Namespace DXApplication
	Partial Public Class Main
		Inherits RibbonForm

		Public Sub New()
			InitializeComponent()

			gridView.OptionsView.RowAutoHeight = True
		End Sub
		Private Async Sub BindToDataTable(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles useDataTabletem.ItemClick
			gridView.LoadingPanelVisible = True
			gridControl.DataSource = Await DataTableProvider.Instance.GetDataAsync()
			gridView.BestFitColumns()
			gridView.LoadingPanelVisible = False
		End Sub
		Private Async Sub BindToSqlDataSource(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles useSqlDataSourceItem.ItemClick
			gridView.LoadingPanelVisible = True
			gridControl.DataSource = Await SqlDataSourceProvider.Instance.GetDataAsync()
			gridControl.DataMember = "AzureQuery"
			gridView.BestFitColumns()
			gridView.LoadingPanelVisible = False
		End Sub
		Private Async Sub BindToEF(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles useEFItem.ItemClick
			gridView.LoadingPanelVisible = True
			gridControl.DataSource = Await EFDataProvider.Instance.GetDataAsync()
			gridView.BestFitColumns()
			gridView.LoadingPanelVisible = False
		End Sub
	End Class
End Namespace
