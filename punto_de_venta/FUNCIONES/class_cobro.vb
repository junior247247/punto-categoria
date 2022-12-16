Imports System.Data.SqlClient
Public Class class_cobro
    Inherits conexion
    Protected cmd As New SqlCommand




    Function actualizar_fondo(ByVal id_usuario As Integer, ByVal fondo As Decimal) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actualizar_fondo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
            cmd.Parameters.AddWithValue("@fondo", fondo)
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

    Function verificar_si_hay_fondo(ByVal id_usuario As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificar_si_hay_fondo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
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
    Function insertar_fondo(ByVal id_usuario As Integer, ByVal fondo As Decimal) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_fondo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
            cmd.Parameters.AddWithValue("@fondo", fondo)
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
    Function actualizar_importe_reporte(ByVal obj_cobro As ce_venta_final) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actualizar_importe_reporte")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", obj_cobro.id_venta)
            cmd.Parameters.AddWithValue("@pendiente", obj_cobro.pendiente)
            cmd.Parameters.AddWithValue("@pagado", obj_cobro.pagado)
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

    Function actualizar_importe_venta_final(ByVal obj_cobro As ce_venta_final) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actualizar_importe_venta_final")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", obj_cobro.id_venta)
            cmd.Parameters.AddWithValue("@importe", obj_cobro.importe)
            cmd.Parameters.AddWithValue("@pendiente", obj_cobro.pendiente)
            cmd.Parameters.AddWithValue("@pagado", obj_cobro.pagado)
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
    Function eliminar_comprobante_usado(ByVal comprobante As String) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_comprobante_usado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@combrobante", comprobante)
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

    Function actualizar_dinero_en_caja(ByVal obj_cobro As ce_cobro) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actualizar_dinero_en_caja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", obj_cobro.id_usuario)
            cmd.Parameters.AddWithValue("@id_dinero", obj_cobro.id_dinero_en_caja)
            cmd.Parameters.AddWithValue("@dinero", obj_cobro.dinero_en_cja)
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

    Function verificar_si_hay_registro(ByVal id_usuario As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificar_si_hay_registro")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
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

    Function insertar_dinero_en_caja(ByVal obj_cobro As ce_cobro) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_dinero_en_caja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", obj_cobro.id_usuario)
            cmd.Parameters.AddWithValue("@dinero", obj_cobro.dinero_en_cja)

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


    Function insertar_total(ByVal obj_cobro As ce_cobro) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_total")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", obj_cobro.id_venta)
            cmd.Parameters.AddWithValue("@sub_total", obj_cobro.sub_total)
            cmd.Parameters.AddWithValue("@total", obj_cobro.total)
            cmd.Parameters.AddWithValue("@cliente", obj_cobro.cliente)
            cmd.Parameters.AddWithValue("@descuento", obj_cobro.descuento)
            cmd.Parameters.AddWithValue("@descuento_por_siento", obj_cobro.porciento_descuento)
            cmd.Parameters.AddWithValue("@recibido", obj_cobro.recibido)
            cmd.Parameters.AddWithValue("@cambio", obj_cobro.cambio)
            cmd.Parameters.AddWithValue("@total_de_articulos", obj_cobro.total_de_articulos)
            cmd.Parameters.AddWithValue("@le_atendio", obj_cobro.le_atendio)
            cmd.Parameters.AddWithValue("@fecha", obj_cobro.fecha)
            cmd.Parameters.AddWithValue("@hora", obj_cobro.hora)
            cmd.Parameters.AddWithValue("@turno", obj_cobro.turno)
            cmd.Parameters.AddWithValue("@rnc_cliente", obj_cobro.rnc_cliente)
            cmd.Parameters.AddWithValue("@ncf", obj_cobro.ncf)
            cmd.Parameters.AddWithValue("@nombre_o_empresa", obj_cobro.nombre_o_empresa)
            cmd.Parameters.AddWithValue("@pendiente", obj_cobro.pendiente)
            cmd.Parameters.AddWithValue("@pagado", obj_cobro.pagado)
            cmd.Parameters.AddWithValue("@tipo", obj_cobro.tipo)
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

End Class
