Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("SalesLT.Customer")>
	Partial Public Class Customer
		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>
		Public Sub New()
			CustomerAddresses = New HashSet(Of CustomerAddress)()
			SalesOrderHeaders = New HashSet(Of SalesOrderHeader)()
		End Sub

		Public Property CustomerID() As Integer

		Public Property NameStyle() As Boolean

		<StringLength(8)>
		Public Property Title() As String

		<Required, StringLength(50)>
		Public Property FirstName() As String

		<StringLength(50)>
		Public Property MiddleName() As String

		<Required, StringLength(50)>
		Public Property LastName() As String

		<StringLength(10)>
		Public Property Suffix() As String

		<StringLength(128)>
		Public Property CompanyName() As String

		<StringLength(256)>
		Public Property SalesPerson() As String

		<StringLength(50)>
		Public Property EmailAddress() As String

		<StringLength(25)>
		Public Property Phone() As String

		<Required, StringLength(128)>
		Public Property PasswordHash() As String

		<Required, StringLength(10)>
		Public Property PasswordSalt() As String

		Public Property rowguid() As Guid

		Public Property ModifiedDate() As Date

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property CustomerAddresses() As ICollection(Of CustomerAddress)

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property SalesOrderHeaders() As ICollection(Of SalesOrderHeader)
	End Class
End Namespace
