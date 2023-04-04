Imports System.IO
Public Class frm_punto_de_venta
    Private dt As New DataTable
    Private class_venta As New class_venta
    Private obj_venta As New ce_venta
    Private obj_producto As New ce_producto
    Private obj_cobro As New ce_cobro
    Private class_cobro As New class_cobro
    Private obb_caja_diaria As New ce_caja_diaria
    Private class_caja_diaria As New class_caja_diaria
    Private obj_final As New ce_venta_final
    Private class_invenntario As New class_inventario
    Private class_producto As New class_producto
    Private class_cliente As New class_cliente
    Private class_provedor As New class_proveedor
    Private classCombo As New classCombo

    Private class_cierre_de_caja As New class_cierre_de_caja



    Public Declare Auto Function CreateFile Lib "kernel32.dll" (
ByVal lpFileName As String, ByVal dwDesiredAccess As Int32,
ByVal dwShareMode As Int32, ByVal lpSecurityAttributes As IntPtr,
ByVal dwCreationDisposition As Int32, ByVal dwFlagsAndAttributes As Int32,
ByVal hTemplateFile As IntPtr) As IntPtr

    Public Shared puerto As String
    Public Const GENERIC_READ As Int32 = &H80000000

    Public Const GENERIC_WRITE As Int32 = &H40000000

    Public Const OPEN_EXISTING As Int32 = 3

    Public Shared Property puertos() As String
        Get

            Return puerto
        End Get
        Set(ByVal Value As String)
            puerto = Value
        End Set
    End Property
    Public Shared Sub abrircajon(ByVal puertolpt As String)
        puertos = puertolpt


        Dim hFich As IntPtr = CreateFile(puertos, GENERIC_WRITE, 0, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero)
        Dim stream As New FileStream(hFich, FileAccess.Write)

        Dim writer As New StreamWriter(stream)

        writer.WriteLine(Chr(&H1B) + "p" + Chr(0))
        writer.Close()
        stream.Close()
    End Sub










    Public Sub mostrar_dinero_en_producto()
        Try
            Dim milista As List(Of Decimal)
            Dim clasS_producto As New class_producto
            dt = clasS_producto.mostrar_productos
            Dim EXISTENCIA As Decimal
            Dim PRECIO As Decimal
            Dim inversion As Decimal
            Dim total As Decimal
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1 Step 1
                    EXISTENCIA = dt.Rows(i).Item("Existencia")
                    PRECIO = dt.Rows(i).Item("Precio_de_Compra")

                    inversion = PRECIO * EXISTENCIA


                    total = total + inversion
                Next
                frm_inventario.lbl_dinero_en_producto.Text = ParseToDecimal.parse(total.ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub mostrar_ingresos_del_dia()
        Try
            dt = class_invenntario.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
            frm_caja.lbl_dinero_encaja.Text = ParseToDecimal.parse(dt.Rows(0).Item("ventas_del_dia").ToString)
            frm_caja.lbl_dinero_en_caja.Text = ParseToDecimal.parse(dt.Rows(0).Item("ventas_del_dia").ToString)
            frm_caja.lbl_total_ventas_card_y_efeec.Text = ParseToDecimal.parse(dt.Rows(0).Item("ventas_del_dia").ToString)

            If frm_caja.lbl_dinero_encaja.Text = String.Empty Then
                frm_caja.lbl_dinero_encaja.Text = "0.00"
                frm_caja.lbl_dinero_en_caja.Text = "0.00"
                frm_caja.lbl_total_ventas_card_y_efeec.Text = "0.00"
                frm_caja.lbl_contador_ventas.Text = "0"
            End If

            dt = class_invenntario.ganancias_del_dia(Val(Form1.lbl_id_usuario.Text))
            frm_caja.lbl_ganancia_en_ventas.Text = ParseToDecimal.parse(dt.Rows(0).Item("ganancias_del_dia").ToString)
            If frm_caja.lbl_ganancia_en_ventas.Text = String.Empty Then
                frm_caja.lbl_ganancia_en_ventas.Text = "0.00"
            End If
            dt = class_invenntario.devoluciones(Val(Form1.lbl_id_usuario.Text))
            frm_caja.lbl_devolucioneS_efectivos.Text = ParseToDecimal.parse(dt.Rows(0).Item("devoluciones_del_dia").ToString)
            If frm_caja.lbl_devolucioneS_efectivos.Text = String.Empty Then
                frm_caja.lbl_devolucioneS_efectivos.Text = "0"
            End If

            dt = class_invenntario.mostrar_listado_ingreso_del_dia(Val(Form1.lbl_id_usuario.Text))
            frm_caja.datalistado_caja.DataSource = dt
            frm_caja.lbl_contador_ventas.Text = frm_caja.datalistado_caja.Rows.Count
            frm_caja.datalistado_caja.EnableHeadersVisualStyles = False
            For i = 0 To frm_caja.datalistado_caja.Columns.Count - 1 Step 1
                frm_caja.datalistado_caja.Columns(i).Width = 170
            Next
            mostrar_dinero_en_producto()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub






    Public Sub mostrar_ingresos_del_diaS()
        Try
            'dt = class_invenntario.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
            'frm_caja.lbl_dinero_encaja.Text = dt.Rows(0).Item("ventas_del_dia").ToString
            'frm_caja.lbl_dinero_en_caja.Text = dt.Rows(0).Item("ventas_del_dia").ToString
            'frm_caja.lbl_total_ventas_card_y_efeec.Text = dt.Rows(0).Item("ventas_del_dia").ToString

            'If frm_caja.lbl_dinero_encaja.Text = String.Empty Then
            '    frm_caja.lbl_dinero_encaja.Text = "0.00"
            '    frm_caja.lbl_dinero_en_caja.Text = "0.00"
            '    frm_caja.lbl_total_ventas_card_y_efeec.Text = "0.00"
            '    frm_caja.lbl_contador_ventas.Text = "0"
            'End If

            dt = class_invenntario.ganancias_del_dia(Val(Form1.lbl_id_usuario.Text))
            frm_caja.lbl_ganancia_en_ventas.Text = ParseToDecimal.parse(dt.Rows(0).Item("ganancias_del_dia").ToString)
            If frm_caja.lbl_ganancia_en_ventas.Text = String.Empty Then
                frm_caja.lbl_ganancia_en_ventas.Text = "0.00"
            End If
            dt = class_invenntario.devoluciones(Val(Form1.lbl_id_usuario.Text))
            frm_caja.lbl_devolucioneS_efectivos.Text = ParseToDecimal.parse(dt.Rows(0).Item("devoluciones_del_dia").ToString)
            If frm_caja.lbl_devolucioneS_efectivos.Text = String.Empty Then
                frm_caja.lbl_devolucioneS_efectivos.Text = "0"
            End If

            dt = class_invenntario.mostrar_listado_ingreso_del_dia(Val(Form1.lbl_id_usuario.Text))
            frm_caja.datalistado_caja.DataSource = dt
            frm_caja.lbl_contador_ventas.Text = frm_caja.datalistado_caja.Rows.Count
            frm_caja.datalistado_caja.EnableHeadersVisualStyles = False
            For i = 0 To frm_caja.datalistado_caja.Columns.Count - 1 Step 1
                frm_caja.datalistado_caja.Columns(i).Width = 170
            Next

            Dim totalBar, totalGomera As Decimal
            dt = class_cierre_de_caja.sumarVentasDeldiaBar
            If dt.Rows(0).Item("total").ToString <> "" Then
                totalBar = Convert.ToDecimal(dt.Rows(0).Item("total").ToString)
            Else
                totalBar = 0
            End If

            dt = class_cierre_de_caja.sumarVentasDeldiaGomera
            If dt.Rows(0).Item("total").ToString <> "" Then
                totalGomera = Convert.ToDecimal(dt.Rows(0).Item("total").ToString)
            Else
                totalGomera = 0
            End If

            Dim total As Decimal = totalGomera + totalBar

            frm_caja.lbl_dinero_encaja.Text = ParseToDecimal.parse(total.ToString)
            frm_caja.lbl_total_ventas_card_y_efeec.Text = ParseToDecimal.parse(total.ToString)
            mostrar_dinero_en_producto()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub







    Public Sub mostrar_nventario()
        Try
            dt = class_invenntario.compras_de_la_semana
            If dt.Rows.Count > 0 Then
                frm_inventario.lbl_compras_de_la_semana.Text = ParseToDecimal.parse(dt.Rows(0).Item("total_compras").ToString)
                If frm_inventario.lbl_compras_de_la_semana.Text = String.Empty Then
                    frm_inventario.lbl_compras_de_la_semana.Text = "0.00"
                End If
            Else
                frm_inventario.lbl_compras_de_la_semana.Text = "0.00"

            End If


            dt = class_invenntario.compras_del_mes
            If dt.Rows.Count > 0 Then
                frm_inventario.lbl_compras_del_mes.Text = ParseToDecimal.parse(dt.Rows(0).Item("total_compras_del_mes").ToString)
                If frm_inventario.lbl_compras_del_mes.Text = String.Empty Then
                    frm_inventario.lbl_compras_del_mes.Text = "0.00"
                End If
            Else
                frm_inventario.lbl_compras_del_mes.Text = "0.00"
            End If



            dt = class_invenntario.ganancias_de_la_semana
            If dt.Rows.Count > 0 Then
                frm_inventario.lbl_ganancias_de_la_semana.Text = ParseToDecimal.parse(dt.Rows(0).Item("total_ganancias_de_la_Semana").ToString)
                If frm_inventario.lbl_ganancias_de_la_semana.Text = String.Empty Then
                    frm_inventario.lbl_ganancias_de_la_semana.Text = "0.00"
                End If
            Else
                frm_inventario.lbl_ganancias_de_la_semana.Text = "0.00"

            End If

            dt = class_invenntario.ganancias_del_mes
            If dt.Rows.Count > 0 Then
                frm_inventario.lbl_ganancias_del_mes.Text = ParseToDecimal.parse(dt.Rows(0).Item("total_ganancias_del_mes").ToString)
                If frm_inventario.lbl_ganancias_del_mes.Text = String.Empty Then
                    frm_inventario.lbl_ganancias_del_mes.Text = "0.00"
                End If
            Else
                frm_inventario.lbl_ganancias_del_mes.Text = "0.00"
            End If

            dt = class_invenntario.ventas_de_la_semana
            If dt.Rows.Count > 0 Then
                frm_inventario.lbl_ventas_de_la_semana.Text = ParseToDecimal.parse(dt.Rows(0).Item("ventas_de_la_semana").ToString)
                If frm_inventario.lbl_ventas_de_la_semana.Text = String.Empty Then
                    frm_inventario.lbl_ventas_de_la_semana.Text = "0.00"
                End If
            Else
                frm_inventario.lbl_ventas_de_la_semana.Text = "0.00"
            End If

            dt = class_invenntario.ventas_del_mes
            If dt.Rows.Count > 0 Then
                frm_inventario.lbl_ventas_del_mes.Text = ParseToDecimal.parse(dt.Rows(0).Item("ventas_del_mes").ToString)
                If frm_inventario.lbl_ventas_del_mes.Text = String.Empty Then
                    frm_inventario.lbl_ventas_del_mes.Text = "0.00"
                End If
            Else
                frm_inventario.lbl_ventas_del_mes.Text = "0.00"

            End If

            dt = class_invenntario.mostrar_dinero_en_caja(Form1.lbl_id_usuario.Text)
            If dt.Rows.Count > 0 Then
                frm_inventario.lbl_dinero_en_caja.Text = ParseToDecimal.parse(dt.Rows(0).Item("dinero_en_caja").ToString)
                If frm_inventario.lbl_dinero_en_caja.Text = String.Empty Then
                    frm_inventario.lbl_dinero_en_caja.Text = "0.00"
                End If
            Else
                frm_inventario.lbl_dinero_en_caja.Text = "0.00"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





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







    Public Sub home()
        Try

            dt = class_invenntario.sumar_mantenimiento_por_30_dias
            frm_inventario.lbl_mantenimiento_por_30_dias.Text = ParseToDecimal.parse(dt.Rows(0).Item("ingresos_mantenimiento_por30_dias").ToString)
            If frm_inventario.lbl_mantenimiento_por_30_dias.Text = String.Empty Then
                frm_inventario.lbl_mantenimiento_por_semana.Text = "0.00"
            End If





            dt = class_invenntario.sumar_mantenimiento_por_7_dias
            frm_inventario.lbl_mantenimiento_por_semana.Text = ParseToDecimal.parse(dt.Rows(0).Item("ingresos_mantenimiento_por7_dias").ToString)
            If frm_inventario.lbl_mantenimiento_por_semana.Text = String.Empty Then
                frm_inventario.lbl_mantenimiento_por_semana.Text = "0.00"
            End If



            dt = class_invenntario.sumar_liquidos_por_semana
            frm_inventario.lbl_por_semanas_liquidos.Text = ParseToDecimal.parse(dt.Rows(0).Item("ingresos_liquidos_por_semanas").ToString)
            If frm_inventario.lbl_por_semanas_liquidos.Text = String.Empty Then
                frm_inventario.lbl_por_semanas_liquidos.Text = "0.00"
            End If

            dt = class_invenntario.sumar_liquidos_por_30_dias
            frm_inventario.lbl_detalle_por_mes.Text = ParseToDecimal.parse(dt.Rows(0).Item("ingresos_liquidos_por_30_dias").ToString)
            If frm_inventario.lbl_detalle_por_mes.Text = String.Empty Then
                frm_inventario.lbl_detalle_por_mes.Text = "0.00"
            End If


            dt = class_invenntario.sumar_ventas_del_mes
            If dt.Rows.Count > 0 Then
                frm_home.lbl_compras_del_mes.Text = "RD$ " + ParseToDecimal.parse(dt.Rows(0).Item("compras_del_mes").ToString)


            End If

            If frm_home.lbl_compras_del_mes.Text = "RD$ " Then
                frm_home.lbl_compras_del_mes.Text = "RD$ 0.00"
            End If


            dt = class_producto.mostrar_productos_en_punto_de_reorden
            frm_home.lbl_productos_en_punto_de_reorden.Text = dt.Rows.Count
            If frm_home.lbl_productos_en_punto_de_reorden.Text = String.Empty Then
                frm_home.lbl_productos_en_punto_de_reorden.Text = "0"
            End If
            dt = class_cliente.motrar_clientes
            frm_home.lbl_clientes.Text = dt.Rows.Count
            If lbl_clientes.Text = String.Empty Then
                lbl_clientes.Text = "0"

            End If
            dt = class_provedor.mostrar_proveedores
            frm_home.lbl_proveedores.Text = dt.Rows.Count
            If frm_home.lbl_proveedores.Text = String.Empty Then
                frm_home.lbl_proveedores.Text = "0"
            End If
            dt = class_invenntario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                frm_home.lbl_dinero_en_caja.Text = "RD$ " + ParseToDecimal.parse(dt.Rows(0).Item("dinero_en_caja").ToString)
            Else
                frm_home.lbl_dinero_en_caja.Text = "RD$ 0.00"
            End If
            dt = class_invenntario.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                frm_home.lbl_ventas_del_dia.Text = "RD$ " + ParseToDecimal.parse(dt.Rows(0).Item("ventas_del_dia").ToString)
            Else
                frm_home.lbl_ventas_del_dia.Text = "RD$ 0.00"
            End If
            If frm_home.lbl_ventas_del_dia.Text = "RD$ " Then

                frm_home.lbl_ventas_del_dia.Text = "RD$ 0.00"
            End If

            mostrar_productos()
            'mostrar_productos_almacen()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub






    Public Sub verificar_si_no_se_vendieron_los_productos_ponerlos_en_data()
        Try
            dt = class_venta.verificar_si_no_esta_vendido
            If dt.Rows.Count > 0 Then
                Dim id_venta As Integer
                id_venta = dt.Rows(0).Item("id_venta")
                lbl_id_venta.Text = id_venta

                MessageBox.Show("La venta no fue finalizada ", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                mostar_id_de_venta()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Public Sub verificar_si_no_se_vendieron_los_productos()
        Try
            dt = class_venta.verificar_si_no_esta_vendido
            If dt.Rows.Count > 0 Then
                Dim id_producto, cantidad, id_venta As Integer
                For i = 0 To dt.Rows.Count - 1 Step 1
                    id_producto = dt.Rows(i).Item("id_producto")
                    cantidad = dt.Rows(i).Item("cantidad")
                    With obj_producto
                        .id_producto = Val(id_producto)
                        .cantidad = Val(cantidad)
                    End With
                    class_venta.aumentar_stock(obj_producto)

                Next
                id_venta = dt.Rows(0).Item("id_venta")
                class_venta.eliminar_todos_los_articulos(id_venta)
                MessageBox.Show("La venta no fue finalizada el stock no fue afectado", "Venta no finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mostrar()
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


    Public Sub ver_existencia()
        Try
            dt = class_venta.ver_cantidad(lbl_id_producto.Text)
            txt_existencia.Text = dt.Rows(0).Item("Cantidad").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mostrar_articulos()
        Try
            obj_venta.id_venta = Val(lbl_id_venta.Text)
            dt = class_venta.mostrar_articulos(obj_venta)
            datalistado_articulos.DataSource = dt
            datalistado_articulos.Columns(0).Visible = False
            datalistado_articulos.Columns(6).Visible = False
            datalistado_articulos.Columns(7).Visible = False
            datalistado_articulos.Columns(8).Visible = False
            datalistado_articulos.Columns(9).Visible = False
            If datalistado_articulos.Rows.Count > 0 Then
                datalistado_articulos.ContextMenuStrip = c_menu_articulos
            Else
                datalistado_articulos.ContextMenuStrip = Nothing
            End If
            datalistado_articulos.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_articulos.Columns.Count - 1 Step 1
                datalistado_articulos.Columns(i).Width = 150
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mostar_id_de_venta()
        Try
            dt = class_venta.id_de_venta
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1 Step 1
                    lbl_id_venta.Text = dt.Rows(i).Item("id_venta").ToString
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub buscar()
        Try
            If txt_buscar_producto.Focus Then



                If txt_buscar_producto.Text.Trim <> String.Empty Then
                    dt = class_venta.buscar_productos_para_venta(txt_buscar_producto.Text)
                    If dt.Rows.Count > 0 Then
                        grb_conenedor.Visible = True
                        datalistado_productos.DataSource = dt
                        datalistado_productos.ColumnHeadersVisible = False
                        datalistado_productos.Columns(0).Visible = False

                        datalistado_productos.Columns(1).Width = 472
                        For i = 2 To datalistado_productos.Columns.Count - 1 Step 1
                            datalistado_productos.Columns(i).Visible = False
                        Next


                    Else
                        grb_conenedor.Visible = False

                    End If
                Else
                    grb_conenedor.Visible = False

                End If
            Else
                grb_conenedor.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_producto.TextChanged
        buscar()
    End Sub

    Private Sub frm_punto_de_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grb_conenedor.Visible = False
        cbo_forma_de_pago.Text = "EEFCTIVO"
        cbo_forma_de_pago.DropDownStyle = 2

        txt_buscar_producto.Select()

        verificar_si_no_se_vendieron_los_productos_ponerlos_en_data()
        mostrar_articulos()
        sumas_total()
        txt_precio.Clear()
        txt_buscar_producto.Select()
        lbl_cantidad_por_mayoreo.Text = ""
        cbo_tipo.Text = "CONTADO"
        cbo_tipo.DropDownStyle = 2
        lbl_ganancia.Text = "gannacia"
        txt_rnc_cliente.Enabled = False
        RB_NO.Checked = True
        txt_nombre_de_empresa.Enabled = False
    End Sub

    Private Sub link_buscar_producto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_buscar_producto.LinkClicked
        frm_buscar_product.ShowDialog()
    End Sub

    Private Sub datalistado_productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_productos.CellClick
        Try
            txt_buscar_producto.Text = datalistado_productos.SelectedCells.Item(1).Value

            lblCategoria.Text = datalistado_productos.SelectedCells.Item(12).Value

            txt_precio.Text = datalistado_productos.SelectedCells.Item(4).Value
            lbl_precio_normal.Text = datalistado_productos.SelectedCells.Item(4).Value
            lbl_cantidad_por_mayoreo.Text = datalistado_productos.SelectedCells.Item(6).Value
            lbl_id_producto.Text = datalistado_productos.SelectedCells.Item(0).Value
            lbl_precio_por_mayoreo.Text = datalistado_productos.SelectedCells.Item(5).Value
            lbl_ganancia.Text = datalistado_productos.SelectedCells.Item(7).Value
            lbl_fecha_de_vencimiento.Text = datalistado_productos.SelectedCells.Item(8).Value
            lbl_itbis.Text = datalistado_productos.SelectedCells.Item(9).Value
            lbl_precio_con_descuento.Text = datalistado_productos.SelectedCells.Item(10).Value
            lbl_activo_descuento.Text = datalistado_productos.SelectedCells.Item(11).Value
            If lbl_activo_descuento.Text = "ACTIVADO" Then
                txt_precio.Text = lbl_precio_con_descuento.Text

            End If
            ver_existencia()
            grb_conenedor.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Public Sub AGREGAR_PRODUCTOS()
        dt = class_venta.buscar_productos_para_venta(txt_buscar_producto.Text)
        Dim cadena As String = txt_cantitdad_flag1.Text
        txt_cantitdad_flag1.Text = cadena.Replace(".", ",")
        If txt_cantitdad_flag1.Text = String.Empty Then
            txt_cantitdad_flag1.Text = "1"
        End If

        If txt_buscar_producto.Text <> String.Empty Then
            Me.Cursor = Cursors.WaitCursor


            If dt.Rows.Count > 0 Then
                If lbl_ganancia.Text <> "gannacia" Then


                    If IsNumeric(txt_cantitdad_flag1.Text) Then
                        If Convert.ToDecimal(txt_cantitdad_flag1.Text) <= Convert.ToDecimal(txt_existencia.Text) Then
                            If lbl_fecha_de_vencimiento.Text = "No aplica" Then
                                dt = class_venta.verificar_si_existe_el_articulo(Val(lbl_id_venta.Text), Val(lbl_id_producto.Text))

                                If dt.Rows.Count > 0 Then

                                    Dim precio As Decimal

                                    Dim cantidad_ingresada As Decimal = 0

                                    cantidad_ingresada = Convert.ToDecimal(dt.Rows(0).Item("cantidad"))
                                    cantidad_ingresada = cantidad_ingresada + Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    Dim C As Integer
                                    C += dt.Rows(0).Item("cantidad")
                                    If cantidad_ingresada >= Convert.ToDecimal(lbl_cantidad_por_mayoreo.Text) Then
                                        precio = Format(Convert.ToDecimal(lbl_precio_por_mayoreo.Text), "0.00")
                                        txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_por_mayoreo.Text), "0.00")

                                        dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                                        If dt.Rows.Count > 0 Then
                                            lbl_ganancia.Text = dt.Rows(0).Item("ganacia_por_mayoreo")


                                        End If

                                        If lbl_activo_descuento.Text = "ACTIVADO" Then

                                        End If


                                    Else


                                        precio = Format(Convert.ToDecimal(lbl_precio_normal.Text), "0.00")
                                        txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_normal.Text), "0.00")

                                        dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                                        If dt.Rows.Count > 0 Then
                                            lbl_ganancia.Text = dt.Rows(0).Item("Ganancia")
                                        End If
                                    End If


                                    Dim cantida_por_precio, resultado_desc, precio_nomrmal, precio_descuento As Decimal
                                    If lbl_activo_descuento.Text = "ACTIVADO" Then
                                        precio_nomrmal = Convert.ToDecimal(lbl_precio_normal.Text)
                                        precio_descuento = Convert.ToDecimal(lbl_precio_con_descuento.Text)
                                        resultado_desc = precio_nomrmal - precio_descuento
                                        cantida_por_precio = resultado_desc * cantidad_ingresada
                                    Else

                                        cantida_por_precio = cantida_por_precio * 1
                                    End If




                                    Dim isStock As Boolean = False


                                    Dim total, total_ganancia As Decimal
                                    Dim precio_de_compra, precio_de_venta As Decimal
                                    Dim formulta As Decimal
                                    dt = class_producto.mostrar_precio_de_compra(Val(lbl_id_producto.Text))
                                    precio_de_compra = Convert.ToDecimal(dt.Rows(0).Item("Precio_de_Compra"))
                                    precio_de_venta = Convert.ToDecimal(dt.Rows(0).Item("precio_con_descuento"))


                                    If lbl_activo_descuento.Text = "ACTIVADO" Then
                                        dt = class_producto.SUMAR_GANANCIAS_EN_VENTA(Val(lbl_id_producto.Text), Val(lbl_id_venta.Text))
                                        total_ganancia = dt.Rows(0).Item("total_ganancia")
                                        formulta = precio_descuento - precio_de_compra
                                        total_ganancia = total_ganancia + formulta * Convert.ToDecimal(txt_cantitdad_flag1.Text)




                                    Else
                                        total_ganancia = Convert.ToDecimal(lbl_ganancia.Text) * cantidad_ingresada

                                    End If
                                    total = precio * cantidad_ingresada
                                    Dim itbis As Decimal
                                    itbis = Format(Convert.ToDecimal(lbl_itbis.Text), "0.00") * Convert.ToDecimal(cantidad_ingresada)





                                    dt = classCombo.verificarProductoCombo(Val(lbl_id_producto.Text))
                                    If dt.Rows.Count > 1 Then
                                        For i = 0 To dt.Rows.Count - 1 Step 1
                                            Dim dtProducto As New DataTable
                                            Dim cantidaTotal As Decimal = 0
                                            Dim idProducto As Integer = Val(dt.Rows(i).Item("idProducto").ToString)

                                            dtProducto = classCombo.selecionarProducto(idProducto)
                                            Dim description As String = dtProducto.Rows(0).Item("Descripcion").ToString
                                            Dim existencia As Decimal = Convert.ToDecimal(dtProducto.Rows(0).Item("Cantidad").ToString)
                                            Dim cantidad As Decimal = Convert.ToDecimal(dt.Rows(i).Item("cantidad").ToString)
                                            cantidaTotal = cantidad * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            If cantidaTotal <= existencia Then
                                                isStock = True
                                            Else
                                                MessageBox.Show("EL PRODUCTO: " + description + " SUPERA LA CANTIDAD DISPONIBLE", "AGREGANOD PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                isStock = False
                                            End If
                                        Next

                                        'If lblCategoria.Text <> "GOMERA" Then
                                        For i = 0 To dt.Rows.Count - 1 Step 1
                                                Dim dtProducto As New DataTable
                                                Dim cantidaTotal As Decimal = 0
                                                Dim idProducto As Integer = Val(dt.Rows(i).Item("idProducto").ToString)
                                                dtProducto = classCombo.selecionarProducto(idProducto)
                                                Dim existencia As Decimal = Convert.ToDecimal(dtProducto.Rows(0).Item("Cantidad").ToString)
                                                Dim cantidad As Decimal = Convert.ToDecimal(dt.Rows(i).Item("cantidad").ToString)
                                                cantidaTotal = cantidad * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                                If isStock Then
                                                    With obj_producto
                                                        .id_producto = Val(idProducto)
                                                        .cantidad = Convert.ToDecimal(cantidaTotal)
                                                    End With
                                                    class_venta.disminuir_stock(obj_producto)


                                                End If
                                            Next

                                            'End If




                                            If isStock Then
                                            With obj_venta
                                                .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                                .id_producto = Val(lbl_id_producto.Text)
                                                .itbis = itbis
                                                .precio = Format(Convert.ToDecimal(precio), "0.00")
                                                .id_venta = Val(lbl_id_venta.Text)
                                                .total = total
                                                .gananci = total_ganancia
                                                .descuento = cantida_por_precio
                                            End With
                                            class_venta.actualizar_monto_si_existe_el_articulo(obj_venta)
                                        End If


                                    Else

                                        If lblCategoria.Text <> "GOMERA" Then
                                            With obj_producto
                                                .id_producto = Val(lbl_id_producto.Text)
                                                .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            End With
                                            class_venta.disminuir_stock(obj_producto)
                                        End If


                                        With obj_venta
                                            .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            .id_producto = Val(lbl_id_producto.Text)
                                            .itbis = itbis
                                            .precio = Format(Convert.ToDecimal(precio), "0.00")
                                            .id_venta = Val(lbl_id_venta.Text)
                                            .total = total
                                            .gananci = total_ganancia
                                            .descuento = cantida_por_precio
                                        End With
                                        class_venta.actualizar_monto_si_existe_el_articulo(obj_venta)
                                    End If
                                    mostrar_articulos()
                                    txt_buscar_producto.Clear()

                                    sumas_total()
                                    ver_existencia()
                                    Me.Cursor = Cursors.Default
                                    txt_cantitdad_flag1.Text = "1"


                                Else


                                    Dim cantidad As Decimal = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    Dim precio As Decimal = Format(Convert.ToDecimal(txt_precio.Text), "0.00")


                                    Dim cantidad_ingresada As Decimal = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    Dim C As Integer

                                    If cantidad_ingresada >= Convert.ToDecimal(lbl_cantidad_por_mayoreo.Text) Then
                                        precio = Format(Convert.ToDecimal(lbl_precio_por_mayoreo.Text), "0.00")
                                        txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_por_mayoreo.Text), "0.00")

                                        dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                                        If dt.Rows.Count > 0 Then
                                            lbl_ganancia.Text = dt.Rows(0).Item("ganacia_por_mayoreo")


                                        End If

                                        If lbl_activo_descuento.Text = "ACTIVADO" Then

                                        End If


                                    Else
                                        precio = Format(Convert.ToDecimal(lbl_precio_normal.Text), "0.00")
                                        txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_normal.Text), "0.00")
                                        dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                                        If dt.Rows.Count > 0 Then
                                            lbl_ganancia.Text = dt.Rows(0).Item("Ganancia")
                                        End If
                                    End If
                                    Dim cantida_por_precio, resultado_desc, precio_nomrmal, precio_descuento As Decimal
                                    If lbl_activo_descuento.Text = "ACTIVADO" Then
                                        precio_nomrmal = Convert.ToDecimal(lbl_precio_normal.Text)
                                        precio_descuento = Convert.ToDecimal(lbl_precio_con_descuento.Text)
                                        resultado_desc = precio_nomrmal - precio_descuento
                                        cantida_por_precio = resultado_desc * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    Else
                                        cantida_por_precio = cantida_por_precio * 1
                                    End If
                                    Dim itbis As Decimal
                                    itbis = Format(Convert.ToDecimal(lbl_itbis.Text), "0.00") * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    Dim total, total_ganancia As Decimal
                                    total = precio * cantidad
                                    Dim precio_de_compra, precio_de_venta As Decimal
                                    Dim formulta As Decimal
                                    dt = class_producto.mostrar_precio_de_compra(Val(lbl_id_producto.Text))
                                    precio_de_compra = Convert.ToDecimal(dt.Rows(0).Item("Precio_de_Compra"))
                                    precio_de_venta = Convert.ToDecimal(dt.Rows(0).Item("precio_con_descuento"))
                                    If lbl_activo_descuento.Text = "ACTIVADO" Then
                                        formulta = precio_descuento - precio_de_compra
                                        total_ganancia = total_ganancia + formulta * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    Else
                                        total_ganancia = Convert.ToDecimal(lbl_ganancia.Text) * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    End If
                                    Dim isStock As Boolean = False
                                    dt = classCombo.verificarProductoCombo(Val(lbl_id_producto.Text))
                                    If dt.Rows.Count > 1 Then
                                        For i = 0 To dt.Rows.Count - 1 Step 1
                                            Dim dtProducto As New DataTable
                                            Dim cantidaTotal As Decimal = 0
                                            Dim idProducto As Integer = Val(dt.Rows(i).Item("idProducto").ToString)
                                            dtProducto = classCombo.selecionarProducto(idProducto)
                                            Dim description As String = dtProducto.Rows(0).Item("Descripcion").ToString
                                            Dim existencia As Decimal = Convert.ToDecimal(dtProducto.Rows(0).Item("Cantidad").ToString)
                                            Dim cantidadp As Decimal = Convert.ToDecimal(dt.Rows(i).Item("cantidad").ToString)
                                            cantidaTotal = cantidadp * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            If cantidaTotal <= existencia Then
                                                isStock = True
                                            Else
                                                MessageBox.Show("EL PRODUCTO: " + description + " SUPERA LA CANTIDAD DISPONIBLE", "AGREGANOD PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                isStock = False
                                            End If
                                        Next
                                        'If lblCategoria.Text <> "GOMERA" Then
                                        For i = 0 To dt.Rows.Count - 1 Step 1
                                                Dim dtProducto As New DataTable
                                                Dim cantidaTotal As Decimal = 0
                                                Dim idProducto As Integer = Val(dt.Rows(i).Item("idProducto").ToString)
                                                dtProducto = classCombo.selecionarProducto(idProducto)
                                                Dim existencia As Decimal = Convert.ToDecimal(dtProducto.Rows(0).Item("Cantidad").ToString)
                                                Dim cantidadp As Decimal = Convert.ToDecimal(dt.Rows(i).Item("cantidad").ToString)
                                                cantidaTotal = cantidadp * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                                If isStock Then
                                                    With obj_producto
                                                        .id_producto = Val(idProducto)
                                                        .cantidad = Convert.ToDecimal(cantidaTotal)
                                                    End With
                                                    class_venta.disminuir_stock(obj_producto)
                                                End If
                                            Next
                                            'End If

                                            If isStock Then
                                            With obj_venta
                                                .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                                .id_producto = Val(lbl_id_producto.Text)
                                                .itbis = itbis
                                                .precio = Format(Convert.ToDecimal(txt_precio.Text), "0.00")
                                                .id_venta = Val(lbl_id_venta.Text)
                                                .total = total
                                                .gananci = total_ganancia
                                                .estado = "SIN VENDER"
                                                .descuento = cantida_por_precio
                                                .categoria = lblCategoria.Text
                                                .idCajero = Val(Form1.lbl_id_usuario.Text)
                                            End With
                                            class_venta.insertar_detalle_de_venta(obj_venta)
                                        End If
                                    Else
                                        'If lblCategoria.Text <> "GOMERA" Then
                                        With obj_producto
                                                .id_producto = Val(lbl_id_producto.Text)
                                                .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            End With
                                            class_venta.disminuir_stock(obj_producto)
                                            'End If

                                            With obj_venta
                                            .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            .id_producto = Val(lbl_id_producto.Text)
                                            .itbis = itbis
                                            .precio = Format(Convert.ToDecimal(txt_precio.Text), "0.00")
                                            .id_venta = Val(lbl_id_venta.Text)
                                            .total = total
                                            .gananci = total_ganancia
                                            .estado = "SIN VENDER"
                                            .descuento = cantida_por_precio
                                            .categoria = lblCategoria.Text
                                            .idCajero = Val(Form1.lbl_id_usuario.Text)
                                        End With
                                        class_venta.insertar_detalle_de_venta(obj_venta)
                                    End If
                                    mostrar_articulos()
                                    Me.Cursor = Cursors.Default
                                    txt_buscar_producto.Clear()


                                    sumas_total()
                                    ver_existencia()

                                    txt_cantitdad_flag1.Text = "1"

                                End If
                            ElseIf lbl_fecha_de_vencimiento.Text >= Date.Now Then
                                dt = class_venta.verificar_si_existe_el_articulo(Val(lbl_id_venta.Text), Val(lbl_id_producto.Text))
                                If dt.Rows.Count > 0 Then
                                    Dim precio As Decimal
                                    Dim cantidad_ingresada As Decimal
                                    cantidad_ingresada = Convert.ToDecimal(dt.Rows(0).Item("cantidad"))
                                    Dim C As Integer
                                    cantidad_ingresada = cantidad_ingresada + Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    If cantidad_ingresada >= Convert.ToDecimal(lbl_cantidad_por_mayoreo.Text) Then
                                        precio = Format(Convert.ToDecimal(lbl_precio_por_mayoreo.Text), "0.00")
                                        txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_por_mayoreo.Text), "0.00")
                                        dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                                        If dt.Rows.Count > 0 Then
                                            lbl_ganancia.Text = dt.Rows(0).Item("ganacia_por_mayoreo")

                                        End If
                                    Else
                                        precio = Format(Convert.ToDecimal(lbl_precio_normal.Text), "0.00")
                                        txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_normal.Text), "0.00")

                                        dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                                        If dt.Rows.Count > 0 Then
                                            lbl_ganancia.Text = dt.Rows(0).Item("Ganancia")
                                        End If
                                    End If
                                    Dim total, total_ganancia As Decimal
                                    total_ganancia = Convert.ToDecimal(lbl_ganancia.Text) * Convert.ToDecimal(cantidad_ingresada)
                                    total = precio * Convert.ToDecimal(cantidad_ingresada)
                                    Dim itbis As Decimal
                                    itbis = Format(Convert.ToDecimal(lbl_itbis.Text), "0.00")
                                    Dim result_itbis As Decimal
                                    result_itbis = itbis * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    Dim cantida_por_precio, resultado_desc, precio_nomrmal, precio_descuento As Decimal
                                    If lbl_activo_descuento.Text = "ACTIVADO" Then
                                        precio_nomrmal = Convert.ToDecimal(lbl_precio_normal.Text)
                                        precio_descuento = Convert.ToDecimal(lbl_precio_con_descuento.Text)
                                        resultado_desc = precio_nomrmal - precio_descuento
                                        cantida_por_precio = resultado_desc * Convert.ToDecimal(cantidad_ingresada)
                                    Else
                                        cantida_por_precio = cantida_por_precio * 1
                                    End If
                                    Dim precio_de_compra, precio_de_venta As Decimal
                                    Dim formulta As Decimal
                                    dt = class_producto.mostrar_precio_de_compra(Val(lbl_id_producto.Text))
                                    precio_de_compra = Convert.ToDecimal(dt.Rows(0).Item("Precio_de_Compra"))
                                    precio_de_venta = Convert.ToDecimal(dt.Rows(0).Item("precio_con_descuento"))
                                    If lbl_activo_descuento.Text = "ACTIVADO" Then
                                        dt = class_producto.SUMAR_GANANCIAS_EN_VENTA(Val(lbl_id_producto.Text), Val(lbl_id_venta.Text))
                                        total_ganancia = dt.Rows(0).Item("total_ganancia")
                                        formulta = precio_descuento - precio_de_compra
                                        total_ganancia = total_ganancia + formulta * Val(txt_cantitdad_flag1.Text)
                                    Else
                                        total_ganancia = Convert.ToDecimal(lbl_ganancia.Text) * cantidad_ingresada
                                    End If
                                    Dim isStock As Boolean = False
                                    dt = classCombo.verificarProductoCombo(Val(lbl_id_producto.Text))
                                    If dt.Rows.Count > 1 Then
                                        For i = 0 To dt.Rows.Count - 1 Step 1
                                            Dim dtProducto As New DataTable
                                            Dim cantidaTotal As Decimal = 0
                                            Dim idProducto As Integer = Val(dt.Rows(i).Item("idProducto").ToString)

                                            dtProducto = classCombo.selecionarProducto(idProducto)
                                            Dim description As String = dtProducto.Rows(0).Item("Descripcion").ToString
                                            Dim existencia As Decimal = Convert.ToDecimal(dtProducto.Rows(0).Item("Cantidad").ToString)
                                            Dim cantidadp As Decimal = Convert.ToDecimal(dt.Rows(i).Item("cantidad").ToString)
                                            cantidaTotal = cantidadp * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            If cantidaTotal <= existencia Then
                                                isStock = True
                                            Else
                                                MessageBox.Show("EL PRODUCTO: " + description + " SUPERA LA CANTIDAD DISPONIBLE", "AGREGANOD PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                isStock = False
                                            End If
                                        Next

                                        'If lblCategoria.Text <> "GOMERA" Then
                                        For i = 0 To dt.Rows.Count - 1 Step 1
                                                Dim dtProducto As New DataTable
                                                Dim cantidaTotal As Decimal = 0
                                                Dim idProducto As Integer = Val(dt.Rows(i).Item("idProducto").ToString)
                                                dtProducto = classCombo.selecionarProducto(idProducto)
                                                Dim existencia As Decimal = Convert.ToDecimal(dtProducto.Rows(0).Item("Cantidad").ToString)
                                                Dim cantidadp As Decimal = Convert.ToDecimal(dt.Rows(i).Item("cantidad").ToString)
                                                cantidaTotal = cantidadp * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                                If isStock Then
                                                    With obj_producto
                                                        .id_producto = Val(idProducto)
                                                        .cantidad = Convert.ToDecimal(cantidaTotal)
                                                    End With
                                                    class_venta.disminuir_stock(obj_producto)
                                                End If
                                            Next
                                            'End If

                                            If isStock Then
                                            With obj_venta
                                                .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                                .id_producto = Val(lbl_id_producto.Text)
                                                .itbis = itbis
                                                .precio = Format(Convert.ToDecimal(precio), "0.00")
                                                .id_venta = Val(lbl_id_venta.Text)
                                                .total = total
                                                .gananci = total_ganancia
                                                .descuento = cantida_por_precio
                                            End With
                                            class_venta.actualizar_monto_si_existe_el_articulo(obj_venta)
                                        End If
                                    Else
                                        'If lblCategoria.Text <> "GOMERA" Then
                                        With obj_producto
                                                .id_producto = Val(lbl_id_producto.Text)
                                                .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            End With
                                            class_venta.disminuir_stock(obj_producto)
                                            'End If
                                            With obj_venta
                                            .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            .id_producto = Val(lbl_id_producto.Text)
                                            .itbis = itbis
                                            .precio = Format(Convert.ToDecimal(precio), "0.00")
                                            .id_venta = Val(lbl_id_venta.Text)
                                            .total = total
                                            .gananci = total_ganancia
                                            .descuento = cantida_por_precio
                                        End With
                                        class_venta.actualizar_monto_si_existe_el_articulo(obj_venta)
                                    End If
                                    mostrar_articulos()
                                    txt_buscar_producto.Clear()
                                    sumas_total()
                                    ver_existencia()
                                    Me.Cursor = Cursors.Default
                                    txt_cantitdad_flag1.Text = "1"
                                Else
                                    Dim precio As Decimal
                                    Dim cantidad_ingresada As Decimal = 0
                                    cantidad_ingresada = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    cantidad_ingresada = cantidad_ingresada + Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    If cantidad_ingresada >= Convert.ToDecimal(lbl_cantidad_por_mayoreo.Text) Then
                                        precio = Format(Convert.ToDecimal(lbl_precio_por_mayoreo.Text), "0.00")
                                        txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_por_mayoreo.Text), "0.00")
                                        dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                                        If dt.Rows.Count > 0 Then
                                            lbl_ganancia.Text = dt.Rows(0).Item("ganacia_por_mayoreo")
                                        End If
                                        If lbl_activo_descuento.Text = "ACTIVADO" Then

                                        End If
                                    Else
                                        precio = Format(Convert.ToDecimal(lbl_precio_normal.Text), "0.00")
                                        txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_normal.Text), "0.00")

                                        dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                                        If dt.Rows.Count > 0 Then
                                            lbl_ganancia.Text = dt.Rows(0).Item("Ganancia")
                                        End If
                                    End If
                                    Dim cantida_por_precio, resultado_desc, precio_nomrmal, precio_descuento As Decimal
                                    If lbl_activo_descuento.Text = "ACTIVADO" Then
                                        precio_nomrmal = Convert.ToDecimal(lbl_precio_normal.Text)
                                        precio_descuento = Convert.ToDecimal(lbl_precio_con_descuento.Text)
                                        resultado_desc = precio_nomrmal - precio_descuento
                                        cantida_por_precio = resultado_desc * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    Else
                                        cantida_por_precio = cantida_por_precio * 1
                                    End If
                                    Dim itbis As Decimal
                                    itbis = Format(Convert.ToDecimal(lbl_itbis.Text), "0.00")
                                    Dim result_itbis As Decimal
                                    result_itbis = itbis * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    Dim cantidad As Decimal = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    'Dim precio As Decimal = Format(Convert.ToDecimal(txt_precio.Text), "0.00")
                                    Dim total, total_ganancia As Decimal
                                    total = precio * cantidad
                                    Dim precio_de_compra, precio_de_venta As Decimal
                                    Dim formulta As Decimal
                                    dt = class_producto.mostrar_precio_de_compra(Val(lbl_id_producto.Text))
                                    precio_de_compra = Convert.ToDecimal(dt.Rows(0).Item("Precio_de_Compra"))
                                    precio_de_venta = Convert.ToDecimal(dt.Rows(0).Item("precio_con_descuento"))
                                    If lbl_activo_descuento.Text = "ACTIVADO" Then
                                        formulta = precio_descuento - precio_de_compra
                                        total_ganancia = total_ganancia + formulta * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    Else
                                        total_ganancia = Convert.ToDecimal(lbl_ganancia.Text) * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                    End If
                                    Dim isStock As Boolean = False
                                    dt = classCombo.verificarProductoCombo(Val(lbl_id_producto.Text))
                                    If dt.Rows.Count > 1 Then
                                        For i = 0 To dt.Rows.Count - 1 Step 1
                                            Dim dtProducto As New DataTable
                                            Dim cantidaTotal As Decimal = 0
                                            Dim idProducto As Integer = Val(dt.Rows(i).Item("idProducto").ToString)

                                            dtProducto = classCombo.selecionarProducto(idProducto)
                                            Dim description As String = dtProducto.Rows(0).Item("Descripcion").ToString
                                            Dim existencia As Decimal = Convert.ToDecimal(dtProducto.Rows(0).Item("Cantidad").ToString)
                                            Dim cantidadp As Decimal = Convert.ToDecimal(dt.Rows(i).Item("cantidad").ToString)
                                            cantidaTotal = cantidadp * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            If cantidaTotal <= existencia Then
                                                isStock = True
                                            Else
                                                MessageBox.Show("EL PRODUCTO: " + description + " SUPERA LA CANTIDAD DISPONIBLE", "AGREGANOD PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                isStock = False
                                            End If
                                        Next
                                        'If lblCategoria.Text <> "GOMERA" Then
                                        For i = 0 To dt.Rows.Count - 1 Step 1
                                                Dim dtProducto As New DataTable
                                                Dim cantidaTotal As Decimal = 0
                                                Dim idProducto As Integer = Val(dt.Rows(i).Item("idProducto").ToString)
                                                dtProducto = classCombo.selecionarProducto(idProducto)
                                                Dim existencia As Decimal = Convert.ToDecimal(dtProducto.Rows(0).Item("Cantidad").ToString)
                                                Dim cantidadp As Decimal = Convert.ToDecimal(dt.Rows(i).Item("cantidad").ToString)
                                                cantidaTotal = cantidadp * Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                                If isStock Then
                                                    With obj_producto
                                                        .id_producto = Val(idProducto)
                                                        .cantidad = Convert.ToDecimal(cantidaTotal)
                                                    End With
                                                    class_venta.disminuir_stock(obj_producto)
                                                End If
                                            Next
                                            'End If
                                            If isStock Then
                                            With obj_venta
                                                .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                                .id_producto = Val(lbl_id_producto.Text)
                                                .itbis = result_itbis
                                                .precio = Format(Convert.ToDecimal(txt_precio.Text), "0.00")
                                                .id_venta = Val(lbl_id_venta.Text)
                                                .total = total
                                                .gananci = total_ganancia
                                                .estado = "SIN VENDER"
                                                .descuento = cantida_por_precio
                                                .categoria = lblCategoria.Text
                                                .idCajero = Val(Form1.lbl_id_usuario.Text)
                                            End With
                                            class_venta.insertar_detalle_de_venta(obj_venta)
                                        End If
                                    Else
                                        'If lblCategoria.Text <> "GOMERA" Then
                                        With obj_producto
                                                .id_producto = Val(lbl_id_producto.Text)
                                                .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            End With
                                            class_venta.disminuir_stock(obj_producto)
                                            'End If
                                            With obj_venta
                                            .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                                            .id_producto = Val(lbl_id_producto.Text)
                                            .itbis = result_itbis
                                            .precio = Format(Convert.ToDecimal(txt_precio.Text), "0.00")
                                            .id_venta = Val(lbl_id_venta.Text)
                                            .total = total
                                            .gananci = total_ganancia
                                            .estado = "SIN VENDER"
                                            .descuento = cantida_por_precio
                                            .categoria = lblCategoria.Text
                                            .idCajero = Val(Form1.lbl_id_usuario.Text)
                                        End With
                                        class_venta.insertar_detalle_de_venta(obj_venta)
                                    End If
                                    mostrar_articulos()
                                    txt_buscar_producto.Clear()
                                    Me.Cursor = Cursors.Default
                                    sumas_total()
                                    ver_existencia()
                                    txt_cantitdad_flag1.Text = "1"
                                End If
                            Else
                                MessageBox.Show("La fecha de caducida del producto a expirado", "Agregando articulo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Cursor = Cursors.Default

                            End If
                        Else
                            MessageBox.Show("La Cantidad ingresada supera le existencia disponible", "Agregando articulos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Cursor = Cursors.Default
                        End If
                    Else
                        MessageBox.Show("Valor numerico no valido", "Agregando articulos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Cursor = Cursors.Default
                    End If
                Else
                    MessageBox.Show("Este producto no existe", "Agregando articulos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Cursor = Cursors.Default
                End If
            Else
                MessageBox.Show("Seleccione el articulo", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Cursor = Cursors.Default
            End If
        Else
            Me.Cursor = Cursors.Default
        End If
    End Sub



    Private Sub txt_buscar_producto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buscar_producto.KeyPress


        If e.KeyChar = Chr(Keys.Enter) Then
            Me.Cursor = Cursors.WaitCursor
            Dim DESCRIPITON As String = ""
            If grb_conenedor.Visible Then
                DESCRIPITON = datalistado_productos.SelectedCells.Item(1).Value
            Else
                DESCRIPITON = ""

            End If
            dt = class_venta.verificar_si_existe_producto(txt_buscar_producto.Text.Trim, DESCRIPITON)
            If dt.Rows.Count > 0 Then



                txt_precio.Text = datalistado_productos.SelectedCells.Item(4).Value
                lbl_precio_normal.Text = datalistado_productos.SelectedCells.Item(4).Value
                lbl_cantidad_por_mayoreo.Text = datalistado_productos.SelectedCells.Item(6).Value
                lbl_id_producto.Text = datalistado_productos.SelectedCells.Item(0).Value
                lbl_precio_por_mayoreo.Text = datalistado_productos.SelectedCells.Item(5).Value
                lbl_ganancia.Text = datalistado_productos.SelectedCells.Item(7).Value
                lbl_fecha_de_vencimiento.Text = datalistado_productos.SelectedCells.Item(8).Value

                lbl_itbis.Text = datalistado_productos.SelectedCells.Item(9).Value
                lbl_precio_con_descuento.Text = datalistado_productos.SelectedCells.Item(10).Value
                lbl_activo_descuento.Text = datalistado_productos.SelectedCells.Item(11).Value
                ver_existencia()
                grb_conenedor.Visible = False
                AGREGAR_PRODUCTOS()
                dt = Nothing
                Me.Cursor = Cursors.Default
            Else
                MessageBox.Show("CODIGO DE BARRA NO REGISTRADO", "AGREGANDO PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_buscar_producto.Clear()
                Me.Cursor = Cursors.Default
            End If



        End If

    End Sub


    Public Sub sumas_total()
        Try

            If datalistado_articulos.Rows.Count > 0 Then

                Dim precio As Double
                Dim itbis As Integer
                Dim cantidad As Integer
                Dim result As Decimal
                Dim total_descuento As Decimal
                For i = 0 To datalistado_articulos.Rows.Count - 1 Step 1
                    'importe_sumado += datalistados_ventas.Rows(i).Cells("importe").Value

                    precio += datalistado_articulos.Rows(i).Cells("total").Value
                    itbis += datalistado_articulos.Rows(i).Cells("ITBIS").Value
                    cantidad += datalistado_articulos.Rows(i).Cells("Cantidad").Value
                    total_descuento += datalistado_articulos.Rows(i).Cells("descuento").Value
                Next
                result = precio - itbis
                lbl_total_de_articulos.Text = cantidad.ToString
                lbl_sub_total.Text = ParseToDecimal.parse(result.ToString)
                lbl_total.Text = ParseToDecimal.parse(precio.ToString)
                lbl_descuento.Text = ParseToDecimal.parse(total_descuento.ToString)
                txt_descuento.Text = ParseToDecimal.parse(total_descuento.ToString)


                Dim f As Decimal
                result = precio - itbis
                lbl_total_de_articulos.Text = cantidad.ToString
                f = result - total_descuento
                lbl_sub_total.Text = ParseToDecimal.parse(Convert.ToDecimal(f.ToString))
                lblSubTotalHide.Text = Format(Convert.ToDecimal(f.ToString), "0.00")
                f = precio - total_descuento
                lbl_total.Text = ParseToDecimal.parse(f.ToString)
                lblTotalOculto.Text = Format(Convert.ToDecimal(f.ToString), "0.00")
                lbl_descuento.Text = ParseToDecimal.parse(total_descuento.ToString)


            Else
                lbl_total_de_articulos.Text = "0"
                lbl_sub_total.Text = "0.00"
                lbl_descuento.Text = "0.00"
                lbl_total.Text = "0.00"
                txt_descuento.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_agregar_producto_Click(sender As Object, e As EventArgs) Handles btn_agregar_producto.Click
        AGREGAR_PRODUCTOS()


    End Sub

    Private Sub txt_cantitdad_flag1_ValueChanged(sender As Object, e As EventArgs)
        If txt_buscar_producto.Text.Trim <> String.Empty Then
            If lbl_ganancia.Text <> "gannacia" Then



                If Convert.ToDecimal(txt_cantitdad_flag1.Text) >= Convert.ToDecimal(lbl_cantidad_por_mayoreo.Text) Then
                    txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_por_mayoreo.Text), "0.00")
                    dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                    If dt.Rows.Count > 0 Then
                        lbl_ganancia.Text = dt.Rows(0).Item("ganacia_por_mayoreo")
                    End If

                Else
                    txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_normal.Text), "0.00")
                    dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                    If dt.Rows.Count > 0 Then
                        lbl_ganancia.Text = dt.Rows(0).Item("Ganancia")
                    End If

                End If

                Dim cant As Integer = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                Dim precio As Decimal = Val(txt_precio.Text)
                Dim resul As Decimal
                resul = precio * cant
                lbl_precio_por_cantidad.Text = precio.ToString + " x " + cant.ToString + " = " + resul.ToString
            End If

        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try





            Dim id_producto As Integer = datalistado_articulos.SelectedCells.Item(6).Value
            Dim cantidad As Decimal = datalistado_articulos.SelectedCells.Item(3).Value
            Dim categori As String = Convert.ToString(datalistado_articulos.SelectedCells.Item(9).Value.ToString)
            dt = classCombo.verificarProductoCombo(id_producto)
            'If categori <> "GOMERA" Then


                If dt.Rows.Count > 1 Then
                    For j = 0 To dt.Rows.Count - 1 Step 1
                        Dim idP As Integer = Convert.ToInt32(dt.Rows(j).Item("idProducto").ToString)
                        Dim c, ctotal As Decimal
                        c = Convert.ToDecimal(dt.Rows(j).Item("cantidad").ToString)
                        ctotal = c * cantidad
                        With obj_producto
                            .id_producto = idP
                            .cantidad = Convert.ToDecimal(ctotal)
                        End With
                        class_venta.aumentar_stock(obj_producto)
                    Next
                    'Else

                    With obj_producto
                        .id_producto = id_producto
                        .cantidad = Convert.ToDecimal(cantidad)
                    End With
                    class_venta.aumentar_stock(obj_producto)

                    'End If

                End If




            obj_venta.id_detalle_de_venta = datalistado_articulos.SelectedCells.Item(0).Value
            class_venta.eliminar_articulo(obj_venta)


            mostrar_articulos()
            sumas_total()
            ver_existencia()
            txt_cantitdad_flag1.Text = "1"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txt_descuento_TextChanged(sender As Object, e As EventArgs) Handles txt_descuento.TextChanged
        Try

            If datalistado_articulos.Rows.Count > 0 Then

                Dim precio As Double
                Dim itbis As Integer
                Dim cantidad As Integer
                Dim result As Decimal
                Dim descuento_por_ciento As Integer = 0
                Dim f As Decimal
                Dim result_descuento As Decimal
                For i = 0 To datalistado_articulos.Rows.Count - 1 Step 1
                    'importe_sumado += datalistados_ventas.Rows(i).Cells("importe").Value

                    precio += datalistado_articulos.Rows(i).Cells("total").Value
                    itbis += datalistado_articulos.Rows(i).Cells("ITBIS").Value
                    cantidad += datalistado_articulos.Rows(i).Cells("Cantidad").Value
                    descuento_por_ciento += datalistado_articulos.Rows(i).Cells("descuento").Value
                Next
                If txt_descuento.Text.Trim <> String.Empty Then


                    If CH_DESCUENTO.Checked Then
                        'result_descuento = precio * descuento_por_ciento / 100
                        result = precio - itbis
                        lbl_total_de_articulos.Text = cantidad.ToString
                        f = result - Convert.ToDecimal(txt_descuento.Text)
                        lbl_sub_total.Text = Format(Convert.ToDecimal(f.ToString), "0.00")
                        f = precio - Convert.ToDecimal(txt_descuento.Text)
                        lbl_total.Text = Format(Convert.ToDecimal(f.ToString), "0.00")

                        lbl_descuento.Text = Format(Convert.ToDecimal(descuento_por_ciento.ToString), "0.00")


                    Else
                        'result_descuento = precio * descuento_por_ciento / 100
                        result = precio - itbis
                        lbl_total_de_articulos.Text = cantidad.ToString
                        f = result - descuento_por_ciento
                        lbl_sub_total.Text = Format(Convert.ToDecimal(f.ToString), "0.00")
                        f = precio - descuento_por_ciento
                        lbl_total.Text = Format(Convert.ToDecimal(f.ToString), "0.00")

                        lbl_descuento.Text = Format(Convert.ToDecimal(descuento_por_ciento.ToString), "0.00")


                    End If
                Else
                    result = precio - itbis
                    lbl_total_de_articulos.Text = cantidad.ToString
                    f = result - descuento_por_ciento
                    lbl_sub_total.Text = Format(Convert.ToDecimal(f.ToString), "0.00")
                    f = precio - descuento_por_ciento
                    lbl_total.Text = Format(Convert.ToDecimal(f.ToString), "0.00")

                    lbl_descuento.Text = Format(Convert.ToDecimal(f.ToString), "0.00")


                End If


            Else
                lbl_total_de_articulos.Text = "0"
                lbl_sub_total.Text = "0.00"
                lbl_total.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Dim d As New DialogResult
        Dim id_producto As Integer
        Dim cantidad As Decimal
        Dim categoria As String
        d = MessageBox.Show("¿Deceas cancelar la venta?", "cancelando venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If d = DialogResult.Yes Then
            If datalistado_articulos.Rows.Count > 0 Then



                For i = 0 To datalistado_articulos.Rows.Count - 1 Step 1

                    categoria = datalistado_articulos.Rows(i).Cells("categoria").Value
                    id_producto = datalistado_articulos.Rows(i).Cells("id_producto").Value
                    cantidad = datalistado_articulos.Rows(i).Cells("Cantidad").Value
                    dt = classCombo.verificarProductoCombo(id_producto)

                    'If categoria <> "GOMERA" Then


                    If dt.Rows.Count > 1 Then
                            For j = 0 To dt.Rows.Count - 1 Step 1
                                Dim idP As Integer = Convert.ToInt32(dt.Rows(j).Item("idProducto").ToString)
                                Dim c, ctotal As Decimal
                                c = Convert.ToDecimal(dt.Rows(j).Item("cantidad").ToString)
                                ctotal = c * cantidad
                                With obj_producto
                                    .id_producto = idP
                                    .cantidad = Convert.ToDecimal(ctotal)
                                End With
                                class_venta.aumentar_stock(obj_producto)
                            Next
                        Else

                            With obj_producto
                                .id_producto = id_producto
                                .cantidad = Convert.ToDecimal(cantidad)
                            End With
                            class_venta.aumentar_stock(obj_producto)

                        End If

                    'End If

                Next
                MessageBox.Show("venta cancelada con exito", "Cancelando venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                class_venta.eliminar_todos_los_articulos(Val(lbl_id_venta.Text))
                txt_buscar_producto.Clear()
                RB_NO.Checked = True
                RB_SI.Checked = False
                txt_precio.Clear()
                txt_existencia.Clear()
                txt_recibido.Clear()
                txt_rnc_cliente.Clear()
                txt_nombre_de_empresa.Clear()
                txt_buscar_producto.Clear()
                txt_nombre_de_empresa.Enabled = False
                txt_rnc_cliente.Enabled = False
                lbl_clientes.Text = ""
                lbl_precio_por_cantidad.Text = ""
                mostrar_articulos()
                sumas_total()
            Else
                MessageBox.Show("No hay ningun producto seleccionado", "Canselando venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub link_buscar_clientes_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_buscar_clientes.LinkClicked
        frm_buscar_cliente.ShowDialog()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click


        Dim id_producto As Integer
        Dim cantidad As Decimal
        Dim categoria As String
        If datalistado_articulos.Rows.Count > 0 Then
            Dim d As New DialogResult
            d = MessageBox.Show("¿Deceas cancelar la venta?", "cancelando venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If d = DialogResult.Yes Then


                For i = 0 To datalistado_articulos.Rows.Count - 1 Step 1
                    categoria = datalistado_articulos.Rows(i).Cells("categoria").Value
                    id_producto = datalistado_articulos.Rows(i).Cells("id_producto").Value
                    cantidad = datalistado_articulos.Rows(i).Cells("Cantidad").Value



                    dt = classCombo.verificarProductoCombo(id_producto)
                    If categoria <> "GOMERA" Then


                        If dt.Rows.Count > 1 Then
                            For j = 0 To dt.Rows.Count - 1 Step 1
                                Dim idP As Integer = Convert.ToInt32(dt.Rows(j).Item("idProducto").ToString)
                                Dim c, ctotal As Decimal
                                c = Convert.ToDecimal(dt.Rows(j).Item("cantidad").ToString)
                                ctotal = c * cantidad
                                With obj_producto
                                    .id_producto = idP
                                    .cantidad = Convert.ToDecimal(ctotal)
                                End With
                                class_venta.aumentar_stock(obj_producto)
                            Next
                        Else

                            With obj_producto
                                .id_producto = id_producto
                                .cantidad = Convert.ToDecimal(cantidad)
                            End With
                            class_venta.aumentar_stock(obj_producto)

                        End If

                    End If




                Next
                MessageBox.Show("venta cancelada con exito", "Cancelando venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_buscar_producto.Clear()
                class_venta.eliminar_todos_los_articulos(Val(lbl_id_venta.Text))

                mostrar_articulos()
                sumas_total()
                txt_precio.Clear()
                txt_recibido.Clear()
                txt_descuento.Clear()
                txt_buscar_producto.Clear()
                txt_existencia.Clear()
                lbl_clientes.Text = ""
                RB_NO.Checked = True
                RB_SI.Checked = False
                txt_nombre_de_empresa.Enabled = False
                txt_rnc_cliente.Enabled = False
                txt_rnc_cliente.Clear()
                txt_nombre_de_empresa.Clear()
                txt_cantitdad_flag1.Text = "1"
                lbl_precio_por_cantidad.Text = ""
                Me.Close()
            End If
        Else
            txt_precio.Clear()
            txt_recibido.Clear()
            txt_descuento.Clear()
            txt_existencia.Clear()
            txt_buscar_producto.Clear()
            lbl_clientes.Text = ""
            lbl_precio_por_cantidad.Text = ""
            txt_cantitdad_flag1.Text = "1"
            RB_NO.Checked = True
            RB_SI.Checked = False
            txt_rnc_cliente.Clear()
            txt_nombre_de_empresa.Clear()
            Me.Close()

        End If




    End Sub


    Private Sub cobrar()
        Dim ganancias As Decimal
        If txt_descuento.Text = "" Then
            txt_descuento.Text = "0"
        End If
        Me.Cursor = Cursors.WaitCursor
        If txt_recibido.Text <> String.Empty Then
            If cbo_tipo.Text = "CONTADO" Then
                If RB_NO.Checked Then
                    If datalistado_articulos.Rows.Count > 0 Then
                        If Convert.ToDecimal(txt_recibido.Text) >= Convert.ToDecimal(lblTotalOculto.Text) Then
                            If IsNumeric(txt_recibido.Text) Then
                                If IsNumeric(txt_descuento.Text) Then
                                    Dim nombre As String
                                    If lbl_clientes.Text = "" Then
                                        nombre = ""
                                    Else
                                        nombre = "EMPLEADO: " + lbl_clientes.Text.ToString
                                    End If
                                    Dim recibido, total, cambio As Decimal
                                    total = Convert.ToDecimal(lblTotalOculto.Text)
                                    recibido = Convert.ToDecimal(txt_recibido.Text)
                                    cambio = recibido - total
                                    'obtiene el total de ganancias
                                    For i = 0 To datalistado_articulos.Rows.Count - 1 Step 1
                                        ganancias += datalistado_articulos.Rows(i).Cells("ganancia").Value
                                    Next
                                    If CH_DESCUENTO.Checked = True Then
                                        ganancias = ganancias - Convert.ToDecimal(txt_descuento.Text)
                                    End If
                                    With obj_final
                                        .condicion = cbo_tipo.Text.ToUpper
                                        .articulos = Val(lbl_total_de_articulos.Text)
                                        .importe = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                        .cliente = lbl_clientes.Text.ToUpper
                                        .descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                        .documento = "TICKET"
                                        .fecha = Today.Date
                                        .id_venta = Val(lbl_id_venta.Text)
                                        .pendiente = 0
                                        .pagado = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                    End With
                                    class_venta.insertar_venta_final(obj_final)
                                    With obj_cobro
                                        .id_venta = Val(lbl_id_venta.Text)
                                        .sub_total = Convert.ToDecimal(lblSubTotalHide.Text)
                                        .total = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                        .total_de_articulos = Val(lbl_total_de_articulos.Text)
                                        .le_atendio = Form1.lbl_nombre_de_usuario.Text.ToUpper
                                        .recibido = Convert.ToDecimal(txt_recibido.Text)
                                        .cambio = Format(Convert.ToDecimal(cambio), "0.00")
                                        .cliente = nombre
                                        .descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                        .porciento_descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                        .hora = TimeOfDay.ToString("hh:mm")
                                        .fecha = Today.Date
                                        .turno = Form1.lbl_turno.Text.ToUpper
                                        .nombre_o_empresa = ""
                                        .rnc_cliente = ""
                                        .ncf = ""
                                        .pendiente = 0
                                        .pagado = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                        .tipo = cbo_tipo.Text
                                    End With
                                    class_cobro.insertar_total(obj_cobro)
                                    With obb_caja_diaria
                                        .id_venta = Val(lbl_id_venta.Text)
                                        .id_cajero = Val(Form1.lbl_id_usuario.Text)
                                        .estado = "VALIDO"
                                        .cierre = "SIN CIERRE"
                                        .ganancia = ganancias
                                        .importe = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                        .medio_de_pago = cbo_forma_de_pago.Text
                                        .hora = TimeOfDay.ToString("HH:MM")
                                        .terminal = Net.Dns.GetHostName
                                        .tipo_operacion = "VENTA"
                                        .valor_de_cambio = cambio
                                        .tipo_de_movimiento = "INGRESO"
                                        .fecha = Today.Date
                                        .tipo_de_moneda = "RD"
                                    End With
                                    class_caja_diaria.insertar_caja_diaria(obb_caja_diaria)
                                    dt = class_cobro.verificar_si_hay_registro(Val(Form1.lbl_id_usuario.Text))
                                    If dt.Rows.Count > 0 Then
                                        Dim id_dinero As Integer
                                        id_dinero = dt.Rows(0).Item("id_dinero_en_caja")
                                        With obj_cobro
                                            .id_usuario = Val(Form1.lbl_id_usuario.Text)
                                            .id_dinero_en_caja = Val(id_dinero)
                                            .dinero_en_cja = Convert.ToDecimal(lblTotalOculto.Text)
                                        End With
                                        class_cobro.actualizar_dinero_en_caja(obj_cobro)
                                    Else
                                        obj_cobro.id_usuario = Val(Form1.lbl_id_usuario.Text)
                                        obj_cobro.dinero_en_cja = Convert.ToDecimal(lbl_total.Text)
                                        class_cobro.insertar_dinero_en_caja(obj_cobro)
                                    End If
                                    obj_venta.id_venta = Val(lbl_id_venta.Text)
                                    class_venta.actualizar_estado_articulos(obj_venta)
                                    MessageBox.Show("venta realizada con exito", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    mostrar()
                                    home()
                                    RB_NO.Checked = False
                                    RB_SI.Checked = False
                                    mostrar_nventario()
                                    mostrar_ingresos_del_dia()
                                    frm_reporte_venta.lbl_id_venta.Text = lbl_id_venta.Text
                                    frm_reporte_venta.ShowDialog()
                                    lbl_id_venta.Text = "0"
                                    mostrar_articulos()
                                    sumas_total()
                                    txt_buscar_producto.Clear()
                                    txt_recibido.Clear()
                                    txt_existencia.Clear()
                                    txt_precio.Clear()
                                    txt_descuento.Enabled = False
                                    CH_DESCUENTO.Checked = False
                                    lbl_clientes.Text = ""
                                    lbl_precio_por_cantidad.Text = ""
                                    txt_descuento.Text = "0"
                                    'abrircajon("COM1")
                                    txt_rnc_cliente.Clear()
                                    Me.Cursor = Cursors.Default
                                    txt_nombre_de_empresa.Clear()
                                    Me.Close()
                                Else
                                    Me.Cursor = Cursors.Default
                                    MessageBox.Show("Valor numerico para descuento incorrecto", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                Me.Cursor = Cursors.Default
                                MessageBox.Show("Valor numero incorrecto para cobrar", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("El monto a pagar es menor que el total", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        MessageBox.Show("No hay ningun producto agregado", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                ElseIf RB_SI.Checked Then
                    If txt_rnc_cliente.Text.Trim <> String.Empty And txt_nombre_de_empresa.Text.Trim <> String.Empty Then
                        Dim numero_de_comprobane As String = ""
                        Dim ncf As String = ""
                        dt = class_venta.numeros_de_comprobantes
                        If dt.Rows.Count > 0 Then
                            For i = 0 To dt.Rows.Count - 1 Step 1
                                numero_de_comprobane = dt.Rows(i).Item("comprobantes")
                            Next
                            Dim fecha_de_vencimiento As String = ""
                            fecha_de_vencimiento = "31-" + "-12-" + Today.Year.ToString
                            If numero_de_comprobane.Length = 1 Then
                                ncf = "B020000000" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 2 Then
                                ncf = "B02000000" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 3 Then
                                ncf = "B0200000" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 4 Then
                                ncf = "B020000" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 5 Then
                                ncf = "B02000" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 6 Then
                                ncf = "B0200" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 7 Then
                                ncf = "B020" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 8 Then
                                ncf = "B02" + numero_de_comprobane
                            End If
                            If datalistado_articulos.Rows.Count > 0 Then
                                If Convert.ToDecimal(txt_recibido.Text) >= Convert.ToDecimal(lblTotalOculto.Text) Then
                                    If IsNumeric(txt_recibido.Text) Then
                                        If IsNumeric(txt_descuento.Text) Then
                                            Dim nombre As String
                                            If lbl_clientes.Text = "" Then
                                                nombre = ""
                                            Else
                                                nombre = "EMPLEADO: " + lbl_clientes.Text.ToString
                                            End If
                                            Dim recibido, total, cambio As Decimal
                                            total = Convert.ToDecimal(lblTotalOculto.Text)
                                            recibido = Convert.ToDecimal(txt_recibido.Text)
                                            cambio = recibido - total
                                            'obtiene el total de ganancias
                                            For i = 0 To datalistado_articulos.Rows.Count - 1 Step 1
                                                ganancias += datalistado_articulos.Rows(i).Cells("ganancia").Value
                                            Next
                                            If CH_DESCUENTO.Checked = True Then
                                                ganancias = ganancias - Convert.ToDecimal(txt_descuento.Text)
                                            End If
                                            With obj_final
                                                .condicion = cbo_tipo.Text.ToUpper
                                                .articulos = Val(lbl_total_de_articulos.Text)
                                                .importe = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                                .cliente = lbl_clientes.Text.ToUpper
                                                .descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                                .documento = "TICKET"
                                                .fecha = Today.Date
                                                .id_venta = Val(lbl_id_venta.Text)
                                                .pendiente = 0
                                                .pagado = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                            End With
                                            class_venta.insertar_venta_final(obj_final)
                                            With obj_cobro
                                                .id_venta = Val(lbl_id_venta.Text)
                                                .sub_total = Format(Convert.ToDecimal(lblSubTotalHide.Text), "0.00")
                                                .total = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                                .total_de_articulos = Val(lbl_total_de_articulos.Text)
                                                .le_atendio = Form1.lbl_nombre_de_usuario.Text.ToUpper
                                                .recibido = Format(Convert.ToDecimal(txt_recibido.Text), "0.00")
                                                .cambio = Format(Convert.ToDecimal(cambio), "0.00")
                                                .cliente = nombre
                                                .descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                                .porciento_descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                                .hora = TimeOfDay.ToString("hh:mm")
                                                .fecha = Today.Date
                                                .turno = Form1.lbl_turno.Text.ToUpper
                                                .ncf = "NCF:" + ncf
                                                .rnc_cliente = "RNC/CEDULA:" + txt_rnc_cliente.Text
                                                .nombre_o_empresa = "NOMBRE O EMPRESA:" + txt_nombre_de_empresa.Text.ToUpper
                                                .pendiente = 0
                                                .pagado = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                                .tipo = cbo_tipo.Text
                                            End With
                                            class_cobro.insertar_total(obj_cobro)
                                            class_cobro.eliminar_comprobante_usado(numero_de_comprobane)
                                            With obb_caja_diaria
                                                .id_venta = Val(lbl_id_venta.Text)
                                                .id_cajero = Val(Form1.lbl_id_usuario.Text)
                                                .estado = "VALIDO"
                                                .cierre = "SIN CIERRE"
                                                .ganancia = ganancias
                                                .importe = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                                .medio_de_pago = cbo_forma_de_pago.Text
                                                .hora = TimeOfDay.ToString("HH:MM")
                                                .terminal = Net.Dns.GetHostName
                                                .tipo_operacion = "VENTA"
                                                .valor_de_cambio = Format(Convert.ToDecimal(cambio), "0.00")
                                                .tipo_de_movimiento = "INGRESO"
                                                .fecha = Today.Date
                                                .tipo_de_moneda = "RD"
                                            End With
                                            class_caja_diaria.insertar_caja_diaria(obb_caja_diaria)
                                            dt = class_cobro.verificar_si_hay_registro(Val(Form1.lbl_id_usuario.Text))
                                            If dt.Rows.Count > 0 Then
                                                Dim id_dinero As Integer
                                                id_dinero = dt.Rows(0).Item("id_dinero_en_caja")
                                                With obj_cobro
                                                    .id_usuario = Val(Form1.lbl_id_usuario.Text)
                                                    .id_dinero_en_caja = Val(id_dinero)
                                                    .dinero_en_cja = Convert.ToDecimal(lblTotalOculto.Text)
                                                End With
                                                class_cobro.actualizar_dinero_en_caja(obj_cobro)
                                            Else

                                                obj_cobro.dinero_en_cja = Convert.ToDecimal(lblTotalOculto.Text)
                                                obj_cobro.id_usuario = Val(Form1.lbl_id_usuario.Text)
                                                class_cobro.insertar_dinero_en_caja(obj_cobro)
                                            End If
                                            obj_venta.id_venta = Val(lbl_id_venta.Text)
                                            class_venta.actualizar_estado_articulos(obj_venta)
                                            'que hace este codigo???
                                            MessageBox.Show("venta realizada con exito", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            'realiza el cobro de la venta 
                                            mostrar()
                                            home()
                                            RB_NO.Checked = False
                                            RB_SI.Checked = False
                                            mostrar_nventario()
                                            mostrar_ingresos_del_dia()
                                            frm_reporte_con_rnc.lbl_id_venta.Text = lbl_id_venta.Text
                                            frm_reporte_con_rnc.ShowDialog()
                                            lbl_id_venta.Text = "0"
                                            mostrar_articulos()
                                            sumas_total()
                                            txt_buscar_producto.Clear()
                                            txt_recibido.Clear()
                                            txt_existencia.Clear()
                                            txt_precio.Clear()
                                            txt_descuento.Enabled = False
                                            CH_DESCUENTO.Checked = False
                                            lbl_clientes.Text = ""
                                            lbl_precio_por_cantidad.Text = ""
                                            txt_descuento.Text = "0"
                                            abrircajon("COM1")
                                            txt_rnc_cliente.Clear()
                                            txt_nombre_de_empresa.Clear()
                                            Me.Cursor = Cursors.Default
                                            Me.Close()
                                        Else
                                            Me.Cursor = Cursors.Default
                                            MessageBox.Show("Valor numerico para descuento incorrecto", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                        End If
                                    Else
                                        Me.Cursor = Cursors.Default
                                        MessageBox.Show("Valor numero incorrecto para cobrar", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                    End If
                                Else
                                    Me.Cursor = Cursors.Default
                                    MessageBox.Show("El monto a pagar es menor que el total", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                End If
                            Else
                                Me.Cursor = Cursors.Default
                                MessageBox.Show("No hay ningun producto agregado", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            End If
                        Else
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("No hay numeros de comprobantes disponibles", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        MessageBox.Show("Ingrese el numero de comprobante y nombre de empresa", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                Else
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("Seleccione factura con comprobante si o no", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)


                End If
            Else

                'A CREDITOS
                If RB_NO.Checked Then
                    If datalistado_articulos.Rows.Count > 0 Then
                        If IsNumeric(txt_recibido.Text) Then
                            If IsNumeric(txt_descuento.Text) Then
                                Dim nombre As String
                                If lbl_clientes.Text = "" Then
                                    nombre = ""
                                Else
                                    nombre = "EMPLEADO: " + lbl_clientes.Text.ToString
                                End If
                                Dim recibido, total, cambio, pendiente As Decimal
                                total = Convert.ToDecimal(lblTotalOculto.Text)
                                recibido = Convert.ToDecimal(txt_recibido.Text)
                                cambio = recibido - total
                                pendiente = total - recibido
                                'obtiene el total de ganancias
                                For i = 0 To datalistado_articulos.Rows.Count - 1 Step 1
                                    ganancias += datalistado_articulos.Rows(i).Cells("ganancia").Value
                                Next
                                Dim result As Decimal
                                If CH_DESCUENTO.Checked = True Then
                                    ganancias = ganancias - Convert.ToDecimal(txt_descuento.Text)
                                End If
                                result = ganancias / Convert.ToDecimal(lblTotalOculto.Text)
                                result = result * Convert.ToDecimal(txt_recibido.Text)
                                With obb_caja_diaria
                                    .id_venta = Val(lbl_id_venta.Text)
                                    .id_cajero = Val(Form1.lbl_id_usuario.Text)
                                    .estado = "VALIDO"
                                    .cierre = "SIN CIERRE"
                                    .ganancia = result
                                    .importe = Format(Convert.ToDecimal(txt_recibido.Text), "0.00")
                                    .medio_de_pago = cbo_forma_de_pago.Text
                                    .hora = TimeOfDay.ToString("HH:MM")
                                    .terminal = Net.Dns.GetHostName
                                    .tipo_operacion = "VENTA"
                                    .valor_de_cambio = 0
                                    .tipo_de_movimiento = "INGRESO"
                                    .fecha = Today.Date
                                    .tipo_de_moneda = "RD"
                                End With
                                class_caja_diaria.insertar_caja_diaria(obb_caja_diaria)
                                With obj_final
                                    .condicion = cbo_tipo.Text.ToUpper
                                    .articulos = Val(lbl_total_de_articulos.Text)
                                    .importe = Format(Convert.ToDecimal(recibido), "0.00")
                                    .cliente = lbl_clientes.Text.ToUpper
                                    .descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                    .documento = "TICKET"
                                    .fecha = Today.Date
                                    .id_venta = Val(lbl_id_venta.Text)
                                    .pendiente = pendiente
                                    .pagado = recibido
                                End With
                                class_venta.insertar_venta_final(obj_final)
                                With obj_cobro
                                    .id_venta = Val(lbl_id_venta.Text)
                                    .sub_total = Val(lblSubTotalHide.Text)
                                    .total = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                    .total_de_articulos = Val(lbl_total_de_articulos.Text)
                                    .le_atendio = Form1.lbl_nombre_de_usuario.Text.ToUpper
                                    .recibido = Val(txt_recibido.Text)
                                    .cambio = Format(Convert.ToDecimal(cambio), "0.00")
                                    .cliente = nombre
                                    .descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                    .porciento_descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                    .hora = TimeOfDay.ToString("hh:mm")
                                    .fecha = Today.Date
                                    .turno = Form1.lbl_turno.Text.ToUpper
                                    .nombre_o_empresa = ""
                                    .rnc_cliente = ""
                                    .ncf = ""
                                    .pendiente = pendiente
                                    .pagado = Format(Convert.ToDecimal(recibido), "0.00")
                                    .tipo = cbo_tipo.Text
                                End With
                                class_cobro.insertar_total(obj_cobro)
                                dt = class_cobro.verificar_si_hay_registro(Val(Form1.lbl_id_usuario.Text))
                                If dt.Rows.Count > 0 Then
                                    Dim id_dinero As Integer
                                    id_dinero = dt.Rows(0).Item("id_dinero_en_caja")
                                    With obj_cobro
                                        .id_usuario = Val(Form1.lbl_id_usuario.Text)
                                        .id_dinero_en_caja = Val(id_dinero)
                                        .dinero_en_cja = Convert.ToDecimal(recibido)
                                    End With
                                    class_cobro.actualizar_dinero_en_caja(obj_cobro)
                                Else
                                    obj_cobro.dinero_en_cja = Convert.ToDecimal(recibido)
                                    obj_cobro.id_usuario = Val(Form1.lbl_id_usuario.Text)
                                    class_cobro.insertar_dinero_en_caja(obj_cobro)
                                End If
                                obj_venta.id_venta = Val(lbl_id_venta.Text)
                                class_venta.actualizar_estado_articulos(obj_venta)
                                'que hace este codigo???
                                MessageBox.Show("venta realizada con exito", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                'realiza el cobro de la venta 
                                class_venta.QUITAR_DE_CREDITO()
                                mostrar()
                                home()
                                RB_NO.Checked = False
                                RB_SI.Checked = False
                                mostrar_nventario()
                                mostrar_ingresos_del_dia()
                                frm_reporte_venta_a_creditos.lbl_id_venta.Text = lbl_id_venta.Text
                                frm_reporte_venta_a_creditos.ShowDialog()
                                lbl_id_venta.Text = "0"
                                mostrar_articulos()
                                sumas_total()
                                txt_buscar_producto.Clear()
                                txt_recibido.Clear()
                                txt_existencia.Clear()
                                txt_precio.Clear()
                                lbl_clientes.Text = ""
                                lbl_precio_por_cantidad.Text = ""
                                txt_descuento.Text = "0"
                                abrircajon("COM1")
                                txt_rnc_cliente.Clear()
                                Me.Cursor = Cursors.Default
                                txt_nombre_de_empresa.Clear()
                                Me.Close()
                            Else
                                Me.Cursor = Cursors.Default
                                MessageBox.Show("Valor numerico para descuento incorrecto", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            End If
                        Else
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("Valor numero incorrecto para cobrar", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        MessageBox.Show("No hay ningun producto agregado", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                ElseIf RB_SI.Checked Then

                    If txt_rnc_cliente.Text.Trim <> String.Empty And txt_nombre_de_empresa.Text.Trim <> String.Empty Then
                        Dim numero_de_comprobane As String = ""
                        Dim ncf As String = ""
                        dt = class_venta.numeros_de_comprobantes
                        If dt.Rows.Count > 0 Then
                            For i = 0 To dt.Rows.Count - 1 Step 1
                                numero_de_comprobane = dt.Rows(i).Item("comprobantes")
                            Next
                            Dim fecha_de_vencimiento As String = ""
                            fecha_de_vencimiento = "31-" + "-12-" + Today.Year.ToString
                            If numero_de_comprobane.Length = 1 Then
                                ncf = "B020000000" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 2 Then
                                ncf = "B02000000" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 3 Then
                                ncf = "B0200000" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 4 Then
                                ncf = "B020000" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 5 Then
                                ncf = "B02000" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 6 Then
                                ncf = "B0200" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 7 Then
                                ncf = "B020" + numero_de_comprobane
                            ElseIf numero_de_comprobane.Length = 8 Then
                                ncf = "B02" + numero_de_comprobane
                            End If
                            If datalistado_articulos.Rows.Count > 0 Then
                                If Convert.ToDecimal(txt_recibido.Text) <= Convert.ToDecimal(lblTotalOculto.Text) Then
                                    If IsNumeric(txt_recibido.Text) Then
                                        If IsNumeric(txt_descuento.Text) Then
                                            Dim nombre As String
                                            If lbl_clientes.Text = "" Then
                                                nombre = ""
                                            Else
                                                nombre = "EMPLEADO: " + lbl_clientes.Text.ToString

                                            End If
                                            Dim recibido, total, cambio, pendiente As Decimal
                                            total = Convert.ToDecimal(lblTotalOculto.Text)
                                            recibido = Convert.ToDecimal(txt_recibido.Text)
                                            cambio = recibido - total
                                            pendiente = total - recibido
                                            'obtiene el total de ganancias
                                            For i = 0 To datalistado_articulos.Rows.Count - 1 Step 1
                                                ganancias += datalistado_articulos.Rows(i).Cells("ganancia").Value
                                            Next
                                            If CH_DESCUENTO.Checked = True Then
                                                ganancias = ganancias - Convert.ToDecimal(txt_descuento.Text)
                                            End If
                                            Dim result As Decimal
                                            result = ganancias / Convert.ToDecimal(lblTotalOculto.Text)
                                            result = result * Convert.ToDecimal(txt_recibido.Text)
                                            With obb_caja_diaria
                                                .id_venta = Val(lbl_id_venta.Text)
                                                .id_cajero = Val(Form1.lbl_id_usuario.Text)
                                                .estado = "VALIDO"
                                                .cierre = "SIN CIERRE"
                                                .ganancia = result
                                                .importe = Format(Convert.ToDecimal(txt_recibido.Text), "0.00")
                                                .medio_de_pago = cbo_forma_de_pago.Text
                                                .hora = TimeOfDay.ToString("HH:MM")
                                                .terminal = Net.Dns.GetHostName
                                                .tipo_operacion = "VENTA"
                                                .valor_de_cambio = 0
                                                .tipo_de_movimiento = "INGRESO"
                                                .fecha = Today.Date
                                                .tipo_de_moneda = "RD"
                                            End With
                                            class_caja_diaria.insertar_caja_diaria(obb_caja_diaria)
                                            With obj_final
                                                .condicion = cbo_tipo.Text.ToUpper
                                                .articulos = Val(lbl_total_de_articulos.Text)
                                                .importe = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                                .cliente = lbl_clientes.Text.ToUpper
                                                .descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                                .documento = "TICKET"
                                                .fecha = Today.Date
                                                .id_venta = Val(lbl_id_venta.Text)
                                                .pendiente = pendiente
                                                .pagado = recibido
                                            End With
                                            class_venta.insertar_venta_final(obj_final)
                                            With obj_cobro
                                                .id_venta = Val(lbl_id_venta.Text)
                                                .sub_total = Format(Convert.ToDecimal(lblSubTotalHide.Text), "0.00")
                                                .total = Format(Convert.ToDecimal(lblTotalOculto.Text), "0.00")
                                                .total_de_articulos = Val(lbl_total_de_articulos.Text)
                                                .le_atendio = Form1.lbl_nombre_de_usuario.Text.ToUpper
                                                .recibido = Format(Convert.ToDecimal(txt_recibido.Text), "0.00")
                                                .cambio = Format(Convert.ToDecimal(cambio), "0.00")
                                                .cliente = nombre
                                                .descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                                .porciento_descuento = Format(Convert.ToDecimal(txt_descuento.Text), "0.00")
                                                .hora = TimeOfDay.ToString("hh:mm")
                                                .fecha = Today.Date
                                                .turno = Form1.lbl_turno.Text.ToUpper
                                                .ncf = "NCF:" + ncf
                                                .rnc_cliente = "RNC/CEDULA:" + txt_rnc_cliente.Text
                                                .nombre_o_empresa = "NOMBRE O EMPRESA:" + txt_nombre_de_empresa.Text.ToUpper
                                                .pendiente = pendiente
                                                .pagado = Format(Convert.ToDecimal(recibido), "0.00")
                                                .tipo = cbo_tipo.Text
                                            End With
                                            class_cobro.insertar_total(obj_cobro)
                                            class_cobro.eliminar_comprobante_usado(numero_de_comprobane)
                                            dt = class_cobro.verificar_si_hay_registro(Val(Form1.lbl_id_usuario.Text))
                                            If dt.Rows.Count > 0 Then
                                                Dim id_dinero As Integer
                                                id_dinero = dt.Rows(0).Item("id_dinero_en_caja")
                                                With obj_cobro
                                                    .id_usuario = Val(Form1.lbl_id_usuario.Text)
                                                    .id_dinero_en_caja = Val(id_dinero)
                                                    .dinero_en_cja = Convert.ToDecimal(recibido)
                                                End With
                                                class_cobro.actualizar_dinero_en_caja(obj_cobro)
                                            Else
                                                obj_cobro.dinero_en_cja = Convert.ToDecimal(recibido)
                                                obj_cobro.id_usuario = Val(Form1.lbl_id_usuario.Text)
                                                class_cobro.insertar_dinero_en_caja(obj_cobro)
                                            End If
                                            obj_venta.id_venta = Val(lbl_id_venta.Text)
                                            class_venta.actualizar_estado_articulos(obj_venta)
                                            'que hace este codigo???
                                            MessageBox.Show("venta realizada con exito", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            'realiza el cobro de la venta 
                                            frm_reporte_venta_a_creditos.lbl_id_venta.Text = lbl_id_venta.Text
                                            frm_reporte_venta_a_creditos.ShowDialog()
                                            class_venta.QUITAR_DE_CREDITO()
                                            mostrar()
                                            home()
                                            mostrar_nventario()
                                            mostrar_ingresos_del_dia()
                                            RB_NO.Checked = False
                                            RB_SI.Checked = False
                                            txt_descuento.Enabled = False
                                            CH_DESCUENTO.Checked = False
                                            lbl_id_venta.Text = "0"

                                            mostrar_articulos()
                                            sumas_total()
                                            txt_buscar_producto.Clear()
                                            txt_recibido.Clear()
                                            txt_existencia.Clear()
                                            txt_precio.Clear()
                                            lbl_clientes.Text = ""
                                            lbl_precio_por_cantidad.Text = ""
                                            txt_descuento.Text = "0"
                                            abrircajon("COM1")
                                            txt_rnc_cliente.Clear()
                                            Me.Cursor = Cursors.Default
                                            txt_nombre_de_empresa.Clear()
                                            Me.Close()
                                        Else
                                            Me.Cursor = Cursors.Default
                                            MessageBox.Show("Valor numerico para descuento incorrecto", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                        End If

                                    Else
                                        Me.Cursor = Cursors.Default
                                        MessageBox.Show("Valor numero incorrecto para cobrar", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                        txt_recibido.Clear()
                                    End If
                                Else
                                    Me.Cursor = Cursors.Default
                                    MessageBox.Show("El monto a pagar supera el total de la factura a credito", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Me.Cursor = Cursors.Default
                                    txt_recibido.Clear()
                                End If
                            Else
                                Me.Cursor = Cursors.Default
                                MessageBox.Show("No hay ningun producto agregado", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            End If
                        Else
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("No hay numeros de comprobantes disponibles", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        MessageBox.Show("Ingrese el numero de comprobante y nombre de empresa", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                Else
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("Seleccione factura con comprobante si o no", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
        Else
            Me.Cursor = Cursors.Default
            MessageBox.Show("Debeb de ingresar el monto recibido", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txt_recibido.Select()
        End If
    End Sub

    Private Sub btn_cobrar_Click(sender As Object, e As EventArgs) Handles btn_cobrar.Click
        cobrar()
    End Sub

    Private Sub txt_cantitdad_flag_TextChanged(sender As Object, e As EventArgs)
        If txt_buscar_producto.Text.Trim <> String.Empty Then
            If lbl_ganancia.Text <> "gannacia" Then



                If txt_cantitdad_flag1.Text >= Val(lbl_cantidad_por_mayoreo.Text) Then
                    txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_por_mayoreo.Text), "0.00")
                    dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                    If dt.Rows.Count > 0 Then
                        lbl_ganancia.Text = dt.Rows(0).Item("ganacia_por_mayoreo")
                    End If

                Else
                    txt_precio.Text = Format(Convert.ToDecimal(lbl_precio_normal.Text), "0.00")
                    dt = class_producto.ganancia_al_por_mayor(Val(lbl_id_producto.Text))
                    If dt.Rows.Count > 0 Then
                        lbl_ganancia.Text = dt.Rows(0).Item("Ganancia")
                    End If

                End If

                Dim cant As Integer = Convert.ToDecimal(txt_cantitdad_flag1.Text)
                Dim precio As Decimal = Val(txt_precio.Text)
                Dim resul As Decimal
                resul = precio * cant
                lbl_precio_por_cantidad.Text = precio.ToString + " x " + cant.ToString + " = " + resul.ToString
            End If

        End If
    End Sub

    Private Sub btn_agregar_producto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btn_agregar_producto.KeyPress


        If e.KeyChar = Chr(Keys.Enter) Then
            AGREGAR_PRODUCTOS()
        End If

        'If txt_buscar_producto.Text.Trim <> String.Empty Then
        '    If lbl_ganancia.Text <> "gannacia" Then


        '        If IsNumeric(txt_cantitdad_flag1.Text) Then
        '            If Val(txt_cantitdad_flag1.Text) <= Val(txt_existencia.Text) Then
        '                If lbl_fecha_de_vencimiento.Text = "No aplica" Then



        '                    Dim cantidad As Integer = Val(txt_cantitdad_flag1.Text)
        '                    Dim precio As Decimal = Val(txt_precio.Text)
        '                    Dim total, total_ganancia As Decimal
        '                    total_ganancia = Val(lbl_ganancia.Text) * cantidad
        '                    total = precio * cantidad
        '                    With obj_venta
        '                        .cantidad = Val(txt_cantitdad_flag1.Text)
        '                        .id_producto = Val(lbl_id_producto.Text)
        '                        .itbis = Val(0)
        '                        .precio = Val(txt_precio.Text)
        '                        .id_venta = Val(lbl_id_venta.Text)
        '                        .total = total
        '                        .gananci = total_ganancia
        '                        .estado = "SIN VENDER"
        '                    End With
        '                    class_venta.insertar_detalle_de_venta(obj_venta)
        '                    With obj_producto
        '                        .id_producto = Val(lbl_id_producto.Text)
        '                        .cantidad = Val(txt_cantitdad_flag1.Text)
        '                    End With
        '                    class_venta.disminuir_stock(obj_producto)
        '                    mostrar_articulos()
        '                    txt_descuento.Text = "0"
        '                    txt_buscar_producto.Clear()


        '                    sumas_total()
        '                    ver_existencia()

        '                    txt_cantitdad_flag1.Text = "1"

        '                ElseIf lbl_fecha_de_vencimiento.Text > Date.Now Then



        '                    Dim cantidad As Integer = Val(txt_cantitdad_flag1.Text)
        '                    Dim precio As Decimal = Val(txt_precio.Text)
        '                    Dim total, total_ganancia As Decimal
        '                    total_ganancia = Val(lbl_ganancia.Text) * cantidad
        '                    total = precio * cantidad
        '                    With obj_venta
        '                        .cantidad = Val(txt_cantitdad_flag1.Text)
        '                        .id_producto = Val(lbl_id_producto.Text)
        '                        .itbis = Val(0)
        '                        .precio = Val(txt_precio.Text)
        '                        .id_venta = Val(lbl_id_venta.Text)
        '                        .total = total
        '                        .gananci = total_ganancia
        '                        .estado = "SIN VENDER"
        '                    End With
        '                    class_venta.insertar_detalle_de_venta(obj_venta)
        '                    With obj_producto
        '                        .id_producto = Val(lbl_id_producto.Text)
        '                        .cantidad = Convert.ToDecimal(txt_cantitdad_flag1.Text)
        '                    End With
        '                    class_venta.disminuir_stock(obj_producto)
        '                    mostrar_articulos()
        '                    txt_descuento.Text = "0"


        '                    sumas_total()
        '                    ver_existencia()

        '                    txt_cantitdad_flag1.Text = "1"
        '                    txt_buscar_producto.Clear()
        '                    txt_recibido.Select()
        '                Else
        '                    MessageBox.Show("La fecha de caducida del producto a expirado", "Agregando articulo", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '                End If
        '            Else
        '                MessageBox.Show("La Cantidad ingresada supera le existencia disponible", "Agregando articulos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            End If
        '        Else
        '            MessageBox.Show("Valor numerico no valido", "Agregando articulos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End If
        '    Else
        '        MessageBox.Show("Este producto no existe", "Agregando articulos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'Else
        '    MessageBox.Show("Seleccione el articulo", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub



    Private Sub txt_recibido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_recibido.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then

            cobrar()




        End If
    End Sub

    Private Sub txt_descuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descuento.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_recibido.Select()
        End If
    End Sub

    Private Sub RB_NO_CheckedChanged(sender As Object, e As EventArgs) Handles RB_NO.CheckedChanged
        txt_rnc_cliente.Enabled = False
        txt_nombre_de_empresa.Enabled = False
    End Sub

    Private Sub RB_SI_CheckedChanged(sender As Object, e As EventArgs) Handles RB_SI.CheckedChanged
        txt_rnc_cliente.Enabled = True
        txt_nombre_de_empresa.Enabled = True
    End Sub



    Private Sub cbo_tipo_TextChanged(sender As Object, e As EventArgs) Handles cbo_tipo.TextChanged
        If cbo_tipo.Text = "A CREDITO" Then
            txt_recibido.Text = "0"
            txt_recibido.Select()
        Else
            txt_recibido.Clear()
            txt_recibido.Select()
        End If


    End Sub



    Private Sub CH_DESCUENTO_Click(sender As Object, e As EventArgs) Handles CH_DESCUENTO.Click

        frm_desbloqueo_para_descuento.ShowDialog()


    End Sub

    Private Sub CH_DESCUENTO_CheckedChanged(sender As Object, e As EventArgs) Handles CH_DESCUENTO.CheckedChanged
        If CH_DESCUENTO.Checked Then
            txt_descuento.Enabled = True
        Else
            txt_descuento.Enabled = False
        End If
    End Sub
End Class