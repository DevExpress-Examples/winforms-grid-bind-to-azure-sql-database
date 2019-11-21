Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("SalesLT.Address")>
	Partial Public Class Address
		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>
		Public Sub New()
			CustomerAddresses = New HashSet(Of CustomerAddress)()
			SalesOrderHeaders = New HashSet(Of SalesOrderHeader)()
			SalesOrderHeaders1 = New HashSet(Of SalesOrderHeader)()
		End Sub

		Public Property AddressID() As Integer

		<Required, StringLength(60)>
		Public Property AddressLine1() As String

		<StringLength(60)>
		Public Property AddressLine2() As String

		<Required, StringLength(30)>
		Public Property City() As String

		<Required, StringLength(50)>
		Public Property StateProvince() As String

		<Required, StringLength(50)>
		Public Property CountryRegion() As String

		<Required, StringLength(15)>
		Public Property PostalCode() As String

		Public Property rowguid() As Guid

		Public Property ModifiedDate() As Date

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property CustomerAddresses() As ICollection(Of CustomerAddress)

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property SalesOrderHeaders() As ICollection(Of SalesOrderHeader)

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property SalesOrderHeaders1() As ICollection(Of SalesOrderHeader)
	End Class
End Namespace
