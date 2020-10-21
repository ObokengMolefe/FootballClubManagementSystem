Imports System.Data.OleDb

Public Class DBTechStaff

    Public Shared Function GetStaff() As SortedDictionary(Of Integer, TechnicalStaff)
        Dim techTeam As New SortedDictionary(Of Integer, TechnicalStaff)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Dim dr As OleDbDataReader
        Try
            myConnection.Open()
            Dim selectStatement As String
            selectStatement = "SELECT * FROM Technical_Staff"
            Dim cmd As OleDbCommand = New OleDbCommand(selectStatement, myConnection)
            dr = cmd.ExecuteReader
            Dim staff As TechnicalStaff
            Do While dr.Read()
                staff = New TechnicalStaff
                staff.ID = CInt(dr("Staff_ID").ToString)
                staff.Role = CType(staff.GetRoleEnumIndex(dr("T_Role").ToString), Role)
                staff.StartDate = CDate(dr("T_StartDate").ToString)
                staff.Name = dr("T_Name").ToString
                staff.Surname = dr("T_Surname").ToString
                staff.Email = dr("T_Email").ToString
                staff.MonthlySal = CDec(dr("T_Salary").ToString)
                staff.Address = dr("T_Address").ToString
                staff.EndDate = CDate(dr("T_EnDate").ToString)
                staff.Phone = CInt(dr("T_Phone").ToString)
                techTeam.Add(staff.ID, staff)
            Loop
            dr.Close()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Exception")
        Finally
            myConnection.Close()
        End Try
        Return techTeam
    End Function

    Public Shared Sub AddStaff(staff As TechnicalStaff)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection()
        Try
            myConnection.Open()
            Dim insertStatement As String
            insertStatement = "INSERT INTO Technical_Staff VALUES (?,?,?,?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(insertStatement, myConnection)
            With cmd.Parameters
                .Add(New OleDbParameter("Staff_ID", staff.ID))
                .Add(New OleDbParameter("T_Name", staff.Name))
                .Add(New OleDbParameter("T_Surname", staff.Surname))
                .Add(New OleDbParameter("T_Email", staff.Email))
                .Add(New OleDbParameter("T_Phone", staff.Phone))
                .Add(New OleDbParameter("T_Address", staff.Address))
                .Add(New OleDbParameter("T_Role", staff.Role))
                .Add(New OleDbParameter("T_Salary", staff.MonthlySal))
                .Add(New OleDbParameter("T_StartDate", staff.StartDate))
                .Add(New OleDbParameter("T_EnDate", staff.EndDate))
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Database Insert Tech Staff")
        Finally
            myConnection.Close()
        End Try
    End Sub

    Public Shared Sub RemoveStaff(staffID As Integer)
        Dim myConnection As OleDbConnection = DBFCMS.GetConnection
        Dim deleteStatement As String
        deleteStatement = "DELETE FROM Technical_Staff WHERE ( Staff_ID = " & staffID & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(deleteStatement, myConnection)
        Try
            myConnection.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database delete staff")
        Finally
            myConnection.Close()
        End Try
        MessageBox.Show("Technical Staff successfully deleted")
    End Sub

    Public Shared Sub ModifyStaff(staff As TechnicalStaff)

    End Sub
End Class
