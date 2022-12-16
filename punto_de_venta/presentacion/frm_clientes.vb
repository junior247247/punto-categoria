Public Class frm_clientes
    Private dt As New DataTable
    Private class_cliente As New class_cliente
    Private obj_cliente As New ce_clientes



    Public Sub buscar()
        Try
            dt = class_cliente.buscar_cliente(txt_buscar_clientes.Text)
            datalistado_clientes.DataSource = dt
            datalistado_clientes.Columns(0).Visible = False
            datalistado_clientes.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_clientes.Columns.Count - 1 Step 1
                datalistado_clientes.Columns(i).Width = 200
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub mostrar_clientes()
        Try
            dt = class_cliente.motrar_clientes
            datalistado_clientes.DataSource = dt
            datalistado_clientes.EnableHeadersVisualStyles = False
            datalistado_clientes.Columns(0).Visible = False

            If datalistado_clientes.Rows.Count > 0 Then
                datalistado_clientes.ContextMenuStrip = c_menu_clientes
            Else
                datalistado_clientes.ContextMenuStrip = Nothing
            End If

            For i = 1 To datalistado_clientes.Columns.Count - 1 Step 1
                datalistado_clientes.Columns(i).Width = 200
            Next
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_clientes()
    End Sub

    Private Sub btn_nuevo_cliente_Click(sender As Object, e As EventArgs) Handles btn_nuevo_cliente.Click
        frm_registro_clientes.btn_Guardar.Visible = True
        frm_registro_clientes.btn_editar.Visible = False
        frm_registro_clientes.ShowDialog()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Try
            frm_registro_clientes.lb_id_cliente.Text = datalistado_clientes.SelectedCells.Item(0).Value
            frm_registro_clientes.txt_nombre_y_apellido.Text = datalistado_clientes.SelectedCells.Item(1).Value
            frm_registro_clientes.txt_telefono.Text = datalistado_clientes.SelectedCells.Item(2).Value
            frm_registro_clientes.txt_dni.Text = datalistado_clientes.SelectedCells.Item(3).Value
            frm_registro_clientes.txt_dreccion.Text = datalistado_clientes.SelectedCells.Item(4).Value
            frm_registro_clientes.btn_Guardar.Visible = False
            frm_registro_clientes.btn_editar.Visible = True
            frm_registro_clientes.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            Dim d As New DialogResult
            d = MessageBox.Show("¿Seguro que deceas eliminar este cliente?", "Eliminando Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If d = DialogResult.Yes Then
                obj_cliente.id_cliente = datalistado_clientes.SelectedCells.Item(0).Value
                class_cliente.eliminar_cliente(obj_cliente)
                mostrar_clientes()
                MessageBox.Show("Cliente eliminado con exito", "Elimando Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_buscar_clientes_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_clientes.TextChanged
        buscar()
    End Sub
End Class