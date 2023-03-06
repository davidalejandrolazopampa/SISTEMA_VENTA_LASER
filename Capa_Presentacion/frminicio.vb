Imports Capa_Datos
Imports Capa_Logica
Public Class frminicio
    Dim fu As New Fusuario
    Dim eu As New Eusuario
    Sub hablar(ByVal texto As String)
        Dim audio = createObject("SAPI.spvoice")
        audio.volume = 100
        'velocidad de la voz
        audio.rate = 0
        audio.speak(texto)
    End Sub
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Try
            If txtususario.Text <> "" And txtcontraseña.Text <> "" Then
                Dim dt As New DataTable
                eu._users = txtususario.Text
                eu._passwords = txtcontraseña.Text
                dt = fu.validarusuario(eu)
                If dt.Rows.Count > 0 Then
                    Timer1.Start()

                    Dim nivel As String
                    nivel = dt.Rows(0)("nivel")
                    If nivel = "Vendedor" Then
                        btnaceptar.Enabled = False
                        hablar("Bienvenido" & txtususario.Text & "Prioridad Vendedor")
                        My.Forms.frmPadre.panel3.Visible = False
                    ElseIf nivel = "Administrador" Then
                        btnaceptar.Enabled = False
                        hablar("Bienvenido" & txtususario.Text & "Prioridad Administrador")
                        My.Forms.frmPadre.panel1.Visible = False
                    End If
                Else
                    Static intento As Integer
                    intento = intento + 1
                    lblAdvertencia.Text = ("Estimado usuario te quedan " & (3 - intento) & " intentos")
                    hablar("Usuario y/o Contraseña invalidos le quedan" & (3 - intento) & " intentos")
                    If intento = 3 Then
                        hablar("El Sistema se cerrara, Gracias")
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            frmPadre.Show()
        End If
    End Sub

    Private Sub pcSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia")
        If opc = Windows.Forms.DialogResult.Yes Then
            End
        Else : opc = Windows.Forms.DialogResult.No
            Return
        End If
        Me.Hide()
    End Sub



    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblhora.Text = TimeOfDay
    End Sub

    Private Sub frminicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Start()
        lblhora.Text = TimeOfDay
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        txtususario.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        txtcontraseña.Visible = True
    End Sub

    Private Sub PictureBox3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.DoubleClick
        txtususario.Visible = False
    End Sub

    Private Sub PictureBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.DoubleClick
        txtcontraseña.Visible = False
    End Sub
End Class