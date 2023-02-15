<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstBaiHat = New System.Windows.Forms.ListBox()
        Me.tm = New System.Windows.Forms.Timer(Me.components)
        Me.prc = New System.Windows.Forms.ProgressBar()
        Me.lblThoiGian = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 26)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstBaiHat
        '
        Me.lstBaiHat.FormattingEnabled = True
        Me.lstBaiHat.Location = New System.Drawing.Point(12, 15)
        Me.lstBaiHat.Name = "lstBaiHat"
        Me.lstBaiHat.Size = New System.Drawing.Size(416, 186)
        Me.lstBaiHat.TabIndex = 3
        '
        'tm
        '
        Me.tm.Interval = 1000
        '
        'prc
        '
        Me.prc.Location = New System.Drawing.Point(12, 207)
        Me.prc.Name = "prc"
        Me.prc.Size = New System.Drawing.Size(416, 15)
        Me.prc.TabIndex = 4
        '
        'lblThoiGian
        '
        Me.lblThoiGian.AutoSize = True
        Me.lblThoiGian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblThoiGian.Location = New System.Drawing.Point(104, 235)
        Me.lblThoiGian.Name = "lblThoiGian"
        Me.lblThoiGian.Size = New System.Drawing.Size(60, 13)
        Me.lblThoiGian.TabIndex = 5
        Me.lblThoiGian.Text = "lblThoiGian"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 263)
        Me.Controls.Add(Me.lblThoiGian)
        Me.Controls.Add(Me.prc)
        Me.Controls.Add(Me.lstBaiHat)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BAC PLAYER MP3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstBaiHat As System.Windows.Forms.ListBox
    Friend WithEvents tm As System.Windows.Forms.Timer
    Friend WithEvents prc As System.Windows.Forms.ProgressBar
    Friend WithEvents lblThoiGian As System.Windows.Forms.Label

End Class
