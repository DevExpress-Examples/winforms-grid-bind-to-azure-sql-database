Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DXApplication.Data
	Public MustInherit Class DataProvider(Of T As Class)
		Public Overridable Async Function GetDataAsync() As Task(Of T)
			Return Await Task.FromResult(GetData())
		End Function
		Public MustOverride Function GetData() As T
	End Class
	Public Class DataTableProvider
		Inherits DataProvider(Of DataTable)

		Private Sub New()
		End Sub
'INSTANT VB NOTE: The field instance was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private Shared instance_Renamed As DataTableProvider
		Public Shared ReadOnly Property Instance() As DataTableProvider
			Get
				If instance_Renamed Is Nothing Then
					instance_Renamed = New DataTableProvider()
				End If
				Return instance_Renamed
			End Get
		End Property
		Public Overrides Function GetData() As DataTable
			Try
				Using connection = New SqlConnection(ConnectionSettings.GetConnectionString())
					connection.Open()
					Using adapter As New SqlDataAdapter(ConnectionSettings.SelectQuery, connection)
						Dim dt = New DataTable()
						adapter.Fill(dt)
						Return dt
					End Using
				End Using
			Catch
				Return Nothing
			End Try
		End Function
	End Class
	Public Class SqlDataSourceProvider
		Inherits DataProvider(Of SqlDataSource)

		Private Sub New()
		End Sub
'INSTANT VB NOTE: The field instance was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private Shared instance_Renamed As SqlDataSourceProvider
		Public Shared ReadOnly Property Instance() As SqlDataSourceProvider
			Get
				If instance_Renamed Is Nothing Then
					instance_Renamed = New SqlDataSourceProvider()
				End If
				Return instance_Renamed
			End Get
		End Property
		Public Overrides Function GetData() As SqlDataSource
			Dim source = CreateSqlDataSource()
			source.Fill()
			Return source
		End Function
		Public Async Overrides Function GetDataAsync() As Task(Of SqlDataSource)
			Dim source = CreateSqlDataSource()
			Await source.FillAsync()
			Return source
		End Function
		Private Function CreateSqlDataSource() As SqlDataSource
			Dim connectionParameters As New MsSqlConnectionParameters(ConnectionSettings.DataSource, ConnectionSettings.InitialCatalog, ConnectionSettings.UserID, ConnectionSettings.Password, MsSqlAuthorizationType.SqlServer)
			Dim source As New SqlDataSource(connectionParameters)
			Dim query As New CustomSqlQuery()
			query.Name = "AzureQuery"
			query.Sql = ConnectionSettings.SelectQuery
			source.Queries.Add(query)
			Return source
		End Function
	End Class
	Public Class EFDataProvider
		Inherits DataProvider(Of List(Of Product))

		Private Sub New()
		End Sub
'INSTANT VB NOTE: The field instance was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private Shared instance_Renamed As EFDataProvider
		Public Shared ReadOnly Property Instance() As EFDataProvider
			Get
				If instance_Renamed Is Nothing Then
					instance_Renamed = New EFDataProvider()
				End If
				Return instance_Renamed
			End Get
		End Property
		Friend Shared Sub PreInitContext()
			Using context As New AdventureWorksLTContext()
				context.Products.Include("SalesOrderDetails")
			End Using
		End Sub
		Public Overrides Function GetData() As List(Of Product)
			Using context As New AdventureWorksLTContext()
				Return context.Products.ToList()
			End Using
		End Function
		Public Async Overrides Function GetDataAsync() As Task(Of List(Of Product))
			Using context As New AdventureWorksLTContext()
				context.Configuration.LazyLoadingEnabled = False
				Dim list = Await context.Products.Include("SalesOrderDetails").ToListAsync()
				Return list
			End Using
		End Function
	End Class
End Namespace
