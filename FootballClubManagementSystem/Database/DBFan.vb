Imports System.Data.OleDb

Public Class DBFan
    'Shared function to get list of all club fans from the database
    Public Shared Function GetFans() As SortedDictionary(Of Integer, Fan)
        Dim fanList As New SortedDictionary(Of Integer, Fan)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Dim dr As OleDbDataReader

        Try
            myConnection.Open()
            Dim selectStatement As String
            selectStatement = "SELECT * FROM Fan"
            Dim cmd As OleDbCommand = New OleDbCommand(selectStatement, myConnection)
            dr = cmd.ExecuteReader
            Dim fan As Fan
            Do While dr.Read
                fan = New Fan
                fan.ID = CInt(dr("Fan_ID").ToString)
                fan.Name = dr("F_Name").ToString
                fan.Surname = dr("F_Surname").ToString
                fan.BirthDate = CDate(dr("F_DOB").ToString)
                fan.Gender = dr("F_Gender").ToString
                fan.Phone = CInt(dr("F_Phone").ToString)
                fan.Address = dr("F_Address").ToString
                fan.Category = dr("F_Category").ToString
                fan.StartDate = CDate(dr("F_StartDate").ToString)
                fan.EndDate = CDate(dr("F_EnDate").ToString)
                fanList.Add(fan.ID, fan)
            Loop
            dr.Close()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Get Fan Exception")
        Finally
            myConnection.Close()
        End Try
        Return fanList

    End Function
    'Shared function to add new fan to the database
    Public Shared Sub AddFan(fn As Fan)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Try
            myConnection.Open()
            Dim insertStatement As String
            insertStatement = "INSERT INTO Fan VALUES (?,?,?,?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(insertStatement, myConnection)
            With cmd.Parameters
                .Add(New OleDbParameter("Fan_ID", fn.ID))
                .Add(New OleDbParameter("F_Name", fn.Name))
                .Add(New OleDbParameter("F_Surname", fn.Surname))
                .Add(New OleDbParameter("F_DOB", fn.BirthDate))
                .Add(New OleDbParameter("F_Gender", fn.Gender))
                .Add(New OleDbParameter("F_Phone", fn.Phone))
                .Add(New OleDbParameter("F_Address", fn.Address))
                .Add(New OleDbParameter("F_Category", fn.Category))
                .Add(New OleDbParameter("F_StartDate", fn.StartDate))
                .Add(New OleDbParameter("F_EnDate", fn.EndDate))
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Insert Fan")
        Finally
            myConnection.Close()
        End Try
    End Sub
    'Shared function to remove a fan from the database
    Public Shared Sub RemoveFan(fanID As Integer)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection
        Dim deleteStatement As String
        deleteStatement = "DELETE FROM Fan ( Staff_ID = " & fanID & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(deleteStatement, myConnection)
        Try
            myConnection.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Delete Fan")
        Finally
            myConnection.Close()
        End Try
        MessageBox.Show("Fan successfully deleted")
    End Sub
    'Shared function to modify fan 
    Public Shared Sub ModifyFan(fan As Fan)

    End Sub
End Class
