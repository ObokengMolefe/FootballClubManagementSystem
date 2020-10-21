Imports System.DateTime

Public Class Person

    Public Property ID As Integer
    Public Property Name As String
    Public Property Surname As String
    Public Property Phone As Integer
    Public Property Address As String
    Public Property StartDate As Date
    Public Property EndDate As Date

    Public Sub New()

    End Sub

    Public Sub New(personID As Integer, pName As String, pSurname As String, pPhone As Integer, pAddress As String, pEndDate As Date)
        ID = personID
        Name = pName
        Surname = pSurname
        Phone = pPhone
        Address = pAddress
        StartDate = DateTime.Today
        EndDate = pEndDate
    End Sub

    Public Overrides Function ToString() As String
        Return Name & " " & Surname
    End Function
End Class
