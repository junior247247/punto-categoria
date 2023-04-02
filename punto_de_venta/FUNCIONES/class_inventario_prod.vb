Imports System.Data.SqlClient
Public Class class_inventario_prod
    Inherits conexion


    Protected cmd As New SqlCommand


    Public Function getProdById(id As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("getProdById")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idProd", id)
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function updateInventario(obj As ce_prod) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("updateInventario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idProducto", obj.idProducto)
            cmd.Parameters.AddWithValue("@cantidad", obj.cantidad)
            cmd.Parameters.AddWithValue("@diferencia", obj.direfencia)
            cmd.Parameters.AddWithValue("@importe", obj.importe)
            cmd.Parameters.AddWithValue("@total", obj.total)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function getProdByCount(id As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("getProdByCount")
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
        End Try
    End Function

    Public Function insertarInventario(obj As ce_prod) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertarInventario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idProducto", obj.idProducto)
            cmd.Parameters.AddWithValue("@cantidad", obj.cantidad)
            cmd.Parameters.AddWithValue("@diferencia", obj.direfencia)
            cmd.Parameters.AddWithValue("@importe", obj.importe)
            cmd.Parameters.AddWithValue("@total", obj.total)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
