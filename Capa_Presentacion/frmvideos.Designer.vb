<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvideos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmvideos))
        Me.play = New AxWMPLib.AxWindowsMediaPlayer()
        Me.rb7 = New System.Windows.Forms.RadioButton()
        Me.rb6 = New System.Windows.Forms.RadioButton()
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.btnsustituir = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.play, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsustituir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'play
        '
        Me.play.AllowDrop = True
        Me.play.Enabled = True
        Me.play.Location = New System.Drawing.Point(28, 25)
        Me.play.Name = "play"
        Me.play.OcxState = CType(resources.GetObject("play.OcxState"), System.Windows.Forms.AxHost.State)
        Me.play.Size = New System.Drawing.Size(1275, 720)
        Me.play.TabIndex = 0
        Me.play.UseWaitCursor = True
        '
        'rb7
        '
        Me.rb7.AutoSize = True
        Me.rb7.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.rb7.Location = New System.Drawing.Point(1335, 250)
        Me.rb7.Name = "rb7"
        Me.rb7.Size = New System.Drawing.Size(199, 34)
        Me.rb7.TabIndex = 19
        Me.rb7.TabStop = True
        Me.rb7.Text = "Sony Xperia Z5"
        Me.rb7.UseVisualStyleBackColor = True
        '
        'rb6
        '
        Me.rb6.AutoSize = True
        Me.rb6.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.rb6.Location = New System.Drawing.Point(1335, 403)
        Me.rb6.Name = "rb6"
        Me.rb6.Size = New System.Drawing.Size(198, 34)
        Me.rb6.TabIndex = 18
        Me.rb6.TabStop = True
        Me.rb6.Text = "Sony Xperia Z3"
        Me.rb6.UseVisualStyleBackColor = True
        '
        'rb5
        '
        Me.rb5.AutoSize = True
        Me.rb5.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.rb5.Location = New System.Drawing.Point(1335, 456)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(284, 34)
        Me.rb5.TabIndex = 17
        Me.rb5.TabStop = True
        Me.rb5.Text = "Samsung S6 * S6 EDGE"
        Me.rb5.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.rb4.Location = New System.Drawing.Point(1335, 197)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(171, 34)
        Me.rb4.TabIndex = 16
        Me.rb4.TabStop = True
        Me.rb4.Text = "Moto X Style"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.rb3.Location = New System.Drawing.Point(1335, 153)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(168, 34)
        Me.rb3.TabIndex = 15
        Me.rb3.TabStop = True
        Me.rb3.Text = "Moto X Play"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.rb2.Location = New System.Drawing.Point(1335, 352)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(101, 34)
        Me.rb2.TabIndex = 14
        Me.rb2.TabStop = True
        Me.rb2.Text = "LG G4"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.rb1.Location = New System.Drawing.Point(1335, 301)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(205, 34)
        Me.rb1.TabIndex = 13
        Me.rb1.TabStop = True
        Me.rb1.Text = "Iphone PLUS 6S"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'btnsustituir
        '
        Me.btnsustituir.Image = Global.Capa_Presentacion.My.Resources.Resources.playy
        Me.btnsustituir.Location = New System.Drawing.Point(1366, 546)
        Me.btnsustituir.Name = "btnsustituir"
        Me.btnsustituir.Size = New System.Drawing.Size(106, 100)
        Me.btnsustituir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnsustituir.TabIndex = 21
        Me.btnsustituir.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1482, 588)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(55, 13)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Cerrar ""X"""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(1353, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 73)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Videos"
        '
        'frmvideos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1617, 771)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.rb7)
        Me.Controls.Add(Me.rb6)
        Me.Controls.Add(Me.rb5)
        Me.Controls.Add(Me.rb4)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.btnsustituir)
        Me.Controls.Add(Me.play)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmvideos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevos Equipos"
        CType(Me.play, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsustituir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents play As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents rb7 As System.Windows.Forms.RadioButton
    Friend WithEvents rb6 As System.Windows.Forms.RadioButton
    Friend WithEvents rb5 As System.Windows.Forms.RadioButton
    Friend WithEvents rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnsustituir As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
