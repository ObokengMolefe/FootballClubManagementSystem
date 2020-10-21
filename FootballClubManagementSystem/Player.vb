Public Class Player
    Inherits Employee

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Property MarketValue As Decimal
    Public Property Position As Position
    Public Property BirthDate As Date
    Public Property JerseyNum As Integer
    Public Property Nationality As String
    Public Property ImagePath As String
    Public ReadOnly Property Age As Integer
        Get
            Return Date.Now.Year - BirthDate.Year
        End Get
    End Property

    Public Sub New(id As Integer, name As String, surname As String, phone As Integer, address As String, endDate As Date, mail As String, sal As Decimal,
                   value As Decimal, pos As Position, dob As Date, jNum As Integer, nation As String, image As String)
        MyBase.New(id, name, surname, phone, address, endDate, mail, sal)
        MarketValue = value
        Position = pos
        BirthDate = dob
        JerseyNum = jNum
        ImagePath = image
        Nationality = nation
    End Sub

    Public Overrides Function ToString() As String
        Return Name & " " & Surname & " a " & Position.ToString & "Jersey No: " & JerseyNum
    End Function

    Public Function GetPositionEnumIndex(pos As String) As Integer
        Dim idx As Integer
        Select Case pos
            Case "Striker"
                idx = 0
            Case "Midfielder"
                idx = 1
            Case "Defender"
                idx = 2
            Case "Goalkeeper"
                idx = 3
        End Select
        Return idx
    End Function
End Class

Public Enum Position
    Striker
    Midfielder
    Defender
    Goalkeeper
End Enum
