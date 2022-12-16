Imports CrystalDecisions.Shared
Public Class frm_reporte_venta_a_creditos
    Private Sub frm_reporte_venta_a_creditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim class_reporte As New class_reporte
        Dim dt As New DataTable
        Dim obj_reporte As New rp_ventas_a_creditos
        Dim data_se As New data_set_reportes

        dt = class_reporte.mostrar_reporte_venta_a_creditos(Val(lbl_id_venta.Text))

        If dt.Rows.Count > 0 Then

            For i = 0 To dt.Rows.Count - 1 Step 1





                Dim dtr_comprobante As DataRow = data_se.Tables("mostrar_reporte_venta_a_creditos").NewRow

                dtr_comprobante("id_venta") = dt.Rows(i).Item("id_venta")
                dtr_comprobante("turno") = dt.Rows(i).Item("turno")
                dtr_comprobante("fecha") = dt.Rows(i).Item("fecha")
                dtr_comprobante("hora") = dt.Rows(i).Item("hora")
                dtr_comprobante("le_atendio") = dt.Rows(i).Item("le_atendio")
                dtr_comprobante("total_de_articulos") = dt.Rows(i).Item("total_de_articulos")
                dtr_comprobante("cambio") = dt.Rows(i).Item("cambio")
                dtr_comprobante("descuento_porciento") = dt.Rows(i).Item("descuento_porciento")
                dtr_comprobante("descuento") = dt.Rows(i).Item("descuento")
                dtr_comprobante("cliente") = dt.Rows(i).Item("cliente")
                dtr_comprobante("total") = dt.Rows(i).Item("total")
                dtr_comprobante("sub_total") = dt.Rows(i).Item("sub_total")
                dtr_comprobante("cantidad") = dt.Rows(i).Item("cantidad")
                dtr_comprobante("itbis") = dt.Rows(i).Item("itbis")
                dtr_comprobante("precio") = dt.Rows(i).Item("precio")
                dtr_comprobante("total1") = dt.Rows(i).Item("total1")
                dtr_comprobante("Descripcion") = dt.Rows(i).Item("Descripcion")
                dtr_comprobante("id_venta1") = dt.Rows(i).Item("id_venta1")
                dtr_comprobante("recibido") = dt.Rows(i).Item("recibido")
                dtr_comprobante("nombre_o_empresa") = dt.Rows(i).Item("nombre_o_empresa")
                dtr_comprobante("rnc_cliente") = dt.Rows(i).Item("rnc_cliente")
                dtr_comprobante("ncf") = dt.Rows(i).Item("ncf")
                dtr_comprobante("tipo") = dt.Rows(i).Item("tipo")
                dtr_comprobante("pendiente") = dt.Rows(i).Item("pendiente")
                dtr_comprobante("pagado") = dt.Rows(i).Item("pagado")


                data_se.Tables("mostrar_reporte_venta_a_creditos").Rows.Add(dtr_comprobante)



            Next


            obj_reporte.SetDataSource(data_se)
            CrystalReportViewer1.ReportSource = obj_reporte
            CrystalReportViewer1.Zoom(100)


            Dim d As New DialogResult
            d = MessageBox.Show("deceas imprimir la factura", "imprimir reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If d = DialogResult.Yes Then


                Dim ObjMargin As New PageMargins
                ObjMargin = obj_reporte.PrintOptions.PageMargins


                With ObjMargin
                    .bottomMargin = 0
                    .leftMargin = 0
                    .rightMargin = 0
                    .topMargin = 0
                End With

                obj_reporte.PrintOptions.ApplyPageMargins(ObjMargin)


                'esta línea de código hace que envíe directo a imprimir
                obj_reporte.PrintToPrinter(2, False, 0, 0)
                Me.Close()
            Else
                Me.Close()
            End If



        End If
    End Sub
End Class