<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreporteserviciotecnico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.generar_comprobante_servicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaVentasLASERDataSet = New Capa_Presentacion.SistemaVentasLASERDataSet()
        Me.txtidservicio = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.generar_comprobante_servicioTableAdapter = New Capa_Presentacion.SistemaVentasLASERDataSetTableAdapters.generar_comprobante_servicioTableAdapter()
        CType(Me.generar_comprobante_servicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaVentasLASERDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generar_comprobante_servicioBindingSource
        '
        Me.generar_comprobante_servicioBindingSource.DataMember = "generar_comprobante_servicio"
        Me.generar_comprobante_servicioBindingSource.DataSource = Me.SistemaVentasLASERDataSet
        '
        'SistemaVentasLASERDataSet
        '
        Me.SistemaVentasLASERDataSet.DataSetName = "SistemaVentasLASERDataSet"
        Me.SistemaVentasLASERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtidservicio
        '
        Me.txtidservicio.Enabled = False
        Me.txtidservicio.Location = New System.Drawing.Point(161, 41)
        Me.txtidservicio.Name = "txtidservicio"
        Me.txtidservicio.Size = New System.Drawing.Size(52, 20)
        Me.txtidservicio.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.generar_comprobante_servicioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.reportedeservicioTecnico.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(738, 642)
        Me.ReportViewer1.TabIndex = 2
        '
        'generar_comprobante_servicioTableAdapter
        '
        Me.generar_comprobante_servicioTableAdapter.ClearBeforeFill = True
        '
        'frmreporteserviciotecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 642)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtidservicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmreporteserviciotecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":::--_Servicio Tecnico_--:::"
        CType(Me.generar_comprobante_servicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaVentasLASERDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtidservicio As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents generar_comprobante_servicioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SistemaVentasLASERDataSet As Capa_Presentacion.SistemaVentasLASERDataSet
    Friend WithEvents generar_comprobante_servicioTableAdapter As Capa_Presentacion.SistemaVentasLASERDataSetTableAdapters.generar_comprobante_servicioTableAdapter
End Class
