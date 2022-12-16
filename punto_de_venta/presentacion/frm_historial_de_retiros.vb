Public Class frm_historial_de_retiros

    Private dt As New DataTable
    Private class_incentario As New class_inventario

    Public Sub buscar()
        Try
            dt = class_incentario.buscar_retiros(txt_fecha1.Text, txtfecha_2.Text)
            datalistado_retiros.DataSource = dt
            datalistado_retiros.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_retiros.Columns.Count - 1 Step 1
                datalistado_retiros.Columns(i).Width = 160
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mostrar()
        Try
            dt = class_incentario.mostrar_retiros
            datalistado_retiros.DataSource = dt
            datalistado_retiros.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_retiros.Columns.Count - 1 Step 1
                datalistado_retiros.Columns(i).Width = 160
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub

    Private Sub txt_fecha1_ValueChanged(sender As Object, e As EventArgs) Handles txt_fecha1.ValueChanged
        buscar()
    End Sub

    Private Sub txtfecha_2_ValueChanged(sender As Object, e As EventArgs) Handles txtfecha_2.ValueChanged
        buscar()
    End Sub

    Private Sub frm_historial_de_retiros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
End Class