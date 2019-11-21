Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("SalesLT.ProductModelProductDescription")>
	Partial Public Class ProductModelProductDescription
		<Key, Column(Order := 0), DatabaseGenerated(DatabaseGeneratedOption.None)>
		Public Property ProductModelID() As Integer

		<Key, Column(Order := 1), DatabaseGenerated(DatabaseGeneratedOption.None)>
		Public Property ProductDescriptionID() As Integer

		<Key, Column(Order := 2), StringLength(6)>
		Public Property Culture() As String

		Public Property rowguid() As Guid

		Public Property ModifiedDate() As Date

		Public Overridable Property ProductDescription() As ProductDescription

		Public Overridable Property ProductModel() As ProductModel
	End Class
End Namespace
