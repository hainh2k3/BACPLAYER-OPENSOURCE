<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Thứ hai")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Thứ ba")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Thứ tư")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Thứ năm")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Thứ sáu")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Thứ bảy")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chủ nhật")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cả Tuần", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gThuMuc = New System.Windows.Forms.GroupBox()
        Me.treeThuMuc = New System.Windows.Forms.TreeView()
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.cmbTrangThai = New System.Windows.Forms.ComboBox()
        Me.lstTask = New System.Windows.Forms.ListView()
        Me.colTen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTiepTheo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDaChay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNgayTao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mDungHoacHoatDong = New System.Windows.Forms.ToolStripMenuItem()
        Me.gDsBaiHat = New System.Windows.Forms.GroupBox()
        Me.lstMp3 = New System.Windows.Forms.ListView()
        Me.tt2 = New System.Windows.Forms.ToolStrip()
        Me.btnThemNhac = New System.Windows.Forms.ToolStripButton()
        Me.btnXoaNhac = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnUp = New System.Windows.Forms.ToolStripButton()
        Me.btnDown = New System.Windows.Forms.ToolStripButton()
        Me.gChiTietCauHinh = New System.Windows.Forms.GroupBox()
        Me.txtKetThuc = New System.Windows.Forms.DateTimePicker()
        Me.chkTatMay = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkChuNhat = New System.Windows.Forms.CheckBox()
        Me.chkThuBay = New System.Windows.Forms.CheckBox()
        Me.chkThuSau = New System.Windows.Forms.CheckBox()
        Me.chkThuNam = New System.Windows.Forms.CheckBox()
        Me.chkThuTu = New System.Windows.Forms.CheckBox()
        Me.chkThuBa = New System.Windows.Forms.CheckBox()
        Me.chkThuHai = New System.Windows.Forms.CheckBox()
        Me.btnBatDau = New System.Windows.Forms.Button()
        Me.chkPhatNgauNhien = New System.Windows.Forms.CheckBox()
        Me.txtThoiGian = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBatDau = New System.Windows.Forms.DateTimePicker()
        Me.chkDangHoatDong = New System.Windows.Forms.CheckBox()
        Me.txtMoTa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTenCauHinh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.st = New System.Windows.Forms.StatusStrip()
        Me.tt1 = New System.Windows.Forms.ToolStrip()
        Me.btnThuVienBaiHat = New System.Windows.Forms.ToolStripButton()
        Me.btnThemMoiTacVu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnChayTacVu = New System.Windows.Forms.ToolStripButton()
        Me.btnXoaTacVu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnThoat = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.amluong = New System.Windows.Forms.TrackBar()
        Me.lblAmLuong = New System.Windows.Forms.Label()
        Me.btnThietLapAmLuong = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.gThuMuc.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.gDsBaiHat.SuspendLayout()
        Me.tt2.SuspendLayout()
        Me.gChiTietCauHinh.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtThoiGian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tt1.SuspendLayout()
        CType(Me.amluong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gThuMuc
        '
        Me.gThuMuc.BackColor = System.Drawing.Color.AliceBlue
        Me.gThuMuc.Controls.Add(Me.treeThuMuc)
        Me.gThuMuc.Controls.Add(Me.cmbTrangThai)
        Me.gThuMuc.Location = New System.Drawing.Point(5, 30)
        Me.gThuMuc.Name = "gThuMuc"
        Me.gThuMuc.Size = New System.Drawing.Size(213, 262)
        Me.gThuMuc.TabIndex = 2
        Me.gThuMuc.TabStop = False
        '
        'treeThuMuc
        '
        Me.treeThuMuc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.treeThuMuc.BackColor = System.Drawing.Color.AliceBlue
        Me.treeThuMuc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treeThuMuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeThuMuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.treeThuMuc.FullRowSelect = True
        Me.treeThuMuc.ImageKey = "closefolder.gif"
        Me.treeThuMuc.ImageList = Me.img
        Me.treeThuMuc.ItemHeight = 25
        Me.treeThuMuc.Location = New System.Drawing.Point(10, 48)
        Me.treeThuMuc.Name = "treeThuMuc"
        TreeNode9.Name = "Node1"
        TreeNode9.Text = "Thứ hai"
        TreeNode10.Name = "Node2"
        TreeNode10.Text = "Thứ ba"
        TreeNode11.Name = "Node3"
        TreeNode11.Text = "Thứ tư"
        TreeNode12.Name = "Node2"
        TreeNode12.Text = "Thứ năm"
        TreeNode13.Name = "Node3"
        TreeNode13.Text = "Thứ sáu"
        TreeNode14.Name = "Node4"
        TreeNode14.Text = "Thứ bảy"
        TreeNode15.ForeColor = System.Drawing.Color.Red
        TreeNode15.Name = "Node5"
        TreeNode15.Text = "Chủ nhật"
        TreeNode16.ForeColor = System.Drawing.Color.Navy
        TreeNode16.Name = "Node0"
        TreeNode16.Text = "Cả Tuần"
        Me.treeThuMuc.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode16})
        Me.treeThuMuc.SelectedImageIndex = 2
        Me.treeThuMuc.Size = New System.Drawing.Size(195, 197)
        Me.treeThuMuc.TabIndex = 2
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "closefolder.gif")
        Me.img.Images.SetKeyName(1, "openfolder.gif")
        Me.img.Images.SetKeyName(2, "folder-open.png")
        '
        'cmbTrangThai
        '
        Me.cmbTrangThai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTrangThai.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrangThai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrangThai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTrangThai.FormattingEnabled = True
        Me.cmbTrangThai.Items.AddRange(New Object() {"Tất cả trạng thái", "Đang được kích hoạt", "Đã ngừng kích hoạt"})
        Me.cmbTrangThai.Location = New System.Drawing.Point(10, 17)
        Me.cmbTrangThai.Name = "cmbTrangThai"
        Me.cmbTrangThai.Size = New System.Drawing.Size(195, 24)
        Me.cmbTrangThai.TabIndex = 0
        '
        'lstTask
        '
        Me.lstTask.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstTask.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTask.AutoArrange = False
        Me.lstTask.BackColor = System.Drawing.Color.AliceBlue
        Me.lstTask.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTen, Me.colTiepTheo, Me.colDaChay, Me.colNgayTao})
        Me.lstTask.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTask.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstTask.FullRowSelect = True
        Me.lstTask.GridLines = True
        Me.lstTask.HideSelection = False
        Me.lstTask.Location = New System.Drawing.Point(221, 31)
        Me.lstTask.Name = "lstTask"
        Me.lstTask.ShowGroups = False
        Me.lstTask.Size = New System.Drawing.Size(665, 261)
        Me.lstTask.TabIndex = 0
        Me.lstTask.UseCompatibleStateImageBehavior = False
        Me.lstTask.View = System.Windows.Forms.View.Details
        '
        'colTen
        '
        Me.colTen.Text = "Tên"
        Me.colTen.Width = 314
        '
        'colTiepTheo
        '
        Me.colTiepTheo.Text = "Lần thực hiện tới"
        Me.colTiepTheo.Width = 119
        '
        'colDaChay
        '
        Me.colDaChay.Text = "Đã thực hiện lúc"
        Me.colDaChay.Width = 111
        '
        'colNgayTao
        '
        Me.colNgayTao.Text = "Ngày tạo"
        Me.colNgayTao.Width = 117
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mDungHoacHoatDong})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 26)
        '
        'mDungHoacHoatDong
        '
        Me.mDungHoacHoatDong.Name = "mDungHoacHoatDong"
        Me.mDungHoacHoatDong.Size = New System.Drawing.Size(163, 22)
        Me.mDungHoacHoatDong.Text = "Dừng/hoạt động"
        '
        'gDsBaiHat
        '
        Me.gDsBaiHat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gDsBaiHat.BackColor = System.Drawing.Color.White
        Me.gDsBaiHat.Controls.Add(Me.lstMp3)
        Me.gDsBaiHat.Controls.Add(Me.tt2)
        Me.gDsBaiHat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gDsBaiHat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gDsBaiHat.Location = New System.Drawing.Point(403, 298)
        Me.gDsBaiHat.Name = "gDsBaiHat"
        Me.gDsBaiHat.Size = New System.Drawing.Size(484, 372)
        Me.gDsBaiHat.TabIndex = 1
        Me.gDsBaiHat.TabStop = False
        Me.gDsBaiHat.Text = "Danh sách bài hát"
        '
        'lstMp3
        '
        Me.lstMp3.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstMp3.BackColor = System.Drawing.Color.AliceBlue
        Me.lstMp3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstMp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMp3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstMp3.FullRowSelect = True
        Me.lstMp3.GridLines = True
        Me.lstMp3.HideSelection = False
        Me.lstMp3.Location = New System.Drawing.Point(3, 43)
        Me.lstMp3.MultiSelect = False
        Me.lstMp3.Name = "lstMp3"
        Me.lstMp3.ShowGroups = False
        Me.lstMp3.Size = New System.Drawing.Size(478, 326)
        Me.lstMp3.TabIndex = 4
        Me.lstMp3.UseCompatibleStateImageBehavior = False
        Me.lstMp3.View = System.Windows.Forms.View.List
        '
        'tt2
        '
        Me.tt2.BackColor = System.Drawing.Color.AliceBlue
        Me.tt2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tt2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThemNhac, Me.btnXoaNhac, Me.ToolStripSeparator3, Me.btnUp, Me.btnDown, Me.ToolStripSeparator4, Me.btnThietLapAmLuong})
        Me.tt2.Location = New System.Drawing.Point(3, 18)
        Me.tt2.Name = "tt2"
        Me.tt2.Size = New System.Drawing.Size(478, 25)
        Me.tt2.TabIndex = 3
        Me.tt2.Text = "ToolStrip2"
        '
        'btnThemNhac
        '
        Me.btnThemNhac.Image = CType(resources.GetObject("btnThemNhac.Image"), System.Drawing.Image)
        Me.btnThemNhac.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThemNhac.Name = "btnThemNhac"
        Me.btnThemNhac.Size = New System.Drawing.Size(57, 22)
        Me.btnThemNhac.Text = "Thêm"
        '
        'btnXoaNhac
        '
        Me.btnXoaNhac.Image = CType(resources.GetObject("btnXoaNhac.Image"), System.Drawing.Image)
        Me.btnXoaNhac.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoaNhac.Name = "btnXoaNhac"
        Me.btnXoaNhac.Size = New System.Drawing.Size(47, 22)
        Me.btnXoaNhac.Text = "Xóa"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnUp
        '
        Me.btnUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(23, 22)
        Me.btnUp.Text = "Đẩy lên"
        '
        'btnDown
        '
        Me.btnDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(23, 22)
        Me.btnDown.Text = "Đẩy xuống"
        '
        'gChiTietCauHinh
        '
        Me.gChiTietCauHinh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gChiTietCauHinh.BackColor = System.Drawing.Color.White
        Me.gChiTietCauHinh.Controls.Add(Me.Label6)
        Me.gChiTietCauHinh.Controls.Add(Me.lblAmLuong)
        Me.gChiTietCauHinh.Controls.Add(Me.GroupBox4)
        Me.gChiTietCauHinh.Controls.Add(Me.amluong)
        Me.gChiTietCauHinh.Controls.Add(Me.Label5)
        Me.gChiTietCauHinh.Controls.Add(Me.txtKetThuc)
        Me.gChiTietCauHinh.Controls.Add(Me.chkTatMay)
        Me.gChiTietCauHinh.Controls.Add(Me.btnBatDau)
        Me.gChiTietCauHinh.Controls.Add(Me.chkPhatNgauNhien)
        Me.gChiTietCauHinh.Controls.Add(Me.txtThoiGian)
        Me.gChiTietCauHinh.Controls.Add(Me.Label4)
        Me.gChiTietCauHinh.Controls.Add(Me.Label3)
        Me.gChiTietCauHinh.Controls.Add(Me.txtBatDau)
        Me.gChiTietCauHinh.Controls.Add(Me.chkDangHoatDong)
        Me.gChiTietCauHinh.Controls.Add(Me.txtMoTa)
        Me.gChiTietCauHinh.Controls.Add(Me.Label2)
        Me.gChiTietCauHinh.Controls.Add(Me.txtTenCauHinh)
        Me.gChiTietCauHinh.Controls.Add(Me.Label1)
        Me.gChiTietCauHinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gChiTietCauHinh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gChiTietCauHinh.Location = New System.Drawing.Point(5, 298)
        Me.gChiTietCauHinh.Name = "gChiTietCauHinh"
        Me.gChiTietCauHinh.Size = New System.Drawing.Size(392, 372)
        Me.gChiTietCauHinh.TabIndex = 0
        Me.gChiTietCauHinh.TabStop = False
        Me.gChiTietCauHinh.Text = "Chi tiết cấu hình"
        '
        'txtKetThuc
        '
        Me.txtKetThuc.CustomFormat = "HH:mm:ss"
        Me.txtKetThuc.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txtKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtKetThuc.Location = New System.Drawing.Point(219, 131)
        Me.txtKetThuc.Name = "txtKetThuc"
        Me.txtKetThuc.ShowUpDown = True
        Me.txtKetThuc.Size = New System.Drawing.Size(80, 22)
        Me.txtKetThuc.TabIndex = 15
        '
        'chkTatMay
        '
        Me.chkTatMay.AutoSize = True
        Me.chkTatMay.ForeColor = System.Drawing.Color.Black
        Me.chkTatMay.Location = New System.Drawing.Point(307, 132)
        Me.chkTatMay.Name = "chkTatMay"
        Me.chkTatMay.Size = New System.Drawing.Size(78, 20)
        Me.chkTatMay.TabIndex = 14
        Me.chkTatMay.Text = "Tắt máy "
        Me.chkTatMay.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ngày thực hiện trong tuần"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkChuNhat)
        Me.GroupBox4.Controls.Add(Me.chkThuBay)
        Me.GroupBox4.Controls.Add(Me.chkThuSau)
        Me.GroupBox4.Controls.Add(Me.chkThuNam)
        Me.GroupBox4.Controls.Add(Me.chkThuTu)
        Me.GroupBox4.Controls.Add(Me.chkThuBa)
        Me.GroupBox4.Controls.Add(Me.chkThuHai)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 222)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(375, 74)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        '
        'chkChuNhat
        '
        Me.chkChuNhat.AutoSize = True
        Me.chkChuNhat.ForeColor = System.Drawing.Color.Black
        Me.chkChuNhat.Location = New System.Drawing.Point(179, 41)
        Me.chkChuNhat.Name = "chkChuNhat"
        Me.chkChuNhat.Size = New System.Drawing.Size(77, 20)
        Me.chkChuNhat.TabIndex = 17
        Me.chkChuNhat.Text = "Chủ nhật"
        Me.chkChuNhat.UseVisualStyleBackColor = True
        '
        'chkThuBay
        '
        Me.chkThuBay.AutoSize = True
        Me.chkThuBay.ForeColor = System.Drawing.Color.Black
        Me.chkThuBay.Location = New System.Drawing.Point(93, 41)
        Me.chkThuBay.Name = "chkThuBay"
        Me.chkThuBay.Size = New System.Drawing.Size(75, 20)
        Me.chkThuBay.TabIndex = 16
        Me.chkThuBay.Text = "Thứ bảy"
        Me.chkThuBay.UseVisualStyleBackColor = True
        '
        'chkThuSau
        '
        Me.chkThuSau.AutoSize = True
        Me.chkThuSau.ForeColor = System.Drawing.Color.Black
        Me.chkThuSau.Location = New System.Drawing.Point(13, 41)
        Me.chkThuSau.Name = "chkThuSau"
        Me.chkThuSau.Size = New System.Drawing.Size(74, 20)
        Me.chkThuSau.TabIndex = 15
        Me.chkThuSau.Text = "Thứ sáu"
        Me.chkThuSau.UseVisualStyleBackColor = True
        '
        'chkThuNam
        '
        Me.chkThuNam.AutoSize = True
        Me.chkThuNam.ForeColor = System.Drawing.Color.Black
        Me.chkThuNam.Location = New System.Drawing.Point(258, 15)
        Me.chkThuNam.Name = "chkThuNam"
        Me.chkThuNam.Size = New System.Drawing.Size(78, 20)
        Me.chkThuNam.TabIndex = 14
        Me.chkThuNam.Text = "Thứ năm"
        Me.chkThuNam.UseVisualStyleBackColor = True
        '
        'chkThuTu
        '
        Me.chkThuTu.AutoSize = True
        Me.chkThuTu.ForeColor = System.Drawing.Color.Black
        Me.chkThuTu.Location = New System.Drawing.Point(179, 15)
        Me.chkThuTu.Name = "chkThuTu"
        Me.chkThuTu.Size = New System.Drawing.Size(62, 20)
        Me.chkThuTu.TabIndex = 13
        Me.chkThuTu.Text = "Thứ tư"
        Me.chkThuTu.UseVisualStyleBackColor = True
        '
        'chkThuBa
        '
        Me.chkThuBa.AutoSize = True
        Me.chkThuBa.ForeColor = System.Drawing.Color.Black
        Me.chkThuBa.Location = New System.Drawing.Point(93, 15)
        Me.chkThuBa.Name = "chkThuBa"
        Me.chkThuBa.Size = New System.Drawing.Size(68, 20)
        Me.chkThuBa.TabIndex = 12
        Me.chkThuBa.Text = "Thứ ba"
        Me.chkThuBa.UseVisualStyleBackColor = True
        '
        'chkThuHai
        '
        Me.chkThuHai.AutoSize = True
        Me.chkThuHai.ForeColor = System.Drawing.Color.Black
        Me.chkThuHai.Location = New System.Drawing.Point(13, 15)
        Me.chkThuHai.Name = "chkThuHai"
        Me.chkThuHai.Size = New System.Drawing.Size(70, 20)
        Me.chkThuHai.TabIndex = 11
        Me.chkThuHai.Text = "Thứ hai"
        Me.chkThuHai.UseVisualStyleBackColor = True
        '
        'btnBatDau
        '
        Me.btnBatDau.BackColor = System.Drawing.Color.White
        Me.btnBatDau.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatDau.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBatDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatDau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatDau.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBatDau.Image = CType(resources.GetObject("btnBatDau.Image"), System.Drawing.Image)
        Me.btnBatDau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatDau.Location = New System.Drawing.Point(11, 328)
        Me.btnBatDau.Name = "btnBatDau"
        Me.btnBatDau.Size = New System.Drawing.Size(125, 32)
        Me.btnBatDau.TabIndex = 11
        Me.btnBatDau.Text = "   Cập nhật"
        Me.btnBatDau.UseVisualStyleBackColor = False
        '
        'chkPhatNgauNhien
        '
        Me.chkPhatNgauNhien.AutoSize = True
        Me.chkPhatNgauNhien.ForeColor = System.Drawing.Color.Black
        Me.chkPhatNgauNhien.Location = New System.Drawing.Point(11, 302)
        Me.chkPhatNgauNhien.Name = "chkPhatNgauNhien"
        Me.chkPhatNgauNhien.Size = New System.Drawing.Size(251, 20)
        Me.chkPhatNgauNhien.TabIndex = 10
        Me.chkPhatNgauNhien.Text = "Phát ngẫu nhiên trong danh sách nhạc"
        Me.chkPhatNgauNhien.UseVisualStyleBackColor = True
        '
        'txtThoiGian
        '
        Me.txtThoiGian.Location = New System.Drawing.Point(283, 339)
        Me.txtThoiGian.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtThoiGian.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtThoiGian.Name = "txtThoiGian"
        Me.txtThoiGian.Size = New System.Drawing.Size(82, 22)
        Me.txtThoiGian.TabIndex = 8
        Me.txtThoiGian.Value = New Decimal(New Integer() {15, 0, 0, 0})
        Me.txtThoiGian.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(160, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Kết thúc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bắt đầu"
        '
        'txtBatDau
        '
        Me.txtBatDau.CustomFormat = "HH:mm:ss"
        Me.txtBatDau.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txtBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtBatDau.Location = New System.Drawing.Point(75, 131)
        Me.txtBatDau.Name = "txtBatDau"
        Me.txtBatDau.ShowUpDown = True
        Me.txtBatDau.Size = New System.Drawing.Size(79, 22)
        Me.txtBatDau.TabIndex = 5
        '
        'chkDangHoatDong
        '
        Me.chkDangHoatDong.AutoSize = True
        Me.chkDangHoatDong.Checked = True
        Me.chkDangHoatDong.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDangHoatDong.ForeColor = System.Drawing.Color.Black
        Me.chkDangHoatDong.Location = New System.Drawing.Point(244, 27)
        Me.chkDangHoatDong.Name = "chkDangHoatDong"
        Me.chkDangHoatDong.Size = New System.Drawing.Size(121, 20)
        Me.chkDangHoatDong.TabIndex = 4
        Me.chkDangHoatDong.Text = "Đang hoạt động"
        Me.chkDangHoatDong.UseVisualStyleBackColor = True
        '
        'txtMoTa
        '
        Me.txtMoTa.BackColor = System.Drawing.Color.White
        Me.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMoTa.Location = New System.Drawing.Point(75, 55)
        Me.txtMoTa.Multiline = True
        Me.txtMoTa.Name = "txtMoTa"
        Me.txtMoTa.Size = New System.Drawing.Size(310, 70)
        Me.txtMoTa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mô tả"
        '
        'txtTenCauHinh
        '
        Me.txtTenCauHinh.BackColor = System.Drawing.Color.White
        Me.txtTenCauHinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTenCauHinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenCauHinh.ForeColor = System.Drawing.Color.Blue
        Me.txtTenCauHinh.Location = New System.Drawing.Point(75, 25)
        Me.txtTenCauHinh.Name = "txtTenCauHinh"
        Me.txtTenCauHinh.ReadOnly = True
        Me.txtTenCauHinh.Size = New System.Drawing.Size(163, 22)
        Me.txtTenCauHinh.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên"
        '
        'st
        '
        Me.st.Location = New System.Drawing.Point(0, 675)
        Me.st.Name = "st"
        Me.st.Size = New System.Drawing.Size(899, 22)
        Me.st.TabIndex = 2
        Me.st.Text = "StatusStrip1"
        '
        'tt1
        '
        Me.tt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tt1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tt1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThuVienBaiHat, Me.btnThemMoiTacVu, Me.ToolStripSeparator2, Me.btnChayTacVu, Me.btnXoaTacVu, Me.ToolStripSeparator1, Me.btnThoat})
        Me.tt1.Location = New System.Drawing.Point(0, 0)
        Me.tt1.Name = "tt1"
        Me.tt1.Size = New System.Drawing.Size(899, 28)
        Me.tt1.TabIndex = 2
        Me.tt1.Text = "ToolStrip1"
        '
        'btnThuVienBaiHat
        '
        Me.btnThuVienBaiHat.Enabled = False
        Me.btnThuVienBaiHat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThuVienBaiHat.Image = CType(resources.GetObject("btnThuVienBaiHat.Image"), System.Drawing.Image)
        Me.btnThuVienBaiHat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThuVienBaiHat.Name = "btnThuVienBaiHat"
        Me.btnThuVienBaiHat.Size = New System.Drawing.Size(140, 25)
        Me.btnThuVienBaiHat.Text = "Thư viện bài hát"
        Me.btnThuVienBaiHat.Visible = False
        '
        'btnThemMoiTacVu
        '
        Me.btnThemMoiTacVu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemMoiTacVu.Image = CType(resources.GetObject("btnThemMoiTacVu.Image"), System.Drawing.Image)
        Me.btnThemMoiTacVu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThemMoiTacVu.Name = "btnThemMoiTacVu"
        Me.btnThemMoiTacVu.Size = New System.Drawing.Size(146, 25)
        Me.btnThemMoiTacVu.Text = "Thêm mới tác vụ"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'btnChayTacVu
        '
        Me.btnChayTacVu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChayTacVu.Image = CType(resources.GetObject("btnChayTacVu.Image"), System.Drawing.Image)
        Me.btnChayTacVu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChayTacVu.Name = "btnChayTacVu"
        Me.btnChayTacVu.Size = New System.Drawing.Size(110, 25)
        Me.btnChayTacVu.Text = "Chạy tác vụ"
        '
        'btnXoaTacVu
        '
        Me.btnXoaTacVu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaTacVu.Image = CType(resources.GetObject("btnXoaTacVu.Image"), System.Drawing.Image)
        Me.btnXoaTacVu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoaTacVu.Name = "btnXoaTacVu"
        Me.btnXoaTacVu.Size = New System.Drawing.Size(101, 25)
        Me.btnXoaTacVu.Text = "Xóa tác vụ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(69, 25)
        Me.btnThoat.Text = "Thoát"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(891, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(8, 647)
        Me.Panel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Âm lượng"
        '
        'amluong
        '
        Me.amluong.Location = New System.Drawing.Point(66, 179)
        Me.amluong.Maximum = 100
        Me.amluong.Name = "amluong"
        Me.amluong.Size = New System.Drawing.Size(319, 45)
        Me.amluong.TabIndex = 17
        Me.amluong.TickStyle = System.Windows.Forms.TickStyle.None
        Me.amluong.Value = 100
        '
        'lblAmLuong
        '
        Me.lblAmLuong.AutoSize = True
        Me.lblAmLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmLuong.ForeColor = System.Drawing.Color.Maroon
        Me.lblAmLuong.Location = New System.Drawing.Point(92, 164)
        Me.lblAmLuong.Name = "lblAmLuong"
        Me.lblAmLuong.Size = New System.Drawing.Size(223, 16)
        Me.lblAmLuong.TabIndex = 18
        Me.lblAmLuong.Text = "( Phát theo 100% âm lượng máy tính )"
        '
        'btnThietLapAmLuong
        '
        Me.btnThietLapAmLuong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnThietLapAmLuong.Image = CType(resources.GetObject("btnThietLapAmLuong.Image"), System.Drawing.Image)
        Me.btnThietLapAmLuong.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThietLapAmLuong.Name = "btnThietLapAmLuong"
        Me.btnThietLapAmLuong.Size = New System.Drawing.Size(140, 22)
        Me.btnThietLapAmLuong.Text = "Thiết lập âm lượng riêng"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(899, 697)
        Me.Controls.Add(Me.gDsBaiHat)
        Me.Controls.Add(Me.lstTask)
        Me.Controls.Add(Me.gChiTietCauHinh)
        Me.Controls.Add(Me.gThuMuc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tt1)
        Me.Controls.Add(Me.st)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BAC PLAYER REMOTE"
        Me.gThuMuc.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.gDsBaiHat.ResumeLayout(False)
        Me.gDsBaiHat.PerformLayout()
        Me.tt2.ResumeLayout(False)
        Me.tt2.PerformLayout()
        Me.gChiTietCauHinh.ResumeLayout(False)
        Me.gChiTietCauHinh.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtThoiGian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tt1.ResumeLayout(False)
        Me.tt1.PerformLayout()
        CType(Me.amluong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gThuMuc As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTrangThai As System.Windows.Forms.ComboBox
    Friend WithEvents treeThuMuc As System.Windows.Forms.TreeView
    Friend WithEvents st As System.Windows.Forms.StatusStrip
    Friend WithEvents tt1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnThuVienBaiHat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lstTask As System.Windows.Forms.ListView
    Friend WithEvents colTen As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTiepTheo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDaChay As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNgayTao As System.Windows.Forms.ColumnHeader
    Friend WithEvents gChiTietCauHinh As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTenCauHinh As System.Windows.Forms.TextBox
    Friend WithEvents txtMoTa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gDsBaiHat As System.Windows.Forms.GroupBox
    Friend WithEvents lstMp3 As System.Windows.Forms.ListView
    Friend WithEvents tt2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnThemNhac As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnXoaNhac As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkDangHoatDong As System.Windows.Forms.CheckBox
    Friend WithEvents chkPhatNgauNhien As System.Windows.Forms.CheckBox
    Friend WithEvents txtThoiGian As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBatDau As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnThemMoiTacVu As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnThoat As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBatDau As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnXoaTacVu As System.Windows.Forms.ToolStripButton
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkChuNhat As System.Windows.Forms.CheckBox
    Friend WithEvents chkThuBay As System.Windows.Forms.CheckBox
    Friend WithEvents chkThuSau As System.Windows.Forms.CheckBox
    Friend WithEvents chkThuNam As System.Windows.Forms.CheckBox
    Friend WithEvents chkThuTu As System.Windows.Forms.CheckBox
    Friend WithEvents chkThuBa As System.Windows.Forms.CheckBox
    Friend WithEvents chkThuHai As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUp As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDown As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnChayTacVu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mDungHoacHoatDong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkTatMay As CheckBox
    Friend WithEvents txtKetThuc As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents amluong As TrackBar
    Friend WithEvents lblAmLuong As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnThietLapAmLuong As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
