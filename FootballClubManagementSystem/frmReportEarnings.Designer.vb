<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportEarnings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportEarnings))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMerchSales = New System.Windows.Forms.Label()
        Me.txtMatch = New System.Windows.Forms.Label()
        Me.txtFanClub = New System.Windows.Forms.Label()
        Me.txtSponsor = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtTraining = New System.Windows.Forms.Label()
        Me.txtFanCosts = New System.Windows.Forms.Label()
        Me.txtStaffSal = New System.Windows.Forms.Label()
        Me.txtTeamSal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtProfit = New System.Windows.Forms.Label()
        Me.txtExpense = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(224, 72)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(274, 23)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Expected Earnings Report"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FootballClubManagementSystem.My.Resources.Resources.emblem_Setshaba_United_FC
        Me.PictureBox1.Location = New System.Drawing.Point(301, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(450, 116)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(40, 16)
        Me.txtDate.TabIndex = 9
        Me.txtDate.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Income"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Sponsorship Fee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fan Club Revenue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Match Day Revenue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Merchandise Sales"
        '
        'txtMerchSales
        '
        Me.txtMerchSales.AutoSize = True
        Me.txtMerchSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMerchSales.Location = New System.Drawing.Point(485, 263)
        Me.txtMerchSales.Name = "txtMerchSales"
        Me.txtMerchSales.Size = New System.Drawing.Size(18, 20)
        Me.txtMerchSales.TabIndex = 18
        Me.txtMerchSales.Text = "+"
        '
        'txtMatch
        '
        Me.txtMatch.AutoSize = True
        Me.txtMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatch.Location = New System.Drawing.Point(485, 235)
        Me.txtMatch.Name = "txtMatch"
        Me.txtMatch.Size = New System.Drawing.Size(18, 20)
        Me.txtMatch.TabIndex = 17
        Me.txtMatch.Text = "+"
        '
        'txtFanClub
        '
        Me.txtFanClub.AutoSize = True
        Me.txtFanClub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFanClub.Location = New System.Drawing.Point(485, 208)
        Me.txtFanClub.Name = "txtFanClub"
        Me.txtFanClub.Size = New System.Drawing.Size(18, 20)
        Me.txtFanClub.TabIndex = 16
        Me.txtFanClub.Text = "+"
        '
        'txtSponsor
        '
        Me.txtSponsor.AutoSize = True
        Me.txtSponsor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSponsor.Location = New System.Drawing.Point(485, 181)
        Me.txtSponsor.Name = "txtSponsor"
        Me.txtSponsor.Size = New System.Drawing.Size(18, 20)
        Me.txtSponsor.TabIndex = 15
        Me.txtSponsor.Text = "+"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(721, 678)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 52
        Me.LineShape3.X2 = 656
        Me.LineShape3.Y1 = 517
        Me.LineShape3.Y2 = 513
        '
        'LineShape2
        '
        Me.LineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 48
        Me.LineShape2.X2 = 652
        Me.LineShape2.Y1 = 352
        Me.LineShape2.Y2 = 350
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 44
        Me.LineShape1.X2 = 652
        Me.LineShape1.Y1 = 173
        Me.LineShape1.Y2 = 172
        '
        'txtTraining
        '
        Me.txtTraining.AutoSize = True
        Me.txtTraining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTraining.Location = New System.Drawing.Point(485, 444)
        Me.txtTraining.Name = "txtTraining"
        Me.txtTraining.Size = New System.Drawing.Size(14, 20)
        Me.txtTraining.TabIndex = 28
        Me.txtTraining.Text = "-"
        '
        'txtFanCosts
        '
        Me.txtFanCosts.AutoSize = True
        Me.txtFanCosts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFanCosts.Location = New System.Drawing.Point(485, 416)
        Me.txtFanCosts.Name = "txtFanCosts"
        Me.txtFanCosts.Size = New System.Drawing.Size(14, 20)
        Me.txtFanCosts.TabIndex = 27
        Me.txtFanCosts.Text = "-"
        '
        'txtStaffSal
        '
        Me.txtStaffSal.AutoSize = True
        Me.txtStaffSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffSal.Location = New System.Drawing.Point(485, 389)
        Me.txtStaffSal.Name = "txtStaffSal"
        Me.txtStaffSal.Size = New System.Drawing.Size(14, 20)
        Me.txtStaffSal.TabIndex = 26
        Me.txtStaffSal.Text = "-"
        '
        'txtTeamSal
        '
        Me.txtTeamSal.AutoSize = True
        Me.txtTeamSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamSal.Location = New System.Drawing.Point(485, 362)
        Me.txtTeamSal.Name = "txtTeamSal"
        Me.txtTeamSal.Size = New System.Drawing.Size(14, 20)
        Me.txtTeamSal.TabIndex = 25
        Me.txtTeamSal.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(81, 444)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(170, 20)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Special Training Costs "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(81, 416)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 20)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Fan Club Costs"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(81, 389)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 20)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Staff Salary"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(81, 362)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 20)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Team Salary"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(55, 325)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 20)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Expenditure"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(419, 529)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 20)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Income"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(419, 560)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 20)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Expense"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(419, 593)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 20)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Profit"
        '
        'txtProfit
        '
        Me.txtProfit.AutoSize = True
        Me.txtProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfit.Location = New System.Drawing.Point(522, 593)
        Me.txtProfit.Name = "txtProfit"
        Me.txtProfit.Size = New System.Drawing.Size(19, 20)
        Me.txtProfit.TabIndex = 34
        Me.txtProfit.Text = "="
        '
        'txtExpense
        '
        Me.txtExpense.AutoSize = True
        Me.txtExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpense.Location = New System.Drawing.Point(522, 560)
        Me.txtExpense.Name = "txtExpense"
        Me.txtExpense.Size = New System.Drawing.Size(15, 20)
        Me.txtExpense.TabIndex = 33
        Me.txtExpense.Text = "-"
        '
        'txtIncome
        '
        Me.txtIncome.AutoSize = True
        Me.txtIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome.Location = New System.Drawing.Point(522, 529)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(19, 20)
        Me.txtIncome.TabIndex = 32
        Me.txtIncome.Text = "+"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmReportEarnings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(721, 678)
        Me.Controls.Add(Me.txtProfit)
        Me.Controls.Add(Me.txtExpense)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtTraining)
        Me.Controls.Add(Me.txtFanCosts)
        Me.Controls.Add(Me.txtStaffSal)
        Me.Controls.Add(Me.txtTeamSal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtMerchSales)
        Me.Controls.Add(Me.txtMatch)
        Me.Controls.Add(Me.txtFanClub)
        Me.Controls.Add(Me.txtSponsor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportEarnings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMerchSales As System.Windows.Forms.Label
    Friend WithEvents txtMatch As System.Windows.Forms.Label
    Friend WithEvents txtFanClub As System.Windows.Forms.Label
    Friend WithEvents txtSponsor As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtTraining As System.Windows.Forms.Label
    Friend WithEvents txtFanCosts As System.Windows.Forms.Label
    Friend WithEvents txtStaffSal As System.Windows.Forms.Label
    Friend WithEvents txtTeamSal As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtProfit As System.Windows.Forms.Label
    Friend WithEvents txtExpense As System.Windows.Forms.Label
    Friend WithEvents txtIncome As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
