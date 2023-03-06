Imports Capa_Logica
Imports Capa_Datos
Public Class listaproductos
    'Definir variables globales; estas van despues de la linea de inherits
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    'Estas tres subrutinas permiten desplazar el formulario. 
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))
        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe
        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub
    Private dt As New DataTable
    Private Sub mostrar()
        Try
            Dim func As New fproducto
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        buscar()
    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
    End Sub
    Private Sub txtbuscar_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtbuscar.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del cliente porfavor, este datos es obligatorio")
        End If
    End Sub

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellClick
        Try

            txtidcproducto.Text = datalistado.SelectedCells.Item(1).Value
            txtidcategoria.Text = datalistado.SelectedCells.Item(2).Value
            txtnom_categoria.Text = datalistado.SelectedCells.Item(3).Value
            txtnombre.Text = datalistado.SelectedCells.Item(4).Value
            txtdesccripcion.Text = datalistado.SelectedCells.Item(5).Value
            txtstock.Text = datalistado.SelectedCells.Item(6).Value
            txtprecio_compra.Text = datalistado.SelectedCells.Item(7).Value
            txtprecio_venta.Text = datalistado.SelectedCells.Item(8).Value
            txtfecha_vencimiento.Text = datalistado.SelectedCells.Item(9).Value


            imagen.BackgroundImage = Nothing
            Dim b() As Byte = datalistado.SelectedCells.Item(10).Value
            Dim ms As New IO.MemoryStream(b)

            imagen.Image = Image.FromStream(ms)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage

        Catch ex As Exception

        End Try


    End Sub
    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        Try
            If txtflag.Text = "1" Then
                frmdetalle_venta.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
                frmdetalle_venta.txtnombre_producto.Text = datalistado.SelectedCells.Item(4).Value
                frmdetalle_venta.txtstock.Text = datalistado.SelectedCells.Item(6).Value
                frmdetalle_venta.txtprecio_unitario.Text = datalistado.SelectedCells.Item(8).Value

                frmdetalle_venta_usuario.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
                frmdetalle_venta_usuario.txtnombre_producto.Text = datalistado.SelectedCells.Item(4).Value
                frmdetalle_venta_usuario.txtstock.Text = datalistado.SelectedCells.Item(6).Value
                frmdetalle_venta_usuario.txtprecio_unitario.Text = datalistado.SelectedCells.Item(8).Value


                frmserviciotecnico.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
                frmserviciotecnico.txtnombre_producto.Text = datalistado.SelectedCells.Item(4).Value

                Me.Close()
            End If
        Catch ex As Exception

        End Try




    End Sub

    Private Sub listaproductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class