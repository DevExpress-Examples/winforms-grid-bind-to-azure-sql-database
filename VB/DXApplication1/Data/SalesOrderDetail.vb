Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("SalesLT.SalesOrderDetail")>
	Partial Public Class SalesOrderDetail
		<Key, Column(Order := 0), DatabaseGenerated(DatabaseGeneratedOption.None)>
		Public Property SalesOrderID() As Integer

		<Key, Column(Order := 1)>
		Public Property SalesOrderDetailID() As Integer

		Public Property OrderQty() As Short

		Public Property ProductID() As Integer

		<Column(TypeName := "money")>
		Public Property UnitPrice() As Decimal

		<Column(TypeName := "money")>
		Public Property UnitPriceDiscount() As Decimal

		<Column(TypeName := "numeric"), DatabaseGenerated(DatabaseGeneratedOption.Computed)>
		Public Property LineTotal() As Decimal

		Public Property rowguid() As Guid

		Public Property ModifiedDate() As Date

		Public Overridable Property Product() As Product

		Public Overridable Property SalesOrderHeader() As SalesOrderHeader
	End Class
End Namespace
