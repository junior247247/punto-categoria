Public Class frm_histtorial_de_compras

    Private dt As New DataTable
    Private class_prodcuto As New class_proveedor
    Private class_producto As New class_producto
    Private class_invenntario As New class_inventario


    Public Sub mostrar_nventario()
        Try
            dt = class_invenntario.compras_de_la_semana
            frm_inventario.lbl_compras_de_la_semana.Text = dt.Rows(0).Item("total_compras").ToString
            If frm_inventario.lbl_compras_de_la_semana.Text = String.Empty Then
                frm_inventario.lbl_compras_de_la_semana.Text = "0.00"
            End If

            dt = class_invenntario.compras_del_mes
            frm_inventario.lbl_compras_del_mes.Text = dt.Rows(0).Item("total_compras_del_mes").ToString
            If frm_inventario.lbl_compras_del_mes.Text = String.Empty Then
                frm_inventario.lbl_compras_del_mes.Text = "0.00"
            End If

            dt = class_invenntario.ganancias_de_la_semana
            frm_inventario.lbl_ganancias_de_la_semana.Text = dt.Rows(0).Item("total_ganancias_de_la_Semana").ToString
            If frm_inventario.lbl_ganancias_de_la_semana.Text = String.Empty Then
                frm_inventario.lbl_ganancias_de_la_semana.Text = "0.00"
            End If

            dt = class_invenntario.ganancias_del_mes
            frm_inventario.lbl_ganancias_del_mes.Text = dt.Rows(0).Item("total_ganancias_del_mes").ToString
            If frm_inventario.lbl_ganancias_del_mes.Text = String.Empty Then
                frm_inventario.lbl_ganancias_del_mes.Text = "0.00"
            End If

            dt = class_invenntario.ventas_de_la_semana
            frm_inventario.lbl_ventas_de_la_semana.Text = dt.Rows(0).Item("ventas_de_la_semana").ToString
            If frm_inventario.lbl_ventas_de_la_semana.Text = String.Empty Then
                frm_inventario.lbl_ventas_de_la_semana.Text = "0.00"
            End If

            dt = class_invenntario.ventas_del_mes
            frm_inventario.lbl_ventas_del_mes.Text = dt.Rows(0).Item("ventas_del_mes").ToString
            If frm_inventario.lbl_ventas_del_mes.Text = String.Empty Then
                frm_inventario.lbl_ventas_del_mes.Text = "0.00"
            End If

            dt = class_invenntario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                frm_inventario.lbl_dinero_en_caja.Text = dt.Rows(0).Item("dinero_en_caja").ToString
            End If

            If frm_inventario.lbl_dinero_en_caja.Text = String.Empty Then
                frm_inventario.lbl_dinero_en_caja.Text = "0.00"
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub home()
        Try




            dt = class_invenntario.sumar_ventas_del_mes
            If dt.Rows.Count > 0 Then
                frm_home.lbl_compras_del_mes.Text = "RD$ " + dt.Rows(0).Item("compras_del_mes").ToString


            End If

            If frm_home.lbl_compras_del_mes.Text = "RD$ " Then
                frm_home.lbl_compras_del_mes.Text = "RD$ 0.00"
            End If


            dt = class_producto.mostrar_productos_en_punto_de_reorden
            frm_home.lbl_productos_en_punto_de_reorden.Text = dt.Rows.Count
            If frm_home.lbl_productos_en_punto_de_reorden.Text = String.Empty Then
                frm_home.lbl_productos_en_punto_de_reorden.Text = "0"
            End If


            dt = class_invenntario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                frm_home.lbl_dinero_en_caja.Text = "RD$ " + dt.Rows(0).Item("dinero_en_caja").ToString
            Else
                frm_home.lbl_dinero_en_caja.Text = "RD$ 0.00"
            End If
            dt = class_invenntario.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                frm_home.lbl_ventas_del_dia.Text = "RD$ " + dt.Rows(0).Item("ventas_del_dia").ToString
            Else
                frm_home.lbl_ventas_del_dia.Text = "RD$ 0.00"
            End If
            If frm_home.lbl_ventas_del_dia.Text = "RD$ " Then

                frm_home.lbl_ventas_del_dia.Text = "RD$ 0.00"
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub buscar_por_codigo_de_barra_historial()
        Try
            Dim total As Decimal
            dt = class_prodcuto.buscar_hostorial_de_compras_por_codigos_dE_barra(txtfecha_1.Text, txt_fecha_2.Text, txt_producto.Text)
            datalistado_productos.DataSource = dt
            datalistado_productos.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 200
            Next
            For i = 0 To datalistado_productos.Rows.Count - 1 Step 1
                total += datalistado_productos.Rows(i).Cells("Importe").Value
            Next
            lbl_total.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub buscar()
        Try
            Dim total As Decimal
            dt = class_prodcuto.buscar_hostorial_de_compras(txtfecha_1.Text, txt_fecha_2.Text)
            datalistado_productos.DataSource = dt
            datalistado_productos.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 200
            Next
            For i = 0 To datalistado_productos.Rows.Count - 1 Step 1
                total += datalistado_productos.Rows(i).Cells("Importe").Value


            Next
            lbl_total.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mostrar()
        Try
            Dim total As Decimal
            dt = class_prodcuto.mostrar_hostorial_de_compras
            datalistado_productos.DataSource = dt
            datalistado_productos.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_productos.Columns.Count - 1 Step 1
                datalistado_productos.Columns(i).Width = 200
            Next
            For i = 0 To datalistado_productos.Rows.Count - 1 Step 1
                total += datalistado_productos.Rows(i).Cells("Importe").Value
            Next
            If datalistado_productos.Rows.Count > 0 Then
                datalistado_productos.ContextMenuStrip = ContextMenuStrip1
            Else
                datalistado_productos.ContextMenuStrip = Nothing
            End If
            lbl_total.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub frm_histtorial_de_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub



    Private Sub txtfecha_1_ValueChanged(sender As Object, e As EventArgs) Handles txtfecha_1.ValueChanged
        buscar()
    End Sub

    Private Sub txt_fecha_2_ValueChanged(sender As Object, e As EventArgs) Handles txt_fecha_2.ValueChanged
        buscar()
    End Sub

    Private Sub txt_producto_TextChanged(sender As Object, e As EventArgs) Handles txt_producto.TextChanged
        buscar_por_codigo_de_barra_historial()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim d As New DialogResult
        d = MessageBox.Show("REALMENTE DECEAS ELIMINAR ESTA COMPRA", "Eliminando registro de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If d = DialogResult.Yes Then
            Dim id As Integer = datalistado_productos.SelectedCells.Item(0).Value
            class_prodcuto.eliminar_compra(id)
            mostrar()
            mostrar_nventario()
            home()
            MessageBox.Show("Compra eliminada con exito", "Elimando registro de compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class