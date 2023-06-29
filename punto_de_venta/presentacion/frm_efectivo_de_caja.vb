Imports System.Net.Mail
Imports System.Net
Imports System.IO
Public Class frm_efectivo_de_caja
    Private dt As New DataTable
    Private Class_inventaro As New class_inventario
    Private obj_cierre_de_caja As New ce_cierre_de_caja
    Private class_cierre_de_caja As New class_cierre_de_caja
    Private obj_cobro As New ce_cobro
    Private class_cobro As New class_cobro

    Public Declare Auto Function CreateFile Lib "kernel32.dll" (
ByVal lpFileName As String, ByVal dwDesiredAccess As Int32,
ByVal dwShareMode As Int32, ByVal lpSecurityAttributes As IntPtr,
ByVal dwCreationDisposition As Int32, ByVal dwFlagsAndAttributes As Int32,
ByVal hTemplateFile As IntPtr) As IntPtr

    Public Shared puerto As String
    Public Const GENERIC_READ As Int32 = &H80000000

    Public Const GENERIC_WRITE As Int32 = &H40000000

    Public Const OPEN_EXISTING As Int32 = 3




    Private Sub cerrarTurno()
        Dim d As New DialogResult
        d = MessageBox.Show("¿deceas cerrar el turno?", "cerrando turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim dt_cierre As New DataTable
        dt_cierre = Class_inventaro.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
        Me.Cursor = Cursors.WaitCursor
        If txt_valor_en_la_caja.Text.Trim <> String.Empty Then



            If IsNumeric(txt_valor_en_la_caja.Text) Then



                Dim dinero_contado As Decimal = Convert.ToDecimal(txt_valor_en_la_caja.Text)


                If d = DialogResult.Yes Then
                    Dim ventas_del_dia As String
                    If dt_cierre.Rows.Count > 0 Then
                        ventas_del_dia = dt_cierre.Rows(0).Item("ventas_del_dia").ToString
                    Else
                        ventas_del_dia = "0"
                    End If
                    If ventas_del_dia = "" Then
                        ventas_del_dia = "0"
                    End If


                    'MsgBox(txt_valor_en_la_caja.Text)

                    Dim dinero_queda_en_caja, total_retiros As String
                    dt = Class_inventaro.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
                    If dt.Rows.Count > 0 Then
                        dinero_queda_en_caja = dt.Rows(0).Item("dinero_en_caja")
                    Else
                        dinero_queda_en_caja = "0"
                    End If

                    If dinero_queda_en_caja = "" Then
                        dinero_queda_en_caja = "0"
                    End If


                    dt = class_cierre_de_caja.SUMAR_RETIROS_DEL_DIA
                    If dt.Rows.Count > 0 Then
                        total_retiros = dt.Rows(0).Item("retiros_del_dia").ToString

                    End If



                    If total_retiros = "" Then
                        total_retiros = "0"
                    End If

                    dinero_queda_en_caja = dinero_queda_en_caja + Convert.ToDecimal(frm_caja.lbl_fondo_en_caja.Text)
                    Dim valor_restante As String
                    If Convert.ToDecimal(ventas_del_dia) >= dinero_contado Then
                        valor_restante = "SOBRANTE:+" + ventas_del_dia.ToString
                    Else
                        valor_restante = "RESTANTE:-" + ventas_del_dia.ToString
                    End If

                    With obj_cierre_de_caja
                        .dinero_en_caja = Val(dinero_queda_en_caja)
                        .devoluciones = Val(frm_caja.lbl_devolucioneS_efectivos.Text)
                        .fecha = Today.Date
                        .usuario = Form1.lbl_nombre_de_usuario.Text
                        .hora = TimeOfDay.ToString("hh:mm")
                        .turno = Form1.lbl_turno.Text
                        .id_usuario = Form1.lbl_id_usuario.Text
                        .total_retirador = total_retiros
                        .retirado = Convert.ToDecimal(frm_caja.lbl_fondo_en_caja.Text.Replace(".", ","))
                        .total_en_ventas_del_dia = Val(ventas_del_dia)
                        .dinero_efectivo_en_caja = Val(txt_valor_en_la_caja.Text)
                        .tarjeta = Convert.ToDecimal(frm_caja.lblTotalTarjeta.Text)
                        .restante = ""
                        .totalBar = 0
                        .totalGomera = 0
                    End With
                    class_cierre_de_caja.insertar_cierre_de_caja(obj_cierre_de_caja)
                    enviar_correoNormal()
                    class_cierre_de_caja.poner_en_cierre_retirados()
                    Dim id_uusario As Integer
                    id_uusario = Val(Form1.lbl_id_usuario.Text)
                    class_cierre_de_caja.cerrar_turno_caja_diaria(id_uusario)


                    dt = Class_inventaro.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
                    If dt.Rows.Count > 0 Then
                        dinero_queda_en_caja = dt.Rows(0).Item("dinero_en_caja")
                    Else
                        dinero_queda_en_caja = "0"
                    End If

                    If dinero_queda_en_caja = "" Then
                        dinero_queda_en_caja = "0"
                    End If

                    dt = Class_inventaro.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
                    Dim id_dinero As Integer
                    class_cierre_de_caja.actualizar_al_cerrar_hora(Val(Form1.lbl_id_usuario.Text))

                    class_cierre_de_caja.sacar_los_fondos(Val(Form1.lbl_id_usuario.Text), Convert.ToDecimal(frm_caja.lbl_fondo_en_caja.Text.Replace(".", "")))

                    If dt.Rows.Count > 0 Then
                        id_dinero = dt.Rows(0).Item("id_dinero_en_caja")
                        With obj_cobro
                            .id_usuario = Val(Form1.lbl_id_usuario.Text)
                            .id_dinero_en_caja = id_dinero
                            .retiro = Convert.ToDecimal(dinero_queda_en_caja)
                        End With
                        Class_inventaro.retirar_dinero(obj_cobro)


                    End If
                    'abrircajon("COM1")
                    Me.Cursor = Cursors.Default
                    frm_reporte_cierre_de_caja.ShowDialog()
                    End
                Else
                    Me.Cursor = Cursors.Default
                    Me.Close()
                End If

            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show("Valor numerico incorrecto", "Cierre de turno", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Me.Cursor = Cursors.Default
            MessageBox.Show("Ingrese un monto de la caja", "Cierre de turno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Public Sub enviar_correoNormal()
        Try
            Dim fondo, dinero_queda_en_caja As Decimal
            Me.Cursor = Cursors.WaitCursor
            Dim en_ventas_del_dia As String
            Dim ganancias_del_dia As String
            Dim total_retiros As String
            dt = class_cierre_de_caja.SUMAR_RETIROS_DEL_DIA
            If dt.Rows.Count > 0 Then
                total_retiros = dt.Rows(0).Item("retiros_del_dia").ToString

            End If
            dt = Class_inventaro.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                en_ventas_del_dia = dt.Rows(0).Item("ventas_del_dia").ToString
            Else
                en_ventas_del_dia = "0"
            End If



            dt = class_cobro.verificar_si_hay_fondo(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                fondo = dt.Rows(0).Item("fondo").ToString
            Else
                fondo = "0"
            End If

            dt = Class_inventaro.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                dinero_queda_en_caja = dt.Rows(0).Item("dinero_en_caja")
            Else
                dinero_queda_en_caja = 0
            End If
            dt = Class_inventaro.ganancias_del_dia(Val(Form1.lbl_id_usuario.Text))

            If dt.Rows.Count > 0 Then
                ganancias_del_dia = dt.Rows(0).Item("ganancias_del_dia").ToString
            Else
                ganancias_del_dia = "0"
            End If
            If ganancias_del_dia = "" Then

                ganancias_del_dia = "0"
            End If

            Dim body As String
            Dim hora_del_sistema, fecha_del_sistema As String
            hora_del_sistema = TimeOfDay.ToString("hh:mm:ss")
            fecha_del_sistema = Today.Date
            Dim hora_abierta, hora_caja_cirrada As String
            Dim dinero_contado_de_caja As Decimal
            hora_abierta = ""
            dt = class_cierre_de_caja.selecionar_hora_caja_abierta(Val(Form1.lbl_id_usuario.Text))
            'If dt.Rows.Count > 0 Then
            '    hora_abierta = dt.Rows(0).Item("caja_abierta")
            hora_caja_cirrada = fecha_del_sistema + " " + hora_del_sistema
            dinero_queda_en_caja = dinero_queda_en_caja + fondo
            dinero_contado_de_caja = Convert.ToDecimal(txt_valor_en_la_caja.Text)
            body = "SUCURSAL: PRINCIPAL".ToString + "   USUARIO: ".ToString + Form1.lbl_nombre_de_usuario.Text.ToString + "   TURNO: " + Form1.lbl_turno.Text.ToString + "   CAJA ABIERTA: ".ToString + hora_abierta.ToString + vbCrLf + "   CAJA CERRADA:".ToString + hora_caja_cirrada.ToString + vbCrLf + "   FONDO DE LA CAJA: " + fondo.ToString + vbCrLf + " VENTAS DEL DIA: " + en_ventas_del_dia.ToString + vbCrLf + " DINERO EN CAJA: ".ToString + dinero_queda_en_caja.ToString + vbCrLf + "DINERO CONTADO EN CAJA: ".ToString + dinero_contado_de_caja.ToString + " DEVOLUCIONES: " + frm_caja.lbl_devolucioneS_efectivos.Text.ToString + " GANANCIAS: " + ganancias_del_dia.ToString

            'End If

            Dim message As New MailMessage
            Dim smtp As New SmtpClient




            message.From = New MailAddress("dead_25@outlook.es")
            message.To.Add("reimy_64@hotmail.com")

            'message.To.Add("corderoxg@gmail.com")

            'message.To.Add("gtx247247@gmail.com")

            'message.To.Add("whaterbautista@icloud.com")

            message.Body = body
            message.Subject = "JRSOFT CIERRE DE CAJA DEL:" + Today.Date
            message.Priority = MailPriority.Normal

            smtp.EnableSsl = True
            smtp.Port = "587"
            smtp.Host = "smtp.office365.com"
            smtp.Credentials = New NetworkCredential("dead_25@outlook.es", "Junior221089")
            smtp.Send(message)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Hubo en la conexion Correo de cierre de caja no enviado")
        End Try
    End Sub









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
    Public Sub enviar_correoT3(restante As String, totalGomera As String, totalBar As String, total As String)
        Try
            Dim fondo, dinero_queda_en_caja As Decimal
            Me.Cursor = Cursors.WaitCursor
            Dim en_ventas_del_dia As String
            Dim ganancias_del_dia As String
            Dim total_retiros As String
            dt = class_cierre_de_caja.SUMAR_RETIROS_DEL_DIA
            If dt.Rows.Count > 0 Then
                total_retiros = dt.Rows(0).Item("retiros_del_dia").ToString

            End If
            dt = Class_inventaro.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                en_ventas_del_dia = dt.Rows(0).Item("ventas_del_dia").ToString
            Else
                en_ventas_del_dia = "0"
            End If



            dt = class_cobro.verificar_si_hay_fondo(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                fondo = dt.Rows(0).Item("fondo").ToString
            Else
                fondo = "0"
            End If

            dt = Class_inventaro.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                dinero_queda_en_caja = dt.Rows(0).Item("dinero_en_caja")
            Else
                dinero_queda_en_caja = 0
            End If
            dt = Class_inventaro.ganancias_del_dia(Val(Form1.lbl_id_usuario.Text))

            If dt.Rows.Count > 0 Then
                ganancias_del_dia = dt.Rows(0).Item("ganancias_del_dia").ToString
            Else
                ganancias_del_dia = "0"
            End If
            If ganancias_del_dia = "" Then

                ganancias_del_dia = "0"
            End If

            Dim body As String
            Dim hora_del_sistema, fecha_del_sistema As String
            hora_del_sistema = TimeOfDay.ToString("hh:mm:ss")
            fecha_del_sistema = Today.Date
            Dim hora_abierta, hora_caja_cirrada As String
            Dim dinero_contado_de_caja As Decimal
            hora_abierta = ""
            dt = class_cierre_de_caja.selecionar_hora_caja_abierta(Val(Form1.lbl_id_usuario.Text))
            'If dt.Rows.Count > 0 Then
            '    hora_abierta = dt.Rows(0).Item("caja_abierta")
            hora_caja_cirrada = fecha_del_sistema + " " + hora_del_sistema
            dinero_queda_en_caja = dinero_queda_en_caja + fondo
            dinero_contado_de_caja = Convert.ToDecimal(txt_valor_en_la_caja.Text)
            body = "SUCURSAL: PRINCIPAL".ToString + "   USUARIO: ".ToString + Form1.lbl_nombre_de_usuario.Text.ToString + "   TURNO: " + Form1.lbl_turno.Text.ToString + "   CAJA ABIERTA: ".ToString + hora_abierta.ToString + vbCrLf + "   CAJA CERRADA:".ToString + hora_caja_cirrada.ToString + vbCrLf + "   FONDO DE LA CAJA: " + fondo.ToString + vbCrLf + " VENTAS DEL DIA: " + total.ToString + vbCrLf + " DINERO EN CAJA: ".ToString + dinero_queda_en_caja.ToString + vbCrLf + "DINERO CONTADO EN CAJA: ".ToString + dinero_contado_de_caja.ToString + " DEVOLUCIONES: " + frm_caja.lbl_devolucioneS_efectivos.Text.ToString + " GANANCIAS: " + ganancias_del_dia.ToString + vbCrLf + "Total Bar:" + totalBar.ToString + vbCrLf + "Total Gomera:" + totalGomera.ToString + vbCrLf + " " + restante.ToString

            'End If

            Dim message As New MailMessage
            Dim smtp As New SmtpClient




            message.From = New MailAddress("dead_25@outlook.es")
            message.To.Add("reimy_64@hotmail.com")

            'message.To.Add("corderoxg@gmail.com")

            'message.To.Add("whaterbautista@icloud.com")

            message.Body = body
            message.Subject = "JRSOFT CIERRE DE CAJA DEL:" + Today.Date
            message.Priority = MailPriority.Normal

            smtp.EnableSsl = True
            smtp.Port = "587"
            smtp.Host = "smtp.office365.com"
            smtp.Credentials = New NetworkCredential("dead_25@outlook.es", "Junior221089")
            smtp.Send(message)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Hubo en la conexion Correo de cierre de caja no enviado")
        End Try
    End Sub

    Public Sub enviar_correo(restante As String, totalGomera As String, totalBar As String)
        Try
            Dim fondo, dinero_queda_en_caja As Decimal
            Me.Cursor = Cursors.WaitCursor
            Dim en_ventas_del_dia As String
            Dim ganancias_del_dia As String
            Dim total_retiros As String
            dt = class_cierre_de_caja.SUMAR_RETIROS_DEL_DIA
            If dt.Rows.Count > 0 Then
                total_retiros = dt.Rows(0).Item("retiros_del_dia").ToString

            End If
            dt = Class_inventaro.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                en_ventas_del_dia = dt.Rows(0).Item("ventas_del_dia").ToString
            Else
                en_ventas_del_dia = "0"
            End If



            dt = class_cobro.verificar_si_hay_fondo(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                fondo = dt.Rows(0).Item("fondo").ToString
            Else
                fondo = "0"
            End If

            dt = Class_inventaro.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                dinero_queda_en_caja = dt.Rows(0).Item("dinero_en_caja")
            Else
                dinero_queda_en_caja = 0
            End If
            dt = Class_inventaro.ganancias_del_dia(Val(Form1.lbl_id_usuario.Text))

            If dt.Rows.Count > 0 Then
                ganancias_del_dia = dt.Rows(0).Item("ganancias_del_dia").ToString
            Else
                ganancias_del_dia = "0"
            End If
            If ganancias_del_dia = "" Then

                ganancias_del_dia = "0"
            End If

            Dim body As String
            Dim hora_del_sistema, fecha_del_sistema As String
            hora_del_sistema = TimeOfDay.ToString("hh:mm:ss")
            fecha_del_sistema = Today.Date
            Dim hora_abierta, hora_caja_cirrada As String
            Dim dinero_contado_de_caja As Decimal
            hora_abierta = ""
            dt = class_cierre_de_caja.selecionar_hora_caja_abierta(Val(Form1.lbl_id_usuario.Text))
            'If dt.Rows.Count > 0 Then
            '    hora_abierta = dt.Rows(0).Item("caja_abierta")
            hora_caja_cirrada = fecha_del_sistema + " " + hora_del_sistema
                dinero_queda_en_caja = dinero_queda_en_caja + fondo
                dinero_contado_de_caja = Convert.ToDecimal(txt_valor_en_la_caja.Text)
            body = "SUCURSAL: PRINCIPAL".ToString + "   USUARIO: ".ToString + Form1.lbl_nombre_de_usuario.Text.ToString + "   TURNO: " + Form1.lbl_turno.Text.ToString + "   CAJA ABIERTA: ".ToString + hora_abierta.ToString + vbCrLf + "   CAJA CERRADA:".ToString + hora_caja_cirrada.ToString + vbCrLf + "   FONDO DE LA CAJA: " + fondo.ToString + vbCrLf + " VENTAS DEL DIA: " + en_ventas_del_dia.ToString + vbCrLf + " DINERO EN CAJA: ".ToString + dinero_queda_en_caja.ToString + vbCrLf + "DINERO CONTADO EN CAJA: ".ToString + dinero_contado_de_caja.ToString + " DEVOLUCIONES: " + frm_caja.lbl_devolucioneS_efectivos.Text.ToString + " GANANCIAS: " + ganancias_del_dia.ToString + vbCrLf + "Total Bar:" + totalBar.ToString + vbCrLf + "Total Gomera:" + totalGomera.ToString + vbCrLf + " " + restante.ToString

            'End If

            Dim message As New MailMessage
            Dim smtp As New SmtpClient




            message.From = New MailAddress("dead_25@outlook.es")
            message.To.Add("reimy_64@hotmail.com")

            'message.To.Add("corderoxg@gmail.com")

            'message.To.Add("whaterbautista@icloud.com")

            message.Body = body
            message.Subject = "JRSOFT CIERRE DE CAJA DEL:" + Today.Date
            message.Priority = MailPriority.Normal

            smtp.EnableSsl = True
            smtp.Port = "587"
            smtp.Host = "smtp.office365.com"
            smtp.Credentials = New NetworkCredential("dead_25@outlook.es", "Junior221089")
            smtp.Send(message)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Hubo en la conexion Correo de cierre de caja no enviado")
        End Try
    End Sub
    Private Sub cobrar()
        Dim d As New DialogResult
        d = MessageBox.Show("¿deceas cerrar el turno?", "cerrando turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim dt_cierre As New DataTable
        dt_cierre = Class_inventaro.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
        Me.Cursor = Cursors.WaitCursor

        If d = DialogResult.Yes Then
                    Dim ventas_del_dia As String
                    If dt_cierre.Rows.Count > 0 Then
                        ventas_del_dia = dt_cierre.Rows(0).Item("ventas_del_dia").ToString
                    Else
                        ventas_del_dia = "0"
                    End If
            If ventas_del_dia = "" Then
                ventas_del_dia = "0"
            End If


            'MsgBox(txt_valor_en_la_caja.Text)

            Dim dinero_queda_en_caja, total_retiros As String
                    dt = Class_inventaro.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
                    If dt.Rows.Count > 0 Then
                        dinero_queda_en_caja = dt.Rows(0).Item("dinero_en_caja")
                    Else
                        dinero_queda_en_caja = "0"
                    End If

                    If dinero_queda_en_caja = "" Then
                        dinero_queda_en_caja = "0"
                    End If


                    dt = class_cierre_de_caja.SUMAR_RETIROS_DEL_DIA
                    If dt.Rows.Count > 0 Then
                        total_retiros = dt.Rows(0).Item("retiros_del_dia").ToString

                    End If



                    If total_retiros = "" Then
                        total_retiros = "0"
                    End If


            Dim totalGomera, totalBar As Decimal
            dt = class_cierre_de_caja.sumarBar(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows(0).Item("totalBar").ToString <> "" Then
                totalBar = Convert.ToDecimal(dt.Rows(0).Item("totalBar").ToString)
            Else
                totalBar = 0
            End If
            dt = class_cierre_de_caja.sumarGomera(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows(0).Item("total").ToString <> "" Then
                totalGomera = Convert.ToDecimal(dt.Rows(0).Item("total").ToString)
            Else
                totalGomera = 0
            End If
            Dim restante As String = ""


            dt = class_cierre_de_caja.selecionarUsuario(Val(Form1.lbl_id_usuario.Text))

            Dim turno = dt.Rows(0).Item("turno").ToString


            If turno.Equals("T3") Then


                Dim id_uusario As Integer
                id_uusario = Val(Form1.lbl_id_usuario.Text)

                class_cierre_de_caja.cerrar_turno_caja_diaria(id_uusario)


                dt = Class_inventaro.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
                If dt.Rows.Count > 0 Then
                    dinero_queda_en_caja = dt.Rows(0).Item("dinero_en_caja")
                Else
                    dinero_queda_en_caja = "0"
                End If

                If dinero_queda_en_caja = "" Then
                    dinero_queda_en_caja = "0"
                End If

                dt = Class_inventaro.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
                Dim id_dinero As Integer
                class_cierre_de_caja.actualizar_al_cerrar_hora(Val(Form1.lbl_id_usuario.Text))
                dt = class_cierre_de_caja.sumarVentasTotales
                Dim dineroDia As Decimal
                If dt.Rows(0).Item("total").ToString <> "" Then
                    dineroDia = Convert.ToDecimal(dt.Rows(0).Item("total").ToString)
                Else
                    dineroDia = 0
                End If

                dt = class_cierre_de_caja.sumarVentasDeldiaGomera
                If dt.Rows(0).Item("total").ToString <> "" Then
                    totalGomera = Convert.ToDecimal(dt.Rows(0).Item("total").ToString)
                Else
                    totalGomera = 0
                End If

                dt = class_cierre_de_caja.sumarVentasDeldiaBar
                If dt.Rows(0).Item("total").ToString <> "" Then
                    totalBar = Convert.ToDecimal(dt.Rows(0).Item("total").ToString)
                Else
                    totalBar = 0
                End If
                Dim total As Decimal = totalGomera + totalBar
                If total > Val(txt_valor_en_la_caja.Text) Then
                    Dim r = total - Val(txt_valor_en_la_caja.Text)
                    restante = "FALTANTE:" + r.ToString()
                Else
                    Dim r = Val(txt_valor_en_la_caja.Text) - total
                    restante = "SOBRANTE:" + r.ToString()
                End If


                With obj_cierre_de_caja
                    .dinero_en_caja = Val(dineroDia)
                    .devoluciones = Val(frm_caja.lbl_devolucioneS_efectivos.Text)
                    .fecha = Today.Date
                    .usuario = Form1.lbl_nombre_de_usuario.Text
                    .hora = TimeOfDay.ToString("hh:mm")
                    .turno = Form1.lbl_turno.Text
                    .id_usuario = Form1.lbl_id_usuario.Text
                    .total_retirador = total_retiros
                    .retirado = Convert.ToDecimal(frm_caja.lbl_fondo_en_caja.Text.Replace(".", ","))
                    .total_en_ventas_del_dia = Val(total)
                    .dinero_efectivo_en_caja = Val(txt_valor_en_la_caja.Text)
                    .restante = restante
                    .totalBar = totalBar
                    .totalGomera = totalGomera
                    .tarjeta = Convert.ToDecimal(frm_caja.lblTotalTarjeta.Text.Replace(".", ","))
                End With
                class_cierre_de_caja.insertar_cierre_de_caja(obj_cierre_de_caja)

                'enviar_correoT3(restante, totalGomera.ToString(), totalBar.ToString(), total.ToString)
                class_cierre_de_caja.cerrarCajaDiaria()
                class_cierre_de_caja.poner_en_cierre_retirados()
                'class_cierre_de_caja.ponerEnCierreDetalles()
                'class_cierre_de_caja.sacarDineroCaja()
                'class_cierre_de_caja.sacarFondos()




                class_cierre_de_caja.sacar_los_fondos(Val(Form1.lbl_id_usuario.Text), Convert.ToDecimal(frm_caja.lbl_fondo_en_caja.Text))

                If dt.Rows.Count > 0 Then
                    id_dinero = dt.Rows(0).Item("id_dinero_en_caja")
                    With obj_cobro
                        .id_usuario = Val(Form1.lbl_id_usuario.Text)
                        .id_dinero_en_caja = id_dinero
                        .retiro = Convert.ToDecimal(dinero_queda_en_caja)
                    End With
                    Class_inventaro.retirar_dinero(obj_cobro)


                End If

            Else
                Dim total As Decimal
                    total = totalBar + totalGomera
                If total > Val(txt_valor_en_la_caja.Text) Then
                    Dim r = total - Val(txt_valor_en_la_caja.Text)
                    restante = "FALTANTE:" + r.ToString()
                Else
                    Dim r = Val(txt_valor_en_la_caja.Text) - total
                    restante = "SOBRANTE:" + r.ToString()
                End If

                With obj_cierre_de_caja
                    .dinero_en_caja = Val(dinero_queda_en_caja)
                    .devoluciones = Val(frm_caja.lbl_devolucioneS_efectivos.Text)
                    .fecha = Today.Date
                    .usuario = Form1.lbl_nombre_de_usuario.Text
                    .hora = TimeOfDay.ToString("hh:mm")
                    .turno = Form1.lbl_turno.Text
                    .id_usuario = Form1.lbl_id_usuario.Text
                    .total_retirador = total_retiros
                    .retirado = Convert.ToDecimal(frm_caja.lbl_fondo_en_caja.Text.Replace(".", ","))
                    .total_en_ventas_del_dia = Val(total)
                    .dinero_efectivo_en_caja = Val(txt_valor_en_la_caja.Text)
                    .restante = restante
                    .totalBar = totalBar
                    .totalGomera = totalGomera
                    .tarjeta = Convert.ToDecimal(frm_caja.lblTotalTarjeta.Text.Replace(".", ","))
                End With
                class_cierre_de_caja.insertar_cierre_de_caja(obj_cierre_de_caja)
                enviar_correo(restante, totalGomera.ToString(), totalBar.ToString())


            End If
            'enviar_correo(restante, totalGomera.ToString(), totalBar.ToString())
            ''abrircajon("COM1")
            Me.Cursor = Cursors.Default
                    frm_reporte_cierre_de_caja.ShowDialog()
                    End
                Else
                    Me.Cursor = Cursors.Default
                    Me.Close()
                End If

                'Else
        '    Me.Cursor = Cursors.Default
        '    MessageBox.Show("Valor numerico incorrecto", "Cierre de turno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        '    Else
        '    Me.Cursor = Cursors.Default
        '    MessageBox.Show("Ingrese un monto de la caja", "Cierre de turno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub


    Private Sub btn_cobrar_Click(sender As Object, e As EventArgs) Handles btn_cobrar.Click

        cerrarTurno()
    End Sub

    Private Sub txt_valor_en_la_caja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor_en_la_caja.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then

            cerrarTurno()


        End If
    End Sub

    Private Sub frm_efectivo_de_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txt_valor_en_la_caja.Select()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_valor_en_la_caja.Clear()
        Me.Close()
    End Sub

    Private Sub txt_valor_en_la_caja_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_en_la_caja.TextChanged

    End Sub
End Class