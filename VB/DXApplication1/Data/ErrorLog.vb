Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace DXApplication

	<Table("ErrorLog")>
	Partial Public Class ErrorLog
		Public Property ErrorLogID() As Integer

		Public Property ErrorTime() As Date

		<Required, StringLength(128)>
		Public Property UserName() As String

		Public Property ErrorNumber() As Integer

		Public Property ErrorSeverity() As Integer?

		Public Property ErrorState() As Integer?

		<StringLength(126)>
		Public Property ErrorProcedure() As String

		Public Property ErrorLine() As Integer?

		<Required, StringLength(4000)>
		Public Property ErrorMessage() As String
	End Class
End Namespace
