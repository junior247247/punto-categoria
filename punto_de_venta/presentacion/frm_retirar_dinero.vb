Imports System.IO
Public Class frm_retirar_dinero
    Private obj_coobro As New ce_cobro
    Private class_inventario As New class_inventario
    Private dt As New DataTable
    Dim port As New IO.Ports.SerialPort



    Public Declare Auto Function CreateFile Lib "kernel32.dll" (
ByVal lpFileName As String, ByVal dwDesiredAccess As Int32,
ByVal dwShareMode As Int32, ByVal lpSecurityAttributes As IntPtr,
ByVal dwCreationDisposition As Int32, ByVal dwFlagsAndAttributes As Int32,
ByVal hTemplateFile As IntPtr) As IntPtr

    Public Shared puerto As String
    Public Const GENERIC_READ As Int32 = &H80000000

    Public Const GENERIC_WRITE As Int32 = &H40000000

    Public Const OPEN_EXISTING As Int32 = 3

    Public Shared Property puertos() As String
        Get

            Return puerto
        End Get
        Set(ByVal Value As String)
            puerto = Value
        End Set
    End Property
    Public Shared Sub abrircajon(ByVal puertolpt As String)
        puertos = puertolpt


        Dim hFich As IntPtr = CreateFile(puertos, GENERIC_WRITE, 0, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero)
        Dim stream As New FileStream(hFich, FileAccess.Write)

        Dim writer As New StreamWriter(stream)

        writer.WriteLine(Chr(&H1B) + "p" + Chr(0))
        writer.Close()
        stream.Close()
    End Sub



    Public Sub mostrar_nventario()
        Try






            dt = class_inventario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            frm_inventario.lbl_dinero_en_caja.Text = dt.Rows(0).Item("dinero_en_caja").ToString
            If frm_inventario.lbl_dinero_en_caja.Text = String.Empty Then
                frm_inventario.lbl_dinero_en_caja.Text = "0.00"
            End If


            dt = class_inventario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                frm_home.lbl_dinero_en_caja.Text = "RD$ " + dt.Rows(0).Item("dinero_en_caja").ToString
            Else
                frm_home.lbl_dinero_en_caja.Text = "RD$ 0.00"
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub btn_retirar_Click(sender As Object, e As EventArgs) Handles btn_retirar.Click
        If txt_motivo_del_retiro.Text.Trim <> String.Empty Then

            If IsNumeric(txt_monto_retiro.Text) Then
                    If Val(txt_monto_retiro.Text) <= Val(txt_dinero_en_caja.Text) Then
                    dt = class_inventario.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
                    Me.Cursor = Cursors.WaitCursor
                    Dim id_dinero As Integer
                        If dt.Rows.Count > 0 Then
                            id_dinero = dt.Rows(0).Item("id_dinero_en_caja")
                        With obj_coobro
                            obj_coobro.id_usuario = Val(Form1.lbl_id_usuario.Text)
                            .id_dinero_en_caja = id_dinero
                            .retiro = Val(txt_monto_retiro.Text)
                        End With
                        class_inventario.retirar_dinero(obj_coobro)

                        With obj_coobro
                                .motivo = txt_motivo_del_retiro.Text.ToUpper
                                .retiro = Val(txt_monto_retiro.Text)
                                .fecha = Today.Date
                            End With
                            class_inventario.insertar_retiro(obj_coobro)
                            txt_monto_retiro.Clear()
                            txt_motivo_del_retiro.Clear()
                            txt_dinero_en_caja.Clear()
                            mostrar_nventario()
                            MessageBox.Show("Retiro completado con exito", "Retiro de dinero", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'abrircajon("LPT3")
                        Me.Close()
                        Me.Cursor = Cursors.Default
                        reporte_retiros.ShowDialog()


                    End If

                    Else
                        MessageBox.Show("el monto a retirar no puede ser mayor que el dinero en caja", "Retiro de dinero", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("valor numerico invalido", "Retiro de dinero", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
            MessageBox.Show("Debe de ingresar un motivo para poder retirar", "Retiro de dinero", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_monto_retiro.Clear()
        txt_motivo_del_retiro.Clear()
        txt_dinero_en_caja.Clear()
        Me.Close()
    End Sub

    Private Sub frm_retirar_dinero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_monto_retiro.Select()
    End Sub
End Class