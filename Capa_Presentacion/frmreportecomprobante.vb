Public Class frmreportecomprobante

    Private Sub frmreportecomprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaVentasLASERDataSet.generar_comprobante' Puede moverla o quitarla según sea necesario.
        Try
            Me.generar_comprobanteTableAdapter.Fill(Me.SistemaVentasLASERDataSet.generar_comprobante, idventa:=txtidventa.Text)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()
        End Try

    End Sub
End Class