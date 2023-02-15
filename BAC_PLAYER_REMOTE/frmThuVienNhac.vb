Imports System.IO
Public Class frmThuVienNhac





    

    


    Private isUpdate As Boolean = True

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LayDsThuMuc()
    End Sub


    Private Sub LayDsThuMuc()
        lstTask.Items.Clear()
        Dim d As New IO.DirectoryInfo(Application.StartupPath & "\NhacMp3")
        Dim root As New TreeNode("NhacMp3")
        root.Tag = Application.StartupPath & "\NhacMp3"
        For Each dic As IO.DirectoryInfo In d.GetDirectories
            Dim i As New TreeNode(dic.Name)
            i.Tag = dic.FullName
            root.Nodes.Add(i)
            dequyNod(i, dic)
        Next
        treeThuMuc.Nodes.Add(root)
        treeThuMuc.ExpandAll()
    End Sub

    Private Sub dequyNod(n As TreeNode, d As IO.DirectoryInfo)
        If d.GetDirectories().Length = 0 Then Exit Sub
        For Each dic As IO.DirectoryInfo In d.GetDirectories
            Dim i As New TreeNode(dic.Name)
            i.Tag = dic.FullName
            n.Nodes.Add(i)
            dequyNod(i, dic)
        Next
    End Sub



    Private Sub treeThuMuc_NodeMouseClick(sender As System.Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treeThuMuc.NodeMouseClick
        lstTask.Items.Clear()
    End Sub

    Private Sub treeThuMuc_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles treeThuMuc.AfterSelect
        lstTask.Items.Clear()
        If treeThuMuc.SelectedNode Is Nothing Then Exit Sub
        Dim d As New IO.DirectoryInfo(treeThuMuc.SelectedNode.Tag)
        For Each f As IO.FileInfo In d.GetFiles()
            Dim _file As New ListViewItem(New String() {f.Name.ToLower, Math.Round(f.Length / (1024 * 1024), 2, MidpointRounding.AwayFromZero).ToString, f.CreationTime.ToString("HH:mm dd/MM/yyyy")})
            _file.Tag = f.FullName.Replace(Application.StartupPath & "\NhacMp3\", "")
            lstTask.Items.Add(_file)
        Next
    End Sub


   


    


    Private Sub btnThoat_Click(sender As System.Object, e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub


    Private Sub lstTask_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Public strListMp3 As String = ""
    Private Sub btnChonDanhSach_Click(sender As System.Object, e As System.EventArgs) Handles btnChonDanhSach.Click
        If lstTask.SelectedItems.Count > 0 Then
            For Each i As ListViewItem In lstTask.SelectedItems
                strListMp3 &= i.Tag & ";"
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub


End Class
