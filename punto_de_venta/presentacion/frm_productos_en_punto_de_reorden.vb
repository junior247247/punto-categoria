Public Class frm_productos_en_punto_de_reorden

    Private dt As New DataTable
    Private class_producto As New class_producto

    Public Sub buscar_productos_en_punto_de_reorden_por_descripcion()
        Try
            dt = class_producto.buscar_productos_en_punto_de_reorden_por_descripcion(txt_buscar_por_descripcion.Text)
            datalistado_productos.DataSource = dt
            datalistado_productos.Columns(0).Visible = False
            datalistado_productos.Columns(11).Visible = False
            datalistado_productos.EnableHeadersVisualStyles = False
            If datalistado_productos.Rows.Count > 0 Then
                datalistado_productos.ContextMenuStrip = c_menu_reabastecer
            Else
                datalistado_productos.ContextMenuStrip = Nothing
            End If

            datalistado_productos.Columns(1).Width = 270
            For i = 2 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 100
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub buscar_productos_en_punto_de_reorden()
        Try
            dt = class_producto.buscar_productos_en_punto_de_reorden(txt_buscar.Text)
            datalistado_productos.DataSource = dt
            datalistado_productos.Columns(0).Visible = False
            datalistado_productos.Columns(11).Visible = False
            datalistado_productos.EnableHeadersVisualStyles = False
            If datalistado_productos.Rows.Count > 0 Then
                datalistado_productos.ContextMenuStrip = c_menu_reabastecer
            Else
                datalistado_productos.ContextMenuStrip = Nothing
            End If

            datalistado_productos.Columns(1).Width = 270
            For i = 2 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 100
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mostrar_productos_en_punto_de_reorden()
        Try
            dt = class_producto.mostrar_productos_en_punto_de_reorden
            datalistado_productos.DataSource = dt
            datalistado_productos.Columns(0).Visible = False
            datalistado_productos.Columns(11).Visible = False
            datalistado_productos.EnableHeadersVisualStyles = False
            If datalistado_productos.Rows.Count > 0 Then
                datalistado_productos.ContextMenuStrip = c_menu_reabastecer
            Else
                datalistado_productos.ContextMenuStrip = Nothing
            End If

            datalistado_productos.Columns(1).Width = 270
            For i = 2 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 100
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_productos_en_punto_de_reorden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_productos_en_punto_de_reorden()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_buscar.Clear()
        Me.Close()
    End Sub

    Private Sub ReabastecerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReabastecerToolStripMenuItem.Click
        Try
            frm_reabastecer.lbl_id_producto.Text = datalistado_productos.SelectedCells.Item(0).Value
            frm_reabastecer.lbl_producto.Text = datalistado_productos.SelectedCells.Item(1).Value
            frm_reabastecer.txt_existencia.Text = datalistado_productos.SelectedCells.Item(8).Value

            frm_reabastecer.ShowDialog()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_reabastecer_Click(sender As Object, e As EventArgs) Handles btn_reabastecer.Click
        Try
            If datalistado_productos.Rows.Count > 0 Then
                frm_reabastecer.lbl_id_producto.Text = datalistado_productos.SelectedCells.Item(0).Value
                frm_reabastecer.lbl_producto.Text = datalistado_productos.SelectedCells.Item(1).Value
                frm_reabastecer.txt_existencia.Text = datalistado_productos.SelectedCells.Item(8).Value

                frm_reabastecer.ShowDialog()
                Me.Close()

            Else
                MessageBox.Show("No hay productos disponible en punto de reorden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        buscar_productos_en_punto_de_reorden()
    End Sub

    Private Sub txt_buscar_por_descripcion_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_por_descripcion.TextChanged
        buscar_productos_en_punto_de_reorden_por_descripcion()
    End Sub
End Class