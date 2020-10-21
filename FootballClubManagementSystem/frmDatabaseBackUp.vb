Public Class frmDatabaseBackUp

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Me.Backup()
    End Sub

    Private Sub Backup()

        Dim database As String = Application.StartupPath & "\FCMS_Database.accdb"
        Dim playerImages As String = Application.StartupPath & "\PlayerImages"
        Dim location As String = Application.StartupPath & "\Backups"
        Try
            If Not (My.Computer.FileSystem.DirectoryExists(location)) Then
                My.Computer.FileSystem.CreateDirectory(location)
            End If
            My.Computer.FileSystem.CopyDirectory(playerImages, location & "\PlayerImages", True)
            My.Computer.FileSystem.CopyFile(database, location & "\FCMS_Database.accdb", True)

        Catch ex As Exception
            Throw ex
        End Try
       
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(2)
        Me.lblPerc.Text = ProgressBar1.Value & "%"
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Stop()
        End If

    End Sub

    Private Sub frmDatabaseBackUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Dispose()
        Me.Close()
    End Sub
End Class