Imports System.IO
Public Class frm_venta_liquido
    Private class_text As New class_texto
    Private obj_liquido As New ce_liquidos
    Private class_caja_diaria As New class_caja_diaria
    Private obj_caja_diaria As New ce_caja_diaria
    Private class_cobro As New class_cobro
    Private obj_cobro As New ce_cobro
    Private dt As New DataTable
    Private obj_final As New ce_venta_final
    Private class_venta As New class_venta
    Private class_inventario As New class_inventario
    Private obj_venta As New ce_venta

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


    Public Sub mostrar_ingresos_del_dia()
        Try
            dt = class_inventario.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
            frm_caja.lbl_dinero_encaja.Text = dt.Rows(0).Item("ventas_del_dia").ToString
            frm_caja.lbl_dinero_en_caja.Text = dt.Rows(0).Item("ventas_del_dia").ToString
            frm_caja.lbl_total_ventas_card_y_efeec.Text = dt.Rows(0).Item("ventas_del_dia").ToString

            If frm_caja.lbl_dinero_encaja.Text = String.Empty Then
                frm_caja.lbl_dinero_encaja.Text = "0.00"
                frm_caja.lbl_dinero_en_caja.Text = "0.00"
                frm_caja.lbl_total_ventas_card_y_efeec.Text = "0.00"
                frm_caja.lbl_contador_ventas.Text = "0"
            End If

            dt = class_inventario.ganancias_del_dia(Val(Form1.lbl_id_usuario.Text))
            frm_caja.lbl_ganancia_en_ventas.Text = dt.Rows(0).Item("ganancias_del_dia").ToString
            If frm_caja.lbl_ganancia_en_ventas.Text = String.Empty Then
                frm_caja.lbl_ganancia_en_ventas.Text = "0.00"
            End If
            dt = class_inventario.devoluciones(Val(Form1.lbl_id_usuario.Text))
            frm_caja.lbl_devolucioneS_efectivos.Text = dt.Rows(0).Item("devoluciones_del_dia").ToString
            If frm_caja.lbl_devolucioneS_efectivos.Text = String.Empty Then
                frm_caja.lbl_devolucioneS_efectivos.Text = "0"
            End If

            dt = class_inventario.mostrar_listado_ingreso_del_dia(Val(Form1.lbl_id_usuario.Text))
            frm_caja.datalistado_caja.DataSource = dt
            frm_caja.lbl_contador_ventas.Text = frm_caja.datalistado_caja.Rows.Count
            frm_caja.datalistado_caja.EnableHeadersVisualStyles = False
            For i = 0 To frm_caja.datalistado_caja.Columns.Count - 1 Step 1
                frm_caja.datalistado_caja.Columns(i).Width = 170
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub home()



        Try
            dt = class_inventario.sumar_mantenimiento_por_30_dias

            frm_inventario.lbl_mantenimiento_por_30_dias.Text = dt.Rows(0).Item("ingresos_mantenimiento_por30_dias").ToString
            If frm_inventario.lbl_mantenimiento_por_30_dias.Text = String.Empty Then
                frm_inventario.lbl_mantenimiento_por_semana.Text = "0.00"
            End If





            dt = class_inventario.sumar_mantenimiento_por_7_dias
            frm_inventario.lbl_mantenimiento_por_semana.Text = dt.Rows(0).Item("ingresos_mantenimiento_por7_dias").ToString
            If frm_inventario.lbl_mantenimiento_por_semana.Text = String.Empty Then
                frm_inventario.lbl_mantenimiento_por_semana.Text = "0.00"
            End If




            dt = class_inventario.sumar_liquidos_por_30_dias
            frm_inventario.lbl_detalle_por_mes.Text = dt.Rows(0).Item("ingresos_liquidos_por_30_dias").ToString
            If frm_inventario.lbl_detalle_por_mes.Text = String.Empty Then
                frm_inventario.lbl_detalle_por_mes.Text = "0.00"
            End If



            dt = class_inventario.sumar_liquidos_por_semana
            frm_inventario.lbl_por_semanas_liquidos.Text = dt.Rows(0).Item("ingresos_liquidos_por_semanas").ToString
            If frm_inventario.lbl_por_semanas_liquidos.Text = String.Empty Then
                frm_inventario.lbl_por_semanas_liquidos.Text = "0.00"
            End If


            dt = class_inventario.sumar_ventas_del_mes
            If dt.Rows.Count > 0 Then
                frm_home.lbl_compras_del_mes.Text = "RD$ " + dt.Rows(0).Item("compras_del_mes").ToString


            End If

            If frm_home.lbl_compras_del_mes.Text = "RD$ " Then
                frm_home.lbl_compras_del_mes.Text = "RD$ 0.00"
            End If





            dt = class_inventario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                frm_home.lbl_dinero_en_caja.Text = "RD$ " + dt.Rows(0).Item("dinero_en_caja").ToString
            Else
                frm_home.lbl_dinero_en_caja.Text = "RD$ 0.00"
            End If
            dt = class_inventario.dinero_de_ventas_del_dia(Form1.lbl_id_usuario.Text)
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






    Public Sub mostrar_nventario()
        Try


            dt = class_inventario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))

            If dt.Rows.Count > 0 Then
                frm_inventario.lbl_dinero_en_caja.Text = dt.Rows(0).Item("dinero_en_caja").ToString
            Else
                frm_inventario.lbl_dinero_en_caja.Text = "0.00"
            End If

            dt = class_inventario.sumar_mantenimiento_por_30_dias
            frm_inventario.lbl_mantenimiento_por_30_dias.Text = dt.Rows(0).Item("ingresos_mantenimiento_por30_dias").ToString
            If frm_inventario.lbl_mantenimiento_por_30_dias.Text = String.Empty Then
                frm_inventario.lbl_mantenimiento_por_semana.Text = "0.00"
            End If
            dt = class_inventario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))

            If dt.Rows.Count > 0 Then
                frm_home.lbl_dinero_en_caja.Text = "RD$ " + dt.Rows(0).Item("dinero_en_caja").ToString
            Else
                frm_home.lbl_dinero_en_caja.Text = "RD$ 0.00"
            End If


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

            frm_caja.lbl_dinero_encaja.Text = total.ToString
            frm_caja.lbl_total_ventas_card_y_efeec.Text = total.ToString


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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub frm_venta_liquido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_motivo.DropDownStyle = 2
        txt.Select()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_cobrar_Click(sender As Object, e As EventArgs) Handles btn_cobrar.Click
        If txt.Text.Trim <> String.Empty Then
            IsNumeric(txt.Text)
            With obj_liquido
                .fecha = Today.Date
                .monto = Val(txt.Text)
                .motivo = cbo_motivo.Text
            End With
            class_text.insertar_cobro_liquido(obj_liquido)


            Dim id_operacion As Integer
            dt = class_text.mostrar_cobro_liquido_o_mantenimiento
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1 Step 1
                    id_operacion = dt.Rows(i).Item("id_liquido")
                Next
            End If

            With obj_venta
                .cantidad = 1
                .id_producto = Val(0)
                .itbis = 0
                .precio = Format(Convert.ToDecimal(txt.Text), "0.00")
                .id_venta = Val(id_operacion)
                .total = Format(Convert.ToDecimal(txt.Text), "0.00")
                .gananci = 0
                .estado = "VENDIDO"
                .descuento = 0
                .categoria = "GOMERA"
                .idCajero = Val(Form1.lbl_id_usuario.Text)
                .fecha = Today.Date
            End With
            class_venta.insertar_detalle_de_venta(obj_venta)



            With obj_caja_diaria
                .id_venta = id_operacion
                .id_cajero = Val(Form1.lbl_id_usuario.Text)
                .estado = "VALIDO"
                .cierre = "SIN CIERRE"
                .ganancia = Val(0)
                .importe = Val(txt.Text)
                .medio_de_pago = "EFECTIVO"
                .hora = TimeOfDay.ToString("HH:MM")
                .terminal = Net.Dns.GetHostName
                .tipo_operacion = cbo_motivo.Text
                .valor_de_cambio = 0
                .tipo_de_movimiento = "INGRESO"
                .fecha = Today.Date
                .tipo_de_moneda = "RD"
            End With
            class_caja_diaria.insertar_caja_diaria(obj_caja_diaria)



            dt = class_cobro.verificar_si_hay_registro(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                Dim id_dinero As Integer
                id_dinero = dt.Rows(0).Item("id_dinero_en_caja")
                With obj_cobro
                    .id_usuario = Val(Form1.lbl_id_usuario.Text)
                    .id_dinero_en_caja = Val(id_dinero)
                    .dinero_en_cja = Val(txt.Text)
                End With
                class_cobro.actualizar_dinero_en_caja(obj_cobro)
            Else
                obj_cobro.id_usuario = Val(Form1.lbl_id_usuario.Text)

                obj_cobro.dinero_en_cja = Val(txt.Text)
                class_cobro.insertar_dinero_en_caja(obj_cobro)

            End If





            With obj_final
                .condicion = "CONTADO"
                .articulos = Val(1)
                .importe = Val(txt.Text)
                .cliente = ""
                .descuento = Val(0)
                .documento = "TICKET"
                .fecha = Today.Date
                .id_venta = Val(id_operacion)
                .pagado = Val(txt.Text)
                .pendiente = 0

            End With
            class_venta.insertar_venta_final(obj_final)

            home()
            mostrar_nventario()
            mostrar_ingresos_del_dia()

            mostrar()

            MessageBox.Show("cobro realizado con exito", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'abrircajon("LPT1")
            txt.Clear()
            Me.Close()
        End If



    End Sub

    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If txt.Text.Trim <> String.Empty Then
                IsNumeric(txt.Text)
                With obj_liquido
                    .fecha = Today.Date
                    .monto = Val(txt.Text)
                    .motivo = cbo_motivo.Text
                End With
                class_text.insertar_cobro_liquido(obj_liquido)


                Dim id_operacion As Integer
                dt = class_text.mostrar_cobro_liquido_o_mantenimiento
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1 Step 1
                        id_operacion = dt.Rows(i).Item("id_liquido")
                    Next
                End If

                With obj_venta
                    .cantidad = 1
                    .id_producto = Val(0)
                    .itbis = 0
                    .precio = Format(Convert.ToDecimal(txt.Text), "0.00")
                    .id_venta = Val(id_operacion)
                    .total = Format(Convert.ToDecimal(txt.Text), "0.00")
                    .gananci = 0
                    .estado = "VENDIDO"
                    .descuento = 0
                    .categoria = "GOMERA"
                    .idCajero = Val(Form1.lbl_id_usuario.Text)
                    .fecha = Today.Date
                End With
                class_venta.insertar_detalle_de_venta(obj_venta)



                With obj_caja_diaria
                    .id_venta = id_operacion
                    .id_cajero = Val(Form1.lbl_id_usuario.Text)
                    .estado = "VALIDO"
                    .cierre = "SIN CIERRE"
                    .ganancia = Val(0)
                    .importe = Val(txt.Text)
                    .medio_de_pago = "EFECTIVO"
                    .hora = TimeOfDay.ToString("HH:MM")
                    .terminal = Net.Dns.GetHostName
                    .tipo_operacion = cbo_motivo.Text
                    .valor_de_cambio = 0
                    .tipo_de_movimiento = "INGRESO"
                    .fecha = Today.Date
                    .tipo_de_moneda = "RD"
                End With
                class_caja_diaria.insertar_caja_diaria(obj_caja_diaria)



                dt = class_cobro.verificar_si_hay_registro(Val(Form1.lbl_id_usuario.Text))
                If dt.Rows.Count > 0 Then
                    Dim id_dinero As Integer
                    id_dinero = dt.Rows(0).Item("id_dinero_en_caja")
                    With obj_cobro
                        .id_usuario = Val(Form1.lbl_id_usuario.Text)
                        .id_dinero_en_caja = Val(id_dinero)
                        .dinero_en_cja = Val(txt.Text)
                    End With
                    class_cobro.actualizar_dinero_en_caja(obj_cobro)
                Else
                    obj_cobro.id_usuario = Val(Form1.lbl_id_usuario.Text)

                    obj_cobro.dinero_en_cja = Val(txt.Text)
                    class_cobro.insertar_dinero_en_caja(obj_cobro)

                End If





                With obj_final
                    .condicion = "CONTADO"
                    .articulos = Val(1)
                    .importe = Val(txt.Text)
                    .cliente = ""
                    .descuento = Val(0)
                    .documento = "TICKET"
                    .fecha = Today.Date
                    .id_venta = Val(id_operacion)
                    .pagado = Val(txt.Text)
                    .pendiente = 0

                End With
                class_venta.insertar_venta_final(obj_final)

                home()
                mostrar_nventario()
                mostrar_ingresos_del_dia()

                mostrar()

                MessageBox.Show("cobro realizado con exito", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'abrircajon("LPT1")
                txt.Clear()
                Me.Close()
            End If
        End If
    End Sub
End Class