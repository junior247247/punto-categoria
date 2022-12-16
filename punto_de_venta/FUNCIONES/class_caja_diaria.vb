Imports System.Data.SqlClient
Public Class class_caja_diaria
    Inherits conexion
    Protected cmd As New SqlCommand



    Function insertar_caja_diaria(ByVal obj_caja_diaria As ce_caja_diaria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_caja_diaria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha", obj_caja_diaria.fecha)
            cmd.Parameters.AddWithValue("@hora", obj_caja_diaria.hora)
            cmd.Parameters.AddWithValue("@tipo_de_movimineto", obj_caja_diaria.tipo_de_movimiento)
            cmd.Parameters.AddWithValue("@tipo_oprecion", obj_caja_diaria.tipo_operacion)
            cmd.Parameters.AddWithValue("@importe", obj_caja_diaria.importe)
            cmd.Parameters.AddWithValue("@medio_de_pago", obj_caja_diaria.medio_de_pago)
            cmd.Parameters.AddWithValue("@valor_de_cambio", obj_caja_diaria.valor_de_cambio)
            cmd.Parameters.AddWithValue("@id_cajero", obj_caja_diaria.id_cajero)
            cmd.Parameters.AddWithValue("@terminal", obj_caja_diaria.terminal)
            cmd.Parameters.AddWithValue("@estado", obj_caja_diaria.estado)
            cmd.Parameters.AddWithValue("@ganancia", obj_caja_diaria.ganancia)
            cmd.Parameters.AddWithValue("@id_venta", obj_caja_diaria.id_venta)
            cmd.Parameters.AddWithValue("@cierre", obj_caja_diaria.cierre)
            cmd.Parameters.AddWithValue("@tipo_de_moneta", obj_caja_diaria.tipo_de_moneda)
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
