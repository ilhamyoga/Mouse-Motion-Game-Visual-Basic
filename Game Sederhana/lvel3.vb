Public Class lvel3

    Dim waktu As String
    Dim fl, ss, mm As Integer

    Private Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As POINTAPI) As Integer
    Private Structure POINTAPI
        Dim X As Integer
        Dim Y As Integer
    End Structure
    Sub pss()
        Dim p As POINTAPI
        GetCursorPos(p)
        Player.Left = p.X - 7
        Player.Top = p.Y - 5
    End Sub
    Sub Over()
        fl = fl + 1
        foul.Text = fl
        Player.Left = 53
        Player.Top = 178
        Timer1.Enabled = False
        My.Computer.Audio.Play(My.Resources.bom, AudioPlayMode.Background)
        MsgBox("Coba Lagi")
    End Sub
    Sub cpoint()
        fl = fl + 1
        foul.Text = fl
        Player.Left = 1286
        Player.Top = 178
        Timer3.Enabled = False
        My.Computer.Audio.Play(My.Resources.bom, AudioPlayMode.Background)
        MsgBox("Coba Lagi")
    End Sub
    Sub cpoint1()
        fl = fl + 1
        foul.Text = fl
        Player.Left = 555
        Player.Top = 555
        Timer4.Enabled = False
        My.Computer.Audio.Play(My.Resources.bom, AudioPlayMode.Background)
        MsgBox("Coba Lagi")
    End Sub
    Sub fns()
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        Player.Visible = False
        MsgBox(" SELAMAT ANDA BERHASIL" & vbCrLf & " Waktu Anda " & waktu)
    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Me.Close()
        level.Show()
        My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pss()
        If Player.Bounds.IntersectsWith(b1.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b2.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b3.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b4.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b5.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b6.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b7.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b8.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b9.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b10.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b11.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b12.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(b13.Bounds) Then
            Over()
        End If
        If Player.Bounds.IntersectsWith(cp1.Bounds) Then
            Timer1.Enabled = False
            Timer3.Enabled = True
            Timer4.Enabled = False
        End If
        If Player.Bounds.IntersectsWith(cp2.Bounds) Then
            Timer1.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = True
        End If
        If Player.Bounds.IntersectsWith(finish.Bounds) Then
            fns()
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        pss()
        If Player.Bounds.IntersectsWith(b1.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b2.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b3.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b4.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b5.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b6.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b7.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b8.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b9.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b10.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b11.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b12.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(b13.Bounds) Then
            cpoint()
        End If
        If Player.Bounds.IntersectsWith(cp2.Bounds) Then
            Timer1.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = True
        End If
        If Player.Bounds.IntersectsWith(finish.Bounds) Then
            fns()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        pss()
        If Player.Bounds.IntersectsWith(b1.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b2.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b3.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b4.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b5.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b6.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b7.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b8.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b9.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b10.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b11.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b12.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(b13.Bounds) Then
            cpoint1()
        End If
        If Player.Bounds.IntersectsWith(cp1.Bounds) Then
            Timer1.Enabled = False
            Timer3.Enabled = True
            Timer4.Enabled = False
        End If
        If Player.Bounds.IntersectsWith(finish.Bounds) Then
            fns()
        End If
    End Sub

    Private Sub Player_Click(sender As Object, e As EventArgs) Handles Player.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ss = ss + 1
        If ss >= 60 Then
            ss = 0
            mm = mm + 1
        End If
        waktu = Format(mm, "00") & ":" & Format(ss, "00")
        tmr.Text = waktu
    End Sub
End Class