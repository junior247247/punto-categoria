Imports System.Data.SqlClient
Public Class Class_comprobantes
    Inherits conexion

    Protected cmd As New SqlCommand


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
    Function actualizar_ultimo_disponible(ByVal obj_comprobante As Ce_comprobantes) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actualizar_ultimo_disponible")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_ultimo_comprobante", obj_comprobante.id_comprobante)
            cmd.Parameters.AddWithValue("@ultimo_comprobante", obj_comprobante.comprobante)
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

    Function seleccionar_ultimo_comprobante() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("seleccionar_ultimo_comprobante")
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


    Function insertar_ultimo_comprobante(ByVal obj_comprobante As Ce_comprobantes) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_ultimo_comprobante")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@numero_de_ultimo_comprobante", obj_comprobante.comprobante)
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

    Function insertar_comprobantes(ByVal obj_comprobante As Ce_comprobantes) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_comprobantes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@numero_de_comprobante", obj_comprobante.comprobante)
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
