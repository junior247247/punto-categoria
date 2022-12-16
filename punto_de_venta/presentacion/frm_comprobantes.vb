Public Class frm_comprobantes
    Protected obj_comprobante As New Ce_comprobantes
    Protected class_comprobante As New Class_comprobantes
    Protected dt As New DataTable
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_desde.Clear()
        txt_hasta.Clear()
        Me.Close()
    End Sub
    Public Sub mostar()
        Try
            dt = class_comprobante.seleccionar_ultimo_comprobante
            If dt.Rows.Count > 0 Then
                txt_ultimo_disponible.Text = dt.Rows(0).Item("ultimo_comprobante").ToString
            Else
                txt_ultimo_disponible.Text = "0"
            End If
            dt = class_comprobante.numeros_de_comprobantes
            lbl_numeor_de_comprobantes_disponibles.Text = dt.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_agregar_comprobantes_Click(sender As Object, e As EventArgs) Handles btn_agregar_comprobantes.Click

        If txt_desde.Text.Trim <> String.Empty And txt_hasta.Text.Trim <> String.Empty Then
            If Val(txt_desde.Text) > Val(txt_ultimo_disponible.Text) Then

                Dim i As Integer = Val(txt_desde.Text)
                While (i <= Val(txt_hasta.Text))
                    With obj_comprobante
                        .comprobante = i
                    End With
                    class_comprobante.insertar_comprobantes(obj_comprobante)
                    i += 1
                End While


                dt = class_comprobante.seleccionar_ultimo_comprobante
                If dt.Rows.Count > 0 Then
                    Dim id_ultimo_comprobante As Integer = dt.Rows(0).Item("id_ultimo_comprobante")
                    i = i - 1
                    With obj_comprobante
                        .id_comprobante = id_ultimo_comprobante
                        .comprobante = i
                    End With
                    class_comprobante.actualizar_ultimo_disponible(obj_comprobante)
                Else
                    i = i - 1
                    With obj_comprobante
                        .comprobante = i
                    End With
                    class_comprobante.insertar_ultimo_comprobante(obj_comprobante)
                End If

                If dt.Rows.Count > 0 Then
                    txt_ultimo_disponible.Text = dt.Rows(0).Item("ultimo_comprobante").ToString
                Else
                    txt_ultimo_disponible.Text = "0"
                End If
                dt = class_comprobante.numeros_de_comprobantes
                lbl_numeor_de_comprobantes_disponibles.Text = dt.Rows.Count
                dt = class_comprobante.seleccionar_ultimo_comprobante

                txt_ultimo_disponible.Text = dt.Rows(0).Item("ultimo_comprobante").ToString
                MessageBox.Show("Numeros de comprobantes ingresados con exito", "Registro de comprobantes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_desde.Clear()
                txt_hasta.Clear()
            Else
                MessageBox.Show("No puedes ingresar el ultimo numero de comprobante usado", "Registro de comprobantes", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else
            MessageBox.Show("Datos incompletos", "Registro de comprobantes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub frm_comprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostar()
        txt_desde.Select()
    End Sub

    Private Sub txt_desde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_desde.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_hasta.Select()
        End If
    End Sub

    Private Sub txt_hasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_hasta.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btn_agregar_comprobantes.Select()
        End If
    End Sub
End Class