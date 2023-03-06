Imports Capa_Datos
Imports Capa_Logica
Public Class frmbienvenida2
    Private pict As PictureBox()
    Private count As Integer = 0
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Hide()
        frminicio.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        If count < 5 Then
            pict(count).BackgroundImage = Capa_Presentacion.My.Resources.Circle2
            count += 1
            label1.Text = "Cargando al " & (count * 20) & " %"
        Else
            Timer1.Enabled = False
            PictureBox6.Visible = True
        End If
    End Sub
    Private Sub frmbienvenida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        pict = New PictureBox(4) {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5}
        PictureBox6.Visible = False
    End Sub
End Class