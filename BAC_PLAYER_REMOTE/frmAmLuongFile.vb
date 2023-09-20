Imports System.IO
Public Class frmAmLuongFile


    Private Sub btnThoat_Click(sender As System.Object, e As System.EventArgs) Handles btnThoat.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Public strListMp3 As String = ""
    Private Sub btnChonDanhSach_Click(sender As System.Object, e As System.EventArgs) Handles btnChonDanhSach.Click
        If chkDacBiet.Checked Then
            Dim tempAmLuong As String = amluong.Value
            If amluong.Value < 10 Then
                tempAmLuong = "00" & amluong.Value
            ElseIf amluong.Value < 100 Then
                tempAmLuong = "0" & amluong.Value
            Else
                tempAmLuong = "100"
            End If
            fileKetQua = "[" & tempAmLuong & "]. " & fileNameBanDau
        Else
            fileKetQua = "[   ]. " & fileNameBanDau
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub chkDacBiet_CheckedChanged(sender As Object, e As EventArgs) Handles chkDacBiet.CheckedChanged
        If chkDacBiet.Checked Then
            amluong.Enabled = True
        Else
            amluong.Enabled = False
            amluong.Value = 100
        End If
    End Sub

    Public fileName As String
    Public fileNameBanDau As String
    Public thamso As String
    Public fileKetQua As String
    Private Sub frmAmLuongFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fileNameBanDau = fileName.Substring(7)
        txtFile.Text = fileNameBanDau
        thamso = fileName.Substring(0, 4).Substring(1)
        If thamso = "   " Then
            chkDacBiet.Checked = False
        Else
            chkDacBiet.Checked = True
            amluong.Value = Convert.ToInt32(thamso)
        End If
    End Sub
    Private Sub amluong_ValueChanged(sender As Object, e As EventArgs) Handles amluong.ValueChanged
        lblAmLuong.Text = "( Phát theo " & amluong.Value & "% âm lượng máy tính )"
    End Sub

End Class
