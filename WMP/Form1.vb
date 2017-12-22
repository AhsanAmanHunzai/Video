Public Class Form1

   
    
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Video File | *.mp4; *.mpg;"
        OpenFileDialog1.InitialDirectory = "E:\"
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        Else
            TextBox1.Text = OpenFileDialog1.FileName.ToString
            AxWindowsMediaPlayer1.URL = TextBox1.Text
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button5.Text = "MUTE" Then
            AxWindowsMediaPlayer1.settings.mute = True
            Button5.Text = "VOICE"
        Else
            AxWindowsMediaPlayer1.settings.mute = False
            Button5.Text = "MUTE"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer1.settings.rate = 0.5
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer1.settings.rate = 1
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        AxWindowsMediaPlayer1.settings.rate = 1.5
    End Sub
End Class
