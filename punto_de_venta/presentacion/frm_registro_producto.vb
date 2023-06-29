Imports System.Net.Mail
Imports System.Net
Imports System.IO
Public Class frm_registro_producto
    Protected obj_producto As New ce_producto
    Protected class_producto As New class_producto
    Protected class_invenntario As New class_inventario
    Protected dt As New DataTable
    Private Almacen As New Almacen
    Dim existenciaActual, exitenciActualizada As Integer
    Dim description, exitenciaUpdating As String

    Public Sub enviar_correo()
        Try

            Me.Cursor = Cursors.WaitCursor


            Dim body As String
            Dim hora_del_sistema, fecha_del_sistema As String
            hora_del_sistema = TimeOfDay.ToString("hh:mm:ss")
            fecha_del_sistema = Today.Date



            Dim message As New MailMessage
            Dim smtp As New SmtpClient




            message.From = New MailAddress("dead_25@outlook.es")
            message.To.Add("reimy_64@hotmail.com")
            ''message.To.Add("whaterrodriguez@gmail.com")
            'message.To.Add("edelmirogalva@yahoo.com")
            'message.To.Add("whaterbautista@icloud.com")
            dt = class_producto.verificar_producto(Val(lbl_id_producto.Text))
            If dt.Rows.Count > 0 Then
                existenciaActual = Convert.ToInt32(dt.Rows(0).Item("Cantidad"))
                description = Convert.ToString(dt.Rows(0).Item("Descripcion"))
            End If


            If Val(txt_cantidad_producto.Text) < existenciaActual Then
                Dim parcial As Integer
                parcial = existenciaActual - Val(txt_cantidad_producto.Text)
                Dim stringActual = Convert.ToString(existenciaActual)
                Dim strinParcial = Convert.ToString(parcial)
                exitenciaUpdating = "EL PRODUCTO: " + description.ToString & " CON LA CANTIDAD DE " & stringActual & " FUE DISMINUIDO CON LA CANTIDAD DE: " & strinParcial.ToString & "    CANTIDAD INGRESADA: " & txt_cantidad_producto.Text.ToString



            Else
                Dim parcial As Integer
                parcial = Val(txt_cantidad_producto.Text) - existenciaActual
                exitenciaUpdating = "EL PRODUCTO: " + description.ToString + " FUE ACTUALIZADO CON LA CANTIDAD DE: " + parcial.ToString

            End If

            message.Body = exitenciaUpdating
            message.Subject = "JRSOFT PRODUCTO ACTUALIZADO EL DIA:" + Today.Date
            message.Priority = MailPriority.Normal

            smtp.EnableSsl = True
            smtp.Port = "587"
            smtp.Host = "smtp.office365.com"
            smtp.Credentials = New NetworkCredential("dead_25@outlook.es", "Junior221089")
            smtp.Send(message)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                frm_inventario.lbl_dinero_en_producto.Text = Format(Convert.ToDecimal(total), "0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub mostrar_productos_almacen()
        Try
            dt = Almacen.mostrarAlmacen
            frm_almacen.datalistado_productos.DataSource = dt
            frm_almacen.datalistado_productos.Columns(0).Visible = False
            frm_almacen.datalistado_productos.Columns(1).Visible = False
            frm_almacen.datalistado_productos.EnableHeadersVisualStyles = False
            If frm_almacen.datalistado_productos.Rows.Count > 0 Then
                frm_almacen.datalistado_productos.ContextMenuStrip = frm_almacen.c_menu_reabastecer
            Else
                frm_almacen.datalistado_productos.ContextMenuStrip = Nothing
            End If

            frm_almacen.datalistado_productos.Columns(2).Width = 270
            For i = 2 To frm_almacen.datalistado_productos.Columns.Count - 1 Step 1
                frm_almacen.datalistado_productos.Columns(i).Width = 200
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
            dt = class_invenntario.dinero_de_ventas_del_dia(1)
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








    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        pciture_producto.Image = My.Resources.SIN_IMAGEN
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
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If dlg.ShowDialog = DialogResult.OK Then
            pciture_producto.Image = Nothing
            pciture_producto.Image = New Bitmap(dlg.FileName)

            pciture_producto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Public Sub limpiar()
        txt_codigo_de_barra.Clear()
        txt_description_producto.Clear()
        rb_por_libra.Checked = False
        rb_por_unidad.Checked = False
        txt_precio_de_compra.Clear()
        txt_precio_de_venta.Clear()
        txt_precio_mayoreo.Clear()
        txt_cantidad_por_mayoreo_a_vender.Clear()
        txt_cantidad_producto.Clear()
        txt_punto_DE_reorden.Clear()
        check_no_aplica_fecha.Checked = False
        txtfecha_DE_vencimeinto.Value = Date.Now
        cbo_categoria.Text = "ABARROTES"
        txt_descuento.Clear()
        txt_precio_con_descuento.Clear()
        chb_descuento_activo.Checked = False
        chb_itbis.Checked = False
        CHB_DESCUENTO_POR_MONTO.Checked = False
        txt_precio_con_descuento.Enabled = False
        txt_descuento.Enabled = True
        txt_precio_de_venta.Enabled = True
    End Sub

    Private Sub btn_guardar_productos_Click(sender As Object, e As EventArgs) Handles btn_guardar_productos.Click
        Dim no_aplica_venciento As String = ""
        Dim se_vende_por As String = ""
        Dim ITBIS As Decimal
        Dim descuento_activo As String = ""

        Dim cadena2 As String = txt_precio_de_venta.Text
        txt_precio_de_venta.Text = cadena2.Replace(".", ",")

        Dim cadena As String = txt_precio_de_compra.Text
        txt_precio_de_compra.Text = cadena.Replace(".", ",")

        Dim cadena4 As String = txt_precio_con_descuento.Text
        txt_precio_con_descuento.Text = cadena4.Replace(".", ",")

        Dim cadena6 As String = txt_cantidad_por_mayoreo_a_vender.Text
        txt_cantidad_por_mayoreo_a_vender.Text = cadena6.Replace(".", ",")

        Dim cadena3 As String = txt_cantidad_producto.Text
        txt_cantidad_producto.Text = cadena3.Replace(".", ",")

        Dim cadena5 As String = txt_precio_mayoreo.Text
        txt_precio_mayoreo.Text = cadena5.Replace(".", ",")



        If chb_descuento_activo.Checked Then
            descuento_activo = "ACTIVADO"
        Else
            descuento_activo = "DESACTIVADO"
        End If

        If chb_itbis.Checked Then
            ITBIS = Val(txt_precio_de_venta.Text) / 100 * 18
        Else
            ITBIS = Val(0)
        End If

        If txt_precio_con_descuento.Text.Trim <> String.Empty And txt_codigo_de_barra.Text.Trim <> String.Empty And txt_description_producto.Text.Trim <> String.Empty And rb_por_libra.Checked Or rb_por_unidad.Checked And txt_precio_de_compra.Text.Trim <> String.Empty And txt_precio_de_venta.Text.Trim <> String.Empty And txt_cantidad_producto.Text.Trim <> String.Empty And txt_punto_DE_reorden.Text.Trim <> String.Empty And cbo_categoria.Text.Trim <> String.Empty Then
            Me.Cursor = Cursors.WaitCursor
            dt = class_producto.verificar_si_existe_codigo_de_barra(txt_codigo_de_barra.Text)
            If dt.Rows.Count > 0 Then
                Cursor = Cursors.Default
                MessageBox.Show("Codigo de barra existente", "Error de codigo de barra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If check_no_aplica_fecha.Checked Then
                    no_aplica_venciento = "No aplica"
                    If rb_por_libra.Checked Then
                        se_vende_por = "A granel/Libra/klg"
                    ElseIf rb_por_unidad.Checked Then
                        se_vende_por = "Por Unidad/Pieza"
                    End If

                    If IsNumeric(txt_precio_de_compra.Text) And IsNumeric(txt_precio_con_descuento.Text) And IsNumeric(txt_precio_de_venta.Text) And IsNumeric(txt_cantidad_producto.Text) And IsNumeric(txt_punto_DE_reorden.Text) Then

                        If txt_precio_mayoreo.Text.Trim <> String.Empty And txt_cantidad_por_mayoreo_a_vender.Text.Trim <> String.Empty Then
                            If IsNumeric(txt_precio_mayoreo.Text) And IsNumeric(txt_cantidad_por_mayoreo_a_vender.Text) Then


                                Dim ms As New IO.MemoryStream
                                If Not pciture_producto.Image Is Nothing Then
                                    pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                Else
                                    pciture_producto.Image = My.Resources.SIN_IMAGEN
                                    pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                End If
                                Dim ganacias As Decimal
                                ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                Dim ganancia_al_por_mayot As Decimal
                                ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                With obj_producto
                                    .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                    .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                    .description = txt_description_producto.Text.ToUpper
                                    .se_vende_por = se_vende_por
                                    .precio_de_compra = Convert.ToDecimal(txt_precio_de_compra.Text)
                                    .precio_de_venta = Convert.ToDecimal(txt_precio_de_venta.Text)
                                    .precio_mayoreo = Convert.ToDecimal(txt_precio_mayoreo.Text)
                                    .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                    .categorias = cbo_categoria.Text.ToUpper
                                    .cantidad = Convert.ToDecimal(txt_cantidad_producto.Text)
                                    .fecha_de_vencieminto = no_aplica_venciento
                                    .gimagen = ms.GetBuffer
                                    .ganancias = ganacias
                                    .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                    .itbis = Convert.ToDecimal(ITBIS)
                                    .precio_con_descuento = Convert.ToDecimal(txt_precio_con_descuento.Text)
                                    .descuento_activo = descuento_activo
                                End With
                                class_producto.insertar_producto(obj_producto)
                                MessageBox.Show("Producto registrado con exito", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                limpiar()
                                mostrar_productos()
                                mostrar_productos_almacen()
                                home()

                                Cursor = Cursors.Default
                                chb_itbis.Checked = False
                                Me.Close()

                            Else
                                Cursor = Cursors.Default
                                MessageBox.Show("Valor numerico invalido", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)


                            End If

                        Else

                            Dim ms As New IO.MemoryStream
                            If Not pciture_producto.Image Is Nothing Then
                                pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                            Else
                                pciture_producto.Image = My.Resources.SIN_IMAGEN
                                pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                            End If
                            Dim ganacias As Decimal
                            ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                            Dim ganancia_al_por_mayot As Decimal
                            ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                            With obj_producto
                                .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                .description = txt_description_producto.Text.ToUpper
                                .se_vende_por = se_vende_por
                                .precio_de_compra = Convert.ToDecimal(txt_precio_de_compra.Text)
                                .precio_de_venta = Format(Convert.ToDecimal(txt_precio_de_venta.Text), "0.00")
                                .precio_mayoreo = Format(Convert.ToDecimal(txt_precio_mayoreo.Text), "0.00")
                                .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                .categorias = cbo_categoria.Text.ToUpper
                                .cantidad = Convert.ToDecimal(txt_cantidad_producto.Text)
                                .fecha_de_vencieminto = no_aplica_venciento
                                .gimagen = ms.GetBuffer
                                .ganancias = ganacias
                                .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                .itbis = Format(Convert.ToDecimal(ITBIS), "0.00")
                                .precio_con_descuento = Format(Convert.ToDecimal(txt_precio_con_descuento.Text), "0.00")
                                .descuento_activo = descuento_activo
                            End With
                            class_producto.insertar_producto(obj_producto)
                            MessageBox.Show("Producto registrado con exito", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Cursor = Cursors.Default
                            limpiar()
                            mostrar_productos()
                            mostrar_productos_almacen()
                            home()
                            chb_itbis.Checked = False
                            Me.Close()

                        End If
                    Else
                        Cursor = Cursors.Default
                        MessageBox.Show("Valor numerico invalido", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                Else
                    no_aplica_venciento = txtfecha_DE_vencimeinto.Text
                    If txtfecha_DE_vencimeinto.Value <= Date.Now Then
                        Cursor = Cursors.Default
                        MessageBox.Show("La fecha de venciemiento no puede ser igual o menor que la fecha actual", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If rb_por_libra.Checked Then
                            se_vende_por = "A granel/Libra/klg"
                        ElseIf rb_por_unidad.Checked Then
                            se_vende_por = "Por Unidad/Pieza"
                        End If



                        If IsNumeric(txt_precio_de_compra.Text) And IsNumeric(txt_precio_con_descuento.Text) And IsNumeric(txt_precio_de_venta.Text) And IsNumeric(txt_cantidad_producto.Text) And IsNumeric(txt_punto_DE_reorden.Text) Then

                            If txt_precio_mayoreo.Text.Trim <> String.Empty And txt_cantidad_por_mayoreo_a_vender.Text.Trim <> String.Empty Then
                                If IsNumeric(txt_precio_mayoreo.Text) And IsNumeric(txt_cantidad_por_mayoreo_a_vender.Text) Then


                                    Dim ms As New IO.MemoryStream
                                    If Not pciture_producto.Image Is Nothing Then
                                        pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                    Else
                                        pciture_producto.Image = My.Resources.SIN_IMAGEN
                                        pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                    End If
                                    Dim ganacias As Decimal
                                    ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                    Dim ganancia_al_por_mayot As Decimal
                                    ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                    With obj_producto
                                        .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                        .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                        .description = txt_description_producto.Text.ToUpper
                                        .se_vende_por = se_vende_por
                                        .precio_de_compra = Convert.ToDecimal(txt_precio_de_compra.Text)
                                        .precio_de_venta = Format(Convert.ToDecimal(txt_precio_de_venta.Text), "0.00")
                                        .precio_mayoreo = Format(Convert.ToDecimal(txt_precio_mayoreo.Text), "0.00")
                                        .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                        .categorias = cbo_categoria.Text.ToUpper
                                        .cantidad = Convert.ToDecimal(txt_cantidad_producto.Text)
                                        .fecha_de_vencieminto = no_aplica_venciento
                                        .gimagen = ms.GetBuffer
                                        .ganancias = ganacias
                                        .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                        .itbis = Format(Convert.ToDecimal(ITBIS), "0.00")
                                        .precio_con_descuento = Format(Convert.ToDecimal(txt_precio_con_descuento.Text), "0.00")
                                        .descuento_activo = descuento_activo
                                    End With
                                    class_producto.insertar_producto(obj_producto)
                                    MessageBox.Show("Producto registrado con exito", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    limpiar()
                                    mostrar_productos()
                                    mostrar_productos_almacen()
                                    home()
                                    Cursor = Cursors.Default
                                    chb_itbis.Checked = False
                                    Me.Close()

                                Else
                                    Cursor = Cursors.Default
                                    MessageBox.Show("Valor numerico invalido", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If

                            Else

                                Dim ms As New IO.MemoryStream
                                If Not pciture_producto.Image Is Nothing Then
                                    pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                Else
                                    pciture_producto.Image = My.Resources.SIN_IMAGEN
                                    pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                End If
                                Dim ganacias As Decimal
                                ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                Dim ganancia_al_por_mayot As Decimal
                                ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                With obj_producto
                                    .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                    .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                    .description = txt_description_producto.Text.ToUpper
                                    .se_vende_por = se_vende_por
                                    .precio_de_compra = Convert.ToDecimal(txt_precio_de_compra.Text)
                                    .precio_de_venta = Format(Convert.ToDecimal(txt_precio_de_venta.Text), "0.00")
                                    .precio_mayoreo = Format(Convert.ToDecimal(txt_precio_mayoreo.Text), "0.00")
                                    .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                    .categorias = cbo_categoria.Text.ToUpper
                                    .cantidad = Convert.ToDecimal(txt_cantidad_producto.Text)
                                    .fecha_de_vencieminto = no_aplica_venciento
                                    .gimagen = ms.GetBuffer
                                    .ganancias = ganacias
                                    .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                    .itbis = Format(Convert.ToDecimal(ITBIS), "0.00")
                                    .precio_con_descuento = Format(Convert.ToDecimal(txt_precio_con_descuento.Text), "0.00")
                                    .descuento_activo = descuento_activo
                                End With
                                class_producto.insertar_producto(obj_producto)
                                MessageBox.Show("Producto registrado con exito", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                mostrar_productos()
                                mostrar_productos_almacen()
                                Cursor = Cursors.Default
                                home()
                                chb_itbis.Checked = False
                                Me.Close()

                            End If
                        Else
                            Cursor = Cursors.Default
                            MessageBox.Show("Valor numerico invalido", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If



                    End If
                End If


            End If



        Else

            Cursor = Cursors.Default
            MessageBox.Show("Datos incompletos", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub btn_actualizar_datos_Click(sender As Object, e As EventArgs) Handles btn_actualizar_datos.Click
        Dim no_aplica_venciento As String = ""
        Dim se_vende_por As String = ""

        Dim cadena2 As String = txt_precio_de_venta.Text
        txt_precio_de_venta.Text = cadena2.Replace(".", ",")

        Dim cadena As String = txt_precio_de_compra.Text
        txt_precio_de_compra.Text = cadena.Replace(".", ",")

        Dim cadena4 As String = txt_precio_con_descuento.Text
        txt_precio_con_descuento.Text = cadena4.Replace(".", ",")

        Dim cadena6 As String = txt_cantidad_por_mayoreo_a_vender.Text
        txt_cantidad_por_mayoreo_a_vender.Text = cadena6.Replace(".", ",")

        Dim cadena3 As String = txt_cantidad_producto.Text
        txt_cantidad_producto.Text = cadena3.Replace(".", ",")

        Dim cadena5 As String = txt_precio_mayoreo.Text
        txt_precio_mayoreo.Text = cadena5.Replace(".", ",")

        Dim ITBIS As Decimal
        Dim descuento_activo As String = ""
        If chb_descuento_activo.Checked Then
            descuento_activo = "ACTIVADO"
        Else
            descuento_activo = "DESACTIVADO"
        End If

        If chb_itbis.Checked Then
            ITBIS = Val(txt_precio_de_venta.Text) / 100 * 18
        Else
            ITBIS = Val(0)
        End If

        If txt_precio_con_descuento.Text.Trim <> String.Empty And cbo_categoria.Text.Trim <> String.Empty And txt_codigo_de_barra.Text.Trim <> String.Empty And txt_description_producto.Text.Trim <> String.Empty And rb_por_libra.Checked Or rb_por_unidad.Checked And txt_precio_de_compra.Text.Trim <> String.Empty And txt_precio_de_venta.Text.Trim <> String.Empty And txt_cantidad_producto.Text.Trim <> String.Empty And txt_punto_DE_reorden.Text.Trim <> String.Empty Then
            Me.Cursor = Cursors.WaitCursor
            dt = class_producto.verificar_si_el_producto_tiene_codigo(txt_codigo_de_barra.Text, Val(lbl_id_producto.Text))
            If dt.Rows.Count > 0 Then

                If check_no_aplica_fecha.Checked Then
                    no_aplica_venciento = "No aplica"
                    If rb_por_libra.Checked Then
                        se_vende_por = "A granel/Libra/klg"
                    ElseIf rb_por_unidad.Checked Then
                        se_vende_por = "Por Unidad/Pieza"
                    End If

                    If IsNumeric(txt_precio_con_descuento.Text) And IsNumeric(txt_precio_de_compra.Text) And IsNumeric(txt_precio_de_venta.Text) And IsNumeric(txt_cantidad_producto.Text) And IsNumeric(txt_punto_DE_reorden.Text) Then

                        If txt_precio_mayoreo.Text.Trim <> String.Empty And txt_cantidad_por_mayoreo_a_vender.Text.Trim <> String.Empty Then
                            If IsNumeric(txt_precio_mayoreo.Text) And IsNumeric(txt_cantidad_por_mayoreo_a_vender.Text) Then


                                Dim ms As New IO.MemoryStream
                                If Not pciture_producto.Image Is Nothing Then
                                    pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                Else
                                    pciture_producto.Image = My.Resources.SIN_IMAGEN
                                    pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                End If
                                Dim ganacias As Decimal
                                ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                Dim ganancia_al_por_mayot As Decimal
                                ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                With obj_producto
                                    .id_producto = Val(lbl_id_producto.Text)
                                    .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                    .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                    .description = txt_description_producto.Text.ToUpper
                                    .se_vende_por = se_vende_por
                                    .precio_de_compra = Format(Convert.ToDecimal(txt_precio_de_compra.Text), "0.00")
                                    .precio_de_venta = Format(Convert.ToDecimal(txt_precio_de_venta.Text), "0.00")
                                    .precio_mayoreo = Format(Convert.ToDecimal(txt_precio_mayoreo.Text), "0.00")
                                    .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                    .categorias = cbo_categoria.Text.ToUpper
                                    .cantidad = Format(Convert.ToDecimal(txt_cantidad_producto.Text), "0.00")
                                    .fecha_de_vencieminto = no_aplica_venciento
                                    .gimagen = ms.GetBuffer
                                    .ganancias = ganacias
                                    .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                    .itbis = Format(Convert.ToDecimal(ITBIS), "0.00")
                                    .precio_con_descuento = Format(Convert.ToDecimal(txt_precio_con_descuento.Text), "0.00")
                                    .descuento_activo = descuento_activo
                                End With
                                enviar_correo()
                                class_producto.editar_producto(obj_producto)
                                MessageBox.Show("Producto actualizado con exito", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                limpiar()
                                mostrar_productos()
                                mostrar_productos_almacen()
                                home()
                                Cursor = Cursors.Default
                                Me.Close()

                            Else
                                Cursor = Cursors.Default
                                MessageBox.Show("Valor numerico invalido", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            End If

                        Else

                            Dim ms As New IO.MemoryStream
                            If Not pciture_producto.Image Is Nothing Then
                                pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                            Else
                                pciture_producto.Image = My.Resources.SIN_IMAGEN
                                pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                            End If
                            Dim ganacias As Decimal
                            ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                            Dim ganancia_al_por_mayot As Decimal
                            ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                            With obj_producto
                                .id_producto = Val(lbl_id_producto.Text)
                                .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                .description = txt_description_producto.Text.ToUpper
                                .se_vende_por = se_vende_por
                                .precio_de_compra = Format(Convert.ToDecimal(txt_precio_de_compra.Text), "0.00")
                                .precio_de_venta = Format(Convert.ToDecimal(txt_precio_de_venta.Text), "0.00")
                                .precio_mayoreo = Format(Convert.ToDecimal(txt_precio_mayoreo.Text), "0.00")
                                .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                .categorias = cbo_categoria.Text.ToUpper
                                .cantidad = Format(Convert.ToDecimal(txt_cantidad_producto.Text), "0.00")
                                .fecha_de_vencieminto = no_aplica_venciento
                                .gimagen = ms.GetBuffer
                                .ganancias = ganacias
                                .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                .itbis = Format(Convert.ToDecimal(ITBIS), "0.00")
                                .precio_con_descuento = Format(Convert.ToDecimal(txt_precio_con_descuento.Text), "0.00")
                                .descuento_activo = descuento_activo
                            End With
                            enviar_correo()
                            class_producto.editar_producto(obj_producto)
                            MessageBox.Show("Producto actualizado con exito", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            limpiar()
                            mostrar_productos()

                            mostrar_productos_almacen()
                            home()
                            Cursor = Cursors.Default
                            Me.Close()

                        End If
                    Else
                        Cursor = Cursors.Default
                        MessageBox.Show("Valor numerico invalido", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                Else
                    no_aplica_venciento = txtfecha_DE_vencimeinto.Text
                    If txtfecha_DE_vencimeinto.Value <= Date.Now Then
                        Cursor = Cursors.Default
                        MessageBox.Show("La fecha de venciemiento no puede ser igual o menor que la fecha actual", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If rb_por_libra.Checked Then
                            se_vende_por = "A granel/Libra/klg"
                        ElseIf rb_por_unidad.Checked Then
                            se_vende_por = "Por Unidad/Pieza"
                        End If



                        If IsNumeric(txt_precio_con_descuento.Text) And IsNumeric(txt_precio_de_compra.Text) And IsNumeric(txt_precio_de_venta.Text) And IsNumeric(txt_cantidad_producto.Text) And IsNumeric(txt_punto_DE_reorden.Text) Then

                            If txt_precio_mayoreo.Text.Trim <> String.Empty And txt_cantidad_por_mayoreo_a_vender.Text.Trim <> String.Empty Then
                                If IsNumeric(txt_precio_mayoreo.Text) And IsNumeric(txt_cantidad_por_mayoreo_a_vender.Text) Then


                                    Dim ms As New IO.MemoryStream
                                    If Not pciture_producto.Image Is Nothing Then
                                        pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                    Else
                                        pciture_producto.Image = My.Resources.SIN_IMAGEN
                                        pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                    End If
                                    Dim ganacias As Decimal
                                    ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                    Dim ganancia_al_por_mayot As Decimal
                                    ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                    With obj_producto
                                        .id_producto = Val(lbl_id_producto.Text)
                                        .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                        .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                        .description = txt_description_producto.Text.ToUpper
                                        .se_vende_por = se_vende_por
                                        .precio_de_compra = Format(Convert.ToDecimal(txt_precio_de_compra.Text), "0.00")
                                        .precio_de_venta = Format(Convert.ToDecimal(txt_precio_de_venta.Text), "0.00")
                                        .precio_mayoreo = Format(Convert.ToDecimal(txt_precio_mayoreo.Text), "0.00")
                                        .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                        .categorias = cbo_categoria.Text.ToUpper
                                        .cantidad = Format(Convert.ToDecimal(txt_cantidad_producto.Text), "0.00")
                                        .fecha_de_vencieminto = no_aplica_venciento
                                        .gimagen = ms.GetBuffer
                                        .ganancias = ganacias
                                        .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                        .itbis = Format(Convert.ToDecimal(ITBIS), "0.00")
                                        .precio_con_descuento = Format(Convert.ToDecimal(txt_precio_con_descuento.Text), "0.00")
                                        .descuento_activo = descuento_activo
                                    End With
                                    enviar_correo()
                                    class_producto.editar_producto(obj_producto)
                                    MessageBox.Show("Producto actualizado con exito", "actualizando producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    limpiar()

                                    mostrar_productos()
                                    mostrar_productos_almacen()
                                    home()
                                    Cursor = Cursors.Default
                                    Me.Close()

                                Else
                                    Cursor = Cursors.Default
                                    MessageBox.Show("Valor numerico invalido", "Actualizando producto", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                End If

                            Else

                                Dim ms As New IO.MemoryStream
                                If Not pciture_producto.Image Is Nothing Then
                                    pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                Else
                                    pciture_producto.Image = My.Resources.SIN_IMAGEN
                                    pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                End If
                                Dim ganacias As Decimal
                                ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                Dim ganancia_al_por_mayot As Decimal
                                ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                With obj_producto
                                    .id_producto = Val(lbl_id_producto.Text)
                                    .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                    .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                    .description = txt_description_producto.Text.ToUpper
                                    .se_vende_por = se_vende_por
                                    .precio_de_compra = Format(Convert.ToDecimal(txt_precio_de_compra.Text), "0.00")
                                    .precio_de_venta = Format(Convert.ToDecimal(txt_precio_de_venta.Text), "0.00")
                                    .precio_mayoreo = Format(Convert.ToDecimal(txt_precio_mayoreo.Text), "0.00")
                                    .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                    .categorias = cbo_categoria.Text.ToUpper
                                    .cantidad = Format(Convert.ToDecimal(txt_cantidad_producto.Text), "0.00")
                                    .fecha_de_vencieminto = no_aplica_venciento
                                    .gimagen = ms.GetBuffer
                                    .ganancias = ganacias
                                    .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                    .itbis = Format(Convert.ToDecimal(ITBIS), "0.00")
                                    .descuento_activo = descuento_activo
                                    .precio_con_descuento = Format(Convert.ToDecimal(txt_precio_con_descuento.Text), "0.00")
                                End With
                                enviar_correo()
                                class_producto.editar_producto(obj_producto)
                                MessageBox.Show("Producto actualizado con exito", "Actualizando producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                limpiar()
                                mostrar_productos()

                                mostrar_productos_almacen()
                                home()
                                Cursor = Cursors.Default
                                Me.Close()

                            End If
                        Else
                            Cursor = Cursors.Default
                            MessageBox.Show("Valor numerico invalido", "Actualizando producto", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If



                    End If
                End If

            Else
                dt = class_producto.verificar_si_existe_codigo_de_barra(txt_codigo_de_barra.Text)
                If dt.Rows.Count > 0 Then
                    Cursor = Cursors.Default
                    MessageBox.Show("Codigo de barra existente", "ERROR DE CODIGO DE BARRA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    If check_no_aplica_fecha.Checked Then
                        no_aplica_venciento = "No aplica"
                        If rb_por_libra.Checked Then
                            se_vende_por = "A granel/Libra/klg"
                        ElseIf rb_por_unidad.Checked Then
                            se_vende_por = "Por Unidad/Pieza"
                        End If

                        If IsNumeric(txt_precio_con_descuento.Text) And IsNumeric(txt_precio_de_compra.Text) And IsNumeric(txt_precio_de_venta.Text) And IsNumeric(txt_cantidad_producto.Text) And IsNumeric(txt_punto_DE_reorden.Text) Then

                            If txt_precio_mayoreo.Text.Trim <> String.Empty And txt_cantidad_por_mayoreo_a_vender.Text.Trim <> String.Empty Then
                                If IsNumeric(txt_precio_mayoreo.Text) And IsNumeric(txt_cantidad_por_mayoreo_a_vender.Text) Then


                                    Dim ms As New IO.MemoryStream
                                    If Not pciture_producto.Image Is Nothing Then
                                        pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                    Else
                                        pciture_producto.Image = My.Resources.SIN_IMAGEN
                                        pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                    End If
                                    Dim ganacias As Decimal
                                    ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                    Dim ganancia_al_por_mayot As Decimal
                                    ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                    With obj_producto
                                        .id_producto = Val(lbl_id_producto.Text)
                                        .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                        .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                        .description = txt_description_producto.Text.ToUpper
                                        .se_vende_por = se_vende_por
                                        .precio_de_compra = Format(Convert.ToDecimal(txt_precio_de_compra.Text), "0.00")
                                        .precio_de_venta = Format(Convert.ToDecimal(txt_precio_de_venta.Text), "0.00")
                                        .precio_mayoreo = Format(Convert.ToDecimal(txt_precio_mayoreo.Text), "0.00")
                                        .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                        .categorias = cbo_categoria.Text.ToUpper
                                        .cantidad = Format(Convert.ToDecimal(txt_cantidad_producto.Text), "0.00")
                                        .fecha_de_vencieminto = no_aplica_venciento
                                        .gimagen = ms.GetBuffer
                                        .ganancias = ganacias
                                        .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                        .itbis = Format(Convert.ToDecimal(ITBIS), "0.00")
                                        .precio_con_descuento = Format(Convert.ToDecimal(txt_precio_con_descuento.Text), "0.00")
                                        .descuento_activo = descuento_activo
                                    End With
                                    enviar_correo()
                                    class_producto.editar_producto(obj_producto)
                                    MessageBox.Show("Producto actualizado con exito", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    limpiar()

                                    mostrar_productos()
                                    mostrar_productos_almacen()
                                    home()
                                    Cursor = Cursors.Default
                                    Me.Close()

                                Else
                                    Cursor = Cursors.Default
                                    MessageBox.Show("Valor numerico invalido", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                End If

                            Else

                                Dim ms As New IO.MemoryStream
                                If Not pciture_producto.Image Is Nothing Then
                                    pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                Else
                                    pciture_producto.Image = My.Resources.SIN_IMAGEN
                                    pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                End If
                                Dim ganacias As Decimal
                                ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                Dim ganancia_al_por_mayot As Decimal
                                ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                With obj_producto
                                    .id_producto = Val(lbl_id_producto.Text)
                                    .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                    .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                    .description = txt_description_producto.Text.ToUpper
                                    .se_vende_por = se_vende_por
                                    .precio_de_compra = Format(Convert.ToDecimal(txt_precio_de_compra.Text), "0.00")
                                    .precio_de_venta = Format(Convert.ToDecimal(txt_precio_de_venta.Text), "0.00")
                                    .precio_mayoreo = Format(Convert.ToDecimal(txt_precio_mayoreo.Text), "0.00")
                                    .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                    .categorias = cbo_categoria.Text.ToUpper
                                    .cantidad = Format(Convert.ToDecimal(txt_cantidad_producto.Text), "0.00")
                                    .fecha_de_vencieminto = no_aplica_venciento
                                    .gimagen = ms.GetBuffer
                                    .ganancias = ganacias
                                    .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                    .itbis = Format(Convert.ToDecimal(ITBIS), "0.00")
                                    .precio_con_descuento = Format(Convert.ToDecimal(txt_precio_con_descuento.Text), "0.00")
                                    .descuento_activo = descuento_activo
                                End With
                                enviar_correo()
                                class_producto.editar_producto(obj_producto)
                                MessageBox.Show("Producto actualizado con exito", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                limpiar()
                                mostrar_productos()

                                mostrar_productos_almacen()
                                home()
                                Cursor = Cursors.Default
                                Me.Close()

                            End If
                        Else
                            Cursor = Cursors.Default
                            MessageBox.Show("Valor numerico invalido", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If

                    Else
                        no_aplica_venciento = txtfecha_DE_vencimeinto.Text
                        If txtfecha_DE_vencimeinto.Value <= Date.Now Then
                            MessageBox.Show("La fecha de venciemiento no puede ser igual o menor que la fecha actual", "Registro de productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If rb_por_libra.Checked Then
                                se_vende_por = "A granel/Libra/klg"
                            ElseIf rb_por_unidad.Checked Then
                                se_vende_por = "Por Unidad/Pieza"
                            End If



                            If IsNumeric(txt_precio_con_descuento.Text) And IsNumeric(txt_precio_de_compra.Text) And IsNumeric(txt_precio_de_venta.Text) And IsNumeric(txt_cantidad_producto.Text) And IsNumeric(txt_punto_DE_reorden.Text) Then

                                If txt_precio_mayoreo.Text.Trim <> String.Empty And txt_cantidad_por_mayoreo_a_vender.Text.Trim <> String.Empty Then
                                    If IsNumeric(txt_precio_mayoreo.Text) And IsNumeric(txt_cantidad_por_mayoreo_a_vender.Text) Then


                                        Dim ms As New IO.MemoryStream
                                        If Not pciture_producto.Image Is Nothing Then
                                            pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                        Else
                                            pciture_producto.Image = My.Resources.SIN_IMAGEN
                                            pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                        End If
                                        Dim ganacias As Decimal
                                        ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                        Dim ganancia_al_por_mayot As Decimal
                                        ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                        With obj_producto
                                            .id_producto = Val(lbl_id_producto.Text)
                                            .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                            .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                            .description = txt_description_producto.Text.ToUpper
                                            .se_vende_por = se_vende_por
                                            .precio_de_compra = Format(Convert.ToDecimal(txt_precio_de_compra.Text), "0.00")
                                            .precio_de_venta = Format(Convert.ToDecimal(txt_precio_de_venta.Text), "0.00")
                                            .precio_mayoreo = Format(Convert.ToDecimal(txt_precio_mayoreo.Text), "0.00")
                                            .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                            .categorias = cbo_categoria.Text.ToUpper
                                            .cantidad = Format(Convert.ToDecimal(txt_cantidad_producto.Text), "0.00")
                                            .fecha_de_vencieminto = no_aplica_venciento
                                            .gimagen = ms.GetBuffer
                                            .ganancias = ganacias
                                            .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                            .itbis = Format(Convert.ToDecimal(ITBIS), "0.00")
                                            .precio_con_descuento = Format(Convert.ToDecimal(txt_precio_con_descuento.Text), "0.00")
                                            .descuento_activo = descuento_activo
                                        End With
                                        enviar_correo()
                                        class_producto.editar_producto(obj_producto)
                                        MessageBox.Show("Producto actualizado con exito", "actualizando producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        limpiar()
                                        mostrar_productos()

                                        mostrar_productos_almacen()
                                        home()
                                        Cursor = Cursors.Default
                                        Me.Close()

                                    Else
                                        Cursor = Cursors.Default
                                        MessageBox.Show("Valor numerico invalido", "Actualizando producto", MessageBoxButtons.OK, MessageBoxIcon.Error)


                                    End If

                                Else

                                    Dim ms As New IO.MemoryStream
                                    If Not pciture_producto.Image Is Nothing Then
                                        pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                    Else
                                        pciture_producto.Image = My.Resources.SIN_IMAGEN
                                        pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

                                    End If
                                    Dim ganacias As Decimal
                                    ganacias = Val(txt_precio_de_venta.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                    Dim ganancia_al_por_mayot As Decimal
                                    ganancia_al_por_mayot = Val(txt_precio_mayoreo.Text.Trim) - Val(txt_precio_de_compra.Text.Trim)
                                    With obj_producto
                                        .id_producto = Val(lbl_id_producto.Text)
                                        .ganancia_por_precio_al_pormayor = ganancia_al_por_mayot
                                        .codigo_de_barra = txt_codigo_de_barra.Text.Trim
                                        .description = txt_description_producto.Text.ToUpper
                                        .se_vende_por = se_vende_por
                                        .precio_de_compra = Format(Convert.ToDecimal(txt_precio_de_compra.Text), "0.00")
                                        .precio_de_venta = Format(Convert.ToDecimal(txt_precio_de_venta.Text), "0.00")
                                        .precio_mayoreo = Format(Convert.ToDecimal(txt_precio_mayoreo.Text), "0.00")
                                        .cantida_por_mayoreo = Convert.ToDecimal(txt_cantidad_por_mayoreo_a_vender.Text)
                                        .categorias = cbo_categoria.Text.ToUpper
                                        .cantidad = Format(Convert.ToDecimal(txt_cantidad_producto.Text), "0.00")
                                        .fecha_de_vencieminto = no_aplica_venciento
                                        .gimagen = ms.GetBuffer
                                        .ganancias = ganacias
                                        .punto_de_reorden = Val(txt_punto_DE_reorden.Text)
                                        .itbis = Format(Convert.ToDecimal(ITBIS), "0.00")
                                        .descuento_activo = descuento_activo
                                        .precio_con_descuento = Format(Convert.ToDecimal(txt_precio_con_descuento.Text), "0.00")
                                    End With
                                    enviar_correo()
                                    class_producto.editar_producto(obj_producto)
                                    MessageBox.Show("Producto actualizado con exito", "Actualizando producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    limpiar()
                                    mostrar_productos()
                                    mostrar_productos_almacen()

                                    home()
                                    Cursor = Cursors.Default
                                    Me.Close()

                                End If
                            Else
                                Cursor = Cursors.Default
                                MessageBox.Show("Valor numerico invalido", "Actualizando producto", MessageBoxButtons.OK, MessageBoxIcon.Error)


                            End If



                        End If
                    End If
                End If

            End If





        Else
            Cursor = Cursors.Default

            MessageBox.Show("Datos incompletos", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click

        limpiar()
        Me.Close()
    End Sub

    Private Sub check_no_aplica_fecha_CheckedChanged(sender As Object, e As EventArgs) Handles check_no_aplica_fecha.CheckedChanged
        If check_no_aplica_fecha.Checked Then
            txtfecha_DE_vencimeinto.Enabled = False
        Else
            txtfecha_DE_vencimeinto.Enabled = True
        End If
    End Sub

    Public Sub gargar_gategorias()
        Try
            dt = class_producto.mostrar_categoria


            If dt.Rows.Count > 0 Then
                cbo_categoria.Items.Clear()
                cbo_categoria.Text = dt.Rows(0).Item("Categoria").ToString
                For i = 0 To dt.Rows.Count - 1 Step 1
                    cbo_categoria.Items.Add(dt.Rows(i).Item("Categoria").ToString)
                Next

                cbo_categoria.Text = dt.Rows(dt.Rows.Count - 1).Item("Categoria").ToString


            Else
                cbo_categoria.Items.Clear()
                cbo_categoria.Text = "ABARROTE"
                cbo_categoria.Items.Add("ABARROTE")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_registro_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_categoria.DropDownStyle = 2
        gargar_gategorias()
        txt_codigo_de_barra.Select()
        'cbo_categoria.Text = "ABARROTES"
    End Sub

    Private Sub txt_codigo_de_barra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo_de_barra.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_description_producto.Select()

        End If
    End Sub

    Private Sub txt_description_producto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_description_producto.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_precio_de_compra.Select()

        End If
    End Sub

    Private Sub txt_precio_de_compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio_de_compra.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_precio_de_venta.Select()

        End If
    End Sub

    Private Sub txt_precio_de_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio_de_venta.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_precio_mayoreo.Select()

        End If
    End Sub

    Private Sub txt_precio_mayoreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio_mayoreo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_cantidad_por_mayoreo_a_vender.Select()

        End If
    End Sub

    Private Sub txt_cantidad_por_mayoreo_a_vender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_por_mayoreo_a_vender.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cbo_categoria.Select()

        End If
    End Sub

    Private Sub cbo_categoria_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_cantidad_producto.Select()

        End If
    End Sub

    Private Sub txt_cantidad_producto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_producto.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_punto_DE_reorden.Select()

        End If
    End Sub

    Private Sub txt_descuento_TextChanged(sender As Object, e As EventArgs) Handles txt_descuento.TextChanged
        If txt_precio_de_venta.Text.Trim <> String.Empty Then
            Dim precio_con_descuento As Decimal
            Dim itbis As Decimal
            Dim re As Decimal
            Dim cadena5 As String = txt_precio_de_venta.Text
            txt_precio_de_venta.Text = cadena5.Replace(".", ",")

            Dim precio_de_venta As Decimal = Convert.ToDecimal(txt_precio_de_venta.Text)
            If chb_itbis.Checked = True Then


                precio_con_descuento = precio_de_venta / 100 * Val(txt_descuento.Text)

                txt_precio_con_descuento.Text = precio_de_venta - precio_con_descuento
            Else
                precio_con_descuento = precio_de_venta / 100 * Val(txt_descuento.Text)
                txt_precio_con_descuento.Text = precio_de_venta - precio_con_descuento
            End If

        End If


    End Sub

    Private Sub chb_itbis_CheckedChanged(sender As Object, e As EventArgs) Handles chb_itbis.CheckedChanged
        Dim itbis, precio As Decimal

        If txt_precio_de_venta.Text.Trim <> String.Empty Then
            If IsNumeric(txt_precio_de_venta.Text) Then


                If chb_itbis.Checked Then

                    itbis = Val(txt_precio_de_venta.Text) / 100 * 18
                    precio = Val(txt_precio_de_venta.Text)
                    precio = precio + itbis

                    txt_precio_de_venta.Text = precio
                    txt_precio_de_venta.Enabled = False

                Else



                    txt_precio_de_venta.Clear()
                    txt_precio_de_venta.Enabled = True
                    txt_precio_de_venta.Select()


                End If

            End If


        End If




    End Sub

    Private Sub CHB_DESCUENTO_POR_MONTO_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_DESCUENTO_POR_MONTO.CheckedChanged
        If CHB_DESCUENTO_POR_MONTO.Checked Then
            txt_descuento.Enabled = False
            txt_precio_con_descuento.Enabled = True
        Else
            txt_descuento.Enabled = True
            txt_precio_con_descuento.Enabled = False
        End If
    End Sub


End Class