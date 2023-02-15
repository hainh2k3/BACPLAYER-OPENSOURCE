<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThuVienNhac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThuVienNhac))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.treeThuMuc = New System.Windows.Forms.TreeView()
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lstTask = New System.Windows.Forms.ListView()
        Me.colTen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNgayTao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.st = New System.Windows.Forms.StatusStrip()
        Me.tt1 = New System.Windows.Forms.ToolStrip()
        Me.btnThuVienBaiHat = New System.Windows.Forms.ToolStripButton()
        Me.btnThemMoiTacVu = New System.Windows.Forms.ToolStripButton()
        Me.btnXoaTacVu = New System.Windows.Forms.ToolStripButton()
        Me.btnChonDanhSach = New System.Windows.Forms.ToolStripButton()
        Me.btnThoat = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tt1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.treeThuMuc)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 539)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
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
        Me.treeThuMuc.Location = New System.Drawing.Point(12, 19)
        Me.treeThuMuc.Name = "treeThuMuc"
        Me.treeThuMuc.SelectedImageIndex = 2
        Me.treeThuMuc.Size = New System.Drawing.Size(182, 498)
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstTask)
        Me.SplitContainer1.Size = New System.Drawing.Size(876, 539)
        Me.SplitContainer1.SplitterDistance = 200
        Me.SplitContainer1.TabIndex = 3
        '
        'lstTask
        '
        Me.lstTask.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstTask.AutoArrange = False
        Me.lstTask.BackColor = System.Drawing.Color.AliceBlue
        Me.lstTask.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTen, Me.colMB, Me.colNgayTao})
        Me.lstTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTask.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstTask.FullRowSelect = True
        Me.lstTask.GridLines = True
        Me.lstTask.Location = New System.Drawing.Point(0, 0)
        Me.lstTask.Name = "lstTask"
        Me.lstTask.ShowGroups = False
        Me.lstTask.Size = New System.Drawing.Size(672, 539)
        Me.lstTask.TabIndex = 1
        Me.lstTask.UseCompatibleStateImageBehavior = False
        Me.lstTask.View = System.Windows.Forms.View.Details
        '
        'colTen
        '
        Me.colTen.Text = "Tên file"
        Me.colTen.Width = 389
        '
        'colMB
        '
        Me.colMB.Text = "MB"
        Me.colMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colMB.Width = 80
        '
        'colNgayTao
        '
        Me.colNgayTao.Text = "Ngày tạo"
        Me.colNgayTao.Width = 138
        '
        'st
        '
        Me.st.Location = New System.Drawing.Point(0, 567)
        Me.st.Name = "st"
        Me.st.Size = New System.Drawing.Size(884, 22)
        Me.st.TabIndex = 2
        Me.st.Text = "StatusStrip1"
        '
        'tt1
        '
        Me.tt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tt1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tt1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThuVienBaiHat, Me.btnThemMoiTacVu, Me.btnXoaTacVu, Me.btnChonDanhSach, Me.btnThoat})
        Me.tt1.Location = New System.Drawing.Point(0, 0)
        Me.tt1.Name = "tt1"
        Me.tt1.Size = New System.Drawing.Size(884, 28)
        Me.tt1.TabIndex = 2
        Me.tt1.Text = "ToolStrip1"
        '
        'btnThuVienBaiHat
        '
        Me.btnThuVienBaiHat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThuVienBaiHat.Image = CType(resources.GetObject("btnThuVienBaiHat.Image"), System.Drawing.Image)
        Me.btnThuVienBaiHat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThuVienBaiHat.Name = "btnThuVienBaiHat"
        Me.btnThuVienBaiHat.Size = New System.Drawing.Size(130, 25)
        Me.btnThuVienBaiHat.Text = "Thêm thư mục"
        Me.btnThuVienBaiHat.Visible = False
        '
        'btnThemMoiTacVu
        '
        Me.btnThemMoiTacVu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemMoiTacVu.Image = CType(resources.GetObject("btnThemMoiTacVu.Image"), System.Drawing.Image)
        Me.btnThemMoiTacVu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThemMoiTacVu.Name = "btnThemMoiTacVu"
        Me.btnThemMoiTacVu.Size = New System.Drawing.Size(120, 25)
        Me.btnThemMoiTacVu.Text = "Thêm bài hát"
        Me.btnThemMoiTacVu.Visible = False
        '
        'btnXoaTacVu
        '
        Me.btnXoaTacVu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaTacVu.Image = CType(resources.GetObject("btnXoaTacVu.Image"), System.Drawing.Image)
        Me.btnXoaTacVu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoaTacVu.Name = "btnXoaTacVu"
        Me.btnXoaTacVu.Size = New System.Drawing.Size(107, 25)
        Me.btnXoaTacVu.Text = "Xóa bài hát"
        Me.btnXoaTacVu.Visible = False
        '
        'btnChonDanhSach
        '
        Me.btnChonDanhSach.Image = CType(resources.GetObject("btnChonDanhSach.Image"), System.Drawing.Image)
        Me.btnChonDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChonDanhSach.Name = "btnChonDanhSach"
        Me.btnChonDanhSach.Size = New System.Drawing.Size(135, 25)
        Me.btnChonDanhSach.Text = "Chọn vào danh sách"
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
        Me.Panel1.Location = New System.Drawing.Point(876, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(8, 539)
        Me.Panel1.TabIndex = 1
        '
        'frmThuVienNhac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 589)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tt1)
        Me.Controls.Add(Me.st)
        Me.Name = "frmThuVienNhac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BAC PLAYER REMOTE"
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tt1.ResumeLayout(False)
        Me.tt1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents treeThuMuc As System.Windows.Forms.TreeView
    Friend WithEvents st As System.Windows.Forms.StatusStrip
    Friend WithEvents tt1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnThuVienBaiHat As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnThemMoiTacVu As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnThoat As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnXoaTacVu As System.Windows.Forms.ToolStripButton
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents btnChonDanhSach As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lstTask As System.Windows.Forms.ListView
    Friend WithEvents colTen As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMB As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNgayTao As System.Windows.Forms.ColumnHeader

End Class
