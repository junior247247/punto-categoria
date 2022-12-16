Imports CrystalDecisions.Shared
Public Class reporte_retiros
    Private Sub reporte_retiros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try



            Dim class_reporte As New class_reporte
            Dim dt As New DataTable
            Dim obj_reporte As New rpt_retiros
            Dim data_se As New data_set_reportes
            Dim id_cierre As Integer = 0
            dt = class_reporte.sacar_id_reporte_retiros
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1 Step 1
                    id_cierre = dt.Rows(i).Item("id_retiros")
                Next
            End If


            dt = class_reporte.mostrar_reporte_retiros(Val(id_cierre))
            If dt.Rows.Count > 0 Then



                Dim dtr_comprobante As DataRow = data_se.Tables("mostrar_reporte_retiros").NewRow

                dtr_comprobante("id_retiros") = dt.Rows(0).Item("id_retiros")
                dtr_comprobante("motivo") = dt.Rows(0).Item("motivo")
                dtr_comprobante("monto") = dt.Rows(0).Item("monto")
                dtr_comprobante("fecha") = dt.Rows(0).Item("fecha")




                data_se.Tables("mostrar_reporte_retiros").Rows.Add(dtr_comprobante)



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
                    Me.Close()
                End If


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class