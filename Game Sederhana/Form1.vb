Public Class Form1

    Dim tulisan As String
    Dim i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tulisan = "MOUSE MOTION "
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If i.Equals(tulisan.Length) Then
            judul.Text = ""
            i = 0
        End If
        judul.Text = tulisan.Substring(0, i)
        i = i + 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        player1.Left = player1.Left + 5
        If player1.Left > 1341 Then
            player1.Left = 0
        End If
        player4.Left = player4.Left - 5
        If player4.Left < 0 Then
            player4.Left = 1341
        End If
        player2.Left = player2.Left - 2
        If player2.Left < 0 Then
            player2.Left = 1341
        End If
        player3.Left = player3.Left + 2
        If player3.Left > 1341 Then
            player3.Left = 0
        End If
        rpl.Left = rpl.Left + 3
        If rpl.Left > 1336 Then
            rpl.Left = -332
        End If
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Application.Exit()
        My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
    End Sub

    Private Sub tutorial_Click(sender As Object, e As EventArgs) Handles tutorial.Click
        tutor.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
    End Sub

    Private Sub play_Click(sender As Object, e As EventArgs) Handles play.Click
        level.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.pop, AudioPlayMode.Background)
    End Sub
End Class
