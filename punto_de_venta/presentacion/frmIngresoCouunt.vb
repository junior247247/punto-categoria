Public Class frmIngresoCouunt
    Private dt As New DataTable
    Private inventario As New class_inventario_prod
    Private objProd As New ce_prod
    Private class_producto As New class_producto

    Private Sub paintCells()

        Dim dt = class_producto.mostrar_productos
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1 Step 1

                Dim id As Integer = Convert.ToInt32(frm_productos.datalistado_productos.Rows(i).Cells("id_producto").Value)


                dt = inventario.getProdByCount(id)
                If dt.Rows.Count > 0 Then
                    Dim row As DataGridViewRow = frm_productos.datalistado_productos.Rows(i)
                    Dim cell As DataGridViewCell = frm_productos.datalistado_productos.Rows(i).Cells(0)
                    row.DefaultCellStyle.BackColor = Color.Honeydew
                    row.DefaultCellStyle.ForeColor = Color.Black


                Else
                    Dim row As DataGridViewRow = frm_productos.datalistado_productos.Rows(i)
                    Dim cell As DataGridViewCell = frm_productos.datalistado_productos.Rows(i).Cells(0)
                    row.DefaultCellStyle.BackColor = Color.Red
                    row.DefaultCellStyle.ForeColor = Color.White
                End If
            Next

        End If





    End Sub

    Private Sub create()
        dt = inventario.getProdByCount(Val(lblid.Text))
        Dim dtProd As New DataTable
        dtProd = inventario.getProdById(Val(lblid.Text))
        Dim diferencia As Decimal
        Dim counte = Convert.ToDecimal(txtCount.Text)
        Dim existencia, pCompra, importe, total, restante As Decimal
        existencia = Convert.ToDecimal(dtProd.Rows(0).Item("Cantidad").ToString)
        pCompra = Convert.ToDecimal(dtProd.Rows(0).Item("Precio_de_Compra").ToString)

        If counte >= existencia Then
            diferencia = counte - existencia
            restante = pCompra * diferencia
            total = existencia * pCompra
            'MsgBox(total)
        Else
            diferencia = existencia - counte
            restante = pCompra * -diferencia
            total = existencia * pCompra
            'MsgBox(total)
        End If


        With objProd
            .cantidad = txtCount.Text
            .idProducto = Val(lblid.Text)
            .cantidad = txtCount.Text
            .direfencia = diferencia
            .importe = restante
            .total = total
        End With
        If dt.Rows.Count > 0 Then
            inventario.updateInventario(objProd)

        Else
            inventario.insertarInventario(objProd)
        End If
        Me.Close()
        paintCells()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txtCount.Clear()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtExits.TextChanged

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        create()
    End Sub
End Class