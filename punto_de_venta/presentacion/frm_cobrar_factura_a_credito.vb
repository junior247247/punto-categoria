Imports System.IO
Public Class frm_cobrar_factura_a_credito
    Private dt As New DataTable
    Private obj_venta As New ce_venta
    Private class_venta As New class_venta
    Private obj_venta_final As New ce_venta_final
    Private class_cobro As New class_cobro
    Private obb_caja_diaria As New ce_caja_diaria
    Private obj_cobro As New ce_cobro
    Private class_invenntario As New class_inventario
    Private class_caja_diaria As New class_caja_diaria

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




    Private Sub frm_cobrar_factura_a_credito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_articulos()
        cbo_forma_de_pago.DropDownStyle = 2
        txt_monto.Select()
    End Sub

    Public Sub mostrar_pendietes_de_cregitos()
        Try
            dt = class_venta.mostrar_facturas_a_creditos
            frm_facturas_a_creditos.datalistado_facturas.DataSource = dt
            frm_facturas_a_creditos.datalistado_facturas.EnableHeadersVisualStyles = False
            For i = 0 To frm_facturas_a_creditos.datalistado_facturas.Columns.Count - 1 Step 1
                frm_facturas_a_creditos.datalistado_facturas.Columns(i).Width = 150
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub home()
        'Try

        '    dt = class_invenntario.sumar_mantenimiento_por_30_dias
        '    frm_inventario.lbl_mantenimiento_por_30_dias.Text = dt.Rows(0).Item("ingresos_mantenimiento_por30_dias").ToString
        '    If frm_inventario.lbl_mantenimiento_por_30_dias.Text = String.Empty Then
        '        frm_inventario.lbl_mantenimiento_por_semana.Text = "0.00"
        '    End If





        '    dt = class_invenntario.sumar_mantenimiento_por_7_dias
        '    frm_inventario.lbl_mantenimiento_por_semana.Text = dt.Rows(0).Item("ingresos_mantenimiento_por7_dias").ToString
        '    If frm_inventario.lbl_mantenimiento_por_semana.Text = String.Empty Then
        '        frm_inventario.lbl_mantenimiento_por_semana.Text = "0.00"
        '    End If



        '    dt = class_invenntario.sumar_liquidos_por_semana
        '    frm_inventario.lbl_por_semanas_liquidos.Text = dt.Rows(0).Item("ingresos_liquidos_por_semanas").ToString
        '    If frm_inventario.lbl_por_semanas_liquidos.Text = String.Empty Then
        '        frm_inventario.lbl_por_semanas_liquidos.Text = "0.00"
        '    End If

        '    dt = class_invenntario.sumar_liquidos_por_30_dias
        '    frm_inventario.lbl_detalle_por_mes.Text = dt.Rows(0).Item("ingresos_liquidos_por_30_dias").ToString
        '    If frm_inventario.lbl_detalle_por_mes.Text = String.Empty Then
        '        frm_inventario.lbl_detalle_por_mes.Text = "0.00"
        '    End If


        '    dt = class_invenntario.sumar_ventas_del_mes
        '    If dt.Rows.Count > 0 Then
        '        frm_home.lbl_compras_del_mes.Text = "RD$ " + dt.Rows(0).Item("compras_del_mes").ToString


        '    End If

        '    If frm_home.lbl_compras_del_mes.Text = "RD$ " Then
        '        frm_home.lbl_compras_del_mes.Text = "RD$ 0.00"
        '    End If





        '    dt = class_invenntario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
        '    If dt.Rows.Count > 0 Then
        '        frm_home.lbl_dinero_en_caja.Text = "RD$ " + dt.Rows(0).Item("dinero_en_caja").ToString
        '    Else
        '        frm_home.lbl_dinero_en_caja.Text = "RD$ 0.00"
        '    End If
        '    dt = class_invenntario.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
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

        '    dt = class_invenntario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
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



    Public Sub mostrar_articulos()
        Try
            obj_venta.id_venta = Val(lbl_id_factura.Text)

            dt = class_venta.mostrar_articulos(obj_venta)
            datalistado_articulos.DataSource = dt
            datalistado_articulos.EnableHeadersVisualStyles = False
            datalistado_articulos.Columns(0).Visible = False
            datalistado_articulos.Columns(6).Visible = False
            datalistado_articulos.Columns(7).Visible = False
            datalistado_articulos.Columns(8).Visible = False
            For i = 0 To datalistado_articulos.Columns.Count - 1 Step 1
                datalistado_articulos.Columns(i).Width = 170
            Next

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
    Public Sub limpiar()
        Try
            lbl_cliente.Text = ""
            lbl_id_factura.Text = "0"
            lbl_pagado.Text = "0"
            lbl_pendiente.Text = "0"
            txt_monto.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cobrar()
        Dim d As New DialogResult
        d = MessageBox.Show("Seguro deceas cobrar la factura no: " + lbl_id_factura.Text, "Cobrando factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If d = DialogResult.Yes Then
            If IsNumeric(txt_monto.Text) Then

                If Convert.ToDecimal(txt_monto.Text) <= Convert.ToDecimal(lbl_pendiente.Text) Then
                    Me.Cursor = Cursors.WaitCursor
                    With obj_venta_final
                        .id_venta = Val(lbl_id_factura.Text)
                        .importe = Convert.ToDecimal(txt_monto.Text)
                        .pendiente = Convert.ToDecimal(txt_monto.Text)
                        .pagado = Convert.ToDecimal(txt_monto.Text)
                    End With
                    class_cobro.actualizar_importe_venta_final(obj_venta_final)
                    class_cobro.actualizar_importe_reporte(obj_venta_final)
                    Dim ganancias, importe, result As Decimal
                    For i = 0 To datalistado_articulos.Rows.Count - 1 Step 1
                        ganancias += datalistado_articulos.Rows(i).Cells("ganancia").Value
                    Next
                    importe = Convert.ToDecimal(lbl_pendiente.Text) + Convert.ToDecimal(lbl_pagado.Text)
                    result = ganancias / Convert.ToDecimal(importe)
                    result = result * Convert.ToDecimal(txt_monto.Text)
                    dt = class_cobro.verificar_si_hay_registro(Val(Form1.lbl_id_usuario.Text))


                    If cbo_forma_de_pago.Text = "EFECTIVO" Then
                        If dt.Rows.Count > 0 Then
                            Dim id_dinero As Integer
                            id_dinero = dt.Rows(0).Item("id_dinero_en_caja")
                            With obj_cobro
                                .id_usuario = Val(Form1.lbl_id_usuario.Text)
                                .id_dinero_en_caja = Val(id_dinero)
                                .dinero_en_cja = Convert.ToDecimal(txt_monto.Text)
                            End With
                            class_cobro.actualizar_dinero_en_caja(obj_cobro)
                        Else
                            obj_cobro.id_usuario = Val(Form1.lbl_id_usuario.Text)
                            obj_cobro.dinero_en_cja = Convert.ToDecimal(txt_monto.Text)
                            class_cobro.insertar_dinero_en_caja(obj_cobro)
                        End If
                    End If



                    With obb_caja_diaria
                        .id_venta = Val(lbl_id_factura.Text)
                        .id_cajero = Val(Form1.lbl_id_usuario.Text)
                        .estado = "VALIDO"
                        .cierre = "SIN CIERRE"
                        .ganancia = result
                        .importe = Format(Convert.ToDecimal(txt_monto.Text), "0.00")
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
                    class_venta.QUITAR_DE_CREDITO()
                    class_venta.poner_en_positivo_creditos()
                    class_venta.poner_en_positivos_reporte_credito()
                    mostrar_nventario()
                    home()
                    mostrar_ingresos_del_dia()
                    mostrar_articulos()
                    mostrar()
                    mostrar_pendietes_de_cregitos()
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("Cobro de factura realizado con exito", "Cobrando factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim dt_verifica_si_es_con_rnc As New DataTable
                    dt_verifica_si_es_con_rnc = class_venta.verifiacar_si_lleva_rnc_con_credito(Val(lbl_id_factura.Text))
                    If dt_verifica_si_es_con_rnc.Rows.Count > 0 Then
                        frm_reporte_con_rcn_y_a_credito.lbl_id_venta.Text = lbl_id_factura.Text
                        frm_reporte_con_rcn_y_a_credito.ShowDialog()
                    Else
                        frm_reporte_venta_a_creditos.lbl_id_venta.Text = lbl_id_factura.Text
                        frm_reporte_venta_a_creditos.ShowDialog()
                    End If
                    'abrircajon("LPT3")
                    limpiar()
                    Me.Close()
                Else
                    MessageBox.Show("El monto a pagar debe ser menor o igual que el saldo pendiente", "Cobrando factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Introduzca un valor numerico valido", "Cobrando factura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_cobrar_Click(sender As Object, e As EventArgs) Handles btn_cobrar.Click
        cobrar()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub txt_monto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_monto.KeyPress

        If e.KeyChar = Chr(Keys.Enter) Then

            cobrar()


        End If


    End Sub
End Class