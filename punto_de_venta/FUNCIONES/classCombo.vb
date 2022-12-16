Imports System.Data.SqlClient
Public Class classCombo
    Inherits conexion

    Protected cmd As New SqlCommand


    Public Function verificarSiEstaElproductoEncombo(id As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificarSiEstaElproductoEncombo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idProducto", id)
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

    Public Sub eliminarComboPorIdCombo(id As Integer)
        Try
            conectado()
            cmd = New SqlCommand("eliminarComboPorIdCombo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idCombo", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub
    Public Function verificarProductoCombo(id As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificarProductoCombo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idCombo", id)
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
    Public Sub updateIdCombo(id As Integer)
        conectado()
        cmd = New SqlCommand("UPDATE db_combo SET idCombo=@idProducto,verifica='si' where (idCombo=0)", cnn)
        Dim Trans As SqlTransaction
        Trans = cnn.BeginTransaction
        cmd.Transaction = Trans
        Try

            cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value = id

            cmd.ExecuteNonQuery()
            Trans.Commit()

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub
    Public Function mostrarProductoAcendente() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarProductoAcendente")
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

    Public Function selecionarProducto(idProducto As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("selecionarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
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

    Public Sub elimiarComboSelecion(id As Integer)
        Try
            conectado()
            cmd = New SqlCommand("elimiarComboSelecion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub
    Public Function mostrarProductoSCombo() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarProductoSCombo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
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

    Public Function verificarSiEstaElProducto(idProducto As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificarSiEstaElProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
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
    Public Sub insertarCombo(combo As ceCombo)
        Try
            conectado()
            cmd = New SqlCommand("insertarCombo")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idProducto", combo.idProducto)
            cmd.Parameters.AddWithValue("@idCombo", combo.idCombo)
            cmd.Parameters.AddWithValue("@cantidad", combo.cantidad)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub

End Class
