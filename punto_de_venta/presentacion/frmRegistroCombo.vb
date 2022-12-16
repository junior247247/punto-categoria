Public Class frmRegistroCombo
    Private dt As New DataTable
    Private classCombo As New classCombo
    Private objCombo As New ceCombo
    Private obj_producto As New ce_producto
    Private class_producto As New class_producto


    Public Sub mostrar_productos()
        Try
            dt = class_producto.mostrar_productos
            frm_productos.datalistado_productos.DataSource = dt
            frm_productos.datalistado_productos.Columns(0).Visible = False
            frm_productos.datalistado_productos.Columns(11).Visible = False
            frm_productos.datalistado_productos.EnableHeadersVisualStyles = False
            If frm_productos.datalistado_productos.Rows.Count > 0 Then
                frm_productos.datalistado_productos.ContextMenuStrip = frm_productos.c_menu_productos
            Else
                frm_productos.datalistado_productos.ContextMenuStrip = Nothing
            End If

            frm_productos.datalistado_productos.Columns(1).Width = 270
            For i = 2 To frm_productos.datalistado_productos.Columns.Count - 1 Step 1
                frm_productos.datalistado_productos.Columns(i).Width = 100
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrarCombo()
        Try
            dt = classCombo.mostrarProductoSCombo
            datalistado_articulos.DataSource = dt
            datalistado_articulos.EnableHeadersVisualStyles = False
            datalistado_articulos.Columns(1).Visible = False
            datalistado_articulos.Columns(0).Visible = False
            If datalistado_articulos.Rows.Count > 0 Then
                datalistado_articulos.ContextMenuStrip = ContextMenuStrip1
            Else
                datalistado_articulos.ContextMenuStrip = Nothing
            End If

            For i = 0 To datalistado_articulos.Columns.Count() - 1 Step 1
                datalistado_articulos.Columns(i).Width = 180
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmRegistroCombo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarCombo()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        lbidProducto.Text = ""
        txtCantidad.Clear()
        txtDescription.Clear()
        lblDescription.Text = "DESCRIPTION: "
        txtPrecio.Clear()

        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim id As Integer = datalistado_articulos.SelectedCells.Item(0).Value
        classCombo.elimiarComboSelecion(id)
        mostrarCombo()
    End Sub
    Private Sub createCombo()
        Dim ms As New IO.MemoryStream
        If Not pciture_producto.Image Is Nothing Then
            pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

        Else
            pciture_producto.Image = My.Resources.SIN_IMAGEN
            pciture_producto.Image.Save(ms, pciture_producto.Image.RawFormat)

        End If
        Dim ganacias As Decimal
        dt = classCombo.mostrarProductoSCombo()
        Dim PrecioTotal As Decimal = Convert.ToDecimal(txtPrecio.Text)
        Dim PVenta As Decimal

        'PVenta = PrecioTotal / dt.Rows.Count

        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1 Step 1
                Dim idProducto As Integer = Convert.ToInt32(dt.Rows(i).Item("id_producto").ToString)
                Dim cantidad As Decimal = Convert.ToDecimal(dt.Rows(i).Item("CANTIDAD").ToString)
                Dim dtComboProduc = classCombo.selecionarProducto(idProducto)

                If dtComboProduc.Rows.Count > 0 Then
                    Dim PVentas As Decimal = Convert.ToDecimal(dtComboProduc.Rows(0).Item("Precio_de_Venta").ToString)
                    Dim PCompra As Decimal = Convert.ToDecimal(dtComboProduc.Rows(0).Item("Precio_de_Compra").ToString)

                    ganacias += PCompra * cantidad
                End If
            Next
        End If
        ganacias = PrecioTotal - ganacias
        With obj_producto
            .ganancia_por_precio_al_pormayor = ganacias
            .codigo_de_barra = ""
            .description = txtDescription.Text.ToUpper
            .se_vende_por = "Por Unidad/Pieza"
            .precio_de_compra = Convert.ToDecimal(txtPrecio.Text)
            .precio_de_venta = Convert.ToDecimal(txtPrecio.Text)
            .precio_mayoreo = Convert.ToDecimal(txtPrecio.Text)
            .cantida_por_mayoreo = Convert.ToDecimal(10)
            .categorias = "ABARROTE"
            .cantidad = Convert.ToDecimal(10)
            .fecha_de_vencieminto = "No aplica"
            .gimagen = ms.GetBuffer
            .ganancias = ganacias
            .punto_de_reorden = Val(0)
            .itbis = Convert.ToDecimal(0)
            .precio_con_descuento = Convert.ToDecimal(txtPrecio.Text)
            .descuento_activo = "DESACTIVADO"
        End With
        class_producto.insertar_producto(obj_producto)
        mostrar_productos()
        dt = classCombo.mostrarProductoAcendente
        Dim idProductoFinal As Integer = Val(dt.Rows(0).Item("id_producto").ToString)
        classCombo.updateIdCombo(idProductoFinal)
        ganacias = 0
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If lbidProducto.Text <> "" Then
            If lblDescription.Text <> "" Then
                If txtCantidad.Text = "" Then
                    txtCantidad.Text = "1"
                End If
                If IsNumeric(txtCantidad.Text) Then
                    If Convert.ToDecimal(txtCantidad.Text) > 0 Then
                        dt = classCombo.verificarSiEstaElproductoEncombo(Val(lbidProducto.Text))
                        If dt.Rows.Count = 0 Then
                            With objCombo
                                .idCombo = 0
                                .idProducto = Val(lbidProducto.Text)
                                .cantidad = Convert.ToDecimal(txtCantidad.Text)
                            End With
                            classCombo.insertarCombo(objCombo)
                            mostrarCombo()
                            lbidProducto.Text = ""

                            txtCantidad.Clear()
                        End If


                    Else
                        MessageBox.Show("la cantidad de el combo tiene que ser mayor que cero", "Registro De Combo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Else
                        MessageBox.Show("valor numerico no valido", "Registro De Combo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Producto no seleccionado", "Registro De Combo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Producto no seleccionado", "Registro De Combo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub



    Private Sub btnGuardarCombo_Click(sender As Object, e As EventArgs) Handles btnGuardarCombo.Click
        If datalistado_articulos.Rows.Count > 0 Then
            createCombo()
            lblDescription.Text = "DESCRIPTION: "
            txtPrecio.Clear()
            txtCantidad.Clear()
            txtDescription.Clear()
            MessageBox.Show("COMBO REGISTRADO CON EXITO", "REGISTRO DE COMBO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mostrar_productos()
            Me.Close()

        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBuscarParaCombos.ShowDialog()
    End Sub

    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtPrecio.Select()
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If datalistado_articulos.Rows.Count > 0 Then
                createCombo()
                lblDescription.Text = "DESCRIPTION: "
                txtPrecio.Clear()
                txtCantidad.Clear()
                txtDescription.Select()
                MessageBox.Show("COMBO REGISTRADO CON EXITO", "REGISTRO DE COMBO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar_productos()
                Me.Close()
            End If

        End If
    End Sub


End Class