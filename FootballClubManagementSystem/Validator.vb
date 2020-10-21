Public Class Validator
    Public Shared Function IsValidFanTextbox() As Boolean
        If ((frmFCMS.txtFanName.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtFanSurname.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtFanPhone.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtFanAddress.Text.Trim(CChar(" ")) = vbNullString)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsValidTechStaffTextbox() As Boolean
        If ((frmFCMS.txtStaffAddress.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtStaffEmail.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtStaffName.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtStaffSalary.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtStaffSurname.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtStaffPhone.Text.Trim(CChar(" ")) = vbNullString)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsValidPlayerTextbox() As Boolean
        If ((frmFCMS.txtPlayerAddress.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtPlayerEmail.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtPlayerPhone.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtPlayerSalary.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtPlayerSurname.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtPlayerValue.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtPlayerJerseyNo.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmFCMS.txtPlayerName.Text.Trim(CChar(" ")) = vbNullString)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsValidSponsorTextbox() As Boolean
        If ((frmFCMS.txtSponsorName.Text = vbNullString) OrElse
              (frmFCMS.txtSponsorIndustry.Text = vbNullString) OrElse
              (frmFCMS.txtSponsorFee.Text = vbNullString)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsValidUserTextbox() As Boolean
        If ((frmAddUser.txtName.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmAddUser.txtSurname.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmAddUser.txtUsername.Text.Trim(CChar(" ")) = vbNullString) OrElse
              (frmAddUser.txtPassword.Text.Trim(CChar(" ")) = vbNullString)) Then
            Return False
        Else
            Return True
        End If
    End Function
    'Validate to ensure that neither birth date nor end date equals current date
    Public Shared Function IsValidBirthDate(paramDate As Date) As Boolean
        If ((paramDate.ToShortDateString) >= (Date.Today.ToShortDateString)) Then
            Return False
        Else
            Return True
        End If
    End Function

    'Validate to ensure that neither birth date nor end date equals current date
    Public Shared Function IsValidEndDate(paramDate As Date) As Boolean
        If ((paramDate.ToShortDateString) <= (Date.Today.ToShortDateString)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsValidPlayerCombobox() As Boolean
        If ((frmFCMS.cmboxPlayerNation.SelectedIndex = -1) Or (frmFCMS.cmboxPlayerPosition.SelectedIndex = -1)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsValidTechStaffCombobox() As Boolean
        If (frmFCMS.cmboxStaffRole.SelectedIndex = -1) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsValidFanListbox() As Boolean
        If (frmFCMS.lstboxFanCat.SelectedIndex = -1) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsValidFanGender() As Boolean
        If ((frmFCMS.rdoFanMale.Checked = False) And (frmFCMS.rdoFanFemale.Checked = False)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsValidUserDep() As Boolean
        If (Not (frmAddUser.rdoFin.Checked) And Not (frmAddUser.rdoHR.Checked) And Not (frmAddUser.rdoMan.Checked)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsImage(img As PictureBox) As Boolean
        If (img.Image Is FootballClubManagementSystem.My.Resources.Resources.image_holder) Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
