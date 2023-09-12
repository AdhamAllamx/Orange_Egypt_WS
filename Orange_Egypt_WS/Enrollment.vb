Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Enrollment")>
Partial Public Class Enrollment
    Public Property ID As Integer

    Public Property StudentID As Integer?

    Public Property InstructorID As Integer?

    Public Property CourseID As Integer?

    Public Property Creation_Date As Date?

    Public Property isDeleted As Boolean?

    Public Property Score As Integer?

    Public Overridable Property Course As Course

    Public Overridable Property Instructor As Instructor

    Public Overridable Property Student As Student
End Class
