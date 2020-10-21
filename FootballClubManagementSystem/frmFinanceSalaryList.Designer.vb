<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinanceSalaryList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinanceSalaryList))
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dataGridReportSalary = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtAverage = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.ReportListlbl = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.dataGridReportSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(408, 144)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 15)
        Me.lblDate.TabIndex = 19
        Me.lblDate.Text = "Date:"
        '
        'dataGridReportSalary
        '
        Me.dataGridReportSalary.AllowUserToAddRows = False
        Me.dataGridReportSalary.AllowUserToDeleteRows = False
        Me.dataGridReportSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridReportSalary.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dataGridReportSalary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridReportSalary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataGridReportSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridReportSalary.GridColor = System.Drawing.SystemColors.Window
        Me.dataGridReportSalary.Location = New System.Drawing.Point(20, 175)
        Me.dataGridReportSalary.Name = "dataGridReportSalary"
        Me.dataGridReportSalary.ReadOnly = True
        Me.dataGridReportSalary.RowHeadersVisible = False
        Me.dataGridReportSalary.RowTemplate.Height = 28
        Me.dataGridReportSalary.Size = New System.Drawing.Size(595, 555)
        Me.dataGridReportSalary.TabIndex = 18
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox2.Image = Global.FootballClubManagementSystem.My.Resources.Resources.emblem_Setshaba_United_FC
        Me.PictureBox2.Location = New System.Drawing.Point(252, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(122, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'txtAverage
        '
        Me.txtAverage.AutoSize = True
        Me.txtAverage.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAverage.Location = New System.Drawing.Point(31, 144)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(38, 15)
        Me.txtAverage.TabIndex = 20
        Me.txtAverage.Text = "Date:"
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(31, 117)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(38, 15)
        Me.txtTotal.TabIndex = 21
        Me.txtTotal.Text = "Date:"
        '
        'ReportListlbl
        '
        Me.ReportListlbl.AutoSize = True
        Me.ReportListlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportListlbl.Location = New System.Drawing.Point(239, 88)
        Me.ReportListlbl.Name = "ReportListlbl"
        Me.ReportListlbl.Size = New System.Drawing.Size(57, 18)
        Me.ReportListlbl.TabIndex = 22
        Me.ReportListlbl.Text = "Label1"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmFinanceSalaryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(634, 742)
        Me.Controls.Add(Me.ReportListlbl)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dataGridReportSalary)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFinanceSalaryList"
        Me.Text = "Finance Salary List"
        CType(Me.dataGridReportSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dataGridReportSalary As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtAverage As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents ReportListlbl As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
