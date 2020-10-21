Public Class FinanceReports
    Public Shared Sub ReportOnFans()

        FanReport.lblDate.Text = "Date: " & CStr(Date.Now)
        FanReport.lblTotalNo.Text = "Total Revenues: R20 660.00"

        'Fill the gender chart
        FanReport.ChartFanGender.Series("Gender").Points.Clear()
        FanReport.ChartFanGender.Series("Gender").Points.AddXY("Male R15000", 15000)
        FanReport.ChartFanGender.Series("Gender").Points.AddXY("Female R5660", 5660)

        'Fill the category chart
        FanReport.ChartFanCategory.Series("Category").Points.Clear()
        FanReport.ChartFanCategory.Series("Category").Points.AddXY("Gold", 4500)
        FanReport.ChartFanCategory.Series("Category").Points.AddXY("Silver", 6700)
        FanReport.ChartFanCategory.Series("Category").Points.AddXY("Bronze", 9460)
        FanReport.ShowDialog()
    End Sub

    Public Shared Sub ReportOnPlayerSalaryList()
        frmFinanceSalaryList.lblDate.Text = Date.Now.ToString
        frmFinanceSalaryList.dataGridReportSalary.ClearSelection()
        frmFinanceSalaryList.dataGridReportSalary.ClearSelection()
        frmFinanceSalaryList.ReportListlbl.Text = "Players Salaries"
        frmFinanceSalaryList.lblDate.Text = "Date: " & Date.Today.ToShortDateString
        frmFinanceSalaryList.dataGridReportSalary.Rows.Clear()
        frmFinanceSalaryList.dataGridReportSalary.Columns.Clear()
        Dim total As Decimal = 0
        Dim average As Decimal
        Dim count As Integer = 0
        With frmFinanceSalaryList.dataGridReportSalary.Columns
            .Add("ppName", "Name")
            .Add("ppSurname", "Surname")
            .Add("ppAge", "Age")
            .Add("ppPosition", "Position")
            .Add("ppDuration", "Contract(years)")
            .Add("ppSalary", "Salary")
        End With
        For Each pPlayer As KeyValuePair(Of Integer, Player) In frmFCMS.listPlayers.Players
            total += pPlayer.Value.MonthlySal
            frmFinanceSalaryList.dataGridReportSalary.Rows.Add(pPlayer.Value.Name, pPlayer.Value.Surname, pPlayer.Value.Age, pPlayer.Value.Position,
                                                      pPlayer.Value.ContractLength, pPlayer.Value.MonthlySal.ToString("C2"))
            count += 1
        Next
        average = total / count

        frmFinanceSalaryList.txtTotal.Text = "Salary Total:        " & total.ToString("C2")
        frmFinanceSalaryList.txtAverage.Text = "Salary Average: " & average.ToString("C2")
        frmFinanceSalaryList.ShowDialog()

    End Sub

    Public Shared Sub ReportOnStaffSalaryList()
        frmFinanceSalaryList.lblDate.Text = Date.Now.ToString
        frmFinanceSalaryList.dataGridReportSalary.ClearSelection()
        frmFinanceSalaryList.dataGridReportSalary.ClearSelection()
        frmFinanceSalaryList.ReportListlbl.Text = "Technical Staff Salaries"
        frmFinanceSalaryList.lblDate.Text = "Date: " & Date.Today.ToShortDateString
        frmFinanceSalaryList.dataGridReportSalary.Rows.Clear()
        frmFinanceSalaryList.dataGridReportSalary.Columns.Clear()
        Dim total As Decimal = 0
        Dim average As Decimal
        Dim count As Integer = 0
        With frmFinanceSalaryList.dataGridReportSalary.Columns
            .Add("ppName", "Name")
            .Add("ppSurname", "Surname")
            .Add("ppRole", "Role")
            .Add("ppDuration", "Contract(years)")
            .Add("ppSalary", "Salary")
        End With
        For Each p As KeyValuePair(Of Integer, TechnicalStaff) In frmFCMS.technicalTeam.Staff
            total += p.Value.MonthlySal
            frmFinanceSalaryList.dataGridReportSalary.Rows.Add(p.Value.Name, p.Value.Surname, p.Value.Role,
                                                      p.Value.ContractLength, p.Value.MonthlySal.ToString("C2"))
            count += 1
        Next
        average = total / count

        frmFinanceSalaryList.txtTotal.Text = "Salary Total:        " & total.ToString("C2")
        frmFinanceSalaryList.txtAverage.Text = "Salary Average: " & average.ToString("C2")
        frmFinanceSalaryList.ShowDialog()

    End Sub

    Public Shared Sub ReportOnSponsorList()
        frmFinanceSalaryList.lblDate.Text = Date.Now.ToString
        frmFinanceSalaryList.dataGridReportSalary.ClearSelection()
        frmFinanceSalaryList.dataGridReportSalary.ClearSelection()
        frmFinanceSalaryList.ReportListlbl.Text = "Club Sponsors"
        frmFinanceSalaryList.lblDate.Text = "Date: " & Date.Today.ToShortDateString
        frmFinanceSalaryList.dataGridReportSalary.Rows.Clear()
        frmFinanceSalaryList.dataGridReportSalary.Columns.Clear()
        Dim total As Decimal = 0
        Dim average As Decimal
        Dim count As Integer = 0
        With frmFinanceSalaryList.dataGridReportSalary.Columns
            .Add("ppName", "Name")
            .Add("ppIndustry", "Industry")
            .Add("ppFee", "Sponsorship")
            .Add("ppDuration", "Contract(years)")
            .Add("ppYearsLeft", "Years Left")
        End With
        For Each p As KeyValuePair(Of Integer, Sponsor) In frmFCMS.sponsorsList.Sponsors
            total += p.Value.Sponsorship
            frmFinanceSalaryList.dataGridReportSalary.Rows.Add(p.Value.Name, p.Value.Industry, p.Value.Sponsorship.ToString("C2"), p.Value.ContractDuration,
                                                      p.Value.YearsLeft)
            count += 1
        Next
        average = total / count

        frmFinanceSalaryList.txtTotal.Text = "Sponsorship Total:        " & total.ToString("C2")
        frmFinanceSalaryList.txtAverage.Text = "Sponsorship Average: " & average.ToString("C2")
        frmFinanceSalaryList.ShowDialog()

    End Sub

    Public Shared Sub DiplaySummaryReportEarnings()
        Dim income As Decimal
        Dim expense As Decimal
        Dim profit As Decimal

        Dim spons As Decimal = 650000
        Dim fan As Decimal = 16000
        Dim match As Decimal = 23000
        Dim merch As Decimal = 13000

        Dim teamSal As Decimal = 350000
        Dim staffSal As Decimal = 91500
        Dim fanCost As Decimal = 7000
        Dim training As Decimal = 5000
        income = spons + fan + match + merch
        expense = teamSal + staffSal + fanCost + training
        profit = income - expense
        With frmReportEarnings
            .txtSponsor.Text = spons.ToString("C2")
            .txtFanClub.Text = fan.ToString("C2")
            .txtMatch.Text = match.ToString("C2")
            .txtMerchSales.Text = merch.ToString("C2")
            .txtTeamSal.Text = teamSal.ToString("C2")
            .txtStaffSal.Text = staffSal.ToString("C2")
            .txtFanCosts.Text = fanCost.ToString("C2")
            .txtTraining.Text = training.ToString("C2")
            .txtIncome.Text = income.ToString("C2")
            .txtExpense.Text = expense.ToString("C2")
            .txtProfit.Text = profit.ToString("C2")
            .txtDate.Text &= Date.Now.ToString
        End With
        frmReportEarnings.ShowDialog()
    End Sub
End Class
