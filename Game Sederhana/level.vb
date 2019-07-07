Public Class level
    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Me.Close()
        Form1.Show()
        My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
    End Sub

    Private Sub lv1_Click(sender As Object, e As EventArgs) Handles lv1.Click
        lvel1.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
    End Sub

    Private Sub lv2_Click(sender As Object, e As EventArgs) Handles lv2.Click
        lvel2.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
    End Sub

    Private Sub lv3_Click(sender As Object, e As EventArgs) Handles lv3.Click
        lvel3.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
    End Sub
End Class