Imports System.Data.SqlClient
Public Class class_proveedor
    Inherits conexion

    Protected cmd As New SqlCommand


    Function eliminar_compra(ByVal id_compra As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_compra")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_compra", id_compra)
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
    Function buscar_hostorial_de_compras_por_codigos_dE_barra(ByVal fecha1 As Date, ByVal fecha2 As Date, ByVal filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_hostorial_de_compras_por_codigos_dE_barra")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
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

    Function eliminar_proveedor(ByVal id_proveedor As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor)
            If cmd.ExecuteNonQuery Then
                Return True
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

    Function buscar_proveedores(ByVal filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_proveedores")
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
    Function mostrar_proveedores() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_proveedores")
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

    Function editar_proveedor(ByVal obj_proveedor As ce_proveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_proveedor", obj_proveedor.id_proveedore)
            cmd.Parameters.AddWithValue("@nombre_o_razon_social", obj_proveedor.nombre_o_razon_social)
            cmd.Parameters.AddWithValue("@tipo_de_documento", obj_proveedor.tipo_de_doc)
            cmd.Parameters.AddWithValue("@numero_de_doc", obj_proveedor.numero_doc)
            cmd.Parameters.AddWithValue("@telefono", obj_proveedor.telefono)
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



    Function insertar_proveedores(ByVal obj_proveedor As ce_proveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_proveedores")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre_o_razon_social", obj_proveedor.nombre_o_razon_social)
            cmd.Parameters.AddWithValue("@tipo_de_documento", obj_proveedor.tipo_de_doc)
            cmd.Parameters.AddWithValue("@numero_de_doc", obj_proveedor.numero_doc)
            cmd.Parameters.AddWithValue("@telefono", obj_proveedor.telefono)
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

    Function buscar_hostorial_de_compras(ByVal fecha1 As Date, ByVal fecha2 As Date) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_hostorial_de_compras")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
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
    Function mostrar_hostorial_de_compras() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_hostorial_de_compras")
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

    Function insertar_compra(ByVal obj_proveedor As ce_proveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_compra")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@cantida", obj_proveedor.cantidad)
            cmd.Parameters.AddWithValue("@comprobante", obj_proveedor.comprobante)
            cmd.Parameters.AddWithValue("@precio", obj_proveedor.precio)
            cmd.Parameters.AddWithValue("@numero_doc", obj_proveedor.numero_doc)
            cmd.Parameters.AddWithValue("@proveedor", obj_proveedor.proveedor)
            cmd.Parameters.AddWithValue("@tipo_de_ingreso", obj_proveedor.tipo_de_ingreso)
            cmd.Parameters.AddWithValue("@fecha", obj_proveedor.fecha)
            cmd.Parameters.AddWithValue("@articulo", obj_proveedor.articulo)
            cmd.Parameters.AddWithValue("@codigo_de_barra", obj_proveedor.codigo_de_barra)
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
