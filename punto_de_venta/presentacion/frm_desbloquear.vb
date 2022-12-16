Public Class frm_desbloquear
    Private dt As New DataTable
    Private class_usuario As New class_usuarios
    Private Sub btn_desbloquear_Click(sender As Object, e As EventArgs) Handles btn_desbloquear.Click
        dt = class_usuario.desbloquear(txt_pass.Text)
        If dt.Rows.Count > 0 Then
            Me.Close()
            frm_registro_producto.ShowDialog()
            txt_pass.Clear()

        Else
            MessageBox.Show("password incorrecta", "desbloqueo para editar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_pass.Clear()
        End If

    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
        txt_pass.Clear()
    End Sub

    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            dt = class_usuario.desbloquear(txt_pass.Text)
            If dt.Rows.Count > 0 Then
                Me.Close()
                frm_registro_producto.ShowDialog()
                txt_pass.Clear()

            Else
                MessageBox.Show("password incorrecto", "desbloqueo para editar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_pass.Clear()
                txt_pass.Select()
            End If

        End If
    End Sub

    Private Sub frm_desbloquear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_pass.Select()
    End Sub
End Class