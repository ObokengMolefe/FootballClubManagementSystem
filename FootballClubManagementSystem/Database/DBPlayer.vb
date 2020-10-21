Imports System.Data.OleDb

Public Class DBPlayer

    Public Shared Function GetPlayers() As SortedDictionary(Of Integer, Player)
        Dim playerList As New SortedDictionary(Of Integer, Player)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Dim dr As OleDbDataReader

        Try
            myConnection.Open()
            Dim selectStatement As String
            selectStatement = "SELECT * FROM Player"
            Dim cmd As OleDbCommand = New OleDbCommand(selectStatement, myConnection)
            dr = cmd.ExecuteReader
            Dim player As Player
            Do While dr.Read
                player = New Player
                player.ID = CInt(dr("Player_ID").ToString)
                player.Name = dr("P_Name").ToString
                player.Surname = dr("P_Surname").ToString
                player.Position = CType(player.GetPositionEnumIndex(dr("P_Position").ToString), Position)
                player.BirthDate = CDate(dr("P_DOB").ToString)
                player.Address = dr("P_Address").ToString
                player.Email = dr("P_Email").ToString
                player.Phone = CInt(dr("P_Phone").ToString)
                player.Nationality = dr("P_Nation").ToString
                player.MonthlySal = CDec(dr("P_Salary").ToString)
                player.EndDate = CDate(dr("P_EnDate").ToString)
                player.ImagePath = dr("P_Image").ToString
                player.JerseyNum = CInt(dr("P_Jersey").ToString)
                player.StartDate = CDate(dr("P_StartDate").ToString)
                player.MarketValue = CDec(dr("P_Value").ToString)
                playerList.Add(player.ID, player)
            Loop
            dr.Close()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Get Players Exception")
        Finally
            myConnection.Close()
        End Try
        Return playerList
    End Function

    Public Shared Sub AddPlayer(newPlayer As Player)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Dim insertStatement As String = "INSERT INTO Player Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(insertStatement, myConnection)
        Try
            myConnection.Open()
            With cmd.Parameters
                .Add(New OleDbParameter("Player_ID", newPlayer.ID))
                .Add(New OleDbParameter("P_Name", newPlayer.Name))
                .Add(New OleDbParameter("P_Surname", newPlayer.Surname))
                .Add(New OleDbParameter("P_Email", newPlayer.Email))
                .Add(New OleDbParameter("P_Phone", newPlayer.Phone))
                .Add(New OleDbParameter("P_DOB", newPlayer.BirthDate))
                .Add(New OleDbParameter("P_Nation", newPlayer.Nationality))
                .Add(New OleDbParameter("P_Address", newPlayer.Address))
                .Add(New OleDbParameter("P_Value", newPlayer.MarketValue))
                .Add(New OleDbParameter("P_Salary", newPlayer.MonthlySal))
                .Add(New OleDbParameter("P_Position", newPlayer.Position.ToString))
                .Add(New OleDbParameter("P_Jersey", newPlayer.JerseyNum))
                .Add(New OleDbParameter("P_EnDate", newPlayer.EndDate))
                .Add(New OleDbParameter("P_Image", newPlayer.ImagePath))
                .Add(New OleDbParameter("P_StartDate", newPlayer.StartDate))

            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Insert Player")
        Finally
            myConnection.Close()
        End Try
    End Sub

    Public Shared Sub RemovePlayer(playerID As Integer)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection
        Dim deleteStatement As String
        deleteStatement = "DELETE FROM Player WHERE ( Player_ID = " & playerID & ")"
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

    Public Shared Sub ModifyPlayer(player As Player)

    End Sub

    Public Shared Function GetInjuredPlayers() As SortedDictionary(Of Integer, Injured)
        Dim playerList As New SortedDictionary(Of Integer, Injured)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Dim dr As OleDbDataReader

        Try
            myConnection.Open()
            Dim selectStatement As String
            selectStatement = "SELECT * FROM Injured"
            Dim cmd As OleDbCommand = New OleDbCommand(selectStatement, myConnection)
            dr = cmd.ExecuteReader
            Dim player As Injured
            Do While dr.Read
                player = New Injured
                player.PlayerID = CInt(dr("Inj_ID").ToString)
                player.Diagnosis = dr("Inj_Diagnosis").ToString
                player.StartDate = CDate(dr("Inj_StartDate").ToString)
                player.EndDate = CDate(dr("Inj_EndDate").ToString)
                playerList.Add(player.PlayerID, player)
            Loop
            dr.Close()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Get Injured Exception")
        Finally
            myConnection.Close()
        End Try
        Return playerList
    End Function

    Public Shared Sub AddInjuredPlayer(inj As Injured)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Try
            myConnection.Open()
            Dim insertStatement As String
            insertStatement = "INSERT INTO Injured VALUES (?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(insertStatement, myConnection)
            With cmd.Parameters
                .Add(New OleDbParameter("Inj_ID", inj.PlayerID))
                .Add(New OleDbParameter("Inj_Diagnosis", inj.Diagnosis))
                .Add(New OleDbParameter("Inj_StartDate", inj.StartDate))
                .Add(New OleDbParameter("Inj_EnDate", inj.EndDate))
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Insert Injured")
        Finally
            myConnection.Close()
        End Try
    End Sub

    Public Shared Sub RemoveInjuredPlayer(playerID As Integer)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection
        Dim deleteStatement As String
        deleteStatement = "DELETE FROM Injured WHERE ( Inj_ID = " & playerID & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(deleteStatement, myConnection)
        Try
            myConnection.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database delete Injured")
        Finally
            myConnection.Close()
        End Try
        MessageBox.Show("Player successfully removed from injury list")
    End Sub

    Public Shared Sub ModifyInjuredPlayer(player As Player)

    End Sub

    Public Shared Sub UpdatePlayer(p As Player)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection
        myConnection.Open()
        Dim updateStatement As String
        updateStatement = "UPDATE Player SET [P_Email] = " & p.Email & ", [P_Address] = " & _
            p.Address & ", [P_Phone] = " & p.Phone & ", [P_Value] = " & _
            p.MarketValue & ", [P_EnDate] = " & p.EndDate & " [P_Salary] = " & p.MonthlySal & " WHERE ( Player_ID = " & p.ID & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(updateStatement, myConnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Player")
        Finally
            myConnection.Close()
        End Try
    End Sub
End Class
