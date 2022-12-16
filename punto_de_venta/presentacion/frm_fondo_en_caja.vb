Imports System.IO
Public Class frm_fondo_en_caja
    Private dt As New DataTable
    Private class_cobro As New class_cobro


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

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        txt_fondo.Clear()
        End
    End Sub

    Private Sub fondo_de_caja()
        If IsNumeric(txt_fondo.Text) Then
            If txt_fondo.Text.Trim <> String.Empty Then
                If IsNumeric(txt_fondo.Text) Then
                    dt = class_cobro.verificar_si_hay_fondo(Val(Form1.lbl_id_usuario.Text))
                    If dt.Rows.Count > 0 Then
                        class_cobro.actualizar_fondo(Val(Form1.lbl_id_usuario.Text), Convert.ToDecimal(txt_fondo.Text))
                        txt_fondo.Clear()
                        Me.Hide()
                        Form1.Show()
                        'abrircajon("LPT3")
                    Else
                        class_cobro.insertar_fondo(Val(Form1.lbl_id_usuario.Text), Convert.ToDecimal(txt_fondo.Text))
                        txt_fondo.Clear()
                        Me.Hide()
                        Form1.Show()
                        'abrircajon("LPT3")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If txt_fondo.Text.Trim <> String.Empty Then
            fondo_de_caja()
        End If
    End Sub

    Private Sub frm_fondo_en_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_fondo.Select()
    End Sub

    Private Sub txt_fondo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fondo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            fondo_de_caja()
        End If
    End Sub
End Class