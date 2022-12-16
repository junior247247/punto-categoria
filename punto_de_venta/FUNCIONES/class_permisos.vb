Imports System.Data.SqlClient
Public Class class_permisos
    Inherits conexion
    Protected cmd As New SqlCommand

    Function dar_permisos(ByVal id_usuario As Integer, ByVal permiso As String) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("dar_permisos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuairo", id_usuario)
            cmd.Parameters.AddWithValue("@permiso", permiso)
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




    Function eliminar_permiso(ByVal id_usuario As Integer, ByVal id_permiso As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_permiso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
            cmd.Parameters.AddWithValue("@id_permiso", id_permiso)
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
    Function selecionar_permisos_dados(ByVal id_user As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("selecionar_permisos_dados")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", id_user)
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
