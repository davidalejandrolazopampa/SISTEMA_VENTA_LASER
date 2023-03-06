<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lineas_telefonicas
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.claro = New System.Windows.Forms.PictureBox()
        Me.entel = New System.Windows.Forms.PictureBox()
        Me.movistar = New System.Windows.Forms.PictureBox()
        Me.bitel = New System.Windows.Forms.PictureBox()
        Me.tuentii = New System.Windows.Forms.PictureBox()
        CType(Me.claro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.movistar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bitel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tuentii, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(184, 303)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(62, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X ""CLOSE"""
        '
        'claro
        '
        Me.claro.Image = Global.Capa_Presentacion.My.Resources.Resources._2000px_Claro_svg
        Me.claro.Location = New System.Drawing.Point(42, 33)
        Me.claro.Name = "claro"
        Me.claro.Size = New System.Drawing.Size(100, 94)
        Me.claro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.claro.TabIndex = 1
        Me.claro.TabStop = False
        '
        'entel
        '
        Me.entel.Image = Global.Capa_Presentacion.My.Resources.Resources.cPcWXQ0t
        Me.entel.Location = New System.Drawing.Point(42, 189)
        Me.entel.Name = "entel"
        Me.entel.Size = New System.Drawing.Size(100, 94)
        Me.entel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.entel.TabIndex = 2
        Me.entel.TabStop = False
        '
        'movistar
        '
        Me.movistar.Image = Global.Capa_Presentacion.My.Resources.Resources.img_share
        Me.movistar.Location = New System.Drawing.Point(276, 33)
        Me.movistar.Name = "movistar"
        Me.movistar.Size = New System.Drawing.Size(100, 94)
        Me.movistar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.movistar.TabIndex = 3
        Me.movistar.TabStop = False
        '
        'bitel
        '
        Me.bitel.Image = Global.Capa_Presentacion.My.Resources.Resources.chips_claro_movistar_bitel_entel_por_mayor_y_menor_envios_21785_MPE20217490116_122014_O
        Me.bitel.Location = New System.Drawing.Point(276, 189)
        Me.bitel.Name = "bitel"
        Me.bitel.Size = New System.Drawing.Size(100, 94)
        Me.bitel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bitel.TabIndex = 4
        Me.bitel.TabStop = False
        '
        'tuentii
        '
        Me.tuentii.Image = Global.Capa_Presentacion.My.Resources.Resources.tuenti
        Me.tuentii.Location = New System.Drawing.Point(162, 113)
        Me.tuentii.Name = "tuentii"
        Me.tuentii.Size = New System.Drawing.Size(100, 94)
        Me.tuentii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tuentii.TabIndex = 5
        Me.tuentii.TabStop = False
        '
        'Lineas_telefonicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(419, 345)
        Me.Controls.Add(Me.tuentii)
        Me.Controls.Add(Me.bitel)
        Me.Controls.Add(Me.movistar)
        Me.Controls.Add(Me.entel)
        Me.Controls.Add(Me.claro)
        Me.Controls.Add(Me.LinkLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lineas_telefonicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lineas_telefonicas"
        CType(Me.claro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.movistar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bitel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tuentii, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents claro As System.Windows.Forms.PictureBox
    Friend WithEvents entel As System.Windows.Forms.PictureBox
    Friend WithEvents movistar As System.Windows.Forms.PictureBox
    Friend WithEvents bitel As System.Windows.Forms.PictureBox
    Friend WithEvents tuentii As System.Windows.Forms.PictureBox
End Class
