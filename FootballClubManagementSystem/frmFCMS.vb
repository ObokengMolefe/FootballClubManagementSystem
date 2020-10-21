

Public Class frmFCMS

    Public listPlayers As PlayerList
    Public membership As ClubMembership
    Public technicalTeam As TechStaffTeam
    Public injuredList As InjuryList
    Public playerTranfers As TransferList
    Public sponsorsList As SponsorList
    Public newSales As Sales
    Public scoutsList As ScoutList

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btnAddtoInjured.Click
        If (cmboxPlayerIDs.SelectedIndex = -1) Then
            MessageBox.Show("Please select the player from the combo-box list", "Player ID Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If (injuredList.InjuredPlayers.ContainsKey(CInt(cmboxPlayerIDs.SelectedItem.ToString))) Then
                MessageBox.Show("Player with the id" & cmboxPlayerIDs.SelectedItem.ToString & " has already been added to the injury list", "Player exists in injury list",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frmAddInjuredPlayer.txtInjPlayerId.Text = Me.cmboxPlayerIDs.SelectedItem.ToString
                Dim injPlayer As Player = listPlayers.GetPlayer(CInt(cmboxPlayerIDs.SelectedItem))
                frmAddInjuredPlayer.txtInjName.Text = injPlayer.Name.ToString
                frmAddInjuredPlayer.ShowDialog()
                Me.FillPlayerIDs()
                ClearFields.ClearPlayerFields()
            End If
            
        End If

    End Sub

    Private Sub frmFCMS_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim result As MsgBoxResult = CType(MessageBox.Show("Are you sure you want to exit?", "Exit Program?",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2), MsgBoxResult)
            If (result = MsgBoxResult.Yes) Then
                Me.Close()
            End If
            Exit Sub
        ElseIf e.KeyCode = Keys.L AndAlso e.Modifiers = Keys.Control Then
            frmLogin.Show()
            Me.Close()
        End If

        If e.KeyCode = Keys.F1 Then
            frmAboutBox.ShowDialog()
        End If

        If e.KeyCode = Keys.D1 AndAlso e.Modifiers = Keys.Control Then
            TabControl1.SelectTab(Me.TabPagePlayerView)
        End If

        If e.KeyCode = Keys.D2 AndAlso e.Modifiers = Keys.Control Then
            TabControl1.SelectTab(Me.TabPageStaffView)
        End If
        If e.KeyCode = Keys.D3 AndAlso e.Modifiers = Keys.Control Then
            TabControl1.SelectTab(Me.TabPageMedView)
        End If
        If e.KeyCode = Keys.D4 AndAlso e.Modifiers = Keys.Control Then
            TabControl1.SelectTab(Me.TabPageTransView)
        End If
        If e.KeyCode = Keys.D5 AndAlso e.Modifiers = Keys.Control Then
            TabControl1.SelectTab(Me.TabPageFanView)
        End If
        If e.KeyCode = Keys.D6 AndAlso e.Modifiers = Keys.Control Then
            TabControl2.SelectTab(Me.TabPagePlayerAdd)
        End If
        If e.KeyCode = Keys.D7 AndAlso e.Modifiers = Keys.Control Then
            TabControl2.SelectTab(Me.TabPageStaffAdd)
        End If
        If e.KeyCode = Keys.D8 AndAlso e.Modifiers = Keys.Control Then
            TabControl2.SelectTab(Me.TabPageFanAdd)
        End If
    End Sub

    Private Sub frmFCMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.showUI(frmLogin.activeUser.Department)
        frmLogin.Close()
        frmLoading.Close()

        'listPlayers = New PlayerList()
        ' membership = New ClubMembership(DBFan.GetFans())
        ' technicalTeam = New TechStaffTeam()
        injuredList = New InjuryList()
        playerTranfers = New TransferList(DBPlayerTransfers.GetTransferList())
        ' sponsorsList = New SponsorList()
        newSales = New Sales()
        ' scoutsList = New ScoutList()

        FillPlayerPositions()
        FillFieldsWithData.FillPlayerIDs()
        FillFieldsWithData.FillInjuredIDs()
        FillFieldsWithData.FillReportInjuredDataGrid()

        AddStatusBar()
    End Sub
    Private datePanel As New StatusBarPanel
    Public Sub AddStatusBar()
        Dim mainStatusbar As New StatusBar
        Dim userPanel As New StatusBarPanel



        userPanel.BorderStyle = StatusBarPanelBorderStyle.Sunken
        userPanel.Text = "Logged User: " & frmLogin.activeUser.Name & " " & frmLogin.activeUser.Surname
        userPanel.ToolTipText = "Current Active User"
        userPanel.AutoSize = StatusBarPanelAutoSize.Spring
        mainStatusbar.Panels.Add(userPanel)

        datePanel.BorderStyle = StatusBarPanelBorderStyle.Raised
        datePanel.Text = ""
        datePanel.ToolTipText = "Date and Time"
        datePanel.AutoSize = StatusBarPanelAutoSize.Contents
        mainStatusbar.Panels.Add(datePanel)
        mainStatusbar.ShowPanels = True
        Controls.Add(mainStatusbar)

    End Sub

    Private Sub showUI(dep As Department)
        Me.TabControl.TabPages.Clear()
        Select Case dep
            Case Department.HumanResources
                Me.TabControl.TabPages.Add(TabPageHR)
            Case Department.Finance
                Me.TabControl.TabPages.Add(TabPageFin)
            Case Department.Management
                Me.TabControl.TabPages.Add(TabPageMan)
        End Select
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnPlayerImage.Click
        OpenFileDialog1.ShowDialog()

        Dim file As String = OpenFileDialog1.FileName()
        picboxPlayer.ImageLocation = file
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmAdminAuthorisation.ShowDialog()
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        frmAdminAuthorisation.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        frmAboutBox.ShowDialog()
    End Sub

    Private Sub btnPlayerSave_Click(sender As Object, e As EventArgs) Handles btnPlayerSave.Click
        Dim myPlayer As Player

        If ((Validator.IsValidPlayerTextbox = False) Or (Validator.IsValidBirthDate(datePlayerDoB.Value) = False) Or
           (Validator.IsValidPlayerCombobox = False) Or (Validator.IsValidEndDate(datePlayerEnd.Value) = False)) Then
            MessageBox.Show("Please all textbox should be filled" & vbNewLine & "Please select the valid date of birth" & vbNewLine &
                            "Please select valid end date" & vbNewLine & "Please select player position", "Invalid Entry Inputs", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (FillFieldsWithData.JerseyAvailable(CInt(txtPlayerJerseyNo.Text)) = False) Then
            MessageBox.Show("Jersey Number: " & txtPlayerJerseyNo.Text & " is already taken. Please choose another one", "Jersey Number Taken",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (Validator.IsImage(picboxPlayer) = False) Then
            MessageBox.Show("Please provide the player image", "No player Image",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim idP As Integer = ProducePlayerID(Me.datePlayerDoB.Value, txtPlayerJerseyNo.Text)
            Dim nameP As String = txtPlayerName.Text
            Dim surnameP As String = txtPlayerSurname.Text
            Dim addressP As String = txtPlayerAddress.Text
            Dim emailP As String = txtPlayerEmail.Text
            Dim nationP As String = CStr(cmboxPlayerNation.SelectedItem)
            Dim imageP As String = Me.GetPlayerImage(picboxPlayer.ImageLocation, idP)
            Dim positionP As Position = CType(cmboxPlayerPosition.SelectedIndex, Position)
            Dim salaryP As Decimal = CDec(txtPlayerSalary.Text)
            Dim valueP As Decimal = CDec(txtPlayerValue.Text)
            Dim phoneP As Integer = CInt(txtPlayerPhone.Text)
            Dim jerseyNoP As Integer = CInt(txtPlayerJerseyNo.Text)
            Dim endDateP As Date = CDate(Me.datePlayerEnd.Value)
            Dim birthDateP As Date = CDate(Me.datePlayerDoB.Value)

            myPlayer = New Player(idP, nameP, surnameP, phoneP, addressP, endDateP, emailP, salaryP, valueP, positionP, birthDateP, jerseyNoP, nationP, imageP)
            listPlayers.Add(myPlayer)
            DBPlayer.AddPlayer(myPlayer)
            MessageBox.Show("Player successfully saved")
            FillFieldsWithData.FillPlayerIDs()
        End If

    End Sub

    'Generate a employee id for player which will be used to refer to specific player
    Public Function ProducePlayerID(dob As Date, jersey As String) As Integer
        Dim birthDate As String = String.Format("{0:yyyymmdd}", dob)
        Dim jerseyNum As Integer = Convert.ToInt32(jersey)
        Dim formattedJerseyNum As String = jerseyNum.ToString.PadLeft(2, "0"c)

        Return CInt(birthDate + formattedJerseyNum)
    End Function

    Private Sub btnPlayerSaveChanges_Click(sender As Object, e As EventArgs)
        For Each p As KeyValuePair(Of Integer, Player) In listPlayers.Players
            MessageBox.Show(p.Value.ToString(), "")

        Next
    End Sub

    'On-load fill in the combobox with valid player positions
    Private Sub FillPlayerPositions()
        cmboxPlayerPosition.Items.Add(Position.Striker)
        cmboByPosition.Items.Add(Position.Striker)
        cmboxPlayerPosition.Items.Add(Position.Midfielder)
        cmboByPosition.Items.Add(Position.Midfielder)
        cmboxPlayerPosition.Items.Add(Position.Defender)
        cmboByPosition.Items.Add(Position.Defender)
        cmboxPlayerPosition.Items.Add(Position.Goalkeeper)
        cmboByPosition.Items.Add(Position.Goalkeeper)
    End Sub


    Private Function GetPosition() As Position
        Dim pos As Position = Nothing
        Select Case Me.cmboxPlayerPosition.SelectedItem.ToString
            Case "Striker"
                pos = Position.Striker
            Case "Midfielder"
                pos = Position.Midfielder
            Case "Defender"
                pos = Position.Defender
            Case "Goalkeeper"
                pos = Position.Goalkeeper
        End Select
        Return pos
    End Function

    'Retrive all registered players and fill the datagridview for players 
    Private Sub btnPlayerGetAll_Click(sender As Object, e As EventArgs) Handles btnPlayerGetAll.Click
        dgvPlayer.Rows.Clear()
        For Each p As KeyValuePair(Of Integer, Player) In listPlayers.Players
            Me.dgvPlayer.Rows.Add(p.Value.Name, p.Value.Surname, p.Value.Age, p.Value.Nationality, p.Value.JerseyNum,
                                             p.Value.Position, p.Value.MarketValue.ToString("C2"), p.Value.MonthlySal.ToString("C2"), p.Value.YearsLeft)
        Next
    End Sub

    Private Sub btnFanSave_Click(sender As Object, e As EventArgs) Handles btnFanSave.Click
        Dim clubFan As Fan
        Dim gender As String = ""
        If ((Validator.IsValidFanGender = False) Or (Validator.IsValidFanListbox = False) Or (Validator.IsValidFanTextbox = False)) Then
            MessageBox.Show("Please all textbox should be filled" & vbNewLine & "Please select gender" & vbNewLine &
                       "Please select membership category", "Invalid Entry Inputs", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If (Me.rdoFanMale.Checked) Then
                gender = "Male"
            Else
                gender = "Female"
            End If

            clubFan = New Fan(ClubMembership.GenerateID(membership.Fans), txtFanName.Text, txtFanSurname.Text, CInt(txtFanPhone.Text), txtFanAddress.Text, Date.Today.AddMonths(12),
                              dateFanDoB.Value, gender, CStr(lstboxFanCat.SelectedItem), Fan.GetFee(lstboxFanCat.SelectedItem.ToString))

            membership.Add(clubFan)
            DBFan.AddFan(clubFan)
            MessageBox.Show("Fan Information Added")
        End If
    End Sub

    Private Sub btnFanGetAll_Click(sender As Object, e As EventArgs) Handles btnFanGetAll.Click
        Me.dataGridFan.Rows.Clear()
        For Each f As KeyValuePair(Of Integer, Fan) In membership.Fans
            Me.dataGridFan.Rows.Add(f.Value.Name, f.Value.Surname, f.Value.Phone, f.Value.Gender, f.Value.Category, f.Value.Expired)
        Next
        'MessageBox.Show(DBFan.GetFans().Count.ToString)
    End Sub

    Private Sub btnFanSearch_Click(sender As Object, e As EventArgs) Handles btnFanSearch.Click
        Me.dataGridFan.Rows.Clear()
        ' Dim searchFan As Fan
        If ((Me.txtFanByID.Text.Trim(CChar(" ")) = vbNullString) AndAlso (Me.txtFanByName.Text.Trim(CChar(" ")) = vbNullString)) Then
            MessageBox.Show("One of the fields(ID or Name) must be filled", "Invalid Entry")
        ElseIf ((Me.txtFanByID.Text <> vbNullString) And (Me.txtFanByName.Text.Trim(CChar(" ")) = vbNullString)) Then
            FillFieldsWithData.SearchFanByID(CInt(Me.txtFanByID.Text))
        ElseIf ((Me.txtFanByID.Text.Trim(CChar(" ")) = vbNullString) And (Me.txtFanByName.Text <> vbNullString)) Then
            FillFieldsWithData.SearchFanByName(Me.txtFanByName.Text)
        Else
            FillFieldsWithData.SearchFanByID(CInt(Me.txtFanByID.Text))
        End If

    End Sub

    Private Sub btnFanIDEdit_Click(sender As Object, e As EventArgs) Handles btnFanIDEdit.Click
        If (Me.txtFanIDEdit.Text = "") Then
            MessageBox.Show("Please enter the fan ID to be searched", "Empty input entry")
        Else
            Dim fanID As Integer = CInt(Me.txtFanIDEdit.Text)
            If (membership.GetFan(fanID) IsNot Nothing) Then
                Dim showFan As Fan = membership.GetFan(fanID)
                Me.txtFanName.Text = showFan.Name.ToString
                Me.txtFanSurname.Text = showFan.Surname.ToString
                Me.txtFanPhone.Text = showFan.Phone.ToString
                Me.txtFanAddress.Text = showFan.Address.ToString
                Me.lstboxFanCat.SelectedItem = showFan.Category.ToString
                Me.dateFanDoB.Value = showFan.BirthDate
                If (showFan.Gender.ToString = "Male") Then
                    Me.rdoFanMale.Checked = True
                Else
                    Me.rdoFanFemale.Checked = True
                End If

                'Me.txtFanName.Enabled = False
                'Me.txtFanSurname.Enabled = False
                'Me.txtFanPhone.Enabled = False
                'Me.txtFanAddress.Enabled = False
                'Me.lstboxFanCat.Enabled = False
                'Me.dateFanDoB.Enabled = False
                'Me.rdoFanFemale.Enabled = False
                'Me.rdoFanMale.Enabled = False

            Else
                MessageBox.Show("Not found, Unknown")
            End If
        End If

    End Sub

    Private Sub btnFanSummaryReport_Click(sender As Object, e As EventArgs) Handles btnFanSummaryReport.Click
        FillFieldsWithData.ReportOnFans()
    End Sub

    Private Sub btnStaffSave_Click(sender As Object, e As EventArgs) Handles btnStaffSave.Click
        Dim newTechStaffMem As TechnicalStaff
        If ((Validator.IsValidTechStaffTextbox = False) Or (Validator.IsValidTechStaffCombobox = False)) Then
            MessageBox.Show("Please all textbox should be filled" & vbNewLine & "Please select role", "Invalid Entry Inputs", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Dim tRole As Role = Me.GetRole(cmboxStaffRole.SelectedIndex)

            newTechStaffMem = New TechnicalStaff(TechStaffTeam.GenerateID(cmboxStaffRole.SelectedItem.ToString), txtStaffName.Text, txtStaffSurname.Text, CInt(txtStaffPhone.Text),
                                                 txtStaffAddress.Text, dateStaffEnd.Value,
                                                 txtStaffEmail.Text, CDec(txtStaffSalary.Text), tRole)
            'MessageBox.Show("Staff Information Added")

            If (technicalTeam.Contains(newTechStaffMem.ID)) Then
                MessageBox.Show("There's already an employee for the role: " & cmboxStaffRole.SelectedItem.ToString, "Employee Role Already Taken",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                technicalTeam.Add(newTechStaffMem)
                DBTechStaff.AddStaff(newTechStaffMem)
            End If
            FillFieldsWithData.FillTechStaffRoles()
        End If
        
    End Sub

    Private Sub btnStaffSearch_Click(sender As Object, e As EventArgs) Handles btnStaffSearch.Click
        Dim member As TechnicalStaff
        If (txtStaffByRole.Text = vbNullString) Then
            MessageBox.Show("Please enter the technical staff role to search", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If (technicalTeam.GetStaffMember(TechStaffTeam.GenerateID(Me.txtStaffByRole.Text)) Is Nothing) Then
                MessageBox.Show("Role not found. Either invalid role or role has not yet been assigned to an employee.", "Invalid Role Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                member = technicalTeam.GetStaffMember(TechStaffTeam.GenerateID(Me.txtStaffByRole.Text))
                dataGridStaff.Rows.Clear()
                dataGridStaff.Rows.Add(member.Name, member.Surname, member.Email, member.Phone, member.Role, member.ContractLength)
            End If
        End If
        txtStaffByRole.Clear()
    End Sub

    Private Function GetRole(selectedRole As Integer) As Role
        Dim rol As Role
        'selectedRole = selectedRole.ToLower()
        Select Case selectedRole
            Case 0
                rol = FootballClubManagementSystem.Role.Coach
            Case 1
                rol = FootballClubManagementSystem.Role.AssistantCoach
            Case 3
                rol = FootballClubManagementSystem.Role.Scout
            Case 4
                rol = FootballClubManagementSystem.Role.Doctor
            Case 2
                rol = FootballClubManagementSystem.Role.PhysicalTrainer
            Case Else
                rol = Nothing
        End Select
        Return rol
    End Function

    Private Sub btnStaffGetAll_Click(sender As Object, e As EventArgs) Handles btnStaffGetAll.Click
        Me.dataGridStaff.Rows.Clear()
        For Each techMem As KeyValuePair(Of Integer, TechnicalStaff) In technicalTeam.Staff
            dataGridStaff.Rows.Add(techMem.Value.Name, techMem.Value.Surname, techMem.Value.Phone, techMem.Value.Email, techMem.Value.Role, techMem.Value.YearsLeft)
        Next
    End Sub

    Private Sub btnStaffClear_Click(sender As Object, e As EventArgs) Handles btnStaffClear.Click
        txtStaffByRole.Clear()
    End Sub

    Private Sub cmboxStaffRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxStaffRole.SelectedIndexChanged

    End Sub

    Public Sub FillTechStaffRoles()
        cmboxStaffRoles.Items.Clear()
        For Each techStaff As KeyValuePair(Of Integer, TechnicalStaff) In technicalTeam.Staff
            cmboxStaffRoles.Items.Add(techStaff.Value.Role)
        Next
    End Sub

    Private Sub btnStaffDelete_Click(sender As Object, e As EventArgs) Handles btnStaffDelete.Click
        If (cmboxStaffRoles.SelectedIndex < 0) Then
            MessageBox.Show("Please select the employee you want to remove from the combo-box Roles", "Role to be deleted not selected", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        Else
            Dim result As MsgBoxResult = CType(MessageBox.Show("Are you sure you want to delete the " & cmboxStaffRoles.SelectedItem.ToString & "?", "Delete Technical Staff Member?",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
            If (result = MsgBoxResult.Yes) Then
                Dim staffID As Integer = TechStaffTeam.GenerateID(cmboxStaffRoles.SelectedItem.ToString)
                technicalTeam.Remove(staffID)
                DBTechStaff.RemoveStaff(staffID)
                MessageBox.Show(cmboxStaffRoles.SelectedItem.ToString & " successfully deleted.")
            End If
        End If

        Call Me.FillTechStaffRoles()
    End Sub

    Private Sub cmboxStaffRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxStaffRoles.SelectedIndexChanged
        Dim staffID As Integer = TechStaffTeam.GenerateID(cmboxStaffRoles.SelectedItem.ToString)
        Dim staffMember As TechnicalStaff = technicalTeam.GetStaffMember(staffID)
        txtStaffName.Text = staffMember.Name
        txtStaffSurname.Text = staffMember.Surname
        txtStaffEmail.Text = staffMember.Email
        txtStaffAddress.Text = staffMember.Address
        txtStaffPhone.Text = staffMember.Phone.ToString
        txtStaffSalary.Text = staffMember.MonthlySal.ToString
        cmboxStaffRole.SelectedItem = staffMember.Role.ToString
        dateStaffEnd.Value = staffMember.EndDate
    End Sub

    Private Sub btnStaffModify_Click(sender As Object, e As EventArgs) Handles btnStaffModify.Click
        If (cmboxStaffRoles.SelectedIndex < 0) Then
            MessageBox.Show("Please select the employee you want to modify from the combo-box Roles", "Role to be modified not selected", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        Else
            Dim result As MsgBoxResult = CType(MessageBox.Show("Are you sure you modify details of the " & cmboxStaffRoles.SelectedItem.ToString & "?", "Modify Techical Staff?",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
            If (result = MsgBoxResult.Yes) Then

            End If
        End If
    End Sub

    Private Sub btnStaffCancel_Click(sender As Object, e As EventArgs) Handles btnStaffCancel.Click
        ClearFields.ClearTechStaffFields()
    End Sub

    Public Sub DisableTechStaffFields()
        txtStaffAddress.Enabled = False
        txtStaffEmail.Enabled = False
        txtStaffName.Enabled = False
        txtStaffSurname.Enabled = False
        txtStaffPhone.Enabled = False
        txtStaffSalary.Enabled = False
        cmboxStaffRole.Enabled = False
        dateStaffEnd.Enabled = False
    End Sub

    Public Sub EnableTechStaffFields()
        txtStaffAddress.Enabled = True
        txtStaffEmail.Enabled = True
        txtStaffName.Enabled = True
        txtStaffSurname.Enabled = True
        txtStaffPhone.Enabled = True
        txtStaffSalary.Enabled = True
        cmboxStaffRole.Enabled = True
        dateStaffEnd.Enabled = True
    End Sub

    Dim prevID As Integer = 555
    Private Sub btnStaffPrevious_Click(sender As Object, e As EventArgs)
        ' prevID = technicalTeam.Staff.Keys.Last
        Dim techStaff As New TechnicalStaff
        If (prevID < 111) Then
            MessageBox.Show("Reached the bottom, can't go any further")
        Else
            Me.DisableTechStaffFields()
            techStaff = technicalTeam.GetStaffMember(prevID)
            txtStaffAddress.Text = techStaff.Address
            txtStaffEmail.Text = techStaff.Email
            txtStaffName.Text = techStaff.Name
            txtStaffPhone.Text = techStaff.Phone.ToString
            txtStaffSalary.Text = techStaff.MonthlySal.ToString
            cmboxStaffRole.SelectedItem = techStaff.Role.ToString
            dateStaffEnd.Value = techStaff.EndDate
            prevID -= 111
        End If
    End Sub

    Private Sub btnFanCancel_Click(sender As Object, e As EventArgs) Handles btnFanCancel.Click
        ClearFields.ClearFanFields()
    End Sub

    Private Sub btnFanDelete_Click(sender As Object, e As EventArgs) Handles btnFanDelete.Click
        If (txtFanIDEdit.Text = vbNullString) Then
            MessageBox.Show("Please enter the fan ID to be searched", "Empty entry field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If (membership.Fans.ContainsKey(CInt(txtFanIDEdit.Text))) Then
                Dim result As MsgBoxResult = CType(MessageBox.Show("Are you sure you want to delete this fan?", "Delete Fan?", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
                If (result = MsgBoxResult.Yes) Then

                    membership.Fans.Remove(CInt(txtFanIDEdit.Text))
                    ClearFields.ClearFanFields()
                    MessageBox.Show("Successfully removed from system")
                End If
            Else
                MessageBox.Show("ID: " & txtFanIDEdit.Text & " not found. Please enter valid ID", "Invalid Fan ID Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnJerseyNoAvail_Click(sender As Object, e As EventArgs) Handles btnJerseyNoAvail.Click
        FillFieldsWithData.FillTakenJerseys()
        If (FillFieldsWithData.JerseyAvailable(CInt(txtPlayerJerseyNo.Text)) = False) Then
            MessageBox.Show("Jersey Number: " & txtPlayerJerseyNo.Text & " is already taken. Please choose another one", "Jersey Number Taken",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Jersey Number: " & txtPlayerJerseyNo.Text & " is available", "Jersey Number Available", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnPlayerDelete_Click(sender As Object, e As EventArgs) Handles btnPlayerDelete.Click
        If (cmboxPlayerIDs.SelectedIndex = -1) Then
            MessageBox.Show("Please select the player from the combo-box list", "Player ID Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim result As MsgBoxResult = CType(MessageBox.Show("Are you sure you want to delete player : " & cmboxPlayerIDs.SelectedItem.ToString & " ?",
                                                         "Delete Player?", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
            If (result = MsgBoxResult.Yes) Then
                listPlayers.Players.Remove(CInt(cmboxPlayerIDs.SelectedItem.ToString))
                DBPlayer.RemovePlayer(CInt(cmboxPlayerIDs.SelectedItem.ToString))
                Me.FillPlayerIDs()
                ClearFields.ClearPlayerFields()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Public Sub FillPlayerIDs()
        cmboxPlayerIDs.Items.Clear()
        For Each pID As KeyValuePair(Of Integer, Player) In listPlayers.Players
            cmboxPlayerIDs.Items.Add(pID.Value.ID)
        Next
    End Sub

    Private Sub cmboxPlayerIDs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxPlayerIDs.SelectedIndexChanged
        Dim player As Player = listPlayers.GetPlayer(CInt(cmboxPlayerIDs.SelectedItem))
        txtPlayerName.Text = player.Name
        txtPlayerSurname.Text = player.Surname
        txtPlayerAddress.Text = player.Address
        txtPlayerEmail.Text = player.Email
        cmboxPlayerNation.SelectedItem = player.Nationality
        picboxPlayer.ImageLocation = player.ImagePath
        cmboxPlayerPosition.SelectedItem = player.Position
        txtPlayerSalary.Text = player.MonthlySal.ToString
        txtPlayerValue.Text = player.MarketValue.ToString
        txtPlayerPhone.Text = player.Phone.ToString
        txtPlayerJerseyNo.Text = player.JerseyNum.ToString
        datePlayerDoB.Value = player.BirthDate
        datePlayerEnd.Value = player.EndDate


    End Sub

    Private Sub btnPlayerReport_Click(sender As Object, e As EventArgs) Handles btnPlayerReport.Click
        If (cmboxPlayerIDs.SelectedIndex = -1) Then
            MessageBox.Show("Please select the player from the combo-bos list", "Player ID Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim player As Player
            player = listPlayers.GetPlayer(CInt(cmboxPlayerIDs.SelectedItem))
            PlayerReport.atxtName.Text = ": " & player.Name
            PlayerReport.atxtSurname.Text = ": " & player.Surname
            PlayerReport.atxtAge.Text = ": " & CStr(player.Age)
            PlayerReport.atxtNation.Text = ": " & player.Nationality
            PlayerReport.atxtEmail.Text = ": " & player.Email
            PlayerReport.atxtPhone.Text = ": " & "+27" & CStr(player.Phone)
            PlayerReport.atxtPosition.Text = ": " & player.Position.ToString
            PlayerReport.atxtJersey.Text = ": " & CStr(player.JerseyNum)
            PlayerReport.atxtValue.Text = ": " & player.MarketValue.ToString("C2")
            PlayerReport.atxtSalary.Text = ": " & player.MonthlySal.ToString("C2")
            PlayerReport.atxtContract.Text = ": " & CStr(player.ContractLength)
            PlayerReport.atxtYearsLeft.Text = ": " & CStr(player.YearsLeft)
            PlayerReport.picPlayer.ImageLocation = player.ImagePath
            PlayerReport.ShowDialog()
        End If
    End Sub

    Private Sub btnInjuredAdd_Click(sender As Object, e As EventArgs) Handles btnInjuredUpdate.Click
        If (cmboInjuredIDs.SelectedIndex <> -1) Then
            Dim newInjured As Injured = injuredList.GetPlayer(CInt(cmboInjuredIDs.SelectedItem.ToString))
            newInjured.Diagnosis = txtInjuredDiagnosis.Text
            newInjured.EndDate = dateInjuredEnd.Value
            FillFieldsWithData.FillInjuredDataGrid()
        End If
    End Sub



    Private Sub btnAddtoTransfer_Click(sender As Object, e As EventArgs) Handles btnAddtoTransfer.Click
        If (cmboxPlayerIDs.SelectedIndex = -1) Then
            MessageBox.Show("Please select the player from the combo-box list", "Player ID Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If (playerTranfers.PlayerTransferList.ContainsKey(CInt(cmboxPlayerIDs.SelectedItem.ToString))) Then
                MessageBox.Show("Player with the id" & cmboxPlayerIDs.SelectedItem.ToString & " has already been added to the transfer list", "Player exists in transfer list",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim player As Player = listPlayers.GetPlayer(CInt(cmboxPlayerIDs.SelectedItem))
                playerTranfers.Add(player)
                DBPlayerTransfers.AddPlayerToTransfer(player.ID)
                MessageBox.Show("Successfully Added to Transfer List")
                ClearFields.ClearPlayerFields()
                Me.FillPlayerIDs()
            End If
        End If
    End Sub

    Private Sub rdoScoutList_CheckedChanged(sender As Object, e As EventArgs) Handles rdoScoutList.CheckedChanged
        FillFieldsWithData.FillTransferDataGridScout()
        btnScoutAdd.Show()
        btnScoutRegister.Show()
        btnScoutReport.Show()
        groupScout.Show()

        btnTransferRelease.Hide()
        btnTransferReport.Hide()
        btnTransferRetain.Hide()
        groupTranfer.Hide()
    End Sub

    Public Sub FillTransferDataGridTransfer()
        dataGridTransfers.Rows.Clear()
        dataGridTransfers.Columns.Clear()
        dataGridTransfers.Columns.Add("transName", "Name")
        dataGridTransfers.Columns.Add("transSurname", "Surname")
        dataGridTransfers.Columns.Add("transPosition", "Position")
        dataGridTransfers.Columns.Add("transJerseyNo", "Jersey No")
        dataGridTransfers.Columns.Add("transValue", "Value")
        dataGridTransfers.Columns.Add("transYearsLeft", "Years Left")

        For Each trans As KeyValuePair(Of Integer, Player) In playerTranfers.PlayerTransferList
            dataGridTransfers.Rows.Add(trans.Value.Name, trans.Value.Surname, trans.Value.Position, trans.Value.JerseyNum, trans.Value.MarketValue, trans.Value.YearsLeft)
        Next
    End Sub

    Public Sub FillTransferDataGridScout()
        dataGridTransfers.Rows.Clear()
        dataGridTransfers.Columns.Clear()
        dataGridTransfers.Columns.Add("scoutName", "Name")
        dataGridTransfers.Columns.Add("scoutSurname", "Surname")
        dataGridTransfers.Columns.Add("scoutPosition", "Position")
        dataGridTransfers.Columns.Add("scoutClub", "Club")
        dataGridTransfers.Columns.Add("scoutValue", "Value")
    End Sub

    Private Sub rdoTransferList_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTransferList.CheckedChanged
        FillFieldsWithData.FillTransferDataGridTransfer()
        btnScoutAdd.Hide()
        btnScoutRegister.Hide()
        btnScoutReport.Hide()
        groupScout.Hide()

        btnTransferRelease.Show()
        btnTransferReport.Show()
        btnTransferRetain.Show()
        groupTranfer.Show()
    End Sub

    Private Sub txtFanPhone_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtFanPhone.KeyPress, txtFanPhone.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
        e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtFanIDEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFanIDEdit.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
        e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtStaffPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStaffPhone.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
        e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPlayerPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlayerPhone.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
        e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    'Copy player image file to secure directory and return the string of file path
    Public Function GetPlayerImage(pic As String, pID As Integer) As String
        Dim playerID As String = CStr(pID)
        Dim picFormat As String = pic.Substring(pic.LastIndexOf("."))
        Dim formattedName As String = playerID & picFormat
        Dim strFileName As String = IO.Path.GetFileName(pic)
        'Dim path As String = "C:\Users\Rabalao\Documents\Visual Studio 2012\Projects\FootballClubManagementSystem\FootballClubManagementSystem\PlayerImages"
        Dim path As String = Application.StartupPath & "\PlayerImages"
        Dim strCombinedPathAndFileName = IO.Path.Combine(path, strFileName)
        If (My.Computer.FileSystem.FileExists(strCombinedPathAndFileName)) Then
            'Return "C:\Users\Rabalao\Documents\Visual Studio 2012\Projects\FootballClubManagementSystem\FootballClubManagementSystem\PlayerImages\demo.jpg"
            Return Application.StartupPath & "\PlayerImages\demo.jpg"
        Else
            My.Computer.FileSystem.CopyFile(pic, strCombinedPathAndFileName)
            My.Computer.FileSystem.RenameFile(strCombinedPathAndFileName, formattedName)
            Return path & "\" & formattedName
        End If
    End Function

    Private Sub btnTransferRetain_Click(sender As Object, e As EventArgs) Handles btnTransferRetain.Click
        Dim selRowCount As Integer = dataGridTransfers.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If (selRowCount = 0) Then
            MessageBox.Show("You need to select at least one row")
        ElseIf (selRowCount > 1) Then
            MessageBox.Show("You can't select more than one row")
        Else
            Dim pid As Integer = CInt(dataGridTransfers.SelectedRows.Item(0).Cells(0).Value.ToString)
            Dim playerId As Integer
            For Each pla As KeyValuePair(Of Integer, Player) In playerTranfers.PlayerTransferList
                If (pla.Value.ID = pid) Then
                    playerId = pla.Key
                End If
            Next
            Dim result As MsgBoxResult = CType(MessageBox.Show("Do you want this player retained?", "Retain player?", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
            If (result = MsgBoxResult.Yes) Then
                playerTranfers.Remove(playerId)
                DBPlayerTransfers.RemovePlayerFromTransfer(playerId)
                FillFieldsWithData.FillTransferDataGridTransfer()
                MessageBox.Show("Player : " & playerId & " successfully removed from transfer list")
            End If
        End If
        FillFieldsWithData.FillPlayerIDs()
    End Sub


    Private Sub btnFanClear_Click(sender As Object, e As EventArgs) Handles btnFanClear.Click
        Me.txtFanByID.Clear()
        Me.txtFanByName.Clear()
    End Sub

    Private Sub btnPlayerClear_Click(sender As Object, e As EventArgs) Handles btnPlayerClear.Click
        Me.txtPlayerByJerseyNo.Clear()
        Me.txtPlayerByName.Clear()
        Me.cmboByPosition.SelectedIndex = -1
    End Sub

    Private Sub btnPlayerSearch_Click(sender As Object, e As EventArgs) Handles btnPlayerSearch.Click
        If ((Me.txtPlayerByJerseyNo.Text = vbNullString) And (Me.txtPlayerByName.Text = vbNullString) And (Me.cmboByPosition.SelectedIndex = -1)) Then
            MessageBox.Show("Please enter a name, position or shirt number to search")
        ElseIf ((Me.txtPlayerByJerseyNo.Text <> vbNullString) And (Me.txtPlayerByName.Text = vbNullString) And (Me.cmboByPosition.SelectedIndex = -1)) Then
            FillFieldsWithData.SearchPlayerByJersey(Me.txtPlayerByJerseyNo.Text)
        ElseIf ((Me.txtPlayerByJerseyNo.Text = vbNullString) And (Me.txtPlayerByName.Text <> vbNullString) And (Me.cmboByPosition.SelectedIndex = -1)) Then
            FillFieldsWithData.SearchPlayerByName(Me.txtPlayerByName.Text)
        ElseIf ((Me.txtPlayerByJerseyNo.Text = vbNullString) And (Me.txtPlayerByName.Text = vbNullString) And (Me.cmboByPosition.SelectedIndex = -1)) Then
            FillFieldsWithData.SearchPlayerByPosition(Me.cmboByPosition.SelectedIndex)
        Else
            FillFieldsWithData.SearchPlayerByPosition(Me.cmboByPosition.SelectedIndex)
        End If
    End Sub

    Private Sub btnSponsorSave_Click(sender As Object, e As EventArgs) Handles btnSponsorSave.Click
        Dim newSponsor As Sponsor
        If ((Validator.IsValidEndDate(dateSponsorEnd.Value) = False) Or (Validator.IsValidSponsorTextbox() = False)) Then
            MessageBox.Show("The end date should be greater than the current date" & vbNewLine &
                            "Please fill all text fields", "Invalid Input Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            newSponsor = New Sponsor(sponsorsList.GenerateID(), txtSponsorName.Text, CDec(txtSponsorFee.Text), txtSponsorIndustry.Text, dateSponsorEnd.Value)
            sponsorsList.Add(newSponsor)
            DBSponsor.AddSponsor(newSponsor)
            MessageBox.Show("Sponsor Successfully Saved")
            ClearFields.ClearSponsorFields()
        End If

    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles btnListSponsors.Click
        FillFieldsWithData.FillFinanceDataGridSponsor()
        dataGridFinance.Rows.GetLastRow(DataGridViewElementStates.Selected)
    End Sub

    Private Sub btnListStaffSalaries_Click(sender As Object, e As EventArgs) Handles btnListStaffSalaries.Click
        FillFieldsWithData.FillFinanceDataGridTechStaff()
    End Sub

    Private Sub btnListPlayerSalaries_Click(sender As Object, e As EventArgs) Handles btnListPlayerSalaries.Click
        FillFieldsWithData.FillFinanceDataGridPlayer()
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles btnSaleSave.Click
        Dim ticketSale As MatchDayTicketSale
        Dim merchandise As ClubMerchandiseSale
        If (rdoMerchandise.Checked) Then
            merchandise = New ClubMerchandiseSale(newSales.GenerateMerchandiseSaleID(), Date.Today, CDec(txtSaleAmount.Text))
            newSales.Add(merchandise)
            Me.txtSaleAmount.Text = ""
            Me.dateSale.Value = Date.Now
            MessageBox.Show("Merchandise sale successfully saved")
        ElseIf (rdoTicket.Checked) Then
            ticketSale = New MatchDayTicketSale(newSales.GenerateTicketSaleID(), Date.Today, CDec(txtSaleAmount.Text))
            newSales.Add(ticketSale)
            Me.txtSaleAmount.Text = ""
            Me.dateSale.Value = Date.Now
            MessageBox.Show("Ticket sale successfully saved")
        Else
            MessageBox.Show("You need to check/select the relevent sale type for transaction")
        End If
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles btnSaleCancel.Click
        Me.txtSaleAmount.Text = ""
        Me.dateSale.Value = Date.Now
    End Sub

    Private Sub btnSponsorCancel_Click(sender As Object, e As EventArgs) Handles btnSponsorCancel.Click
        MessageBox.Show(CStr(Date.Today.AddYears(10).Year - Date.Today.Year))
    End Sub

    Private Sub btnScoutAdd_Click(sender As Object, e As EventArgs) Handles btnScoutAdd.Click
        frmAddScoutPlayer.ShowDialog()
    End Sub

    Private Sub btnInjuredReport_Click(sender As Object, e As EventArgs) Handles btnInjuredReport.Click
        FillFieldsWithData.FillReportInjuredDataGrid()
        frmReportList.ShowDialog()
    End Sub


    Private Sub btnPlayerCancel_Click(sender As Object, e As EventArgs) Handles btnPlayerCancel.Click
        ClearFields.ClearPlayerFields()
    End Sub

    Private Sub btnPlayerModify_Click(sender As Object, e As EventArgs) Handles btnPlayerModify.Click
        If (cmboxPlayerIDs.SelectedIndex = -1) Then
            MessageBox.Show("Please select the player ID from the combo-box list", "Player ID Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim result As MsgBoxResult = CType(MessageBox.Show("Are you sure you want modify this player: " & cmboxPlayerIDs.SelectedItem.ToString & " ?", "Modify Player?",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
            If (result = MsgBoxResult.Yes) Then

                ClearFields.ClearPlayerFields()
                FillFieldsWithData.FillPlayerIDs()
            End If
        End If
    End Sub

    Private Sub btnFanModify_Click(sender As Object, e As EventArgs) Handles btnFanModify.Click
        If (txtFanIDEdit.Text = vbNullString) Then
            MessageBox.Show("Please enter the fan ID to be searched", "Empty entry field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If (membership.Fans.ContainsKey(CInt(txtFanIDEdit.Text))) Then
                Dim result As MsgBoxResult = CType(MessageBox.Show("Are you sure you want to modify this fan?", "Modify Fan?", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
                If (result = MsgBoxResult.Yes) Then

                    ClearFields.ClearFanFields()
                    MessageBox.Show("Successfully modified")
                End If
            Else
                MessageBox.Show("ID: " & txtFanIDEdit.Text & " not found. Please enter valid ID", "Invalid Fan ID Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnFanRenew_Click(sender As Object, e As EventArgs) Handles btnFanRenew.Click
        If (txtFanIDEdit.Text = vbNullString) Then
            MessageBox.Show("Please enter the fan ID to be searched", "Empty entry field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If (membership.Fans.ContainsKey(CInt(txtFanIDEdit.Text))) Then
                Dim result As MsgBoxResult = CType(MessageBox.Show("Renew membership for this fan?", "Renew Membership Fan?",
                                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
                If (result = MsgBoxResult.Yes) Then


                    ClearFields.ClearFanFields()
                    MessageBox.Show("Membership Successfully Renewed")
                End If
            Else
                MessageBox.Show("ID: " & txtFanIDEdit.Text & " not found. Please enter valid ID", "Invalid Fan ID Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnPlayerSummaryReport_Click(sender As Object, e As EventArgs) Handles btnPlayerSummaryReport.Click
        FillFieldsWithData.FillReportPlayersDataGrid()
    End Sub

    Private Sub btnInjuredCancel_Click(sender As Object, e As EventArgs) Handles btnInjuredCancel.Click
        ClearFields.ClearInjuredFields()
    End Sub

    Private Sub btnScoutReport_Click(sender As Object, e As EventArgs) Handles btnScoutReport.Click
        FillFieldsWithData.FillReportScoutDataGrid()
    End Sub

    Private Sub btnTransferReport_Click(sender As Object, e As EventArgs) Handles btnTransferReport.Click
        FillFieldsWithData.FillReportTransfersDataGrid()
    End Sub

    Private Sub btnTransferRelease_Click(sender As Object, e As EventArgs) Handles btnTransferRelease.Click
        Dim selRowCount As Integer = dataGridTransfers.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If (selRowCount = 0) Then
            MessageBox.Show("You need to select at least one row")
        ElseIf (selRowCount > 1) Then
            MessageBox.Show("You can't select more than one row")
        Else
            Dim jno As Integer = CInt(dataGridTransfers.SelectedRows.Item(0).Cells(0).Value.ToString)
            Dim playerId As Integer
            For Each pla As KeyValuePair(Of Integer, Player) In playerTranfers.PlayerTransferList
                If (pla.Value.ID = jno) Then
                    playerId = pla.Key
                End If
            Next
            Dim result As MsgBoxResult = CType(MessageBox.Show("Do you want this player released?", "Release player?", MessageBoxButtons.YesNo, MessageBoxIcon.Question), 
                MsgBoxResult)
            If (result = MsgBoxResult.Yes) Then
                playerTranfers.Remove(playerId)
                DBPlayerTransfers.RemovePlayerFromTransfer(playerId)
                listPlayers.Remove(playerId)
                DBPlayer.RemovePlayer(playerId)
                FillFieldsWithData.FillTransferDataGridTransfer()
                MessageBox.Show("Player : " & playerId & " successfully removed from transfer list")
            End If
        End If
        FillFieldsWithData.FillPlayerIDs()
    End Sub

    Private Sub dataGridInjured_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridInjured.CellContentClick
        
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        If (Me.lstFinanceReports.SelectedIndex = -1) Then
            MessageBox.Show("Please select the report to be displayed", "Finance Report Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Select Case Me.lstFinanceReports.SelectedIndex
                Case 0
                    FinanceReports.DiplaySummaryReportEarnings()
                Case 1
                    FinanceReports.ReportOnFans()
                Case 2
                    FinanceReports.ReportOnPlayerSalaryList()
                Case 3
                    FinanceReports.ReportOnStaffSalaryList()
                Case 4
                    FinanceReports.ReportOnSponsorList()
            End Select
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datePanel.Text = Date.Now.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (Me.lstManSummaryReport.SelectedIndex = -1) Then
            MessageBox.Show("Please select the report to be displayed", "Report Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Select Case Me.lstManSummaryReport.SelectedIndex
                Case 0
                    ManInfoReport.PlayerChartReportPosition()
                Case 1
                    FillFieldsWithData.ReportOnFans()
                Case 2
                    FinanceReports.DiplaySummaryReportEarnings()
                Case 3
                    FinanceReports.ReportOnFans()
            End Select
            Me.lstManSummaryReport.SelectedIndex = -1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ManInfoReport.FillManDataGridPlayers()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.lstManListReport.SelectedIndex = -1) Then
            MessageBox.Show("Please select the report to be displayed", "Report Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Select Case Me.lstManListReport.SelectedIndex
                Case 0
                    FillFieldsWithData.FillReportPlayersDataGrid()
                Case 1
                    FillFieldsWithData.FillReportStaffDataGrid()
                Case 2
                    FillFieldsWithData.FillReportInjuredDataGrid()
                    frmReportList.ShowDialog()
                Case 3
                    FillFieldsWithData.FillReportTransfersDataGrid()
                Case 4
                    FillFieldsWithData.FillReportScoutDataGrid()
                Case 5
                    FinanceReports.ReportOnSponsorList()
                Case 6
                    FinanceReports.ReportOnStaffSalaryList()
                Case 7
                    FinanceReports.ReportOnPlayerSalaryList()
            End Select
            Me.lstManListReport.SelectedIndex = -1
        End If
    End Sub


    Private Sub btnStaffSummaryReport_Click(sender As Object, e As EventArgs) Handles btnStaffSummaryReport.Click
        FillFieldsWithData.FillReportStaffDataGrid()
    End Sub

    Private Sub BackUpDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackUpDatabaseToolStripMenuItem.Click
        frmDatabaseBackUp.ShowDialog()
    End Sub

    Private Sub txtStaffPhone_TextChanged(sender As Object, e As EventArgs) Handles txtStaffPhone.TextChanged

    End Sub

    Private Sub txtPlayerPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerPhone.TextChanged

    End Sub

    Private Sub txtPlayerValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlayerValue.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
       e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPlayerSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlayerSalary.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
       e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPlayerJerseyNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlayerJerseyNo.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
       e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
