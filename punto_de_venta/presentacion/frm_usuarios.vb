Public Class frm_usuarios
    Private obj_usuario As New ce_usuario
    Private class_usuario As New class_usuarios
    Private Sub frm_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_permisos.DropDownStyle = 2
        cbo_turno.DropDownStyle = 2
    End Sub

    Private Sub btn_ver_usuarios_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_ver_usuarios.LinkClicked
        frm_ver_usuarios.ShowDialog()
    End Sub

    Public Sub limpiar()
        txt_nombre_y_apellido.Clear()
        txt_password.Clear()
        txt_usuario.Clear()


    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If cbo_permisos.Text.Trim <> String.Empty And cbo_turno.Text.Trim <> String.Empty And txt_nombre_y_apellido.Text.Trim <> String.Empty And txt_usuario.Text.Trim <> String.Empty And txt_password.Text.Trim <> String.Empty Then
            With obj_usuario
                .nombre_y_apellido = txt_nombre_y_apellido.Text.ToUpper
                .permisos = cbo_permisos.Text.ToUpper
                .password = txt_password.Text.Trim
                .usuario = txt_usuario.Text
                .turno = cbo_turno.Text.ToUpper
            End With
            class_usuario.inserta_usaurio(obj_usuario)

            MessageBox.Show("USUARIO REGISTRADO CON EXITO", "REGISTRO DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Else
            MessageBox.Show("DATOS INCOMPLETOS", "REGISTRO DE USUARO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If cbo_permisos.Text.Trim <> String.Empty And cbo_turno.Text.Trim <> String.Empty And txt_nombre_y_apellido.Text.Trim <> String.Empty And txt_usuario.Text.Trim <> String.Empty And txt_password.Text.Trim <> String.Empty Then
            With obj_usuario
                .id_usuairo = Val(lbL_id_usaurio.Text)
                .nombre_y_apellido = txt_nombre_y_apellido.Text.ToUpper
                .permisos = cbo_permisos.Text.ToUpper
                .password = txt_password.Text.Trim
                .usuario = txt_usuario.Text
                .turno = cbo_turno.Text.ToUpper
            End With
            class_usuario.editar_usaurio(obj_usuario)
            btn_editar.Visible = False
            btn_guardar.Visible = True
            MessageBox.Show("USUARIO REGISTRADO CON EXITO", "REGISTRO DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Else
            MessageBox.Show("DATOS INCOMPLETOS", "REGISTRO DE USUARO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_cambiar_password_admin_Click(sender As Object, e As EventArgs) Handles btn_cambiar_password_admin.Click
        frm_password_admin.ShowDialog()
    End Sub

    Private Sub txt_nombre_y_apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_y_apellido.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_usuario.Select()
        End If
    End Sub

    Private Sub txt_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usuario.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_password.Select()
        End If
    End Sub




End Class