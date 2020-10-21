Public Class frmAdminAuthorisation
    Const authoKey As String = "admin"

    Private Sub frmAdminAuthorisation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Me.txtAdminAuthoKey.Text = authoKey Then
            frmAddUser.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Authorisation key invalid", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtAdminAuthoKey.Clear()
        End If
    End Sub
End Class