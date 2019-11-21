Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("BuildVersion")>
	Partial Public Class BuildVersion
		<Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)>
		Public Property SystemInformationID() As Byte

		<Column("Database Version"), Required, StringLength(25)>
		Public Property Database_Version() As String

		Public Property VersionDate() As Date

		Public Property ModifiedDate() As Date
	End Class
End Namespace
