Public Class frmreporteproductos

    Private Sub frmreporteproductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'SistemaVentasLASERDataSet.mostrar_producto' Puede moverla o quitarla según sea necesario.
            Me.mostrar_productoTableAdapter.Fill(Me.SistemaVentasLASERDataSet.mostrar_producto)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()
        End Try

    End Sub
End Class