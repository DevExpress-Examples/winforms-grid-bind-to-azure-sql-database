Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("SalesLT.ProductCategory")>
	Partial Public Class ProductCategory
		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>
		Public Sub New()
			Products = New HashSet(Of Product)()
			ProductCategory1 = New HashSet(Of ProductCategory)()
		End Sub

		Public Property ProductCategoryID() As Integer

		Public Property ParentProductCategoryID() As Integer?

		<Required, StringLength(50)>
		Public Property Name() As String

		Public Property rowguid() As Guid

		Public Property ModifiedDate() As Date

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property Products() As ICollection(Of Product)

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property ProductCategory1() As ICollection(Of ProductCategory)

		Public Overridable Property ProductCategory2() As ProductCategory
	End Class
End Namespace
