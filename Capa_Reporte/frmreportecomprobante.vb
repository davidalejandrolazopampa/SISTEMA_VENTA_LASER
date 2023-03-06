Imports Capa_Presentacion
Imports Capa_Datos
Imports Capa_Logica
Public Class frmreportecomprobante

    Private Sub frmreportecomprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class