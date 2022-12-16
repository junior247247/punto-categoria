Imports System.Data.SqlClient
Public Class class_producto
    Inherits conexion

    Protected cmd As New SqlCommand



    Public Function verificar_producto(ByVal idProductoas As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", idProductoas)
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

    Public Sub actualizar_precio_de_compra(id_producto As Integer, precio_de_compra As Decimal)
        Try
            conectado()
            cmd = New SqlCommand("actualizar_precio_de_compra")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
            cmd.Parameters.AddWithValue("@precio_de_compra", precio_de_compra)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub
    Function actilizar_todas_las_imagen(ByVal ce_producto As ce_producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("actilizar_todas_las_imagen")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@img", ce_producto.gimagen)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Function verificar_si_el_producto_tiene_codigo(ByVal codigo_Debarra As String, ByVal id_producto As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificar_si_el_producto_tiene_codigo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
            cmd.Parameters.AddWithValue("@codigo_de_barra", codigo_Debarra)
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
    Function verificar_si_existe_codigo_de_barra(ByVal codigo_de_barra As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificar_si_existe_codigo_de_barra")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@codigo_de_barra", codigo_de_barra)
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
    Function SUMAR_GANANCIAS_EN_VENTA(ByVal id_producto As Integer, ByVal id_venta As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("SUMAR_GANANCIAS_EN_VENTA")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
            cmd.Parameters.AddWithValue("@id_venta", id_venta)
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


    Function mostrar_precio_de_compra(ByVal id_producto As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_precio_de_compra")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
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


    Function ganancia_al_por_mayor(ByVal id_producto As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("ganancia_al_por_mayor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
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
    Function reabastecer_por_id(ByVal obj_producto As ce_producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("reabastecer_por_id")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", obj_producto.id_producto)
            cmd.Parameters.AddWithValue("@cantidaad", obj_producto.cantidad)
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
    Function eliminar_categoria(ByVal id_categoria As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria)
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
    Function mostrar_categoria() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_categoria")
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
    Function insertar_categoria(ByVal obj_prodcto As ce_producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre", obj_prodcto.categorias)
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

    Function reeabastecer_por_nombre(ByVal obj_producto As ce_producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("reeabastecer_por_nombre")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre", obj_producto.description)
            cmd.Parameters.AddWithValue("@cantidad", obj_producto.cantidad)
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
    Function verificar_si_exite_el_producto(ByVal nombre As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("verificar_si_exite_el_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre", nombre)
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

    Function buscar_productos_en_compras(ByVal filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_productos_en_compras")
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

    Function buscar_productos(ByVal filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_productos")
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
    Function buscar_productos_en_punto_de_reorden_por_descripcion(ByVal filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_productos_en_punto_de_reorden_por_descripcion")
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



    Function buscar_productos_en_punto_de_reorden(ByVal filtro As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_productos_en_punto_de_reorden")
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
    Function mostrar_productos_en_punto_de_reorden() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_productos_en_punto_de_reorden")
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

    Function eliminar_prodcuto(ByVal obj_producto As ce_producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_prodcuto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", obj_producto.id_producto)
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
    Function mostrar_productos() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_productos")
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


    Function editar_producto(ByVal obj_producto As ce_producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_producto", obj_producto.id_producto)
            cmd.Parameters.AddWithValue("@description", obj_producto.description)
            cmd.Parameters.AddWithValue("@categoria", obj_producto.categorias)
            cmd.Parameters.AddWithValue("@codigo_de_barra", obj_producto.codigo_de_barra)
            cmd.Parameters.AddWithValue("@se_vende_por", obj_producto.se_vende_por)
            cmd.Parameters.AddWithValue("@precio_de_compra", obj_producto.precio_de_compra)
            cmd.Parameters.AddWithValue("@precio_de_venta", obj_producto.precio_de_venta)
            cmd.Parameters.AddWithValue("@precio_mayoreo", obj_producto.precio_mayoreo)
            cmd.Parameters.AddWithValue("@cantidad", obj_producto.cantidad)
            cmd.Parameters.AddWithValue("@punto_de_reorden", obj_producto.punto_de_reorden)
            cmd.Parameters.AddWithValue("@fecha_de_venc", obj_producto.fecha_de_vencieminto)
            cmd.Parameters.AddWithValue("@ganancia", obj_producto.ganancias)
            cmd.Parameters.AddWithValue("@cantidad_por_mayoreo", obj_producto.cantida_por_mayoreo)
            cmd.Parameters.AddWithValue("@itbis", obj_producto.itbis)
            cmd.Parameters.AddWithValue("@ganancia_por_mayor", obj_producto.ganancia_por_precio_al_pormayor)
            cmd.Parameters.AddWithValue("@imgagen", obj_producto.gimagen)
            cmd.Parameters.AddWithValue("@precio_con_descuento", obj_producto.precio_con_descuento)
            cmd.Parameters.AddWithValue("@activo", obj_producto.descuento_activo)
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



    Function insertar_producto(ByVal obj_producto As ce_producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@description", obj_producto.description)
            cmd.Parameters.AddWithValue("@categoria", obj_producto.categorias)
            cmd.Parameters.AddWithValue("@codigo_de_barra", obj_producto.codigo_de_barra)
            cmd.Parameters.AddWithValue("@se_vende_por", obj_producto.se_vende_por)
            cmd.Parameters.AddWithValue("@precio_de_compra", obj_producto.precio_de_compra)
            cmd.Parameters.AddWithValue("@precio_de_venta", obj_producto.precio_de_venta)
            cmd.Parameters.AddWithValue("@precio_mayoreo", obj_producto.precio_mayoreo)
            cmd.Parameters.AddWithValue("@cantidad", obj_producto.cantidad)
            cmd.Parameters.AddWithValue("@punto_de_reorden", obj_producto.punto_de_reorden)
            cmd.Parameters.AddWithValue("@fecha_de_venc", obj_producto.fecha_de_vencieminto)
            cmd.Parameters.AddWithValue("@ganancia", obj_producto.ganancias)
            cmd.Parameters.AddWithValue("@cantidad_por_mayoreo", obj_producto.cantida_por_mayoreo)
            cmd.Parameters.AddWithValue("@imgagen", obj_producto.gimagen)
            cmd.Parameters.AddWithValue("@itbis", obj_producto.itbis)
            cmd.Parameters.AddWithValue("@ganancia_al_por_mayor", obj_producto.ganancia_por_precio_al_pormayor)
            cmd.Parameters.AddWithValue("@precio_con_descuento", obj_producto.precio_con_descuento)
            cmd.Parameters.AddWithValue("@descuento_activo", obj_producto.descuento_activo)
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
