Imports System.Data.SqlClient
Public Class class_cierre_de_caja
    Inherits conexion
    Protected cmd As New SqlCommand



    Public Function sumarVentasTotales() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumarVentasTotales")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
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

    Public Function sumarVentasDeldiaBar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumarVentasDeldiaBar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
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


    Public Function sumarVentasDeldiaGomera() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumarVentasDeldiaGomera")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
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

    Public Sub cerrarCajaDiaria()
        Try
            conectado()
            cmd = New SqlCommand("cerrarCajaDiaria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub

    Public Sub sacarFondos()
        Try
            conectado()
            cmd = New SqlCommand("sacarFondos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub

    Public Sub sacarDineroCaja()
        Try
            conectado()
            cmd = New SqlCommand("sacarDineroCaja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub

    Public Function selecionarUsuario(id As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("selecionarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idUser", id)
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

    Public Sub ponerEnCierreDetalles()
        Try
            conectado()
            cmd = New SqlCommand("ponerEnCierreDetalles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub

    Function sumarGomera(id As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumarGomera")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idUser", id)
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

    Function sumarBar(id As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumarBar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idUser", id)
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

    Function selecionar_hora_caja_abierta(ByVal id_usuario As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("selecionar_hora_caja_abierta")
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

    Function actualizar_al_cerrar_hora(ByVal id_usaurio As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actualizar_al_cerrar_hora")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", id_usaurio)
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

    Function sacar_los_fondos(ByVal id_usuario As Integer, ByVal fondo As Decimal) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("sacar_los_fondos")
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

    Function poner_en_cierre_retirados() As Boolean
        Try
            conectado()
            cmd = New SqlCommand("poner_en_cierre_retirados")
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

    Function SUMAR_RETIROS_DEL_DIA() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("SUMAR_RETIROS_DEL_DIA")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim DT As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(DT)
                Return DT
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


    Function listar_cierre_de_caja() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("listar_cierre_de_caja")
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

    Function reporte_cierre_de_caja(ByVal id_cierre As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("reporte_cierre_de_caja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_cierre", id_cierre)
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

    Function cerrar_turno_caja_diaria(ByVal id_usuario As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("cerrar_turno_caja_diaria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
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



    Function insertar_cierre_de_caja(ByVal obj_cierre_de_caja As ce_cierre_de_caja) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_cierre_de_caja")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@dinero_en_caja", obj_cierre_de_caja.dinero_en_caja)
            cmd.Parameters.AddWithValue("@devoluciones", obj_cierre_de_caja.devoluciones)
            cmd.Parameters.AddWithValue("@fecha", obj_cierre_de_caja.fecha)
            cmd.Parameters.AddWithValue("@usuario", obj_cierre_de_caja.usuario)
            cmd.Parameters.AddWithValue("@hora", obj_cierre_de_caja.hora)
            cmd.Parameters.AddWithValue("@turno", obj_cierre_de_caja.turno)
            cmd.Parameters.AddWithValue("@id_usuario", obj_cierre_de_caja.id_usuario)
            cmd.Parameters.AddWithValue("@retirados", obj_cierre_de_caja.retirado)
            cmd.Parameters.AddWithValue("@total_ventas_del_dia", obj_cierre_de_caja.total_en_ventas_del_dia)
            cmd.Parameters.AddWithValue("@valor_en_efectivo_de_la_caja", obj_cierre_de_caja.dinero_efectivo_en_caja)
            cmd.Parameters.AddWithValue("@total_retirados", obj_cierre_de_caja.total_retirador)
            cmd.Parameters.AddWithValue("@restante", obj_cierre_de_caja.restante)
            cmd.Parameters.AddWithValue("@totalBar", obj_cierre_de_caja.totalBar)
            cmd.Parameters.AddWithValue("@totalGomera", obj_cierre_de_caja.totalGomera)
            cmd.Parameters.AddWithValue("@tarjeta", obj_cierre_de_caja.tarjeta)

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
