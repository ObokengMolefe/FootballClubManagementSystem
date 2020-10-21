<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUser
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPageManageUser = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoMan = New System.Windows.Forms.RadioButton()
        Me.rdoFin = New System.Windows.Forms.RadioButton()
        Me.rdoHR = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tabPageViewUsers = New System.Windows.Forms.TabPage()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.dataGridUsers = New System.Windows.Forms.DataGridView()
        Me.uUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uDep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.tabPageManageUser.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabPageViewUsers.SuspendLayout()
        CType(Me.dataGridUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPageManageUser)
        Me.TabControl1.Controls.Add(Me.tabPageViewUsers)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(467, 327)
        Me.TabControl1.TabIndex = 0
        '
        'tabPageManageUser
        '
        Me.tabPageManageUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabPageManageUser.Controls.Add(Me.GroupBox1)
        Me.tabPageManageUser.Controls.Add(Me.Label6)
        Me.tabPageManageUser.Controls.Add(Me.txtPassword)
        Me.tabPageManageUser.Controls.Add(Me.Label5)
        Me.tabPageManageUser.Controls.Add(Me.txtUsername)
        Me.tabPageManageUser.Controls.Add(Me.Label4)
        Me.tabPageManageUser.Controls.Add(Me.txtSurname)
        Me.tabPageManageUser.Controls.Add(Me.Label3)
        Me.tabPageManageUser.Controls.Add(Me.txtName)
        Me.tabPageManageUser.Controls.Add(Me.Label2)
        Me.tabPageManageUser.Controls.Add(Me.Label1)
        Me.tabPageManageUser.Controls.Add(Me.Button2)
        Me.tabPageManageUser.Controls.Add(Me.Button1)
        Me.tabPageManageUser.Location = New System.Drawing.Point(4, 22)
        Me.tabPageManageUser.Name = "tabPageManageUser"
        Me.tabPageManageUser.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageManageUser.Size = New System.Drawing.Size(459, 301)
        Me.tabPageManageUser.TabIndex = 0
        Me.tabPageManageUser.Text = "Manage User"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoMan)
        Me.GroupBox1.Controls.Add(Me.rdoFin)
        Me.GroupBox1.Controls.Add(Me.rdoHR)
        Me.GroupBox1.Location = New System.Drawing.Point(99, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 122)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'rdoMan
        '
        Me.rdoMan.AutoSize = True
        Me.rdoMan.Location = New System.Drawing.Point(18, 86)
        Me.rdoMan.Name = "rdoMan"
        Me.rdoMan.Size = New System.Drawing.Size(87, 17)
        Me.rdoMan.TabIndex = 2
        Me.rdoMan.TabStop = True
        Me.rdoMan.Text = "Management"
        Me.rdoMan.UseVisualStyleBackColor = True
        '
        'rdoFin
        '
        Me.rdoFin.AutoSize = True
        Me.rdoFin.Location = New System.Drawing.Point(18, 53)
        Me.rdoFin.Name = "rdoFin"
        Me.rdoFin.Size = New System.Drawing.Size(63, 17)
        Me.rdoFin.TabIndex = 1
        Me.rdoFin.TabStop = True
        Me.rdoFin.Text = "Finance"
        Me.rdoFin.UseVisualStyleBackColor = True
        '
        'rdoHR
        '
        Me.rdoHR.AutoSize = True
        Me.rdoHR.Location = New System.Drawing.Point(18, 19)
        Me.rdoHR.Name = "rdoHR"
        Me.rdoHR.Size = New System.Drawing.Size(113, 17)
        Me.rdoHR.TabIndex = 0
        Me.rdoHR.TabStop = True
        Me.rdoHR.Text = "Human Resources"
        Me.rdoHR.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Department :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(308, 125)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(128, 20)
        Me.txtPassword.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(238, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(99, 125)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(131, 20)
        Me.txtUsername.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Username :"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(308, 67)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(128, 20)
        Me.txtSurname.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Surname :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(99, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(131, 20)
        Me.txtName.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Add System User"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(358, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tabPageViewUsers
        '
        Me.tabPageViewUsers.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabPageViewUsers.Controls.Add(Me.btnRemove)
        Me.tabPageViewUsers.Controls.Add(Me.btnModify)
        Me.tabPageViewUsers.Controls.Add(Me.dataGridUsers)
        Me.tabPageViewUsers.Location = New System.Drawing.Point(4, 22)
        Me.tabPageViewUsers.Name = "tabPageViewUsers"
        Me.tabPageViewUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageViewUsers.Size = New System.Drawing.Size(459, 301)
        Me.tabPageViewUsers.TabIndex = 1
        Me.tabPageViewUsers.Text = "View Users"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(127, 17)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(102, 23)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(7, 17)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(102, 23)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'dataGridUsers
        '
        Me.dataGridUsers.AllowUserToAddRows = False
        Me.dataGridUsers.AllowUserToDeleteRows = False
        Me.dataGridUsers.AllowUserToOrderColumns = True
        Me.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataGridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.uUserName, Me.uPassword, Me.uDep, Me.uName})
        Me.dataGridUsers.Location = New System.Drawing.Point(7, 46)
        Me.dataGridUsers.Name = "dataGridUsers"
        Me.dataGridUsers.ReadOnly = True
        Me.dataGridUsers.Size = New System.Drawing.Size(452, 249)
        Me.dataGridUsers.TabIndex = 0
        '
        'uUserName
        '
        Me.uUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.uUserName.Frozen = True
        Me.uUserName.HeaderText = "UserName"
        Me.uUserName.Name = "uUserName"
        Me.uUserName.ReadOnly = True
        '
        'uPassword
        '
        Me.uPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.uPassword.Frozen = True
        Me.uPassword.HeaderText = "Password"
        Me.uPassword.Name = "uPassword"
        Me.uPassword.ReadOnly = True
        '
        'uDep
        '
        Me.uDep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.uDep.Frozen = True
        Me.uDep.HeaderText = "Department"
        Me.uDep.Name = "uDep"
        Me.uDep.ReadOnly = True
        '
        'uName
        '
        Me.uName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.uName.Frozen = True
        Me.uName.HeaderText = "Name"
        Me.uName.Name = "uName"
        Me.uName.ReadOnly = True
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 330)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmAddUser"
        Me.Text = "Add System User"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPageManageUser.ResumeLayout(False)
        Me.tabPageManageUser.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabPageViewUsers.ResumeLayout(False)
        CType(Me.dataGridUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPageManageUser As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoMan As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFin As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHR As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tabPageViewUsers As System.Windows.Forms.TabPage
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents dataGridUsers As System.Windows.Forms.DataGridView
    Friend WithEvents uUserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uPassword As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uDep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
