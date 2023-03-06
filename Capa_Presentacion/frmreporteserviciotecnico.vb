Public Class frmreporteserviciotecnico

    Private Sub frmreporteserviciotecnico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Try
            Me.generar_comprobante_servicioTableAdapter.Fill(Me.SistemaVentasLASERDataSet.generar_comprobante_servicio, idservicio:=txtidservicio.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()
        End Try
    End Sub
End Class