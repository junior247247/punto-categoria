Public Class frm_ventas
    Private obj_vent As New ce_venta
    Private class_venta As New class_venta
    Private obj_producto As New ce_producto
    Private dt As New DataTable
    Private class_reporte As New class_reporte
    Public Sub verificar_si_no_se_vendieron_los_productos()
        Try
            dt = class_venta.verificar_si_no_esta_vendido
            If dt.Rows.Count > 0 Then
                Dim id_producto, id_venta As Integer
                Dim cantidad As Decimal
                For i = 0 To dt.Rows.Count - 1 Step 1
                    id_producto = dt.Rows(i).Item("id_producto")
                    cantidad = dt.Rows(i).Item("cantidad")
                    With obj_producto
                        .id_producto = Val(id_producto)
                        .cantidad = Convert.ToDecimal(cantidad)
                    End With
                    class_venta.aumentar_stock(obj_producto)

                Next
                id_venta = dt.Rows(0).Item("id_venta")
                class_venta.eliminar_todos_los_articulos(id_venta)
                MessageBox.Show("La venta no fue finalizada el stock no fue afectado", "Venta no finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub buscarPorFecha()
        Try
            Dim suma1, suma2, total As Decimal
            dt = class_venta.buscaVentasPorFecha(txtDesde.Text, txtHasta.Text)
            datalistado_ventas.DataSource = dt
            datalistado_ventas.EnableHeadersVisualStyles = False
            datalistado_ventas.Columns(0).Width = 100
            For i = 1 To datalistado_ventas.Columns.Count - 1 Step 1
                datalistado_ventas.Columns(i).Width = 190
            Next
            dt = class_venta.sumarBarPorFecha(txtDesde.Text, txtHasta.Text)
            If dt.Rows(0).Item("total").ToString <> "" Then
                lblTotalBar.Text = Parse.ToDecimal(dt.Rows(0).Item("total").ToString)
                suma1 = Convert.ToDecimal(dt.Rows(0).Item("total").ToString)
            Else
                suma1 = 0
                lblTotalBar.Text = "0"
            End If

            dt = class_venta.sumarGomeraPorFecha(txtDesde.Text, txtHasta.Text)
            If dt.Rows(0).Item("total").ToString <> "" Then
                lblTotalGomera.Text = Parse.ToDecimal(dt.Rows(0).Item("total").ToString)
                suma2 = Convert.ToDecimal(dt.Rows(0).Item("total").ToString)
            Else
                suma2 = 0
                lblTotalGomera.Text = "0"
            End If
            total = suma1 + suma2
            lblTotal.Text = Parse.ToDecimal(total)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub buscar()
        Try
            dt = class_venta.buscar_ventas_final(txt_buscar_venta.Text)
            datalistado_ventas.DataSource = dt
            datalistado_ventas.EnableHeadersVisualStyles = False
            datalistado_ventas.Columns(0).Width = 100
            For i = 1 To datalistado_ventas.Columns.Count - 1 Step 1
                datalistado_ventas.Columns(i).Width = 190
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mostrar()
        Try
            dt = class_venta.mostrar_venta_final
            datalistado_ventas.DataSource = dt
            datalistado_ventas.EnableHeadersVisualStyles = False
            datalistado_ventas.Columns(0).Width = 100
            For i = 1 To datalistado_ventas.Columns.Count - 1 Step 1
                datalistado_ventas.Columns(i).Width = 190
            Next

            If datalistado_ventas.Rows.Count > 0 Then
                datalistado_ventas.ContextMenuStrip = ContextMenuStrip1
            Else
                datalistado_ventas.ContextMenuStrip = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'verificar_si_no_se_vendieron_los_productos()
        mostrar()
    End Sub

    Private Sub btn_nueva_venta_Click(sender As Object, e As EventArgs) Handles btn_nueva_venta.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            obj_vent.fecha = Today.Date
            class_venta.insertar_venta(obj_vent)
            frm_punto_de_venta.ShowDialog()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_imprimir_ticket_Click(sender As Object, e As EventArgs) Handles btn_imprimir_ticket.Click
        Try
            Dim dt_verifica_si_tiene_rnc As New DataTable
            Dim dt_verificar_si_tiene_rnc_a_credito As New DataTable
            Dim id_venta As Integer = datalistado_ventas.SelectedCells.Item(0).Value
            dt_verifica_si_tiene_rnc = class_venta.verifiacar_si_lleva_rnc(id_venta)
            dt_verificar_si_tiene_rnc_a_credito = class_venta.verifiacar_si_lleva_rnc_con_credito(id_venta)

            If datalistado_ventas.Rows.Count > 0 Then
                Cursor = Cursors.WaitCursor
                dt = class_reporte.VERIFICAR_SI_EL_REPORTE_ES_ACREDITO(Val(datalistado_ventas.SelectedCells.Item(0).Value))
                If dt.Rows.Count > 0 Then
                    If dt_verificar_si_tiene_rnc_a_credito.Rows.Count > 0 Then
                        frm_reporte_con_rcn_y_a_credito.lbl_id_venta.Text = datalistado_ventas.SelectedCells.Item(0).Value
                        frm_reporte_con_rcn_y_a_credito.ShowDialog()
                        Me.Cursor = Cursors.Default
                    Else

                        frm_reporte_venta_a_creditos.lbl_id_venta.Text = datalistado_ventas.SelectedCells.Item(0).Value
                        frm_reporte_venta_a_creditos.ShowDialog()
                        Me.Cursor = Cursors.Default
                    End If
                Else
                    If dt_verifica_si_tiene_rnc.Rows.Count > 0 Then
                        frm_reporte_con_rnc.lbl_id_venta.Text = datalistado_ventas.SelectedCells.Item(0).Value
                        frm_reporte_con_rnc.ShowDialog()
                        Me.Cursor = Cursors.Default
                    Else
                        frm_reporte_venta.lbl_id_venta.Text = datalistado_ventas.SelectedCells.Item(0).Value
                        frm_reporte_venta.ShowDialog()
                        Me.Cursor = Cursors.Default
                    End If

                End If
            Else
                Cursor = Cursors.WaitCursor
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_buscar_venta_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_venta.TextChanged
        buscar()
    End Sub

    Private Sub btn_mantenimiento_Click(sender As Object, e As EventArgs) Handles btn_mantenimiento.Click
        frm_venta_liquido.ShowDialog()
    End Sub

    Private Sub btn_facturas_a_creditos_Click(sender As Object, e As EventArgs) Handles btn_facturas_a_creditos.Click
        frm_facturas_a_creditos.ShowDialog()
    End Sub

    Private Sub VERARTICULOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERARTICULOSToolStripMenuItem.Click
        Try
            If datalistado_ventas.Rows.Count > 0 Then
                frm_articulos.lbl_cliente.Text = datalistado_ventas.SelectedCells.Item(2).Value
                frm_articulos.lbl_id_factura.Text = datalistado_ventas.SelectedCells.Item(0).Value
                frm_articulos.lbl_pagado.Text = datalistado_ventas.SelectedCells.Item(7).Value
                frm_articulos.lbl_pendiente.Text = datalistado_ventas.SelectedCells.Item(6).Value
                frm_articulos.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDesde_ValueChanged(sender As Object, e As EventArgs) Handles txtDesde.ValueChanged
        buscarPorFecha()
    End Sub

    Private Sub txtHasta_ValueChanged(sender As Object, e As EventArgs) Handles txtHasta.ValueChanged
        buscarPorFecha()
    End Sub
End Class