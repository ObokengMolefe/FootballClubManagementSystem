Public Class Employee
    Inherits Person

    Public Property Email As String
    Public Property MonthlySal As Decimal
    Public ReadOnly Property ContractLength As Integer
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

    Public Sub New(id As Integer, name As String, surname As String, phone As Integer, address As String, endDate As Date, mail As String, sal As Decimal)
        MyBase.New(id, name, surname, phone, address, endDate)
        Email = mail
        MonthlySal = sal
    End Sub


End Class
