Public Class frm_almacen
    Private dt As New DataTable
    'Private class_producto As New class_producto
    Private almacen As New Almacen

    Public Sub buscar_prodcutos()
        Try


            dt = almacen.buscarEmAlmacen(txt_buscar.Text)
            datalistado_productos.DataSource = dt
            datalistado_productos.Columns(0).Visible = False
            datalistado_productos.Columns(1).Visible = False
            datalistado_productos.EnableHeadersVisualStyles = False




            If datalistado_productos.Rows.Count > 0 Then
                datalistado_productos.ContextMenuStrip = c_menu_reabastecer
            Else
                datalistado_productos.ContextMenuStrip = Nothing
            End If

            datalistado_productos.Columns(2).Width = 270
            For i = 2 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 200
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Public Sub mostrar_productos()
        Try
            dt = almacen.mostrarAlmacen
            datalistado_productos.DataSource = dt
            datalistado_productos.Columns(0).Visible = False
            datalistado_productos.Columns(1).Visible = False
            datalistado_productos.EnableHeadersVisualStyles = False
            If datalistado_productos.Rows.Count > 0 Then
                datalistado_productos.ContextMenuStrip = c_menu_reabastecer
            Else
                datalistado_productos.ContextMenuStrip = Nothing
            End If

            datalistado_productos.Columns(2).Width = 270
            For i = 2 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 200
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_productos
    End Sub

    Private Sub btn_productos_en_punto_de_reorden_Click(sender As Object, e As EventArgs) Handles btn_productos_en_punto_de_reorden.Click
        frm_productos_en_punto_de_reorden.ShowDialog()
    End Sub

    Private Sub ReabastecerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReabastecerToolStripMenuItem.Click
        Try
            Dim d As New DialogResult
            d = MessageBox.Show("¿Realmente deceas eliminar este registro?", "Eliminando Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If d = DialogResult.Yes Then
                Dim id As Integer = Convert.ToInt32(datalistado_productos.SelectedCells.Item(1).Value.ToString)
                almacen.eliminardeAlmacen(id)
                mostrar_productos()
                MessageBox.Show("Registro eliminado", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        buscar_prodcutos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmIngresoAlmacen.ShowDialog()
    End Sub

    Private Sub ReabastecerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReabastecerToolStripMenuItem1.Click
        frmIngresoAlmacen.lblId.Text = datalistado_productos.SelectedCells.Item(0).Value
        frmIngresoAlmacen.lblIdAlmacen.Text = datalistado_productos.SelectedCells.Item(1).Value
        frmIngresoAlmacen.txtProducto.Text = datalistado_productos.SelectedCells.Item(2).Value
        frmIngresoAlmacen.cboTipo.Text = datalistado_productos.SelectedCells.Item(3).Value
        frmIngresoAlmacen.txtCantidad.Text = datalistado_productos.SelectedCells.Item(4).Value
        frmIngresoAlmacen.txtUnidad.Text = datalistado_productos.SelectedCells.Item(5).Value
        frmIngresoAlmacen.txtCantidad.Enabled = True
        frmIngresoAlmacen.txtUnidad.Enabled = True
        frmIngresoAlmacen.ShowDialog()
    End Sub
End Class