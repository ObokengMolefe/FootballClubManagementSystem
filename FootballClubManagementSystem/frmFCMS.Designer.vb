<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFCMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFCMS))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUpDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageHR = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPagePlayerView = New System.Windows.Forms.TabPage()
        Me.dgvPlayer = New System.Windows.Forms.DataGridView()
        Me.pName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pNation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pJersey = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pSalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pYearsLeft = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.cmboByPosition = New System.Windows.Forms.ComboBox()
        Me.btnPlayerSummaryReport = New System.Windows.Forms.Button()
        Me.btnPlayerSearch = New System.Windows.Forms.Button()
        Me.btnPlayerClear = New System.Windows.Forms.Button()
        Me.btnPlayerGetAll = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtPlayerByJerseyNo = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtPlayerByName = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TabPageStaffView = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnStaffSummaryReport = New System.Windows.Forms.Button()
        Me.dataGridStaff = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractYears = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.btnStaffSearch = New System.Windows.Forms.Button()
        Me.btnStaffClear = New System.Windows.Forms.Button()
        Me.btnStaffGetAll = New System.Windows.Forms.Button()
        Me.txtStaffByRole = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TabPageMedView = New System.Windows.Forms.TabPage()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.btnInjuredReport = New System.Windows.Forms.Button()
        Me.btnInjuredRemove = New System.Windows.Forms.Button()
        Me.dataGridInjured = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diagnosis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.cmboInjuredIDs = New System.Windows.Forms.ComboBox()
        Me.dateInjuredEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnInjuredUpdate = New System.Windows.Forms.Button()
        Me.btnInjuredCancel = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtInjuredDiagnosis = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TabPageTransView = New System.Windows.Forms.TabPage()
        Me.groupTranfer = New System.Windows.Forms.GroupBox()
        Me.btnTransferReport = New System.Windows.Forms.Button()
        Me.btnTransferRelease = New System.Windows.Forms.Button()
        Me.btnTransferRetain = New System.Windows.Forms.Button()
        Me.groupScout = New System.Windows.Forms.GroupBox()
        Me.btnScoutReport = New System.Windows.Forms.Button()
        Me.btnScoutRegister = New System.Windows.Forms.Button()
        Me.btnScoutAdd = New System.Windows.Forms.Button()
        Me.dataGridTransfers = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transJerseyNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transYearsLeft = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.rdoScoutList = New System.Windows.Forms.RadioButton()
        Me.rdoTransferList = New System.Windows.Forms.RadioButton()
        Me.TabPageFanView = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFanSummaryReport = New System.Windows.Forms.Button()
        Me.dataGridFan = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fanExpired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.btnFanSearch = New System.Windows.Forms.Button()
        Me.btnFanClear = New System.Windows.Forms.Button()
        Me.btnFanGetAll = New System.Windows.Forms.Button()
        Me.txtFanByID = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtFanByName = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPagePlayerAdd = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnAddtoInjured = New System.Windows.Forms.Button()
        Me.btnAddtoTransfer = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnPlayerReport = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmboxPlayerIDs = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.btnPlayerDelete = New System.Windows.Forms.Button()
        Me.btnPlayerModify = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnJerseyNoAvail = New System.Windows.Forms.Button()
        Me.txtPlayerJerseyNo = New System.Windows.Forms.TextBox()
        Me.cmboxPlayerPosition = New System.Windows.Forms.ComboBox()
        Me.picboxPlayer = New System.Windows.Forms.PictureBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnPlayerImage = New System.Windows.Forms.Button()
        Me.cmboxPlayerNation = New System.Windows.Forms.ComboBox()
        Me.datePlayerEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtPlayerValue = New System.Windows.Forms.TextBox()
        Me.txtPlayerSalary = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtPlayerEmail = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnPlayerCancel = New System.Windows.Forms.Button()
        Me.btnPlayerSave = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPlayerAddress = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.datePlayerDoB = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPlayerPhone = New System.Windows.Forms.TextBox()
        Me.txtPlayerSurname = New System.Windows.Forms.TextBox()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TabPageStaffAdd = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.cmboxStaffRoles = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btnStaffDelete = New System.Windows.Forms.Button()
        Me.btnStaffModify = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtStaffEmail = New System.Windows.Forms.TextBox()
        Me.cmboxStaffRole = New System.Windows.Forms.ComboBox()
        Me.txtStaffSalary = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnStaffCancel = New System.Windows.Forms.Button()
        Me.btnStaffSave = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStaffAddress = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dateStaffEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtStaffPhone = New System.Windows.Forms.TextBox()
        Me.txtStaffSurname = New System.Windows.Forms.TextBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPageFanAdd = New System.Windows.Forms.TabPage()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.btnFanRenew = New System.Windows.Forms.Button()
        Me.btnFanIDEdit = New System.Windows.Forms.Button()
        Me.txtFanIDEdit = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnFanDelete = New System.Windows.Forms.Button()
        Me.btnFanModify = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnFanCancel = New System.Windows.Forms.Button()
        Me.btnFanSave = New System.Windows.Forms.Button()
        Me.lstboxFanCat = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdoFanFemale = New System.Windows.Forms.RadioButton()
        Me.rdoFanMale = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFanAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dateFanDoB = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFanPhone = New System.Windows.Forms.TextBox()
        Me.txtFanSurname = New System.Windows.Forms.TextBox()
        Me.txtFanName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPageFin = New System.Windows.Forms.TabPage()
        Me.dataGridFinance = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.Button53 = New System.Windows.Forms.Button()
        Me.lstFinanceReports = New System.Windows.Forms.ListBox()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.btnListSponsors = New System.Windows.Forms.Button()
        Me.btnListStaffSalaries = New System.Windows.Forms.Button()
        Me.btnListPlayerSalaries = New System.Windows.Forms.Button()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dateSale = New System.Windows.Forms.DateTimePicker()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.btnSaleCancel = New System.Windows.Forms.Button()
        Me.btnSaleSave = New System.Windows.Forms.Button()
        Me.txtSaleAmount = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.rdoMerchandise = New System.Windows.Forms.RadioButton()
        Me.rdoTicket = New System.Windows.Forms.RadioButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnSponsorCancel = New System.Windows.Forms.Button()
        Me.btnSponsorSave = New System.Windows.Forms.Button()
        Me.dateSponsorEnd = New System.Windows.Forms.DateTimePicker()
        Me.txtSponsorIndustry = New System.Windows.Forms.TextBox()
        Me.txtSponsorFee = New System.Windows.Forms.TextBox()
        Me.txtSponsorName = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPageMan = New System.Windows.Forms.TabPage()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lstManSummaryReport = New System.Windows.Forms.ListBox()
        Me.dataGridMan = New System.Windows.Forms.DataGridView()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstManListReport = New System.Windows.Forms.ListBox()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageHR.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPagePlayerView.SuspendLayout()
        CType(Me.dgvPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.TabPageStaffView.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGridStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        Me.TabPageMedView.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        CType(Me.dataGridInjured, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox16.SuspendLayout()
        Me.TabPageTransView.SuspendLayout()
        Me.groupTranfer.SuspendLayout()
        Me.groupScout.SuspendLayout()
        CType(Me.dataGridTransfers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox17.SuspendLayout()
        Me.TabPageFanView.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataGridFan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox18.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPagePlayerAdd.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.picboxPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageStaffAdd.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPageFanAdd.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPageFin.SuspendLayout()
        CType(Me.dataGridFinance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox24.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPageMan.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.dataGridMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.AdminToolStripMenuItem1, Me.DataBackupToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1257, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.LogoutToolStripMenuItem.ToolTipText = "Log out"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        Me.ExitToolStripMenuItem1.ToolTipText = "Exit the system"
        '
        'AdminToolStripMenuItem1
        '
        Me.AdminToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUsersToolStripMenuItem})
        Me.AdminToolStripMenuItem1.Name = "AdminToolStripMenuItem1"
        Me.AdminToolStripMenuItem1.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem1.Text = "Admin"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'DataBackupToolStripMenuItem
        '
        Me.DataBackupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackUpDatabaseToolStripMenuItem})
        Me.DataBackupToolStripMenuItem.Name = "DataBackupToolStripMenuItem"
        Me.DataBackupToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DataBackupToolStripMenuItem.Text = "Database"
        '
        'BackUpDatabaseToolStripMenuItem
        '
        Me.BackUpDatabaseToolStripMenuItem.Name = "BackUpDatabaseToolStripMenuItem"
        Me.BackUpDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.BackUpDatabaseToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.BackUpDatabaseToolStripMenuItem.Text = "Back-Up Database"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Checked = True
        Me.HelpToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1257, 76)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(491, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "SETSHABA UNITED FC"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FootballClubManagementSystem.My.Resources.Resources.emblem_Setshaba_United_FC
        Me.PictureBox2.Location = New System.Drawing.Point(1128, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(123, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FootballClubManagementSystem.My.Resources.Resources.emblem_Setshaba_United_FC
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(569, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Football Club Mangement System"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TabControl)
        Me.Panel2.Location = New System.Drawing.Point(5, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1247, 524)
        Me.Panel2.TabIndex = 3
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageHR)
        Me.TabControl.Controls.Add(Me.TabPageFin)
        Me.TabControl.Controls.Add(Me.TabPageMan)
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(5, -2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1240, 519)
        Me.TabControl.TabIndex = 0
        '
        'TabPageHR
        '
        Me.TabPageHR.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageHR.Controls.Add(Me.TabControl1)
        Me.TabPageHR.Controls.Add(Me.TabControl2)
        Me.TabPageHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageHR.Location = New System.Drawing.Point(4, 25)
        Me.TabPageHR.Name = "TabPageHR"
        Me.TabPageHR.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageHR.Size = New System.Drawing.Size(1232, 490)
        Me.TabPageHR.TabIndex = 0
        Me.TabPageHR.Text = "Human Resources"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPagePlayerView)
        Me.TabControl1.Controls.Add(Me.TabPageStaffView)
        Me.TabControl1.Controls.Add(Me.TabPageMedView)
        Me.TabControl1.Controls.Add(Me.TabPageTransView)
        Me.TabControl1.Controls.Add(Me.TabPageFanView)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(5, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1216, 215)
        Me.TabControl1.TabIndex = 0
        '
        'TabPagePlayerView
        '
        Me.TabPagePlayerView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPagePlayerView.Controls.Add(Me.dgvPlayer)
        Me.TabPagePlayerView.Controls.Add(Me.GroupBox10)
        Me.TabPagePlayerView.Location = New System.Drawing.Point(4, 25)
        Me.TabPagePlayerView.Name = "TabPagePlayerView"
        Me.TabPagePlayerView.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePlayerView.Size = New System.Drawing.Size(1208, 186)
        Me.TabPagePlayerView.TabIndex = 0
        Me.TabPagePlayerView.Text = "Player View"
        '
        'dgvPlayer
        '
        Me.dgvPlayer.AllowUserToAddRows = False
        Me.dgvPlayer.AllowUserToDeleteRows = False
        Me.dgvPlayer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPlayer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlayer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pName, Me.pSurname, Me.pAge, Me.pNation, Me.pJersey, Me.pPosition, Me.pValue, Me.pSalary, Me.pYearsLeft})
        Me.dgvPlayer.Location = New System.Drawing.Point(321, 6)
        Me.dgvPlayer.Name = "dgvPlayer"
        Me.dgvPlayer.ReadOnly = True
        Me.dgvPlayer.Size = New System.Drawing.Size(873, 171)
        Me.dgvPlayer.TabIndex = 1
        '
        'pName
        '
        Me.pName.HeaderText = "Name"
        Me.pName.Name = "pName"
        Me.pName.ReadOnly = True
        '
        'pSurname
        '
        Me.pSurname.HeaderText = "Surname"
        Me.pSurname.Name = "pSurname"
        Me.pSurname.ReadOnly = True
        '
        'pAge
        '
        Me.pAge.HeaderText = "Age"
        Me.pAge.Name = "pAge"
        Me.pAge.ReadOnly = True
        '
        'pNation
        '
        Me.pNation.HeaderText = "Nation"
        Me.pNation.Name = "pNation"
        Me.pNation.ReadOnly = True
        '
        'pJersey
        '
        Me.pJersey.HeaderText = "JerseyNum"
        Me.pJersey.Name = "pJersey"
        Me.pJersey.ReadOnly = True
        '
        'pPosition
        '
        Me.pPosition.HeaderText = "Position"
        Me.pPosition.Name = "pPosition"
        Me.pPosition.ReadOnly = True
        '
        'pValue
        '
        Me.pValue.HeaderText = "Value"
        Me.pValue.Name = "pValue"
        Me.pValue.ReadOnly = True
        '
        'pSalary
        '
        Me.pSalary.HeaderText = "Salary"
        Me.pSalary.Name = "pSalary"
        Me.pSalary.ReadOnly = True
        '
        'pYearsLeft
        '
        Me.pYearsLeft.HeaderText = "YearsLeft"
        Me.pYearsLeft.Name = "pYearsLeft"
        Me.pYearsLeft.ReadOnly = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.cmboByPosition)
        Me.GroupBox10.Controls.Add(Me.btnPlayerSummaryReport)
        Me.GroupBox10.Controls.Add(Me.btnPlayerSearch)
        Me.GroupBox10.Controls.Add(Me.btnPlayerClear)
        Me.GroupBox10.Controls.Add(Me.btnPlayerGetAll)
        Me.GroupBox10.Controls.Add(Me.Label37)
        Me.GroupBox10.Controls.Add(Me.txtPlayerByJerseyNo)
        Me.GroupBox10.Controls.Add(Me.Label36)
        Me.GroupBox10.Controls.Add(Me.txtPlayerByName)
        Me.GroupBox10.Controls.Add(Me.Label35)
        Me.GroupBox10.Location = New System.Drawing.Point(11, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(291, 180)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Search"
        '
        'cmboByPosition
        '
        Me.cmboByPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboByPosition.FormattingEnabled = True
        Me.cmboByPosition.Location = New System.Drawing.Point(109, 88)
        Me.cmboByPosition.Name = "cmboByPosition"
        Me.cmboByPosition.Size = New System.Drawing.Size(145, 24)
        Me.cmboByPosition.TabIndex = 3
        '
        'btnPlayerSummaryReport
        '
        Me.btnPlayerSummaryReport.Location = New System.Drawing.Point(5, 151)
        Me.btnPlayerSummaryReport.Name = "btnPlayerSummaryReport"
        Me.btnPlayerSummaryReport.Size = New System.Drawing.Size(117, 23)
        Me.btnPlayerSummaryReport.TabIndex = 7
        Me.btnPlayerSummaryReport.Text = "Summary Report"
        Me.btnPlayerSummaryReport.UseVisualStyleBackColor = True
        '
        'btnPlayerSearch
        '
        Me.btnPlayerSearch.Location = New System.Drawing.Point(149, 119)
        Me.btnPlayerSearch.Name = "btnPlayerSearch"
        Me.btnPlayerSearch.Size = New System.Drawing.Size(63, 23)
        Me.btnPlayerSearch.TabIndex = 5
        Me.btnPlayerSearch.Text = "Search"
        Me.btnPlayerSearch.UseVisualStyleBackColor = True
        '
        'btnPlayerClear
        '
        Me.btnPlayerClear.Location = New System.Drawing.Point(219, 119)
        Me.btnPlayerClear.Name = "btnPlayerClear"
        Me.btnPlayerClear.Size = New System.Drawing.Size(63, 23)
        Me.btnPlayerClear.TabIndex = 6
        Me.btnPlayerClear.Text = "Clear"
        Me.btnPlayerClear.UseVisualStyleBackColor = True
        '
        'btnPlayerGetAll
        '
        Me.btnPlayerGetAll.Location = New System.Drawing.Point(5, 119)
        Me.btnPlayerGetAll.Name = "btnPlayerGetAll"
        Me.btnPlayerGetAll.Size = New System.Drawing.Size(117, 23)
        Me.btnPlayerGetAll.TabIndex = 4
        Me.btnPlayerGetAll.Text = "Retrieve All"
        Me.btnPlayerGetAll.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(8, 91)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(81, 16)
        Me.Label37.TabIndex = 24
        Me.Label37.Text = "By Position :"
        '
        'txtPlayerByJerseyNo
        '
        Me.txtPlayerByJerseyNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerByJerseyNo.Location = New System.Drawing.Point(109, 57)
        Me.txtPlayerByJerseyNo.Name = "txtPlayerByJerseyNo"
        Me.txtPlayerByJerseyNo.Size = New System.Drawing.Size(145, 20)
        Me.txtPlayerByJerseyNo.TabIndex = 2
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(8, 57)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(95, 16)
        Me.Label36.TabIndex = 22
        Me.Label36.Text = "By Jersey No :"
        '
        'txtPlayerByName
        '
        Me.txtPlayerByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerByName.Location = New System.Drawing.Point(109, 23)
        Me.txtPlayerByName.Name = "txtPlayerByName"
        Me.txtPlayerByName.Size = New System.Drawing.Size(145, 20)
        Me.txtPlayerByName.TabIndex = 1
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(8, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(70, 16)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "By Name :"
        '
        'TabPageStaffView
        '
        Me.TabPageStaffView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageStaffView.Controls.Add(Me.GroupBox2)
        Me.TabPageStaffView.Controls.Add(Me.dataGridStaff)
        Me.TabPageStaffView.Controls.Add(Me.GroupBox15)
        Me.TabPageStaffView.Location = New System.Drawing.Point(4, 25)
        Me.TabPageStaffView.Name = "TabPageStaffView"
        Me.TabPageStaffView.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageStaffView.Size = New System.Drawing.Size(1208, 186)
        Me.TabPageStaffView.TabIndex = 1
        Me.TabPageStaffView.Text = "Tech Staff View"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnStaffSummaryReport)
        Me.GroupBox2.Location = New System.Drawing.Point(337, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 63)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'btnStaffSummaryReport
        '
        Me.btnStaffSummaryReport.Location = New System.Drawing.Point(43, 21)
        Me.btnStaffSummaryReport.Name = "btnStaffSummaryReport"
        Me.btnStaffSummaryReport.Size = New System.Drawing.Size(123, 23)
        Me.btnStaffSummaryReport.TabIndex = 29
        Me.btnStaffSummaryReport.Text = "Summary Report"
        Me.btnStaffSummaryReport.UseVisualStyleBackColor = True
        '
        'dataGridStaff
        '
        Me.dataGridStaff.AllowUserToAddRows = False
        Me.dataGridStaff.AllowUserToDeleteRows = False
        Me.dataGridStaff.AllowUserToOrderColumns = True
        Me.dataGridStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridStaff.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.tPhone, Me.Email, Me.Role, Me.ContractYears})
        Me.dataGridStaff.Location = New System.Drawing.Point(557, 6)
        Me.dataGridStaff.Name = "dataGridStaff"
        Me.dataGridStaff.ReadOnly = True
        Me.dataGridStaff.Size = New System.Drawing.Size(641, 174)
        Me.dataGridStaff.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'tPhone
        '
        Me.tPhone.HeaderText = "Phone"
        Me.tPhone.Name = "tPhone"
        Me.tPhone.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'Role
        '
        Me.Role.HeaderText = "Role"
        Me.Role.Name = "Role"
        Me.Role.ReadOnly = True
        '
        'ContractYears
        '
        Me.ContractYears.HeaderText = "Contract(years)"
        Me.ContractYears.Name = "ContractYears"
        Me.ContractYears.ReadOnly = True
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox15.Controls.Add(Me.btnStaffSearch)
        Me.GroupBox15.Controls.Add(Me.btnStaffClear)
        Me.GroupBox15.Controls.Add(Me.btnStaffGetAll)
        Me.GroupBox15.Controls.Add(Me.txtStaffByRole)
        Me.GroupBox15.Controls.Add(Me.Label40)
        Me.GroupBox15.Location = New System.Drawing.Point(9, 16)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(312, 115)
        Me.GroupBox15.TabIndex = 2
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Search"
        '
        'btnStaffSearch
        '
        Me.btnStaffSearch.Location = New System.Drawing.Point(139, 76)
        Me.btnStaffSearch.Name = "btnStaffSearch"
        Me.btnStaffSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnStaffSearch.TabIndex = 28
        Me.btnStaffSearch.Text = "Search"
        Me.btnStaffSearch.UseVisualStyleBackColor = True
        '
        'btnStaffClear
        '
        Me.btnStaffClear.Location = New System.Drawing.Point(221, 76)
        Me.btnStaffClear.Name = "btnStaffClear"
        Me.btnStaffClear.Size = New System.Drawing.Size(75, 23)
        Me.btnStaffClear.TabIndex = 27
        Me.btnStaffClear.Text = "Clear"
        Me.btnStaffClear.UseVisualStyleBackColor = True
        '
        'btnStaffGetAll
        '
        Me.btnStaffGetAll.Location = New System.Drawing.Point(11, 76)
        Me.btnStaffGetAll.Name = "btnStaffGetAll"
        Me.btnStaffGetAll.Size = New System.Drawing.Size(99, 23)
        Me.btnStaffGetAll.TabIndex = 26
        Me.btnStaffGetAll.Text = "Retrieve All"
        Me.btnStaffGetAll.UseVisualStyleBackColor = True
        '
        'txtStaffByRole
        '
        Me.txtStaffByRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffByRole.Location = New System.Drawing.Point(80, 23)
        Me.txtStaffByRole.Name = "txtStaffByRole"
        Me.txtStaffByRole.Size = New System.Drawing.Size(121, 20)
        Me.txtStaffByRole.TabIndex = 21
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(8, 23)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(62, 16)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "By Role :"
        '
        'TabPageMedView
        '
        Me.TabPageMedView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageMedView.Controls.Add(Me.GroupBox21)
        Me.TabPageMedView.Controls.Add(Me.dataGridInjured)
        Me.TabPageMedView.Controls.Add(Me.GroupBox16)
        Me.TabPageMedView.Location = New System.Drawing.Point(4, 25)
        Me.TabPageMedView.Name = "TabPageMedView"
        Me.TabPageMedView.Size = New System.Drawing.Size(1208, 186)
        Me.TabPageMedView.TabIndex = 2
        Me.TabPageMedView.Text = "Medical View"
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.btnInjuredReport)
        Me.GroupBox21.Controls.Add(Me.btnInjuredRemove)
        Me.GroupBox21.Location = New System.Drawing.Point(321, 16)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(200, 127)
        Me.GroupBox21.TabIndex = 4
        Me.GroupBox21.TabStop = False
        '
        'btnInjuredReport
        '
        Me.btnInjuredReport.Location = New System.Drawing.Point(40, 88)
        Me.btnInjuredReport.Name = "btnInjuredReport"
        Me.btnInjuredReport.Size = New System.Drawing.Size(125, 23)
        Me.btnInjuredReport.TabIndex = 31
        Me.btnInjuredReport.Text = "Injury Report"
        Me.btnInjuredReport.UseVisualStyleBackColor = True
        '
        'btnInjuredRemove
        '
        Me.btnInjuredRemove.Location = New System.Drawing.Point(40, 23)
        Me.btnInjuredRemove.Name = "btnInjuredRemove"
        Me.btnInjuredRemove.Size = New System.Drawing.Size(125, 23)
        Me.btnInjuredRemove.TabIndex = 30
        Me.btnInjuredRemove.Text = "Remove"
        Me.btnInjuredRemove.UseVisualStyleBackColor = True
        '
        'dataGridInjured
        '
        Me.dataGridInjured.AllowUserToAddRows = False
        Me.dataGridInjured.AllowUserToDeleteRows = False
        Me.dataGridInjured.AllowUserToOrderColumns = True
        Me.dataGridInjured.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridInjured.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataGridInjured.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dataGridInjured.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridInjured.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn15, Me.Diagnosis, Me.Duration})
        Me.dataGridInjured.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dataGridInjured.Location = New System.Drawing.Point(527, 6)
        Me.dataGridInjured.Name = "dataGridInjured"
        Me.dataGridInjured.ReadOnly = True
        Me.dataGridInjured.Size = New System.Drawing.Size(672, 174)
        Me.dataGridInjured.TabIndex = 3
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Player ID"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'Diagnosis
        '
        Me.Diagnosis.HeaderText = "Diagnosis"
        Me.Diagnosis.Name = "Diagnosis"
        Me.Diagnosis.ReadOnly = True
        '
        'Duration
        '
        Me.Duration.HeaderText = "Duration(weeks)"
        Me.Duration.Name = "Duration"
        Me.Duration.ReadOnly = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.cmboInjuredIDs)
        Me.GroupBox16.Controls.Add(Me.dateInjuredEnd)
        Me.GroupBox16.Controls.Add(Me.btnInjuredUpdate)
        Me.GroupBox16.Controls.Add(Me.btnInjuredCancel)
        Me.GroupBox16.Controls.Add(Me.Label41)
        Me.GroupBox16.Controls.Add(Me.txtInjuredDiagnosis)
        Me.GroupBox16.Controls.Add(Me.Label42)
        Me.GroupBox16.Controls.Add(Me.Label43)
        Me.GroupBox16.Location = New System.Drawing.Point(9, 16)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(272, 164)
        Me.GroupBox16.TabIndex = 2
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Add Injured"
        '
        'cmboInjuredIDs
        '
        Me.cmboInjuredIDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboInjuredIDs.FormattingEnabled = True
        Me.cmboInjuredIDs.Location = New System.Drawing.Point(97, 20)
        Me.cmboInjuredIDs.Name = "cmboInjuredIDs"
        Me.cmboInjuredIDs.Size = New System.Drawing.Size(148, 24)
        Me.cmboInjuredIDs.TabIndex = 30
        '
        'dateInjuredEnd
        '
        Me.dateInjuredEnd.Location = New System.Drawing.Point(97, 87)
        Me.dateInjuredEnd.Name = "dateInjuredEnd"
        Me.dateInjuredEnd.Size = New System.Drawing.Size(148, 22)
        Me.dateInjuredEnd.TabIndex = 29
        '
        'btnInjuredUpdate
        '
        Me.btnInjuredUpdate.Location = New System.Drawing.Point(93, 126)
        Me.btnInjuredUpdate.Name = "btnInjuredUpdate"
        Me.btnInjuredUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnInjuredUpdate.TabIndex = 28
        Me.btnInjuredUpdate.Text = "Update"
        Me.btnInjuredUpdate.UseVisualStyleBackColor = True
        '
        'btnInjuredCancel
        '
        Me.btnInjuredCancel.Location = New System.Drawing.Point(173, 126)
        Me.btnInjuredCancel.Name = "btnInjuredCancel"
        Me.btnInjuredCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnInjuredCancel.TabIndex = 27
        Me.btnInjuredCancel.Text = "Cancel"
        Me.btnInjuredCancel.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(8, 91)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(70, 16)
        Me.Label41.TabIndex = 24
        Me.Label41.Text = "End Date :"
        '
        'txtInjuredDiagnosis
        '
        Me.txtInjuredDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInjuredDiagnosis.Location = New System.Drawing.Point(97, 57)
        Me.txtInjuredDiagnosis.Name = "txtInjuredDiagnosis"
        Me.txtInjuredDiagnosis.Size = New System.Drawing.Size(148, 20)
        Me.txtInjuredDiagnosis.TabIndex = 23
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(8, 57)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(75, 16)
        Me.Label42.TabIndex = 22
        Me.Label42.Text = "Diagnosis :"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(8, 23)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(69, 16)
        Me.Label43.TabIndex = 20
        Me.Label43.Text = "Player ID :"
        '
        'TabPageTransView
        '
        Me.TabPageTransView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageTransView.Controls.Add(Me.groupTranfer)
        Me.TabPageTransView.Controls.Add(Me.groupScout)
        Me.TabPageTransView.Controls.Add(Me.dataGridTransfers)
        Me.TabPageTransView.Controls.Add(Me.GroupBox17)
        Me.TabPageTransView.Location = New System.Drawing.Point(4, 25)
        Me.TabPageTransView.Name = "TabPageTransView"
        Me.TabPageTransView.Size = New System.Drawing.Size(1208, 186)
        Me.TabPageTransView.TabIndex = 3
        Me.TabPageTransView.Text = "Transfers View"
        '
        'groupTranfer
        '
        Me.groupTranfer.Controls.Add(Me.btnTransferReport)
        Me.groupTranfer.Controls.Add(Me.btnTransferRelease)
        Me.groupTranfer.Controls.Add(Me.btnTransferRetain)
        Me.groupTranfer.Location = New System.Drawing.Point(227, 16)
        Me.groupTranfer.Name = "groupTranfer"
        Me.groupTranfer.Size = New System.Drawing.Size(287, 78)
        Me.groupTranfer.TabIndex = 5
        Me.groupTranfer.TabStop = False
        Me.groupTranfer.Text = "Transfer List"
        '
        'btnTransferReport
        '
        Me.btnTransferReport.Location = New System.Drawing.Point(155, 50)
        Me.btnTransferReport.Name = "btnTransferReport"
        Me.btnTransferReport.Size = New System.Drawing.Size(125, 23)
        Me.btnTransferReport.TabIndex = 35
        Me.btnTransferReport.Text = "Transfer Report"
        Me.btnTransferReport.UseVisualStyleBackColor = True
        '
        'btnTransferRelease
        '
        Me.btnTransferRelease.Location = New System.Drawing.Point(9, 50)
        Me.btnTransferRelease.Name = "btnTransferRelease"
        Me.btnTransferRelease.Size = New System.Drawing.Size(125, 23)
        Me.btnTransferRelease.TabIndex = 34
        Me.btnTransferRelease.Text = "Release"
        Me.btnTransferRelease.UseVisualStyleBackColor = True
        '
        'btnTransferRetain
        '
        Me.btnTransferRetain.Location = New System.Drawing.Point(9, 21)
        Me.btnTransferRetain.Name = "btnTransferRetain"
        Me.btnTransferRetain.Size = New System.Drawing.Size(125, 23)
        Me.btnTransferRetain.TabIndex = 33
        Me.btnTransferRetain.Text = "Retain"
        Me.btnTransferRetain.UseVisualStyleBackColor = True
        '
        'groupScout
        '
        Me.groupScout.Controls.Add(Me.btnScoutReport)
        Me.groupScout.Controls.Add(Me.btnScoutRegister)
        Me.groupScout.Controls.Add(Me.btnScoutAdd)
        Me.groupScout.Location = New System.Drawing.Point(227, 98)
        Me.groupScout.Name = "groupScout"
        Me.groupScout.Size = New System.Drawing.Size(287, 82)
        Me.groupScout.TabIndex = 4
        Me.groupScout.TabStop = False
        Me.groupScout.Text = "Scout List"
        '
        'btnScoutReport
        '
        Me.btnScoutReport.Location = New System.Drawing.Point(155, 53)
        Me.btnScoutReport.Name = "btnScoutReport"
        Me.btnScoutReport.Size = New System.Drawing.Size(125, 23)
        Me.btnScoutReport.TabIndex = 36
        Me.btnScoutReport.Text = "Scout Report"
        Me.btnScoutReport.UseVisualStyleBackColor = True
        '
        'btnScoutRegister
        '
        Me.btnScoutRegister.Location = New System.Drawing.Point(9, 53)
        Me.btnScoutRegister.Name = "btnScoutRegister"
        Me.btnScoutRegister.Size = New System.Drawing.Size(125, 23)
        Me.btnScoutRegister.TabIndex = 32
        Me.btnScoutRegister.Text = "Register"
        Me.btnScoutRegister.UseVisualStyleBackColor = True
        '
        'btnScoutAdd
        '
        Me.btnScoutAdd.Location = New System.Drawing.Point(9, 24)
        Me.btnScoutAdd.Name = "btnScoutAdd"
        Me.btnScoutAdd.Size = New System.Drawing.Size(125, 23)
        Me.btnScoutAdd.TabIndex = 31
        Me.btnScoutAdd.Text = "Add New"
        Me.btnScoutAdd.UseVisualStyleBackColor = True
        '
        'dataGridTransfers
        '
        Me.dataGridTransfers.AllowUserToAddRows = False
        Me.dataGridTransfers.AllowUserToDeleteRows = False
        Me.dataGridTransfers.AllowUserToOrderColumns = True
        Me.dataGridTransfers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridTransfers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn24, Me.transJerseyNo, Me.DataGridViewTextBoxColumn25, Me.transYearsLeft})
        Me.dataGridTransfers.Location = New System.Drawing.Point(520, 6)
        Me.dataGridTransfers.Name = "dataGridTransfers"
        Me.dataGridTransfers.ReadOnly = True
        Me.dataGridTransfers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridTransfers.Size = New System.Drawing.Size(679, 174)
        Me.dataGridTransfers.TabIndex = 3
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'transJerseyNo
        '
        Me.transJerseyNo.HeaderText = "Jersey No"
        Me.transJerseyNo.Name = "transJerseyNo"
        Me.transJerseyNo.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'transYearsLeft
        '
        Me.transYearsLeft.HeaderText = "YearsLeft"
        Me.transYearsLeft.Name = "transYearsLeft"
        Me.transYearsLeft.ReadOnly = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.rdoScoutList)
        Me.GroupBox17.Controls.Add(Me.rdoTransferList)
        Me.GroupBox17.Location = New System.Drawing.Point(9, 16)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(195, 145)
        Me.GroupBox17.TabIndex = 2
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Retrieve"
        '
        'rdoScoutList
        '
        Me.rdoScoutList.AutoSize = True
        Me.rdoScoutList.Location = New System.Drawing.Point(40, 85)
        Me.rdoScoutList.Name = "rdoScoutList"
        Me.rdoScoutList.Size = New System.Drawing.Size(83, 20)
        Me.rdoScoutList.TabIndex = 30
        Me.rdoScoutList.Text = "Scout List"
        Me.rdoScoutList.UseVisualStyleBackColor = True
        '
        'rdoTransferList
        '
        Me.rdoTransferList.AutoSize = True
        Me.rdoTransferList.Location = New System.Drawing.Point(40, 38)
        Me.rdoTransferList.Name = "rdoTransferList"
        Me.rdoTransferList.Size = New System.Drawing.Size(99, 20)
        Me.rdoTransferList.TabIndex = 29
        Me.rdoTransferList.Text = "Transfer List"
        Me.rdoTransferList.UseVisualStyleBackColor = True
        '
        'TabPageFanView
        '
        Me.TabPageFanView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageFanView.Controls.Add(Me.GroupBox1)
        Me.TabPageFanView.Controls.Add(Me.dataGridFan)
        Me.TabPageFanView.Controls.Add(Me.GroupBox18)
        Me.TabPageFanView.Location = New System.Drawing.Point(4, 25)
        Me.TabPageFanView.Name = "TabPageFanView"
        Me.TabPageFanView.Size = New System.Drawing.Size(1208, 186)
        Me.TabPageFanView.TabIndex = 4
        Me.TabPageFanView.Text = "Fan Membership"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFanSummaryReport)
        Me.GroupBox1.Location = New System.Drawing.Point(359, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 72)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnFanSummaryReport
        '
        Me.btnFanSummaryReport.Location = New System.Drawing.Point(23, 23)
        Me.btnFanSummaryReport.Name = "btnFanSummaryReport"
        Me.btnFanSummaryReport.Size = New System.Drawing.Size(129, 23)
        Me.btnFanSummaryReport.TabIndex = 29
        Me.btnFanSummaryReport.Text = "Summary Report"
        Me.btnFanSummaryReport.UseVisualStyleBackColor = True
        '
        'dataGridFan
        '
        Me.dataGridFan.AllowUserToAddRows = False
        Me.dataGridFan.AllowUserToDeleteRows = False
        Me.dataGridFan.AllowUserToOrderColumns = True
        Me.dataGridFan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridFan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridFan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.Contact, Me.Gender, Me.Category, Me.fanExpired})
        Me.dataGridFan.Location = New System.Drawing.Point(557, 6)
        Me.dataGridFan.Name = "dataGridFan"
        Me.dataGridFan.ReadOnly = True
        Me.dataGridFan.Size = New System.Drawing.Size(643, 174)
        Me.dataGridFan.TabIndex = 3
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'Contact
        '
        Me.Contact.HeaderText = "Contact"
        Me.Contact.Name = "Contact"
        Me.Contact.ReadOnly = True
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'fanExpired
        '
        Me.fanExpired.HeaderText = "Expired?"
        Me.fanExpired.Name = "fanExpired"
        Me.fanExpired.ReadOnly = True
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.btnFanSearch)
        Me.GroupBox18.Controls.Add(Me.btnFanClear)
        Me.GroupBox18.Controls.Add(Me.btnFanGetAll)
        Me.GroupBox18.Controls.Add(Me.txtFanByID)
        Me.GroupBox18.Controls.Add(Me.Label48)
        Me.GroupBox18.Controls.Add(Me.txtFanByName)
        Me.GroupBox18.Controls.Add(Me.Label49)
        Me.GroupBox18.Location = New System.Drawing.Point(9, 16)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(315, 164)
        Me.GroupBox18.TabIndex = 2
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Search"
        '
        'btnFanSearch
        '
        Me.btnFanSearch.Location = New System.Drawing.Point(139, 117)
        Me.btnFanSearch.Name = "btnFanSearch"
        Me.btnFanSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnFanSearch.TabIndex = 28
        Me.btnFanSearch.Text = "Search"
        Me.btnFanSearch.UseVisualStyleBackColor = True
        '
        'btnFanClear
        '
        Me.btnFanClear.Location = New System.Drawing.Point(221, 117)
        Me.btnFanClear.Name = "btnFanClear"
        Me.btnFanClear.Size = New System.Drawing.Size(75, 23)
        Me.btnFanClear.TabIndex = 27
        Me.btnFanClear.Text = "Clear"
        Me.btnFanClear.UseVisualStyleBackColor = True
        '
        'btnFanGetAll
        '
        Me.btnFanGetAll.Location = New System.Drawing.Point(11, 117)
        Me.btnFanGetAll.Name = "btnFanGetAll"
        Me.btnFanGetAll.Size = New System.Drawing.Size(99, 23)
        Me.btnFanGetAll.TabIndex = 26
        Me.btnFanGetAll.Text = "Retrieve All"
        Me.btnFanGetAll.UseVisualStyleBackColor = True
        '
        'txtFanByID
        '
        Me.txtFanByID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFanByID.Location = New System.Drawing.Point(80, 57)
        Me.txtFanByID.Name = "txtFanByID"
        Me.txtFanByID.Size = New System.Drawing.Size(121, 20)
        Me.txtFanByID.TabIndex = 23
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(8, 57)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(46, 16)
        Me.Label48.TabIndex = 22
        Me.Label48.Text = "By ID :"
        '
        'txtFanByName
        '
        Me.txtFanByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFanByName.Location = New System.Drawing.Point(80, 23)
        Me.txtFanByName.Name = "txtFanByName"
        Me.txtFanByName.Size = New System.Drawing.Size(121, 20)
        Me.txtFanByName.TabIndex = 21
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(8, 23)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(70, 16)
        Me.Label49.TabIndex = 20
        Me.Label49.Text = "By Name :"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPagePlayerAdd)
        Me.TabControl2.Controls.Add(Me.TabPageStaffAdd)
        Me.TabControl2.Controls.Add(Me.TabPageFanAdd)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(5, 227)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1221, 258)
        Me.TabControl2.TabIndex = 1
        '
        'TabPagePlayerAdd
        '
        Me.TabPagePlayerAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPagePlayerAdd.Controls.Add(Me.GroupBox9)
        Me.TabPagePlayerAdd.Controls.Add(Me.GroupBox8)
        Me.TabPagePlayerAdd.Controls.Add(Me.GroupBox7)
        Me.TabPagePlayerAdd.Controls.Add(Me.GroupBox6)
        Me.TabPagePlayerAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPagePlayerAdd.Location = New System.Drawing.Point(4, 25)
        Me.TabPagePlayerAdd.Name = "TabPagePlayerAdd"
        Me.TabPagePlayerAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePlayerAdd.Size = New System.Drawing.Size(1213, 229)
        Me.TabPagePlayerAdd.TabIndex = 0
        Me.TabPagePlayerAdd.Text = "Players"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox9.Controls.Add(Me.btnAddtoInjured)
        Me.GroupBox9.Controls.Add(Me.btnAddtoTransfer)
        Me.GroupBox9.Location = New System.Drawing.Point(885, 160)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(309, 58)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Injury and Transfer"
        '
        'btnAddtoInjured
        '
        Me.btnAddtoInjured.Location = New System.Drawing.Point(171, 24)
        Me.btnAddtoInjured.Name = "btnAddtoInjured"
        Me.btnAddtoInjured.Size = New System.Drawing.Size(109, 23)
        Me.btnAddtoInjured.TabIndex = 3
        Me.btnAddtoInjured.Text = "Add to Injured"
        Me.btnAddtoInjured.UseVisualStyleBackColor = True
        '
        'btnAddtoTransfer
        '
        Me.btnAddtoTransfer.Location = New System.Drawing.Point(27, 24)
        Me.btnAddtoTransfer.Name = "btnAddtoTransfer"
        Me.btnAddtoTransfer.Size = New System.Drawing.Size(115, 23)
        Me.btnAddtoTransfer.TabIndex = 4
        Me.btnAddtoTransfer.Text = "Add to Transfer"
        Me.btnAddtoTransfer.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox8.Controls.Add(Me.btnPlayerReport)
        Me.GroupBox8.Location = New System.Drawing.Point(885, 103)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(309, 58)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Player Info Report"
        '
        'btnPlayerReport
        '
        Me.btnPlayerReport.Location = New System.Drawing.Point(101, 21)
        Me.btnPlayerReport.Name = "btnPlayerReport"
        Me.btnPlayerReport.Size = New System.Drawing.Size(109, 23)
        Me.btnPlayerReport.TabIndex = 30
        Me.btnPlayerReport.Text = "Player Report"
        Me.btnPlayerReport.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox7.Controls.Add(Me.cmboxPlayerIDs)
        Me.GroupBox7.Controls.Add(Me.Label45)
        Me.GroupBox7.Controls.Add(Me.btnPlayerDelete)
        Me.GroupBox7.Controls.Add(Me.btnPlayerModify)
        Me.GroupBox7.Location = New System.Drawing.Point(885, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(309, 91)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Manage Details"
        '
        'cmboxPlayerIDs
        '
        Me.cmboxPlayerIDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxPlayerIDs.FormattingEnabled = True
        Me.cmboxPlayerIDs.Location = New System.Drawing.Point(77, 21)
        Me.cmboxPlayerIDs.Name = "cmboxPlayerIDs"
        Me.cmboxPlayerIDs.Size = New System.Drawing.Size(95, 24)
        Me.cmboxPlayerIDs.TabIndex = 3
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(5, 27)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(66, 16)
        Me.Label45.TabIndex = 2
        Me.Label45.Text = "Player ID:"
        '
        'btnPlayerDelete
        '
        Me.btnPlayerDelete.Location = New System.Drawing.Point(171, 59)
        Me.btnPlayerDelete.Name = "btnPlayerDelete"
        Me.btnPlayerDelete.Size = New System.Drawing.Size(91, 23)
        Me.btnPlayerDelete.TabIndex = 1
        Me.btnPlayerDelete.Text = "Delete"
        Me.btnPlayerDelete.UseVisualStyleBackColor = True
        '
        'btnPlayerModify
        '
        Me.btnPlayerModify.Location = New System.Drawing.Point(43, 59)
        Me.btnPlayerModify.Name = "btnPlayerModify"
        Me.btnPlayerModify.Size = New System.Drawing.Size(91, 23)
        Me.btnPlayerModify.TabIndex = 0
        Me.btnPlayerModify.Text = "Modify"
        Me.btnPlayerModify.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox6.Controls.Add(Me.btnJerseyNoAvail)
        Me.GroupBox6.Controls.Add(Me.txtPlayerJerseyNo)
        Me.GroupBox6.Controls.Add(Me.cmboxPlayerPosition)
        Me.GroupBox6.Controls.Add(Me.picboxPlayer)
        Me.GroupBox6.Controls.Add(Me.Label32)
        Me.GroupBox6.Controls.Add(Me.btnPlayerImage)
        Me.GroupBox6.Controls.Add(Me.cmboxPlayerNation)
        Me.GroupBox6.Controls.Add(Me.datePlayerEnd)
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.txtPlayerValue)
        Me.GroupBox6.Controls.Add(Me.txtPlayerSalary)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.txtPlayerEmail)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.btnPlayerCancel)
        Me.GroupBox6.Controls.Add(Me.btnPlayerSave)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txtPlayerAddress)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.datePlayerDoB)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.txtPlayerPhone)
        Me.GroupBox6.Controls.Add(Me.txtPlayerSurname)
        Me.GroupBox6.Controls.Add(Me.txtPlayerName)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(848, 222)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Add Player"
        '
        'btnJerseyNoAvail
        '
        Me.btnJerseyNoAvail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJerseyNoAvail.Location = New System.Drawing.Point(597, 142)
        Me.btnJerseyNoAvail.Name = "btnJerseyNoAvail"
        Me.btnJerseyNoAvail.Size = New System.Drawing.Size(67, 23)
        Me.btnJerseyNoAvail.TabIndex = 51
        Me.btnJerseyNoAvail.Text = "available?"
        Me.btnJerseyNoAvail.UseVisualStyleBackColor = True
        '
        'txtPlayerJerseyNo
        '
        Me.txtPlayerJerseyNo.Location = New System.Drawing.Point(543, 142)
        Me.txtPlayerJerseyNo.MaxLength = 2
        Me.txtPlayerJerseyNo.Name = "txtPlayerJerseyNo"
        Me.txtPlayerJerseyNo.Size = New System.Drawing.Size(49, 22)
        Me.txtPlayerJerseyNo.TabIndex = 50
        '
        'cmboxPlayerPosition
        '
        Me.cmboxPlayerPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxPlayerPosition.FormattingEnabled = True
        Me.cmboxPlayerPosition.Location = New System.Drawing.Point(321, 142)
        Me.cmboxPlayerPosition.Name = "cmboxPlayerPosition"
        Me.cmboxPlayerPosition.Size = New System.Drawing.Size(121, 24)
        Me.cmboxPlayerPosition.TabIndex = 49
        '
        'picboxPlayer
        '
        Me.picboxPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picboxPlayer.Image = Global.FootballClubManagementSystem.My.Resources.Resources.image_holder
        Me.picboxPlayer.InitialImage = Global.FootballClubManagementSystem.My.Resources.Resources.image_holder
        Me.picboxPlayer.Location = New System.Drawing.Point(685, 47)
        Me.picboxPlayer.Name = "picboxPlayer"
        Me.picboxPlayer.Size = New System.Drawing.Size(147, 124)
        Me.picboxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxPlayer.TabIndex = 47
        Me.picboxPlayer.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(683, 24)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(87, 16)
        Me.Label32.TabIndex = 46
        Me.Label32.Text = "Insert Image :"
        '
        'btnPlayerImage
        '
        Me.btnPlayerImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayerImage.Location = New System.Drawing.Point(808, 20)
        Me.btnPlayerImage.Name = "btnPlayerImage"
        Me.btnPlayerImage.Size = New System.Drawing.Size(24, 21)
        Me.btnPlayerImage.TabIndex = 45
        Me.btnPlayerImage.Text = "+"
        Me.btnPlayerImage.UseVisualStyleBackColor = True
        '
        'cmboxPlayerNation
        '
        Me.cmboxPlayerNation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxPlayerNation.FormattingEnabled = True
        Me.cmboxPlayerNation.Items.AddRange(New Object() {"Algeria", "Angola", "Botswana", "Lesotho", "South Africa", "Zambia", "Namibia", "Zimbabwe", "Congo", "Niger", "Nigeria"})
        Me.cmboxPlayerNation.Location = New System.Drawing.Point(543, 65)
        Me.cmboxPlayerNation.Name = "cmboxPlayerNation"
        Me.cmboxPlayerNation.Size = New System.Drawing.Size(121, 24)
        Me.cmboxPlayerNation.TabIndex = 43
        '
        'datePlayerEnd
        '
        Me.datePlayerEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePlayerEnd.Location = New System.Drawing.Point(317, 180)
        Me.datePlayerEnd.Name = "datePlayerEnd"
        Me.datePlayerEnd.Size = New System.Drawing.Size(124, 20)
        Me.datePlayerEnd.TabIndex = 41
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(229, 180)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(70, 16)
        Me.Label31.TabIndex = 40
        Me.Label31.Text = "End Date :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(467, 67)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 16)
        Me.Label30.TabIndex = 37
        Me.Label30.Text = "Nationality :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(467, 142)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(76, 16)
        Me.Label29.TabIndex = 36
        Me.Label29.Text = "Jersey No :"
        '
        'txtPlayerValue
        '
        Me.txtPlayerValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerValue.Location = New System.Drawing.Point(321, 105)
        Me.txtPlayerValue.Name = "txtPlayerValue"
        Me.txtPlayerValue.Size = New System.Drawing.Size(121, 20)
        Me.txtPlayerValue.TabIndex = 35
        '
        'txtPlayerSalary
        '
        Me.txtPlayerSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerSalary.Location = New System.Drawing.Point(543, 106)
        Me.txtPlayerSalary.Name = "txtPlayerSalary"
        Me.txtPlayerSalary.Size = New System.Drawing.Size(121, 20)
        Me.txtPlayerSalary.TabIndex = 34
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(467, 106)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(82, 16)
        Me.Label28.TabIndex = 33
        Me.Label28.Text = "Mon Salary :"
        '
        'txtPlayerEmail
        '
        Me.txtPlayerEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerEmail.Location = New System.Drawing.Point(77, 62)
        Me.txtPlayerEmail.Name = "txtPlayerEmail"
        Me.txtPlayerEmail.Size = New System.Drawing.Size(121, 20)
        Me.txtPlayerEmail.TabIndex = 32
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 65)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 16)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Email :"
        '
        'btnPlayerCancel
        '
        Me.btnPlayerCancel.Location = New System.Drawing.Point(776, 192)
        Me.btnPlayerCancel.Name = "btnPlayerCancel"
        Me.btnPlayerCancel.Size = New System.Drawing.Size(67, 23)
        Me.btnPlayerCancel.TabIndex = 30
        Me.btnPlayerCancel.Text = "Cancel"
        Me.btnPlayerCancel.UseVisualStyleBackColor = True
        '
        'btnPlayerSave
        '
        Me.btnPlayerSave.Location = New System.Drawing.Point(685, 192)
        Me.btnPlayerSave.Name = "btnPlayerSave"
        Me.btnPlayerSave.Size = New System.Drawing.Size(80, 23)
        Me.btnPlayerSave.TabIndex = 29
        Me.btnPlayerSave.Text = "Save"
        Me.btnPlayerSave.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(229, 142)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 16)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Position :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(229, 106)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 16)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Market Value :"
        '
        'txtPlayerAddress
        '
        Me.txtPlayerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerAddress.Location = New System.Drawing.Point(77, 102)
        Me.txtPlayerAddress.Multiline = True
        Me.txtPlayerAddress.Name = "txtPlayerAddress"
        Me.txtPlayerAddress.Size = New System.Drawing.Size(143, 114)
        Me.txtPlayerAddress.TabIndex = 25
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(5, 102)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 16)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Address :"
        '
        'datePlayerDoB
        '
        Me.datePlayerDoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePlayerDoB.Location = New System.Drawing.Point(543, 27)
        Me.datePlayerDoB.Name = "datePlayerDoB"
        Me.datePlayerDoB.Size = New System.Drawing.Size(121, 20)
        Me.datePlayerDoB.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(467, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 16)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Birth Date :"
        '
        'txtPlayerPhone
        '
        Me.txtPlayerPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerPhone.Location = New System.Drawing.Point(321, 63)
        Me.txtPlayerPhone.Name = "txtPlayerPhone"
        Me.txtPlayerPhone.Size = New System.Drawing.Size(121, 20)
        Me.txtPlayerPhone.TabIndex = 21
        '
        'txtPlayerSurname
        '
        Me.txtPlayerSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerSurname.Location = New System.Drawing.Point(321, 22)
        Me.txtPlayerSurname.Name = "txtPlayerSurname"
        Me.txtPlayerSurname.Size = New System.Drawing.Size(121, 20)
        Me.txtPlayerSurname.TabIndex = 20
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerName.Location = New System.Drawing.Point(77, 27)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(121, 20)
        Me.txtPlayerName.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(229, 67)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 16)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "Phone No :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(229, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(68, 16)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Surname :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(5, 27)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 16)
        Me.Label26.TabIndex = 16
        Me.Label26.Text = "Name :"
        '
        'TabPageStaffAdd
        '
        Me.TabPageStaffAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageStaffAdd.Controls.Add(Me.GroupBox12)
        Me.TabPageStaffAdd.Controls.Add(Me.GroupBox5)
        Me.TabPageStaffAdd.Location = New System.Drawing.Point(4, 25)
        Me.TabPageStaffAdd.Name = "TabPageStaffAdd"
        Me.TabPageStaffAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageStaffAdd.Size = New System.Drawing.Size(1213, 229)
        Me.TabPageStaffAdd.TabIndex = 1
        Me.TabPageStaffAdd.Text = "Technical Staff"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.cmboxStaffRoles)
        Me.GroupBox12.Controls.Add(Me.Label33)
        Me.GroupBox12.Controls.Add(Me.btnStaffDelete)
        Me.GroupBox12.Controls.Add(Me.btnStaffModify)
        Me.GroupBox12.Location = New System.Drawing.Point(829, 20)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(377, 133)
        Me.GroupBox12.TabIndex = 3
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Manage Details"
        '
        'cmboxStaffRoles
        '
        Me.cmboxStaffRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxStaffRoles.FormattingEnabled = True
        Me.cmboxStaffRoles.Items.AddRange(New Object() {"Coach", "AssistantCoach", "Scout", "Doctor", "PhysicalTrainer"})
        Me.cmboxStaffRoles.Location = New System.Drawing.Point(69, 30)
        Me.cmboxStaffRoles.Name = "cmboxStaffRoles"
        Me.cmboxStaffRoles.Size = New System.Drawing.Size(191, 24)
        Me.cmboxStaffRoles.TabIndex = 37
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(21, 33)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(43, 16)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "Role :"
        '
        'btnStaffDelete
        '
        Me.btnStaffDelete.Location = New System.Drawing.Point(171, 88)
        Me.btnStaffDelete.Name = "btnStaffDelete"
        Me.btnStaffDelete.Size = New System.Drawing.Size(91, 23)
        Me.btnStaffDelete.TabIndex = 1
        Me.btnStaffDelete.Text = "Delete"
        Me.btnStaffDelete.UseVisualStyleBackColor = True
        '
        'btnStaffModify
        '
        Me.btnStaffModify.Location = New System.Drawing.Point(43, 88)
        Me.btnStaffModify.Name = "btnStaffModify"
        Me.btnStaffModify.Size = New System.Drawing.Size(91, 23)
        Me.btnStaffModify.TabIndex = 0
        Me.btnStaffModify.Text = "Modify"
        Me.btnStaffModify.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox5.Controls.Add(Me.txtStaffEmail)
        Me.GroupBox5.Controls.Add(Me.cmboxStaffRole)
        Me.GroupBox5.Controls.Add(Me.txtStaffSalary)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.btnStaffCancel)
        Me.GroupBox5.Controls.Add(Me.btnStaffSave)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtStaffAddress)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.dateStaffEnd)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtStaffPhone)
        Me.GroupBox5.Controls.Add(Me.txtStaffSurname)
        Me.GroupBox5.Controls.Add(Me.txtStaffName)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(704, 222)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Add Tech Staff"
        '
        'txtStaffEmail
        '
        Me.txtStaffEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffEmail.Location = New System.Drawing.Point(99, 73)
        Me.txtStaffEmail.Name = "txtStaffEmail"
        Me.txtStaffEmail.Size = New System.Drawing.Size(143, 20)
        Me.txtStaffEmail.TabIndex = 35
        '
        'cmboxStaffRole
        '
        Me.cmboxStaffRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxStaffRole.FormattingEnabled = True
        Me.cmboxStaffRole.Items.AddRange(New Object() {"Coach", "AssistantCoach", "PhysicalTrainer", "Scout", "Doctor"})
        Me.cmboxStaffRole.Location = New System.Drawing.Point(407, 137)
        Me.cmboxStaffRole.Name = "cmboxStaffRole"
        Me.cmboxStaffRole.Size = New System.Drawing.Size(143, 24)
        Me.cmboxStaffRole.TabIndex = 34
        '
        'txtStaffSalary
        '
        Me.txtStaffSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffSalary.Location = New System.Drawing.Point(407, 104)
        Me.txtStaffSalary.Name = "txtStaffSalary"
        Me.txtStaffSalary.Size = New System.Drawing.Size(143, 20)
        Me.txtStaffSalary.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(309, 178)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 16)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "End Date :"
        '
        'btnStaffCancel
        '
        Me.btnStaffCancel.Location = New System.Drawing.Point(589, 192)
        Me.btnStaffCancel.Name = "btnStaffCancel"
        Me.btnStaffCancel.Size = New System.Drawing.Size(107, 23)
        Me.btnStaffCancel.TabIndex = 31
        Me.btnStaffCancel.Text = "Cancel"
        Me.btnStaffCancel.UseVisualStyleBackColor = True
        '
        'btnStaffSave
        '
        Me.btnStaffSave.Location = New System.Drawing.Point(589, 156)
        Me.btnStaffSave.Name = "btnStaffSave"
        Me.btnStaffSave.Size = New System.Drawing.Size(107, 23)
        Me.btnStaffSave.TabIndex = 30
        Me.btnStaffSave.Text = "Save"
        Me.btnStaffSave.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(309, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Role :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(309, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 16)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Monthly Salary :"
        '
        'txtStaffAddress
        '
        Me.txtStaffAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffAddress.Location = New System.Drawing.Point(99, 105)
        Me.txtStaffAddress.Multiline = True
        Me.txtStaffAddress.Name = "txtStaffAddress"
        Me.txtStaffAddress.Size = New System.Drawing.Size(193, 91)
        Me.txtStaffAddress.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 16)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Address :"
        '
        'dateStaffEnd
        '
        Me.dateStaffEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateStaffEnd.Location = New System.Drawing.Point(407, 174)
        Me.dateStaffEnd.Name = "dateStaffEnd"
        Me.dateStaffEnd.Size = New System.Drawing.Size(143, 20)
        Me.dateStaffEnd.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 16)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Email :"
        '
        'txtStaffPhone
        '
        Me.txtStaffPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffPhone.Location = New System.Drawing.Point(407, 72)
        Me.txtStaffPhone.Name = "txtStaffPhone"
        Me.txtStaffPhone.Size = New System.Drawing.Size(143, 20)
        Me.txtStaffPhone.TabIndex = 21
        '
        'txtStaffSurname
        '
        Me.txtStaffSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffSurname.Location = New System.Drawing.Point(407, 30)
        Me.txtStaffSurname.Name = "txtStaffSurname"
        Me.txtStaffSurname.Size = New System.Drawing.Size(143, 20)
        Me.txtStaffSurname.TabIndex = 20
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffName.Location = New System.Drawing.Point(99, 30)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(143, 20)
        Me.txtStaffName.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(309, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 16)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Phone No :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(309, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 16)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Surname :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(27, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 16)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Name :"
        '
        'TabPageFanAdd
        '
        Me.TabPageFanAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageFanAdd.Controls.Add(Me.GroupBox14)
        Me.TabPageFanAdd.Controls.Add(Me.GroupBox3)
        Me.TabPageFanAdd.Location = New System.Drawing.Point(4, 25)
        Me.TabPageFanAdd.Name = "TabPageFanAdd"
        Me.TabPageFanAdd.Size = New System.Drawing.Size(1213, 229)
        Me.TabPageFanAdd.TabIndex = 3
        Me.TabPageFanAdd.Text = "Fan Membership"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.btnFanRenew)
        Me.GroupBox14.Controls.Add(Me.btnFanIDEdit)
        Me.GroupBox14.Controls.Add(Me.txtFanIDEdit)
        Me.GroupBox14.Controls.Add(Me.Label34)
        Me.GroupBox14.Controls.Add(Me.btnFanDelete)
        Me.GroupBox14.Controls.Add(Me.btnFanModify)
        Me.GroupBox14.Location = New System.Drawing.Point(747, 14)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(449, 130)
        Me.GroupBox14.TabIndex = 3
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Manage Details"
        '
        'btnFanRenew
        '
        Me.btnFanRenew.Location = New System.Drawing.Point(7, 95)
        Me.btnFanRenew.Name = "btnFanRenew"
        Me.btnFanRenew.Size = New System.Drawing.Size(91, 23)
        Me.btnFanRenew.TabIndex = 16
        Me.btnFanRenew.Text = "Renew"
        Me.btnFanRenew.UseVisualStyleBackColor = True
        '
        'btnFanIDEdit
        '
        Me.btnFanIDEdit.Location = New System.Drawing.Point(243, 32)
        Me.btnFanIDEdit.Name = "btnFanIDEdit"
        Me.btnFanIDEdit.Size = New System.Drawing.Size(91, 23)
        Me.btnFanIDEdit.TabIndex = 7
        Me.btnFanIDEdit.Text = "Search"
        Me.btnFanIDEdit.UseVisualStyleBackColor = True
        '
        'txtFanIDEdit
        '
        Me.txtFanIDEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFanIDEdit.Location = New System.Drawing.Point(104, 35)
        Me.txtFanIDEdit.Name = "txtFanIDEdit"
        Me.txtFanIDEdit.Size = New System.Drawing.Size(103, 20)
        Me.txtFanIDEdit.TabIndex = 6
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(45, 35)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 16)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "Fan ID :"
        '
        'btnFanDelete
        '
        Me.btnFanDelete.Location = New System.Drawing.Point(243, 93)
        Me.btnFanDelete.Name = "btnFanDelete"
        Me.btnFanDelete.Size = New System.Drawing.Size(91, 23)
        Me.btnFanDelete.TabIndex = 1
        Me.btnFanDelete.Text = "Delete"
        Me.btnFanDelete.UseVisualStyleBackColor = True
        '
        'btnFanModify
        '
        Me.btnFanModify.Location = New System.Drawing.Point(117, 93)
        Me.btnFanModify.Name = "btnFanModify"
        Me.btnFanModify.Size = New System.Drawing.Size(91, 23)
        Me.btnFanModify.TabIndex = 0
        Me.btnFanModify.Text = "Modify"
        Me.btnFanModify.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnFanCancel)
        Me.GroupBox3.Controls.Add(Me.btnFanSave)
        Me.GroupBox3.Controls.Add(Me.lstboxFanCat)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtFanAddress)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.dateFanDoB)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtFanPhone)
        Me.GroupBox3.Controls.Add(Me.txtFanSurname)
        Me.GroupBox3.Controls.Add(Me.txtFanName)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 204)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Fan"
        '
        'btnFanCancel
        '
        Me.btnFanCancel.Location = New System.Drawing.Point(555, 156)
        Me.btnFanCancel.Name = "btnFanCancel"
        Me.btnFanCancel.Size = New System.Drawing.Size(107, 23)
        Me.btnFanCancel.TabIndex = 15
        Me.btnFanCancel.Text = "Cancel"
        Me.btnFanCancel.UseVisualStyleBackColor = True
        '
        'btnFanSave
        '
        Me.btnFanSave.Location = New System.Drawing.Point(555, 117)
        Me.btnFanSave.Name = "btnFanSave"
        Me.btnFanSave.Size = New System.Drawing.Size(107, 23)
        Me.btnFanSave.TabIndex = 14
        Me.btnFanSave.Text = "Save"
        Me.btnFanSave.UseVisualStyleBackColor = True
        '
        'lstboxFanCat
        '
        Me.lstboxFanCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxFanCat.FormattingEnabled = True
        Me.lstboxFanCat.Items.AddRange(New Object() {"Gold", "Silver", "Bronze"})
        Me.lstboxFanCat.Location = New System.Drawing.Point(371, 138)
        Me.lstboxFanCat.Name = "lstboxFanCat"
        Me.lstboxFanCat.Size = New System.Drawing.Size(147, 43)
        Me.lstboxFanCat.TabIndex = 13
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdoFanFemale)
        Me.GroupBox4.Controls.Add(Me.rdoFanMale)
        Me.GroupBox4.Location = New System.Drawing.Point(371, 88)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(147, 40)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        '
        'rdoFanFemale
        '
        Me.rdoFanFemale.AutoSize = True
        Me.rdoFanFemale.Location = New System.Drawing.Point(69, 15)
        Me.rdoFanFemale.Name = "rdoFanFemale"
        Me.rdoFanFemale.Size = New System.Drawing.Size(72, 20)
        Me.rdoFanFemale.TabIndex = 15
        Me.rdoFanFemale.TabStop = True
        Me.rdoFanFemale.Text = "Female"
        Me.rdoFanFemale.UseVisualStyleBackColor = True
        '
        'rdoFanMale
        '
        Me.rdoFanMale.AutoSize = True
        Me.rdoFanMale.Location = New System.Drawing.Point(5, 15)
        Me.rdoFanMale.Name = "rdoFanMale"
        Me.rdoFanMale.Size = New System.Drawing.Size(56, 20)
        Me.rdoFanMale.TabIndex = 14
        Me.rdoFanMale.TabStop = True
        Me.rdoFanMale.Text = "Male"
        Me.rdoFanMale.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(291, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Category :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(291, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Gender :"
        '
        'txtFanAddress
        '
        Me.txtFanAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFanAddress.Location = New System.Drawing.Point(83, 95)
        Me.txtFanAddress.Multiline = True
        Me.txtFanAddress.Name = "txtFanAddress"
        Me.txtFanAddress.Size = New System.Drawing.Size(193, 91)
        Me.txtFanAddress.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Address :"
        '
        'dateFanDoB
        '
        Me.dateFanDoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFanDoB.Location = New System.Drawing.Point(83, 59)
        Me.dateFanDoB.Name = "dateFanDoB"
        Me.dateFanDoB.Size = New System.Drawing.Size(181, 20)
        Me.dateFanDoB.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "DoB :"
        '
        'txtFanPhone
        '
        Me.txtFanPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFanPhone.Location = New System.Drawing.Point(371, 61)
        Me.txtFanPhone.Name = "txtFanPhone"
        Me.txtFanPhone.Size = New System.Drawing.Size(143, 20)
        Me.txtFanPhone.TabIndex = 5
        '
        'txtFanSurname
        '
        Me.txtFanSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFanSurname.Location = New System.Drawing.Point(371, 20)
        Me.txtFanSurname.Name = "txtFanSurname"
        Me.txtFanSurname.Size = New System.Drawing.Size(143, 20)
        Me.txtFanSurname.TabIndex = 4
        '
        'txtFanName
        '
        Me.txtFanName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFanName.Location = New System.Drawing.Point(83, 20)
        Me.txtFanName.Name = "txtFanName"
        Me.txtFanName.Size = New System.Drawing.Size(181, 20)
        Me.txtFanName.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(291, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Phone No :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(291, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Surname :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Name :"
        '
        'TabPageFin
        '
        Me.TabPageFin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageFin.Controls.Add(Me.dataGridFinance)
        Me.TabPageFin.Controls.Add(Me.GroupBox24)
        Me.TabPageFin.Controls.Add(Me.GroupBox23)
        Me.TabPageFin.Controls.Add(Me.TabControl3)
        Me.TabPageFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageFin.Location = New System.Drawing.Point(4, 25)
        Me.TabPageFin.Name = "TabPageFin"
        Me.TabPageFin.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFin.Size = New System.Drawing.Size(1232, 490)
        Me.TabPageFin.TabIndex = 1
        Me.TabPageFin.Text = "Finances"
        '
        'dataGridFinance
        '
        Me.dataGridFinance.AllowUserToAddRows = False
        Me.dataGridFinance.AllowUserToDeleteRows = False
        Me.dataGridFinance.AllowUserToOrderColumns = True
        Me.dataGridFinance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridFinance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridFinance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.dataGridFinance.Location = New System.Drawing.Point(501, 40)
        Me.dataGridFinance.Name = "dataGridFinance"
        Me.dataGridFinance.ReadOnly = True
        Me.dataGridFinance.RowHeadersVisible = False
        Me.dataGridFinance.Size = New System.Drawing.Size(715, 427)
        Me.dataGridFinance.TabIndex = 3
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nation"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "JerseyNo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Salary"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Years "
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.Button53)
        Me.GroupBox24.Controls.Add(Me.lstFinanceReports)
        Me.GroupBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox24.Location = New System.Drawing.Point(5, 367)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(472, 100)
        Me.GroupBox24.TabIndex = 2
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Reporting"
        '
        'Button53
        '
        Me.Button53.Location = New System.Drawing.Point(331, 45)
        Me.Button53.Name = "Button53"
        Me.Button53.Size = New System.Drawing.Size(120, 23)
        Me.Button53.TabIndex = 13
        Me.Button53.Text = "Display Report"
        Me.Button53.UseVisualStyleBackColor = True
        '
        'lstFinanceReports
        '
        Me.lstFinanceReports.FormattingEnabled = True
        Me.lstFinanceReports.ItemHeight = 16
        Me.lstFinanceReports.Items.AddRange(New Object() {"Club Income vs Expense", "Club Fan Membership Revenue", "List Players' Salaries (end-month payment) ", "List Tech-Staff' Salaries (end-month payment)", "Club Sponsor List", ""})
        Me.lstFinanceReports.Location = New System.Drawing.Point(7, 21)
        Me.lstFinanceReports.Name = "lstFinanceReports"
        Me.lstFinanceReports.Size = New System.Drawing.Size(304, 68)
        Me.lstFinanceReports.TabIndex = 0
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.btnListSponsors)
        Me.GroupBox23.Controls.Add(Me.btnListStaffSalaries)
        Me.GroupBox23.Controls.Add(Me.btnListPlayerSalaries)
        Me.GroupBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox23.Location = New System.Drawing.Point(5, 246)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(472, 100)
        Me.GroupBox23.TabIndex = 1
        Me.GroupBox23.TabStop = False
        '
        'btnListSponsors
        '
        Me.btnListSponsors.Location = New System.Drawing.Point(339, 39)
        Me.btnListSponsors.Name = "btnListSponsors"
        Me.btnListSponsors.Size = New System.Drawing.Size(105, 23)
        Me.btnListSponsors.TabIndex = 12
        Me.btnListSponsors.Text = "List Sponsors"
        Me.btnListSponsors.UseVisualStyleBackColor = True
        '
        'btnListStaffSalaries
        '
        Me.btnListStaffSalaries.Location = New System.Drawing.Point(157, 39)
        Me.btnListStaffSalaries.Name = "btnListStaffSalaries"
        Me.btnListStaffSalaries.Size = New System.Drawing.Size(153, 23)
        Me.btnListStaffSalaries.TabIndex = 11
        Me.btnListStaffSalaries.Text = "Tech Staff Salaries"
        Me.btnListStaffSalaries.UseVisualStyleBackColor = True
        '
        'btnListPlayerSalaries
        '
        Me.btnListPlayerSalaries.Location = New System.Drawing.Point(5, 39)
        Me.btnListPlayerSalaries.Name = "btnListPlayerSalaries"
        Me.btnListPlayerSalaries.Size = New System.Drawing.Size(121, 23)
        Me.btnListPlayerSalaries.TabIndex = 10
        Me.btnListPlayerSalaries.Text = "Players Salaries"
        Me.btnListPlayerSalaries.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(5, 15)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(475, 225)
        Me.TabControl3.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.dateSale)
        Me.TabPage2.Controls.Add(Me.Label46)
        Me.TabPage2.Controls.Add(Me.btnSaleCancel)
        Me.TabPage2.Controls.Add(Me.btnSaleSave)
        Me.TabPage2.Controls.Add(Me.txtSaleAmount)
        Me.TabPage2.Controls.Add(Me.Label44)
        Me.TabPage2.Controls.Add(Me.GroupBox22)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(467, 196)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Sales"
        '
        'dateSale
        '
        Me.dateSale.Location = New System.Drawing.Point(307, 82)
        Me.dateSale.Name = "dateSale"
        Me.dateSale.Size = New System.Drawing.Size(141, 22)
        Me.dateSale.TabIndex = 13
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(227, 82)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(74, 16)
        Me.Label46.TabIndex = 12
        Me.Label46.Text = "Sale Date :"
        '
        'btnSaleCancel
        '
        Me.btnSaleCancel.Location = New System.Drawing.Point(321, 144)
        Me.btnSaleCancel.Name = "btnSaleCancel"
        Me.btnSaleCancel.Size = New System.Drawing.Size(105, 23)
        Me.btnSaleCancel.TabIndex = 11
        Me.btnSaleCancel.Text = "Cancel"
        Me.btnSaleCancel.UseVisualStyleBackColor = True
        '
        'btnSaleSave
        '
        Me.btnSaleSave.Location = New System.Drawing.Point(195, 144)
        Me.btnSaleSave.Name = "btnSaleSave"
        Me.btnSaleSave.Size = New System.Drawing.Size(101, 23)
        Me.btnSaleSave.TabIndex = 10
        Me.btnSaleSave.Text = "Save"
        Me.btnSaleSave.UseVisualStyleBackColor = True
        '
        'txtSaleAmount
        '
        Me.txtSaleAmount.Location = New System.Drawing.Point(307, 28)
        Me.txtSaleAmount.Name = "txtSaleAmount"
        Me.txtSaleAmount.Size = New System.Drawing.Size(141, 22)
        Me.txtSaleAmount.TabIndex = 6
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(227, 28)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(80, 16)
        Me.Label44.TabIndex = 5
        Me.Label44.Text = "Amount (R) :"
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.rdoMerchandise)
        Me.GroupBox22.Controls.Add(Me.rdoTicket)
        Me.GroupBox22.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(215, 106)
        Me.GroupBox22.TabIndex = 0
        Me.GroupBox22.TabStop = False
        '
        'rdoMerchandise
        '
        Me.rdoMerchandise.AutoSize = True
        Me.rdoMerchandise.Location = New System.Drawing.Point(21, 60)
        Me.rdoMerchandise.Name = "rdoMerchandise"
        Me.rdoMerchandise.Size = New System.Drawing.Size(192, 20)
        Me.rdoMerchandise.TabIndex = 1
        Me.rdoMerchandise.TabStop = True
        Me.rdoMerchandise.Text = "Club Merchandise Revenue"
        Me.rdoMerchandise.UseVisualStyleBackColor = True
        '
        'rdoTicket
        '
        Me.rdoTicket.AutoSize = True
        Me.rdoTicket.Location = New System.Drawing.Point(21, 20)
        Me.rdoTicket.Name = "rdoTicket"
        Me.rdoTicket.Size = New System.Drawing.Size(188, 20)
        Me.rdoTicket.TabIndex = 0
        Me.rdoTicket.TabStop = True
        Me.rdoTicket.Text = "Match Day Ticket Revenue"
        Me.rdoTicket.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.btnSponsorCancel)
        Me.TabPage3.Controls.Add(Me.btnSponsorSave)
        Me.TabPage3.Controls.Add(Me.dateSponsorEnd)
        Me.TabPage3.Controls.Add(Me.txtSponsorIndustry)
        Me.TabPage3.Controls.Add(Me.txtSponsorFee)
        Me.TabPage3.Controls.Add(Me.txtSponsorName)
        Me.TabPage3.Controls.Add(Me.Label39)
        Me.TabPage3.Controls.Add(Me.Label38)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(467, 196)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Sponsors"
        '
        'btnSponsorCancel
        '
        Me.btnSponsorCancel.Location = New System.Drawing.Point(344, 155)
        Me.btnSponsorCancel.Name = "btnSponsorCancel"
        Me.btnSponsorCancel.Size = New System.Drawing.Size(105, 23)
        Me.btnSponsorCancel.TabIndex = 9
        Me.btnSponsorCancel.Text = "Cancel"
        Me.btnSponsorCancel.UseVisualStyleBackColor = True
        '
        'btnSponsorSave
        '
        Me.btnSponsorSave.Location = New System.Drawing.Point(217, 155)
        Me.btnSponsorSave.Name = "btnSponsorSave"
        Me.btnSponsorSave.Size = New System.Drawing.Size(101, 23)
        Me.btnSponsorSave.TabIndex = 8
        Me.btnSponsorSave.Text = "Save"
        Me.btnSponsorSave.UseVisualStyleBackColor = True
        '
        'dateSponsorEnd
        '
        Me.dateSponsorEnd.Location = New System.Drawing.Point(312, 105)
        Me.dateSponsorEnd.Name = "dateSponsorEnd"
        Me.dateSponsorEnd.Size = New System.Drawing.Size(137, 22)
        Me.dateSponsorEnd.TabIndex = 7
        Me.dateSponsorEnd.Value = New Date(2016, 10, 1, 13, 35, 35, 0)
        '
        'txtSponsorIndustry
        '
        Me.txtSponsorIndustry.Location = New System.Drawing.Point(72, 107)
        Me.txtSponsorIndustry.Name = "txtSponsorIndustry"
        Me.txtSponsorIndustry.Size = New System.Drawing.Size(100, 22)
        Me.txtSponsorIndustry.TabIndex = 6
        '
        'txtSponsorFee
        '
        Me.txtSponsorFee.Location = New System.Drawing.Point(312, 32)
        Me.txtSponsorFee.Name = "txtSponsorFee"
        Me.txtSponsorFee.Size = New System.Drawing.Size(137, 22)
        Me.txtSponsorFee.TabIndex = 5
        '
        'txtSponsorName
        '
        Me.txtSponsorName.Location = New System.Drawing.Point(72, 32)
        Me.txtSponsorName.Name = "txtSponsorName"
        Me.txtSponsorName.Size = New System.Drawing.Size(100, 22)
        Me.txtSponsorName.TabIndex = 4
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(185, 107)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(70, 16)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "End Date :"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(15, 107)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(60, 16)
        Me.Label38.TabIndex = 2
        Me.Label38.Text = "Industry :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(185, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Sponsorship (Ann):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name :"
        '
        'TabPageMan
        '
        Me.TabPageMan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageMan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageMan.Controls.Add(Me.GroupBox13)
        Me.TabPageMan.Controls.Add(Me.dataGridMan)
        Me.TabPageMan.Controls.Add(Me.GroupBox11)
        Me.TabPageMan.Location = New System.Drawing.Point(4, 25)
        Me.TabPageMan.Name = "TabPageMan"
        Me.TabPageMan.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMan.Size = New System.Drawing.Size(1232, 490)
        Me.TabPageMan.TabIndex = 2
        Me.TabPageMan.Text = "Management Info"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Button2)
        Me.GroupBox13.Controls.Add(Me.lstManSummaryReport)
        Me.GroupBox13.Location = New System.Drawing.Point(16, 164)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(347, 128)
        Me.GroupBox13.TabIndex = 2
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Summary Reports"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(238, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Show Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lstManSummaryReport
        '
        Me.lstManSummaryReport.FormattingEnabled = True
        Me.lstManSummaryReport.ItemHeight = 16
        Me.lstManSummaryReport.Items.AddRange(New Object() {"Players Summary Report", "Fans Summary Report", "Club Income vs Expense", "Club Fans Revenue Report"})
        Me.lstManSummaryReport.Location = New System.Drawing.Point(6, 38)
        Me.lstManSummaryReport.Name = "lstManSummaryReport"
        Me.lstManSummaryReport.Size = New System.Drawing.Size(226, 68)
        Me.lstManSummaryReport.TabIndex = 0
        '
        'dataGridMan
        '
        Me.dataGridMan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridMan.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridMan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataGridMan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridMan.Location = New System.Drawing.Point(369, 21)
        Me.dataGridMan.Name = "dataGridMan"
        Me.dataGridMan.Size = New System.Drawing.Size(853, 432)
        Me.dataGridMan.TabIndex = 1
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Button3)
        Me.GroupBox11.Controls.Add(Me.Button1)
        Me.GroupBox11.Controls.Add(Me.lstManListReport)
        Me.GroupBox11.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(347, 126)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Lists Reports"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(238, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Display List"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(238, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstManListReport
        '
        Me.lstManListReport.FormattingEnabled = True
        Me.lstManListReport.ItemHeight = 16
        Me.lstManListReport.Items.AddRange(New Object() {"Player List", "Tech Staff List", "Injury List", "Transfer List", "Scout List", "Sponsor List", "Tech Staff Salary List", "Players Salary List"})
        Me.lstManListReport.Location = New System.Drawing.Point(6, 38)
        Me.lstManListReport.Name = "lstManListReport"
        Me.lstManListReport.Size = New System.Drawing.Size(226, 68)
        Me.lstManListReport.TabIndex = 0
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmFCMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1257, 658)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFCMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Football Club Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.TabPageHR.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPagePlayerView.ResumeLayout(False)
        CType(Me.dgvPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabPageStaffView.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dataGridStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.TabPageMedView.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        CType(Me.dataGridInjured, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.TabPageTransView.ResumeLayout(False)
        Me.groupTranfer.ResumeLayout(False)
        Me.groupScout.ResumeLayout(False)
        CType(Me.dataGridTransfers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.TabPageFanView.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dataGridFan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPagePlayerAdd.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.picboxPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageStaffAdd.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPageFanAdd.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPageFin.ResumeLayout(False)
        CType(Me.dataGridFinance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPageMan.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        CType(Me.dataGridMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPageHR As System.Windows.Forms.TabPage
    Friend WithEvents TabPageFin As System.Windows.Forms.TabPage
    Friend WithEvents TabPageMan As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPagePlayerView As System.Windows.Forms.TabPage
    Friend WithEvents TabPageStaffView As System.Windows.Forms.TabPage
    Friend WithEvents TabPageMedView As System.Windows.Forms.TabPage
    Friend WithEvents TabPageTransView As System.Windows.Forms.TabPage
    Friend WithEvents TabPageFanView As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPagePlayerAdd As System.Windows.Forms.TabPage
    Friend WithEvents TabPageStaffAdd As System.Windows.Forms.TabPage
    Friend WithEvents TabPageFanAdd As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFanAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dateFanDoB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFanPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtFanSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFanName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnFanCancel As System.Windows.Forms.Button
    Friend WithEvents btnFanSave As System.Windows.Forms.Button
    Friend WithEvents lstboxFanCat As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoFanFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFanMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPlayerValue As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayerSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtPlayerEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnPlayerCancel As System.Windows.Forms.Button
    Friend WithEvents btnPlayerSave As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPlayerAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents datePlayerDoB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtPlayerPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayerSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStaffEmail As System.Windows.Forms.TextBox
    Friend WithEvents cmboxStaffRole As System.Windows.Forms.ComboBox
    Friend WithEvents txtStaffSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnStaffCancel As System.Windows.Forms.Button
    Friend WithEvents btnStaffSave As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtStaffAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dateStaffEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtStaffPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtStaffSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtStaffName As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmboxPlayerNation As System.Windows.Forms.ComboBox
    Friend WithEvents datePlayerEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnPlayerImage As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddtoInjured As System.Windows.Forms.Button
    Friend WithEvents btnAddtoTransfer As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPlayerDelete As System.Windows.Forms.Button
    Friend WithEvents btnPlayerModify As System.Windows.Forms.Button
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStaffDelete As System.Windows.Forms.Button
    Friend WithEvents btnStaffModify As System.Windows.Forms.Button
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picboxPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPlayerSearch As System.Windows.Forms.Button
    Friend WithEvents btnPlayerClear As System.Windows.Forms.Button
    Friend WithEvents btnPlayerGetAll As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtPlayerByJerseyNo As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtPlayerByName As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmboxStaffRoles As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFanIDEdit As System.Windows.Forms.Button
    Friend WithEvents txtFanIDEdit As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents btnFanDelete As System.Windows.Forms.Button
    Friend WithEvents btnFanModify As System.Windows.Forms.Button
    Friend WithEvents cmboxPlayerPosition As System.Windows.Forms.ComboBox
    Friend WithEvents dataGridStaff As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStaffSearch As System.Windows.Forms.Button
    Friend WithEvents btnStaffClear As System.Windows.Forms.Button
    Friend WithEvents btnStaffGetAll As System.Windows.Forms.Button
    Friend WithEvents txtStaffByRole As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents dataGridInjured As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents btnInjuredUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInjuredCancel As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtInjuredDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents dataGridTransfers As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridFan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFanSearch As System.Windows.Forms.Button
    Friend WithEvents btnFanClear As System.Windows.Forms.Button
    Friend WithEvents btnFanGetAll As System.Windows.Forms.Button
    Friend WithEvents txtFanByID As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtFanByName As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStaffSummaryReport As System.Windows.Forms.Button
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents btnInjuredReport As System.Windows.Forms.Button
    Friend WithEvents btnInjuredRemove As System.Windows.Forms.Button
    Friend WithEvents dateInjuredEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents groupTranfer As System.Windows.Forms.GroupBox
    Friend WithEvents btnTransferRelease As System.Windows.Forms.Button
    Friend WithEvents btnTransferRetain As System.Windows.Forms.Button
    Friend WithEvents groupScout As System.Windows.Forms.GroupBox
    Friend WithEvents btnScoutRegister As System.Windows.Forms.Button
    Friend WithEvents btnScoutAdd As System.Windows.Forms.Button
    Friend WithEvents rdoScoutList As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTransferList As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFanSummaryReport As System.Windows.Forms.Button
    Friend WithEvents dataGridFinance As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Friend WithEvents Button53 As System.Windows.Forms.Button
    Friend WithEvents lstFinanceReports As System.Windows.Forms.ListBox
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnSaleCancel As System.Windows.Forms.Button
    Friend WithEvents btnSaleSave As System.Windows.Forms.Button
    Friend WithEvents txtSaleAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoMerchandise As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTicket As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnSponsorCancel As System.Windows.Forms.Button
    Friend WithEvents btnSponsorSave As System.Windows.Forms.Button
    Friend WithEvents dateSponsorEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSponsorIndustry As System.Windows.Forms.TextBox
    Friend WithEvents txtSponsorFee As System.Windows.Forms.TextBox
    Friend WithEvents txtSponsorName As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnPlayerReport As System.Windows.Forms.Button
    Friend WithEvents btnPlayerSummaryReport As System.Windows.Forms.Button
    Friend WithEvents btnTransferReport As System.Windows.Forms.Button
    Friend WithEvents btnScoutReport As System.Windows.Forms.Button
    Friend WithEvents cmboxPlayerIDs As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents btnListSponsors As System.Windows.Forms.Button
    Friend WithEvents btnListStaffSalaries As System.Windows.Forms.Button
    Friend WithEvents btnListPlayerSalaries As System.Windows.Forms.Button
    Friend WithEvents ManageUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnJerseyNoAvail As System.Windows.Forms.Button
    Friend WithEvents txtPlayerJerseyNo As System.Windows.Forms.TextBox
    Friend WithEvents btnFanRenew As System.Windows.Forms.Button
    Friend WithEvents dgvPlayer As System.Windows.Forms.DataGridView
    Friend WithEvents pName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pSurname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pAge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pNation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pJersey As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pPosition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pSalary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pYearsLeft As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fanExpired As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Role As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContractYears As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transJerseyNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transYearsLeft As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateSale As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diagnosis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmboInjuredIDs As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lstManSummaryReport As System.Windows.Forms.ListBox
    Friend WithEvents dataGridMan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstManListReport As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackUpDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmboByPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As Label
End Class
