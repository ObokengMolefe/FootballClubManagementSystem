Imports System.Data.OleDb

Public Class DBSponsor

    Public Shared Function GetSponsors() As SortedDictionary(Of Integer, Sponsor)
        Dim sponsors As New SortedDictionary(Of Integer, Sponsor)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Dim dr As OleDbDataReader

        Try
            myConnection.Open()
            Dim selectStatement As String
            selectStatement = "SELECT * FROM Sponsor"
            Dim cmd As OleDbCommand = New OleDbCommand(selectStatement, myConnection)
            dr = cmd.ExecuteReader
            Dim sponsor As Sponsor
            Do While dr.Read
                sponsor = New Sponsor
                sponsor.SponsorID = CInt(dr("Sponsor_ID").ToString)
                sponsor.Name = dr("S_Name").ToString
                sponsor.Sponsorship = CDec(dr("S_Sponsorship").ToString)
                sponsor.Industry = dr("S_Industry").ToString
                sponsor.StartDate = CDate(dr("S_StartDate").ToString)
                sponsor.EndDate = CDate(dr("S_EnDate").ToString)
                sponsors.Add(sponsor.SponsorID, sponsor)
            Loop
            dr.Close()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Datebase Sponsor Exception")
        Finally
            myConnection.Close()
        End Try
        Return sponsors
    End Function

    Public Shared Sub AddSponsor(sponsor As Sponsor)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Try
            myConnection.Open()
            Dim insertStatement As String
            insertStatement = "INSERT INTO Sponsor VALUES (?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(insertStatement, myConnection)
            With cmd.Parameters
                .Add(New OleDbParameter("Sponsor_ID", sponsor.SponsorID))
                .Add(New OleDbParameter("S_Name", sponsor.Name))
                .Add(New OleDbParameter("S_Sponsorship", sponsor.Sponsorship))
                .Add(New OleDbParameter("S_Industry", sponsor.Industry))
                .Add(New OleDbParameter("S_StartDate", sponsor.StartDate))
                .Add(New OleDbParameter("S_EnDate", sponsor.EndDate))
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Insert Sponsor")
        Finally
            myConnection.Close()
        End Try
    End Sub

    Public Shared Sub RemoveSponsor(sponsName As String)

    End Sub

    Public Shared Sub ModifyPlayer(player As Player)

    End Sub
End Class
