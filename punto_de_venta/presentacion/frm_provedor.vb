Public Class frm_provedor

    Private obj_prov As New ce_proveedor
    Private class_proveedor As New class_proveedor
    Private dt As New DataTable


    Public Sub home()
        Try


            dt = class_proveedor.mostrar_proveedores
            frm_home.lbl_proveedores.Text = dt.Rows.Count
            If frm_home.lbl_proveedores.Text = String.Empty Then
                frm_home.lbl_proveedores.Text = "0"
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub cargar_proveedores()
        Try
            frm_compras.cbo_proveedor.DropDownStyle = 2
            frm_compras.cbo_comprobante.DropDownStyle = 2
            frm_compras.cbo_tipo_de_ingreso.DropDownStyle = 2
            dt = class_proveedor.mostrar_proveedores
            If dt.Rows.Count > 0 Then
                frm_compras.cbo_proveedor.Items.Clear()


                For i = 0 To dt.Rows.Count - 1 Step 1
                    frm_compras.cbo_proveedor.Items.Add(dt.Rows(i).Item("nombre_o_razon_social").ToString)
                Next
            Else
                frm_compras.cbo_proveedor.Items.Clear()
                frm_compras.cbo_proveedor.Text = "PROVEEDOR"
                frm_compras.cbo_proveedor.Items.Add("PROVEEDOR")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub limpiar()
        txt_nombre_o_razon_social.Clear()
        txt_numero_de_doc.Clear()
        txt_telefono.Clear()
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim d As New DialogResult
        d = MessageBox.Show("¿Deceas registrar este proveedor?", "Registro de proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If d = DialogResult.Yes Then
            If txt_nombre_o_razon_social.Text.Trim <> String.Empty And txt_numero_de_doc.Text.Trim <> String.Empty And txt_telefono.Text.Trim <> String.Empty Then
                If IsNumeric(txt_telefono.Text) Then
                    With obj_prov
                        .nombre_o_razon_social = txt_nombre_o_razon_social.Text.ToUpper
                        .tipo_de_doc = cbo_tipo_de_documento.Text.ToUpper
                        .numero_doc = txt_numero_de_doc.Text
                        .telefono = txt_telefono.Text
                    End With
                    class_proveedor.insertar_proveedores(obj_prov)
                    MessageBox.Show("Proveedor registrado con exito", "Registro de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    home()
                    cargar_proveedores()
                Else
                    MessageBox.Show("Numero de telefono incorrecto", "Registro de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Datos incompletos", "Registro de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub frm_provedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_tipo_de_documento.DropDownStyle = 2
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim d As New DialogResult
        d = MessageBox.Show("¿Deceas actualizar este proveedor?", "Actualizando proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If d = DialogResult.Yes Then
            If txt_nombre_o_razon_social.Text.Trim <> String.Empty And txt_numero_de_doc.Text.Trim <> String.Empty And txt_telefono.Text.Trim <> String.Empty Then
                If IsNumeric(txt_telefono.Text) Then
                    With obj_prov
                        .id_proveedore = Val(lbl_id_proveedor.Text)
                        .nombre_o_razon_social = txt_nombre_o_razon_social.Text.ToUpper
                        .tipo_de_doc = cbo_tipo_de_documento.Text.ToUpper
                        .numero_doc = txt_numero_de_doc.Text
                        .telefono = txt_telefono.Text
                    End With
                    class_proveedor.editar_proveedor(obj_prov)
                    MessageBox.Show("Proveedor actualizado con exito", "Actualizando proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btn_editar.Visible = False
                    btn_guardar.Visible = True
                    limpiar()
                    home()
                Else
                    MessageBox.Show("Numero de telefono incorrecto", "Actualizando proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Datos incompletos", "Actualizando proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_lista_de_proveedores_Click(sender As Object, e As EventArgs) Handles btn_lista_de_proveedores.Click
        frm_lista_de_proveedores.ShowDialog()
    End Sub

    Private Sub txt_nombre_o_razon_social_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_o_razon_social.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then

            cbo_tipo_de_documento.Select()
        End If
    End Sub

    Private Sub cbo_tipo_de_documento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_tipo_de_documento.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_numero_de_doc.Select()

        End If
    End Sub

    Private Sub txt_numero_de_doc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero_de_doc.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_telefono.Select()

        End If
    End Sub

    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If btn_guardar.Visible = True Then
                btn_guardar.Select()
            ElseIf btn_editar.Visible = True Then
                btn_editar.Select()
            End If


        End If
    End Sub


End Class