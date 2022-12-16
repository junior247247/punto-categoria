Public Class frmIngresoAlmacen
    Private objalmacen As New ce_almacen
    Private almacen As New Almacen
    Private dt As New DataTable
    Public Sub mostrar_productos()
        Try
            dt = almacen.mostrarAlmacen
            frm_almacen.datalistado_productos.DataSource = dt
            frm_almacen.datalistado_productos.Columns(0).Visible = False
            frm_almacen.datalistado_productos.Columns(1).Visible = False
            frm_almacen.datalistado_productos.EnableHeadersVisualStyles = False
            If frm_almacen.datalistado_productos.Rows.Count > 0 Then
                frm_almacen.datalistado_productos.ContextMenuStrip = frm_almacen.c_menu_reabastecer
            Else
                frm_almacen.datalistado_productos.ContextMenuStrip = Nothing
            End If

            frm_almacen.datalistado_productos.Columns(2).Width = 270
            For i = 2 To frm_almacen.datalistado_productos.Columns.Count - 1 Step 1
                frm_almacen.datalistado_productos.Columns(i).Width = 200
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub crear()
        Try
            If txtProducto.Text.Trim <> "" Then
                If txtUnidad.Text = "" Then txtUnidad.Text = "1"
                If IsNumeric(txtCantidad.Text) And IsNumeric(txtUnidad.Text) Then
                    Dim d As New DialogResult
                    d = MessageBox.Show("Realmente deceas realizar este registro", "Registro almacen", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If d = DialogResult.Yes Then

                        dt = almacen.mostrarAlmacenPorIdProducto(Val(lblId.Text))

                        If lblIdAlmacen.Text <> "id" Then

                            With objalmacen
                                .id = Val(lblIdAlmacen.Text)
                                .cantidad = txtCantidad.Text
                                .idProducto = Val(lblId.Text)
                                .und = Val(txtCantidad.Text) * Val(txtUnidad.Text)
                                .lote = cboTipo.Text
                            End With
                            almacen.actualizarAlmacen(objalmacen)
                        Else
                            If dt.Rows.Count > 0 Then
                                With objalmacen
                                    .id = Val(lblIdAlmacen.Text)
                                    .cantidad = txtCantidad.Text
                                    .idProducto = Val(lblId.Text)
                                    .und = Val(txtCantidad.Text) * Val(txtUnidad.Text)
                                    .lote = cboTipo.Text
                                End With
                                almacen.actualizarAlmacen(objalmacen)
                            Else
                                With objalmacen
                                    .cantidad = txtCantidad.Text
                                    .idProducto = Val(lblId.Text)
                                    .und = Val(txtCantidad.Text) * Val(txtUnidad.Text)
                                    .lote = cboTipo.Text
                                End With
                                almacen.insertarAlmacen(objalmacen)
                            End If

                        End If
                        lblIdAlmacen.Text = "id"
                        txtCantidad.Clear()
                        txtProducto.Clear()
                        txtUnidad.Clear()
                        txtProducto.Clear()
                        mostrar_productos()
                        MessageBox.Show("Registro Ingresado Con Exito", "Registro almacen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("valor numerico no valido", "Registro almacen", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Debes seleccionar el producto", "Registro almacen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txtCantidad.Clear()
        txtProducto.Clear()
        txtUnidad.Clear()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmBuscarProductoAlmacen.ShowDialog()
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If cboTipo.Text = "LOTE" Then
            txtCantidad.Enabled = True
            txtUnidad.Enabled = True
        ElseIf cboTipo.Text = "UND" Then
            txtCantidad.Enabled = True
            txtUnidad.Enabled = False
        Else
            txtUnidad.Enabled = False
            txtCantidad.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        crear()
    End Sub
End Class