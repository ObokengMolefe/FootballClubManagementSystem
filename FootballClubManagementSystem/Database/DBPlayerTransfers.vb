Imports System.Data.OleDb

Public Class DBPlayerTransfers
    Public Shared Function GetScoutList() As SortedDictionary(Of Integer, ScoutedPlayer)
        Dim scoutList As New SortedDictionary(Of Integer, ScoutedPlayer)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Dim dr As OleDbDataReader

        Try
            myConnection.Open()
            Dim selectStatement As String
            selectStatement = "SELECT * FROM Scout_Player"
            Dim cmd As OleDbCommand = New OleDbCommand(selectStatement, myConnection)
            dr = cmd.ExecuteReader
            Dim player As ScoutedPlayer
            Do While dr.Read
                player = New ScoutedPlayer
                player.PlayerID = CInt(dr("Scout_ID").ToString)
                player.Name = dr("SP_Name").ToString
                player.Surname = dr("SP_Surname").ToString
                player.Position = CType(player.GetPositionEnumIndex(dr("SP_Position").ToString), Position)
                player.BirthDate = CDate(dr("SP_DOB").ToString)
                player.Club = dr("SP_Club").ToString
                player.MarketValue = CDec(dr("SP_Value").ToString)
                scoutList.Add(player.PlayerID, player)
            Loop
            dr.Close()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Scouts Exception")
        Finally
            myConnection.Close()
        End Try
        Return scoutList
    End Function

#Region "Player tranfers out"
    Public Shared Function GetTransferList() As SortedDictionary(Of Integer, Player)
        Dim tList As New SortedDictionary(Of Integer, Player)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Dim dr As OleDbDataReader
        Try
            myConnection.Open()
            Dim selectStatement As String
            selectStatement = "SELECT * FROM Transfer_Out"
            Dim cmd As OleDbCommand = New OleDbCommand(selectStatement, myConnection)
            dr = cmd.ExecuteReader
            Dim player As Player
            Do While dr.Read
                player = frmFCMS.listPlayers.GetPlayer(CInt(dr("Player_ID").ToString))
                tList.Add(player.ID, player)
            Loop
            dr.Close()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Get Player Tranfers Exception")
        Finally
            myConnection.Close()
        End Try
        Return tList
    End Function

    Public Shared Sub AddPlayerToTransfer(newPlayer As Integer)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Dim insertStatement As String = "INSERT INTO Transfer_Out Values (?)"
        Dim cmd As OleDbCommand = New OleDbCommand(insertStatement, myConnection)
        Try
            myConnection.Open()
            With cmd.Parameters
                .Add(New OleDbParameter("Player_ID", newPlayer))
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Insert Player to Transfer List")
        Finally
            myConnection.Close()
        End Try
    End Sub

    Public Shared Sub RemovePlayerFromTransfer(playerID As Integer)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection
        Dim deleteStatement As String
        deleteStatement = "DELETE FROM Transfer_Out WHERE ( Player_ID = " & playerID & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(deleteStatement, myConnection)
        Try
            myConnection.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database delete player")
        Finally
            myConnection.Close()
        End Try
        MessageBox.Show("Player successfully deleted")
    End Sub
#End Region
End Class
