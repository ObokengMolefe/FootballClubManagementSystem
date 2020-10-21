Public Class frmLoading

    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' ProgressBarLoad.Increment(20)

        Me.lblPercent.Text = ProgressBarLoad.Value & " %"
        If (ProgressBarLoad.Value = ProgressBarLoad.Maximum) Then
            Timer1.Dispose()
            Me.Hide()
            frmLogin.activeUser.Login()
            'MessageBox.Show("Hello")
            Exit Sub
        End If
        ProgressBarLoad.Value += 10
    End Sub

    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        frmFCMS.technicalTeam = New TechStaffTeam(DBTechStaff.GetStaff())
        frmFCMS.scoutsList = New ScoutList(DBPlayerTransfers.GetScoutList())
        frmFCMS.sponsorsList = New SponsorList(DBSponsor.GetSponsors())
        frmFCMS.listPlayers = New PlayerList(DBPlayer.GetPlayers())
        frmFCMS.membership = New ClubMembership(DBFan.GetFans())
        'frmFCMS.injuredList = New InjuryList(DBPlayer.GetInjuredPlayers())
    End Sub
End Class