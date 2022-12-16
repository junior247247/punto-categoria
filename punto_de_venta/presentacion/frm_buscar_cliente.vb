Public Class frm_buscar_cliente
    Private dt As New DataTable
    Private class_cliente As New class_cliente


    Public Sub buscar()
        Try
            dt = class_cliente.buscar_cliente(txt_buscar.Text)
            datalistado_clientes.DataSource = dt
            datalistado_clientes.Columns(0).Visible = False
            datalistado_clientes.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_clientes.Columns.Count - 1 Step 1
                datalistado_clientes.Columns(i).Width = 190
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mostrar()
        Try
            dt = class_cliente.motrar_clientes
            datalistado_clientes.DataSource = dt
            datalistado_clientes.Columns(0).Visible = False
            datalistado_clientes.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_clientes.Columns.Count - 1 Step 1
                datalistado_clientes.Columns(i).Width = 190
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_buscar_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        txt_buscar.Select()
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        buscar()
    End Sub

    Private Sub datalistado_clientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_clientes.CellDoubleClick
        Try
            frm_punto_de_venta.lbl_clientes.Text = datalistado_clientes.SelectedCells.Item(1).Value
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        Try
            If datalistado_clientes.Rows.Count > 0 Then
                frm_punto_de_venta.lbl_clientes.Text = datalistado_clientes.SelectedCells.Item(1).Value
                Me.Close()
            Else
                MessageBox.Show("No hay clientes registrados", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_buscar.Clear()
        Me.Close()
    End Sub

    Private Sub lbl_registrar_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_registrar_link.LinkClicked

        frm_registro_clientes.btn_Guardar.Visible = True
        frm_registro_clientes.btn_editar.Visible = False
        frm_registro_clientes.ShowDialog()
    End Sub
End Class