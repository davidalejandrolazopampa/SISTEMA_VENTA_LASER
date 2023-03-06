<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmusuarios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.cancelar = New System.Windows.Forms.PictureBox()
        Me.editar = New System.Windows.Forms.PictureBox()
        Me.guardar = New System.Windows.Forms.PictureBox()
        Me.nuevo = New System.Windows.Forms.PictureBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnivel = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.cancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(19, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(19, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(19, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nivel:"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(102, 31)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(286, 26)
        Me.txtusuario.TabIndex = 9
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(102, 70)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(286, 26)
        Me.txtpassword.TabIndex = 10
        '
        'cancelar
        '
        Me.cancelar.Image = Global.Capa_Presentacion.My.Resources.Resources.close
        Me.cancelar.Location = New System.Drawing.Point(499, 420)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(64, 50)
        Me.cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cancelar.TabIndex = 7
        Me.cancelar.TabStop = False
        '
        'editar
        '
        Me.editar.Image = Global.Capa_Presentacion.My.Resources.Resources.edit
        Me.editar.Location = New System.Drawing.Point(543, 349)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(64, 50)
        Me.editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.editar.TabIndex = 6
        Me.editar.TabStop = False
        '
        'guardar
        '
        Me.guardar.Image = Global.Capa_Presentacion.My.Resources.Resources.save
        Me.guardar.Location = New System.Drawing.Point(543, 349)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(64, 50)
        Me.guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.guardar.TabIndex = 5
        Me.guardar.TabStop = False
        '
        'nuevo
        '
        Me.nuevo.Image = Global.Capa_Presentacion.My.Resources.Resources._008_doc_edit
        Me.nuevo.Location = New System.Drawing.Point(449, 349)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(64, 50)
        Me.nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nuevo.TabIndex = 4
        Me.nuevo.TabStop = False
        '
        'imagen
        '
        Me.imagen.Image = Global.Capa_Presentacion.My.Resources.Resources.usermaster
        Me.imagen.Location = New System.Drawing.Point(449, 103)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(158, 218)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 3
        Me.imagen.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnivel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(26, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 153)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro de Usuarios:"
        '
        'txtnivel
        '
        Me.txtnivel.Location = New System.Drawing.Point(102, 114)
        Me.txtnivel.Name = "txtnivel"
        Me.txtnivel.Size = New System.Drawing.Size(286, 26)
        Me.txtnivel.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtbuscar)
        Me.GroupBox3.Controls.Add(Me.cbocampo)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 246)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(408, 48)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(93, 19)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(299, 20)
        Me.txtbuscar.TabIndex = 15
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"users", "nivel"})
        Me.cbocampo.Location = New System.Drawing.Point(13, 19)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(64, 21)
        Me.cbocampo.TabIndex = 1122
        Me.cbocampo.Text = "users"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        Me.datalistado.Location = New System.Drawing.Point(35, 320)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(407, 172)
        Me.datalistado.TabIndex = 1123
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Eliminar"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(139, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(288, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = ".:Registro de Usuarios:."
        '
        'frmusuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(623, 536)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.imagen)
        Me.Controls.Add(Me.editar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmusuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::USUARIOS::"
        CType(Me.cancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
    Friend WithEvents nuevo As System.Windows.Forms.PictureBox
    Friend WithEvents guardar As System.Windows.Forms.PictureBox
    Friend WithEvents editar As System.Windows.Forms.PictureBox
    Friend WithEvents cancelar As System.Windows.Forms.PictureBox
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents dlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtnivel As System.Windows.Forms.TextBox
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
