Public Class frmAddUser

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (Not (Validator.IsValidUserTextbox) Or Not (Validator.IsValidUserDep)) Then
            MessageBox.Show("Please fill all fields and chooser department")
        ElseIf (Me.usernameExist(Me.txtUsername.Text) = True) Then
            MessageBox.Show("Unsername already taken please choose a different one")
        Else
            Dim usr As User = New User(txtUsername.Text, txtPassword.Text, Me.GetDep(), txtName.Text, txtSurname.Text)
            frmLogin.book.AddUser(usr)
            DBUser.AddUser(usr)
            MessageBox.Show("New User Added")
        End If
        FillFieldsWithData.FillUsersdataGrid()
    End Sub

    Private Function usernameExist(un As String) As Boolean
        Dim result As Boolean = False
        For Each usr As User In frmLogin.book.Users
            If (usr.Username = Me.txtUsername.Text) Then
                result = True
            End If
        Next
        Return result
    End Function

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillFieldsWithData.FillUsersdataGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Function GetDep() As Department
        Dim dp As Department
        If (Me.rdoFin.Checked) Then
            dp = Department.Finance
        ElseIf (Me.rdoHR.Checked) Then
            dp = Department.HumanResources
        Else
            dp = Department.Management
        End If
        Return dp
    End Function

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

    End Sub
End Class