Public Class frm_articulos
    Private dt As New DataTable
    Private obj_venta As New ce_venta
    Private class_venta As New class_venta
    Private Sub frm_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_articulos()
    End Sub

    Public Sub mostrar_articulos()
        Try
            obj_venta.id_venta = Val(lbl_id_factura.Text)

            dt = class_venta.mostrar_articulos(obj_venta)
            datalistado_facturas.DataSource = dt
            datalistado_facturas.EnableHeadersVisualStyles = False
            datalistado_facturas.Columns(0).Visible = False
            datalistado_facturas.Columns(6).Visible = False
            datalistado_facturas.Columns(7).Visible = False
            datalistado_facturas.Columns(8).Visible = False
            For i = 0 To datalistado_facturas.Columns.Count - 1 Step 1
                datalistado_facturas.Columns(i).Width = 170
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
End Class