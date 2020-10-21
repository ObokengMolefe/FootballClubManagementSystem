Imports System.Data.OleDb

Public Class DBFCMS

    'Creating connection to the database
    Public Shared Function GetConnection() As OleDbConnection
        Dim connectionString As String =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " & Application.StartupPath & "\FCMS_Database.accdb"
        Return New OleDbConnection(connectionString)
    End Function

End Class
