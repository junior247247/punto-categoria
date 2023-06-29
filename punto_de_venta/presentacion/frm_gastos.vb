Public Class frm_gastos
    Private classGastos As New class_gastos
    Private dt As New DataTable

    'mostrar_gastos_por_fechaConCategoria




    Private Sub mostrar_gastos_por_fechaConCategoria()
        Try
            Dim sumaDeGastos = 0
            dt = classGastos.mostrar_gastos_por_fechaConCategoria(txtfecha1.Text, txtfecha2.Text, cboCategoria.Text)
            datalistado_gastos.DataSource = dt
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    sumaDeGastos += Convert.ToDecimal(dt.Rows(i).Item("Total_con_itbis"))
                Next
                lblTotal.Text = ParseToDecimal.parse(Convert.ToString(sumaDeGastos))
            Else
                lblTotal.Text = "0"
            End If
            datalistado_gastos.EnableHeadersVisualStyles = False
            datalistado_gastos.Columns(0).Visible = False
            For i = 0 To datalistado_gastos.Columns.Count - 1
                datalistado_gastos.Columns(i).Width = 200
            Next
            If datalistado_gastos.Rows.Count > 0 Then
                datalistado_gastos.ContextMenuStrip = ContextMenuStrip1
            Else
                datalistado_gastos.ContextMenuStrip = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub filtrarGastosPorFecha()
        Try
            Dim sumaDeGastos = 0
            dt = classGastos.mostrar_gastos_por_fecha(txtfecha1.Text, txtfecha2.Text)
            datalistado_gastos.DataSource = dt
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    sumaDeGastos += Convert.ToDecimal(dt.Rows(i).Item("Total_con_itbis"))
                Next
                lblTotal.Text = ParseToDecimal.parse(Convert.ToString(sumaDeGastos))
            Else
                lblTotal.Text = "0"
            End If
            datalistado_gastos.EnableHeadersVisualStyles = False
            datalistado_gastos.Columns(0).Visible = False
            For i = 0 To datalistado_gastos.Columns.Count - 1
                datalistado_gastos.Columns(i).Width = 200
            Next
            If datalistado_gastos.Rows.Count > 0 Then
                datalistado_gastos.ContextMenuStrip = ContextMenuStrip1
            Else
                datalistado_gastos.ContextMenuStrip = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub mostrarGastos()
        Try
            Dim sumaDeGastos As Decimal = 0
            dt = classGastos.mostrarGastos
            datalistado_gastos.DataSource = dt
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    sumaDeGastos += Convert.ToDecimal(dt.Rows(i).Item("Total_con_itbis"))
                Next
                lblTotal.Text = ParseToDecimal.parse(Convert.ToString(sumaDeGastos))
            Else
                lblTotal.Text = "0"
            End If
            datalistado_gastos.EnableHeadersVisualStyles = False
            datalistado_gastos.Columns(0).Visible = False
            For i = 0 To datalistado_gastos.Columns.Count - 1
                datalistado_gastos.Columns(i).Width = 200
            Next
            If datalistado_gastos.Rows.Count > 0 Then
                datalistado_gastos.ContextMenuStrip = ContextMenuStrip1
            Else
                datalistado_gastos.ContextMenuStrip = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnRegistrarNuevoGasto_Click(sender As Object, e As EventArgs) Handles btnRegistrarNuevoGasto.Click
        frmRegistroNuevoGasto.ShowDialog()
    End Sub

    Private Sub frm_gastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarGastos()
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Dim d As New DialogResult
        d = MessageBox.Show("Realmente deceas eliminar este registro", "Eliminando Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If d = DialogResult.Yes Then
            Dim idGasto As Integer = datalistado_gastos.SelectedCells.Item(0).Value
            classGastos.eliminarGasto(idGasto)
            MessageBox.Show("Registro eliminado con exito", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mostrarGastos()
        End If
    End Sub

    Private Sub EDITARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITARToolStripMenuItem.Click
        frmRegistroNuevoGasto.lbl_id.Text = datalistado_gastos.SelectedCells.Item(0).Value
        frmRegistroNuevoGasto.txt_description.Text = datalistado_gastos.SelectedCells.Item(1).Value
        frmRegistroNuevoGasto.txt_total_itbis.Text = datalistado_gastos.SelectedCells.Item(5).Value
        frmRegistroNuevoGasto.txt_importe.Text = datalistado_gastos.SelectedCells.Item(3).Value
        frmRegistroNuevoGasto.ShowDialog()
    End Sub

    Private Sub txtfecha1_ValueChanged(sender As Object, e As EventArgs) Handles txtfecha1.ValueChanged
        If cboCategoria.Text = "TODOS" Then
            filtrarGastosPorFecha()

        Else
            mostrar_gastos_por_fechaConCategoria()
        End If
    End Sub

    Private Sub txtfecha2_ValueChanged(sender As Object, e As EventArgs) Handles txtfecha2.ValueChanged
        If cboCategoria.Text = "TODOS" Then
            filtrarGastosPorFecha()

        Else
            mostrar_gastos_por_fechaConCategoria()
        End If
    End Sub

    Private Sub btnExportaraexcell_Click(sender As Object, e As EventArgs) Handles btnExportaraexcell.Click
        Me.Cursor = Cursors.WaitCursor
        classGastos.llenarExcel(datalistado_gastos)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim totalConItbis, totalSinItbis, totalItbis As Decimal

        dt = classGastos.sumarGastos(txtfecha1.Text, txtfecha2.Text)
        If dt.Rows.Count > 0 Then
            Me.Cursor = Cursors.WaitCursor
            For i = 0 To dt.Rows.Count - 1 Step 1
                totalConItbis += Convert.ToDecimal(dt.Rows(i).Item("Total_con_itbis"))
                totalItbis += Convert.ToDecimal(dt.Rows(i).Item("itbis"))
                totalSinItbis += Convert.ToDecimal(dt.Rows(i).Item("Total_sin_itbis"))
            Next
            Dim objRpoerte As New ce_reporte_gasto
            With objRpoerte
                .fechaDesde = txtfecha1.Text
                .fechaHasta = txtfecha2.Text
                .totalConItbis = totalConItbis
                .totalSinItbis = totalSinItbis
                .sumaDeItbis = totalItbis
            End With
            classGastos.insertarTotalSumaGastos(objRpoerte)
            frmReporteGastos.lblfechaDesde.Text = txtfecha1.Text
            frmReporteGastos.lblFechaHasta.Text = txtfecha2.Text
            frmReporteGastos.ShowDialog()
            Me.Cursor = Cursors.Default
        Else
            MessageBox.Show("No hay registros disponibles para las fechas selecionadas", "Imprimir gasto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged
        If cboCategoria.Text = "TODOS" Then
            filtrarGastosPorFecha()

        Else
            mostrar_gastos_por_fechaConCategoria()
        End If
    End Sub
End Class