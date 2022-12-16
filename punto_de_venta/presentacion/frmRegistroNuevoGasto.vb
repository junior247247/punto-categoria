Public Class frmRegistroNuevoGasto
    Private objGasto As New ce_gastos
    Private classGasto As New class_gastos
    Private dt As New DataTable
    Private Sub limpiar()
        txt_description.Clear()
        txt_importe.Clear()
        txt_total_itbis.Clear()
        lbl_id.Text = "id"
        checkBoxCalcular.Checked = False
    End Sub

    Private Sub mostrarGastos()
        Try
            Dim sumaDeGastos = 0
            dt = classGasto.mostrarGastos
            frm_gastos.datalistado_gastos.DataSource = dt
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    sumaDeGastos += Convert.ToDecimal(dt.Rows(i).Item("Total_con_itbis"))
                Next
                frm_gastos.lblTotal.Text = Convert.ToString(sumaDeGastos)
            Else
                frm_gastos.lblTotal.Text = "0"
            End If


            frm_gastos.datalistado_gastos.EnableHeadersVisualStyles = False
            frm_gastos.datalistado_gastos.Columns(0).Visible = False
            For i = 0 To frm_gastos.datalistado_gastos.Columns.Count - 1
                frm_gastos.datalistado_gastos.Columns(i).Width = 200
            Next
            If frm_gastos.datalistado_gastos.Rows.Count > 0 Then
                frm_gastos.datalistado_gastos.ContextMenuStrip = frm_gastos.ContextMenuStrip1
            Else
                frm_gastos.datalistado_gastos.ContextMenuStrip = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub actualizarGasto()
        If txt_description.Text.Trim <> "" And txt_importe.Text.Trim <> "" And cboCategoria.Text.Trim <> "" Then
            If txt_total_itbis.Text.Trim = "" Then
                txt_total_itbis.Text = "0"
            End If
            If IsNumeric(txt_importe.Text.Trim) And IsNumeric(txt_total_itbis.Text.Trim) Then
                Dim importe As String = txt_importe.Text.Trim
                Dim totalItbis As String = txt_total_itbis.Text.Trim
                txt_importe.Text = importe.Replace(".", ",")
                txt_total_itbis.Text = totalItbis.Replace(".", ",")
                Dim totalGastoSinItbis As Decimal = importe - totalItbis
                With objGasto
                    .idGasto = Val(lbl_id.Text)
                    .description = txt_description.Text.ToUpper
                    .totalConItbis = importe
                    .totalSinItbis = totalGastoSinItbis
                    .itbisa = totalItbis
                    .categoria = cboCategoria.Text
                End With
                classGasto.ActualizarrGasto(objGasto)
                limpiar()
                mostrarGastos()
                MessageBox.Show("Registro actualizado con exito", "Registro de gasto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Valor numerico incorrecto", "Registro de gasto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("campos incompletos", "Registro de gasto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub crearGasto()
        If txt_description.Text.Trim <> "" And txt_importe.Text.Trim <> "" And cboCategoria.Text.Trim <> "" Then
            If txt_total_itbis.Text.Trim = "" Then
                txt_total_itbis.Text = "0"
            End If
            If IsNumeric(txt_importe.Text.Trim) And IsNumeric(txt_total_itbis.Text.Trim) Then
                Dim importe As String = txt_importe.Text.Trim
                Dim totalItbis As String = txt_total_itbis.Text.Trim
                txt_importe.Text = importe.Replace(".", ",")
                txt_total_itbis.Text = totalItbis.Replace(".", ",")
                Dim totalGastoSinItbis As Decimal = importe - totalItbis
                With objGasto
                    .description = txt_description.Text.ToUpper
                    .totalConItbis = importe
                    .totalSinItbis = totalGastoSinItbis
                    .itbisa = totalItbis
                    .fecha = Today.Date
                    .categoria = cboCategoria.Text
                End With
                classGasto.insertarGasto(objGasto)
                limpiar()
                mostrarGastos()
                MessageBox.Show("Gasto creado con exito", "Registro de gasto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Valor numerico incorrecto", "Registro de gasto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("campos incompletos", "Registro de gasto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If lbl_id.Text = "id" Then
            crearGasto()
        Else
            actualizarGasto()
        End If
    End Sub

    Private Sub checkBoxCalcular_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxCalcular.CheckedChanged
        If checkBoxCalcular.Checked Then
            txt_total_itbis.Enabled = True
        Else
            txt_total_itbis.Enabled = False
            txt_total_itbis.Clear()
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        limpiar()
        Me.Close()
    End Sub
End Class