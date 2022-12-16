Public Class frm_lista_de_proveedores
    Private dt As New DataTable
    Private class_proveeedor As New class_proveedor


    Public Sub home()
        Try


            dt = class_proveeedor.mostrar_proveedores
            frm_home.lbl_proveedores.Text = dt.Rows.Count
            If frm_home.lbl_proveedores.Text = String.Empty Then
                frm_home.lbl_proveedores.Text = "0"
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub buscar()
        Try
            dt = class_proveeedor.buscar_proveedores(txt_buscar.Text)
            datalistado_proveedor.DataSource = dt

            If datalistado_proveedor.Rows.Count > 0 Then
                datalistado_proveedor.ContextMenuStrip = c_menu_proveedores
            Else
                datalistado_proveedor.ContextMenuStrip = Nothing
            End If
            datalistado_proveedor.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_proveedor.Columns.Count - 1 Step 1
                datalistado_proveedor.Columns(i).Width = 200
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mostrar()
        Try
            dt = class_proveeedor.mostrar_proveedores
            datalistado_proveedor.DataSource = dt
            If datalistado_proveedor.Rows.Count > 0 Then
                datalistado_proveedor.ContextMenuStrip = c_menu_proveedores
            Else
                datalistado_proveedor.ContextMenuStrip = Nothing
            End If
            datalistado_proveedor.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_proveedor.Columns.Count - 1 Step 1
                datalistado_proveedor.Columns(i).Width = 200
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_lista_de_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        txt_buscar.Select()
    End Sub



    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        buscar()
    End Sub



    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_buscar.Clear()
        Me.Close()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            Dim d As New DialogResult
            d = MessageBox.Show("¿Seguro que deceas eliminar este registro?", "Eliminando registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If d = DialogResult.Yes Then
                Dim id As Integer
                id = datalistado_proveedor.SelectedCells.Item(0).Value
                class_proveeedor.eliminar_proveedor(id)
                MessageBox.Show("Registro eliminado con exito", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                home()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datalistado_proveedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_proveedor.CellDoubleClick
        Try
            frm_provedor.lbl_id_proveedor.Text = datalistado_proveedor.SelectedCells.Item(0).Value
            frm_provedor.txt_nombre_o_razon_social.Text = datalistado_proveedor.SelectedCells.Item(1).Value
            frm_provedor.cbo_tipo_de_documento.Text = datalistado_proveedor.SelectedCells.Item(2).Value
            frm_provedor.txt_numero_de_doc.Text = datalistado_proveedor.SelectedCells.Item(3).Value
            frm_provedor.txt_telefono.Text = datalistado_proveedor.SelectedCells.Item(4).Value
            frm_provedor.btn_guardar.Visible = False
            frm_provedor.btn_editar.Visible = True
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class