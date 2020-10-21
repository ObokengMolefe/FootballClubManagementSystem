Public Class Fan
    Inherits Person

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Property BirthDate As Date
    Public Property Gender As String
    Public Property Category As String
    Public Property Expired As Boolean
    Public Property AnnFee As Decimal
    Private fanAge As Integer = ((Date.Today.Year) - (BirthDate.Year))
    Public ReadOnly Property Age As Integer
        Get
            Return ((Date.Today.Year) - (BirthDate.Year))
        End Get
    End Property


    Public Sub New(id As Integer, name As String, surname As String, phone As Integer, address As String, endDate As Date, dob As Date, sex As String, cat As String, fee As Decimal)
        MyBase.New(id, name, surname, phone, address, endDate)
        BirthDate = dob
        Gender = sex
        Category = cat
        AnnFee = fee
    End Sub

    Public Sub Renew()
        Expired = False
    End Sub

    Public Shared Function GetFee(cat As String) As Decimal
        Dim fee As Decimal
        Select Case cat
            Case "Gold"
                fee = 100
            Case "Silver"
                fee = 80
            Case "Bronze"
                fee = 60
        End Select
        Return fee
    End Function

    Public Overrides Function ToString() As String
        Return Name & " " & Surname & " a " & Category & " member." & " " & Expired
    End Function

End Class
