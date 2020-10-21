Public Class Sponsor

    Public Property SponsorID As Integer
    Public Property Name As String
    Public Property Sponsorship As Decimal
    Public Property Industry As String
    Public Property EndDate As Date
    Public Property StartDate As Date
    Public ReadOnly Property ContractDuration As Integer
        Get
            Return EndDate.Year - StartDate.Year
        End Get
    End Property
    Public ReadOnly Property YearsLeft As Integer
        Get
            Return EndDate.Year - Date.Today.Year
        End Get
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, sname As String, fee As Decimal, sindustry As String, sendate As Date)
        SponsorID = id
        Name = sname
        Sponsorship = fee
        Industry = sindustry
        StartDate = Date.Today
        EndDate = sendate
    End Sub

    Public Overrides Function ToString() As String
        Return Name & " " & Industry
    End Function
End Class
