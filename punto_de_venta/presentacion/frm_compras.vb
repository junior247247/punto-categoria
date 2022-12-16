Public Class frm_compras

    Private dt As New DataTable
    Private class_producto As New class_producto
    Private obj_produco As New ce_producto
    Private obj_proveedor As New ce_proveedor
    Private class_proveerdor As New class_proveedor
    Private class_invenntario As New class_inventario




    Public Sub mostrar_nventario()
        Try
            dt = class_invenntario.compras_de_la_semana
            frm_inventario.lbl_compras_de_la_semana.Text = dt.Rows(0).Item("total_compras").ToString
            If frm_inventario.lbl_compras_de_la_semana.Text = String.Empty Then
                frm_inventario.lbl_compras_de_la_semana.Text = "0.00"
            End If

            dt = class_invenntario.compras_del_mes
            frm_inventario.lbl_compras_del_mes.Text = dt.Rows(0).Item("total_compras_del_mes").ToString
            If frm_inventario.lbl_compras_del_mes.Text = String.Empty Then
                frm_inventario.lbl_compras_del_mes.Text = "0.00"
            End If

            dt = class_invenntario.ganancias_de_la_semana
            frm_inventario.lbl_ganancias_de_la_semana.Text = dt.Rows(0).Item("total_ganancias_de_la_Semana").ToString
            If frm_inventario.lbl_ganancias_de_la_semana.Text = String.Empty Then
                frm_inventario.lbl_ganancias_de_la_semana.Text = "0.00"
            End If

            dt = class_invenntario.ganancias_del_mes
            frm_inventario.lbl_ganancias_del_mes.Text = dt.Rows(0).Item("total_ganancias_del_mes").ToString
            If frm_inventario.lbl_ganancias_del_mes.Text = String.Empty Then
                frm_inventario.lbl_ganancias_del_mes.Text = "0.00"
            End If

            dt = class_invenntario.ventas_de_la_semana
            frm_inventario.lbl_ventas_de_la_semana.Text = dt.Rows(0).Item("ventas_de_la_semana").ToString
            If frm_inventario.lbl_ventas_de_la_semana.Text = String.Empty Then
                frm_inventario.lbl_ventas_de_la_semana.Text = "0.00"
            End If

            dt = class_invenntario.ventas_del_mes
            frm_inventario.lbl_ventas_del_mes.Text = dt.Rows(0).Item("ventas_del_mes").ToString
            If frm_inventario.lbl_ventas_del_mes.Text = String.Empty Then
                frm_inventario.lbl_ventas_del_mes.Text = "0.00"
            End If

            dt = class_invenntario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                frm_inventario.lbl_dinero_en_caja.Text = dt.Rows(0).Item("dinero_en_caja").ToString
            End If

            If frm_inventario.lbl_dinero_en_caja.Text = String.Empty Then
                frm_inventario.lbl_dinero_en_caja.Text = "0.00"
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub







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







    Public Sub home()
        Try




            dt = class_invenntario.sumar_ventas_del_mes
            If dt.Rows.Count > 0 Then
                frm_home.lbl_compras_del_mes.Text = "RD$ " + dt.Rows(0).Item("compras_del_mes").ToString


            End If

            If frm_home.lbl_compras_del_mes.Text = "RD$ " Then
                frm_home.lbl_compras_del_mes.Text = "RD$ 0.00"
            End If


            dt = class_producto.mostrar_productos_en_punto_de_reorden
            frm_home.lbl_productos_en_punto_de_reorden.Text = dt.Rows.Count
            If frm_home.lbl_productos_en_punto_de_reorden.Text = String.Empty Then
                frm_home.lbl_productos_en_punto_de_reorden.Text = "0"
            End If


            dt = class_invenntario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                frm_home.lbl_dinero_en_caja.Text = "RD$ " + dt.Rows(0).Item("dinero_en_caja").ToString
            Else
                frm_home.lbl_dinero_en_caja.Text = "RD$ 0.00"
            End If
            dt = class_invenntario.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                frm_home.lbl_ventas_del_dia.Text = "RD$ " + dt.Rows(0).Item("ventas_del_dia").ToString
            Else
                frm_home.lbl_ventas_del_dia.Text = "RD$ 0.00"
            End If
            If frm_home.lbl_ventas_del_dia.Text = "RD$ " Then

                frm_home.lbl_ventas_del_dia.Text = "RD$ 0.00"
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub limpiar()
        txt_articulos.Clear()
        txt_cantidad.Clear()
        lblid.Text = ""
        lblprecio_de_compra.Text = ""
        txt_numero_de_doc.Clear()
        txt_precio.Clear()
        txt_codigo_de_barra.Clear()
        lblprecio_de_compra.Text = "0"

    End Sub

    Public Sub mostrar_productos()
        Try
            dt = class_producto.mostrar_productos
            frm_productos.datalistado_productos.DataSource = dt
            frm_productos.datalistado_productos.Columns(0).Visible = False
            frm_productos.datalistado_productos.Columns(11).Visible = False
            frm_productos.datalistado_productos.EnableHeadersVisualStyles = False
            If frm_productos.datalistado_productos.Rows.Count > 0 Then
                frm_productos.datalistado_productos.ContextMenuStrip = frm_productos.c_menu_productos
            Else
                frm_productos.datalistado_productos.ContextMenuStrip = Nothing
            End If

            frm_productos.datalistado_productos.Columns(1).Width = 270
            For i = 2 To frm_productos.datalistado_productos.Columns.Count - 1 Step 1
                frm_productos.datalistado_productos.Columns(i).Width = 100
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub cargar_proveedores()
        Try
            cbo_proveedor.DropDownStyle = 2
            cbo_comprobante.DropDownStyle = 2
            cbo_tipo_de_ingreso.DropDownStyle = 2
            dt = class_proveerdor.mostrar_proveedores
            If dt.Rows.Count > 0 Then
                cbo_proveedor.Items.Clear()


                For i = 0 To dt.Rows.Count - 1 Step 1
                    cbo_proveedor.Items.Add(dt.Rows(i).Item("nombre_o_razon_social").ToString)
                Next
            Else
                cbo_proveedor.Items.Clear()
                cbo_proveedor.Text = "PROVEEDOR"
                cbo_proveedor.Items.Add("PROVEEDOR")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub buscar()
        Try

            If txt_articulos.Text.Trim <> String.Empty Then



                dt = class_producto.buscar_productos_en_compras(txt_articulos.Text)
                datalistado_productos.DataSource = dt
                If dt.Rows.Count > 0 Then
                    If txt_articulos.Text.Trim <> String.Empty Then
                        If txt_articulos.Focus Then
                            GroupBox2.Visible = True
                        Else
                            GroupBox2.Visible = False
                        End If


                    End If
                Else
                    GroupBox2.Visible = False
                End If
                datalistado_productos.Columns(0).Visible = False
                datalistado_productos.Columns(1).Width = 394
                datalistado_productos.EnableHeadersVisualStyles = False
                datalistado_productos.ColumnHeadersVisible = False
            Else
                GroupBox2.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Visible = False
        cargar_proveedores()
    End Sub

    Private Sub txt_articulos_TextChanged(sender As Object, e As EventArgs) Handles txt_articulos.TextChanged

        buscar()
    End Sub

    Private Sub datalistado_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_productos.CellContentClick, datalistado_productos.CellClick
        Try
            lblid.Text = datalistado_productos.SelectedCells.Item(0).Value
            txt_articulos.Text = datalistado_productos.SelectedCells.Item(1).Value
            txt_codigo_de_barra.Text = datalistado_productos.SelectedCells.Item(2).Value
            lblprecio_de_compra.Text = datalistado_productos.SelectedCells.Item(3).Value
            txt_cantidad.Select()
            GroupBox2.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim cadena As String = txt_cantidad.Text
        txt_cantidad.Text = cadena.Replace(".", ",")
        Dim cadena2 As String = txt_precio.Text
        txt_precio.Text = cadena2.Replace(".", ",")


        If IsNumeric(txt_cantidad.Text) And IsNumeric(txt_precio.Text) Then
            If txt_articulos.Text.Trim <> String.Empty And cbo_proveedor.Text <> String.Empty Then
                dt = class_producto.verificar_si_exite_el_producto(txt_articulos.Text)
                If dt.Rows.Count > 0 Then
                    With obj_produco
                        .description = txt_articulos.Text
                        .cantidad = Convert.ToDecimal(txt_cantidad.Text)
                    End With
                    class_producto.reeabastecer_por_nombre(obj_produco)

                    Dim precioDeCompraActual, precioDeCompraNuevo, diferenciaDeventaAsumar As Decimal
                    precioDeCompraNuevo = Convert.ToDecimal(txt_precio.Text) / Convert.ToDecimal(txt_cantidad.Text)

                    precioDeCompraActual = Convert.ToDecimal(lblprecio_de_compra.Text)
                    If precioDeCompraActual <> precioDeCompraNuevo Then
                        class_producto.actualizar_precio_de_compra(Val(lblid.Text), precioDeCompraNuevo)
                        MessageBox.Show("El precio de compra fue actualizado debido a un cambio de precio con el precio anterior", "Registro de compra", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If

                    'If precioDeCompraActual > precioDeCompraNuevo Then
                    '    diferenciaDeventaAsumar = precioDeCompraActual - precioDeCompraNuevo

                    'ElseIf precioDeCompraActual < precioDeCompraNuevo Then
                    '    diferenciaDeventaAsumar = precioDeCompraNuevo - precioDeCompraActual
                    'End If

                    With obj_proveedor
                        .cantidad = Convert.ToDecimal(txt_cantidad.Text)
                        .comprobante = cbo_comprobante.Text
                        .numero_doc = txt_numero_de_doc.Text
                        .articulo = txt_articulos.Text.ToUpper
                        .fecha = Today.Date
                        .proveedor = cbo_proveedor.Text.ToUpper
                        .tipo_de_ingreso = cbo_tipo_de_ingreso.Text
                        .precio = Convert.ToDecimal(txt_precio.Text)
                        .codigo_de_barra = txt_codigo_de_barra.Text
                    End With
                    class_proveerdor.insertar_compra(obj_proveedor)

                    MessageBox.Show("Compra realizada con exito", "Realizando compra", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    MessageBox.Show("El PRODUCTO: " + txt_articulos.Text + " FUE REABASTECIDO", "Realizando compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    mostrar_productos()
                    mostrar_productos_almacen()
                    home()
                    mostrar_nventario()
                Else

                    With obj_proveedor
                        .cantidad = Convert.ToDecimal(txt_cantidad.Text)
                        .comprobante = cbo_comprobante.Text
                        .numero_doc = txt_numero_de_doc.Text
                        .articulo = txt_articulos.Text.ToUpper
                        .fecha = Today.Date
                        .proveedor = cbo_proveedor.Text.ToUpper
                        .tipo_de_ingreso = cbo_tipo_de_ingreso.Text
                        .precio = Convert.ToDecimal(txt_precio.Text)
                        .codigo_de_barra = txt_codigo_de_barra.Text
                    End With
                    class_proveerdor.insertar_compra(obj_proveedor)

                    MessageBox.Show("Compra realizada con exito", "Realizando compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Dim precioDeCompraActual, precioDeCompraNuevo As Decimal
                    'precioDeCompraNuevo = Convert.ToDecimal(txt_precio.Text) / Convert.ToDecimal(txt_cantidad.Text)
                    'precioDeCompraActual = Convert.ToDecimal(lblprecio_de_compra.Text)
                    'If precioDeCompraActual <> precioDeCompraNuevo Then
                    '    class_producto.actualizar_precio_de_compra(Val(lblid.Text), precioDeCompraNuevo)
                    '    MessageBox.Show("El precio de compra fue actualizado debido a un cambio de precio con el precio anterior", "Registro de compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'End If

                    Dim precio As Integer
                    precio = Convert.ToDecimal(txt_precio.Text) / Convert.ToDecimal(txt_cantidad.Text)
                    frm_registro_producto.txt_description_producto.Text = txt_articulos.Text
                    frm_registro_producto.txt_cantidad_producto.Text = Convert.ToDecimal(txt_cantidad.Text)
                    frm_registro_producto.txt_precio_de_compra.Text = precio
                    frm_registro_producto.txt_codigo_de_barra.Text = txt_codigo_de_barra.Text
                    frm_registro_producto.btn_guardar_productos.Visible = True
                    frm_registro_producto.btn_actualizar_datos.Visible = False
                    frm_registro_producto.ShowDialog()
                    limpiar()
                    home()
                    mostrar_nventario()
                End If
            Else
                MessageBox.Show("Datos incompletos", "Realizando compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

            MessageBox.Show("Valor numerico incorrecto", "Realizando compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_historial_de_compras_Click(sender As Object, e As EventArgs) Handles btn_historial_de_compras.Click
        frm_histtorial_de_compras.ShowDialog()
    End Sub


    Private Sub txt_articulos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_articulos.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If GroupBox2.Visible = True Then
                Try
                    txt_articulos.Text = datalistado_productos.SelectedCells.Item(1).Value
                    txt_codigo_de_barra.Text = datalistado_productos.SelectedCells.Item(2).Value
                    GroupBox2.Visible = False
                    txt_cantidad.Select()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                txt_cantidad.Select()
            End If


        End If
    End Sub

    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_precio.Select()

        End If
    End Sub

    Private Sub txt_precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cbo_comprobante.Select()

        End If
    End Sub



    Private Sub cbo_comprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_comprobante.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_numero_de_doc.Select()

        End If
    End Sub

    Private Sub txt_numero_de_doc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero_de_doc.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cbo_tipo_de_ingreso.Select()
        End If
    End Sub

    Private Sub cbo_tipo_de_ingreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_tipo_de_ingreso.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cbo_proveedor.Select()

        End If
    End Sub

    Private Sub cbo_proveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_proveedor.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btn_guardar.Select()

        End If
    End Sub
End Class