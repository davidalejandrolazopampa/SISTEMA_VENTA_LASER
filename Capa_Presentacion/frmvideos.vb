
Public Class frmvideos
    Private Sub btnplay_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        play.Ctlcontrols.play()
    End Sub
    Private Sub btnsustituir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsustituir.Click
        If rb1.Checked = True Then
            play.URL = "D:\videos\IP6S.mp4"
        ElseIf rb2.Checked = True Then
            play.URL = "D:\videos\LGG4.mp4"
        ElseIf rb3.Checked = True Then
            play.URL = "D:\videos\MotoXP.mp4"
        ElseIf rb4.Checked = True Then
            play.URL = "D:\videos\MotoXS.mp4"
        ElseIf rb5.Checked = True Then
            play.URL = "D:\videos\SS6.mp4"
        ElseIf rb6.Checked = True Then
            play.URL = "D:\videos\Z3.mp4"
        ElseIf rb7.Checked = True Then
            play.URL = "D:\videos\Z5.mp4"
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class