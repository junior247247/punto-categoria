Public Class frm_login
    Private obj_usuairo As New ce_usuario
    Private class_usuario As New class_usuarios
    Private dt As New DataTable
    Private Sub btn_iniciar_sesion_Click(sender As Object, e As EventArgs) Handles btn_iniciar_sesion.Click


        If txt_password.Text.Trim <> String.Empty And txt_password.Text <> String.Empty Then

                With obj_usuairo
                    .usuario = txt_usuario.Text
                    .password = txt_password.Text
                End With
                dt = class_usuario.iniciar_sesion(obj_usuairo)
                If dt.Rows.Count > 0 Then
                    If txt_usuario.Text = dt.Rows(0).Item("usuario").ToString And txt_password.Text = dt.Rows(0).Item("password").ToString Then
                        Form1.lbl_id_usuario.Text = dt.Rows(0).Item("id_usuario").ToString
                        Form1.lbl_nombre_de_usuario.Text = dt.Rows(0).Item("nombre_de_usuario").ToString
                    Form1.lbl_turno.Text = dt.Rows(0).Item("turno").ToString
                    Form1.lbl_permiso.Text = dt.Rows(0).Item("permiso").ToString
                    txt_password.Clear()
                    txt_usuario.Clear()

                    dt = class_usuario.verificar_si_tiene_fondo_el_usuario_en_caja(Val(dt.Rows(0).Item("id_usuario").ToString))
                    If dt.Rows.Count > 0 Then
                        Me.Hide()
                        Form1.Show()
                    Else
                        Me.Hide()
                        frm_fondo_en_caja.ShowDialog()
                    End If

                Else
                        MessageBox.Show("usuario o contraseña incorrecto", "inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt_password.Clear()
                        txt_usuario.Clear()
                        txt_usuario.Select()
                    End If
                Else
                    MessageBox.Show("usuario o contraseña incorrecto", "inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_password.Clear()
                    txt_usuario.Clear()
                    txt_usuario.Select()
                End If
            Else
                MessageBox.Show("campos incompletos", "inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_usuario.Select()
    End Sub

    Private Sub txt_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usuario.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_password.Select()

        End If
    End Sub

    Private Sub txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If txt_password.Text.Trim <> String.Empty And txt_password.Text <> String.Empty Then

                With obj_usuairo
                    .usuario = txt_usuario.Text
                    .password = txt_password.Text
                End With
                dt = class_usuario.iniciar_sesion(obj_usuairo)
                If dt.Rows.Count > 0 Then
                    If txt_usuario.Text = dt.Rows(0).Item("usuario").ToString And txt_password.Text = dt.Rows(0).Item("password").ToString Then
                        Form1.lbl_id_usuario.Text = dt.Rows(0).Item("id_usuario").ToString
                        Form1.lbl_nombre_de_usuario.Text = dt.Rows(0).Item("nombre_de_usuario").ToString
                        Form1.lbl_turno.Text = dt.Rows(0).Item("turno").ToString
                        Form1.lbl_permiso.Text = dt.Rows(0).Item("permiso").ToString
                        txt_password.Clear()
                        txt_usuario.Clear()
                        dt = class_usuario.verificar_si_tiene_fondo_el_usuario_en_caja(Val(dt.Rows(0).Item("id_usuario").ToString))
                        If dt.Rows.Count > 0 Then
                            Me.Hide()
                            Form1.Show()
                        Else
                            Me.Hide()
                            frm_fondo_en_caja.ShowDialog()
                        End If
                    Else
                        MessageBox.Show("usuario o contraseña incorrecto", "inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_password.Clear()
                    txt_usuario.Clear()
                    txt_usuario.Select()
                End If
            Else
                MessageBox.Show("usuario o contraseña incorrecto", "inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_password.Clear()
                    txt_usuario.Clear()
                    txt_usuario.Select()
                End If
            Else
                MessageBox.Show("campos incompletos", "inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        End
    End Sub
End Class