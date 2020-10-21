Public Class frmFinanceSalaryList

    Private Sub frmFinanceSalaryList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        If e.KeyCode = Keys.C Then
            Me.dataGridReportSalary.ClearSelection()
        End If
    End Sub
End Class