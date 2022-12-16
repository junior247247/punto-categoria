Public Class frm_registro_clientes
    Private obj_cliete As New ce_clientes
    Private class_clientes As New class_cliente



    Private dt As New DataTable



    Public Sub mostrar_c()
        Try
            dt = class_clientes.motrar_clientes
            frm_buscar_cliente.datalistado_clientes.DataSource = dt
            frm_buscar_cliente.datalistado_clientes.Columns(0).Visible = False
            frm_buscar_cliente.datalistado_clientes.EnableHeadersVisualStyles = False
            For i = 0 To frm_buscar_cliente.datalistado_clientes.Columns.Count - 1 Step 1
                frm_buscar_cliente.datalistado_clientes.Columns(i).Width = 190
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub home()
        Try





            dt = class_clientes.motrar_clientes
            frm_home.lbl_clientes.Text = dt.Rows.Count
            If frm_home.lbl_clientes.Text = String.Empty Then
                frm_home.lbl_clientes.Text = "0"

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub limpiar()
        txt_dni.Clear()
        txt_dreccion.Clear()
        txt_nombre_y_apellido.Clear()
        txt_telefono.Clear()
    End Sub

    Public Sub mostrar_clientes()
        Try
            dt = class_clientes.motrar_clientes
            frm_clientes.datalistado_clientes.DataSource = dt
            frm_clientes.datalistado_clientes.EnableHeadersVisualStyles = False
            frm_clientes.datalistado_clientes.Columns(0).Visible = False

            If frm_clientes.datalistado_clientes.Rows.Count > 0 Then
                frm_clientes.datalistado_clientes.ContextMenuStrip = frm_clientes.c_menu_clientes
            Else
                frm_clientes.datalistado_clientes.ContextMenuStrip = Nothing
            End If

            For i = 1 To frm_clientes.datalistado_clientes.Columns.Count - 1 Step 1
                frm_clientes.datalistado_clientes.Columns(i).Width = 200
            Next
            home()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        Dim d As New DialogResult
        d = MessageBox.Show("¿Realmente decea registrar este cliente?", "Registro de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If d = DialogResult.Yes Then
            If txt_nombre_y_apellido.Text.Trim <> String.Empty Then

                If txt_telefono.Text.Trim <> String.Empty Then
                    If IsNumeric(txt_telefono.Text) Then

                        With obj_cliete
                            .nombre_y_apellido = txt_nombre_y_apellido.Text.ToUpper
                            .dni = txt_dni.Text
                            .direccion = txt_dreccion.Text
                            .telefono = txt_telefono.Text
                        End With
                        class_clientes.insertar_clientes(obj_cliete)
                        MessageBox.Show("Cliente registrado con exito", "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar_clientes()
                        mostrar_c()
                        limpiar()
                        Me.Close()
                    End If

                Else


                    With obj_cliete
                        .nombre_y_apellido = txt_nombre_y_apellido.Text.ToUpper
                        .dni = txt_dni.Text
                        .direccion = txt_dreccion.Text
                        .telefono = txt_telefono.Text
                    End With
                    class_clientes.insertar_clientes(obj_cliete)
                    MessageBox.Show("Cliente registrado con exito", "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar_clientes()
                    limpiar()
                    mostrar_c()
                    Me.Close()
                End If


            Else
                MessageBox.Show("El nombre de el cliente es obligatorio", "Registro de clietnes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click

        limpiar()
        Me.Close()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim d As New DialogResult
        d = MessageBox.Show("¿Realmente decea acrualizar este registro?", "Actualizando de registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If d = DialogResult.Yes Then
            If txt_nombre_y_apellido.Text.Trim <> String.Empty Then

                If txt_telefono.Text.Trim <> String.Empty Then
                    If IsNumeric(txt_telefono.Text) Then

                        With obj_cliete
                            .id_cliente = Val(lb_id_cliente.Text)
                            .nombre_y_apellido = txt_nombre_y_apellido.Text.ToUpper
                            .dni = txt_dni.Text
                            .direccion = txt_dreccion.Text
                            .telefono = txt_telefono.Text
                        End With
                        class_clientes.editar_cliente(obj_cliete)
                        MessageBox.Show("Registrado actualizado exito", "Actualizando de registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar_clientes()
                        limpiar()
                        mostrar_c()
                        Me.Close()
                    End If

                Else


                    With obj_cliete
                        .id_cliente = Val(lb_id_cliente.Text)
                        .nombre_y_apellido = txt_nombre_y_apellido.Text.ToUpper
                        .dni = txt_dni.Text
                        .direccion = txt_dreccion.Text
                        .telefono = txt_telefono.Text
                    End With
                    class_clientes.editar_cliente(obj_cliete)
                    MessageBox.Show("Registrado actualizado exito", "Actualizando de registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar_clientes()
                    limpiar()
                    mostrar_c()
                    Me.Close()
                End If


            Else
                MessageBox.Show("El nombre de el cliente es obligatorio", "Registro de clietnes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub


End Class