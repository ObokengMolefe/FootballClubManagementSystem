Public Class FanReport

    Private Sub FanReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.lblDate.Text = "Date: " & CStr(Date.Now)
        'Me.lblTotalNo.Text = "Total Membership: 1 671"

        ''Fill the gender chart
        'Me.ChartFanGender.Series("Gender").Points.AddXY("Male", 1000)
        'Me.ChartFanGender.Series("Gender").Points.AddXY("Female", 671)

        ''Fill the category chart
        'Me.ChartFanCategory.Series("Category").Points.AddXY("Gold", 356)
        'Me.ChartFanCategory.Series("Category").Points.AddXY("Silver", 796)
        'Me.ChartFanCategory.Series("Category").Points.AddXY("Bronze", 496)

        Me.KeyPreview = True
    End Sub

    Private Sub FanReport_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            Me.Close()
        ElseIf e.KeyCode = Keys.P AndAlso e.Modifiers = Keys.Control Then
            PrintForm1.Form.SetAutoScrollMargin(2, 2)
            PrintForm1.Form.Width = Me.Width
            PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
            PrintForm1.Print()
        End If
    End Sub
End Class