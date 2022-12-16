<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_inventario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_consultar_por_fecha = New CTSkinet.CTSkinetButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_dinero_en_producto = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_ventas_del_mes = New System.Windows.Forms.Label()
        Me.lbl_compras_del_mes = New System.Windows.Forms.Label()
        Me.lbl_ventas_de_la_semana = New System.Windows.Forms.Label()
        Me.lbl_ganancias_de_la_semana = New System.Windows.Forms.Label()
        Me.lbl_compras_de_la_semana = New System.Windows.Forms.Label()
        Me.lbl_dinero_en_caja = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_ganancias_del_mes = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_mantenimiento_por_30_dias = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_mantenimiento_por_semana = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_detalle_por_mes = New System.Windows.Forms.Label()
        Me.lbl_por_semanas_liquidos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_retirar_dinero = New CTSkinet.CTSkinetButton()
        Me.btn_historial_de_dinero_retirado = New CTSkinet.CTSkinetButton()
        Me.btn_comprobantes = New CTSkinet.CTSkinetButton()
        Me.btn_backup = New CTSkinet.CTSkinetButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_consultar_por_fecha)
        Me.Panel1.Location = New System.Drawing.Point(9, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 38)
        Me.Panel1.TabIndex = 2
        '
        'btn_consultar_por_fecha
        '
        Me.btn_consultar_por_fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_consultar_por_fecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_consultar_por_fecha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_consultar_por_fecha.FlatAppearance.BorderSize = 0
        Me.btn_consultar_por_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_consultar_por_fecha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar_por_fecha.ForeColor = System.Drawing.Color.White
        Me.btn_consultar_por_fecha.Location = New System.Drawing.Point(548, 3)
        Me.btn_consultar_por_fecha.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_consultar_por_fecha.Name = "btn_consultar_por_fecha"
        Me.btn_consultar_por_fecha.Size = New System.Drawing.Size(150, 35)
        Me.btn_consultar_por_fecha.TabIndex = 5
        Me.btn_consultar_por_fecha.Text = "Consultar por fechas"
        Me.btn_consultar_por_fecha.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbl_dinero_en_producto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbl_ventas_del_mes)
        Me.GroupBox1.Controls.Add(Me.lbl_compras_del_mes)
        Me.GroupBox1.Controls.Add(Me.lbl_ventas_de_la_semana)
        Me.GroupBox1.Controls.Add(Me.lbl_ganancias_de_la_semana)
        Me.GroupBox1.Controls.Add(Me.lbl_compras_de_la_semana)
        Me.GroupBox1.Controls.Add(Me.lbl_dinero_en_caja)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_ganancias_del_mes)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 287)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'lbl_dinero_en_producto
        '
        Me.lbl_dinero_en_producto.AutoSize = True
        Me.lbl_dinero_en_producto.Location = New System.Drawing.Point(597, 191)
        Me.lbl_dinero_en_producto.Name = "lbl_dinero_en_producto"
        Me.lbl_dinero_en_producto.Size = New System.Drawing.Size(28, 13)
        Me.lbl_dinero_en_producto.TabIndex = 7
        Me.lbl_dinero_en_producto.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(447, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "DINERO EN PRODUCTOS:"
        '
        'lbl_ventas_del_mes
        '
        Me.lbl_ventas_del_mes.AutoSize = True
        Me.lbl_ventas_del_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ventas_del_mes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_ventas_del_mes.Location = New System.Drawing.Point(596, 128)
        Me.lbl_ventas_del_mes.Name = "lbl_ventas_del_mes"
        Me.lbl_ventas_del_mes.Size = New System.Drawing.Size(32, 16)
        Me.lbl_ventas_del_mes.TabIndex = 5
        Me.lbl_ventas_del_mes.Text = "0.00"
        '
        'lbl_compras_del_mes
        '
        Me.lbl_compras_del_mes.AutoSize = True
        Me.lbl_compras_del_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_compras_del_mes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_compras_del_mes.Location = New System.Drawing.Point(594, 97)
        Me.lbl_compras_del_mes.Name = "lbl_compras_del_mes"
        Me.lbl_compras_del_mes.Size = New System.Drawing.Size(32, 16)
        Me.lbl_compras_del_mes.TabIndex = 5
        Me.lbl_compras_del_mes.Text = "0.00"
        '
        'lbl_ventas_de_la_semana
        '
        Me.lbl_ventas_de_la_semana.AutoSize = True
        Me.lbl_ventas_de_la_semana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ventas_de_la_semana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_ventas_de_la_semana.Location = New System.Drawing.Point(243, 128)
        Me.lbl_ventas_de_la_semana.Name = "lbl_ventas_de_la_semana"
        Me.lbl_ventas_de_la_semana.Size = New System.Drawing.Size(32, 16)
        Me.lbl_ventas_de_la_semana.TabIndex = 5
        Me.lbl_ventas_de_la_semana.Text = "0.00"
        '
        'lbl_ganancias_de_la_semana
        '
        Me.lbl_ganancias_de_la_semana.AutoSize = True
        Me.lbl_ganancias_de_la_semana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ganancias_de_la_semana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_ganancias_de_la_semana.Location = New System.Drawing.Point(243, 159)
        Me.lbl_ganancias_de_la_semana.Name = "lbl_ganancias_de_la_semana"
        Me.lbl_ganancias_de_la_semana.Size = New System.Drawing.Size(31, 15)
        Me.lbl_ganancias_de_la_semana.TabIndex = 5
        Me.lbl_ganancias_de_la_semana.Text = "0.00"
        '
        'lbl_compras_de_la_semana
        '
        Me.lbl_compras_de_la_semana.AutoSize = True
        Me.lbl_compras_de_la_semana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_compras_de_la_semana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_compras_de_la_semana.Location = New System.Drawing.Point(243, 97)
        Me.lbl_compras_de_la_semana.Name = "lbl_compras_de_la_semana"
        Me.lbl_compras_de_la_semana.Size = New System.Drawing.Size(32, 16)
        Me.lbl_compras_de_la_semana.TabIndex = 5
        Me.lbl_compras_de_la_semana.Text = "0.00"
        '
        'lbl_dinero_en_caja
        '
        Me.lbl_dinero_en_caja.AutoSize = True
        Me.lbl_dinero_en_caja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dinero_en_caja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_dinero_en_caja.Location = New System.Drawing.Point(165, 249)
        Me.lbl_dinero_en_caja.Name = "lbl_dinero_en_caja"
        Me.lbl_dinero_en_caja.Size = New System.Drawing.Size(16, 18)
        Me.lbl_dinero_en_caja.TabIndex = 5
        Me.lbl_dinero_en_caja.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(290, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(64, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "GANANCIAS DE LA SEMANA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(19, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DINERO EN CAJA:"
        '
        'lbl_ganancias_del_mes
        '
        Me.lbl_ganancias_del_mes.AutoSize = True
        Me.lbl_ganancias_del_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ganancias_del_mes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_ganancias_del_mes.Location = New System.Drawing.Point(597, 159)
        Me.lbl_ganancias_del_mes.Name = "lbl_ganancias_del_mes"
        Me.lbl_ganancias_del_mes.Size = New System.Drawing.Size(31, 15)
        Me.lbl_ganancias_del_mes.TabIndex = 5
        Me.lbl_ganancias_del_mes.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(380, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 15)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "GANANCIAS DEL ULTIMOS 30 DIAS:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "PRODUCTOS EN PUNTO DE REOREN:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(64, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "VENTAS DE LA SEMANA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(409, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "VENTAS ULTIMOS 30 DIAS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(50, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "COMPRAS DE LA SEMANA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(391, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "COMPRAS  ULTIMOS 30 DIAS:"
        '
        'lbl_mantenimiento_por_30_dias
        '
        Me.lbl_mantenimiento_por_30_dias.AutoSize = True
        Me.lbl_mantenimiento_por_30_dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mantenimiento_por_30_dias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_mantenimiento_por_30_dias.Location = New System.Drawing.Point(621, 467)
        Me.lbl_mantenimiento_por_30_dias.Name = "lbl_mantenimiento_por_30_dias"
        Me.lbl_mantenimiento_por_30_dias.Size = New System.Drawing.Size(32, 16)
        Me.lbl_mantenimiento_por_30_dias.TabIndex = 12
        Me.lbl_mantenimiento_por_30_dias.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(378, 467)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(237, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "MANTENIMIENTO ULTIMOS 30 DIAS:"
        '
        'lbl_mantenimiento_por_semana
        '
        Me.lbl_mantenimiento_por_semana.AutoSize = True
        Me.lbl_mantenimiento_por_semana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mantenimiento_por_semana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_mantenimiento_por_semana.Location = New System.Drawing.Point(256, 465)
        Me.lbl_mantenimiento_por_semana.Name = "lbl_mantenimiento_por_semana"
        Me.lbl_mantenimiento_por_semana.Size = New System.Drawing.Size(32, 16)
        Me.lbl_mantenimiento_por_semana.TabIndex = 10
        Me.lbl_mantenimiento_por_semana.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(33, 465)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(225, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "MANTENIMIENTO DE LA SEMANA:"
        '
        'lbl_detalle_por_mes
        '
        Me.lbl_detalle_por_mes.AutoSize = True
        Me.lbl_detalle_por_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_detalle_por_mes.Location = New System.Drawing.Point(583, 518)
        Me.lbl_detalle_por_mes.Name = "lbl_detalle_por_mes"
        Me.lbl_detalle_por_mes.Size = New System.Drawing.Size(32, 16)
        Me.lbl_detalle_por_mes.TabIndex = 8
        Me.lbl_detalle_por_mes.Text = "0.00"
        '
        'lbl_por_semanas_liquidos
        '
        Me.lbl_por_semanas_liquidos.AutoSize = True
        Me.lbl_por_semanas_liquidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_por_semanas_liquidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_por_semanas_liquidos.Location = New System.Drawing.Point(218, 518)
        Me.lbl_por_semanas_liquidos.Name = "lbl_por_semanas_liquidos"
        Me.lbl_por_semanas_liquidos.Size = New System.Drawing.Size(32, 16)
        Me.lbl_por_semanas_liquidos.TabIndex = 7
        Me.lbl_por_semanas_liquidos.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(358, 518)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(219, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "LIQUIDOS AL DETALLE POR MES:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(10, 518)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(210, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "LIQUIDOS AL DETALLE POR SM:"
        '
        'btn_retirar_dinero
        '
        Me.btn_retirar_dinero.BackColor = System.Drawing.Color.White
        Me.btn_retirar_dinero.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_retirar_dinero.FlatAppearance.BorderSize = 0
        Me.btn_retirar_dinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_retirar_dinero.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retirar_dinero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_retirar_dinero.Location = New System.Drawing.Point(9, 403)
        Me.btn_retirar_dinero.MainColor = System.Drawing.Color.White
        Me.btn_retirar_dinero.Name = "btn_retirar_dinero"
        Me.btn_retirar_dinero.Size = New System.Drawing.Size(150, 35)
        Me.btn_retirar_dinero.TabIndex = 4
        Me.btn_retirar_dinero.Text = "Retirar dinero"
        Me.btn_retirar_dinero.UseVisualStyleBackColor = False
        '
        'btn_historial_de_dinero_retirado
        '
        Me.btn_historial_de_dinero_retirado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_historial_de_dinero_retirado.BackColor = System.Drawing.Color.White
        Me.btn_historial_de_dinero_retirado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_historial_de_dinero_retirado.FlatAppearance.BorderSize = 0
        Me.btn_historial_de_dinero_retirado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_historial_de_dinero_retirado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_historial_de_dinero_retirado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_historial_de_dinero_retirado.Location = New System.Drawing.Point(436, 403)
        Me.btn_historial_de_dinero_retirado.MainColor = System.Drawing.Color.White
        Me.btn_historial_de_dinero_retirado.Name = "btn_historial_de_dinero_retirado"
        Me.btn_historial_de_dinero_retirado.Size = New System.Drawing.Size(273, 35)
        Me.btn_historial_de_dinero_retirado.TabIndex = 4
        Me.btn_historial_de_dinero_retirado.Text = "Historial de dinero retirado"
        Me.btn_historial_de_dinero_retirado.UseVisualStyleBackColor = False
        '
        'btn_comprobantes
        '
        Me.btn_comprobantes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_comprobantes.BackColor = System.Drawing.Color.White
        Me.btn_comprobantes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_comprobantes.FlatAppearance.BorderSize = 0
        Me.btn_comprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_comprobantes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_comprobantes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_comprobantes.Location = New System.Drawing.Point(505, 38)
        Me.btn_comprobantes.MainColor = System.Drawing.Color.White
        Me.btn_comprobantes.Name = "btn_comprobantes"
        Me.btn_comprobantes.Size = New System.Drawing.Size(204, 35)
        Me.btn_comprobantes.TabIndex = 5
        Me.btn_comprobantes.Text = "Agregar comprobantes"
        Me.btn_comprobantes.UseVisualStyleBackColor = False
        Me.btn_comprobantes.Visible = False
        '
        'btn_backup
        '
        Me.btn_backup.BackColor = System.Drawing.Color.White
        Me.btn_backup.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_backup.FlatAppearance.BorderSize = 0
        Me.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_backup.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_backup.Location = New System.Drawing.Point(9, 38)
        Me.btn_backup.MainColor = System.Drawing.Color.White
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(123, 35)
        Me.btn_backup.TabIndex = 13
        Me.btn_backup.Text = "Backup"
        Me.btn_backup.UseVisualStyleBackColor = False
        '
        'frm_inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(716, 575)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.lbl_mantenimiento_por_30_dias)
        Me.Controls.Add(Me.btn_comprobantes)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_mantenimiento_por_semana)
        Me.Controls.Add(Me.btn_historial_de_dinero_retirado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_retirar_dinero)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_detalle_por_mes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_por_semanas_liquidos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_inventario"
        Me.Text = "frm_inventario"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_retirar_dinero As CTSkinet.CTSkinetButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_ventas_del_mes As Label
    Friend WithEvents lbl_compras_del_mes As Label
    Friend WithEvents lbl_ventas_de_la_semana As Label
    Friend WithEvents lbl_compras_de_la_semana As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_ganancias_de_la_semana As Label
    Friend WithEvents btn_historial_de_dinero_retirado As CTSkinet.CTSkinetButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_ganancias_del_mes As Label
    Friend WithEvents lbl_dinero_en_caja As Label
    Friend WithEvents btn_consultar_por_fecha As CTSkinet.CTSkinetButton
    Friend WithEvents lbl_por_semanas_liquidos As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_detalle_por_mes As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_mantenimiento_por_semana As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_mantenimiento_por_30_dias As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_comprobantes As CTSkinet.CTSkinetButton
    Friend WithEvents lbl_dinero_en_producto As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_backup As CTSkinet.CTSkinetButton
End Class
