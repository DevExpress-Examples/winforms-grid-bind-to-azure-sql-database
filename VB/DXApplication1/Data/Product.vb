Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("SalesLT.Product")>
	Partial Public Class Product
		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>
		Public Sub New()
			SalesOrderDetails = New List(Of SalesOrderDetail)()
		End Sub

		Public Property ProductID() As Integer

		<Required, StringLength(50)>
		Public Property Name() As String

		<Required, StringLength(25)>
		Public Property ProductNumber() As String

		<StringLength(15)>
		Public Property Color() As String

		<Column(TypeName := "money")>
		Public Property StandardCost() As Decimal

		<Column(TypeName := "money")>
		Public Property ListPrice() As Decimal

		<StringLength(5)>
		Public Property Size() As String

		Public Property Weight() As Decimal?

		Public Property ProductCategoryID() As Integer?

		Public Property ProductModelID() As Integer?

		Public Property SellStartDate() As Date

		Public Property SellEndDate() As Date?

		Public Property DiscontinuedDate() As Date?

		Public Property ThumbNailPhoto() As Byte()

		<StringLength(50)>
		Public Property ThumbnailPhotoFileName() As String

		Public Property rowguid() As Guid

		Public Property ModifiedDate() As Date

		Public Overridable Property ProductCategory() As ProductCategory

		Public Overridable Property ProductModel() As ProductModel

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property SalesOrderDetails() As List(Of SalesOrderDetail)
	End Class
End Namespace
