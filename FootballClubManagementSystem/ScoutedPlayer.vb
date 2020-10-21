Public Class ScoutedPlayer

    Public Property PlayerID As Integer
    Public Property Name As String
    Public Property Surname As String
    Public Property Position As Position
    Public Property Club As String
    Public Property MarketValue As Decimal
    Public Property BirthDate As Date
    Public ReadOnly Property Age As Integer
        Get
            Return Date.Today.Year - BirthDate.Year
        End Get
    End Property

    Public Sub New(pid As Integer, pname As String, psurname As String, pos As Position, pclub As String, value As Decimal, dob As Date)
        PlayerID = pid
        Name = pname
        Surname = psurname
        Position = pos
        Club = pclub
        MarketValue = value
        BirthDate = dob
    End Sub

    Public Sub New()

    End Sub

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

    Public Overrides Function ToString() As String
        Return Name & " " & Surname & " Club : " & Club
    End Function
End Class
