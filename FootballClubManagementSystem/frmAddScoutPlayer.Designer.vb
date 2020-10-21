<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddScoutPlayer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtScoutName = New System.Windows.Forms.TextBox()
        Me.txtScoutSurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtScoutClub = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtScoutValue = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmboScoutPosition = New System.Windows.Forms.ComboBox()
        Me.dateScoutDoB = New System.Windows.Forms.DateTimePicker()
        Me.btnScoutCancel = New System.Windows.Forms.Button()
        Me.btnScoutSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Scouted Player"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name: "
        '
        'txtScoutName
        '
        Me.txtScoutName.Location = New System.Drawing.Point(78, 79)
        Me.txtScoutName.Name = "txtScoutName"
        Me.txtScoutName.Size = New System.Drawing.Size(160, 20)
        Me.txtScoutName.TabIndex = 2
        '
        'txtScoutSurname
        '
        Me.txtScoutSurname.Location = New System.Drawing.Point(356, 76)
        Me.txtScoutSurname.Name = "txtScoutSurname"
        Me.txtScoutSurname.Size = New System.Drawing.Size(160, 20)
        Me.txtScoutSurname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(259, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Surname: "
        '
        'txtScoutClub
        '
        Me.txtScoutClub.Location = New System.Drawing.Point(78, 192)
        Me.txtScoutClub.Name = "txtScoutClub"
        Me.txtScoutClub.Size = New System.Drawing.Size(160, 20)
        Me.txtScoutClub.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Club: "
        '
        'txtScoutValue
        '
        Me.txtScoutValue.Location = New System.Drawing.Point(356, 131)
        Me.txtScoutValue.Name = "txtScoutValue"
        Me.txtScoutValue.Size = New System.Drawing.Size(160, 20)
        Me.txtScoutValue.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(259, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Market Value: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Birth Date: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(259, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Position: "
        '
        'cmboScoutPosition
        '
        Me.cmboScoutPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboScoutPosition.FormattingEnabled = True
        Me.cmboScoutPosition.Location = New System.Drawing.Point(356, 191)
        Me.cmboScoutPosition.Name = "cmboScoutPosition"
        Me.cmboScoutPosition.Size = New System.Drawing.Size(160, 21)
        Me.cmboScoutPosition.TabIndex = 12
        '
        'dateScoutDoB
        '
        Me.dateScoutDoB.Location = New System.Drawing.Point(102, 131)
        Me.dateScoutDoB.Name = "dateScoutDoB"
        Me.dateScoutDoB.Size = New System.Drawing.Size(136, 20)
        Me.dateScoutDoB.TabIndex = 13
        '
        'btnScoutCancel
        '
        Me.btnScoutCancel.Location = New System.Drawing.Point(420, 256)
        Me.btnScoutCancel.Name = "btnScoutCancel"
        Me.btnScoutCancel.Size = New System.Drawing.Size(96, 23)
        Me.btnScoutCancel.TabIndex = 14
        Me.btnScoutCancel.Text = "&Exit"
        Me.btnScoutCancel.UseVisualStyleBackColor = True
        '
        'btnScoutSave
        '
        Me.btnScoutSave.Location = New System.Drawing.Point(164, 256)
        Me.btnScoutSave.Name = "btnScoutSave"
        Me.btnScoutSave.Size = New System.Drawing.Size(96, 23)
        Me.btnScoutSave.TabIndex = 15
        Me.btnScoutSave.Text = "&Save"
        Me.btnScoutSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(315, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "&Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmAddScoutPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 308)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnScoutSave)
        Me.Controls.Add(Me.btnScoutCancel)
        Me.Controls.Add(Me.dateScoutDoB)
        Me.Controls.Add(Me.cmboScoutPosition)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtScoutValue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtScoutClub)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtScoutSurname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtScoutName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddScoutPlayer"
        Me.Text = "frmAddScoutPlayer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtScoutName As System.Windows.Forms.TextBox
    Friend WithEvents txtScoutSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtScoutClub As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtScoutValue As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmboScoutPosition As System.Windows.Forms.ComboBox
    Friend WithEvents dateScoutDoB As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnScoutCancel As System.Windows.Forms.Button
    Friend WithEvents btnScoutSave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
