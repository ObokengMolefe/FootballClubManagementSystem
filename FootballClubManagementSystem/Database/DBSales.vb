Imports System.Data.OleDb

Public Class DBSales
    'Retrieve the total number of match day tickets sales
    Public Shared Function GetCountTicket() As Integer
        Dim count As Integer
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection
        Dim dr As OleDbDataReader
        Try
            myConnection.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT COUNT(*) AS Num FROM Ticket_Sale", myConnection)
            dr = cmd.ExecuteReader
            Do While dr.Read()
                count = CInt(dr("Num").ToString)
            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database count ticket")
        Finally
            myConnection.Close()
        End Try
        Return count
    End Function
    'Retrieve the total number of merchandise sales
    Public Shared Function GetCountMerchandise() As Integer
        Dim count As Integer
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection
        Dim dr As OleDbDataReader
        Try
            myConnection.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT COUNT(*) AS Num FROM Merchandise_Sale", myConnection)
            dr = cmd.ExecuteReader
            Do While dr.Read()
                count = CInt(dr("Num").ToString)
            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database count ticket")
        Finally
            myConnection.Close()
        End Try
        Return count
    End Function
    'Save new match day ticket sale
    Public Shared Sub SaveSale(sale As MatchDayTicketSale)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Try
            myConnection.Open()
            Dim insertStatement As String
            insertStatement = "INSERT INTO Ticket_Sale VALUES (?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(insertStatement, myConnection)
            With cmd.Parameters
                .Add(New OleDbParameter("Sale_ID", sale.SaleID))
                .Add(New OleDbParameter("Sale_Date", sale.SaleDate))
                .Add(New OleDbParameter("Sale_Amount", sale.SaleAmount))
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Insert Matchday sale")
        Finally
            myConnection.Close()
        End Try
    End Sub
    'Save new merchandise sale
    Public Shared Sub SaveSale(sale As ClubMerchandiseSale)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Try
            myConnection.Open()
            Dim insertStatement As String
            insertStatement = "INSERT INTO Merchandise_Sale VALUES (?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(insertStatement, myConnection)
            With cmd.Parameters
                .Add(New OleDbParameter("Sale_ID", sale.SaleID))
                .Add(New OleDbParameter("Sale_Date", sale.SaleDate))
                .Add(New OleDbParameter("Sale_Amount", sale.SaleAmount))
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Insert Merchandise sale")
        Finally
            myConnection.Close()
        End Try
    End Sub

End Class
