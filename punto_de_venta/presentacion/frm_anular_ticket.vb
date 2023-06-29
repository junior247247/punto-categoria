Public Class frm_anular_ticket
    Private dt As New DataTable
    Private class_invenntario As New class_inventario
    Private obj_c As New ce_cobro
    Private class_producto As New class_producto
    Private class_venta As New class_venta
    Private class_repirte As New class_reporte
    Private obj_venta_final As New ce_venta_final
    Private classCombo As New classCombo
    Private obj_venta As New ce_venta
    Private class_cierre_de_caja As New class_cierre_de_caja

    'Public Sub mostrar_productos_almacen()
    '    Try
    '        dt = class_producto.mostrar_productos
    '        frm_almacen.datalistado_productos.DataSource = dt
    '        frm_almacen.datalistado_productos.Columns(0).Visible = False
    '        frm_almacen.datalistado_productos.Columns(11).Visible = False
    '        frm_almacen.datalistado_productos.EnableHeadersVisualStyles = False
    '        If frm_almacen.datalistado_productos.Rows.Count > 0 Then
    '            frm_almacen.datalistado_productos.ContextMenuStrip = frm_almacen.c_menu_reabastecer
    '        Else
    '            frm_almacen.datalistado_productos.ContextMenuStrip = Nothing
    '        End If

    '        frm_almacen.datalistado_productos.Columns(1).Width = 270
    '        For i = 2 To frm_almacen.datalistado_productos.Columns.Count - 1 Step 1
    '            frm_almacen.datalistado_productos.Columns(i).Width = 100
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub









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




    Public Sub mostrar_venta_final()
        Try
            dt = class_venta.mostrar_venta_final
            frm_ventas.datalistado_ventas.DataSource = dt
            frm_ventas.datalistado_ventas.EnableHeadersVisualStyles = False
            frm_ventas.datalistado_ventas.Columns(0).Width = 100
            For i = 1 To frm_ventas.datalistado_ventas.Columns.Count - 1 Step 1
                frm_ventas.datalistado_ventas.Columns(i).Width = 190
            Next
            If frm_ventas.datalistado_ventas.Rows.Count > 0 Then
                frm_ventas.datalistado_ventas.ContextMenuStrip = frm_ventas.ContextMenuStrip1
            Else
                frm_ventas.datalistado_ventas.ContextMenuStrip = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub










    Public Sub home()
        'Try




        '    dt = class_invenntario.sumar_ventas_del_mes
        '    If dt.Rows.Count > 0 Then
        '        frm_home.lbl_compras_del_mes.Text = "RD$ " + dt.Rows(0).Item("compras_del_mes").ToString


        '    End If

        '    If frm_home.lbl_compras_del_mes.Text = "RD$ " Then
        '        frm_home.lbl_compras_del_mes.Text = "RD$ 0.00"
        '    End If


        '    dt = class_producto.mostrar_productos_en_punto_de_reorden
        '    frm_home.lbl_productos_en_punto_de_reorden.Text = dt.Rows.Count
        '    If frm_home.lbl_productos_en_punto_de_reorden.Text = String.Empty Then
        '        frm_home.lbl_productos_en_punto_de_reorden.Text = "0"
        '    End If


        '    dt = class_invenntario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
        '    If dt.Rows.Count > 0 Then
        '        frm_home.lbl_dinero_en_caja.Text = "RD$ " + dt.Rows(0).Item("dinero_en_caja").ToString
        '    Else
        '        frm_home.lbl_dinero_en_caja.Text = "RD$ 0.00"
        '    End If
        '    dt = class_invenntario.dinero_de_ventas_del_dia(Form1.lbl_id_usuario.Text)
        '    If dt.Rows.Count > 0 Then
        '        frm_home.lbl_ventas_del_dia.Text = "RD$ " + dt.Rows(0).Item("ventas_del_dia").ToString
        '    Else
        '        frm_home.lbl_ventas_del_dia.Text = "RD$ 0.00"
        '    End If
        '    If frm_home.lbl_ventas_del_dia.Text = "RD$ " Then

        '        frm_home.lbl_ventas_del_dia.Text = "RD$ 0.00"
        '    End If


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        frm_home.home()
    End Sub
    Public Sub mostrar_ingresos_del_dia()
        frm_caja.mostrar_ingresos_del_dia()
        'Try
        '    dt = class_invenntario.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
        '    frm_caja.lbl_dinero_encaja.Text = dt.Rows(0).Item("ventas_del_dia").ToString
        '    frm_caja.lbl_dinero_en_caja.Text = dt.Rows(0).Item("ventas_del_dia").ToString
        '    frm_caja.lbl_total_ventas_card_y_efeec.Text = dt.Rows(0).Item("ventas_del_dia").ToString

        '    If frm_caja.lbl_dinero_encaja.Text = String.Empty Then
        '        frm_caja.lbl_dinero_encaja.Text = "0.00"
        '        frm_caja.lbl_dinero_en_caja.Text = "0.00"
        '        frm_caja.lbl_total_ventas_card_y_efeec.Text = "0.00"
        '        frm_caja.lbl_contador_ventas.Text = "0"
        '    End If

        '    dt = class_invenntario.ganancias_del_dia(Val(Form1.lbl_id_usuario.Text))
        '    frm_caja.lbl_ganancia_en_ventas.Text = dt.Rows(0).Item("ganancias_del_dia").ToString
        '    If frm_caja.lbl_ganancia_en_ventas.Text = String.Empty Then
        '        frm_caja.lbl_ganancia_en_ventas.Text = "0.00"
        '    End If
        '    dt = class_invenntario.devoluciones(Val(Form1.lbl_id_usuario.Text))
        '    frm_caja.lbl_devolucioneS_efectivos.Text = dt.Rows(0).Item("devoluciones_del_dia").ToString
        '    If frm_caja.lbl_devolucioneS_efectivos.Text = String.Empty Then
        '        frm_caja.lbl_devolucioneS_efectivos.Text = "0"
        '    End If

        '    dt = class_invenntario.mostrar_listado_ingreso_del_dia(Val(Form1.lbl_id_usuario.Text))
        '    frm_caja.datalistado_caja.DataSource = dt
        '    frm_caja.lbl_contador_ventas.Text = frm_caja.datalistado_caja.Rows.Count
        '    frm_caja.datalistado_caja.EnableHeadersVisualStyles = False
        '    For i = 0 To frm_caja.datalistado_caja.Columns.Count - 1 Step 1
        '        frm_caja.datalistado_caja.Columns(i).Width = 170
        '    Next

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


    End Sub



    Public Sub mostrar_ingresos_del_diaS()
        'Try
        '    'dt = class_invenntario.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
        '    'frm_caja.lbl_dinero_encaja.Text = dt.Rows(0).Item("ventas_del_dia").ToString
        '    'frm_caja.lbl_dinero_en_caja.Text = dt.Rows(0).Item("ventas_del_dia").ToString
        '    'frm_caja.lbl_total_ventas_card_y_efeec.Text = dt.Rows(0).Item("ventas_del_dia").ToString

        '    'If frm_caja.lbl_dinero_encaja.Text = String.Empty Then
        '    '    frm_caja.lbl_dinero_encaja.Text = "0.00"
        '    '    frm_caja.lbl_dinero_en_caja.Text = "0.00"
        '    '    frm_caja.lbl_total_ventas_card_y_efeec.Text = "0.00"
        '    '    frm_caja.lbl_contador_ventas.Text = "0"
        '    'End If

        '    dt = class_invenntario.ganancias_del_dia(Val(Form1.lbl_id_usuario.Text))
        '    frm_caja.lbl_ganancia_en_ventas.Text = dt.Rows(0).Item("ganancias_del_dia").ToString
        '    If frm_caja.lbl_ganancia_en_ventas.Text = String.Empty Then
        '        frm_caja.lbl_ganancia_en_ventas.Text = "0.00"
        '    End If
        '    dt = class_invenntario.devoluciones(Val(Form1.lbl_id_usuario.Text))
        '    frm_caja.lbl_devolucioneS_efectivos.Text = dt.Rows(0).Item("devoluciones_del_dia").ToString
        '    If frm_caja.lbl_devolucioneS_efectivos.Text = String.Empty Then
        '        frm_caja.lbl_devolucioneS_efectivos.Text = "0"
        '    End If

        '    dt = class_invenntario.mostrar_listado_ingreso_del_dia(Val(Form1.lbl_id_usuario.Text))
        '    frm_caja.datalistado_caja.DataSource = dt
        '    frm_caja.lbl_contador_ventas.Text = frm_caja.datalistado_caja.Rows.Count
        '    frm_caja.datalistado_caja.EnableHeadersVisualStyles = False
        '    For i = 0 To frm_caja.datalistado_caja.Columns.Count - 1 Step 1
        '        frm_caja.datalistado_caja.Columns(i).Width = 170
        '    Next

        '    Dim totalBar, totalGomera As Decimal
        '    dt = class_cierre_de_caja.sumarVentasDeldiaBar
        '    If dt.Rows(0).Item("total").ToString <> "" Then
        '        totalBar = Convert.ToDecimal(dt.Rows(0).Item("total").ToString)
        '    Else
        '        totalBar = 0
        '    End If

        '    dt = class_cierre_de_caja.sumarVentasDeldiaGomera
        '    If dt.Rows(0).Item("total").ToString <> "" Then
        '        totalGomera = Convert.ToDecimal(dt.Rows(0).Item("total").ToString)
        '    Else
        '        totalGomera = 0
        '    End If

        '    Dim total As Decimal = totalGomera + totalBar

        '    frm_caja.lbl_dinero_encaja.Text = total.ToString
        '    frm_caja.lbl_total_ventas_card_y_efeec.Text = total.ToString



        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        frm_caja.mostrar_ingresos_del_dia()

    End Sub




    Public Sub mostrar_nventario()
        'Try
        '    dt = class_invenntario.compras_de_la_semana
        '    frm_inventario.lbl_compras_de_la_semana.Text = dt.Rows(0).Item("total_compras").ToString
        '    If frm_inventario.lbl_compras_de_la_semana.Text = String.Empty Then
        '        frm_inventario.lbl_compras_de_la_semana.Text = "0.00"
        '    End If

        '    dt = class_invenntario.compras_del_mes
        '    frm_inventario.lbl_compras_del_mes.Text = dt.Rows(0).Item("total_compras_del_mes").ToString
        '    If frm_inventario.lbl_compras_del_mes.Text = String.Empty Then
        '        frm_inventario.lbl_compras_del_mes.Text = "0.00"
        '    End If

        '    dt = class_invenntario.ganancias_de_la_semana
        '    frm_inventario.lbl_ganancias_de_la_semana.Text = dt.Rows(0).Item("total_ganancias_de_la_Semana").ToString
        '    If frm_inventario.lbl_ganancias_de_la_semana.Text = String.Empty Then
        '        frm_inventario.lbl_ganancias_de_la_semana.Text = "0.00"
        '    End If

        '    dt = class_invenntario.ganancias_del_mes
        '    frm_inventario.lbl_ganancias_del_mes.Text = dt.Rows(0).Item("total_ganancias_del_mes").ToString
        '    If frm_inventario.lbl_ganancias_del_mes.Text = String.Empty Then
        '        frm_inventario.lbl_ganancias_del_mes.Text = "0.00"
        '    End If

        '    dt = class_invenntario.ventas_de_la_semana
        '    frm_inventario.lbl_ventas_de_la_semana.Text = dt.Rows(0).Item("ventas_de_la_semana").ToString
        '    If frm_inventario.lbl_ventas_de_la_semana.Text = String.Empty Then
        '        frm_inventario.lbl_ventas_de_la_semana.Text = "0.00"
        '    End If

        '    dt = class_invenntario.ventas_del_mes
        '    frm_inventario.lbl_ventas_del_mes.Text = dt.Rows(0).Item("ventas_del_mes").ToString
        '    If frm_inventario.lbl_ventas_del_mes.Text = String.Empty Then
        '        frm_inventario.lbl_ventas_del_mes.Text = "0.00"
        '    End If

        '    dt = class_invenntario.mostrar_dinero_en_caja(Form1.lbl_id_usuario.Text)
        '    frm_inventario.lbl_dinero_en_caja.Text = dt.Rows(0).Item("dinero_en_caja").ToString
        '    If frm_inventario.lbl_dinero_en_caja.Text = String.Empty Then
        '        frm_inventario.lbl_dinero_en_caja.Text = "0.00"
        '    End If


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        frm_inventario.mostrar_nventario()
        frm_inventario.mostrar_dinero_en_producto()
    End Sub



    Public Sub mostrar()
        Try
            dt = class_invenntario.buscar_ticket(Val(Form1.lbl_id_usuario.Text), Val(txt_numero_de_ticket.Text))
            datalistado_articulos.DataSource = dt
            datalistado_articulos.EnableHeadersVisualStyles = False
            datalistado_articulos.Columns(3).Visible = False

            For i = 0 To datalistado_articulos.Columns.Count - 1 Step 1
                datalistado_articulos.Columns(i).Width = 90
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_anular_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        txt_numero_de_ticket.Select()
    End Sub

    Private Sub txt_numero_de_ticket_TextChanged(sender As Object, e As EventArgs) Handles txt_numero_de_ticket.TextChanged
        mostrar()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_numero_de_ticket.Clear()
        Me.Close()
    End Sub


    Private Sub anular()
        Dim id_dinero As Integer
        Dim id_venta As Integer
        Dim ganancia, importe As Decimal
        Dim dtDinero As New DataTable
        id_venta = datalistado_articulos.SelectedCells.Item(0).Value
        Dim formaDePago = datalistado_articulos.SelectedCells.Item(9).Value.ToString()
        If datalistado_articulos.Rows.Count > 0 Then

            Dim d As New DialogResult
            d = MessageBox.Show("deceas anular este ticket", "anulando venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If d = DialogResult.Yes Then

                dt = class_repirte.VERIFICAR_SI_EL_REPORTE_ES_ACREDITO(id_venta)
                If dt.Rows.Count > 0 Then





                    Dim idCaja As Integer = 0


                    dt = class_venta.mostraCaja(id_venta)
                    If dt.Rows.Count > 0 Then
                        For i = 0 To dt.Rows.Count - 1 Step 1
                            importe = Convert.ToDecimal(dt.Rows(i).Item("Importe").ToString)
                            ganancia = Convert.ToDecimal(dt.Rows(i).Item("ganancia").ToString)
                            idCaja = Convert.ToInt32(dt.Rows(i).Item("id_cajadiaria").ToString)
                            dtDinero = class_invenntario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
                            If dtDinero.Rows.Count > 0 Then
                                id_dinero = dtDinero.Rows(0).Item("id_dinero_en_caja")
                            End If


                            If formaDePago = "EFECTIVO" Then
                                With obj_c
                                    .id_usuario = Val(Form1.lbl_id_usuario.Text)
                                    .id_dinero_en_caja = Val(id_dinero)
                                    .retiro = Convert.ToDecimal(importe)
                                End With
                                class_invenntario.retirar_dinero(obj_c)
                            End If


                            class_invenntario.anular_ticketCredito(idCaja, importe, ganancia)

                            With obj_venta_final
                                .id_venta = id_venta
                                .importe = importe
                                .pagado = importe
                                .pendiente = importe
                            End With
                            class_venta.anular_ticket_a_credito(obj_venta_final)
                            class_venta.anular_ticket_a_credito_reporte(obj_venta_final)

                        Next
                    End If

                    Dim cantidad, id_producto As Integer
                    Dim obj_venta As New ce_venta
                    Dim obj_producto As New ce_producto
                    obj_venta.id_venta = id_venta
                    dt = class_venta.mostrar_articulos(obj_venta)

                    For i = 0 To dt.Rows.Count - 1 Step 1
                        Dim id As Integer = Convert.ToInt32(dt.Rows(i).Item("id_producto").ToString)
                        Dim cant As Decimal = Convert.ToDecimal(dt.Rows(i).Item("cantidad").ToString)
                        Dim totalC As Decimal
                        totalC = cant * cantidad


                        With obj_producto
                            .id_producto = id
                            .cantidad = totalC
                        End With

                        class_venta.aumentar_stock(obj_producto)
                    Next


                    MessageBox.Show("venta anulada con exito", "anulando venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_numero_de_ticket.Clear()
                    class_venta.poner_en_credito()
                    mostrar_ingresos_del_dia()
                    mostrar_nventario()
                    mostrar_productos()

                    'mostrar_productos_almacen()
                    mostrar_venta_final()
                    home()
                    Me.Close()

                Else



                    id_venta = datalistado_articulos.SelectedCells.Item(0).Value
                    ganancia = datalistado_articulos.SelectedCells.Item(3).Value
                    importe = datalistado_articulos.SelectedCells.Item(4).Value

                    class_invenntario.anular_ticket(id_venta, importe, ganancia)
                    dt = class_invenntario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
                    If dt.Rows.Count > 0 Then
                        id_dinero = dt.Rows(0).Item("id_dinero_en_caja")
                    End If

                    If formaDePago = "EFECTIVO" Then
                        With obj_c
                            .id_usuario = Val(Form1.lbl_id_usuario.Text)
                            .id_dinero_en_caja = Val(id_dinero)
                            .retiro = Convert.ToDecimal(importe)
                        End With
                        class_invenntario.retirar_dinero(obj_c)
                    End If

                    Dim cantidad, id_producto As Integer
                    Dim obj_venta As New ce_venta
                    Dim obj_producto As New ce_producto
                    obj_venta.id_venta = id_venta
                    dt = class_venta.mostrar_articulos(obj_venta)



                    If dt.Rows.Count > 0 Then

                        For i = 0 To dt.Rows.Count - 1 Step 1






                            id_producto = dt.Rows(i).Item("id_producto")
                            cantidad = dt.Rows(i).Item("cantidad")


                            Dim dtCombo As New DataTable
                            dtCombo = classCombo.verificarProductoCombo(id_producto)
                            If dtCombo.Rows.Count > 1 Then
                                For j = 0 To dtCombo.Rows.Count - 1 Step 1
                                    Dim id As Integer = Convert.ToInt32(dtCombo.Rows(j).Item("idProducto").ToString)
                                    Dim cant As Decimal = Convert.ToDecimal(dtCombo.Rows(j).Item("cantidad").ToString)
                                    Dim totalC As Decimal
                                    totalC = cant * cantidad


                                    With obj_producto
                                        .id_producto = id
                                        .cantidad = totalC
                                    End With

                                    class_venta.aumentar_stock(obj_producto)
                                Next



                            Else


                                With obj_producto
                                    .id_producto = id_producto
                                    .cantidad = cantidad
                                End With

                                class_venta.aumentar_stock(obj_producto)

                            End If






                        Next
                        class_venta.eliminar_todos_los_articulos(id_venta)
                        class_venta.eliminar_venta(id_venta)
                    End If



                    MessageBox.Show("venta anulada con exito", "anulando venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_numero_de_ticket.Clear()

                    mostrar_ingresos_del_dia()
                    mostrar_nventario()
                    mostrar_productos()

                    'mostrar_productos_almacen()
                    mostrar_venta_final()
                    home()
                    Me.Close()

                End If


            End If
        Else
            MessageBox.Show("no hay ningun ticket seleccionado", "anulando venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_anular_Click(sender As Object, e As EventArgs) Handles btn_anular.Click
        anular()
    End Sub

    Private Sub txt_numero_de_ticket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero_de_ticket.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then

            anular()


        End If
    End Sub
End Class