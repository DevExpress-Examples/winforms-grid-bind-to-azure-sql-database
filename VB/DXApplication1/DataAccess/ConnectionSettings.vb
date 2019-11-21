Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DXApplication.Data
	Public Module ConnectionSettings
		Public DataSource, UserID, Password, InitialCatalog As String
		Public SelectQuery As String
		Public Sub SetUp(ByVal dataSource As String, ByVal userId As String, ByVal password As String, ByVal initialCatalog As String)
			ConnectionSettings.DataSource = dataSource
			ConnectionSettings.UserID = userId
			ConnectionSettings.Password = password
			ConnectionSettings.InitialCatalog = initialCatalog
		End Sub
		Public Function GetConnectionString() As String
			Dim builder = New SqlConnectionStringBuilder()
			builder.DataSource = ConnectionSettings.DataSource
			builder.UserID = ConnectionSettings.UserID
			builder.Password = ConnectionSettings.Password
			builder.InitialCatalog = ConnectionSettings.InitialCatalog
			Return builder.ConnectionString
		End Function
	End Module
End Namespace
