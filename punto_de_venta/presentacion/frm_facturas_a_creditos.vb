Public Class frm_facturas_a_creditos
    Private dt As New DataTable
    Private class_venta As New class_venta
    Private class_producto As New class_producto
    Private obj_producto As New ce_producto
    Private obj_venta As New ce_venta
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
            frm_inventario.lbl_dinero_en_caja.Text = dt.Rows(0).Item("dinero_en_caja").ToString
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







    Public Sub home()
        Try

            dt = class_invenntario.sumar_mantenimiento_por_30_dias
            frm_inventario.lbl_mantenimiento_por_30_dias.Text = dt.Rows(0).Item("ingresos_mantenimiento_por30_dias").ToString
            If frm_inventario.lbl_mantenimiento_por_30_dias.Text = String.Empty Then
                frm_inventario.lbl_mantenimiento_por_semana.Text = "0.00"
            End If





            dt = class_invenntario.sumar_mantenimiento_por_7_dias
            frm_inventario.lbl_mantenimiento_por_semana.Text = dt.Rows(0).Item("ingresos_mantenimiento_por7_dias").ToString
            If frm_inventario.lbl_mantenimiento_por_semana.Text = String.Empty Then
                frm_inventario.lbl_mantenimiento_por_semana.Text = "0.00"
            End If



            dt = class_invenntario.sumar_liquidos_por_semana
            frm_inventario.lbl_por_semanas_liquidos.Text = dt.Rows(0).Item("ingresos_liquidos_por_semanas").ToString
            If frm_inventario.lbl_por_semanas_liquidos.Text = String.Empty Then
                frm_inventario.lbl_por_semanas_liquidos.Text = "0.00"
            End If

            dt = class_invenntario.sumar_liquidos_por_30_dias
            frm_inventario.lbl_detalle_por_mes.Text = dt.Rows(0).Item("ingresos_liquidos_por_30_dias").ToString
            If frm_inventario.lbl_detalle_por_mes.Text = String.Empty Then
                frm_inventario.lbl_detalle_por_mes.Text = "0.00"
            End If


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

            mostrar_productos()
            mostrar_productos_almacen()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mostrar_venta_final()
        Try
            dt = class_venta.mostrar_venta_final
            frm_ventas.datalistado_ventas.DataSource = dt
            frm_ventas.datalistado_ventas.EnableHeadersVisualStyles = False
            frm_ventas.datalistado_ventas.Columns(0).Width = 100
            For i = 1 To frm_ventas.datalistado_ventas.Columns.Count - 1 Step 1
                frm_ventas.datalistado_ventas.Columns(i).Width = 190
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        TXT_ID_FACTURA.Clear()
        Me.Close()
    End Sub
    Public Sub buscar()
        Try
            dt = class_venta.BUSCAR_facturas_a_creditos(TXT_ID_FACTURA.Text)
            datalistado_facturas.DataSource = dt
            datalistado_facturas.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_facturas.Columns.Count - 1 Step 1
                datalistado_facturas.Columns(i).Width = 150
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mostrar()
        Try
            dt = class_venta.mostrar_facturas_a_creditos
            datalistado_facturas.DataSource = dt
            datalistado_facturas.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_facturas.Columns.Count - 1 Step 1
                datalistado_facturas.Columns(i).Width = 150
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_facturas_a_creditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        TXT_ID_FACTURA.Select()
    End Sub

    Private Sub TXT_ID_FACTURA_TextChanged(sender As Object, e As EventArgs) Handles TXT_ID_FACTURA.TextChanged
        buscar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            If datalistado_facturas.Rows.Count > 0 Then
                frm_cobrar_factura_a_credito.lbl_cliente.Text = datalistado_facturas.SelectedCells.Item(2).Value
                frm_cobrar_factura_a_credito.lbl_id_factura.Text = datalistado_facturas.SelectedCells.Item(0).Value
                frm_cobrar_factura_a_credito.lbl_pagado.Text = datalistado_facturas.SelectedCells.Item(7).Value
                frm_cobrar_factura_a_credito.lbl_pendiente.Text = datalistado_facturas.SelectedCells.Item(6).Value
                frm_cobrar_factura_a_credito.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_eliminar.LinkClicked
        If datalistado_facturas.Rows.Count > 0 Then

            Dim d As New DialogResult
        d = MessageBox.Show("¿Real mente deceas eliminar esta venta?", "Eliminando venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If d = DialogResult.Yes Then
                obj_venta.id_venta = datalistado_facturas.SelectedCells.Item(0).Value
                Dim id_venta As Integer = datalistado_facturas.SelectedCells.Item(0).Value
                dt = class_venta.mostrar_articulos(obj_venta)
                For i = 0 To dt.Rows.Count - 1 Step 1
                    With obj_producto
                        .id_producto = dt.Rows(i).Item("id_producto")
                        .cantidad = Convert.ToDecimal(dt.Rows(i).Item("Cantidad"))
                    End With
                    class_venta.aumentar_stock(obj_producto)
                Next
                class_venta.eliminar_todos_los_articulos(id_venta)
                class_venta.eliminar_venta(id_venta)
                mostrar()
                mostrar_nventario()
                mostrar_productos()
                mostrar_productos_almacen()
                mostrar_venta_final()
                TXT_ID_FACTURA.Clear()
                MessageBox.Show("Venta eliminada con exito", "Eliminando venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Los productos agregados a esta venta fueron reabastecido", "Elimando venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        End If
    End Sub
End Class