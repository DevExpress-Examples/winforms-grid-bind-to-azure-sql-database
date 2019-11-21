Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("SalesLT.CustomerAddress")>
	Partial Public Class CustomerAddress
		<Key, Column(Order := 0), DatabaseGenerated(DatabaseGeneratedOption.None)>
		Public Property CustomerID() As Integer

		<Key, Column(Order := 1), DatabaseGenerated(DatabaseGeneratedOption.None)>
		Public Property AddressID() As Integer

		<Required, StringLength(50)>
		Public Property AddressType() As String

		Public Property rowguid() As Guid

		Public Property ModifiedDate() As Date

		Public Overridable Property Address() As Address

		Public Overridable Property Customer() As Customer
	End Class
End Namespace
