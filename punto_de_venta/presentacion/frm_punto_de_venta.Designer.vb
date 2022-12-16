<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_punto_de_venta
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_punto_de_venta))
        Me.datalistado_articulos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New CTSkinet.CTSkinetButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_recibido = New System.Windows.Forms.TextBox()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.txt_buscar_producto = New System.Windows.Forms.TextBox()
        Me.btn_cobrar = New CTSkinet.CTSkinetButton()
        Me.btn_cancelar = New CTSkinet.CTSkinetButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_agregar_producto = New CTSkinet.CTSkinetButton()
        Me.txt_cantitdad_flag1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_existencia = New System.Windows.Forms.TextBox()
        Me.lbl_descuento = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_sub_total = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_producto = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_precio_por_cantidad = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_total_de_articulos = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CH_DESCUENTO = New System.Windows.Forms.CheckBox()
        Me.cbo_forma_de_pago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.link_buscar_producto = New System.Windows.Forms.LinkLabel()
        Me.link_buscar_clientes = New System.Windows.Forms.LinkLabel()
        Me.lbl_id_producto = New System.Windows.Forms.Label()
        Me.lbl_precio_normal = New System.Windows.Forms.Label()
        Me.lbl_precio_por_mayoreo = New System.Windows.Forms.Label()
        Me.lbl_cantidad_por_mayoreo = New System.Windows.Forms.Label()
        Me.datalistado_productos = New System.Windows.Forms.DataGridView()
        Me.grb_conenedor = New System.Windows.Forms.GroupBox()
        Me.lbl_id_venta = New System.Windows.Forms.Label()
        Me.c_menu_articulos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_ganancia = New System.Windows.Forms.Label()
        Me.lbl_clientes = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_fecha_de_vencimiento = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RB_NO = New System.Windows.Forms.RadioButton()
        Me.RB_SI = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_rnc_cliente = New System.Windows.Forms.TextBox()
        Me.txt_nombre_de_empresa = New System.Windows.Forms.TextBox()
        Me.lbl_itbis = New System.Windows.Forms.Label()
        Me.lbl_precio_con_descuento = New System.Windows.Forms.Label()
        Me.lbl_activo_descuento = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        CType(Me.datalistado_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_conenedor.SuspendLayout()
        Me.c_menu_articulos.SuspendLayout()
        Me.SuspendLayout()
        '
        'datalistado_articulos
        '
        Me.datalistado_articulos.AllowUserToAddRows = False
        Me.datalistado_articulos.AllowUserToDeleteRows = False
        Me.datalistado_articulos.AllowUserToResizeColumns = False
        Me.datalistado_articulos.AllowUserToResizeRows = False
        Me.datalistado_articulos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datalistado_articulos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.datalistado_articulos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado_articulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistado_articulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_articulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_articulos.ColumnHeadersHeight = 25
        Me.datalistado_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datalistado_articulos.GridColor = System.Drawing.SystemColors.Control
        Me.datalistado_articulos.Location = New System.Drawing.Point(6, 138)
        Me.datalistado_articulos.Name = "datalistado_articulos"
        Me.datalistado_articulos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_articulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_articulos.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.datalistado_articulos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_articulos.Size = New System.Drawing.Size(563, 251)
        Me.datalistado_articulos.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 30)
        Me.Panel1.TabIndex = 19
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(816, -1)
        Me.btn_cerrar.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(33, 30)
        Me.btn_cerrar.TabIndex = 574
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(348, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Registro de venta"
        '
        'txt_recibido
        '
        Me.txt_recibido.BackColor = System.Drawing.Color.White
        Me.txt_recibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recibido.Location = New System.Drawing.Point(126, 73)
        Me.txt_recibido.MaxLength = 6
        Me.txt_recibido.Name = "txt_recibido"
        Me.txt_recibido.Size = New System.Drawing.Size(85, 26)
        Me.txt_recibido.TabIndex = 20
        '
        'txt_descuento
        '
        Me.txt_descuento.BackColor = System.Drawing.Color.White
        Me.txt_descuento.Enabled = False
        Me.txt_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descuento.Location = New System.Drawing.Point(126, 14)
        Me.txt_descuento.MaxLength = 6
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(85, 26)
        Me.txt_descuento.TabIndex = 20
        Me.txt_descuento.Text = "0"
        '
        'txt_buscar_producto
        '
        Me.txt_buscar_producto.Location = New System.Drawing.Point(7, 114)
        Me.txt_buscar_producto.MaxLength = 150
        Me.txt_buscar_producto.Name = "txt_buscar_producto"
        Me.txt_buscar_producto.Size = New System.Drawing.Size(473, 20)
        Me.txt_buscar_producto.TabIndex = 20
        '
        'btn_cobrar
        '
        Me.btn_cobrar.BackColor = System.Drawing.Color.White
        Me.btn_cobrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cobrar.FlatAppearance.BorderSize = 0
        Me.btn_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cobrar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cobrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_cobrar.Location = New System.Drawing.Point(710, 385)
        Me.btn_cobrar.MainColor = System.Drawing.Color.White
        Me.btn_cobrar.Name = "btn_cobrar"
        Me.btn_cobrar.Size = New System.Drawing.Size(95, 35)
        Me.btn_cobrar.TabIndex = 21
        Me.btn_cobrar.Text = "Cobrar"
        Me.btn_cobrar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.White
        Me.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(575, 385)
        Me.btn_cancelar.MainColor = System.Drawing.Color.White
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(109, 35)
        Me.btn_cancelar.TabIndex = 21
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_agregar_producto)
        Me.GroupBox1.Controls.Add(Me.txt_cantitdad_flag1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_precio)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_precio)
        Me.GroupBox1.Controls.Add(Me.txt_existencia)
        Me.GroupBox1.Location = New System.Drawing.Point(575, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 153)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'btn_agregar_producto
        '
        Me.btn_agregar_producto.BackColor = System.Drawing.Color.White
        Me.btn_agregar_producto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_agregar_producto.FlatAppearance.BorderSize = 0
        Me.btn_agregar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar_producto.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_agregar_producto.Location = New System.Drawing.Point(61, 105)
        Me.btn_agregar_producto.MainColor = System.Drawing.Color.White
        Me.btn_agregar_producto.Name = "btn_agregar_producto"
        Me.btn_agregar_producto.Size = New System.Drawing.Size(150, 35)
        Me.btn_agregar_producto.TabIndex = 29
        Me.btn_agregar_producto.Text = "Agregar articulo"
        Me.btn_agregar_producto.UseVisualStyleBackColor = False
        '
        'txt_cantitdad_flag1
        '
        Me.txt_cantitdad_flag1.BackColor = System.Drawing.Color.White
        Me.txt_cantitdad_flag1.Location = New System.Drawing.Point(93, 77)
        Me.txt_cantitdad_flag1.MaxLength = 3
        Me.txt_cantitdad_flag1.Name = "txt_cantitdad_flag1"
        Me.txt_cantitdad_flag1.Size = New System.Drawing.Size(45, 20)
        Me.txt_cantitdad_flag1.TabIndex = 52
        Me.txt_cantitdad_flag1.Text = "1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(44, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Cant:"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.Location = New System.Drawing.Point(33, 50)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(57, 20)
        Me.lbl_precio.TabIndex = 0
        Me.lbl_precio.Text = "Precio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Existencia:"
        '
        'txt_precio
        '
        Me.txt_precio.BackColor = System.Drawing.Color.White
        Me.txt_precio.Enabled = False
        Me.txt_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.Location = New System.Drawing.Point(93, 46)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(85, 26)
        Me.txt_precio.TabIndex = 20
        '
        'txt_existencia
        '
        Me.txt_existencia.BackColor = System.Drawing.Color.White
        Me.txt_existencia.Enabled = False
        Me.txt_existencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_existencia.Location = New System.Drawing.Point(93, 15)
        Me.txt_existencia.Name = "txt_existencia"
        Me.txt_existencia.Size = New System.Drawing.Size(85, 26)
        Me.txt_existencia.TabIndex = 20
        '
        'lbl_descuento
        '
        Me.lbl_descuento.AutoSize = True
        Me.lbl_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descuento.Location = New System.Drawing.Point(129, 424)
        Me.lbl_descuento.Name = "lbl_descuento"
        Me.lbl_descuento.Size = New System.Drawing.Size(18, 20)
        Me.lbl_descuento.TabIndex = 0
        Me.lbl_descuento.Text = "0"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(129, 464)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(18, 20)
        Me.lbl_total.TabIndex = 0
        Me.lbl_total.Text = "0"
        '
        'lbl_sub_total
        '
        Me.lbl_sub_total.AutoSize = True
        Me.lbl_sub_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sub_total.Location = New System.Drawing.Point(129, 444)
        Me.lbl_sub_total.Name = "lbl_sub_total"
        Me.lbl_sub_total.Size = New System.Drawing.Size(18, 20)
        Me.lbl_sub_total.TabIndex = 0
        Me.lbl_sub_total.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_producto)
        Me.Panel2.Location = New System.Drawing.Point(6, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(563, 26)
        Me.Panel2.TabIndex = 23
        '
        'lbl_producto
        '
        Me.lbl_producto.AutoSize = True
        Me.lbl_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_producto.ForeColor = System.Drawing.Color.White
        Me.lbl_producto.Location = New System.Drawing.Point(7, 5)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(53, 15)
        Me.lbl_producto.TabIndex = 0
        Me.lbl_producto.Text = "Articulos"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbl_precio_por_cantidad)
        Me.Panel3.Location = New System.Drawing.Point(575, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(251, 26)
        Me.Panel3.TabIndex = 24
        '
        'lbl_precio_por_cantidad
        '
        Me.lbl_precio_por_cantidad.AutoSize = True
        Me.lbl_precio_por_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio_por_cantidad.ForeColor = System.Drawing.Color.White
        Me.lbl_precio_por_cantidad.Location = New System.Drawing.Point(74, 4)
        Me.lbl_precio_por_cantidad.Name = "lbl_precio_por_cantidad"
        Me.lbl_precio_por_cantidad.Size = New System.Drawing.Size(0, 18)
        Me.lbl_precio_por_cantidad.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descuento $:"
        '
        'lbl_total_de_articulos
        '
        Me.lbl_total_de_articulos.AutoSize = True
        Me.lbl_total_de_articulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_de_articulos.Location = New System.Drawing.Point(129, 404)
        Me.lbl_total_de_articulos.Name = "lbl_total_de_articulos"
        Me.lbl_total_de_articulos.Size = New System.Drawing.Size(18, 20)
        Me.lbl_total_de_articulos.TabIndex = 0
        Me.lbl_total_de_articulos.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CH_DESCUENTO)
        Me.GroupBox2.Controls.Add(Me.cbo_forma_de_pago)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_recibido)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_descuento)
        Me.GroupBox2.Location = New System.Drawing.Point(575, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 133)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'CH_DESCUENTO
        '
        Me.CH_DESCUENTO.AutoSize = True
        Me.CH_DESCUENTO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CH_DESCUENTO.Location = New System.Drawing.Point(124, 108)
        Me.CH_DESCUENTO.Name = "CH_DESCUENTO"
        Me.CH_DESCUENTO.Size = New System.Drawing.Size(93, 17)
        Me.CH_DESCUENTO.TabIndex = 52
        Me.CH_DESCUENTO.Text = "DESCUENTO"
        Me.CH_DESCUENTO.UseVisualStyleBackColor = True
        '
        'cbo_forma_de_pago
        '
        Me.cbo_forma_de_pago.BackColor = System.Drawing.Color.White
        Me.cbo_forma_de_pago.FormattingEnabled = True
        Me.cbo_forma_de_pago.Items.AddRange(New Object() {"EFECTIVO"})
        Me.cbo_forma_de_pago.Location = New System.Drawing.Point(126, 46)
        Me.cbo_forma_de_pago.Name = "cbo_forma_de_pago"
        Me.cbo_forma_de_pago.Size = New System.Drawing.Size(85, 21)
        Me.cbo_forma_de_pago.TabIndex = 21
        Me.cbo_forma_de_pago.Text = "EFECTIVO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Recibido $:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Forma de pago:"
        '
        'link_buscar_producto
        '
        Me.link_buscar_producto.AutoSize = True
        Me.link_buscar_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_buscar_producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.link_buscar_producto.LinkColor = System.Drawing.Color.Black
        Me.link_buscar_producto.Location = New System.Drawing.Point(495, 114)
        Me.link_buscar_producto.Name = "link_buscar_producto"
        Me.link_buscar_producto.Size = New System.Drawing.Size(76, 18)
        Me.link_buscar_producto.TabIndex = 27
        Me.link_buscar_producto.TabStop = True
        Me.link_buscar_producto.Text = "BUSCAR"
        '
        'link_buscar_clientes
        '
        Me.link_buscar_clientes.AutoSize = True
        Me.link_buscar_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_buscar_clientes.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.link_buscar_clientes.Location = New System.Drawing.Point(651, 38)
        Me.link_buscar_clientes.Name = "link_buscar_clientes"
        Me.link_buscar_clientes.Size = New System.Drawing.Size(162, 20)
        Me.link_buscar_clientes.TabIndex = 28
        Me.link_buscar_clientes.TabStop = True
        Me.link_buscar_clientes.Text = "BUSCAR CLEINTE"
        '
        'lbl_id_producto
        '
        Me.lbl_id_producto.AutoSize = True
        Me.lbl_id_producto.Location = New System.Drawing.Point(524, 38)
        Me.lbl_id_producto.Name = "lbl_id_producto"
        Me.lbl_id_producto.Size = New System.Drawing.Size(45, 13)
        Me.lbl_id_producto.TabIndex = 29
        Me.lbl_id_producto.Text = "Label12"
        Me.lbl_id_producto.Visible = False
        '
        'lbl_precio_normal
        '
        Me.lbl_precio_normal.AutoSize = True
        Me.lbl_precio_normal.Location = New System.Drawing.Point(639, 419)
        Me.lbl_precio_normal.Name = "lbl_precio_normal"
        Me.lbl_precio_normal.Size = New System.Drawing.Size(45, 13)
        Me.lbl_precio_normal.TabIndex = 30
        Me.lbl_precio_normal.Text = "Label12"
        Me.lbl_precio_normal.Visible = False
        '
        'lbl_precio_por_mayoreo
        '
        Me.lbl_precio_por_mayoreo.AutoSize = True
        Me.lbl_precio_por_mayoreo.Location = New System.Drawing.Point(582, 460)
        Me.lbl_precio_por_mayoreo.Name = "lbl_precio_por_mayoreo"
        Me.lbl_precio_por_mayoreo.Size = New System.Drawing.Size(45, 13)
        Me.lbl_precio_por_mayoreo.TabIndex = 31
        Me.lbl_precio_por_mayoreo.Text = "Label12"
        Me.lbl_precio_por_mayoreo.Visible = False
        '
        'lbl_cantidad_por_mayoreo
        '
        Me.lbl_cantidad_por_mayoreo.AutoSize = True
        Me.lbl_cantidad_por_mayoreo.Location = New System.Drawing.Point(647, 441)
        Me.lbl_cantidad_por_mayoreo.Name = "lbl_cantidad_por_mayoreo"
        Me.lbl_cantidad_por_mayoreo.Size = New System.Drawing.Size(45, 13)
        Me.lbl_cantidad_por_mayoreo.TabIndex = 31
        Me.lbl_cantidad_por_mayoreo.Text = "Label12"
        Me.lbl_cantidad_por_mayoreo.Visible = False
        '
        'datalistado_productos
        '
        Me.datalistado_productos.AllowUserToAddRows = False
        Me.datalistado_productos.AllowUserToDeleteRows = False
        Me.datalistado_productos.AllowUserToResizeColumns = False
        Me.datalistado_productos.AllowUserToResizeRows = False
        Me.datalistado_productos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datalistado_productos.BackgroundColor = System.Drawing.Color.White
        Me.datalistado_productos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistado_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_productos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datalistado_productos.ColumnHeadersHeight = 25
        Me.datalistado_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datalistado_productos.GridColor = System.Drawing.SystemColors.Control
        Me.datalistado_productos.Location = New System.Drawing.Point(0, 11)
        Me.datalistado_productos.Name = "datalistado_productos"
        Me.datalistado_productos.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_productos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.datalistado_productos.RowHeadersVisible = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.datalistado_productos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.datalistado_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_productos.Size = New System.Drawing.Size(472, 97)
        Me.datalistado_productos.TabIndex = 32
        '
        'grb_conenedor
        '
        Me.grb_conenedor.Controls.Add(Me.datalistado_productos)
        Me.grb_conenedor.Location = New System.Drawing.Point(8, 126)
        Me.grb_conenedor.Name = "grb_conenedor"
        Me.grb_conenedor.Size = New System.Drawing.Size(472, 97)
        Me.grb_conenedor.TabIndex = 33
        Me.grb_conenedor.TabStop = False
        '
        'lbl_id_venta
        '
        Me.lbl_id_venta.AutoSize = True
        Me.lbl_id_venta.Location = New System.Drawing.Point(698, 460)
        Me.lbl_id_venta.Name = "lbl_id_venta"
        Me.lbl_id_venta.Size = New System.Drawing.Size(45, 13)
        Me.lbl_id_venta.TabIndex = 34
        Me.lbl_id_venta.Text = "Label12"
        Me.lbl_id_venta.Visible = False
        '
        'c_menu_articulos
        '
        Me.c_menu_articulos.BackColor = System.Drawing.Color.White
        Me.c_menu_articulos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.c_menu_articulos.Name = "c_menu_articulos"
        Me.c_menu_articulos.Size = New System.Drawing.Size(123, 26)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.EliminarToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'lbl_ganancia
        '
        Me.lbl_ganancia.AutoSize = True
        Me.lbl_ganancia.Location = New System.Drawing.Point(274, 38)
        Me.lbl_ganancia.Name = "lbl_ganancia"
        Me.lbl_ganancia.Size = New System.Drawing.Size(51, 13)
        Me.lbl_ganancia.TabIndex = 35
        Me.lbl_ganancia.Text = "gannacia"
        Me.lbl_ganancia.Visible = False
        '
        'lbl_clientes
        '
        Me.lbl_clientes.AutoSize = True
        Me.lbl_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_clientes.Location = New System.Drawing.Point(83, 33)
        Me.lbl_clientes.Name = "lbl_clientes"
        Me.lbl_clientes.Size = New System.Drawing.Size(0, 20)
        Me.lbl_clientes.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(2, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "CLIENTE:"
        '
        'lbl_fecha_de_vencimiento
        '
        Me.lbl_fecha_de_vencimiento.AutoSize = True
        Me.lbl_fecha_de_vencimiento.Location = New System.Drawing.Point(650, 460)
        Me.lbl_fecha_de_vencimiento.Name = "lbl_fecha_de_vencimiento"
        Me.lbl_fecha_de_vencimiento.Size = New System.Drawing.Size(34, 13)
        Me.lbl_fecha_de_vencimiento.TabIndex = 38
        Me.lbl_fecha_de_vencimiento.Text = "fecha"
        Me.lbl_fecha_de_vencimiento.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Total de articulos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 421)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Descuento $:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Total:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(54, 441)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 20)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Sub total:"
        '
        'RB_NO
        '
        Me.RB_NO.AutoSize = True
        Me.RB_NO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.RB_NO.Location = New System.Drawing.Point(242, 65)
        Me.RB_NO.Name = "RB_NO"
        Me.RB_NO.Size = New System.Drawing.Size(41, 17)
        Me.RB_NO.TabIndex = 40
        Me.RB_NO.TabStop = True
        Me.RB_NO.Text = "NO"
        Me.RB_NO.UseVisualStyleBackColor = True
        Me.RB_NO.Visible = False
        '
        'RB_SI
        '
        Me.RB_SI.AutoSize = True
        Me.RB_SI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.RB_SI.Location = New System.Drawing.Point(192, 65)
        Me.RB_SI.Name = "RB_SI"
        Me.RB_SI.Size = New System.Drawing.Size(35, 17)
        Me.RB_SI.TabIndex = 41
        Me.RB_SI.TabStop = True
        Me.RB_SI.Text = "SI"
        Me.RB_SI.UseVisualStyleBackColor = True
        Me.RB_SI.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(298, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "RNC/Cedula Cliente:"
        Me.Label8.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(526, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Nombre o Empresa:"
        Me.Label13.Visible = False
        '
        'txt_rnc_cliente
        '
        Me.txt_rnc_cliente.Location = New System.Drawing.Point(407, 61)
        Me.txt_rnc_cliente.MaxLength = 11
        Me.txt_rnc_cliente.Name = "txt_rnc_cliente"
        Me.txt_rnc_cliente.Size = New System.Drawing.Size(113, 20)
        Me.txt_rnc_cliente.TabIndex = 43
        Me.txt_rnc_cliente.Visible = False
        '
        'txt_nombre_de_empresa
        '
        Me.txt_nombre_de_empresa.Location = New System.Drawing.Point(631, 60)
        Me.txt_nombre_de_empresa.Name = "txt_nombre_de_empresa"
        Me.txt_nombre_de_empresa.Size = New System.Drawing.Size(108, 20)
        Me.txt_nombre_de_empresa.TabIndex = 44
        Me.txt_nombre_de_empresa.Visible = False
        '
        'lbl_itbis
        '
        Me.lbl_itbis.AutoSize = True
        Me.lbl_itbis.Location = New System.Drawing.Point(422, 460)
        Me.lbl_itbis.Name = "lbl_itbis"
        Me.lbl_itbis.Size = New System.Drawing.Size(45, 13)
        Me.lbl_itbis.TabIndex = 45
        Me.lbl_itbis.Text = "Label15"
        Me.lbl_itbis.Visible = False
        '
        'lbl_precio_con_descuento
        '
        Me.lbl_precio_con_descuento.AutoSize = True
        Me.lbl_precio_con_descuento.Location = New System.Drawing.Point(698, 431)
        Me.lbl_precio_con_descuento.Name = "lbl_precio_con_descuento"
        Me.lbl_precio_con_descuento.Size = New System.Drawing.Size(45, 13)
        Me.lbl_precio_con_descuento.TabIndex = 47
        Me.lbl_precio_con_descuento.Text = "Label15"
        Me.lbl_precio_con_descuento.Visible = False
        '
        'lbl_activo_descuento
        '
        Me.lbl_activo_descuento.AutoSize = True
        Me.lbl_activo_descuento.Location = New System.Drawing.Point(257, 446)
        Me.lbl_activo_descuento.Name = "lbl_activo_descuento"
        Me.lbl_activo_descuento.Size = New System.Drawing.Size(45, 13)
        Me.lbl_activo_descuento.TabIndex = 48
        Me.lbl_activo_descuento.Text = "Label15"
        Me.lbl_activo_descuento.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(5, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(181, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "¿FACTURA CON COMPROBANTE?"
        Me.Label14.Visible = False
        '
        'cbo_tipo
        '
        Me.cbo_tipo.BackColor = System.Drawing.Color.White
        Me.cbo_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_tipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Items.AddRange(New Object() {"CONTADO", "A CREDITO"})
        Me.cbo_tipo.Location = New System.Drawing.Point(448, 393)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(121, 21)
        Me.cbo_tipo.TabIndex = 50
        Me.cbo_tipo.Text = "CONTADO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(365, 394)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 15)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "CONDICION:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(351, 38)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(45, 13)
        Me.lblCategoria.TabIndex = 52
        Me.lblCategoria.Text = "Label16"
        Me.lblCategoria.Visible = False
        '
        'frm_punto_de_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(849, 492)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbo_tipo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.RB_NO)
        Me.Controls.Add(Me.RB_SI)
        Me.Controls.Add(Me.txt_rnc_cliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_activo_descuento)
        Me.Controls.Add(Me.lbl_precio_con_descuento)
        Me.Controls.Add(Me.lbl_itbis)
        Me.Controls.Add(Me.txt_nombre_de_empresa)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_fecha_de_vencimiento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_clientes)
        Me.Controls.Add(Me.lbl_ganancia)
        Me.Controls.Add(Me.lbl_id_venta)
        Me.Controls.Add(Me.txt_buscar_producto)
        Me.Controls.Add(Me.grb_conenedor)
        Me.Controls.Add(Me.lbl_cantidad_por_mayoreo)
        Me.Controls.Add(Me.lbl_precio_por_mayoreo)
        Me.Controls.Add(Me.lbl_precio_normal)
        Me.Controls.Add(Me.lbl_id_producto)
        Me.Controls.Add(Me.link_buscar_clientes)
        Me.Controls.Add(Me.lbl_descuento)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.link_buscar_producto)
        Me.Controls.Add(Me.lbl_sub_total)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lbl_total_de_articulos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.datalistado_articulos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_cobrar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_punto_de_venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Punto de venta"
        CType(Me.datalistado_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_conenedor.ResumeLayout(False)
        Me.c_menu_articulos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datalistado_articulos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_recibido As TextBox
    Friend WithEvents txt_descuento As TextBox
    Friend WithEvents txt_buscar_producto As TextBox
    Friend WithEvents btn_cobrar As CTSkinet.CTSkinetButton
    Friend WithEvents btn_cancelar As CTSkinet.CTSkinetButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_descuento As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_sub_total As Label
    Friend WithEvents lbl_total_de_articulos As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_producto As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_cerrar As CTSkinet.CTSkinetButton
    Friend WithEvents link_buscar_producto As LinkLabel
    Friend WithEvents link_buscar_clientes As LinkLabel
    Friend WithEvents btn_agregar_producto As CTSkinet.CTSkinetButton
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_precio As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents txt_existencia As TextBox
    Friend WithEvents lbl_id_producto As Label
    Friend WithEvents lbl_precio_normal As Label
    Friend WithEvents lbl_precio_por_mayoreo As Label
    Friend WithEvents lbl_cantidad_por_mayoreo As Label
    Friend WithEvents datalistado_productos As DataGridView
    Friend WithEvents grb_conenedor As GroupBox
    Friend WithEvents lbl_id_venta As Label
    Friend WithEvents lbl_precio_por_cantidad As Label
    Friend WithEvents c_menu_articulos As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_ganancia As Label
    Friend WithEvents lbl_clientes As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_fecha_de_vencimiento As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbo_forma_de_pago As ComboBox
    Friend WithEvents RB_NO As RadioButton
    Friend WithEvents RB_SI As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_rnc_cliente As TextBox
    Friend WithEvents txt_nombre_de_empresa As TextBox
    Friend WithEvents lbl_itbis As Label
    Friend WithEvents lbl_precio_con_descuento As Label
    Friend WithEvents lbl_activo_descuento As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbo_tipo As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_cantitdad_flag1 As TextBox
    Friend WithEvents CH_DESCUENTO As CheckBox
    Friend WithEvents lblCategoria As Label
End Class
