Public Class frm_listas_desde
    Private dt As New DataTable
    Private class_desde As New class_desde

    Private ganancias As Decimal
    Private otrosGastos As Decimal
    Private classGastos As New class_gastos



    Private Sub filtrarGastosPorFecha()
        Try
            Dim sumaDeGastos = 0
            dt = classGastos.mostrar_gastos_por_fecha(txt_fecha1.Text, txt_fecha2.Text)

            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    sumaDeGastos += Convert.ToDecimal(dt.Rows(i).Item("Total_con_itbis"))
                Next

            Else

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mostrar()


        Try


            dt = classGastos.sumarGastosOtros(txt_fecha1.Text, txt_fecha2.Text)
            lblOtrosGastos.Text = dt.Rows(0).Item("total").ToString

            If lblOtrosGastos.Text = "" Then
                lblOtrosGastos.Text = "0.00"
            End If

            Me.otrosGastos = Convert.ToDecimal(lblOtrosGastos.Text)

            dt = classGastos.sumarGastosInversion(txt_fecha1.Text, txt_fecha2.Text)
            lblTotalInversion.Text = dt.Rows(0).Item("total").ToString
            If lblTotalInversion.Text = "" Then
                lblTotalInversion.Text = "0.00"
            End If


            dt = class_desde.mantenimiento_desde_fechas(txt_fecha1.Text, txt_fecha2.Text)

            lbl_mantenimiento.Text = dt.Rows(0).Item("MANTENIMINETO").ToString
            If lbl_mantenimiento.Text = String.Empty Then
                lbl_mantenimiento.Text = "0.00"
            End If

            dt = class_desde.recargas_desde_fechas(txt_fecha1.Text, txt_fecha2.Text)
            lbl_recargas.Text = dt.Rows(0).Item("recarga").ToString

            If lbl_recargas.Text = String.Empty Then
                lbl_recargas.Text = "0.00"
            End If

            dt = class_desde.compras_de_la_semana_desde(txt_fecha1.Text, txt_fecha2.Text)
            lbl_compras.Text = dt.Rows(0).Item("compreas_desde").ToString
            If lbl_compras.Text = String.Empty Then
                lbl_compras.Text = "0.00"
            End If
            dt = class_desde.gananciaS_desde(txt_fecha1.Text, txt_fecha2.Text)
            lbl_ganancias.Text = dt.Rows(0).Item("ganancias_desde").ToString

            If lbl_ganancias.Text = String.Empty Then
                lbl_ganancias.Text = "0.00"
            End If

            Me.
                ganancias = Convert.ToDecimal(lbl_ganancias.Text)

            dt = class_desde.ventas_desde(txt_fecha1.Text, txt_fecha2.Text)
            lbl_ventas.Text = dt.Rows(0).Item("vendas_desde").ToString
            If lbl_ventas.Text = String.Empty Then
                lbl_ventas.Text = "0.00"
            End If
            dt = class_desde.sumar_retiros_desde(txt_fecha1.Text, txt_fecha2.Text)
            lbl_retirados.Text = dt.Rows(0).Item("total_retiros").ToString
            If lbl_retirados.Text = String.Empty Then
                lbl_retirados.Text = "0.00"
            End If
            Dim ventas, total, retirados As Decimal
            ventas = Format(Convert.ToDecimal(lbl_ventas.Text), "0.00")
            retirados = Format(Convert.ToDecimal(lbl_retirados.Text), "0.00")
            total = ventas - retirados
            lbl_total_de_ingresos.Text = total

            Dim sumaDeGastos = 0
            dt = classGastos.mostrar_gastos_por_fecha(txt_fecha1.Text, txt_fecha2.Text)

            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    sumaDeGastos += Convert.ToDecimal(dt.Rows(i).Item("Total_con_itbis"))
                Next
                lblGastos.Text = sumaDeGastos.ToString
            Else
                lblGastos.Text = "0"
            End If
            Dim ventasSinGasto As Decimal

            ventasSinGasto = total - sumaDeGastos
            lblGastosMenosIngresos.Text = ventasSinGasto.ToString
            Dim totalCostoSinGastos As Decimal
            totalCostoSinGastos = Me.ganancias - Me.otrosGastos
            lblTotalMENOSGASTOS.Text = totalCostoSinGastos.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label3.Click, lbl_ganancias.Click, lbl_ventas.Click, lbl_compras.Click

    End Sub

    Private Sub frm_listas_desde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub txt_fecha2_ValueChanged(sender As Object, e As EventArgs) Handles txt_fecha2.ValueChanged
        mostrar()
    End Sub

    Private Sub txt_fecha1_ValueChanged(sender As Object, e As EventArgs) Handles txt_fecha1.ValueChanged
        mostrar()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
End Class