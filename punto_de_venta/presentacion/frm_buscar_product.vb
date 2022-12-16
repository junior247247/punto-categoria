Public Class frm_buscar_product
    Private dt As New DataTable
    Private class_venta As New class_venta



    Public Sub ver_existencia()
        Try
            dt = class_venta.ver_cantidad(frm_punto_de_venta.lbl_id_producto.Text)
            frm_punto_de_venta.txt_existencia.Text = dt.Rows(0).Item("Cantidad").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub buscar()
        Try
            dt = class_venta.buscar_productos_para_venta(txt_buscar.Text)
            datalistado_productos.DataSource = dt
            datalistado_productos.EnableHeadersVisualStyles = False
            datalistado_productos.Columns(0).Visible = False

            datalistado_productos.Columns(7).Visible = False
            datalistado_productos.Columns(8).Visible = False
            datalistado_productos.Columns(9).Visible = False
            datalistado_productos.Columns(10).Visible = False
            datalistado_productos.Columns(11).Visible = False
            For i = 0 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 150
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mostrar()
        Try
            dt = class_venta.mostrar_productos_para_venta
            datalistado_productos.DataSource = dt
            datalistado_productos.EnableHeadersVisualStyles = False
            datalistado_productos.Columns(0).Visible = False

            datalistado_productos.Columns(7).Visible = False
            datalistado_productos.Columns(8).Visible = False
            datalistado_productos.Columns(9).Visible = False
            datalistado_productos.Columns(10).Visible = False
            datalistado_productos.Columns(11).Visible = False
            For i = 0 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 150
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_buscar.Clear()
        Me.Close()
    End Sub

    Private Sub frm_buscar_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        buscar()
    End Sub





    Private Sub datalistado_productos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_productos.CellDoubleClick
        Try
            If datalistado_productos.Rows.Count > 0 Then


                frm_punto_de_venta.txt_buscar_producto.Text = datalistado_productos.SelectedCells.Item(1).Value

                frm_punto_de_venta.txt_precio.Text = datalistado_productos.SelectedCells.Item(4).Value
                frm_punto_de_venta.lbl_cantidad_por_mayoreo.Text = datalistado_productos.SelectedCells.Item(6).Value
                frm_punto_de_venta.lbl_id_producto.Text = datalistado_productos.SelectedCells.Item(0).Value
                frm_punto_de_venta.lbl_precio_normal.Text = datalistado_productos.SelectedCells.Item(4).Value
                frm_punto_de_venta.lbl_precio_por_mayoreo.Text = datalistado_productos.SelectedCells.Item(5).Value
                frm_punto_de_venta.lbl_ganancia.Text = datalistado_productos.SelectedCells.Item(7).Value
                frm_punto_de_venta.lbl_fecha_de_vencimiento.Text = datalistado_productos.SelectedCells.Item(8).Value
                frm_punto_de_venta.lbl_itbis.Text = datalistado_productos.SelectedCells.Item(9).Value
                frm_punto_de_venta.lbl_precio_con_descuento.Text = datalistado_productos.SelectedCells.Item(10).Value
                frm_punto_de_venta.lbl_activo_descuento.Text = datalistado_productos.SelectedCells.Item(11).Value
                frm_punto_de_venta.lblCategoria.Text = datalistado_productos.SelectedCells.Item(12).Value
                ver_existencia()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        Try
            If datalistado_productos.Rows.Count > 0 Then


                frm_punto_de_venta.txt_buscar_producto.Text = datalistado_productos.SelectedCells.Item(1).Value
                frm_punto_de_venta.lblCategoria.Text = datalistado_productos.SelectedCells.Item(12).Value
                frm_punto_de_venta.txt_precio.Text = datalistado_productos.SelectedCells.Item(4).Value
                frm_punto_de_venta.lbl_cantidad_por_mayoreo.Text = datalistado_productos.SelectedCells.Item(6).Value
                frm_punto_de_venta.lbl_id_producto.Text = datalistado_productos.SelectedCells.Item(0).Value
                frm_punto_de_venta.lbl_precio_normal.Text = datalistado_productos.SelectedCells.Item(4).Value
                frm_punto_de_venta.lbl_precio_por_mayoreo.Text = datalistado_productos.SelectedCells.Item(5).Value
                frm_punto_de_venta.lbl_ganancia.Text = datalistado_productos.SelectedCells.Item(7).Value
                frm_punto_de_venta.lbl_fecha_de_vencimiento.Text = datalistado_productos.SelectedCells.Item(8).Value
                frm_punto_de_venta.lbl_itbis.Text = datalistado_productos.SelectedCells.Item(9).Value
                frm_punto_de_venta.lbl_precio_con_descuento.Text = datalistado_productos.SelectedCells.Item(10).Value
                frm_punto_de_venta.lbl_activo_descuento.Text = datalistado_productos.SelectedCells.Item(11).Value
                ver_existencia()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class