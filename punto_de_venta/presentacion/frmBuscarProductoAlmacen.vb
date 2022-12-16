Public Class frmBuscarProductoAlmacen
    Private class_venta As New class_venta
    Private dt As New DataTable

    Public Sub mostrar()
        Try
            dt = class_venta.mostrar_productos_para_venta
            datalistado_productos.DataSource = dt
            datalistado_productos.EnableHeadersVisualStyles = False
            datalistado_productos.Columns(0).Visible = False

            datalistado_productos.Columns(7).Visible = False
            datalistado_productos.Columns(8).Visible = False
            datalistado_productos.Columns(9).Visible = False
            datalistado_productos.Columns(10).Visible = False
            datalistado_productos.Columns(11).Visible = False
            For i = 0 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 150
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub buscar()
        Try
            dt = class_venta.buscar_productos_para_venta(txt_buscar.Text)
            datalistado_productos.DataSource = dt
            datalistado_productos.EnableHeadersVisualStyles = False
            datalistado_productos.Columns(0).Visible = False

            datalistado_productos.Columns(7).Visible = False
            datalistado_productos.Columns(8).Visible = False
            datalistado_productos.Columns(9).Visible = False
            datalistado_productos.Columns(10).Visible = False
            datalistado_productos.Columns(11).Visible = False
            For i = 0 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 150
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmBuscarProductoAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_buscar.Clear()
        Me.Close()
    End Sub

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        frmIngresoAlmacen.lblId.Text = datalistado_productos.SelectedCells.Item(0).Value
        frmIngresoAlmacen.txtProducto.Text = datalistado_productos.SelectedCells.Item(1).Value
        Me.Close()
    End Sub

    Private Sub datalistado_productos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_productos.CellDoubleClick
        frmIngresoAlmacen.lblId.Text = datalistado_productos.SelectedCells.Item(0).Value
        frmIngresoAlmacen.txtProducto.Text = datalistado_productos.SelectedCells.Item(1).Value
        Me.Close()
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        buscar()
    End Sub
End Class