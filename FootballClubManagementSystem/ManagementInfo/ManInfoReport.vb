Imports System.Windows.Forms.DataVisualization.Charting.Chart

Public Class ManInfoReport
#Region "Chart Reports on Club Fans"
    Public Shared Sub FansChartReportGender()
        Dim fanGender As New System.Windows.Forms.DataVisualization.Charting.Series
        fanGender.Name = "FanGender"
        fanGender.LegendText = "Num Fans on Gender"
        fanGender.ChartType = DataVisualization.Charting.SeriesChartType.Pie

        frmManReportChart.lblDate.Text = "Date: " & Date.Now.ToString
        frmManReportChart.lblTitle.Text = "Summary Report on Club Fan Membership"
        frmManReportChart.Chart1.Series.Clear()
        frmManReportChart.Chart1.Series.Add(fanGender)

        With frmManReportChart.Chart1.Series("FanGender")
            .Points.AddXY("Male", 150)
            .Points.AddXY("Female", 100)
        End With
        FansChartReportAge()
        FansChartReportCategory()
        FansChartReportRevenue()
        frmManReportChart.ShowDialog()
    End Sub

    Public Shared Sub FansChartReportAge()
        Dim fanAge As New System.Windows.Forms.DataVisualization.Charting.Series
        fanAge.Name = "FanAge"
        fanAge.LegendText = "Num Fans on Age"
        ' fanAge.ChartType = DataVisualization.Charting.SeriesChartType.Bar

        frmManReportChart.Chart2.Series.Clear()
        frmManReportChart.Chart2.Series.Add(fanAge)

        With frmManReportChart.Chart2.Series("FanAge")
            .Points.AddXY("18-25", 80)
            .Points.AddXY("26-30", 50)
            .Points.AddXY("31-35", 37)
            .Points.AddXY("36+", 20)
        End With
    End Sub

    Public Shared Sub FansChartReportCategory()
        Dim fanCat As New System.Windows.Forms.DataVisualization.Charting.Series
        Dim fanMale As New System.Windows.Forms.DataVisualization.Charting.Series
        Dim fanFemale As New System.Windows.Forms.DataVisualization.Charting.Series
        fanCat.Name = "FanCat"
        fanCat.LegendText = "Fan Category"
        ''
        fanMale.Name = "FanMale"
        fanMale.LegendText = "Males"
        ''
        fanFemale.Name = "FanFemale"
        fanFemale.LegendText = "Females"

        frmManReportChart.Chart3.Series.Clear()
        frmManReportChart.Chart3.Series.Add(fanCat)
        frmManReportChart.Chart3.Series.Add(fanFemale)
        frmManReportChart.Chart3.Series.Add(fanMale)

        With frmManReportChart.Chart3.Series("FanCat")
            .Points.AddXY("Gold", 80)
            .Points.AddXY("Silver", 50)
            .Points.AddXY("Bronze", 30)
        End With

        With frmManReportChart.Chart3.Series("FanMale")
            .Points.AddXY("Gold", 45)
            .Points.AddXY("Silver", 30)
            .Points.AddXY("Bronze", 15)
        End With

        With frmManReportChart.Chart3.Series("FanFemale")
            .Points.AddXY("Gold", 35)
            .Points.AddXY("Silver", 20)
            .Points.AddXY("Bronze", 15)
        End With

        '  frmManReportChart.ShowDialog()
    End Sub

    Public Shared Sub FansChartReportRevenue()
        Dim fanRevenue As New System.Windows.Forms.DataVisualization.Charting.Series
        Dim fanRevenuePrev As New System.Windows.Forms.DataVisualization.Charting.Series
        fanRevenue.Name = "FanRevenue"
        fanRevenue.LegendText = "Current Revenues"

        fanRevenuePrev.Name = "FanRevenuePrev"
        fanRevenuePrev.LegendText = "Last Year Revenues"
        ' fanRevenue.ChartType = DataVisualization.Charting.SeriesChartType.Renko

        frmManReportChart.Chart4.Series.Clear()
        frmManReportChart.Chart4.Series.Add(fanRevenuePrev)
        frmManReportChart.Chart4.Series.Add(fanRevenue)

        With frmManReportChart.Chart4.Series("FanRevenuePrev")
            .Points.AddXY("Gold", 5600)
            .Points.AddXY("Silver", 3500)
            .Points.AddXY("Bronze", 2700)
        End With

        With frmManReportChart.Chart4.Series("FanRevenue")
            .Points.AddXY("Gold", 9600)
            .Points.AddXY("Silver", 5500)
            .Points.AddXY("Bronze", 3000)
        End With
        '  frmManReportChart.ShowDialog()
    End Sub
