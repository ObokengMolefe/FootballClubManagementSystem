Public Class frmAddScoutPlayer

    Private Sub frmAddScoutPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmboScoutPosition.Items.Add(Position.Striker)
        cmboScoutPosition.Items.Add(Position.Midfielder)
        cmboScoutPosition.Items.Add(Position.Defender)
        cmboScoutPosition.Items.Add(Position.Goalkeeper)

    End Sub

    Private Sub btnScoutSave_Click(sender As Object, e As EventArgs) Handles btnScoutSave.Click
        If ((txtScoutName.Text = vbNullString) Or (txtScoutSurname.Text = vbNullString) Or (txtScoutValue.Text = vbNullString) Or (txtScoutClub.Text = vbNullString) _
           Or (Me.dateScoutDoB.Value.ToShortDateString.Equals(Date.Now.ToShortDateString)) Or (Me.cmboScoutPosition.SelectedIndex = -1)) Then
            MessageBox.Show("Please fill all fields" & vbNewLine & "Birth date should be earlier than today" & vbNewLine & "Please select position",
                            "Add new scouted player", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim player As ScoutedPlayer
            Dim pos As Position = CType(cmboScoutPosition.SelectedItem, Position)
            player = New ScoutedPlayer(frmFCMS.scoutsList.GenerateID(), txtScoutName.Text, txtScoutSurname.Text, pos, txtScoutClub.Text, CDec(txtScoutValue.Text), dateScoutDoB.Value)
            frmFCMS.scoutsList.Add(player)
            MessageBox.Show("Successfully Saved")
        End If
    End Sub

    Private Sub btnScoutCancel_Click(sender As Object, e As EventArgs) Handles btnScoutCancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtScoutName.Text = vbNullString
        txtScoutSurname.Text = vbNullString
        txtScoutValue.Text = vbNullString
        txtScoutClub.Text = vbNullString
        Me.dateScoutDoB.Value = Date.Now
        Me.cmboScoutPosition.SelectedIndex = -1
    End Sub
End Class