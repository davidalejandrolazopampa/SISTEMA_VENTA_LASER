Public Class Lineas_telefonicas

    Private Sub entel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles entel.Click
        Try
            System.Diagnostics.Process.Start("http://www.entel.pe/portabilidad/?gclid=CjwKEAiAgvyxBRDmuviAj67g-XQSJABTLMcH-09TavpHCqt0ArMwzsdG8ebpo-AEvzbxefiyxuoKHRoCrWLw_wcB")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bitel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bitel.Click
        Try
            System.Diagnostics.Process.Start("http://www.bitel.com.pe/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub movistar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles movistar.Click
        Try
            System.Diagnostics.Process.Start("http://www.movistar.com.pe/movil/smartphones?gclid=CjwKEAiAgvyxBRDmuviAj67g-XQSJABTLMcHf1fH2b8CZxeYNRoNiylIxDhSrykeagPQc-hR72aXaBoCi_fw_wcB")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub claro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles claro.Click
        Try
            System.Diagnostics.Process.Start("http://www.claro.com.pe/wps/portal/pe/sc/personas?gclid=CjwKEAiAgvyxBRDmuviAj67g-XQSJABTLMcHYBklrpgwM_qqpeGiTi39hnWUqMS-oFilvh1q_-ra7BoCaLfw_wcB")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tuentii_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tuentii.Click
        Try
            System.Diagnostics.Process.Start("https://www.tuenti.pe/?utm_source=Google&utm_medium=SEM_DTXT&utm_campaign=Tuenti_Search_Brand")
        Catch ex As Exception

        End Try
    End Sub
    'Definir variables globales; estas van despues de la linea de inherits
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    'Estas tres subrutinas permiten desplazar el formulario. 
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))
        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe
        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class