#End Region

#Region "Fill Data Grid With Players"
    Public Shared Sub FillManDataGridPlayers()
        frmFCMS.dataGridMan.Rows.Clear()
        frmFCMS.dataGridMan.Columns.Clear()
        With frmFCMS.dataGridMan.Columns
            .Add("ppName", "Name")
            .Add("ppSurname", "Surname")
            .Add("ppAge", "Age")
            .Add("ppjersey", "Jersey No")
            .Add("ppPosition", "Position")
            .Add("ppSalary", "Salary")
            .Add("ppValue", "Value")
            .Add("ppDuration", "Contract(years)")
            .Add("ppYearsLeft", "YearsLeft")
        End With
        For Each pPlayer As KeyValuePair(Of Integer, Player) In frmFCMS.listPlayers.Players
            frmFCMS.dataGridMan.Rows.Add(pPlayer.Value.Name, pPlayer.Value.Surname, pPlayer.Value.Age, pPlayer.Value.JerseyNum, pPlayer.Value.Position,
                                                      pPlayer.Value.MonthlySal.ToString("C2"), pPlayer.Value.MarketValue.ToString("C2"),
                                                      pPlayer.Value.ContractLength, pPlayer.Value.YearsLeft)
        Next
    End Sub
#End Region

#Region "Chart Report on Players"
    Public Shared Sub PlayerChartReportPosition()
        Dim playerPos As New System.Windows.Forms.DataVisualization.Charting.Series
        playerPos.Name = "playerPos"
        playerPos.LegendText = "Num Players on Position"
        playerPos.Palette = DataVisualization.Charting.ChartColorPalette.Berry

        frmManReportChart.lblDate.Text = "Date: " & Date.Now.ToString
        frmManReportChart.lblTitle.Text = "Summary Report on Club Players"
        frmManReportChart.Chart1.Series.Clear()
        frmManReportChart.Chart1.Series.Add(playerPos)

        With frmManReportChart.Chart1.Series("playerPos")
            .Points.AddXY("Striker", 5)
            .Points.AddXY("Midfielder", 8)
            .Points.AddXY("Defender", 6)
            .Points.AddXY("GoalKeeper", 3)
        End With
        PlayerChartReportContract()
        PlayerChartReportSalary()
        PlayerChartReportAge()
        frmManReportChart.ShowDialog()
    End Sub

    Public Shared Sub PlayerChartReportAge()
        Dim playerAge As New System.Windows.Forms.DataVisualization.Charting.Series
        playerAge.Name = "playerAge"
        playerAge.LegendText = "Num Players on Age"
        playerAge.Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel

        frmManReportChart.Chart2.Series.Clear()
        frmManReportChart.Chart2.Series.Add(playerAge)

        With frmManReportChart.Chart2.Series("playerAge")
            .Points.AddXY("18-24", 5)
            .Points.AddXY("25-29", 8)
            .Points.AddXY("30+", 3)
        End With

        '  frmManReportChart.ShowDialog()
    End Sub

    Public Shared Sub PlayerChartReportSalary()
        Dim playerSal As New System.Windows.Forms.DataVisualization.Charting.Series

        playerSal.Name = "playerSal"
        playerSal.LegendText = "Players' Salaries"
        playerSal.Palette = DataVisualization.Charting.ChartColorPalette.Fire
        ''
        frmManReportChart.Chart3.Series.Clear()
        frmManReportChart.Chart3.Series.Add(playerSal)

        With frmManReportChart.Chart3.Series("playerSal")
            .Points.AddXY("Min", 3000)
            .Points.AddXY("Average", 9500)
            .Points.AddXY("Max", 25000)
        End With

        '  frmManReportChart.ShowDialog()
    End Sub

    Public Shared Sub PlayerChartReportContract()
        Dim playerContract As New System.Windows.Forms.DataVisualization.Charting.Series
        playerContract.Name = "playerContract"
        playerContract.LegendText = "Player Contract Remaining Years"
        playerContract.Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

        frmManReportChart.Chart4.Series.Clear()
        frmManReportChart.Chart4.Series.Add(playerContract)

        With frmManReportChart.Chart4.Series("playerContract")
            .Points.AddXY("1 Yr", 6)
            .Points.AddXY("2 Yrs", 5)
            .Points.AddXY("3 Yrs", 3)
            .Points.AddXY("4 Yrs +", 4)
        End With
    End Sub

#End Region
End Class
