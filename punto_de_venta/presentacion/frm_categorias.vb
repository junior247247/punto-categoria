Public Class frm_categorias
    Private dt As New DataTable
    Private class_prodcuto As New class_producto
    Private obj_producto As New ce_producto

    Public Sub mostrar()
        Try
            dt = class_prodcuto.mostrar_categoria
            datalistado_categorias.DataSource = dt
            datalistado_categorias.EnableHeadersVisualStyles = False
            If datalistado_categorias.Rows.Count > 0 Then
                datalistado_categorias.ContextMenuStrip = c_menu_categoria
            Else
                datalistado_categorias.ContextMenuStrip = Nothing
            End If

            For i = 0 To datalistado_categorias.Columns.Count - 1 Step 1
                datalistado_categorias.Columns(i).Width = 250
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If txt_categoria.Text.Trim <> String.Empty Then
            obj_producto.categorias = txt_categoria.Text.ToUpper
            class_prodcuto.insertar_categoria(obj_producto)
            MessageBox.Show("Categoria registrada con exito", "Regsitro de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_categoria.Clear()
            mostrar()
        Else
            MessageBox.Show("Ingrese el nombre de la categoria", "Registro de categoria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            Dim d As New DialogResult
            d = MessageBox.Show("¿Deceas eliminar este Registro?", "Eliminando registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If d = DialogResult.Yes Then
                Dim id As Integer
                id = datalistado_categorias.SelectedCells.Item(0).Value
                class_prodcuto.eliminar_categoria(id)
                MessageBox.Show("Registro eliminado con exito", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
End Class