Imports DXApplication.Data
Imports System.Linq
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System

Namespace DXApplication

	Partial Public Class AdventureWorksLTContext
		Inherits DbContext

		Public Sub New()
			MyBase.New(ConnectionSettings.GetConnectionString())
		End Sub
		Public Overridable Property Products() As DbSet(Of Product)
	End Class
End Namespace
