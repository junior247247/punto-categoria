Public Class frmCrearBackup
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            'Verifica que exista la carpeta, en caso contrario la crea
            If txtRutaGuardar.Text.Trim <> String.Empty Then
                Process.Start("cmd", "/k" & "sqlcmd -S (local) -E -Q ""BACKUP DATABASE [" & "sispunto_de_ventas" & "] TO DISK='" & txtRutaGuardar.Text & "'""")
                MessageBox.Show("Copia de segurida realizada", "Copia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Dirijase a la ruta especificada para comprobar que el archivo" + SaveFileDialog1.FileName + " Se encuentra", "Copia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtRutaGuardar.Clear()
                Me.Close()
            Else
                MessageBox.Show("Debes de ingresar la ruta donde guardar el backup", "Copia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub btnRutaGuardar_Click(sender As Object, e As EventArgs) Handles btnRutaGuardar.Click
        SaveFileDialog1.Filter = "SQL Backup files|*.bak"
        SaveFileDialog1.FileName = "sispunto_de_ventas -" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ".bak"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtRutaGuardar.Text = SaveFileDialog1.FileName
        End If

    End Sub

    Private Sub btnRutaRestaurar_Click(sender As Object, e As EventArgs) Handles btnRutaRestaurar.Click
        OpenFileDialog1.Filter = "SQL Backup Files|*.bak"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtRutaRestaurar.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Dim d As New DialogResult

        d = MessageBox.Show("Realmente deceas restaurar esta base de datos", "Restaurarando base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If txtRutaRestaurar.Text.Trim <> "" Then
            If d = DialogResult.Yes Then
                Process.Start("cmd", "/k" & "Sqlcmd -S (local) -E -Q ""RESTORE DATABASE [" & "sispunto_de_ventas" & "] FROM DISK = '" & txtRutaRestaurar.Text & "'""")
                MessageBox.Show("Selecione ok para completar", "Restaurarando base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End
            Else
                MessageBox.Show("")
            End If
        Else
            MessageBox.Show("Debes de selecionar la ruta de la copia de seguridad a restaurar", "Restaurarando base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
End Class