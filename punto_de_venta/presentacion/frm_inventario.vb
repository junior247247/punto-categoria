Public Class frm_inventario

    Private dt As New DataTable
    Private class_inventario As New class_inventario



    Public Sub mostrar_dinero_en_producto()
        Try
            Dim milista As List(Of Decimal)
            Dim clasS_producto As New class_producto
            dt = clasS_producto.mostrar_productos
            Dim EXISTENCIA As Decimal
            Dim PRECIO As Decimal
            Dim inversion As Decimal
            Dim total As Decimal
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1 Step 1
                    EXISTENCIA = dt.Rows(i).Item("Existencia")
                    PRECIO = dt.Rows(i).Item("Precio_de_Compra")
                    inversion = PRECIO * EXISTENCIA


                    total = total + inversion
                Next
                lbl_dinero_en_producto.Text = Format(Convert.ToDecimal(total), "0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mostrar_nventario()





        Try

            dt = class_inventario.sumar_mantenimiento_por_30_dias

            lbl_mantenimiento_por_30_dias.Text = dt.Rows(0).Item("ingresos_mantenimiento_por30_dias").ToString
            If lbl_mantenimiento_por_30_dias.Text = String.Empty Then
                lbl_mantenimiento_por_semana.Text = "0.00"
            End If

            dt = class_inventario.sumar_mantenimiento_por_7_dias
            lbl_mantenimiento_por_semana.Text = dt.Rows(0).Item("ingresos_mantenimiento_por7_dias").ToString
            If lbl_mantenimiento_por_semana.Text = String.Empty Then
                lbl_mantenimiento_por_semana.Text = "0.00"
            End If

            dt = class_inventario.sumar_liquidos_por_30_dias
            lbl_detalle_por_mes.Text = dt.Rows(0).Item("ingresos_liquidos_por_30_dias").ToString
            If lbl_detalle_por_mes.Text = String.Empty Then
                lbl_detalle_por_mes.Text = "0.00"
            End If

            dt = class_inventario.sumar_liquidos_por_semana
            lbl_por_semanas_liquidos.Text = dt.Rows(0).Item("ingresos_liquidos_por_semanas").ToString
            If lbl_por_semanas_liquidos.Text = String.Empty Then
                lbl_por_semanas_liquidos.Text = "0.00"
            End If



            dt = class_inventario.compras_de_la_semana
            lbl_compras_de_la_semana.Text = dt.Rows(0).Item("total_compras").ToString
            If lbl_compras_de_la_semana.Text = String.Empty Then
                lbl_compras_de_la_semana.Text = "0.00"
            End If

            dt = class_inventario.compras_del_mes
            lbl_compras_del_mes.Text = dt.Rows(0).Item("total_compras_del_mes").ToString
            If lbl_compras_del_mes.Text = String.Empty Then
                lbl_compras_del_mes.Text = "0.00"
            End If

            dt = class_inventario.ganancias_de_la_semana
            lbl_ganancias_de_la_semana.Text = dt.Rows(0).Item("total_ganancias_de_la_Semana").ToString
            If lbl_ganancias_de_la_semana.Text = String.Empty Then
                lbl_ganancias_de_la_semana.Text = "0.00"
            End If

            dt = class_inventario.ganancias_del_mes
            lbl_ganancias_del_mes.Text = dt.Rows(0).Item("total_ganancias_del_mes").ToString
            If lbl_ganancias_del_mes.Text = String.Empty Then
                lbl_ganancias_del_mes.Text = "0.00"
            End If

            dt = class_inventario.ventas_de_la_semana
            lbl_ventas_de_la_semana.Text = dt.Rows(0).Item("ventas_de_la_semana").ToString
            If lbl_ventas_de_la_semana.Text = String.Empty Then
                lbl_ventas_de_la_semana.Text = "0.00"
            End If

            dt = class_inventario.ventas_del_mes
            lbl_ventas_del_mes.Text = dt.Rows(0).Item("ventas_del_mes").ToString
            If lbl_ventas_del_mes.Text = String.Empty Then
                lbl_ventas_del_mes.Text = "0.00"
            End If

            dt = class_inventario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                lbl_dinero_en_caja.Text = dt.Rows(0).Item("dinero_en_caja").ToString
            Else

                lbl_dinero_en_caja.Text = "0.00"

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frm_inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_nventario()
        mostrar_dinero_en_producto()
    End Sub

    Private Sub btn_retirar_dinero_Click(sender As Object, e As EventArgs) Handles btn_retirar_dinero.Click
        frm_retirar_dinero.txt_dinero_en_caja.Text = lbl_dinero_en_caja.Text
        frm_retirar_dinero.ShowDialog()
    End Sub

    Private Sub btn_historial_de_dinero_retirado_Click(sender As Object, e As EventArgs) Handles btn_historial_de_dinero_retirado.Click
        frm_historial_de_retiros.ShowDialog()
    End Sub

    Private Sub btn_consultar_por_fecha_Click(sender As Object, e As EventArgs) Handles btn_consultar_por_fecha.Click
        frm_listas_desde.ShowDialog()
    End Sub

    Private Sub btn_comprobantes_Click(sender As Object, e As EventArgs) Handles btn_comprobantes.Click
        frm_comprobantes.ShowDialog()
    End Sub

    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click

        frmCrearBackup.ShowDialog()
    End Sub
End Class