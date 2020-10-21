Public Class ClubMerchandiseSale

    Public Property SaleID As Integer
    Public Property SaleDate As Date
    Public Property SaleAmount As Decimal

    Public Sub New(id As Integer, sdate As Date, samnt As Decimal)
        SaleID = id
        SaleDate = CDate(sdate.ToShortDateString)
        SaleAmount = samnt
    End Sub


    Public Overrides Function ToString() As String
        Return SaleDate.ToShortDateString & " " & SaleAmount.ToString("C2")
    End Function
End Class
