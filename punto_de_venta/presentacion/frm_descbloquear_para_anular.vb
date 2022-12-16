Public Class frm_descbloquear_para_anular
    Private dt As New DataTable
    Private class_usuario As New class_usuarios
    Private Sub btn_desbloquear_Click(sender As Object, e As EventArgs) Handles btn_desbloquear.Click
        If txt_password.Text.Trim <> String.Empty Then
            dt = class_usuario.desbloquear(txt_password.Text)
            If dt.Rows.Count > 0 Then
                txt_password.Clear()
                frm_anular_ticket.ShowDialog()
                Me.Close()
            Else
                MessageBox.Show("Contraseña incorrecta", "Desbloqueo anular ticket", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_password.Clear()
                txt_password.Select()
            End If
        End If
    End Sub

    Private Sub txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then

            If txt_password.Text.Trim <> String.Empty Then
                dt = class_usuario.desbloquear(txt_password.Text)
                If dt.Rows.Count > 0 Then
                    txt_password.Clear()
                    frm_anular_ticket.ShowDialog()
                    Me.Close()
                Else
                    MessageBox.Show("Contraseña incorrecta", "Desbloqueo anular ticket", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_password.Clear()
                    txt_password.Select()
                End If
            End If

        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_password.Clear()
        Me.Close()
    End Sub

    Private Sub frm_descbloquear_para_anular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_password.Select()
    End Sub
End Class