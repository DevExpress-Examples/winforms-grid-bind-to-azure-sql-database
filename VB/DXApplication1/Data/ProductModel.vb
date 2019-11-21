Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("SalesLT.ProductModel")>
	Partial Public Class ProductModel
		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>
		Public Sub New()
			Products = New HashSet(Of Product)()
			ProductModelProductDescriptions = New HashSet(Of ProductModelProductDescription)()
		End Sub

		Public Property ProductModelID() As Integer

		<Required, StringLength(50)>
		Public Property Name() As String

		<Column(TypeName := "xml")>
		Public Property CatalogDescription() As String

		Public Property rowguid() As Guid

		Public Property ModifiedDate() As Date

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property Products() As ICollection(Of Product)

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property ProductModelProductDescriptions() As ICollection(Of ProductModelProductDescription)
	End Class
End Namespace
