﻿Imports CrystalDecisions.Shared
Public Class frmReporteGastos
    Dim dt, dtSacarid As New DataTable
    Dim classGastos As New class_gastos

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub frmReporteGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtSacarid = classGastos.sacarUltimoIDGastos
        Dim dataSet As New data_set_reportes
        Dim DataRow As DataRow
        Dim objReporte As New rpt_gastos

        Dim idUltimo = 0
        If dtSacarid.Rows.Count > 0 Then
            For i = 0 To dtSacarid.Rows.Count - 1 Step 1
                idUltimo = Convert.ToInt32(dtSacarid.Rows(i).Item("idTotal"))
            Next
        End If
        dt = classGastos.mostrar_reporte_desde_hasta_gastos(idUltimo, lblfechaDesde.Text, lblFechaHasta.Text)
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1 Step 1
                Dim datRow = dataSet.Tables("mostrar_reporte_desde_hasta_gastos").NewRow
                datRow("Description") = dt.Rows(i).Item("Description")
                datRow("fecha") = dt.Rows(i).Item("fecha")
                datRow("Itbis") = dt.Rows(i).Item("Itbis")
                datRow("Total_con_itbis") = dt.Rows(i).Item("Total_con_itbis")
                datRow("Total_sin_itbis") = dt.Rows(i).Item("Total_sin_itbis")
                datRow("fechaDesde") = dt.Rows(i).Item("fechaDesde")
                datRow("fechaHasta") = dt.Rows(i).Item("fechaHasta")
                datRow("sumaDeItbis") = dt.Rows(i).Item("sumaDeItbis")
                datRow("TotalConItbis") = dt.Rows(i).Item("TotalConItbis")
                datRow("TotalSinItbis") = dt.Rows(i).Item("TotalSinItbis")
                dataSet.Tables("mostrar_reporte_desde_hasta_gastos").Rows.Add(datRow)


            Next






            objReporte.SetDataSource(dataSet)
            CrystalReportViewer1.ReportSource = objReporte
            CrystalReportViewer1.Zoom(100)


            'Dim d As New DialogResult
            'd = MessageBox.Show("deceas imprimir la factura", "imprimir reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If d = DialogResult.Yes Then


            '    Dim ObjMargin As New PageMargins
            '    ObjMargin = objReporte.PrintOptions.PageMargins


            '    With ObjMargin
            '        .bottomMargin = 0
            '        .leftMargin = 0
            '        .rightMargin = 0
            '        .topMargin = 0
            '    End With

            '    objReporte.PrintOptions.ApplyPageMargins(ObjMargin)


            '    'esta línea de código hace que envíe directo a imprimir
            '    objReporte.PrintToPrinter(1, False, 0, 0)
            '    Me.Close()
            'Else
            '    Me.Close()
            'End If

        End If
    End Sub
End Class