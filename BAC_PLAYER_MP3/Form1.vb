Imports System.IO
Imports NAudio.Wave


Public Class Form1

    Private waveOutDevice As IWavePlayer
    Private mp3FileReader As Mp3FileReader

    Private listMp3() As String
    Private indexMp3 As Integer

    Private timeStop As Integer = 1
    Private timeStart As Integer = 0
    Private tatMay As Boolean = True

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim fStream As FileStream
        Dim sReader As StreamReader

        Dim parm() As String = Environment.GetCommandLineArgs()
        If parm.Length <= 1 Then Exit Sub

        timeStop = Convert.ToInt32(parm(2))
        tatMay = Convert.ToByte(parm(3))
        listMp3 = parm(4).Split(";")
        'listMp3 = "E:\BACPLAYER\BACPLAYER\BAC_PLAYER_MP3\bin\Debug\NhacMp3\1.mp3;E:\BACPLAYER\BACPLAYER\BAC_PLAYER_MP3\bin\Debug\NhacMp3\3.mp3;E:\BACPLAYER\BACPLAYER\BAC_PLAYER_MP3\bin\Debug\NhacMp3\4.mp3".Split(";")
        'If Now.Hour <> 9 And Now.Hour <> 2 Then
        If File.Exists(Path.Combine(Application.StartupPath, "NgaySinh.txt")) Then
            fStream = New FileStream(Path.Combine(Application.StartupPath, "NgaySinh.txt"), FileMode.OpenOrCreate)
            sReader = New StreamReader(fStream)
            While Not sReader.EndOfStream
                Dim d As Object = sReader.ReadLine()
                If Convert.ToDateTime(d).Day = Today.Day And Convert.ToDateTime(d).Month = Today.Month Then
                    listMp3(0) = "HappyBirthDay.mp3"
                    Exit While
                End If
            End While
            sReader.Close()
            fStream.Dispose()
        End If
        'End If


        If Convert.ToByte(parm(1) = 1) Then
            Dim arr As New List(Of String)
            For Each s As String In listMp3
                If s.Trim = "" Then Continue For
                arr.Add(s)
            Next
            Dim arrTmp As New List(Of String)
            While arr.Count > 0
                Dim index As Integer = New Random().Next(arr.Count)
                arrTmp.Add(arr(index))
                arr.RemoveAt(index)
            End While
            listMp3 = arrTmp.ToArray
        End If

        For Each s As String In listMp3
            If s.Trim = "" Then Continue For
            lstBaiHat.Items.Add(s)
        Next

        waveOutDevice = New WaveOut()
        waveOutDevice.Volume = 0.2F
        indexMp3 = 0
        AddHandler waveOutDevice.PlaybackStopped, AddressOf NextSong
        NextSong(waveOutDevice, New StoppedEventArgs())

        tm.Enabled = True

        prc.Value = 0
        prc.Maximum = timeStop


    End Sub

    Public Sub NextSong(sender As Object, e As StoppedEventArgs)
        If listMp3.Length = indexMp3 Then indexMp3 = 0
        'If listMp3.Length = indexMp3 Then
        '    RemoveHandler waveOutDevice.PlaybackStopped, AddressOf NextSong
        '    waveOutDevice.Dispose()
        '    mp3FileReader.Dispose()
        '    Application.Exit()
        '    Exit Sub
        'End If
        Try
            Me.Text = listMp3(indexMp3)
            mp3FileReader = New Mp3FileReader(Application.StartupPath & "\NhacMp3\" & listMp3(indexMp3))
            waveOutDevice.Init(mp3FileReader)
            waveOutDevice.Play()
            indexMp3 += 1
        Catch ex As Exception
            indexMp3 += 1
            NextSong(waveOutDevice, New StoppedEventArgs())
        End Try

    End Sub

    Private Sub tm_Tick(sender As System.Object, e As System.EventArgs) Handles tm.Tick

        prc.Value = timeStart

        timeStart += 1
        'lblThoiGian.Text = Math.Floor((timeStart / 60)) & ":" & Math.Round((timeStart Mod 60), 0, MidpointRounding.AwayFromZero) & "s / " & (timeStop / 60) & " phút"
        lblThoiGian.Text = timeStart & "s / " & timeStop & "s"


        If timeStart > timeStop Then
            If waveOutDevice.PlaybackState <> PlaybackState.Stopped Then waveOutDevice.Stop()
            'For i As Integer = 0 To 101
            '    SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
            'Next
            If tatMay = True Then
                System.Diagnostics.Process.Start("shutdown", "-s -t 00")
            End If
            Application.Exit()
        End If
        Try
            If timeStart <= 4 Then waveOutDevice.Volume += 0.2F
        Catch ex As Exception
        End Try
        Try
            If timeStart >= timeStop - 5 Then waveOutDevice.Volume -= 0.1F
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Try
            If waveOutDevice.PlaybackState <> PlaybackState.Stopped Then waveOutDevice.Stop()
        Catch ex As Exception
        End Try
        Application.Exit()
    End Sub


    Private Sub btnOpenFile_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs)

    End Sub
End Class




Public Class Sound
    Dim nircmd As String
    Const MAXVOL As Integer = 65535

    Public Sub New(ByVal nircmd_location As String)
        nircmd = nircmd_location
    End Sub

    Public Sub setVol(ByVal level As Integer)

        Dim p As New ProcessStartInfo
        p.FileName = nircmd
        p.Arguments = "setsysvolume " & (MAXVOL * (level / 100)).ToString
        Process.Start(p)

    End Sub
End Class


