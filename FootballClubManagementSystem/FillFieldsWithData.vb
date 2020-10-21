Imports System.String

Public Class FillFieldsWithData

    Public Shared ShirtNums As New ArrayList
#Region "Search player by name, position or jersey number"
    Public Shared Sub SearchPlayerByName(name As String)
        Dim numFound As Integer = 0
        frmFCMS.dgvPlayer.Rows.Clear()
        For Each p As KeyValuePair(Of Integer, Player) In frmFCMS.listPlayers.Players
            If (p.Value.Name.ToLower = name.ToLower) Then
                numFound += 1
                frmFCMS.dgvPlayer.Rows.Add(p.Value.Name, p.Value.Surname, p.Value.Age, p.Value.Nationality, p.Value.JerseyNum, p.Value.Position,
                                           p.Value.MarketValue.ToString("C2"), p.Value.MonthlySal.ToString("C2"), p.Value.YearsLeft)
            End If
        Next
        If (numFound = 0) Then
            MessageBox.Show("Player Not Found. Make sure spelling is correct", "Search Player", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Shared Sub SearchPlayerByPosition(pos As Integer)
        Dim numFound As Integer = 0
        frmFCMS.dgvPlayer.Rows.Clear()
        For Each p As KeyValuePair(Of Integer, Player) In frmFCMS.listPlayers.Players
            If (p.Value.Position = CType(pos, Position)) Then
                numFound += 1
                frmFCMS.dgvPlayer.Rows.Add(p.Value.Name, p.Value.Surname, p.Value.Age, p.Value.Nationality, p.Value.JerseyNum, p.Value.Position,
                                           p.Value.MarketValue.ToString("C2"), p.Value.MonthlySal.ToString("C2"), p.Value.YearsLeft)
            End If
        Next
        If (numFound = 0) Then
            MessageBox.Show("Player Not Found.", "Search Player", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Shared Sub SearchPlayerByJersey(jNum As String)
        Dim numFound As Integer = 0
        frmFCMS.dgvPlayer.Rows.Clear()
        For Each p As KeyValuePair(Of Integer, Player) In frmFCMS.listPlayers.Players
            If (p.Value.JerseyNum = CInt(jNum)) Then
                numFound += 1
                frmFCMS.dgvPlayer.Rows.Add(p.Value.Name, p.Value.Surname, p.Value.Age, p.Value.Nationality, p.Value.JerseyNum, p.Value.Position,
                                           p.Value.MarketValue.ToString("C2"), p.Value.MonthlySal.ToString("C2"), p.Value.YearsLeft)
            End If
        Next
        If (numFound = 0) Then
            MessageBox.Show("Player Not Found...", "Search Player", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region

#Region "Search Fan By Name or ID"
    Public Shared Sub SearchFanByName(name As String)
        Dim numFound As Integer = 0
        frmFCMS.dgvPlayer.Rows.Clear()
        For Each p As KeyValuePair(Of Integer, Fan) In frmFCMS.membership.Fans
            If (p.Value.Name.ToLower = name.ToLower) Then
                numFound += 1
                frmFCMS.dataGridFan.Rows.Add(p.Value.Name, p.Value.Surname, p.Value.Phone, p.Value.Gender, p.Value.Category, p.Value.Expired)

            End If
        Next
        If (numFound = 0) Then
            MessageBox.Show("Fan Not Found. Please make sure spelling is correct", "Search Player", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Shared Sub SearchFanByID(id As Integer)
        Dim numFound As Integer = 0
        frmFCMS.dgvPlayer.Rows.Clear()
        For Each p As KeyValuePair(Of Integer, Fan) In frmFCMS.membership.Fans
            If (p.Value.ID = id) Then
                numFound += 1
                frmFCMS.dataGridFan.Rows.Add(p.Value.Name, p.Value.Surname, p.Value.Phone, p.Value.Gender, p.Value.Category, p.Value.Expired)

            End If
        Next
        If (numFound = 0) Then
            MessageBox.Show("Fan Not Found.", "Search Player", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region

    Public Shared Sub FillTakenJerseys()
        ShirtNums.Clear()
        For Each shirt As KeyValuePair(Of Integer, Player) In frmFCMS.listPlayers.Players
            ShirtNums.Add(CInt(shirt.Value.JerseyNum))
        Next
    End Sub

    Public Shared Function JerseyAvailable(num As Integer) As Boolean
        FillFieldsWithData.FillTakenJerseys()
        Dim result As Boolean = True
        If (ShirtNums.Contains(num)) Then
            result = False
        End If
        Return result
    End Function

    Public Shared Sub FillInjuredDataGrid()
        Dim player As Player
        Dim pName As String
        Dim pSurname As String
        Dim pShirtNo As Integer
        Dim pPosition As String
        frmFCMS.dataGridInjured.Rows.Clear()
        For Each inj As KeyValuePair(Of Integer, Injured) In frmFCMS.injuredList.InjuredPlayers
            player = frmFCMS.listPlayers.GetPlayer(inj.Value.PlayerID)
            pName = player.Name
            pSurname = player.Surname
            pShirtNo = player.JerseyNum
            pPosition = player.Position.ToString
            frmFCMS.dataGridInjured.Rows.Add(player.ID, pName, pSurname, pPosition, inj.Value.Diagnosis, Math.Round(inj.Value.Duration / 7))
        Next
    End Sub

    Public Shared Sub FillReportInjuredDataGrid()
        frmReportList.dataGridReportList.ClearSelection()
        Dim player As Player
        Dim pName As String
        Dim pSurname As String
        Dim pShirtNo As Integer
        Dim pPosition As String
        frmReportList.ReportListlbl.Text = "Player Injury List"
        frmReportList.lblDate.Text = "Date: " & Date.Today.ToShortDateString
        frmReportList.dataGridReportList.Rows.Clear()
        frmReportList.dataGridReportList.Columns.Clear()
        With frmReportList.dataGridReportList.Columns
            .Add("ipName", "Name")
            .Add("ipSurname", "Surname")
            .Add("ipjersey", "Jersey No")
            .Add("ipPosition", "Position")
            .Add("ipDiagnosis", "Diagnosis")
            .Add("ipDuration", "Duration(weeks)")
        End With
        For Each inj As KeyValuePair(Of Integer, Injured) In frmFCMS.injuredList.InjuredPlayers
            player = frmFCMS.listPlayers.GetPlayer(inj.Value.PlayerID)
            pName = player.Name
            pSurname = player.Surname
            pShirtNo = player.JerseyNum
            pPosition = player.Position.ToString
            frmReportList.dataGridReportList.Rows.Add(pName, pSurname, pShirtNo, pPosition, inj.Value.Diagnosis, Math.Round(inj.Value.Duration / 7))
            frmReportList.dataGridReportList.ClearSelection()
        Next
        frmReportList.dataGridReportList.ClearSelection()
    End Sub

    Public Shared Sub FillReportStaffDataGrid()
        frmReportList.dataGridReportList.ClearSelection()
        frmReportList.dataGridReportList.ClearSelection()
        frmReportList.ReportListlbl.Text = "Technical Staff"
        frmReportList.lblDate.Text = "Date: " & Date.Today.ToShortDateString
        frmReportList.dataGridReportList.Rows.Clear()
        frmReportList.dataGridReportList.Columns.Clear()
        With frmReportList.dataGridReportList.Columns
            .Add("spName", "Name")
            .Add("spSurname", "Surname")
            .Add("spPhone", "Phone")
            .Add("spEmail", "Email")
            .Add("spRole", "Role")
            .Add("spContract", "Contract(yrs)")
        End With
        For Each p As KeyValuePair(Of Integer, TechnicalStaff) In frmFCMS.technicalTeam.Staff
            frmReportList.dataGridReportList.Rows.Add(p.Value.Name, p.Value.Surname, "+27" & p.Value.Phone, p.Value.Email, p.Value.Role,p.Value.ContractLength)
        Next
        frmReportList.ShowDialog()
    End Sub

    Public Shared Sub FillReportScoutDataGrid()
        frmReportList.dataGridReportList.ClearSelection()
        frmReportList.dataGridReportList.ClearSelection()
        frmReportList.ReportListlbl.Text = "Scouted Players"
        frmReportList.lblDate.Text = "Date: " & Date.Today.ToShortDateString
        frmReportList.dataGridReportList.Rows.Clear()
        frmReportList.dataGridReportList.Columns.Clear()
        With frmReportList.dataGridReportList.Columns
            .Add("spName", "Name")
            .Add("spSurname", "Surname")
            .Add("spAge", "Age")
            .Add("spPosition", "Position")
            .Add("spValue", "Value")
            .Add("spClub", "Club")
        End With
        For Each pPlayer As KeyValuePair(Of Integer, ScoutedPlayer) In frmFCMS.scoutsList.Players
            frmReportList.dataGridReportList.Rows.Add(pPlayer.Value.Name, pPlayer.Value.Surname, pPlayer.Value.Age, pPlayer.Value.Position, pPlayer.Value.MarketValue.ToString("C2"),
                                                      pPlayer.Value.Club)
            frmReportList.dataGridReportList.ClearSelection()
        Next
        frmReportList.ShowDialog()
    End Sub

    Public Shared Sub FillReportPlayersDataGrid()
        frmReportList.dataGridReportList.ClearSelection()
        frmReportList.dataGridReportList.ClearSelection()
        frmReportList.ReportListlbl.Text = "Registered Players"
        frmReportList.lblDate.Text = "Date: " & Date.Today.ToShortDateString
        frmReportList.dataGridReportList.Rows.Clear()
        frmReportList.dataGridReportList.Columns.Clear()
        With frmReportList.dataGridReportList.Columns
            .Add("ppName", "Name")
            .Add("ppSurname", "Surname")
            .Add("ppAge", "Age")
            .Add("ppjersey", "Jersey No")
            .Add("ppPosition", "Position")
            .Add("ppDuration", "Contract(years)")
        End With
        For Each pPlayer As KeyValuePair(Of Integer, Player) In frmFCMS.listPlayers.Players
            frmReportList.dataGridReportList.Rows.Add(pPlayer.Value.Name, pPlayer.Value.Surname, pPlayer.Value.Age, pPlayer.Value.JerseyNum, pPlayer.Value.Position,
                                                      pPlayer.Value.ContractLength)
            frmReportList.dataGridReportList.ClearSelection()
        Next
        frmReportList.ShowDialog()
    End Sub

    Public Shared Sub FillReportTransfersDataGrid()
        frmReportList.dataGridReportList.ClearSelection()
        Dim player As Player
        Dim pName As String
        Dim pSurname As String
        Dim pShirtNo As Integer
        Dim pPosition As String
        frmReportList.ReportListlbl.Text = "Player Transfer List"
        frmReportList.lblDate.Text = "Date: " & Date.Today.ToShortDateString
        frmReportList.dataGridReportList.Rows.Clear()
        frmReportList.dataGridReportList.Columns.Clear()
        With frmReportList.dataGridReportList.Columns
            .Add("tpName", "Name")
            .Add("tpSurname", "Surname")
            .Add("tpPosition", "Position")
            .Add("tpValue", "Value")
            .Add("tpDuration", "Duration(years)")
            .Add("tpYearsLeft", "Years Left")
        End With
        For Each trans As KeyValuePair(Of Integer, Player) In frmFCMS.playerTranfers.PlayerTransferList
            player = frmFCMS.listPlayers.GetPlayer(trans.Value.ID)
            pName = player.Name
            pSurname = player.Surname
            pShirtNo = player.JerseyNum
            pPosition = player.Position.ToString
            frmReportList.dataGridReportList.Rows.Add(pName, pSurname, pPosition, trans.Value.MarketValue.ToString("C2"), trans.Value.ContractLength,
                                                      trans.Value.YearsLeft)
            frmReportList.dataGridReportList.ClearSelection()
        Next
        frmReportList.ShowDialog()
    End Sub

    Public Shared Sub FillTransferDataGridTransfer()
        frmFCMS.dataGridTransfers.Rows.Clear()
        frmFCMS.dataGridTransfers.Columns.Clear()
        frmFCMS.dataGridTransfers.Columns.Add("transferId", "Player ID")
        frmFCMS.dataGridTransfers.Columns.Add("transName", "Name")
        frmFCMS.dataGridTransfers.Columns.Add("transSurname", "Surname")
        frmFCMS.dataGridTransfers.Columns.Add("transPosition", "Position")
        frmFCMS.dataGridTransfers.Columns.Add("transValue", "Value")
        frmFCMS.dataGridTransfers.Columns.Add("transYearsLeft", "Years Left")

        For Each trans As KeyValuePair(Of Integer, Player) In frmFCMS.playerTranfers.PlayerTransferList
            frmFCMS.dataGridTransfers.Rows.Add(trans.Value.ID, trans.Value.Name, trans.Value.Surname, trans.Value.Position, trans.Value.MarketValue.ToString("C2"),
                                               trans.Value.YearsLeft)
        Next
        frmFCMS.dataGridTransfers.ClearSelection()
    End Sub

    Public Shared Sub FillFinanceDataGridSponsor()
        frmFCMS.dataGridFinance.Rows.Clear()
        frmFCMS.dataGridFinance.Columns.Clear()
        frmFCMS.dataGridFinance.Columns.Add("sponsID", "ID")
        frmFCMS.dataGridFinance.Columns.Add("sponsName", "Name")
        frmFCMS.dataGridFinance.Columns.Add("sponsFee", "Sponsorship")
        frmFCMS.dataGridFinance.Columns.Add("sponsIndustry", "Industry")
        frmFCMS.dataGridFinance.Columns.Add("sponsDuration", "Contract Duration")
        frmFCMS.dataGridFinance.Columns.Add("sponsYearsLeft", "Years Left")

        For Each spons As KeyValuePair(Of Integer, Sponsor) In frmFCMS.sponsorsList.Sponsors
            frmFCMS.dataGridFinance.Rows.Add(spons.Value.SponsorID, spons.Value.Name, spons.Value.Industry, spons.Value.Sponsorship.ToString("C2"), spons.Value.ContractDuration, spons.Value.YearsLeft)
        Next
    End Sub

    Public Shared Sub FillFinanceDataGridPlayer()
        frmFCMS.dataGridFinance.Rows.Clear()
        frmFCMS.dataGridFinance.Columns.Clear()
        frmFCMS.dataGridFinance.Columns.Add("playerName", "Name")
        frmFCMS.dataGridFinance.Columns.Add("playerSurname", "Surname")
        frmFCMS.dataGridFinance.Columns.Add("playerJersey", "Jersey No")
        frmFCMS.dataGridFinance.Columns.Add("playerValue", "Market Value")
        frmFCMS.dataGridFinance.Columns.Add("playerSalary", "Salary")

        For Each player As KeyValuePair(Of Integer, Player) In frmFCMS.listPlayers.Players
            frmFCMS.dataGridFinance.Rows.Add(player.Value.Name, player.Value.Surname, player.Value.JerseyNum.ToString,
                                             player.Value.MonthlySal.ToString("C2"), player.Value.MarketValue.ToString("C2"))
        Next
    End Sub

    Public Shared Sub FillFinanceDataGridTechStaff()
        frmFCMS.dataGridFinance.Rows.Clear()
        frmFCMS.dataGridFinance.Columns.Clear()
        frmFCMS.dataGridFinance.Columns.Add("staffName", "Name")
        frmFCMS.dataGridFinance.Columns.Add("staffSurname", "Surname")
        frmFCMS.dataGridFinance.Columns.Add("staffRole", "Role")
        frmFCMS.dataGridFinance.Columns.Add("staffSalary", "Salary")

        For Each staff As KeyValuePair(Of Integer, TechnicalStaff) In frmFCMS.technicalTeam.Staff
            frmFCMS.dataGridFinance.Rows.Add(staff.Value.Name, staff.Value.Surname, staff.Value.Role, staff.Value.MonthlySal.ToString("C2"))
        Next
    End Sub

    Public Shared Sub FillTransferDataGridScout()
        frmFCMS.dataGridTransfers.Rows.Clear()
        frmFCMS.dataGridTransfers.Columns.Clear()
        frmFCMS.dataGridTransfers.Columns.Add("scoutID", "ID")
        frmFCMS.dataGridTransfers.Columns.Add("scoutName", "Name")
        frmFCMS.dataGridTransfers.Columns.Add("scoutSurname", "Surname")
        frmFCMS.dataGridTransfers.Columns.Add("scoutPosition", "Position")
        frmFCMS.dataGridTransfers.Columns.Add("scoutClub", "Club")
        frmFCMS.dataGridTransfers.Columns.Add("scoutValue", "Value")

        For Each player As KeyValuePair(Of Integer, ScoutedPlayer) In frmFCMS.scoutsList.Players
            frmFCMS.dataGridTransfers.Rows.Add(player.Value.PlayerID, player.Value.Name, player.Value.Surname, player.Value.Position.ToString,
                                             player.Value.Club, player.Value.MarketValue.ToString("C2"))
        Next
        frmFCMS.dataGridTransfers.ClearSelection()
    End Sub

    Public Shared Sub FillPlayerIDs()
        frmFCMS.cmboxPlayerIDs.Items.Clear()
        For Each pID As KeyValuePair(Of Integer, Player) In frmFCMS.listPlayers.Players
            frmFCMS.cmboxPlayerIDs.Items.Add(pID.Value.ID)
        Next
    End Sub

    Public Shared Sub FillInjuredIDs()
        frmFCMS.cmboInjuredIDs.Items.Clear()
        For Each pID As KeyValuePair(Of Integer, Injured) In frmFCMS.injuredList.InjuredPlayers
            frmFCMS.cmboxPlayerIDs.Items.Add(pID.Value.PlayerID)
        Next
    End Sub

    Public Shared Sub FillTechStaffRoles()
        frmFCMS.cmboxStaffRoles.Items.Clear()
        For Each techStaff As KeyValuePair(Of Integer, TechnicalStaff) In frmFCMS.technicalTeam.Staff
            frmFCMS.cmboxStaffRoles.Items.Add(techStaff.Value.Role)
        Next
    End Sub

    Public Shared Sub FillUsersdataGrid()
        frmAddUser.dataGridUsers.Rows.Clear()
        ' frmAddUser.dataGridUsers.Rows.Add("usr.Username", " usr.Password", "usr.Department.ToString", "usr.Name.ToUpper.Substring(0, 1) & "" & usr.Surname")
        For Each usr As User In frmLogin.book.Users
            frmAddUser.dataGridUsers.Rows.Add(usr.Username, usr.Password, usr.Department.ToString, usr.Name.ToUpper.Substring(0, 1) & " " & usr.Surname)
        Next
    End Sub

    Public Shared Sub ReportOnFans()
        Dim male As Integer = 0
        Dim female As Integer = 0
        Dim gold As Integer = 0
        Dim silver As Integer = 0
        Dim bronze As Integer = 0

        Call GetNumbers.GetFanNumsGenderCat(male, female, gold, silver, bronze)
        FanReport.lblDate.Text = "Date: " & CStr(Date.Now)
        FanReport.lblTotalNo.Text = ""

        'Fill the gender chart
        FanReport.ChartFanGender.Series("Gender").Points.Clear()
        FanReport.ChartFanGender.Series("Gender").Points.AddXY("Male", male)
        FanReport.ChartFanGender.Series("Gender").Points.AddXY("Female", female)

        'Fill the category chart
        FanReport.ChartFanCategory.Series("Category").Points.Clear()
        FanReport.ChartFanCategory.Series("Category").Points.AddXY("Gold", gold)
        FanReport.ChartFanCategory.Series("Category").Points.AddXY("Silver", silver)
        FanReport.ChartFanCategory.Series("Category").Points.AddXY("Bronze", bronze)
        FanReport.ShowDialog()
    End Sub
End Class
