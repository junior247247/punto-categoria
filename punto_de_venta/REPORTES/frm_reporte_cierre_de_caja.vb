Imports CrystalDecisions.Shared
Public Class frm_reporte_cierre_de_caja
    Private Sub frm_reporte_cierre_de_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim class_reporte As New class_cierre_de_caja
        Dim dt As New DataTable
        Dim obj_reporte As New rpt_cierre_de_caja
        Dim data_se As New data_set_reportes
        Dim id_cierre As Integer = 0
        dt = class_reporte.listar_cierre_de_caja
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1 Step 1
                id_cierre = dt.Rows(i).Item("id_cierre_de_caja")
            Next
        End If


        dt = class_reporte.reporte_cierre_de_caja(Val(id_cierre))
        If dt.Rows.Count > 0 Then

            'totalBar, dbo.db_cierre_de_caja.totalGomera

            Dim dtr_comprobante As DataRow = data_se.Tables("reporte_cierre_de_caja").NewRow

            dtr_comprobante("id_cierre_de_caja") = dt.Rows(0).Item("id_cierre_de_caja")
            dtr_comprobante("totalGomera") = dt.Rows(0).Item("totalGomera")
            dtr_comprobante("totalBar") = dt.Rows(0).Item("totalBar")
            dtr_comprobante("dinero_en_caja") = dt.Rows(0).Item("dinero_en_caja")
            dtr_comprobante("devoluciones") = dt.Rows(0).Item("devoluciones")
            dtr_comprobante("fecha") = dt.Rows(0).Item("fecha")
            dtr_comprobante("hora") = dt.Rows(0).Item("hora")
            dtr_comprobante("usuario") = dt.Rows(0).Item("usuario")
            dtr_comprobante("turno") = dt.Rows(0).Item("turno")
            dtr_comprobante("id_usuario") = dt.Rows(0).Item("id_usuario")
            dtr_comprobante("ventas_del_dia") = dt.Rows(0).Item("ventas_del_dia")
            dtr_comprobante("retirados") = dt.Rows(0).Item("retirados")
            dtr_comprobante("total_retirados") = dt.Rows(0).Item("total_retirados")
            dtr_comprobante("valor_en_efectivo_de_caja") = dt.Rows(0).Item("valor_en_efectivo_de_caja")
            dtr_comprobante("restante") = dt.Rows(0).Item("restante")
            dtr_comprobante("tarjeta") = dt.Rows(0).Item("tarjeta")
            data_se.Tables("reporte_cierre_de_caja").Rows.Add(dtr_comprobante)



            obj_reporte.SetDataSource(data_se)


            CrystalReportViewer1.ReportSource = obj_reporte




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
                obj_reporte.PrintToPrinter(1, False, 0, 0)
                Me.Close()
            Else

            End If

        End If
    End Sub
End Class