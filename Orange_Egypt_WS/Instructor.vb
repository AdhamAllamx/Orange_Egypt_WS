Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Instructor")>
Partial Public Class Instructor
    Public Sub New()
        Enrollments = New HashSet(Of Enrollment)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property ID As Integer

    <StringLength(50)>
    Public Property UserName As String

    <StringLength(50)>
    Public Property Password As String

    Public Property Create_Date As Date?

    Public Property isDeleted As Boolean?

    Public Overridable Property Enrollments As ICollection(Of Enrollment)

    Public Overridable Property User As User
End Class
