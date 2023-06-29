Imports System.IO
Public Class frm_caja
    Private dt As New DataTable
    Private Class_inventaro As New class_inventario
    'Private obj_cierre_de_caja As New ce_cierre_de_caja
    'Private class_cierre_de_caja As New class_cierre_de_caja
    'Private obj_cobro As New ce_cobro
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




    Public Sub mostrar_ingresos_del_dia()
        Try
            dt = class_cobro.verificar_si_hay_fondo(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                lbl_fondo_en_caja.Text = ParseToDecimal.parse(dt.Rows(0).Item("fondo").ToString)
            Else
                lbl_fondo_en_caja.Text = "0.00"
            End If

            dt = Class_inventaro.sumarTarjeta(Val(Form1.lbl_id_usuario.Text))

            lblTotalTarjeta.Text = ParseToDecimal.parse(dt.Rows(0).Item("tarjeta").ToString)
            lbl_contador_ventas.Text = ParseToDecimal.parse(dt.Rows(0).Item("tarjeta").ToString)


            If lblTotalTarjeta.Text = String.Empty Then
                lblTotalTarjeta.Text = "0.00"
                lbl_contador_ventas.Text = "0.00"
            End If


            dt = Class_inventaro.dinero_de_ventas_del_dia(Val(Form1.lbl_id_usuario.Text))
            lbl_dinero_encaja.Text = ParseToDecimal.parse(dt.Rows(0).Item("ventas_del_dia").ToString)
            lbl_dinero_en_caja.Text = ParseToDecimal.parse(dt.Rows(0).Item("ventas_del_dia").ToString)
            lbl_total_ventas_card_y_efeec.Text = ParseToDecimal.parse(dt.Rows(0).Item("ventas_del_dia").ToString)

            If lbl_dinero_encaja.Text = String.Empty Then
                lbl_dinero_encaja.Text = "0.00"
                lbl_dinero_en_caja.Text = "0.00"
                lbl_total_ventas_card_y_efeec.Text = "0.00"
                lbl_contador_ventas.Text = "0"
            End If

            dt = Class_inventaro.mostrar_dinero_en_caja(Val(Form1.lbl_id_usuario.Text))
            If dt.Rows.Count > 0 Then
                lbl_dinero_en_caja.Text = "RD$ " + ParseToDecimal.parse(dt.Rows(0).Item("dinero_en_caja").ToString)
            Else
                lbl_dinero_en_caja.Text = "RD$ 0.00"
            End If

            dt = Class_inventaro.ganancias_del_dia(Val(Form1.lbl_id_usuario.Text))
            lbl_ganancia_en_ventas.Text = dt.Rows(0).Item("ganancias_del_dia").ToString
            If lbl_ganancia_en_ventas.Text = String.Empty Then
                lbl_ganancia_en_ventas.Text = "0.00"
            End If
            dt = Class_inventaro.devoluciones(Val(Form1.lbl_id_usuario.Text))
            lbl_devolucioneS_efectivos.Text = dt.Rows(0).Item("devoluciones_del_dia").ToString
            If lbl_devolucioneS_efectivos.Text = String.Empty Then
                lbl_devolucioneS_efectivos.Text = "0"
            End If

            dt = Class_inventaro.mostrar_listado_ingreso_del_dia(Val(Form1.lbl_id_usuario.Text))
            datalistado_caja.DataSource = dt

            datalistado_caja.EnableHeadersVisualStyles = False
            For i = 0 To datalistado_caja.Columns.Count - 1 Step 1
                datalistado_caja.Columns(i).Width = 170
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_ingresos_del_dia()
    End Sub

    Private Sub btn_anular_ticket_Click(sender As Object, e As EventArgs) Handles btn_anular_ticket.Click
        frm_descbloquear_para_anular.ShowDialog()
    End Sub

    Private Sub btn_cerrar_turno_Click(sender As Object, e As EventArgs) Handles btn_cerrar_turno.Click
        'Dim d As New DialogResult
        'd = MessageBox.Show("¿Realmente deceas cerrar el turno?", "Cierre de caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If d = DialogResult.Yes Then
        frm_efectivo_de_caja.ShowDialog()
        'End If

    End Sub

    Private Sub Label75_Click(sender As Object, e As EventArgs) Handles Label75.Click

    End Sub
End Class