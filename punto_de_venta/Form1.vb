
Public Class Form1
    Private class_venta As New class_venta
    Private class_usuario As New class_usuarios
    Private class_permisos As New class_permisos
    Private dt As New DataTable
    Dim ex, ey As Integer

    Dim Arrastre As Boolean

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ex = e.X

        ey = e.Y

        Arrastre = True
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub



    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        Arrastre = False
    End Sub

    Private Sub btn_ajustar_menu_Click(sender As Object, e As EventArgs) Handles btn_ajustar_menu.Click
        If panel_menu.Width = 42 Then

            panel_menu.Width = 260
        Else

            panel_menu.Width = 42
        End If
    End Sub

    Private Sub btn_minimixar_Click(sender As Object, e As EventArgs) Handles btn_minimixar.Click
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btn_restaurar_Click(sender As Object, e As EventArgs) Handles btn_restaurar.Click
        btn_restaurar.Visible = False
        btn_maximixar.Visible = True
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub btn_maximixar_Click(sender As Object, e As EventArgs) Handles btn_maximixar.Click
        btn_restaurar.Visible = True
        btn_maximixar.Visible = False
        WindowState = FormWindowState.Maximized
    End Sub



    Private Sub btn_caja_Click(sender As Object, e As EventArgs) Handles btn_caja.Click
        frm_caja.TopLevel = False
        frm_caja.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_caja.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_caja)
        lbl_donde_estoy.Text = "CAJA"
        frm_provedor.Hide()
        frm_clientes.Hide()
        frm_home.Hide()
        frm_gastos.Hide()
        frm_almacen.Hide()
        frm_productos.Hide()
        frm_inventario.Hide()
        frm_usuarios.Hide()
        frm_ventas.Hide()
        frm_categorias.Hide()
        frm_compras.Hide()
        frm_caja.Show()
    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        frm_productos.TopLevel = False
        frm_productos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_productos.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_productos)
        lbl_donde_estoy.Text = "PRODUCTOS"
        frm_caja.Hide()
        frm_provedor.Hide()
        frm_clientes.Hide()
        frm_home.Hide()
        frm_ventas.Hide()
        frm_almacen.Hide()
        frm_usuarios.Hide()
        frm_inventario.Hide()
        frm_gastos.Hide()
        frm_compras.Hide()
        frm_categorias.Hide()
        frm_productos.Show()
    End Sub

    Private Sub btn_almacen_Click(sender As Object, e As EventArgs) Handles btn_almacen.Click
        frm_almacen.TopLevel = False
        frm_almacen.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_almacen.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_almacen)
        lbl_donde_estoy.Text = "ALMACEN"
        frm_caja.Hide()
        frm_productos.Hide()
        frm_clientes.Hide()
        frm_categorias.Hide()
        frm_gastos.Hide()
        frm_home.Hide()
        frm_usuarios.Hide()
        frm_provedor.Hide()
        frm_inventario.Hide()
        frm_ventas.Hide()
        frm_compras.Hide()
        frm_almacen.Show()
    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        frm_clientes.TopLevel = False
        frm_clientes.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_clientes.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_clientes)
        lbl_donde_estoy.Text = "CLIENTES"
        frm_caja.Hide()
        frm_productos.Hide()
        frm_provedor.Hide()
        frm_ventas.Hide()
        frm_home.Hide()
        frm_gastos.Hide()
        frm_almacen.Hide()
        frm_usuarios.Hide()
        frm_inventario.Hide()
        frm_categorias.Hide()
        frm_compras.Hide()
        frm_clientes.Show()
    End Sub

    Private Sub btn_proveedor_Click(sender As Object, e As EventArgs) Handles btn_proveedor.Click
        frm_provedor.TopLevel = False
        frm_provedor.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_provedor.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_provedor)
        lbl_donde_estoy.Text = "PROVEEDORES"
        frm_caja.Hide()
        frm_productos.Hide()
        frm_compras.Hide()
        frm_home.Hide()
        frm_ventas.Hide()
        frm_gastos.Hide()
        frm_usuarios.Hide()
        frm_clientes.Hide()
        frm_inventario.Hide()
        frm_almacen.Hide()
        frm_categorias.Hide()
        frm_provedor.Show()
    End Sub

    Private Sub btn_compras_Click(sender As Object, e As EventArgs) Handles btn_compras.Click
        frm_compras.TopLevel = False
        frm_compras.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_compras.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_compras)
        lbl_donde_estoy.Text = "COMPRAS"
        frm_caja.Hide()
        frm_productos.Hide()
        frm_provedor.Hide()
        frm_usuarios.Hide()
        frm_gastos.Hide()
        frm_ventas.Hide()
        frm_inventario.Hide()
        frm_almacen.Hide()
        frm_clientes.Hide()
        frm_categorias.Hide()
        frm_home.Hide()
        frm_compras.Show()
    End Sub

    Private Sub btn_categorias_Click(sender As Object, e As EventArgs) Handles btn_categorias.Click
        frm_categorias.TopLevel = False
        frm_categorias.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_categorias.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_categorias)
        lbl_donde_estoy.Text = "CATEGORIAS"
        frm_caja.Hide()
        frm_productos.Hide()
        frm_provedor.Hide()
        frm_almacen.Hide()
        frm_usuarios.Hide()
        frm_ventas.Hide()
        frm_inventario.Hide()
        frm_gastos.Hide()
        frm_clientes.Hide()
        frm_home.Hide()
        frm_compras.Hide()
        frm_categorias.Show()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        frm_home.TopLevel = False
        frm_home.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_home.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_home)
        lbl_donde_estoy.Text = "Home"
        frm_caja.Hide()
        frm_productos.Hide()
        frm_provedor.Hide()
        frm_almacen.Hide()
        frm_clientes.Hide()
        frm_usuarios.Hide()
        frm_gastos.Hide()
        frm_ventas.Hide()
        frm_categorias.Hide()
        frm_inventario.Hide()
        frm_compras.Hide()
        frm_home.Show()
    End Sub
    Private Sub disableButton()
        btn_usuarios.Enabled = False
        btn_almacen.Enabled = False
        btn_caja.Enabled = False
        btn_categorias.Enabled = False
        btn_inventario.Enabled = False
        btn_productos.Enabled = False
        btn_ventas.Enabled = True
        btn_compras.Enabled = False
        btn_clientes.Enabled = False
        btn_proveedor.Enabled = False
        frm_facturas_a_creditos.btn_eliminar.Visible = False
        frm_home.lbl_compras_del_mes.Visible = False
        btn_home.Enabled = False
        frm_caja.Panel5.Visible = True
        frm_caja.GroupBox6.Visible = True
        frm_caja.GroupBox1.Visible = True

    End Sub
    Private Sub permizos_personalizados()
        Dim dt As New DataTable
        dt = class_permisos.selecionar_permisos_dados(Val(lbl_id_usuario.Text))
        Dim lis As New List(Of String)
        For i = 0 To dt.Rows.Count - 1 Step 1
            lis.Add(dt.Rows(i).Item("permiso").ToString)
        Next
        For Each item In lis
            Select Case item
                Case "PRODUCTOS"
                    btn_productos.Enabled = True

                Case "CAJA"
                    btn_caja.Enabled = True
                Case "INVENTARIO"
                    btn_inventario.Enabled = True

                Case "USUARIOS"
                    btn_usuarios.Enabled = True

                Case "ALMACEN"
                    btn_almacen.Enabled = True

                Case "CATEOGRIAS"
                    btn_categorias.Enabled = True

                Case "VENTAS"
                    btn_ventas.Enabled = True

                Case "PROVEEDOR"
                    btn_proveedor.Enabled = True

                Case "COMPRAS"
                    btn_compras.Enabled = True

                Case "CLIENTES"
                    btn_clientes.Enabled = True

            End Select
        Next
        frm_home.TopLevel = False
        frm_home.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_home.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_home)
        lbl_donde_estoy.Text = "Home"
        frm_caja.Hide()
        frm_productos.Hide()
        frm_provedor.Hide()
        frm_almacen.Hide()
        frm_clientes.Hide()
        frm_usuarios.Hide()
        frm_inventario.Hide()
        frm_gastos.Hide()
        frm_ventas.Hide()
        frm_categorias.Hide()
        frm_compras.Hide()
        frm_home.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        class_venta.monto_negativo_en_positivo()

        dt = class_usuario.verificar_si_existe_la_hora(Val(lbl_id_usuario.Text))
        If dt.Rows.Count > 0 Then

        Else
            Dim hora As String = TimeOfDay.ToString("hh:mm:ss")
            Dim fecha As String = Today.Date
            Dim caja_abierta As String = fecha + " " + hora
            class_usuario.insertar_hora_caja_abierta(Val(lbl_id_usuario.Text), caja_abierta)
        End If
        'disableButton()

        If lbl_permiso.Text = "ADMINISTRADOR" Then
            btnGastos.Enabled = True
            btn_almacen.Enabled = True
            btn_caja.Enabled = True
            btn_categorias.Enabled = True
            btn_inventario.Enabled = True
            btn_home.Enabled = True
            btn_productos.Enabled = True
            btn_ventas.Enabled = True
            btn_compras.Enabled = True
            btn_clientes.Enabled = True
            btn_proveedor.Enabled = True
            btn_usuarios.Enabled = True
            frm_home.lbl_compras_del_mes.Visible = True

            frm_home.TopLevel = False
            frm_home.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frm_home.Dock = DockStyle.Fill
            panel_contenedor.Controls.Add(frm_home)
            lbl_donde_estoy.Text = "Home"
            frm_caja.Hide()
            frm_productos.Hide()
            frm_provedor.Hide()
            frm_almacen.Hide()
            frm_clientes.Hide()
            frm_usuarios.Hide()
            frm_gastos.Hide()
            frm_inventario.Hide()
            frm_ventas.Hide()
            frm_categorias.Hide()
            frm_compras.Hide()
            frm_home.Show()

        End If

        If lbl_permiso.Text = "CAJERO" Then
            btnGastos.Enabled = False
            btn_usuarios.Enabled = False
            btn_almacen.Enabled = False
            btn_caja.Enabled = True
            btn_categorias.Enabled = False
            btn_inventario.Enabled = False
            btn_home.Enabled = True
            btn_productos.Enabled = False
            btn_ventas.Enabled = True
            btn_compras.Enabled = False
            btn_clientes.Enabled = False
            btn_proveedor.Enabled = False
            frm_facturas_a_creditos.btn_eliminar.Visible = False
            frm_home.lbl_compras_del_mes.Visible = False
            btn_home.Enabled = False
            frm_caja.Panel5.Visible = False
            frm_caja.GroupBox6.Visible = False
            frm_caja.GroupBox1.Visible = False
            frm_ventas.TopLevel = False
            frm_ventas.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frm_ventas.Dock = DockStyle.Fill
            panel_contenedor.Controls.Add(frm_ventas)
            lbl_donde_estoy.Text = "VENTAS"
            frm_caja.Hide()
            frm_productos.Hide()
            frm_provedor.Hide()
            frm_usuarios.Hide()
            frm_gastos.Hide()
            frm_inventario.Hide()
            frm_almacen.Hide()
            frm_clientes.Hide()
            frm_home.Hide()
            frm_categorias.Hide()
            frm_compras.Hide()
            frm_ventas.Show()


        End If

        'If lbl_permiso.Text = "PERSONALIZADO" Then
        '    permizos_personalizados()
        'End If

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Dim d As New DialogResult
        d = MessageBox.Show("¿Realmente deceas cerrar el sistema?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If d = DialogResult.Yes Then
            End
        End If

    End Sub

    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        frm_ventas.TopLevel = False
        frm_ventas.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_ventas.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_ventas)
        lbl_donde_estoy.Text = "VENTAS"
        frm_caja.Hide()
        frm_productos.Hide()
        frm_provedor.Hide()
        frm_inventario.Hide()
        frm_almacen.Hide()
        frm_usuarios.Hide()
        frm_gastos.Hide()
        frm_clientes.Hide()
        frm_home.Hide()
        frm_categorias.Hide()
        frm_compras.Hide()
        frm_ventas.Show()
    End Sub

    Private Sub btn_inventario_Click(sender As Object, e As EventArgs) Handles btn_inventario.Click
        frm_inventario.TopLevel = False
        frm_inventario.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_inventario.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_inventario)
        lbl_donde_estoy.Text = "INVENTARIO"
        frm_caja.Hide()
        frm_provedor.Hide()
        frm_clientes.Hide()
        frm_home.Hide()
        frm_ventas.Hide()
        frm_gastos.Hide()
        frm_almacen.Hide()
        frm_usuarios.Hide()
        frm_compras.Hide()
        frm_productos.Hide()
        frm_categorias.Hide()
        frm_inventario.Show()
    End Sub

    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        frm_usuarios.TopLevel = False
        frm_usuarios.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_usuarios.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_usuarios)
        lbl_donde_estoy.Text = "USUARIOS"
        frm_caja.Hide()
        frm_provedor.Hide()
        frm_clientes.Hide()
        frm_home.Hide()
        frm_ventas.Hide()
        frm_almacen.Hide()
        frm_gastos.Hide()
        frm_inventario.Hide()
        frm_compras.Hide()
        frm_productos.Hide()
        frm_categorias.Hide()
        frm_usuarios.Show()
    End Sub

    Private Sub btnGastos_Click(sender As Object, e As EventArgs) Handles btnGastos.Click
        frm_gastos.TopLevel = False
        frm_gastos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_gastos.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(frm_gastos)
        lbl_donde_estoy.Text = "GASTOS"
        frm_caja.Hide()
        frm_provedor.Hide()
        frm_clientes.Hide()
        frm_home.Hide()
        frm_ventas.Hide()
        frm_almacen.Hide()
        frm_inventario.Hide()
        frm_compras.Hide()
        frm_productos.Hide()
        frm_categorias.Hide()
        frm_usuarios.Hide()
        frm_gastos.Show()
    End Sub



    Private Sub Panel1_DoubleClick(sender As Object, e As EventArgs) Handles Panel1.DoubleClick
        If WindowState = FormWindowState.Normal Then
            btn_restaurar.Visible = True
            btn_maximixar.Visible = False
            WindowState = FormWindowState.Maximized
        Else
            btn_restaurar.Visible = False
            btn_maximixar.Visible = True
            WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        End
    End Sub
End Class
