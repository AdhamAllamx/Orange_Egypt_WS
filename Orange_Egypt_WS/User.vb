Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class User
    Public Sub New()
        Instructors = New HashSet(Of Instructor)()
        Students = New HashSet(Of Student)()
    End Sub

    <Key>
    <StringLength(50)>
    Public Property UserName As String

    Public Property Creation_Date As Date?

    Public Overridable Property Instructors As ICollection(Of Instructor)

    Public Overridable Property Students As ICollection(Of Student)
End Class
