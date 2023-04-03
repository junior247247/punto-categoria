Public Class frmIngresoCouunt
    Private dt As New DataTable
    Private inventario As New class_inventario_prod
    Private objProd As New ce_prod
    Private class_producto As New class_producto


    Private Sub show()
        Try
            dt = inventario.mostrarInventario
            frm_productos.datalistado_inventory.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
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
        If txtCount.Text.Trim <> "" Then
            If IsNumeric(txtCount.Text) Then
                txtCount.Text = txtCount.Text.Replace(".", ",")
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
                    total = existencia + diferencia * pCompra
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
                    .idInventory = Val(lblIdInventory.Text)
                End With
                If dt.Rows.Count > 0 Then
                    inventario.updateInventario(objProd)

                Else
                    inventario.insertarInventario(objProd)
                End If
                Me.Close()
                paintCells()

            Else
                MessageBox.Show("Valor numerico no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debes de ingresar la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txtCount.Clear()
        Me.Close()
    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        create()
        show()
    End Sub
End Class