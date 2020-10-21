Public Class frmManReportChart

    Private Sub frmManReportChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ManReportChart_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Space Then
            Me.Close()
        ElseIf e.KeyCode = Keys.P AndAlso e.Modifiers = Keys.Control Then
            PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New Printing.Margins(10, 10, 30, 30)
            ' PrintForm1.Form.Width = Me.Width
            PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
            PrintForm1.Print()
        End If
    End Sub
End Class