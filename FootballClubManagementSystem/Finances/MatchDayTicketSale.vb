Public Class MatchDayTicketSale
    Public Property SaleID As Integer
    Public Property SaleDate As Date
    Public Property SaleAmount As Decimal

    Public Sub New(id As Integer, sDate As Date, sAmnt As Decimal)
        SaleID = id
        SaleDate = CDate(sDate.ToShortDateString)
        SaleAmount = sAmnt
    End Sub

    Public Overrides Function ToString() As String
        Return SaleDate.ToShortDateString & " " & SaleAmount.ToString("C2")
    End Function
End Class
