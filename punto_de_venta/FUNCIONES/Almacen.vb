Imports System.Data.SqlClient
Public Class Almacen
    Inherits conexion
    Protected cmd As New SqlCommand





    Public Sub restarAlmacen(idProducto As Integer, und As Decimal)
        Try
            conectado()
            cmd = New SqlCommand("restarAlmacen")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
            cmd.Parameters.AddWithValue("@und", und)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub


    Public Function mostrarAlmacenPorIdProducto(id) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarAlmacenPorIdProducto")
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

    Public Sub eliminardeAlmacen(id As Integer)
        Try
            conectado()
            cmd = New SqlCommand("eliminardeAlmacen")
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
    Public Function buscarEmAlmacen(filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscarEmAlmacen")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filtro", filtro)
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

    Public Function mostrarAlmacen() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarAlmacen")
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
    Public Sub actualizarAlmacen(obk As ce_almacen)
        Try
            conectado()
            cmd = New SqlCommand("actualizarAlmacen")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id", obk.id)
            cmd.Parameters.AddWithValue("@cantidad", obk.cantidad)
            cmd.Parameters.AddWithValue("@lote", obk.lote)
            cmd.Parameters.AddWithValue("@und", obk.und)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub

    Public Sub insertarAlmacen(obj As ce_almacen)
        Try
            conectado()
            cmd = New SqlCommand("insertarAlmacen")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@cantidad", obj.cantidad)
            cmd.Parameters.AddWithValue("@idProducto", obj.idProducto)
            cmd.Parameters.AddWithValue("@lote", obj.lote)
            cmd.Parameters.AddWithValue("@und", obj.und)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub

End Class
