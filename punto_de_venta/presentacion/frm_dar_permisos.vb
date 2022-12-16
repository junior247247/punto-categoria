Public Class frm_dar_permisos
    Private dt As New DataTable
    Private class_permiso As New class_permisos
    Public list As New List(Of Object)

    Private Sub frm_dar_permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_permisos.DropDownStyle = 2
        datalistado_productos.Columns.Add("", "PERMISO")
        datalistado_productos.Columns(0).Width = 300

    End Sub


    Private Sub agregar_permisos()

        Dim i As Integer = 0
        Do



            If list.Count > 0 Then
                For Each imtem In list
                    If imtem <> cbo_permisos.Text.Trim Then
                        list.Add(cbo_permisos.Text)
                    End If

                Next
            Else
                list.Add(cbo_permisos.Text)
            End If
            i += 1
        Loop While i < list.Count

        Dim b As New BindingSource
        datalistado_productos.Rows.Clear()
        For Each item In list

            datalistado_productos.Rows.Add(item)



        Next

    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_permitir_permiso_Click(sender As Object, e As EventArgs) Handles btn_permitir_permiso.Click
        agregar_permisos()
    End Sub
End Class