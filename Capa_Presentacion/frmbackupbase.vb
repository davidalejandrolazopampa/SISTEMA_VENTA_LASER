Imports Capa_Datos
Imports Capa_Logica
Public Class frmbackupbase

    Private Sub btnbackupbase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbackupbase.Click
        Try
            Dim func As New fbackup
            If func.backupbase Then
                MessageBox.Show("Backup Generado Satisfactoriamente", "BAckup DB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Backup No puede ser Generado", "BAckup DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia BBDD BackUp")
        If opc = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else : opc = Windows.Forms.DialogResult.No
            Return
        End If
        Me.Hide()
    End Sub
End Class