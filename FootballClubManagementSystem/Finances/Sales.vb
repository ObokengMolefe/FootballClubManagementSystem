Public Class Sales
    Private Shared numTicketSales As Integer = DBSales.GetCountTicket()
    Private Shared numMerchandiseSale As Integer = DBSales.GetCountMerchandise()
    Public Property TicketSales As SortedList
    Public Property MerchandiseSales As SortedList

    Public Sub New()
        TicketSales = New SortedList
        MerchandiseSales = New SortedList
    End Sub


    Public Sub Add(mSale As ClubMerchandiseSale)
        MerchandiseSales.Add(mSale.SaleID, mSale)
        DBSales.SaveSale(mSale)
        ' MessageBox.Show("Merchandise sale successfully saved")
    End Sub

    Public Sub Add(tSale As MatchDayTicketSale)
        TicketSales.Add(tSale.SaleID, tSale)
        DBSales.SaveSale(tSale)
        ' MessageBox.Show("Match-Day-Ticket sale successfully saved")
    End Sub

    Public Function GenerateTicketSaleID() As Integer
        Dim id As Integer
        If (numTicketSales = 0) Then
            id = 1
            numTicketSales = 1
        Else
            numTicketSales += 1
            id = numTicketSales
        End If
        Return id
    End Function

    Public Function GenerateMerchandiseSaleID() As Integer
        Dim id As Integer
        If (numMerchandiseSale = 0) Then
            id = 1
            numMerchandiseSale = 1
        Else
            numMerchandiseSale += 1
            id = numMerchandiseSale
        End If
        Return id
    End Function
End Class
