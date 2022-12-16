Imports System.Data.SqlClient

Public Class class_gastos
    Inherits conexion
    Private cmd As New SqlCommand





    Public Function sumarGastosOtros(ByVal fecha1 As String, ByVal fecha2 As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumarGastosOtros")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
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




    Public Function sumarGastosInversion(ByVal fecha1 As Date, ByVal fecha2 As Date) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumarGastosInversion")
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


    Public Function mostrar_gastos_por_fechaConCategoria(fecha1 As Date, fecha2 As Date, categoria As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_gastos_por_fechaConCategoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
            cmd.Parameters.AddWithValue("@categoria", categoria)
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
    Public Function sumarGastos(fecha1 As String, fecha2 As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sumarGastos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fechaDesde", fecha1)
            cmd.Parameters.AddWithValue("@fechaHasta", fecha2)
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
    Public Sub insertarTotalSumaGastos(ByVal objReporte As ce_reporte_gasto)
        Try
            conectado()
            cmd = New SqlCommand("insertarTotalSumaGastos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fechadesde", objReporte.fechaDesde)
            cmd.Parameters.AddWithValue("@fechaHasta", objReporte.fechaHasta)
            cmd.Parameters.AddWithValue("@totalSinItbis", objReporte.totalSinItbis)
            cmd.Parameters.AddWithValue("@totalConitbis", objReporte.totalConItbis)
            cmd.Parameters.AddWithValue("@sumaDeitbis", objReporte.sumaDeItbis)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub
    Function sacarUltimoIDGastos() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("sacarUltimoIDGastos")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
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
    Function mostrar_reporte_desde_hasta_gastos(idDesde As Integer, fecha1 As String, fecha2 As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_reporte_desde_hasta_gastos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_desde", idDesde)
            cmd.Parameters.AddWithValue("@fecha_desde", fecha1)
            cmd.Parameters.AddWithValue("@fecha_hasta", fecha2)
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

    Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables




        'Try
        '    Dim exApp As New Microsoft.Office.Interop.Excel.Application

        '    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        '    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        '    'Añadimos el Libro al programa, y la hoja al libro

        '    exLibro = exApp.Workbooks.Add

        '    exHoja = exLibro.Worksheets.Add()

        '    ' ¿Cuantas columnas y cuantas filas?

        '    Dim NCol As Integer = ElGrid.ColumnCount

        '    Dim NRow As Integer = ElGrid.RowCount

        '    'Aqui recorremos todas las filas, y por cada fila todas las columnas

        '    'y vamos escribiendo.

        '    For i As Integer = 1 To NCol

        '        exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString




        '    Next
        '    'errorr linea

        '    For Fila As Integer = 0 To NRow - 1

        '        For Col As Integer = 0 To NCol - 1

        '            exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value

        '        Next

        '    Next

        '    'Titulo en negrita, Alineado al centro y que el tamaño de la columna

        '    'se ajuste al texto

        '    exHoja.Rows.Item(1).Font.Bold = 1

        '    exHoja.Rows.Item(1).HorizontalAlignment = 3

        '    exHoja.Columns.AutoFit()

        '    'Aplicación visible

        '    exApp.Application.Visible = True

        '    exHoja = Nothing

        '    exLibro = Nothing

        '    exApp = Nothing

        'Catch ex As Exception

        '    MsgBox("Excel no instalado o version menor a 2016", MsgBoxStyle.Critical, "Error al exportar a Excel")

        '    Return False

        'End Try

        'Return True

    End Function

    Function mostrar_gastos_por_fecha(ByVal fecha1 As String, ByVal fecha2 As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_gastos_por_fecha")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
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
    Public Sub ActualizarrGasto(ByVal objGasto As ce_gastos)
        Try
            conectado()
            cmd = New SqlCommand("actualizarGasto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_gasto", objGasto.idGasto)
            cmd.Parameters.AddWithValue("@total_sin_itbis", objGasto.totalSinItbis)
            cmd.Parameters.AddWithValue("@total_con_itbis", objGasto.totalConItbis)
            cmd.Parameters.AddWithValue("@itbis", objGasto.itbisa)
            cmd.Parameters.AddWithValue("@description", objGasto.description)
            cmd.Parameters.AddWithValue("@categoria", objGasto.categoria)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub


    Public Sub eliminarGasto(ByVal idGasto As Integer)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_gasto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_gasto", idGasto)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub
    Public Sub insertarGasto(ByVal objGasto As ce_gastos)
        Try
            conectado()
            cmd = New SqlCommand("insertar_gastos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@total_sin_itbis", objGasto.totalSinItbis)
            cmd.Parameters.AddWithValue("@total_con_itbis", objGasto.totalConItbis)
            cmd.Parameters.AddWithValue("@itbis", objGasto.itbisa)
            cmd.Parameters.AddWithValue("@description", objGasto.description)
            cmd.Parameters.AddWithValue("@fecha", objGasto.fecha)
            cmd.Parameters.AddWithValue("@categoria", objGasto.categoria)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
    End Sub
    Function mostrarGastos() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_gastos")
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


End Class
