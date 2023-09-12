Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Course")>
Partial Public Class Course
    Public Sub New()
        Enrollments = New HashSet(Of Enrollment)()
    End Sub

    Public Property ID As Integer

    Public Property Start_Date As Date?

    Public Property End_Date As Date?

    Public Property Creation_Date As Date?

    <StringLength(50)>
    Public Property Title As String

    <StringLength(500)>
    Public Property Description As String

    Public Overridable Property Enrollments As ICollection(Of Enrollment)
End Class
