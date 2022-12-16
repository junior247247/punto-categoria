Public Class frm_password_admin
    Private dt As New DataTable
    Private class_usuario As New class_usuarios
    Private obj_usuaro As New ce_usuario
    Public Sub limpiar()
        txt_password_actual.Clear()
        txt_password_nueva.Clear()
        txt_repetir_password.Clear()
    End Sub
    Private Sub btn_cambiar_password_Click(sender As Object, e As EventArgs) Handles btn_cambiar_password.Click
        If txt_password_actual.Text.Trim <> String.Empty And txt_password_nueva.Text.Trim <> String.Empty And txt_repetir_password.Text.Trim <> String.Empty Then
            dt = class_usuario.desbloquear(txt_password_actual.Text)
            If dt.Rows.Count > 0 Then
                If txt_password_nueva.Text = txt_repetir_password.Text Then
                    Dim id_pass As Integer = dt.Rows(0).Item("id_pass")
                    With obj_usuaro
                        .id_pass = id_pass
                        .password = txt_password_nueva.Text
                    End With
                    class_usuario.cambiar_password_admin(obj_usuaro)
                    MessageBox.Show("Contraseña cambiada con exito", "Cambiar password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    Me.Close()

                Else
                    MessageBox.Show("La contraseña repetitdas no son iguales", "Cambiar password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_password_nueva.Clear()
                    txt_repetir_password.Clear()
                End If
            Else
                MessageBox.Show("Contraseña incorrecta", "Cambiar password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_password_actual.Clear()
                txt_password_actual.Select()
            End If
        Else
            MessageBox.Show("Datos incompletos", "Cambiar password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub txt_password_actual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password_actual.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_password_nueva.Select()
        End If
    End Sub

    Private Sub txt_password_nueva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password_nueva.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_repetir_password.Select()
        End If
    End Sub

    Private Sub txt_repetir_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_repetir_password.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btn_cambiar_password.Select()
        End If
    End Sub
End Class