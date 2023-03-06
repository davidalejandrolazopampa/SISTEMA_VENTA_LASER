Imports Capa_Datos
Imports Capa_Logica
Public Class frmPadre
    Sub hablar(ByVal texto As String)
        Dim audio = createObject("SAPI.spvoice")
        audio.volume = 100
        'velocidad de la voz
        audio.rate = 0
        audio.speak(texto)
    End Sub
    Private Sub misonido()
        Dim r As String
        r = My.Application.Info.DirectoryPath
        Dim sonido As System.Media.SoundPlayer
        sonido = New System.Media.SoundPlayer(r + "\button-09.WAV")
        sonido.Play()
    End Sub
    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        'Centrar el Panel
        Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        ' Captura el Tamaño del Monitor
        Dim ancho As Int32 = (Me.Width - panel3.Width) \ 2
        panel3.Location = New Point(ancho, panel3.Location.Y)
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia")
        If opc = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else : opc = Windows.Forms.DialogResult.No
            Return
        End If
        Me.Hide()
    End Sub

    Private Sub frmPadre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblfecha.Text = DateTime.Now.ToShortDateString()
        lbluser.Text = "Usuario: " & frminicio.txtususario.Text
        lblhora.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        lblhora.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriaToolStripMenuItem.Click
        frmcategoria.MdiParent = Me
        frmcategoria.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        frmproducto.MdiParent = Me
        frmproducto.Show()
    End Sub

  

    Private Sub ventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ventas.Click
        frmventa.MdiParent = Me
        frmventa.Show()
    End Sub

    Private Sub reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reporte.Click
        frmreporteproductos.MdiParent = Me
        frmreporteproductos.Show()
    End Sub

    Private Sub videos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles videos.Click
        frmvideos.MdiParent = Me
        frmvideos.Show()
    End Sub

    Private Sub servicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles servicio.Click
        frmserviciotecnico.MdiParent = Me
        frmserviciotecnico.Show()
    End Sub

    Private Sub backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backup.Click
        frmbackupbase.MdiParent = Me
        frmbackupbase.Show()
    End Sub

    Private Sub EntelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntelToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("http://www.entel.pe/portabilidad/?gclid=CjwKEAiAgvyxBRDmuviAj67g-XQSJABTLMcH-09TavpHCqt0ArMwzsdG8ebpo-AEvzbxefiyxuoKHRoCrWLw_wcB")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BitelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitelToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("http://www.bitel.com.pe/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MovistarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovistarToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("http://www.movistar.com.pe/movil/smartphones?gclid=CjwKEAiAgvyxBRDmuviAj67g-XQSJABTLMcHf1fH2b8CZxeYNRoNiylIxDhSrykeagPQc-hR72aXaBoCi_fw_wcB")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClaroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClaroToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("http://www.claro.com.pe/wps/portal/pe/sc/personas?gclid=CjwKEAiAgvyxBRDmuviAj67g-XQSJABTLMcHYBklrpgwM_qqpeGiTi39hnWUqMS-oFilvh1q_-ra7BoCaLfw_wcB")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TuentiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TuentiToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("https://www.tuenti.pe/?utm_source=Google&utm_medium=SEM_DTXT&utm_campaign=Tuenti_Search_Brand")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usuario.Click
        frmusuarios.MdiParent = Me
        frmusuarios.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        frmcliente.MdiParent = Me
        frmcliente.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        hablar("Detalle de Productos")
        frmreporteproductos.MdiParent = Me
        frmreporteproductos.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        hablar("Clientes")
        frmcliente.MdiParent = Me
        frmcliente.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        hablar("Videos")
        frmvideos.MdiParent = Me
        frmvideos.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        hablar("Planes Telefonicos")
        Lineas_telefonicas.MdiParent = Me
        Lineas_telefonicas.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        hablar("Listado de Productos")
        listaproductos.MdiParent = Me
        listaproductos.Show()
    End Sub

    Private Sub TOLVENTAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOLVENTAS.Click
        hablar("Realizar venta")
        frmventaUsuario.MdiParent = Me
        frmventaUsuario.Show()
    End Sub

    Private Sub TOLCONSULTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOLCONSULTA.Click
        hablar("Servicio Tecnico")
        frmserviciotecnico.MdiParent = Me
        frmserviciotecnico.Show()
    End Sub

    Private Sub ToolStripButton5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton5.MouseHover
        Call misonido()
    End Sub

    Private Sub ToolStripButton4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton4.MouseHover
        Call misonido()
    End Sub
    Private Sub ToolStripButton3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton3.MouseHover
        Call misonido()
    End Sub
    Private Sub ToolStripButton2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton2.MouseHover
        Call misonido()
    End Sub
    Private Sub ToolStripButton1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton1.MouseHover
        Call misonido()
    End Sub

    Private Sub TOLCONSULTA_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TOLCONSULTA.MouseHover
        Call misonido()
    End Sub

    Private Sub TOLVENTAS_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TOLVENTAS.MouseHover
        Call misonido()
    End Sub
End Class