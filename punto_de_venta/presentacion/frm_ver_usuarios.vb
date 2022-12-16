Public Class frm_ver_usuarios
    Private dt As New DataTable
    Private class_usuario As New class_usuarios
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_buscar.Clear()
        Me.Close()
    End Sub

    Public Sub buscar()
        Try
            dt = class_usuario.buscar_usuarios(txt_buscar.Text)
            datalistado_usuarios.DataSource = dt
            datalistado_usuarios.EnableHeadersVisualStyles = False
            datalistado_usuarios.Columns(0).Visible = False
            For i = 0 To datalistado_usuarios.Columns.Count - 1 Step 1
                datalistado_usuarios.Columns(i).Width = 140
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mostrar()
        Try
            dt = class_usuario.mostrar_usuarios
            datalistado_usuarios.DataSource = dt
            datalistado_usuarios.EnableHeadersVisualStyles = False
            datalistado_usuarios.Columns(0).Visible = False
            For i = 0 To datalistado_usuarios.Columns.Count - 1 Step 1
                datalistado_usuarios.Columns(i).Width = 140
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_ver_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub datalistado_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado_usuarios.CellDoubleClick
        Try
            If datalistado_usuarios.Rows.Count > 0 Then
                frm_usuarios.lbL_id_usaurio.Text = datalistado_usuarios.SelectedCells.Item(0).Value
                frm_usuarios.txt_usuario.Text = datalistado_usuarios.SelectedCells.Item(1).Value
                frm_usuarios.txt_nombre_y_apellido.Text = datalistado_usuarios.SelectedCells.Item(2).Value
                frm_usuarios.cbo_turno.Text = datalistado_usuarios.SelectedCells.Item(3).Value
                frm_usuarios.txt_password.Text = datalistado_usuarios.SelectedCells.Item(4).Value
                frm_usuarios.cbo_permisos.Text = datalistado_usuarios.SelectedCells.Item(5).Value
                txt_buscar.Clear()
                frm_usuarios.btn_editar.Visible = True
                frm_usuarios.btn_guardar.Visible = False
                Me.Close()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_anular_Click(sender As Object, e As EventArgs) Handles btn_anular.Click
        Try
            If datalistado_usuarios.Rows.Count > 0 Then
                frm_usuarios.lbL_id_usaurio.Text = datalistado_usuarios.SelectedCells.Item(0).Value
                frm_usuarios.txt_usuario.Text = datalistado_usuarios.SelectedCells.Item(1).Value
                frm_usuarios.txt_nombre_y_apellido.Text = datalistado_usuarios.SelectedCells.Item(2).Value
                frm_usuarios.cbo_turno.Text = datalistado_usuarios.SelectedCells.Item(3).Value
                frm_usuarios.txt_password.Text = datalistado_usuarios.SelectedCells.Item(4).Value
                frm_usuarios.cbo_permisos.Text = datalistado_usuarios.SelectedCells.Item(5).Value
                txt_buscar.Clear()
                frm_usuarios.btn_editar.Visible = True
                frm_usuarios.btn_guardar.Visible = False
                Me.Close()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        buscar()
    End Sub
End Class