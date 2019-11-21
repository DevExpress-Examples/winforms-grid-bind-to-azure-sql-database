Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("SalesLT.SalesOrderHeader")>
	Partial Public Class SalesOrderHeader
		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>
		Public Sub New()
			SalesOrderDetails = New HashSet(Of SalesOrderDetail)()
		End Sub

		<Key, DatabaseGenerated(DatabaseGeneratedOption.None)>
		Public Property SalesOrderID() As Integer

		Public Property RevisionNumber() As Byte

		Public Property OrderDate() As Date

		Public Property DueDate() As Date

		Public Property ShipDate() As Date?

		Public Property Status() As Byte

		Public Property OnlineOrderFlag() As Boolean

		<DatabaseGenerated(DatabaseGeneratedOption.Computed), Required, StringLength(25)>
		Public Property SalesOrderNumber() As String

		<StringLength(25)>
		Public Property PurchaseOrderNumber() As String

		<StringLength(15)>
		Public Property AccountNumber() As String

		Public Property CustomerID() As Integer

		Public Property ShipToAddressID() As Integer?

		Public Property BillToAddressID() As Integer?

		<Required, StringLength(50)>
		Public Property ShipMethod() As String

		<StringLength(15)>
		Public Property CreditCardApprovalCode() As String

		<Column(TypeName := "money")>
		Public Property SubTotal() As Decimal

		<Column(TypeName := "money")>
		Public Property TaxAmt() As Decimal

		<Column(TypeName := "money")>
		Public Property Freight() As Decimal

		<Column(TypeName := "money"), DatabaseGenerated(DatabaseGeneratedOption.Computed)>
		Public Property TotalDue() As Decimal

		Public Property Comment() As String

		Public Property rowguid() As Guid

		Public Property ModifiedDate() As Date

		Public Overridable Property Address() As Address

		Public Overridable Property Address1() As Address

		Public Overridable Property Customer() As Customer

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property SalesOrderDetails() As ICollection(Of SalesOrderDetail)
	End Class
End Namespace
