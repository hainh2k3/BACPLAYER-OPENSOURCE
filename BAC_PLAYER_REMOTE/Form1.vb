Imports Microsoft.Win32.TaskScheduler
Public Class Form1

    Private Sub clearCauHinh()
        txtTenCauHinh.Text = ""
        txtMoTa.Text = ""
        chkDangHoatDong.Checked = True
        Dim hientai As New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, 0)
        txtBatDau.Value = hientai.AddMinutes(5)
        txtKetThuc.Value = hientai.AddMinutes(5).AddSeconds(15)
        txtThoiGian.Value = 15
        chkPhatNgauNhien.Checked = False
        chkTatMay.Checked = False
        chkThuHai.Checked = False
        chkThuBa.Checked = False
        chkThuTu.Checked = False
        chkThuNam.Checked = False
        chkThuSau.Checked = False
        chkThuBay.Checked = False
        chkChuNhat.Checked = False
        lstMp3.Items.Clear()
        amluong.Value = 100
    End Sub



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub


    Private isUpdate As Boolean = True

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim taskServices As New Microsoft.Win32.TaskScheduler.TaskService()
        If taskServices.GetFolder("BACPLAYER") Is Nothing Then taskServices.RootFolder.CreateFolder("BACPLAYER")

        cmbTrangThai.SelectedIndex = 0
        treeThuMuc.ExpandAll()
        treeThuMuc.Focus()
        treeThuMuc.SelectedNode = treeThuMuc.Nodes(0)

        gChiTietCauHinh.Enabled = False
        gDsBaiHat.Enabled = False

    End Sub


    Private Sub treeThuMuc_NodeMouseClick(sender As System.Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treeThuMuc.NodeMouseClick
        clearCauHinh()
    End Sub

    Private Sub cmbTrangThai_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTrangThai.SelectedIndexChanged

    End Sub

    Private Sub treeThuMuc_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles treeThuMuc.AfterSelect

        clearCauHinh()

        Dim taskServices As New Microsoft.Win32.TaskScheduler.TaskService()
        lstTask.Items.Clear()

        Dim dayOfWeek As String = ""
        Select Case treeThuMuc.SelectedNode.Index
            Case 0 'thu hai
                dayOfWeek = "Monday"
                Exit Select
            Case 1 'thu ba
                dayOfWeek = "Tuesday"
                Exit Select
            Case 2 'thu tu
                dayOfWeek = "Wednesday"
                Exit Select
            Case 3 'thu nam
                dayOfWeek = "Thursday"
                Exit Select
            Case 4 'thu sau
                dayOfWeek = "Friday"
                Exit Select
            Case 5 'thu bay
                dayOfWeek = "Saturday"
                Exit Select
            Case 6 'chu nhat
                dayOfWeek = "Sunday"
                Exit Select
        End Select

        For Each t As Task In taskServices.RootFolder.SubFolders("BACPLAYER").Tasks
            If e.Node.Level = 1 Then
                If CType(t.Definition.Triggers(0), WeeklyTrigger).DaysOfWeek.ToString.ToLower = "alldays" Or
                    CType(t.Definition.Triggers(0), WeeklyTrigger).DaysOfWeek.ToString.ToLower.IndexOf(dayOfWeek.ToLower) >= 0 Then
                    Dim item As New ListViewItem(New String() {t.Name, t.NextRunTime.ToString("HH:mm dd/MM/yyyy"), t.LastRunTime.ToString("HH:mm dd/MM/yyyy"), ""})
                    item.Tag = t
                    lstTask.Items.Add(item)
                End If
            Else
                Dim item As New ListViewItem(New String() {t.Name, t.NextRunTime.ToString("HH:mm dd/MM/yyyy"), t.LastRunTime.ToString("HH:mm dd/MM/yyyy"), ""})
                item.Tag = t
                lstTask.Items.Add(item)
            End If
        Next
        taskServices.Dispose()
    End Sub


    Private Sub lstTask_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstTask.SelectedIndexChanged

        If lstTask.SelectedItems.Count = 0 Then
            gChiTietCauHinh.Enabled = False
            gDsBaiHat.Enabled = False
        Else
            gChiTietCauHinh.Enabled = True
            gDsBaiHat.Enabled = True
        End If

        clearCauHinh()
        If lstTask.SelectedItems.Count = 0 Then Exit Sub
        Dim t As Task = CType(lstTask.SelectedItems(0).Tag, Task)
        txtTenCauHinh.Text = t.Name
        txtMoTa.Text = t.Definition.RegistrationInfo.Description
        txtBatDau.Value = t.Definition.Triggers(0).StartBoundary
        chkDangHoatDong.Checked = t.Definition.Triggers(0).Enabled

        Dim strNgay As String = CType(t.Definition.Triggers(0), WeeklyTrigger).DaysOfWeek.ToString.ToLower

        If strNgay.IndexOf("alldays") >= 0 Then
            chkThuHai.Checked = True
            chkThuBa.Checked = True
            chkThuTu.Checked = True
            chkThuNam.Checked = True
            chkThuSau.Checked = True
            chkThuBay.Checked = True
            chkChuNhat.Checked = True
        Else
            If strNgay.IndexOf("monday") >= 0 Then chkThuHai.Checked = True
            If strNgay.IndexOf("tuesday") >= 0 Then chkThuBa.Checked = True
            If strNgay.IndexOf("wednesday") >= 0 Then chkThuTu.Checked = True
            If strNgay.IndexOf("thursday") >= 0 Then chkThuNam.Checked = True
            If strNgay.IndexOf("friday") >= 0 Then chkThuSau.Checked = True
            If strNgay.IndexOf("saturday") >= 0 Then chkThuBay.Checked = True
            If strNgay.IndexOf("sunday") >= 0 Then chkChuNhat.Checked = True
        End If


        Try
            Dim strParm As String = CType(t.Definition.Actions(1), ExecAction).Arguments
            chkPhatNgauNhien.Checked = Convert.ToByte(strParm.Substring(0, 1))
            Dim strTg As String = strParm.Substring(2)
            strTg = strTg.Substring(0, strTg.IndexOf(" "))
            txtThoiGian.Value = Convert.ToInt32(strTg)
            txtKetThuc.Value = txtBatDau.Value.AddSeconds(txtThoiGian.Value)
            Dim strTatMay As String = strParm.Substring(2)
            strTatMay = strTatMay.Substring(strTatMay.IndexOf(" ") + 1)
            chkTatMay.Checked = Convert.ToByte(strTatMay.Substring(0, strTatMay.IndexOf(" ")))
            Dim arrPrm As String() = strParm.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            Dim strAmLuong As String = arrPrm(3)
            amluong.Value = Convert.ToInt32(strAmLuong)

            lstMp3.Items.Clear()
            Try
                Dim strMp3 As String = strParm.Substring(strParm.IndexOf("""") + 1)
                strMp3 = strMp3.Substring(0, strMp3.Length - 1)
                For Each s As String In strMp3.Split(";")
                    If s.Trim = "" Then Continue For
                    lstMp3.Items.Add(s)
                Next
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try

    End Sub


    Private Sub btnBatDau_Click(sender As System.Object, e As System.EventArgs) Handles btnBatDau.Click
        'Check thoi gian
        If txtBatDau.Value >= txtKetThuc.Value Then
            MessageBox.Show("Vui lòng nhập thời gian kết thúc hợp lệ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        txtThoiGian.Value = (txtKetThuc.Value - txtBatDau.Value).TotalSeconds

        If isUpdate Then ' Cap nhat tac vu
            If lstTask.SelectedItems.Count = 0 Then Exit Sub
            Dim taskServices As New Microsoft.Win32.TaskScheduler.TaskService()
            Dim task As Task = taskServices.GetTask("\BACPLAYER\" & txtTenCauHinh.Text)
            task.Definition.RegistrationInfo.Description = txtMoTa.Text
            Dim trig As WeeklyTrigger = CType(task.Definition.Triggers(0).Clone, WeeklyTrigger)
            trig.Enabled = chkDangHoatDong.Checked
            trig.StartBoundary = New DateTime(Today.Year, Today.Month, Today.Day, txtBatDau.Value.Hour, txtBatDau.Value.Minute, txtBatDau.Value.Second)
            Dim ngay As Integer = 0
            If chkThuHai.Checked Then ngay += DaysOfTheWeek.Monday
            If chkThuBa.Checked Then ngay += DaysOfTheWeek.Tuesday
            If chkThuTu.Checked Then ngay += DaysOfTheWeek.Wednesday
            If chkThuNam.Checked Then ngay += DaysOfTheWeek.Thursday
            If chkThuSau.Checked Then ngay += DaysOfTheWeek.Friday
            If chkThuBay.Checked Then ngay += DaysOfTheWeek.Saturday
            If chkChuNhat.Checked Then ngay += DaysOfTheWeek.Sunday
            If ngay = 0 Then
                MessageBox.Show("Chưa chọn ngày trong tuần!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                taskServices.Dispose()
                Exit Sub
            End If
            trig.DaysOfWeek = ngay
            task.Definition.Triggers.RemoveAt(0)
            task.Definition.Triggers.Add(trig)
            Dim act1 As ExecAction = CType(task.Definition.Actions(0).Clone, ExecAction)
            Dim act2 As ExecAction = CType(task.Definition.Actions(1).Clone, ExecAction)
            act1.Path = "taskkill"
            act1.Arguments = "/im BAC_PLAYER_MP3.exe"
            act2.Path = Application.StartupPath & "\BAC_PLAYER_MP3.exe"
            act2.Arguments = Convert.ToByte(chkPhatNgauNhien.Checked).ToString & " " & txtThoiGian.Value.ToString.Replace(",", "").Replace(".", "") & " " & Convert.ToByte(chkTatMay.Checked).ToString & " " & amluong.Value & " "
            Dim _lstNhac As String = ""
            For Each i As ListViewItem In lstMp3.Items
                _lstNhac &= i.Text & ";"
            Next
            If _lstNhac = "" Then
                MessageBox.Show("Chưa chọn bài hát!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                taskServices.Dispose()
                Exit Sub
            End If
            act2.Arguments &= """" & _lstNhac & """"
            task.Definition.Actions.Clear()
            task.Definition.Actions.Add(act1)
            task.Definition.Actions.Add(act2)
            task.RegisterChanges()
            MessageBox.Show("Cập nhật thành công !")
            treeThuMuc_AfterSelect(treeThuMuc, New TreeViewEventArgs(treeThuMuc.SelectedNode))
            gChiTietCauHinh.Enabled = False
            gDsBaiHat.Enabled = False
            taskServices.Dispose()
        Else
            Try
                If txtTenCauHinh.Text = "" Then
                    MessageBox.Show("Chưa nhập tên cấu hình!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                Dim taskServices As New Microsoft.Win32.TaskScheduler.TaskService()
                Dim task As TaskDefinition = taskServices.NewTask

                task.RegistrationInfo.Description = txtMoTa.Text
                Dim trig As New WeeklyTrigger
                trig.Enabled = chkDangHoatDong.Checked
                trig.StartBoundary = New DateTime(Today.Year, Today.Month, Today.Day, txtBatDau.Value.Hour, txtBatDau.Value.Minute, txtBatDau.Value.Second)
                Dim ngay As Integer = 0
                If chkThuHai.Checked Then ngay += DaysOfTheWeek.Monday
                If chkThuBa.Checked Then ngay += DaysOfTheWeek.Tuesday
                If chkThuTu.Checked Then ngay += DaysOfTheWeek.Wednesday
                If chkThuNam.Checked Then ngay += DaysOfTheWeek.Thursday
                If chkThuSau.Checked Then ngay += DaysOfTheWeek.Friday
                If chkThuBay.Checked Then ngay += DaysOfTheWeek.Saturday
                If chkChuNhat.Checked Then ngay += DaysOfTheWeek.Sunday
                If ngay = 0 Then
                    MessageBox.Show("Chưa chọn ngày trong tuần!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    taskServices.Dispose()
                    Exit Sub
                End If
                trig.DaysOfWeek = ngay
                task.Triggers.Add(trig)
                Dim act1 As New ExecAction
                act1.Path = "taskkill"
                act1.Arguments = "/im BAC_PLAYER_MP3.exe"
                Dim act2 As New ExecAction
                act2.Path = Application.StartupPath & "\BAC_PLAYER_MP3.exe"
                act2.Arguments = Convert.ToByte(chkPhatNgauNhien.Checked).ToString & " " & txtThoiGian.Value.ToString.Replace(",", "").Replace(".", "") & " " & Convert.ToByte(chkTatMay.Checked).ToString & " " & amluong.Value & " "
                Dim _lstNhac As String = ""
                For Each i As ListViewItem In lstMp3.Items
                    _lstNhac &= i.Text & ";"
                Next
                If _lstNhac = "" Then
                    MessageBox.Show("Chưa chọn bài hát!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    taskServices.Dispose()
                    Exit Sub
                End If
                act2.Arguments &= """" & _lstNhac & """"
                task.Actions.Add(act1)
                task.Actions.Add(act2)
                taskServices.GetFolder("BACPLAYER").RegisterTaskDefinition(txtTenCauHinh.Text, task)
                MessageBox.Show("Cập nhật thành công !")
                treeThuMuc_AfterSelect(treeThuMuc, New TreeViewEventArgs(treeThuMuc.SelectedNode))
                gChiTietCauHinh.Enabled = False
                gDsBaiHat.Enabled = False
                taskServices.Dispose()

                isUpdate = True
                tt1.Enabled = True
                gThuMuc.Enabled = True
                lstTask.Enabled = True
                gChiTietCauHinh.Enabled = False
                gDsBaiHat.Enabled = False
                txtTenCauHinh.ForeColor = Color.Blue
                txtTenCauHinh.ReadOnly = True
                txtTenCauHinh.Focus()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If


    End Sub



    Private Sub btnXoaTacVu_Click(sender As System.Object, e As System.EventArgs) Handles btnXoaTacVu.Click
        If lstTask.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Bạn có chắc muốn xóa tác vụ vừa chọn không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then Exit Sub
        Dim taskServices As New Microsoft.Win32.TaskScheduler.TaskService()
        taskServices.GetFolder("BACPLAYER").DeleteTask(txtTenCauHinh.Text)

        MessageBox.Show("Xóa tác vụ thành công !")
        treeThuMuc_AfterSelect(treeThuMuc, New TreeViewEventArgs(treeThuMuc.SelectedNode))
        gChiTietCauHinh.Enabled = False
        gDsBaiHat.Enabled = False
        taskServices.Dispose()
    End Sub


    Private Sub btnThoat_Click(sender As System.Object, e As System.EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub


    Private Sub btnThuVienBaiHat_Click(sender As System.Object, e As System.EventArgs) Handles btnThuVienBaiHat.Click

    End Sub


    Private Sub btnThemNhac_Click(sender As System.Object, e As System.EventArgs) Handles btnThemNhac.Click
        Dim f As New frmThuVienNhac
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim strListMp3 As String = f.strListMp3
            For Each s As String In strListMp3.Split(";")
                If s.Trim = "" Then Continue For
                s = "[   ]. " & s
                lstMp3.Items.Add(s)
            Next
        End If
    End Sub

    Private Sub btnXoaNhac_Click(sender As System.Object, e As System.EventArgs) Handles btnXoaNhac.Click
        If lstMp3.SelectedItems.Count = 0 Then Exit Sub
        'If MessageBox.Show("Xóa bài hát bạn vừa chọn khỏi danh sách?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        lstMp3.Items.Remove(lstMp3.SelectedItems(0))
        'End If
    End Sub

    Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs) Handles btnUp.Click
        If lstMp3.SelectedItems.Count = 0 Then Exit Sub
        If lstMp3.SelectedItems(0).Index = 0 Then Exit Sub
        Dim index = lstMp3.SelectedItems(0).Index
        Dim str As String = lstMp3.SelectedItems(0).Text
        lstMp3.Items.Remove(lstMp3.SelectedItems(0))
        lstMp3.Items.Insert(index - 1, str)
        lstMp3.Items(index - 1).Selected = True
    End Sub

    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs) Handles btnDown.Click
        If lstMp3.SelectedItems.Count = 0 Then Exit Sub
        If lstMp3.SelectedItems(0).Index = lstMp3.Items.Count - 1 Then Exit Sub
        Dim index = lstMp3.SelectedItems(0).Index
        Dim str As String = lstMp3.SelectedItems(0).Text
        lstMp3.Items.Remove(lstMp3.SelectedItems(0))
        lstMp3.Items.Insert(index + 1, str)
        lstMp3.Items(index + 1).Selected = True
    End Sub





    Private Sub btnChayTacVu_Click(sender As System.Object, e As System.EventArgs) Handles btnChayTacVu.Click
        If lstTask.SelectedItems.Count = 0 Then Exit Sub
        Dim taskServices As New Microsoft.Win32.TaskScheduler.TaskService()
        taskServices.GetTask("BACPLAYER\" & txtTenCauHinh.Text).Run()
    End Sub


    Private Sub btnThemMoiTacVu_Click(sender As System.Object, e As System.EventArgs) Handles btnThemMoiTacVu.Click
        isUpdate = False

        tt1.Enabled = False
        gThuMuc.Enabled = False
        lstTask.Enabled = False
        gChiTietCauHinh.Enabled = True
        gDsBaiHat.Enabled = True
        txtTenCauHinh.ForeColor = Color.Red
        txtTenCauHinh.ReadOnly = False
        txtTenCauHinh.Focus()


    End Sub

    Private Sub mDungHoacHoatDong_Click(sender As System.Object, e As System.EventArgs) Handles mDungHoacHoatDong.Click

    End Sub

    Private Sub TinhThoiGian()
        If txtBatDau.Value >= txtKetThuc.Value Then
            MessageBox.Show("Vui lòng nhập thời gian kết thúc hợp lệ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim hientai As New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, 0)
            txtBatDau.Value = hientai.AddMinutes(5)
            txtKetThuc.Value = hientai.AddMinutes(5).AddSeconds(15)
            txtThoiGian.Value = (txtKetThuc.Value - txtBatDau.Value).TotalSeconds
        End If
    End Sub

    Private Sub txtBatDau_ValueChanged(sender As Object, e As EventArgs) Handles txtBatDau.ValueChanged
        'TinhThoiGian()
    End Sub

    Private Sub txtKetThuc_ValueChanged(sender As Object, e As EventArgs) Handles txtKetThuc.ValueChanged
        'TinhThoiGian()
    End Sub

    Private Sub amluong_Scroll(sender As Object, e As EventArgs) Handles amluong.Scroll

    End Sub

    Private Sub amluong_ValueChanged(sender As Object, e As EventArgs) Handles amluong.ValueChanged
        lblAmLuong.Text = "( Phát theo " & amluong.Value & "% âm lượng máy tính )"
    End Sub

    Private Sub btnThietLapAmLuong_Click(sender As Object, e As EventArgs) Handles btnThietLapAmLuong.Click
        If lstMp3.SelectedItems.Count = 0 Then Exit Sub
        Dim index = lstMp3.SelectedItems(0).Index
        Dim str As String = lstMp3.SelectedItems(0).Text
        Dim f As New frmAmLuongFile
        f.fileName = str
        If f.ShowDialog() = DialogResult.OK Then
            lstMp3.SelectedItems(0).Text = f.fileKetQua
        End If
    End Sub
End Class
