Public Class frm_reabastecer
    Private dt As New DataTable
    Private obj_producto As New ce_producto
    Private class_producto As New class_producto
    Private almacen As New Almacen



    Private Sub showAlmacenData()
        Try
            dt = almacen.mostrarAlmacenPorIdProducto(Val(lbl_id_producto.Text))
            txtAlmacen.Text = dt.Rows(0).Item("Und").ToString
            lbl_producto.Text = dt.Rows(0).Item("Descripcion").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub home()
        Try



            dt = class_producto.mostrar_productos_en_punto_de_reorden
            frm_home.lbl_productos_en_punto_de_reorden.Text = dt.Rows.Count
            If frm_home.lbl_productos_en_punto_de_reorden.Text = String.Empty Then
                frm_home.lbl_productos_en_punto_de_reorden.Text = "0"
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub








    Public Sub mostrar_productos_almacen()
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

            frm_almacen.datalistado_productos.Columns(1).Width = 270
            For i = 2 To frm_almacen.datalistado_productos.Columns.Count - 1 Step 1
                frm_almacen.datalistado_productos.Columns(i).Width = 100
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub







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


    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_reabastecer.Clear()
        Me.Close()
    End Sub

    Private Sub btn_reabastecer_Click(sender As Object, e As EventArgs) Handles btn_reabastecer.Click
        Dim d As New DialogResult
        d = MessageBox.Show("¿Deceas reabastecer este producto con la cantidad de: " + txt_reabastecer.Text + " ?", "Reabastecer producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If d = DialogResult.Yes Then
            If txt_reabastecer.Text.Trim <> String.Empty Then
                If IsNumeric(txt_reabastecer.Text) Then
                    If Val(txt_reabastecer.Text) <= Val(txtAlmacen.Text) Then


                        With obj_producto
                            .id_producto = Val(lbl_id_producto.Text)
                            .cantidad = Val(txt_reabastecer.Text)
                        End With
                        class_producto.reabastecer_por_id(obj_producto)
                        almacen.restarAlmacen(Val(lbl_id_producto.Text), Val(txt_reabastecer.Text))
                        mostrar_productos_almacen()
                        mostrar_productos()
                        home()
                        MessageBox.Show("Producto reabastecido", "Reabastecer producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txt_reabastecer.Clear()
                        Me.Close()
                    Else
                        MessageBox.Show("La cantidad ingresad supera el monto en almacen", "Reabastecer producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Valor numero incorrecto", "Reabastecer producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Ingrese el numero de producto a reabastecer", "Reabastecer producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub frm_reabastecer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showAlmacenData()
    End Sub
End Class