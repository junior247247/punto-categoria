Public Class frm_home
    Private dt As New DataTable
    Private class_invenntario As New class_inventario
    Private class_producto As New class_producto
    Private Class_cliente As New class_cliente
    Private class_provedor As New class_proveedor

    Public Sub home()
        Try




            dt = class_invenntario.sumar_ventas_del_mes
            If dt.Rows.Count > 0 Then
                lbl_compras_del_mes.Text = "RD$ " + ParseToDecimal.parse(dt.Rows(0).Item("compras_del_mes").ToString)


            End If

            If lbl_compras_del_mes.Text = "RD$ " Then
                lbl_compras_del_mes.Text = "RD$ 0.00"
            End If


            dt = class_producto.mostrar_productos_en_punto_de_reorden
            lbl_productos_en_punto_de_reorden.Text = dt.Rows.Count
            If lbl_productos_en_punto_de_reorden.Text = String.Empty Then
                lbl_productos_en_punto_de_reorden.Text = "0"
            End If
            dt = Class_cliente.motrar_clientes
            lbl_clientes.Text = dt.Rows.Count
            If lbl_clientes.Text = String.Empty Then
                lbl_clientes.Text = "0"

            End If
            dt = class_provedor.mostrar_proveedores
            lbl_proveedores.Text = dt.Rows.Count
            If lbl_proveedores.Text = String.Empty Then
                lbl_proveedores.Text = "0"
            End If
            dt = class_invenntario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                lbl_dinero_en_caja.Text = "RD$ " + ParseToDecimal.parse(dt.Rows(0).Item("dinero_en_caja").ToString)
            Else
                lbl_dinero_en_caja.Text = "RD$ 0.00"
            End If
            dt = class_invenntario.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                lbl_ventas_del_dia.Text = "RD$ " + ParseToDecimal.parse(dt.Rows(0).Item("ventas_del_dia").ToString)
            Else
                lbl_ventas_del_dia.Text = "RD$ 0.00"
            End If
            If lbl_ventas_del_dia.Text = "RD$ " Then

                lbl_ventas_del_dia.Text = "RD$ 0.00"
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        home()
    End Sub
End Class