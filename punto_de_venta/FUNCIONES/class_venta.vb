Imports System.Data.SqlClient
Public Class class_venta
    Inherits conexion
    Protected cmd As New SqlCommand





    Public Function sumarBarPorFecha(fecha1 As String, fecha2 As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumarBarPorFecha")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function




    Public Function sumarGomeraPorFecha(fecha1 As String, fecha2 As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumarGomeraPorFecha")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Function buscaVentasPorFecha(fecha1 As String, fecha2 As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscaVentasPorFecha")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Function mostraCaja(ByVal idVenta As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostraCaja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idVenta", idVenta)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Function verifiacar_si_lleva_rnc_con_credito(ByVal id_venta As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verifiacar_si_lleva_rnc_con_credito")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", id_venta)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Function verifiacar_si_lleva_rnc(ByVal id_venta As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verifiacar_si_lleva_rnc")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", id_venta)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Function poner_en_positivos_reporte_credito() As Boolean
        Try
            conectado()
            cmd = New SqlCommand("poner_en_positivos_reporte_credito")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Function poner_en_positivo_creditos() As Boolean
        Try
            conectado()
            cmd = New SqlCommand("poner_en_positivo_creditos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Function poner_en_credito() As Boolean
        Try
            conectado()
            cmd = New SqlCommand("poner_en_credito")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Function anular_ticket_a_credito_reporte(ByVal obj_venta_final As ce_venta_final) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("anular_ticket_a_credito_reporte")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", obj_venta_final.id_venta)
            cmd.Parameters.AddWithValue("@pendiente", obj_venta_final.pendiente)
            cmd.Parameters.AddWithValue("@pagado", obj_venta_final.pagado)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function


    Function anular_ticket_a_credito(ByVal obj_venta_final As ce_venta_final) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("anular_ticket_a_credito")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", obj_venta_final.id_venta)
            cmd.Parameters.AddWithValue("@importe", obj_venta_final.importe)
            cmd.Parameters.AddWithValue("@pendiente", obj_venta_final.pendiente)
            cmd.Parameters.AddWithValue("@pagado", obj_venta_final.pagado)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Function QUITAR_DE_CREDITO()
        Try
            conectado()
            cmd = New SqlCommand("QUITAR_DE_CREDITO")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Function BUSCAR_facturas_a_creditos(ByVal filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("BUSCAR_facturas_a_creditos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@FILTRO", filtro)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Function mostrar_facturas_a_creditos() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_facturas_a_creditos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Function numeros_de_comprobantes() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("numeros_de_comprobantes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try
    End Function

    Function monto_negativo_en_positivo() As Boolean
        Try
            conectado()
            cmd = New SqlCommand("monto_negativo_en_positivo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Function verificar_si_existe_producto(ByVal codigo_de_barra As String, ByVal descripcion As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificar_si_existe_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@codigo_de_barra", codigo_de_barra)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try

    End Function

    Function actualizar_monto_si_existe_el_articulo(ByVal obj_venta As ce_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actualizar_monto_si_existe_el_articulo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", obj_venta.id_venta)
            cmd.Parameters.AddWithValue("@id_producto", obj_venta.id_producto)
            cmd.Parameters.AddWithValue("@precio", obj_venta.precio)
            cmd.Parameters.AddWithValue("@importe", obj_venta.total)
            cmd.Parameters.AddWithValue("@cantidad", obj_venta.cantidad)
            cmd.Parameters.AddWithValue("@ganancia", obj_venta.gananci)
            cmd.Parameters.AddWithValue("@itbis", obj_venta.itbis)
            cmd.Parameters.AddWithValue("@descuento", obj_venta.descuento)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function


    Function verificar_si_existe_el_articulo(ByVal id_venta As Integer, ByVal id_producto As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificar_si_existe_el_articulo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", id_venta)
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try

    End Function

    Function buscar_ventas_final(ByVal filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_ventas_final")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn '
            cmd.Parameters.AddWithValue("@filtro", filtro)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Function actualizar_estado_articulos(ByVal obj_venta As ce_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actualizar_estado_articulos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", obj_venta.id_venta)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Function verificar_si_no_esta_vendido() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificar_si_no_esta_vendido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Function mostrar_venta_final() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_venta_final")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function



    Function eliminar_venta(ByVal id_venta As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", id_venta)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function


    Function insertar_venta_final(ByVal obj_venta As ce_venta_final) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_venta_final")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@cliente", obj_venta.cliente)
            cmd.Parameters.AddWithValue("@articulos", obj_venta.articulos)
            cmd.Parameters.AddWithValue("@importe", obj_venta.importe)
            cmd.Parameters.AddWithValue("@documento", obj_venta.documento)
            cmd.Parameters.AddWithValue("@descuento", obj_venta.descuento)
            cmd.Parameters.AddWithValue("@condicion", obj_venta.condicion)
            cmd.Parameters.AddWithValue("@fecha", obj_venta.fecha)
            cmd.Parameters.AddWithValue("@id_venta", obj_venta.id_venta)
            cmd.Parameters.AddWithValue("@pendiente", obj_venta.pendiente)
            cmd.Parameters.AddWithValue("@pagado", obj_venta.pagado)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function



    Function eliminar_todos_los_articulos(ByVal id_venta As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_todos_los_articulos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("id_venta", id_venta)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Function ver_cantidad(ByVal id_producto As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("ver_cantidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try

    End Function
    Function aumentar_stock(ByVal obj_prodcuto As ce_producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentar_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", obj_prodcuto.id_producto)
            cmd.Parameters.AddWithValue("@cantidad", obj_prodcuto.cantidad)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function







    Function disminuir_stock(ByVal obj_prodcuto As ce_producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("disminuir_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", obj_prodcuto.id_producto)
            cmd.Parameters.AddWithValue("@cantidad", obj_prodcuto.cantidad)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Function eliminar_articulo(ByVal obj_venta As ce_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_articulo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_detalle_de_venta", obj_venta.id_detalle_de_venta)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Function mostrar_articulos(ByVal obj_id_venta As ce_venta) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_articulos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", obj_id_venta.id_venta)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Function insertar_detalle_de_venta(ByVal obj_detalle_de_venta As ce_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle_de_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", obj_detalle_de_venta.id_venta)
            cmd.Parameters.AddWithValue("@cantidad", obj_detalle_de_venta.cantidad)
            cmd.Parameters.AddWithValue("@id_producto", obj_detalle_de_venta.id_producto)
            cmd.Parameters.AddWithValue("@itbis", obj_detalle_de_venta.itbis)
            cmd.Parameters.AddWithValue("@total", obj_detalle_de_venta.total)
            cmd.Parameters.AddWithValue("@precio", obj_detalle_de_venta.precio)
            cmd.Parameters.AddWithValue("@ganancia", obj_detalle_de_venta.gananci)
            cmd.Parameters.AddWithValue("@estado", obj_detalle_de_venta.estado)
            cmd.Parameters.AddWithValue("@descuento", obj_detalle_de_venta.descuento)
            cmd.Parameters.AddWithValue("@categoria", obj_detalle_de_venta.categoria)
            cmd.Parameters.AddWithValue("@idCajero", obj_detalle_de_venta.idCajero)
            cmd.Parameters.AddWithValue("@fecha", Today.Date)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Function id_de_venta() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("id_de_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Function insertar_venta(ByVal obj_vente As ce_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha", obj_vente.fecha)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Function buscar_productos_para_venta(ByVal filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_productos_para_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filtro", filtro)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Function mostrar_productos_para_venta() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_productos_para_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

End Class
