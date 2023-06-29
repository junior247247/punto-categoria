Imports System.Data.SqlClient
Public Class class_inventario
    Inherits conexion

    Protected cmd As New SqlCommand





    Function sumarTarjeta(id As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumarTarjeta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
            cmd.Parameters.AddWithValue("@cajeroId", id)
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


    Function sumar_mantenimiento_por_30_dias() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumar_mantenimiento_por_30_dias")
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


    Function sumar_mantenimiento_por_7_dias() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumar_mantenimiento_por_7_dias")
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

    Function sumar_liquidos_por_30_dias() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumar_liquidos_por_30_dias")
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


    Function sumar_liquidos_por_semana() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumar_liquidos_por_semana")
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


    Function anular_ticketCredito(ByVal idCaja As Integer, ByVal importe As Decimal, ByVal ganancia As Decimal) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("anular_ticketCredito")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_caja", idCaja)
            cmd.Parameters.AddWithValue("@importe", importe)
            cmd.Parameters.AddWithValue("@ganancia", ganancia)
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

    Function anular_ticket(ByVal id_venta As Integer, ByVal importe As Decimal, ByVal ganancia As Decimal) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("anular_ticket")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_venta", id_venta)
            cmd.Parameters.AddWithValue("@importe", importe)
            cmd.Parameters.AddWithValue("@ganancia", ganancia)
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
    Function buscar_ticket(ByVal id_usuario As Integer, ByVal id_venta As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_ticket")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_cajero", id_usuario)
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
    Function mostrar_listado_ingreso_del_dia(ByVal id_usuario As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_listado_ingreso_del_dia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_cajero", id_usuario)
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
    Function devoluciones(ByVal id_usuario As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("devoluciones")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_cajero", id_usuario)
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
    Function ganancias_del_dia(ByVal id_usuario As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("ganancias_del_dia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_cajero", id_usuario)
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

    Function buscar_retiros(ByVal fecha1 As Date, ByVal fecha2 As Date) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_retiros")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
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
    Function mostrar_retiros() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_retiros")
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

    Function insertar_retiro(ByVal obj_cobro As ce_cobro) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_retiro")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@motivo", obj_cobro.motivo)
            cmd.Parameters.AddWithValue("@retiro", obj_cobro.retiro)
            cmd.Parameters.AddWithValue("@fecha", obj_cobro.fecha)
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

    Function retirar_dinero(ByVal obj_cobro As ce_cobro) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("retirar_dinero")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_ususario", obj_cobro.id_usuario)
            cmd.Parameters.AddWithValue("@id_dinero", obj_cobro.id_dinero_en_caja)
            cmd.Parameters.AddWithValue("@retiro", obj_cobro.retiro)

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

    Function ventas_del_mes() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("ventas_del_mes")
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

    Function ventas_de_la_semana() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("ventas_de_la_semana")
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

    Function ganancias_del_mes() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("ganancias_del_mes")
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



    Function ganancias_de_la_semana() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("ganancias_de_la_semana")
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

    Function compras_del_mes() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("compras_del_mes")
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

    Function compras_de_la_semana() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("compras_de_la_semana")
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

    Function dinero_de_ventas_del_dia(ByVal id_cajero As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("dinero_de_ventas_del_dia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_cajero", id_cajero)
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
    Function mostrar_dinero_en_caja(ByVal id_usuario As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_dinero_en_caja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usaurio", id_usuario)
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
    Function sumar_ventas_del_mes() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumar_ventas_del_mes")
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
