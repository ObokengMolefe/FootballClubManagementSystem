Public Class frmAddInjuredPlayer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newInjured As Injured
        Dim pID As Integer = CInt(txtInjPlayerId.Text)
        Dim diagno As String = txtInjReason.Text
        Dim endate As Date = dateInjEndate.Value

        newInjured = New Injured(pID, diagno, endate)
        frmFCMS.injuredList.Add(newInjured)
        DBPlayer.AddInjuredPlayer(newInjured)
        FillFieldsWithData.FillInjuredDataGrid()
        FillFieldsWithData.FillInjuredIDs()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmAddInjuredPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtInjReason.Focus()
    End Sub
End Class