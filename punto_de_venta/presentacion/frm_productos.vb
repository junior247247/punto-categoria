Public Class frm_productos
    Protected dt As New DataTable
    Protected class_producto As New class_producto
    Private almacen As New Almacen
    Property obj_producto As New ce_producto
    Private classCombo As New classCombo

    Public Sub mostrar_productos_almacen()
        Try
            dt = class_producto.mostrar_productos
            frm_almacen.datalistado_productos.DataSource = dt
            frm_almacen.datalistado_productos.Columns(0).Visible = False
            frm_almacen.datalistado_productos.Columns(11).Visible = False
            frm_almacen.datalistado_productos.EnableHeadersVisualStyles = False
            If frm_almacen.datalistado_productos.Rows.Count > 0 Then
                frm_almacen.datalistado_productos.ContextMenuStrip = frm_almacen.c_menu_reabastecer
            Else
                frm_almacen.datalistado_productos.ContextMenuStrip = Nothing
            End If

            frm_almacen.datalistado_productos.Columns(1).Width = 270
            For i = 2 To frm_almacen.datalistado_productos.Columns.Count - 1 Step 1
                frm_almacen.datalistado_productos.Columns(i).Width = 100
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub buscar_prodcutos()
        Try


            dt = class_producto.buscar_productos(txt_buscar_proctos.Text)
            datalistado_productos.DataSource = dt
            datalistado_productos.Columns(0).Visible = False
            datalistado_productos.Columns(11).Visible = False
            datalistado_productos.EnableHeadersVisualStyles = False




            If datalistado_productos.Rows.Count > 0 Then
                datalistado_productos.ContextMenuStrip = c_menu_productos
            Else
                datalistado_productos.ContextMenuStrip = Nothing
            End If

            datalistado_productos.Columns(1).Width = 270
            For i = 2 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 100
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mostrar_productos()
        Try

            dt = class_producto.mostrar_productos
            datalistado_productos.DataSource = dt
            datalistado_productos.Columns(0).Visible = False
            datalistado_productos.Columns(11).Visible = False
            datalistado_productos.EnableHeadersVisualStyles = False



            If datalistado_productos.Rows.Count > 0 Then
                datalistado_productos.ContextMenuStrip = c_menu_productos
            Else
                datalistado_productos.ContextMenuStrip = Nothing
            End If

            datalistado_productos.Columns(1).Width = 270
            For i = 2 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 100
            Next



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frm_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_productos()
    End Sub
    Public Sub limpiar()
        frm_registro_producto.txt_codigo_de_barra.Clear()
        frm_registro_producto.txt_description_producto.Clear()
        frm_registro_producto.rb_por_libra.Checked = False
        frm_registro_producto.rb_por_unidad.Checked = False
        frm_registro_producto.txt_precio_de_compra.Clear()
        frm_registro_producto.txt_precio_de_venta.Clear()
        frm_registro_producto.txt_precio_mayoreo.Clear()
        frm_registro_producto.txt_cantidad_por_mayoreo_a_vender.Clear()
        frm_registro_producto.txt_cantidad_producto.Clear()
        frm_registro_producto.txt_punto_DE_reorden.Clear()
        frm_registro_producto.check_no_aplica_fecha.Checked = False
        frm_registro_producto.txtfecha_DE_vencimeinto.Value = Date.Now
        frm_registro_producto.cbo_categoria.Text = "ABARROTES"
    End Sub
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_registro_producto.btn_guardar_productos.Visible = True
        frm_registro_producto.btn_actualizar_datos.Visible = False
        limpiar()
        frm_registro_producto.ShowDialog()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Try
            frm_registro_producto.lbl_id_producto.Text = datalistado_productos.SelectedCells.Item(0).Value
            frm_registro_producto.txt_description_producto.Text = datalistado_productos.SelectedCells.Item(1).Value
            frm_registro_producto.cbo_categoria.Text = datalistado_productos.SelectedCells.Item(3).Value
            frm_registro_producto.txt_precio_de_compra.Text = datalistado_productos.SelectedCells.Item(4).Value
            frm_registro_producto.txt_precio_de_venta.Text = datalistado_productos.SelectedCells.Item(5).Value
            frm_registro_producto.txt_precio_mayoreo.Text = datalistado_productos.SelectedCells(6).Value
            frm_registro_producto.txt_cantidad_por_mayoreo_a_vender.Text = datalistado_productos.SelectedCells(7).Value
            frm_registro_producto.txt_cantidad_producto.Text = datalistado_productos.SelectedCells.Item(8).Value
            frm_registro_producto.txt_punto_DE_reorden.Text = datalistado_productos.SelectedCells.Item(9).Value
            Dim estado_descuento As String = datalistado_productos.SelectedCells.Item(13).Value

            If estado_descuento = "ACTIVADO" Then
                frm_registro_producto.chb_descuento_activo.Checked = True
            Else
                frm_registro_producto.chb_descuento_activo.Checked = False
            End If
            frm_registro_producto.txt_precio_con_descuento.Text = datalistado_productos.SelectedCells.Item(14).Value


            'Dim porcentaje As Decimal
            'porcentaje = Val(datalistado_productos.SelectedCells.Item(14).Value) / datalistado_productos.SelectedCells.Item(5).Value
            'Dim o As Double
            'o = porcentaje * 100

            'frm_registro_producto.txt_descuento.Text = Format(porcentaje, "0.00")





            frm_registro_producto.txt_codigo_de_barra.Text = datalistado_productos.SelectedCells.Item(2).Value
            Dim veri As String = ""
            Dim fecha_vencimiento As String = ""
            fecha_vencimiento = datalistado_productos.SelectedCells.Item(10).Value
            If fecha_vencimiento = "No aplica" Then
                frm_registro_producto.check_no_aplica_fecha.Checked = True
                frm_registro_producto.txtfecha_DE_vencimeinto.Enabled = False
            Else
                frm_registro_producto.txtfecha_DE_vencimeinto.Text = datalistado_productos.SelectedCells.Item(10).Value
                frm_registro_producto.check_no_aplica_fecha.Checked = False
                frm_registro_producto.txtfecha_DE_vencimeinto.Enabled = True
            End If
            veri = datalistado_productos.SelectedCells.Item(12).Value
            If veri = "Por Unidad/Pieza" Then
                frm_registro_producto.rb_por_unidad.Checked = True
                frm_registro_producto.rb_por_libra.Checked = False
            Else
                frm_registro_producto.rb_por_libra.Checked = True
                frm_registro_producto.rb_por_unidad.Checked = False
            End If
            Dim b() As Byte = datalistado_productos.SelectedCells.Item(11).Value
            Dim ms As New IO.MemoryStream(b)

            frm_registro_producto.pciture_producto.Image = Image.FromStream(ms)
            frm_registro_producto.pciture_producto.SizeMode = PictureBoxSizeMode.StretchImage
            frm_registro_producto.btn_guardar_productos.Visible = False
            frm_registro_producto.btn_actualizar_datos.Visible = True
            frm_desbloquear.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            Dim d As New DialogResult
            d = MessageBox.Show("¿Seguro que deceas eliminar este prodcuto?", "Eliminando producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If d = DialogResult.Yes Then
                Dim id As Integer = datalistado_productos.SelectedCells.Item(0).Value
                Me.Cursor = Cursors.WaitCursor
                dt = classCombo.verificarProductoCombo(id)
                If dt.Rows.Count > 1 Then

                    obj_producto.id_producto = id
                    class_producto.eliminar_prodcuto(obj_producto)
                    classCombo.eliminarComboPorIdCombo(id)
                    mostrar_productos()
                    mostrar_productos_almacen()
                    Me.Cursor = Cursors.Default

                    MessageBox.Show("Producto eliminado con exito", "Elimando producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    obj_producto.id_producto = id
                    class_producto.eliminar_prodcuto(obj_producto)
                    mostrar_productos()
                    mostrar_productos_almacen()
                    Me.Cursor = Cursors.Default

                    MessageBox.Show("Producto eliminado con exito", "Elimando producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_buscar_proctos_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_proctos.TextChanged
        buscar_prodcutos()
    End Sub

    Private Sub btnNuevoCombo_Click(sender As Object, e As EventArgs) Handles btnNuevoCombo.Click
        frmRegistroCombo.ShowDialog()
    End Sub

    Private Sub ReabastecerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReabastecerToolStripMenuItem.Click
        Dim id As Integer = datalistado_productos.SelectedCells.Item(0).Value
        dt = almacen.mostrarAlmacenPorIdProducto(id)
        If dt.Rows.Count > 0 Then
            frm_reabastecer.lbl_id_producto.Text = datalistado_productos.SelectedCells.Item(0).Value
            frm_reabastecer.txt_existencia.Text = datalistado_productos.SelectedCells.Item(8).Value
            frm_reabastecer.ShowDialog()
        Else
            MessageBox.Show("No hay Registro en almacen para este producto", "Reabastecer Producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub paintCells()
        For i = 0 To datalistado_productos.Rows.Count - 1 Step 1
            Dim row As DataGridViewRow = datalistado_productos.Rows(i)
            Dim cell As DataGridViewCell = datalistado_productos.Rows(i).Cells(0)
            row.DefaultCellStyle.BackColor = Color.Red
        Next

    End Sub

    Private Sub btnStarCount_Click(sender As Object, e As EventArgs) Handles btnStarCount.Click
        paintCells()
    End Sub
End Class