Imports System.Data.SqlClient
Public Class class_cliente
    Inherits conexion
    Protected cmd As New SqlCommand




    Function buscar_cliente(ByVal filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_cliente")
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

    Function eliminar_cliente(ByVal obj_cliente As ce_clientes) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_cliente", obj_cliente.id_cliente)
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
    Function motrar_clientes() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("motrar_clientes")
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

    Function editar_cliente(ByVal obj_clienta As ce_clientes) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_cliente", obj_clienta.id_cliente)
            cmd.Parameters.AddWithValue("@nombre_y_apellido", obj_clienta.nombre_y_apellido)
            cmd.Parameters.AddWithValue("@dni", obj_clienta.dni)
            cmd.Parameters.AddWithValue("@telefoo", obj_clienta.telefono)
            cmd.Parameters.AddWithValue("@direccion", obj_clienta.direccion)
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


    Function insertar_clientes(ByVal obj_clienta As ce_clientes) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_clientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre_y_apellido", obj_clienta.nombre_y_apellido)
            cmd.Parameters.AddWithValue("@dni", obj_clienta.dni)
            cmd.Parameters.AddWithValue("@telefoo", obj_clienta.telefono)
            cmd.Parameters.AddWithValue("@direccion", obj_clienta.direccion)
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
