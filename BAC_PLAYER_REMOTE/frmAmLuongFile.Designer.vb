<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAmLuongFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAmLuongFile))
        Me.tt1 = New System.Windows.Forms.ToolStrip()
        Me.btnChonDanhSach = New System.Windows.Forms.ToolStripButton()
        Me.btnThoat = New System.Windows.Forms.ToolStripButton()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.lblAmLuong = New System.Windows.Forms.Label()
        Me.amluong = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkDacBiet = New System.Windows.Forms.CheckBox()
        Me.tt1.SuspendLayout()
        CType(Me.amluong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tt1
        '
        Me.tt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tt1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tt1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnChonDanhSach, Me.btnThoat})
        Me.tt1.Location = New System.Drawing.Point(0, 0)
        Me.tt1.Name = "tt1"
        Me.tt1.Size = New System.Drawing.Size(446, 28)
        Me.tt1.TabIndex = 2
        Me.tt1.Text = "ToolStrip1"
        '
        'btnChonDanhSach
        '
        Me.btnChonDanhSach.Image = CType(resources.GetObject("btnChonDanhSach.Image"), System.Drawing.Image)
        Me.btnChonDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChonDanhSach.Name = "btnChonDanhSach"
        Me.btnChonDanhSach.Size = New System.Drawing.Size(126, 25)
        Me.btnChonDanhSach.Text = "Thiết lập âm lượng"
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
        'txtFile
        '
        Me.txtFile.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFile.Location = New System.Drawing.Point(8, 34)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ReadOnly = True
        Me.txtFile.Size = New System.Drawing.Size(429, 50)
        Me.txtFile.TabIndex = 3
        Me.txtFile.Text = "rưerewr"
        '
        'lblAmLuong
        '
        Me.lblAmLuong.AutoSize = True
        Me.lblAmLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmLuong.ForeColor = System.Drawing.Color.Maroon
        Me.lblAmLuong.Location = New System.Drawing.Point(116, 120)
        Me.lblAmLuong.Name = "lblAmLuong"
        Me.lblAmLuong.Size = New System.Drawing.Size(223, 16)
        Me.lblAmLuong.TabIndex = 21
        Me.lblAmLuong.Text = "( Phát theo 100% âm lượng máy tính )"
        '
        'amluong
        '
        Me.amluong.Enabled = False
        Me.amluong.Location = New System.Drawing.Point(73, 135)
        Me.amluong.Maximum = 100
        Me.amluong.Name = "amluong"
        Me.amluong.Size = New System.Drawing.Size(361, 45)
        Me.amluong.TabIndex = 20
        Me.amluong.TickStyle = System.Windows.Forms.TickStyle.None
        Me.amluong.Value = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Âm lượng"
        '
        'chkDacBiet
        '
        Me.chkDacBiet.AutoSize = True
        Me.chkDacBiet.ForeColor = System.Drawing.Color.Black
        Me.chkDacBiet.Location = New System.Drawing.Point(12, 93)
        Me.chkDacBiet.Name = "chkDacBiet"
        Me.chkDacBiet.Size = New System.Drawing.Size(274, 17)
        Me.chkDacBiet.TabIndex = 22
        Me.chkDacBiet.Text = "Sử dụng thiết lập mức độ âm lượng riêng cho file này"
        Me.chkDacBiet.UseVisualStyleBackColor = True
        '
        'frmAmLuongFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(446, 165)
        Me.Controls.Add(Me.chkDacBiet)
        Me.Controls.Add(Me.lblAmLuong)
        Me.Controls.Add(Me.amluong)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.tt1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAmLuongFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BAC PLAYER REMOTE"
        Me.tt1.ResumeLayout(False)
        Me.tt1.PerformLayout()
        CType(Me.amluong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tt1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnThoat As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChonDanhSach As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtFile As TextBox
    Friend WithEvents lblAmLuong As Label
    Friend WithEvents amluong As TrackBar
    Friend WithEvents Label5 As Label
    Friend WithEvents chkDacBiet As CheckBox
End Class
