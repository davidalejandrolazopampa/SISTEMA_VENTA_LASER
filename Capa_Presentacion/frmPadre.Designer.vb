<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPadre
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
        Me.panel3 = New System.Windows.Forms.MenuStrip()
        Me.ingreso = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ventas = New System.Windows.Forms.ToolStripMenuItem()
        Me.reporte = New System.Windows.Forms.ToolStripMenuItem()
        Me.videos = New System.Windows.Forms.ToolStripMenuItem()
        Me.telefono = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovistarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClaroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TuentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.servicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.backup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TOLVENTAS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TOLCONSULTA = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.panel3.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.Aqua
        Me.panel3.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.panel3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ingreso, Me.ClientesToolStripMenuItem1, Me.ventas, Me.reporte, Me.videos, Me.telefono, Me.servicio, Me.usuario, Me.backup})
        Me.panel3.Location = New System.Drawing.Point(0, 0)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1187, 29)
        Me.panel3.TabIndex = 13
        Me.panel3.Text = "MenuStrip"
        '
        'ingreso
        '
        Me.ingreso.BackColor = System.Drawing.Color.Transparent
        Me.ingreso.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriaToolStripMenuItem, Me.ProductosToolStripMenuItem})
        Me.ingreso.Image = Global.Capa_Presentacion.My.Resources.Resources.books
        Me.ingreso.Name = "ingreso"
        Me.ingreso.Size = New System.Drawing.Size(117, 25)
        Me.ingreso.Text = "&Productos"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.Add_To_Basket
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.CategoriaToolStripMenuItem.Text = "&Tipo"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.Box_Empty
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.ProductosToolStripMenuItem.Text = "&Productos"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Image = Global.Capa_Presentacion.My.Resources.Resources.Add_User
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(101, 25)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'ventas
        '
        Me.ventas.Image = Global.Capa_Presentacion.My.Resources.Resources.Add_To_Basket
        Me.ventas.Name = "ventas"
        Me.ventas.Size = New System.Drawing.Size(91, 25)
        Me.ventas.Text = "&Ventas"
        '
        'reporte
        '
        Me.reporte.Image = Global.Capa_Presentacion.My.Resources.Resources.paper
        Me.reporte.Name = "reporte"
        Me.reporte.Size = New System.Drawing.Size(208, 25)
        Me.reporte.Text = "&Reporte de &Productos"
        '
        'videos
        '
        Me.videos.Image = Global.Capa_Presentacion.My.Resources.Resources.play
        Me.videos.Name = "videos"
        Me.videos.Size = New System.Drawing.Size(91, 25)
        Me.videos.Text = "&Videos"
        '
        'telefono
        '
        Me.telefono.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntelToolStripMenuItem, Me.BitelToolStripMenuItem, Me.MovistarToolStripMenuItem, Me.ClaroToolStripMenuItem, Me.TuentiToolStripMenuItem})
        Me.telefono.Image = Global.Capa_Presentacion.My.Resources.Resources.consejos_para_ahorrar_en_la_factura_de_telefono
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(206, 25)
        Me.telefono.Text = "Empresas Telefonicas"
        '
        'EntelToolStripMenuItem
        '
        Me.EntelToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.cPcWXQ0t
        Me.EntelToolStripMenuItem.Name = "EntelToolStripMenuItem"
        Me.EntelToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.EntelToolStripMenuItem.Text = "Entel"
        '
        'BitelToolStripMenuItem
        '
        Me.BitelToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.chips_claro_movistar_bitel_entel_por_mayor_y_menor_envios_21785_MPE20217490116_122014_O
        Me.BitelToolStripMenuItem.Name = "BitelToolStripMenuItem"
        Me.BitelToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.BitelToolStripMenuItem.Text = "Bitel"
        '
        'MovistarToolStripMenuItem
        '
        Me.MovistarToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.img_share
        Me.MovistarToolStripMenuItem.Name = "MovistarToolStripMenuItem"
        Me.MovistarToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.MovistarToolStripMenuItem.Text = "Movistar"
        '
        'ClaroToolStripMenuItem
        '
        Me.ClaroToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources._2000px_Claro_svg
        Me.ClaroToolStripMenuItem.Name = "ClaroToolStripMenuItem"
        Me.ClaroToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.ClaroToolStripMenuItem.Text = "Claro"
        '
        'TuentiToolStripMenuItem
        '
        Me.TuentiToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.tuenti
        Me.TuentiToolStripMenuItem.Name = "TuentiToolStripMenuItem"
        Me.TuentiToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.TuentiToolStripMenuItem.Text = "Tuenti"
        '
        'servicio
        '
        Me.servicio.Image = Global.Capa_Presentacion.My.Resources.Resources.serviciotecnico
        Me.servicio.Name = "servicio"
        Me.servicio.Size = New System.Drawing.Size(165, 25)
        Me.servicio.Text = "Servicio Tècnico"
        '
        'usuario
        '
        Me.usuario.Image = Global.Capa_Presentacion.My.Resources.Resources.Banned_User
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(99, 25)
        Me.usuario.Text = "&Usuario"
        '
        'backup
        '
        Me.backup.Image = Global.Capa_Presentacion.My.Resources.Resources.My_Icons
        Me.backup.Name = "backup"
        Me.backup.Size = New System.Drawing.Size(96, 25)
        Me.backup.Text = "BackUp"
        '
        'panel2
        '
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Controls.Add(Me.lblhora)
        Me.panel2.Controls.Add(Me.lblfecha)
        Me.panel2.Controls.Add(Me.lbluser)
        Me.panel2.Controls.Add(Me.btnmin)
        Me.panel2.Controls.Add(Me.btncerrar)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 1038)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1187, 42)
        Me.panel2.TabIndex = 14
        '
        'lblhora
        '
        Me.lblhora.BackColor = System.Drawing.Color.Transparent
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.SystemColors.Window
        Me.lblhora.Location = New System.Drawing.Point(3, 10)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(98, 20)
        Me.lblhora.TabIndex = 0
        Me.lblhora.Text = "22:02:00"
        Me.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.SystemColors.Window
        Me.lblfecha.Location = New System.Drawing.Point(995, 10)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(115, 25)
        Me.lblfecha.TabIndex = 2
        Me.lblfecha.Text = "18/11/2015"
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbluser
        '
        Me.lbluser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.SystemColors.Window
        Me.lbluser.Location = New System.Drawing.Point(212, 5)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(716, 28)
        Me.lbluser.TabIndex = 2
        Me.lbluser.Text = "Usuario: Ventas"
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnmin
        '
        Me.btnmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmin.BackColor = System.Drawing.Color.Cyan
        Me.btnmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmin.ForeColor = System.Drawing.Color.White
        Me.btnmin.Location = New System.Drawing.Point(1116, 1)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(36, 36)
        Me.btnmin.TabIndex = 1
        Me.btnmin.Text = "--"
        Me.btnmin.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Red
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(1151, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'panel1
        '
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.panel1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripSeparator9, Me.ToolStripButton4, Me.ToolStripSeparator2, Me.TOLVENTAS, Me.ToolStripSeparator5, Me.TOLCONSULTA, Me.ToolStripSeparator6, Me.ToolStripButton3, Me.ToolStripSeparator7, Me.ToolStripButton2, Me.ToolStripSeparator8, Me.ToolStripButton1})
        Me.panel1.Location = New System.Drawing.Point(0, 29)
        Me.panel1.Name = "panel1"
        Me.panel1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.panel1.Size = New System.Drawing.Size(133, 1009)
        Me.panel1.TabIndex = 18
        Me.panel1.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(130, 6)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.Capa_Presentacion.My.Resources.Resources.clientes
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(130, 132)
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(130, 6)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.Capa_Presentacion.My.Resources.Resources.kitsarticulos1
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(130, 132)
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(130, 6)
        '
        'TOLVENTAS
        '
        Me.TOLVENTAS.Image = Global.Capa_Presentacion.My.Resources.Resources.ventas
        Me.TOLVENTAS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TOLVENTAS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TOLVENTAS.Name = "TOLVENTAS"
        Me.TOLVENTAS.Size = New System.Drawing.Size(130, 132)
        Me.TOLVENTAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(130, 6)
        '
        'TOLCONSULTA
        '
        Me.TOLCONSULTA.Image = Global.Capa_Presentacion.My.Resources.Resources.servisdesk
        Me.TOLCONSULTA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TOLCONSULTA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TOLCONSULTA.Name = "TOLCONSULTA"
        Me.TOLCONSULTA.Size = New System.Drawing.Size(130, 132)
        Me.TOLCONSULTA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(130, 6)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.Capa_Presentacion.My.Resources.Resources.videpsss
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(130, 132)
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(130, 6)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Capa_Presentacion.My.Resources.Resources.reportesdeproductos
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(130, 132)
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(130, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Capa_Presentacion.My.Resources.Resources.telefono
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(130, 132)
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmPadre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.laserLogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1187, 1080)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "frmPadre"
        Me.Text = ".:LASER 2000 S.A.C. (VENTA DE EQUIPOS):."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel3 As System.Windows.Forms.MenuStrip
    Friend WithEvents ingreso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ventas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents reporte As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents videos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents telefono As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovistarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClaroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TuentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents servicio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents backup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents lblhora As System.Windows.Forms.Label
    Private WithEvents lblfecha As System.Windows.Forms.Label
    Private WithEvents lbluser As System.Windows.Forms.Label
    Private WithEvents btnmin As System.Windows.Forms.Button
    Private WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents usuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panel1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TOLVENTAS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TOLCONSULTA As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
