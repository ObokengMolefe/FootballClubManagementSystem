Public Class ClearFields

    Public Shared Sub ClearTechStaffFields()
        frmFCMS.txtStaffAddress.Clear()
        frmFCMS.txtStaffEmail.Clear()
        frmFCMS.txtStaffName.Clear()
        frmFCMS.txtStaffPhone.Clear()
        frmFCMS.txtStaffSurname.Clear()
        frmFCMS.txtStaffSalary.Clear()
        frmFCMS.cmboxStaffRole.SelectedIndex = -1
        frmFCMS.dateStaffEnd.Value = Date.Today
    End Sub

    Public Shared Sub ClearFanFields()
        frmFCMS.txtFanAddress.Clear()
        frmFCMS.txtFanName.Clear()
        frmFCMS.txtFanPhone.Clear()
        frmFCMS.txtFanSurname.Clear()
        frmFCMS.dateFanDoB.Value = Date.Today
        frmFCMS.lstboxFanCat.SelectedIndex = -1
        frmFCMS.rdoFanFemale.Checked = False
        frmFCMS.rdoFanMale.Checked = False
    End Sub

    Public Shared Sub ClearSponsorFields()
        frmFCMS.txtSponsorFee.Clear()
        frmFCMS.txtSponsorIndustry.Clear()
        frmFCMS.txtSponsorName.Clear()
        frmFCMS.dateSponsorEnd.Value = Date.Today
    End Sub

    Public Shared Sub ClearPlayerFields()
        frmFCMS.txtPlayerName.Text = ""
        frmFCMS.txtPlayerSurname.Text = ""
        frmFCMS.txtPlayerAddress.Text = ""
        frmFCMS.txtPlayerEmail.Text = ""
        frmFCMS.cmboxPlayerNation.SelectedIndex = -1
        frmFCMS.picboxPlayer.Image = FootballClubManagementSystem.My.Resources.Resources.image_holder
        frmFCMS.cmboxPlayerPosition.SelectedIndex = -1
        frmFCMS.txtPlayerSalary.Text = ""
        frmFCMS.txtPlayerValue.Text = ""
        frmFCMS.txtPlayerPhone.Text = ""
        frmFCMS.txtPlayerJerseyNo.Text = ""
        frmFCMS.datePlayerEnd.Value = Date.Now
        frmFCMS.datePlayerDoB.Value = Date.Now
    End Sub

    Public Shared Sub ClearInjuredFields()
        frmFCMS.cmboInjuredIDs.SelectedIndex = -1
        frmFCMS.dateInjuredEnd.Value = Date.Now
    End Sub
End Class
