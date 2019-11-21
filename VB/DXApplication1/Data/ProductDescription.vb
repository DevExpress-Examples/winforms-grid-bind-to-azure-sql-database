Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("SalesLT.ProductDescription")>
	Partial Public Class ProductDescription
		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>
		Public Sub New()
			ProductModelProductDescriptions = New HashSet(Of ProductModelProductDescription)()
		End Sub

		Public Property ProductDescriptionID() As Integer

		<Required, StringLength(400)>
		Public Property Description() As String

		Public Property rowguid() As Guid

		Public Property ModifiedDate() As Date

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")>
		Public Overridable Property ProductModelProductDescriptions() As ICollection(Of ProductModelProductDescription)
	End Class
End Namespace
