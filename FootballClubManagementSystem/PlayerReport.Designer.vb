<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayerReport))
        Me.lblTotalNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.atxtName = New System.Windows.Forms.Label()
        Me.atxtAge = New System.Windows.Forms.Label()
        Me.atxtEmail = New System.Windows.Forms.Label()
        Me.atxtSurname = New System.Windows.Forms.Label()
        Me.atxtNation = New System.Windows.Forms.Label()
        Me.atxtPhone = New System.Windows.Forms.Label()
        Me.atxtJersey = New System.Windows.Forms.Label()
        Me.atxtValue = New System.Windows.Forms.Label()
        Me.atxtContract = New System.Windows.Forms.Label()
        Me.atxtPosition = New System.Windows.Forms.Label()
        Me.atxtSalary = New System.Windows.Forms.Label()
        Me.atxtYearsLeft = New System.Windows.Forms.Label()
        Me.txtPosi = New System.Windows.Forms.Label()
        Me.txtSa = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.Label()
        Me.txtCont = New System.Windows.Forms.Label()
        Me.txtV = New System.Windows.Forms.Label()
        Me.txtJe = New System.Windows.Forms.Label()
        Me.txtEm = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.Label()
        Me.txtPh = New System.Windows.Forms.Label()
        Me.txtNat = New System.Windows.Forms.Label()
        Me.txtSurn = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalNo
        '
        Me.lblTotalNo.AutoSize = True
        Me.lblTotalNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNo.Location = New System.Drawing.Point(17, 143)
        Me.lblTotalNo.Name = "lblTotalNo"
        Me.lblTotalNo.Size = New System.Drawing.Size(52, 18)
        Me.lblTotalNo.TabIndex = 22
        Me.lblTotalNo.Text = "Name "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Player Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(357, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "SETSHABA UNITED FOOTBALL CLUB"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox1.Image = Global.FootballClubManagementSystem.My.Resources.Resources.emblem_Setshaba_United_FC
        Me.PictureBox1.Location = New System.Drawing.Point(512, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox2.Image = Global.FootballClubManagementSystem.My.Resources.Resources.emblem_Setshaba_United_FC
        Me.PictureBox2.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(122, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPlayer.Location = New System.Drawing.Point(460, 143)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(158, 165)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 26
        Me.picPlayer.TabStop = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'atxtName
        '
        Me.atxtName.AutoSize = True
        Me.atxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtName.ForeColor = System.Drawing.Color.Green
        Me.atxtName.Location = New System.Drawing.Point(70, 145)
        Me.atxtName.Name = "atxtName"
        Me.atxtName.Size = New System.Drawing.Size(48, 16)
        Me.atxtName.TabIndex = 46
        Me.atxtName.Text = "Age : "
        '
        'atxtAge
        '
        Me.atxtAge.AutoSize = True
        Me.atxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtAge.ForeColor = System.Drawing.Color.Green
        Me.atxtAge.Location = New System.Drawing.Point(70, 204)
        Me.atxtAge.Name = "atxtAge"
        Me.atxtAge.Size = New System.Drawing.Size(48, 16)
        Me.atxtAge.TabIndex = 47
        Me.atxtAge.Text = "Age : "
        '
        'atxtEmail
        '
        Me.atxtEmail.AutoSize = True
        Me.atxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtEmail.ForeColor = System.Drawing.Color.Green
        Me.atxtEmail.Location = New System.Drawing.Point(70, 269)
        Me.atxtEmail.Name = "atxtEmail"
        Me.atxtEmail.Size = New System.Drawing.Size(48, 16)
        Me.atxtEmail.TabIndex = 48
        Me.atxtEmail.Text = "Age : "
        '
        'atxtSurname
        '
        Me.atxtSurname.AutoSize = True
        Me.atxtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtSurname.ForeColor = System.Drawing.Color.Green
        Me.atxtSurname.Location = New System.Drawing.Point(316, 145)
        Me.atxtSurname.Name = "atxtSurname"
        Me.atxtSurname.Size = New System.Drawing.Size(48, 16)
        Me.atxtSurname.TabIndex = 49
        Me.atxtSurname.Text = "Age : "
        '
        'atxtNation
        '
        Me.atxtNation.AutoSize = True
        Me.atxtNation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtNation.ForeColor = System.Drawing.Color.Green
        Me.atxtNation.Location = New System.Drawing.Point(316, 204)
        Me.atxtNation.Name = "atxtNation"
        Me.atxtNation.Size = New System.Drawing.Size(48, 16)
        Me.atxtNation.TabIndex = 50
        Me.atxtNation.Text = "Age : "
        '
        'atxtPhone
        '
        Me.atxtPhone.AutoSize = True
        Me.atxtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtPhone.ForeColor = System.Drawing.Color.Green
        Me.atxtPhone.Location = New System.Drawing.Point(316, 269)
        Me.atxtPhone.Name = "atxtPhone"
        Me.atxtPhone.Size = New System.Drawing.Size(48, 16)
        Me.atxtPhone.TabIndex = 51
        Me.atxtPhone.Text = "Age : "
        '
        'atxtJersey
        '
        Me.atxtJersey.AutoSize = True
        Me.atxtJersey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtJersey.ForeColor = System.Drawing.Color.Green
        Me.atxtJersey.Location = New System.Drawing.Point(149, 331)
        Me.atxtJersey.Name = "atxtJersey"
        Me.atxtJersey.Size = New System.Drawing.Size(48, 16)
        Me.atxtJersey.TabIndex = 52
        Me.atxtJersey.Text = "Age : "
        '
        'atxtValue
        '
        Me.atxtValue.AutoSize = True
        Me.atxtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtValue.ForeColor = System.Drawing.Color.Green
        Me.atxtValue.Location = New System.Drawing.Point(149, 411)
        Me.atxtValue.Name = "atxtValue"
        Me.atxtValue.Size = New System.Drawing.Size(48, 16)
        Me.atxtValue.TabIndex = 53
        Me.atxtValue.Text = "Age : "
        '
        'atxtContract
        '
        Me.atxtContract.AutoSize = True
        Me.atxtContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtContract.ForeColor = System.Drawing.Color.Green
        Me.atxtContract.Location = New System.Drawing.Point(149, 490)
        Me.atxtContract.Name = "atxtContract"
        Me.atxtContract.Size = New System.Drawing.Size(48, 16)
        Me.atxtContract.TabIndex = 54
        Me.atxtContract.Text = "Age : "
        '
        'atxtPosition
        '
        Me.atxtPosition.AutoSize = True
        Me.atxtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtPosition.ForeColor = System.Drawing.Color.Green
        Me.atxtPosition.Location = New System.Drawing.Point(399, 334)
        Me.atxtPosition.Name = "atxtPosition"
        Me.atxtPosition.Size = New System.Drawing.Size(48, 16)
        Me.atxtPosition.TabIndex = 55
        Me.atxtPosition.Text = "Age : "
        '
        'atxtSalary
        '
        Me.atxtSalary.AutoSize = True
        Me.atxtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtSalary.ForeColor = System.Drawing.Color.Green
        Me.atxtSalary.Location = New System.Drawing.Point(399, 414)
        Me.atxtSalary.Name = "atxtSalary"
        Me.atxtSalary.Size = New System.Drawing.Size(48, 16)
        Me.atxtSalary.TabIndex = 56
        Me.atxtSalary.Text = "Age : "
        '
        'atxtYearsLeft
        '
        Me.atxtYearsLeft.AutoSize = True
        Me.atxtYearsLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atxtYearsLeft.ForeColor = System.Drawing.Color.Green
        Me.atxtYearsLeft.Location = New System.Drawing.Point(399, 491)
        Me.atxtYearsLeft.Name = "atxtYearsLeft"
        Me.atxtYearsLeft.Size = New System.Drawing.Size(48, 16)
        Me.atxtYearsLeft.TabIndex = 57
        Me.atxtYearsLeft.Text = "Age : "
        '
        'txtPosi
        '
        Me.txtPosi.AutoSize = True
        Me.txtPosi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosi.Location = New System.Drawing.Point(319, 332)
        Me.txtPosi.Name = "txtPosi"
        Me.txtPosi.Size = New System.Drawing.Size(66, 18)
        Me.txtPosi.TabIndex = 35
        Me.txtPosi.Text = "Position "
        '
        'txtSa
        '
        Me.txtSa.AutoSize = True
        Me.txtSa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSa.Location = New System.Drawing.Point(319, 412)
        Me.txtSa.Name = "txtSa"
        Me.txtSa.Size = New System.Drawing.Size(49, 18)
        Me.txtSa.TabIndex = 41
        Me.txtSa.Text = "Salary"
        '
        'txtYear
        '
        Me.txtYear.AutoSize = True
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(319, 489)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(78, 18)
        Me.txtYear.TabIndex = 45
        Me.txtYear.Text = "Years Left "
        '
        'txtCont
        '
        Me.txtCont.AutoSize = True
        Me.txtCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCont.Location = New System.Drawing.Point(17, 488)
        Me.txtCont.Name = "txtCont"
        Me.txtCont.Size = New System.Drawing.Size(129, 18)
        Me.txtCont.TabIndex = 43
        Me.txtCont.Text = "Contract Duration "
        '
        'txtV
        '
        Me.txtV.AutoSize = True
        Me.txtV.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtV.Location = New System.Drawing.Point(17, 409)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(94, 18)
        Me.txtV.TabIndex = 39
        Me.txtV.Text = "Market Value"
        '
        'txtJe
        '
        Me.txtJe.AutoSize = True
        Me.txtJe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJe.Location = New System.Drawing.Point(17, 329)
        Me.txtJe.Name = "txtJe"
        Me.txtJe.Size = New System.Drawing.Size(113, 18)
        Me.txtJe.TabIndex = 37
        Me.txtJe.Text = "Jersey Number "
        '
        'txtEm
        '
        Me.txtEm.AutoSize = True
        Me.txtEm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEm.Location = New System.Drawing.Point(17, 264)
        Me.txtEm.Name = "txtEm"
        Me.txtEm.Size = New System.Drawing.Size(49, 18)
        Me.txtEm.TabIndex = 31
        Me.txtEm.Text = "Email "
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(17, 201)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(37, 18)
        Me.txt.TabIndex = 27
        Me.txt.Text = "Age "
        '
        'txtPh
        '
        Me.txtPh.AutoSize = True
        Me.txtPh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPh.Location = New System.Drawing.Point(236, 267)
        Me.txtPh.Name = "txtPh"
        Me.txtPh.Size = New System.Drawing.Size(55, 18)
        Me.txtPh.TabIndex = 33
        Me.txtPh.Text = "Phone "
        '
        'txtNat
        '
        Me.txtNat.AutoSize = True
        Me.txtNat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNat.Location = New System.Drawing.Point(236, 202)
        Me.txtNat.Name = "txtNat"
        Me.txtNat.Size = New System.Drawing.Size(80, 18)
        Me.txtNat.TabIndex = 29
        Me.txtNat.Text = "Nationality "
        '
        'txtSurn
        '
        Me.txtSurn.AutoSize = True
        Me.txtSurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurn.Location = New System.Drawing.Point(236, 143)
        Me.txtSurn.Name = "txtSurn"
        Me.txtSurn.Size = New System.Drawing.Size(72, 18)
        Me.txtSurn.TabIndex = 24
        Me.txtSurn.Text = "Surname "
        '
        'PlayerReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(637, 584)
        Me.Controls.Add(Me.atxtYearsLeft)
        Me.Controls.Add(Me.atxtSalary)
        Me.Controls.Add(Me.atxtPosition)
        Me.Controls.Add(Me.atxtContract)
        Me.Controls.Add(Me.atxtValue)
        Me.Controls.Add(Me.atxtJersey)
        Me.Controls.Add(Me.atxtPhone)
        Me.Controls.Add(Me.atxtNation)
        Me.Controls.Add(Me.atxtSurname)
        Me.Controls.Add(Me.atxtEmail)
        Me.Controls.Add(Me.atxtAge)
        Me.Controls.Add(Me.atxtName)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.txtSa)
        Me.Controls.Add(Me.txtV)
        Me.Controls.Add(Me.txtJe)
        Me.Controls.Add(Me.txtPosi)
        Me.Controls.Add(Me.txtPh)
        Me.Controls.Add(Me.txtEm)
        Me.Controls.Add(Me.txtNat)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.txtSurn)
        Me.Controls.Add(Me.lblTotalNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PlayerReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Player Report"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalNo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents atxtYearsLeft As System.Windows.Forms.Label
    Friend WithEvents atxtSalary As System.Windows.Forms.Label
    Friend WithEvents atxtPosition As System.Windows.Forms.Label
    Friend WithEvents atxtContract As System.Windows.Forms.Label
    Friend WithEvents atxtValue As System.Windows.Forms.Label
    Friend WithEvents atxtJersey As System.Windows.Forms.Label
    Friend WithEvents atxtPhone As System.Windows.Forms.Label
    Friend WithEvents atxtNation As System.Windows.Forms.Label
    Friend WithEvents atxtSurname As System.Windows.Forms.Label
    Friend WithEvents atxtEmail As System.Windows.Forms.Label
    Friend WithEvents atxtAge As System.Windows.Forms.Label
    Friend WithEvents atxtName As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.Label
    Friend WithEvents txtCont As System.Windows.Forms.Label
    Friend WithEvents txtSa As System.Windows.Forms.Label
    Friend WithEvents txtV As System.Windows.Forms.Label
    Friend WithEvents txtJe As System.Windows.Forms.Label
    Friend WithEvents txtPosi As System.Windows.Forms.Label
    Friend WithEvents txtPh As System.Windows.Forms.Label
    Friend WithEvents txtEm As System.Windows.Forms.Label
    Friend WithEvents txtNat As System.Windows.Forms.Label
    Friend WithEvents txt As System.Windows.Forms.Label
    Friend WithEvents txtSurn As System.Windows.Forms.Label
End Class
