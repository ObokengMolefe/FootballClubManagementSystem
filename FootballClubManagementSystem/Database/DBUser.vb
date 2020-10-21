Imports System.Data.OleDb

Public Class DBUser

    Public Shared Function GetUsers() As List(Of User)
        Dim sysusers As New List(Of User)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Dim dr As OleDbDataReader
        Try
            myConnection.Open()
            Dim selectStatement As String
            selectStatement = "SELECT * FROM SystemUser"
            Dim cmd As OleDbCommand = New OleDbCommand(selectStatement, myConnection)
            dr = cmd.ExecuteReader
            Dim user As User
            Do While dr.Read()
                user = New User
                user.Username = dr("User_Name").ToString
                user.Password = dr("U_Password").ToString
                user.Department = CType(user.GetDepEnumIdex(dr("U_Department").ToString), Department)
                user.Name = dr("U_Name").ToString
                user.Surname = dr("U_Surname").ToString
                sysusers.Add(user)
            Loop
            dr.Close()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Exception")
        Finally
            myConnection.Close()
        End Try
        Return sysusers
    End Function

    Public Shared Sub AddUser(newUser As User)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Try
            myConnection.Open()
            Dim insertStatement As String
            insertStatement = "INSERT INTO SystemUser VALUES (?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(insertStatement, myConnection)
            With cmd.Parameters
                .Add(New OleDbParameter("User_Name", newUser.Username))
                .Add(New OleDbParameter("U_Password", newUser.Password))
                .Add(New OleDbParameter("U_Department", newUser.Department))
                .Add(New OleDbParameter("U_Name", newUser.Name))
                .Add(New OleDbParameter("U_Surname", newUser.Surname))
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Insert User")
        Finally
            myConnection.Close()
        End Try
    End Sub

    Public Shared Sub RemoveUser(userName As String)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection
        Dim deleteStatement As String
        deleteStatement = "DELETE FROM SystemUser WHERE ( User_Name = " & userName & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(deleteStatement, myConnection)
        Try
            myConnection.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database delete User")
        Finally
            myConnection.Close()
        End Try
        MessageBox.Show("User successfully deleted")
    End Sub

    Public Shared Sub ModifyUser(player As User)

    End Sub
End Class
