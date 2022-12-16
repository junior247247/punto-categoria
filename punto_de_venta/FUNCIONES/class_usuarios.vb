Imports System.Data.SqlClient
Public Class class_usuarios
    Inherits conexion
    Protected cmd As New SqlCommand





    Function buscar_usuarios(ByVal filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_usuarios")
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

    Function cambiar_password_admin(ByVal obj_usuario As ce_usuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("cambiar_password_admin")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_pass", obj_usuario.id_pass)
            cmd.Parameters.AddWithValue("@password", obj_usuario.password)
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

    Function editar_usaurio(ByVal obj_usuario As ce_usuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_usaurio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", obj_usuario.id_usuairo)
            cmd.Parameters.AddWithValue("@usuario", obj_usuario.usuario)
            cmd.Parameters.AddWithValue("@nombre_y_apellido", obj_usuario.nombre_y_apellido)
            cmd.Parameters.AddWithValue("@turno", obj_usuario.turno)
            cmd.Parameters.AddWithValue("@password", obj_usuario.password)
            cmd.Parameters.AddWithValue("@permiso", obj_usuario.permisos)
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


    Function inserta_usaurio(ByVal obj_usuario As ce_usuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("inserta_usaurio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@usuario", obj_usuario.usuario)
            cmd.Parameters.AddWithValue("@nombre_y_apellido", obj_usuario.nombre_y_apellido)
            cmd.Parameters.AddWithValue("@turno", obj_usuario.turno)
            cmd.Parameters.AddWithValue("@password", obj_usuario.password)
            cmd.Parameters.AddWithValue("@permiso", obj_usuario.permisos)
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
    Function mostrar_usuarios() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_usuarios")
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

    Function insertar_hora_caja_abierta(ByVal id_usuario As Integer, ByVal caja_abierta As String) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_hora_caja_abierta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
            cmd.Parameters.AddWithValue("@caja_abierta", caja_abierta)
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
    Function verificar_si_existe_la_hora(ByVal id_usuario As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificar_si_existe_la_hora")
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





    Function verificar_si_tiene_fondo_el_usuario_en_caja(ByVal id_usuario As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificar_si_tiene_fondo_el_usuario_en_caja")
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
    Function desbloquear(ByVal pass As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("desbloquear")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@pass", pass)
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
    Function iniciar_sesion(ByVal obj_usuario As ce_usuario) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("iniciar_sesion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@usuario", obj_usuario.usuario)
            cmd.Parameters.AddWithValue("@passworrd", obj_usuario.password)
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
