Imports System.Data.SqlClient
Public Class class_texto

    Inherits conexion
    Protected cmd As New SqlCommand


    Function mostrar_cobro_liquido_o_mantenimiento() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_cobro_liquido_o_mantenimiento")
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

    Function insertar_cobro_liquido(ByVal obj_liquido As ce_liquidos) As Boolean
        Try

            conectado()
            cmd = New SqlCommand("insertar_liquido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha", obj_liquido.fecha)
            cmd.Parameters.AddWithValue("@monto", obj_liquido.monto)
            cmd.Parameters.AddWithValue("@motivo", obj_liquido.motivo)
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
