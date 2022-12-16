Public Class frm_desbloqueo_para_descuento
    Private dt As New DataTable
    Private class_usuario As New class_usuarios
    Private Sub btn_desbloquear_Click(sender As Object, e As EventArgs) Handles btn_desbloquear.Click
        dt = class_usuario.desbloquear(txt_pass.Text)
        If dt.Rows.Count > 0 Then
            frm_punto_de_venta.CH_DESCUENTO.Checked = True
            frm_punto_de_venta.txt_descuento.Enabled = True
            txt_pass.Clear()
            Me.Close()
        Else
            MessageBox.Show("password incorrecta", "Desbloquer descuento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_pass.Clear()
            txt_pass.Select()
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_pass.Clear()
        frm_punto_de_venta.CH_DESCUENTO.Checked = False
        Me.Close()
    End Sub

    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            dt = class_usuario.desbloquear(txt_pass.Text)
            If dt.Rows.Count > 0 Then
                frm_punto_de_venta.CH_DESCUENTO.Checked = True
                frm_punto_de_venta.txt_descuento.Enabled = True
                txt_pass.Clear()
                Me.Close()
            Else
                MessageBox.Show("password incorrecta", "Desbloquear descuento", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txt_pass.Clear()
                txt_pass.Select()
            End If
        End If
    End Sub

    Private Sub frm_desbloqueo_para_descuento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_pass.Select()
    End Sub
End Class