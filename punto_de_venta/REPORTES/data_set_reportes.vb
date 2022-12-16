Partial Class data_set_reportes
    Partial Public Class reporte_cierre_de_cajaDataTable
        Private Sub reporte_cierre_de_cajaDataTable_reporte_cierre_de_cajaRowChanging(sender As Object, e As reporte_cierre_de_cajaRowChangeEvent) Handles Me.reporte_cierre_de_cajaRowChanging

        End Sub

    End Class

    Partial Public Class mostrar_reporte_ventaDataTable
        Private Sub mostrar_reporte_ventaDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.id_ventaColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class
