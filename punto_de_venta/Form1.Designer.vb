<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel_menu = New System.Windows.Forms.Panel()
        Me.btnGastos = New CTSkinet.CTSkinetButton()
        Me.btn_usuarios = New CTSkinet.CTSkinetButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_home = New CTSkinet.CTSkinetButton()
        Me.btn_compras = New CTSkinet.CTSkinetButton()
        Me.btn_proveedor = New CTSkinet.CTSkinetButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_inventario = New CTSkinet.CTSkinetButton()
        Me.btn_salir = New CTSkinet.CTSkinetButton()
        Me.btn_caja = New CTSkinet.CTSkinetButton()
        Me.btn_ventas = New CTSkinet.CTSkinetButton()
        Me.btn_clientes = New CTSkinet.CTSkinetButton()
        Me.btn_categorias = New CTSkinet.CTSkinetButton()
        Me.btn_almacen = New CTSkinet.CTSkinetButton()
        Me.btn_productos = New CTSkinet.CTSkinetButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_restaurar = New System.Windows.Forms.PictureBox()
        Me.lbl_donde_estoy = New System.Windows.Forms.Label()
        Me.btn_maximixar = New System.Windows.Forms.PictureBox()
        Me.btn_minimixar = New System.Windows.Forms.PictureBox()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_ajustar_menu = New System.Windows.Forms.PictureBox()
        Me.panel_contenedor = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_permiso = New System.Windows.Forms.Label()
        Me.lbl_nombre_de_usuario = New System.Windows.Forms.Label()
        Me.lbl_turno = New System.Windows.Forms.Label()
        Me.lbl_id_usuario = New System.Windows.Forms.Label()
        Me.panel_menu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_maximixar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimixar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_ajustar_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_contenedor.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_menu
        '
        Me.panel_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.panel_menu.Controls.Add(Me.btnGastos)
        Me.panel_menu.Controls.Add(Me.btn_usuarios)
        Me.panel_menu.Controls.Add(Me.PictureBox2)
        Me.panel_menu.Controls.Add(Me.btn_home)
        Me.panel_menu.Controls.Add(Me.btn_compras)
        Me.panel_menu.Controls.Add(Me.btn_proveedor)
        Me.panel_menu.Controls.Add(Me.Label2)
        Me.panel_menu.Controls.Add(Me.Label1)
        Me.panel_menu.Controls.Add(Me.btn_inventario)
        Me.panel_menu.Controls.Add(Me.btn_salir)
        Me.panel_menu.Controls.Add(Me.btn_caja)
        Me.panel_menu.Controls.Add(Me.btn_ventas)
        Me.panel_menu.Controls.Add(Me.btn_clientes)
        Me.panel_menu.Controls.Add(Me.btn_categorias)
        Me.panel_menu.Controls.Add(Me.btn_almacen)
        Me.panel_menu.Controls.Add(Me.btn_productos)
        Me.panel_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_menu.Location = New System.Drawing.Point(0, 0)
        Me.panel_menu.Name = "panel_menu"
        Me.panel_menu.Size = New System.Drawing.Size(260, 689)
        Me.panel_menu.TabIndex = 1
        '
        'btnGastos
        '
        Me.btnGastos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnGastos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnGastos.FlatAppearance.BorderSize = 0
        Me.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGastos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGastos.ForeColor = System.Drawing.SystemColors.Window
        Me.btnGastos.Image = CType(resources.GetObject("btnGastos.Image"), System.Drawing.Image)
        Me.btnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGastos.Location = New System.Drawing.Point(0, 572)
        Me.btnGastos.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnGastos.Name = "btnGastos"
        Me.btnGastos.Size = New System.Drawing.Size(267, 35)
        Me.btnGastos.TabIndex = 9
        Me.btnGastos.Text = "            Gastos"
        Me.btnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGastos.UseVisualStyleBackColor = False
        '
        'btn_usuarios
        '
        Me.btn_usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_usuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_usuarios.FlatAppearance.BorderSize = 0
        Me.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_usuarios.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_usuarios.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_usuarios.Image = CType(resources.GetObject("btn_usuarios.Image"), System.Drawing.Image)
        Me.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_usuarios.Location = New System.Drawing.Point(-1, 519)
        Me.btn_usuarios.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(267, 35)
        Me.btn_usuarios.TabIndex = 8
        Me.btn_usuarios.Text = "           Usuarios"
        Me.btn_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_usuarios.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_home.FlatAppearance.BorderSize = 0
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_home.Image = CType(resources.GetObject("btn_home.Image"), System.Drawing.Image)
        Me.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.Location = New System.Drawing.Point(-1, 93)
        Me.btn_home.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(267, 35)
        Me.btn_home.TabIndex = 7
        Me.btn_home.Text = "          Dashboard"
        Me.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'btn_compras
        '
        Me.btn_compras.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_compras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_compras.FlatAppearance.BorderSize = 0
        Me.btn_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_compras.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_compras.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_compras.Image = CType(resources.GetObject("btn_compras.Image"), System.Drawing.Image)
        Me.btn_compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_compras.Location = New System.Drawing.Point(1, 421)
        Me.btn_compras.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_compras.Name = "btn_compras"
        Me.btn_compras.Size = New System.Drawing.Size(271, 35)
        Me.btn_compras.TabIndex = 6
        Me.btn_compras.Text = "          Compras"
        Me.btn_compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_compras.UseVisualStyleBackColor = False
        '
        'btn_proveedor
        '
        Me.btn_proveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_proveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_proveedor.FlatAppearance.BorderSize = 0
        Me.btn_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proveedor.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proveedor.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_proveedor.Image = CType(resources.GetObject("btn_proveedor.Image"), System.Drawing.Image)
        Me.btn_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_proveedor.Location = New System.Drawing.Point(1, 380)
        Me.btn_proveedor.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_proveedor.Name = "btn_proveedor"
        Me.btn_proveedor.Size = New System.Drawing.Size(271, 35)
        Me.btn_proveedor.TabIndex = 5
        Me.btn_proveedor.Text = "          Proveedor"
        Me.btn_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_proveedor.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(133, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "( PUNTO DE VENTA )"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "JR SOFT"
        '
        'btn_inventario
        '
        Me.btn_inventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_inventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_inventario.FlatAppearance.BorderSize = 0
        Me.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inventario.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inventario.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_inventario.Image = CType(resources.GetObject("btn_inventario.Image"), System.Drawing.Image)
        Me.btn_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_inventario.Location = New System.Drawing.Point(0, 469)
        Me.btn_inventario.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_inventario.Name = "btn_inventario"
        Me.btn_inventario.Size = New System.Drawing.Size(267, 35)
        Me.btn_inventario.TabIndex = 2
        Me.btn_inventario.Text = "          Inventario"
        Me.btn_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_inventario.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_salir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.Location = New System.Drawing.Point(0, 654)
        Me.btn_salir.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(260, 35)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_caja
        '
        Me.btn_caja.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_caja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_caja.FlatAppearance.BorderSize = 0
        Me.btn_caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_caja.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_caja.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_caja.Image = CType(resources.GetObject("btn_caja.Image"), System.Drawing.Image)
        Me.btn_caja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_caja.Location = New System.Drawing.Point(-1, 339)
        Me.btn_caja.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_caja.Name = "btn_caja"
        Me.btn_caja.Size = New System.Drawing.Size(271, 35)
        Me.btn_caja.TabIndex = 2
        Me.btn_caja.Text = "           Caja"
        Me.btn_caja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_caja.UseVisualStyleBackColor = False
        '
        'btn_ventas
        '
        Me.btn_ventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ventas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ventas.FlatAppearance.BorderSize = 0
        Me.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ventas.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ventas.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_ventas.Image = CType(resources.GetObject("btn_ventas.Image"), System.Drawing.Image)
        Me.btn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ventas.Location = New System.Drawing.Point(-1, 298)
        Me.btn_ventas.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ventas.Name = "btn_ventas"
        Me.btn_ventas.Size = New System.Drawing.Size(271, 35)
        Me.btn_ventas.TabIndex = 2
        Me.btn_ventas.Text = "           Ventas"
        Me.btn_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ventas.UseVisualStyleBackColor = False
        '
        'btn_clientes
        '
        Me.btn_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_clientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_clientes.FlatAppearance.BorderSize = 0
        Me.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clientes.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clientes.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_clientes.Image = CType(resources.GetObject("btn_clientes.Image"), System.Drawing.Image)
        Me.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clientes.Location = New System.Drawing.Point(0, 257)
        Me.btn_clientes.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(270, 35)
        Me.btn_clientes.TabIndex = 2
        Me.btn_clientes.Text = "          Clientes"
        Me.btn_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clientes.UseVisualStyleBackColor = False
        '
        'btn_categorias
        '
        Me.btn_categorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_categorias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_categorias.FlatAppearance.BorderSize = 0
        Me.btn_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_categorias.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_categorias.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_categorias.Image = CType(resources.GetObject("btn_categorias.Image"), System.Drawing.Image)
        Me.btn_categorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_categorias.Location = New System.Drawing.Point(-1, 216)
        Me.btn_categorias.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_categorias.Name = "btn_categorias"
        Me.btn_categorias.Size = New System.Drawing.Size(271, 35)
        Me.btn_categorias.TabIndex = 2
        Me.btn_categorias.Text = "          Categorias"
        Me.btn_categorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_categorias.UseVisualStyleBackColor = False
        '
        'btn_almacen
        '
        Me.btn_almacen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_almacen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_almacen.FlatAppearance.BorderSize = 0
        Me.btn_almacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_almacen.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_almacen.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_almacen.Image = CType(resources.GetObject("btn_almacen.Image"), System.Drawing.Image)
        Me.btn_almacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_almacen.Location = New System.Drawing.Point(-2, 175)
        Me.btn_almacen.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_almacen.Name = "btn_almacen"
        Me.btn_almacen.Size = New System.Drawing.Size(271, 35)
        Me.btn_almacen.TabIndex = 2
        Me.btn_almacen.Text = "           Almacen"
        Me.btn_almacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_almacen.UseVisualStyleBackColor = False
        '
        'btn_productos
        '
        Me.btn_productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_productos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_productos.FlatAppearance.BorderSize = 0
        Me.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productos.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_productos.Image = CType(resources.GetObject("btn_productos.Image"), System.Drawing.Image)
        Me.btn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_productos.Location = New System.Drawing.Point(-1, 134)
        Me.btn_productos.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(271, 35)
        Me.btn_productos.TabIndex = 2
        Me.btn_productos.Text = "          Productos"
        Me.btn_productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_productos.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_restaurar)
        Me.Panel1.Controls.Add(Me.lbl_donde_estoy)
        Me.Panel1.Controls.Add(Me.btn_maximixar)
        Me.Panel1.Controls.Add(Me.btn_minimixar)
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Controls.Add(Me.btn_ajustar_menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(260, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 36)
        Me.Panel1.TabIndex = 2
        '
        'btn_restaurar
        '
        Me.btn_restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_restaurar.Image = CType(resources.GetObject("btn_restaurar.Image"), System.Drawing.Image)
        Me.btn_restaurar.Location = New System.Drawing.Point(690, 5)
        Me.btn_restaurar.Name = "btn_restaurar"
        Me.btn_restaurar.Size = New System.Drawing.Size(20, 20)
        Me.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_restaurar.TabIndex = 3
        Me.btn_restaurar.TabStop = False
        '
        'lbl_donde_estoy
        '
        Me.lbl_donde_estoy.AutoSize = True
        Me.lbl_donde_estoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_donde_estoy.ForeColor = System.Drawing.Color.White
        Me.lbl_donde_estoy.Location = New System.Drawing.Point(66, 8)
        Me.lbl_donde_estoy.Name = "lbl_donde_estoy"
        Me.lbl_donde_estoy.Size = New System.Drawing.Size(56, 20)
        Me.lbl_donde_estoy.TabIndex = 4
        Me.lbl_donde_estoy.Text = "Home"
        '
        'btn_maximixar
        '
        Me.btn_maximixar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maximixar.Image = CType(resources.GetObject("btn_maximixar.Image"), System.Drawing.Image)
        Me.btn_maximixar.Location = New System.Drawing.Point(690, 5)
        Me.btn_maximixar.Name = "btn_maximixar"
        Me.btn_maximixar.Size = New System.Drawing.Size(20, 20)
        Me.btn_maximixar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_maximixar.TabIndex = 3
        Me.btn_maximixar.TabStop = False
        '
        'btn_minimixar
        '
        Me.btn_minimixar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimixar.Image = CType(resources.GetObject("btn_minimixar.Image"), System.Drawing.Image)
        Me.btn_minimixar.Location = New System.Drawing.Point(664, 5)
        Me.btn_minimixar.Name = "btn_minimixar"
        Me.btn_minimixar.Size = New System.Drawing.Size(20, 20)
        Me.btn_minimixar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimixar.TabIndex = 3
        Me.btn_minimixar.TabStop = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(716, 5)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(20, 20)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrar.TabIndex = 3
        Me.btn_cerrar.TabStop = False
        '
        'btn_ajustar_menu
        '
        Me.btn_ajustar_menu.Image = Global.punto_de_venta.My.Resources.Resources.Sin_título_1
        Me.btn_ajustar_menu.Location = New System.Drawing.Point(6, 9)
        Me.btn_ajustar_menu.Name = "btn_ajustar_menu"
        Me.btn_ajustar_menu.Size = New System.Drawing.Size(24, 20)
        Me.btn_ajustar_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_ajustar_menu.TabIndex = 2
        Me.btn_ajustar_menu.TabStop = False
        '
        'panel_contenedor
        '
        Me.panel_contenedor.Controls.Add(Me.Panel2)
        Me.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_contenedor.Location = New System.Drawing.Point(260, 36)
        Me.panel_contenedor.Name = "panel_contenedor"
        Me.panel_contenedor.Size = New System.Drawing.Size(748, 653)
        Me.panel_contenedor.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_permiso)
        Me.Panel2.Controls.Add(Me.lbl_nombre_de_usuario)
        Me.Panel2.Controls.Add(Me.lbl_turno)
        Me.Panel2.Controls.Add(Me.lbl_id_usuario)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 624)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(748, 29)
        Me.Panel2.TabIndex = 0
        '
        'lbl_permiso
        '
        Me.lbl_permiso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_permiso.AutoSize = True
        Me.lbl_permiso.ForeColor = System.Drawing.Color.White
        Me.lbl_permiso.Location = New System.Drawing.Point(136, 7)
        Me.lbl_permiso.Name = "lbl_permiso"
        Me.lbl_permiso.Size = New System.Drawing.Size(98, 13)
        Me.lbl_permiso.TabIndex = 3
        Me.lbl_permiso.Text = "ADMINISTRADOR"
        Me.lbl_permiso.Visible = False
        '
        'lbl_nombre_de_usuario
        '
        Me.lbl_nombre_de_usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre_de_usuario.AutoSize = True
        Me.lbl_nombre_de_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_de_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_nombre_de_usuario.Location = New System.Drawing.Point(553, 7)
        Me.lbl_nombre_de_usuario.Name = "lbl_nombre_de_usuario"
        Me.lbl_nombre_de_usuario.Size = New System.Drawing.Size(110, 13)
        Me.lbl_nombre_de_usuario.TabIndex = 2
        Me.lbl_nombre_de_usuario.Text = "JUNIOR JIMENEZ"
        '
        'lbl_turno
        '
        Me.lbl_turno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_turno.AutoSize = True
        Me.lbl_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_turno.ForeColor = System.Drawing.Color.White
        Me.lbl_turno.Location = New System.Drawing.Point(713, 7)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(22, 13)
        Me.lbl_turno.TabIndex = 1
        Me.lbl_turno.Text = "T1"
        '
        'lbl_id_usuario
        '
        Me.lbl_id_usuario.AutoSize = True
        Me.lbl_id_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_id_usuario.Location = New System.Drawing.Point(440, 7)
        Me.lbl_id_usuario.Name = "lbl_id_usuario"
        Me.lbl_id_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lbl_id_usuario.TabIndex = 0
        Me.lbl_id_usuario.Text = "1"
        Me.lbl_id_usuario.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 689)
        Me.Controls.Add(Me.panel_contenedor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Punto de venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_menu.ResumeLayout(False)
        Me.panel_menu.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_maximixar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimixar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_ajustar_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_contenedor.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_menu As Panel
    Friend WithEvents btn_productos As CTSkinet.CTSkinetButton
    Friend WithEvents btn_almacen As CTSkinet.CTSkinetButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_categorias As CTSkinet.CTSkinetButton
    Friend WithEvents btn_clientes As CTSkinet.CTSkinetButton
    Friend WithEvents btn_salir As CTSkinet.CTSkinetButton
    Friend WithEvents btn_caja As CTSkinet.CTSkinetButton
    Friend WithEvents btn_ventas As CTSkinet.CTSkinetButton
    Friend WithEvents btn_ajustar_menu As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_minimixar As PictureBox
    Friend WithEvents btn_restaurar As PictureBox
    Friend WithEvents btn_maximixar As PictureBox
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents panel_contenedor As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_donde_estoy As Label
    Friend WithEvents btn_proveedor As CTSkinet.CTSkinetButton
    Friend WithEvents btn_compras As CTSkinet.CTSkinetButton
    Friend WithEvents btn_home As CTSkinet.CTSkinetButton
    Friend WithEvents btn_inventario As CTSkinet.CTSkinetButton
    Friend WithEvents lbl_nombre_de_usuario As Label
    Friend WithEvents lbl_turno As Label
    Friend WithEvents lbl_id_usuario As Label
    Friend WithEvents lbl_permiso As Label
    Friend WithEvents btn_usuarios As CTSkinet.CTSkinetButton
    Friend WithEvents btnGastos As CTSkinet.CTSkinetButton
    Friend WithEvents Label2 As Label
End Class
