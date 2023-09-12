Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=OrangeWS_Model1")
    End Sub

    Public Overridable Property Courses As DbSet(Of Course)
    Public Overridable Property Enrollments As DbSet(Of Enrollment)
    Public Overridable Property Instructors As DbSet(Of Instructor)
    Public Overridable Property Students As DbSet(Of Student)
    Public Overridable Property sysdiagrams As DbSet(Of sysdiagram)
    Public Overridable Property Users As DbSet(Of User)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    End Sub
End Class
