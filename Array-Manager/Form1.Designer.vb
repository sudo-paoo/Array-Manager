<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        HopeForm1 = New ReaLTaiizor.Forms.HopeForm()
        pnlSetArraySize = New Panel()
        Panel2 = New Panel()
        btnInitializeArray = New FontAwesome.Sharp.IconButton()
        txtArraySize = New NumericUpDown()
        Label8 = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        pnlArrayManager = New Panel()
        pnlMain = New Panel()
        gbxDelete = New ReaLTaiizor.Controls.HopeGroupBox()
        btnDeleteAll = New FontAwesome.Sharp.IconButton()
        btnDelete = New FontAwesome.Sharp.IconButton()
        Label7 = New Label()
        txtDelete = New ReaLTaiizor.Controls.HopeTextBox()
        gbxFind = New ReaLTaiizor.Controls.HopeGroupBox()
        btnFind = New FontAwesome.Sharp.IconButton()
        btnFindAll = New FontAwesome.Sharp.IconButton()
        Label4 = New Label()
        txtFind = New ReaLTaiizor.Controls.HopeTextBox()
        gbxAdd = New ReaLTaiizor.Controls.HopeGroupBox()
        btnAdd = New FontAwesome.Sharp.IconButton()
        txtAdd = New ReaLTaiizor.Controls.HopeTextBox()
        Label2 = New Label()
        HopeGroupBox2 = New ReaLTaiizor.Controls.HopeGroupBox()
        lbxValues = New ListBox()
        HopeGroupBox1 = New ReaLTaiizor.Controls.HopeGroupBox()
        icnOrder = New FontAwesome.Sharp.IconPictureBox()
        Label5 = New Label()
        lblArraySize = New Label()
        Label3 = New Label()
        pnlHeader = New Panel()
        btnSettings = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        pnlSettings = New Panel()
        Label10 = New Label()
        btnCloseSettings = New FontAwesome.Sharp.IconPictureBox()
        btnExit = New FontAwesome.Sharp.IconButton()
        btnReset = New FontAwesome.Sharp.IconButton()
        rbtnDescending = New ReaLTaiizor.Controls.HopeRadioButton()
        rbtnAscending = New ReaLTaiizor.Controls.HopeRadioButton()
        rbtnNone = New ReaLTaiizor.Controls.HopeRadioButton()
        Label9 = New Label()
        pnlSetArraySize.SuspendLayout()
        Panel2.SuspendLayout()
        CType(txtArraySize, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        pnlArrayManager.SuspendLayout()
        pnlMain.SuspendLayout()
        gbxDelete.SuspendLayout()
        gbxFind.SuspendLayout()
        gbxAdd.SuspendLayout()
        HopeGroupBox2.SuspendLayout()
        HopeGroupBox1.SuspendLayout()
        CType(icnOrder, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        pnlSettings.SuspendLayout()
        CType(btnCloseSettings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HopeForm1
        ' 
        HopeForm1.ControlBoxColorH = Color.FromArgb(CByte(228), CByte(231), CByte(237))
        HopeForm1.ControlBoxColorHC = Color.FromArgb(CByte(245), CByte(108), CByte(108))
        HopeForm1.ControlBoxColorN = Color.White
        HopeForm1.Dock = DockStyle.Top
        HopeForm1.Font = New Font("Segoe UI", 12F)
        HopeForm1.ForeColor = Color.FromArgb(CByte(242), CByte(246), CByte(252))
        HopeForm1.Image = Nothing
        HopeForm1.Location = New Point(0, 0)
        HopeForm1.MaximizeBox = False
        HopeForm1.Name = "HopeForm1"
        HopeForm1.Size = New Size(650, 40)
        HopeForm1.TabIndex = 0
        HopeForm1.Text = "Array Manager"
        HopeForm1.ThemeColor = Color.FromArgb(CByte(92), CByte(173), CByte(255))
        ' 
        ' pnlSetArraySize
        ' 
        pnlSetArraySize.Controls.Add(Panel2)
        pnlSetArraySize.Controls.Add(Panel1)
        pnlSetArraySize.Dock = DockStyle.Fill
        pnlSetArraySize.Location = New Point(0, 40)
        pnlSetArraySize.Name = "pnlSetArraySize"
        pnlSetArraySize.Size = New Size(650, 710)
        pnlSetArraySize.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnInitializeArray)
        Panel2.Controls.Add(txtArraySize)
        Panel2.Controls.Add(Label8)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 65)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(650, 645)
        Panel2.TabIndex = 2
        ' 
        ' btnInitializeArray
        ' 
        btnInitializeArray.BackColor = Color.FromArgb(CByte(33), CByte(82), CByte(217))
        btnInitializeArray.FlatAppearance.BorderSize = 0
        btnInitializeArray.FlatStyle = FlatStyle.Flat
        btnInitializeArray.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnInitializeArray.ForeColor = Color.White
        btnInitializeArray.IconChar = FontAwesome.Sharp.IconChar.None
        btnInitializeArray.IconColor = Color.White
        btnInitializeArray.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnInitializeArray.IconSize = 1
        btnInitializeArray.ImageAlign = ContentAlignment.BottomLeft
        btnInitializeArray.Location = New Point(503, 43)
        btnInitializeArray.Name = "btnInitializeArray"
        btnInitializeArray.Size = New Size(138, 44)
        btnInitializeArray.TabIndex = 4
        btnInitializeArray.Text = "Set Size"
        btnInitializeArray.TextAlign = ContentAlignment.MiddleRight
        btnInitializeArray.TextImageRelation = TextImageRelation.TextBeforeImage
        btnInitializeArray.UseVisualStyleBackColor = False
        ' 
        ' txtArraySize
        ' 
        txtArraySize.Font = New Font("Segoe UI", 13.8F)
        txtArraySize.Location = New Point(18, 48)
        txtArraySize.Name = "txtArraySize"
        txtArraySize.Size = New Size(479, 38)
        txtArraySize.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Label8.Location = New Point(18, 15)
        Label8.Name = "Label8"
        Label8.Size = New Size(214, 25)
        Label8.TabIndex = 2
        Label8.Text = "Set Maximum Array Size"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label6)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(650, 65)
        Panel1.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(249, 46)
        Label6.TabIndex = 0
        Label6.Text = "Array Manager"
        ' 
        ' pnlArrayManager
        ' 
        pnlArrayManager.Controls.Add(pnlMain)
        pnlArrayManager.Controls.Add(pnlHeader)
        pnlArrayManager.Controls.Add(pnlSettings)
        pnlArrayManager.Dock = DockStyle.Fill
        pnlArrayManager.Location = New Point(0, 40)
        pnlArrayManager.Name = "pnlArrayManager"
        pnlArrayManager.Size = New Size(650, 710)
        pnlArrayManager.TabIndex = 0
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(gbxDelete)
        pnlMain.Controls.Add(gbxFind)
        pnlMain.Controls.Add(gbxAdd)
        pnlMain.Controls.Add(HopeGroupBox2)
        pnlMain.Controls.Add(HopeGroupBox1)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 65)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(650, 645)
        pnlMain.TabIndex = 1
        ' 
        ' gbxDelete
        ' 
        gbxDelete.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        gbxDelete.Controls.Add(btnDeleteAll)
        gbxDelete.Controls.Add(btnDelete)
        gbxDelete.Controls.Add(Label7)
        gbxDelete.Controls.Add(txtDelete)
        gbxDelete.Font = New Font("Segoe UI", 12F)
        gbxDelete.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        gbxDelete.LineColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        gbxDelete.Location = New Point(12, 447)
        gbxDelete.Name = "gbxDelete"
        gbxDelete.ShowText = False
        gbxDelete.Size = New Size(301, 183)
        gbxDelete.TabIndex = 3
        gbxDelete.TabStop = False
        gbxDelete.Text = "HopeGroupBox6"
        gbxDelete.ThemeColor = Color.FromArgb(CByte(248), CByte(172), CByte(172))
        ' 
        ' btnDeleteAll
        ' 
        btnDeleteAll.BackColor = Color.FromArgb(CByte(185), CByte(29), CByte(29))
        btnDeleteAll.FlatAppearance.BorderSize = 0
        btnDeleteAll.FlatStyle = FlatStyle.Flat
        btnDeleteAll.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeleteAll.ForeColor = Color.White
        btnDeleteAll.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        btnDeleteAll.IconColor = Color.White
        btnDeleteAll.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDeleteAll.IconSize = 30
        btnDeleteAll.Location = New Point(134, 119)
        btnDeleteAll.Name = "btnDeleteAll"
        btnDeleteAll.Size = New Size(161, 44)
        btnDeleteAll.TabIndex = 9
        btnDeleteAll.Text = "Delete All"
        btnDeleteAll.TextAlign = ContentAlignment.MiddleRight
        btnDeleteAll.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDeleteAll.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(185), CByte(29), CByte(29))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        btnDelete.IconColor = Color.White
        btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDelete.IconSize = 30
        btnDelete.Location = New Point(9, 119)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(119, 44)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.TextAlign = ContentAlignment.MiddleRight
        btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.Location = New Point(6, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(169, 28)
        Label7.TabIndex = 1
        Label7.Text = "Delete Number/s"
        ' 
        ' txtDelete
        ' 
        txtDelete.BackColor = Color.White
        txtDelete.BaseColor = Color.FromArgb(CByte(44), CByte(55), CByte(66))
        txtDelete.BorderColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        txtDelete.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        txtDelete.Font = New Font("Segoe UI", 12F)
        txtDelete.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        txtDelete.Hint = "Example: 5 or 1, 2, 3"
        txtDelete.Location = New Point(6, 60)
        txtDelete.MaxLength = 32767
        txtDelete.Multiline = False
        txtDelete.Name = "txtDelete"
        txtDelete.PasswordChar = ChrW(0)
        txtDelete.ScrollBars = ScrollBars.None
        txtDelete.SelectedText = ""
        txtDelete.SelectionLength = 0
        txtDelete.SelectionStart = 0
        txtDelete.Size = New Size(289, 43)
        txtDelete.TabIndex = 7
        txtDelete.TabStop = False
        txtDelete.UseSystemPasswordChar = False
        ' 
        ' gbxFind
        ' 
        gbxFind.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        gbxFind.Controls.Add(btnFind)
        gbxFind.Controls.Add(btnFindAll)
        gbxFind.Controls.Add(Label4)
        gbxFind.Controls.Add(txtFind)
        gbxFind.Font = New Font("Segoe UI", 12F)
        gbxFind.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        gbxFind.LineColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        gbxFind.Location = New Point(12, 258)
        gbxFind.Name = "gbxFind"
        gbxFind.ShowText = False
        gbxFind.Size = New Size(301, 183)
        gbxFind.TabIndex = 3
        gbxFind.TabStop = False
        gbxFind.Text = "HopeGroupBox4"
        gbxFind.ThemeColor = Color.FromArgb(CByte(173), CByte(235), CByte(194))
        ' 
        ' btnFind
        ' 
        btnFind.BackColor = Color.FromArgb(CByte(21), CByte(138), CByte(123))
        btnFind.FlatAppearance.BorderSize = 0
        btnFind.FlatStyle = FlatStyle.Flat
        btnFind.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFind.ForeColor = Color.White
        btnFind.IconChar = FontAwesome.Sharp.IconChar.Search
        btnFind.IconColor = Color.White
        btnFind.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnFind.IconSize = 30
        btnFind.Location = New Point(9, 123)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(119, 44)
        btnFind.TabIndex = 5
        btnFind.Text = "Find"
        btnFind.TextAlign = ContentAlignment.MiddleRight
        btnFind.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFind.UseVisualStyleBackColor = False
        ' 
        ' btnFindAll
        ' 
        btnFindAll.BackColor = Color.FromArgb(CByte(21), CByte(138), CByte(123))
        btnFindAll.FlatAppearance.BorderSize = 0
        btnFindAll.FlatStyle = FlatStyle.Flat
        btnFindAll.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFindAll.ForeColor = Color.White
        btnFindAll.IconChar = FontAwesome.Sharp.IconChar.Search
        btnFindAll.IconColor = Color.White
        btnFindAll.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnFindAll.IconSize = 30
        btnFindAll.Location = New Point(134, 123)
        btnFindAll.Name = "btnFindAll"
        btnFindAll.Size = New Size(161, 44)
        btnFindAll.TabIndex = 4
        btnFindAll.Text = "Find All"
        btnFindAll.TextAlign = ContentAlignment.MiddleRight
        btnFindAll.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFindAll.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(6, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 28)
        Label4.TabIndex = 1
        Label4.Text = "Find Number"
        ' 
        ' txtFind
        ' 
        txtFind.BackColor = Color.White
        txtFind.BaseColor = Color.FromArgb(CByte(44), CByte(55), CByte(66))
        txtFind.BorderColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        txtFind.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        txtFind.Font = New Font("Segoe UI", 12F)
        txtFind.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        txtFind.Hint = "Example: 5"
        txtFind.Location = New Point(6, 60)
        txtFind.MaxLength = 32767
        txtFind.Multiline = False
        txtFind.Name = "txtFind"
        txtFind.PasswordChar = ChrW(0)
        txtFind.ScrollBars = ScrollBars.None
        txtFind.SelectedText = ""
        txtFind.SelectionLength = 0
        txtFind.SelectionStart = 0
        txtFind.Size = New Size(289, 43)
        txtFind.TabIndex = 3
        txtFind.TabStop = False
        txtFind.UseSystemPasswordChar = False
        ' 
        ' gbxAdd
        ' 
        gbxAdd.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        gbxAdd.Controls.Add(btnAdd)
        gbxAdd.Controls.Add(txtAdd)
        gbxAdd.Controls.Add(Label2)
        gbxAdd.Font = New Font("Segoe UI", 12F)
        gbxAdd.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        gbxAdd.LineColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        gbxAdd.Location = New Point(12, 69)
        gbxAdd.Name = "gbxAdd"
        gbxAdd.ShowText = False
        gbxAdd.Size = New Size(301, 183)
        gbxAdd.TabIndex = 2
        gbxAdd.TabStop = False
        gbxAdd.Text = "HopeGroupBox3"
        gbxAdd.ThemeColor = Color.FromArgb(CByte(149), CByte(188), CByte(250))
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(33), CByte(82), CByte(217))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        btnAdd.IconColor = Color.White
        btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAdd.IconSize = 30
        btnAdd.Location = New Point(176, 123)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(119, 44)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.TextAlign = ContentAlignment.MiddleRight
        btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtAdd
        ' 
        txtAdd.BackColor = Color.White
        txtAdd.BaseColor = Color.FromArgb(CByte(44), CByte(55), CByte(66))
        txtAdd.BorderColorA = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        txtAdd.BorderColorB = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        txtAdd.Font = New Font("Segoe UI", 12F)
        txtAdd.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        txtAdd.Hint = "Example: 5 or 1, 2, 3"
        txtAdd.Location = New Point(6, 60)
        txtAdd.MaxLength = 32767
        txtAdd.Multiline = False
        txtAdd.Name = "txtAdd"
        txtAdd.PasswordChar = ChrW(0)
        txtAdd.ScrollBars = ScrollBars.None
        txtAdd.SelectedText = ""
        txtAdd.SelectionLength = 0
        txtAdd.SelectionStart = 0
        txtAdd.Size = New Size(289, 43)
        txtAdd.TabIndex = 1
        txtAdd.TabStop = False
        txtAdd.UseSystemPasswordChar = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(6, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 28)
        Label2.TabIndex = 0
        Label2.Text = "Add Number/s"
        ' 
        ' HopeGroupBox2
        ' 
        HopeGroupBox2.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        HopeGroupBox2.Controls.Add(lbxValues)
        HopeGroupBox2.Font = New Font("Segoe UI", 12F)
        HopeGroupBox2.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        HopeGroupBox2.LineColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        HopeGroupBox2.Location = New Point(319, 69)
        HopeGroupBox2.Name = "HopeGroupBox2"
        HopeGroupBox2.ShowText = False
        HopeGroupBox2.Size = New Size(319, 564)
        HopeGroupBox2.TabIndex = 1
        HopeGroupBox2.TabStop = False
        HopeGroupBox2.Text = "HopeGroupBox2"
        HopeGroupBox2.ThemeColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        ' 
        ' lbxValues
        ' 
        lbxValues.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbxValues.FormattingEnabled = True
        lbxValues.ItemHeight = 31
        lbxValues.Location = New Point(6, 10)
        lbxValues.Name = "lbxValues"
        lbxValues.SelectionMode = SelectionMode.MultiSimple
        lbxValues.Size = New Size(307, 531)
        lbxValues.TabIndex = 0
        ' 
        ' HopeGroupBox1
        ' 
        HopeGroupBox1.BorderColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        HopeGroupBox1.Controls.Add(icnOrder)
        HopeGroupBox1.Controls.Add(Label5)
        HopeGroupBox1.Controls.Add(lblArraySize)
        HopeGroupBox1.Controls.Add(Label3)
        HopeGroupBox1.Font = New Font("Segoe UI", 12F)
        HopeGroupBox1.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        HopeGroupBox1.LineColor = Color.FromArgb(CByte(220), CByte(223), CByte(230))
        HopeGroupBox1.Location = New Point(12, 15)
        HopeGroupBox1.Name = "HopeGroupBox1"
        HopeGroupBox1.ShowText = False
        HopeGroupBox1.Size = New Size(626, 48)
        HopeGroupBox1.TabIndex = 0
        HopeGroupBox1.TabStop = False
        HopeGroupBox1.Text = "HopeGroupBox1"
        HopeGroupBox1.ThemeColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        ' 
        ' icnOrder
        ' 
        icnOrder.BackColor = Color.Transparent
        icnOrder.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        icnOrder.IconChar = FontAwesome.Sharp.IconChar.Slash
        icnOrder.IconColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        icnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto
        icnOrder.IconSize = 40
        icnOrder.Location = New Point(580, 4)
        icnOrder.Name = "icnOrder"
        icnOrder.Size = New Size(40, 40)
        icnOrder.SizeMode = PictureBoxSizeMode.CenterImage
        icnOrder.TabIndex = 5
        icnOrder.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(510, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 27)
        Label5.TabIndex = 4
        Label5.Text = "Order:"
        ' 
        ' lblArraySize
        ' 
        lblArraySize.AutoSize = True
        lblArraySize.BackColor = Color.Transparent
        lblArraySize.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblArraySize.Location = New Point(114, 11)
        lblArraySize.Name = "lblArraySize"
        lblArraySize.Size = New Size(44, 27)
        lblArraySize.TabIndex = 3
        lblArraySize.Text = "size"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 27)
        Label3.TabIndex = 2
        Label3.Text = "Array Size:"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(btnSettings)
        pnlHeader.Controls.Add(Label1)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(650, 65)
        pnlHeader.TabIndex = 0
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.FromArgb(CByte(242), CByte(244), CByte(247))
        btnSettings.FlatAppearance.BorderSize = 0
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSettings.ForeColor = Color.FromArgb(CByte(79), CByte(86), CByte(103))
        btnSettings.IconChar = FontAwesome.Sharp.IconChar.Bars
        btnSettings.IconColor = Color.FromArgb(CByte(79), CByte(86), CByte(103))
        btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSettings.IconSize = 30
        btnSettings.Location = New Point(503, 11)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(135, 44)
        btnSettings.TabIndex = 3
        btnSettings.Text = "Settings"
        btnSettings.TextAlign = ContentAlignment.MiddleRight
        btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 46)
        Label1.TabIndex = 0
        Label1.Text = "Array Manager"
        ' 
        ' pnlSettings
        ' 
        pnlSettings.BackColor = Color.FromArgb(CByte(242), CByte(244), CByte(247), CByte(255))
        pnlSettings.Controls.Add(Label10)
        pnlSettings.Controls.Add(btnCloseSettings)
        pnlSettings.Controls.Add(btnExit)
        pnlSettings.Controls.Add(btnReset)
        pnlSettings.Controls.Add(rbtnDescending)
        pnlSettings.Controls.Add(rbtnAscending)
        pnlSettings.Controls.Add(rbtnNone)
        pnlSettings.Controls.Add(Label9)
        pnlSettings.Location = New Point(175, 116)
        pnlSettings.Name = "pnlSettings"
        pnlSettings.Size = New Size(300, 325)
        pnlSettings.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(13, 9)
        Label10.Name = "Label10"
        Label10.Size = New Size(205, 27)
        Label10.TabIndex = 12
        Label10.Text = "Array Manager Settings"
        ' 
        ' btnCloseSettings
        ' 
        btnCloseSettings.BackColor = Color.Transparent
        btnCloseSettings.ForeColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        btnCloseSettings.IconChar = FontAwesome.Sharp.IconChar.SquareXmark
        btnCloseSettings.IconColor = Color.FromArgb(CByte(48), CByte(49), CByte(51))
        btnCloseSettings.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCloseSettings.IconSize = 35
        btnCloseSettings.Location = New Point(257, 8)
        btnCloseSettings.Name = "btnCloseSettings"
        btnCloseSettings.Size = New Size(35, 35)
        btnCloseSettings.SizeMode = PictureBoxSizeMode.CenterImage
        btnCloseSettings.TabIndex = 11
        btnCloseSettings.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(185), CByte(29), CByte(29))
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.White
        btnExit.IconChar = FontAwesome.Sharp.IconChar.RightToBracket
        btnExit.IconColor = Color.White
        btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExit.IconSize = 30
        btnExit.Location = New Point(13, 251)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(273, 44)
        btnExit.TabIndex = 10
        btnExit.Text = "Exit System"
        btnExit.TextAlign = ContentAlignment.MiddleRight
        btnExit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(185), CByte(29), CByte(29))
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReset.ForeColor = Color.White
        btnReset.IconChar = FontAwesome.Sharp.IconChar.Eraser
        btnReset.IconColor = Color.White
        btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnReset.IconSize = 30
        btnReset.Location = New Point(13, 191)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(273, 44)
        btnReset.TabIndex = 9
        btnReset.Text = "Reset System"
        btnReset.TextAlign = ContentAlignment.MiddleRight
        btnReset.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' rbtnDescending
        ' 
        rbtnDescending.AutoSize = True
        rbtnDescending.BackColor = Color.FromArgb(CByte(242), CByte(244), CByte(247), CByte(255))
        rbtnDescending.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        rbtnDescending.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        rbtnDescending.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        rbtnDescending.Enable = True
        rbtnDescending.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        rbtnDescending.EnabledStringColor = Color.FromArgb(CByte(146), CByte(146), CByte(146))
        rbtnDescending.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        rbtnDescending.Font = New Font("Segoe UI", 10.8F)
        rbtnDescending.ForeColor = Color.Black
        rbtnDescending.Location = New Point(13, 140)
        rbtnDescending.MinimumSize = New Size(0, 25)
        rbtnDescending.Name = "rbtnDescending"
        rbtnDescending.Size = New Size(181, 25)
        rbtnDescending.TabIndex = 6
        rbtnDescending.TabStop = True
        rbtnDescending.Text = "Descending Order"
        rbtnDescending.UseVisualStyleBackColor = False
        ' 
        ' rbtnAscending
        ' 
        rbtnAscending.AutoSize = True
        rbtnAscending.BackColor = Color.FromArgb(CByte(242), CByte(244), CByte(247), CByte(255))
        rbtnAscending.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        rbtnAscending.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        rbtnAscending.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        rbtnAscending.Enable = True
        rbtnAscending.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        rbtnAscending.EnabledStringColor = Color.FromArgb(CByte(146), CByte(146), CByte(146))
        rbtnAscending.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        rbtnAscending.Font = New Font("Segoe UI", 10.8F)
        rbtnAscending.ForeColor = Color.Black
        rbtnAscending.Location = New Point(13, 109)
        rbtnAscending.MinimumSize = New Size(0, 25)
        rbtnAscending.Name = "rbtnAscending"
        rbtnAscending.Size = New Size(171, 25)
        rbtnAscending.TabIndex = 5
        rbtnAscending.TabStop = True
        rbtnAscending.Text = "Ascending Order"
        rbtnAscending.UseVisualStyleBackColor = False
        ' 
        ' rbtnNone
        ' 
        rbtnNone.AutoSize = True
        rbtnNone.BackColor = Color.FromArgb(CByte(242), CByte(244), CByte(247), CByte(255))
        rbtnNone.CheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        rbtnNone.DisabledColor = Color.FromArgb(CByte(196), CByte(198), CByte(202))
        rbtnNone.DisabledStringColor = Color.FromArgb(CByte(186), CByte(187), CByte(189))
        rbtnNone.Enable = True
        rbtnNone.EnabledCheckedColor = Color.FromArgb(CByte(64), CByte(158), CByte(255))
        rbtnNone.EnabledStringColor = Color.FromArgb(CByte(146), CByte(146), CByte(146))
        rbtnNone.EnabledUncheckedColor = Color.FromArgb(CByte(156), CByte(158), CByte(161))
        rbtnNone.Font = New Font("Segoe UI", 10.8F)
        rbtnNone.ForeColor = Color.Black
        rbtnNone.Location = New Point(13, 78)
        rbtnNone.MinimumSize = New Size(0, 25)
        rbtnNone.Name = "rbtnNone"
        rbtnNone.Size = New Size(80, 25)
        rbtnNone.TabIndex = 4
        rbtnNone.TabStop = True
        rbtnNone.Text = "None"
        rbtnNone.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(13, 48)
        Label9.Name = "Label9"
        Label9.Size = New Size(114, 24)
        Label9.TabIndex = 3
        Label9.Text = "Display Order:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(650, 750)
        Controls.Add(pnlArrayManager)
        Controls.Add(pnlSetArraySize)
        Controls.Add(HopeForm1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MaximumSize = New Size(1920, 1020)
        MinimumSize = New Size(190, 40)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        pnlSetArraySize.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(txtArraySize, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlArrayManager.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        gbxDelete.ResumeLayout(False)
        gbxDelete.PerformLayout()
        gbxFind.ResumeLayout(False)
        gbxFind.PerformLayout()
        gbxAdd.ResumeLayout(False)
        gbxAdd.PerformLayout()
        HopeGroupBox2.ResumeLayout(False)
        HopeGroupBox1.ResumeLayout(False)
        HopeGroupBox1.PerformLayout()
        CType(icnOrder, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSettings.ResumeLayout(False)
        pnlSettings.PerformLayout()
        CType(btnCloseSettings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents HopeForm1 As ReaLTaiizor.Forms.HopeForm
    Friend WithEvents pnlSetArraySize As Panel
    Friend WithEvents pnlArrayManager As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents HopeGroupBox1 As ReaLTaiizor.Controls.HopeGroupBox
    Friend WithEvents icnOrder As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblArraySize As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HopeGroupBox2 As ReaLTaiizor.Controls.HopeGroupBox
    Friend WithEvents gbxDelete As ReaLTaiizor.Controls.HopeGroupBox
    Friend WithEvents gbxFind As ReaLTaiizor.Controls.HopeGroupBox
    Friend WithEvents gbxAdd As ReaLTaiizor.Controls.HopeGroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents txtAdd As ReaLTaiizor.Controls.HopeTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents txtDelete As ReaLTaiizor.Controls.HopeTextBox
    Friend WithEvents btnFindAll As FontAwesome.Sharp.IconButton
    Friend WithEvents txtFind As ReaLTaiizor.Controls.HopeTextBox
    Friend WithEvents lbxValues As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnInitializeArray As FontAwesome.Sharp.IconButton
    Friend WithEvents txtArraySize As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSettings As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFind As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteAll As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents btnReset As FontAwesome.Sharp.IconButton
    Friend WithEvents rbtnDescending As ReaLTaiizor.Controls.HopeRadioButton
    Friend WithEvents rbtnAscending As ReaLTaiizor.Controls.HopeRadioButton
    Friend WithEvents rbtnNone As ReaLTaiizor.Controls.HopeRadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCloseSettings As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label10 As Label

End Class
