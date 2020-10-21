Public Class frmLogin
    Public Shared activeUser As User
    Public Shared book As New UserBook

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If txtUsrname.Text = vbNullString Or txtUsrpassword.Text = vbNullString Then
            MessageBox.Show("You are required to input both Username and Password", "Invalid Input Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            activeUser = book.Item(txtUsrname.Text)
            If activeUser IsNot Nothing Then

                If activeUser.Username = txtUsrname.Text And activeUser.Password = txtUsrpassword.Text Then
                    Me.Hide()
                    frmLoading.Show()
                    ' activeUser.Login()
                Else
                    MessageBox.Show("Credentials do not match", "Credential Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                MessageBox.Show("User does not exist", "Unknown User", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        book = New UserBook(DBUser.GetUsers())
    End Sub
End Class
