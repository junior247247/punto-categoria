Imports System.Data.SqlClient
Public Class class_inventario_prod
    Inherits conexion


    Protected cmd As New SqlCommand

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
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
