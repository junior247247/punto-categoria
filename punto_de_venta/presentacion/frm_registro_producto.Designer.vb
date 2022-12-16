<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_registro_producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registro_producto))
        Me.grb_registro_producto = New System.Windows.Forms.GroupBox()
        Me.CHB_DESCUENTO_POR_MONTO = New System.Windows.Forms.CheckBox()
        Me.chb_descuento_activo = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.txt_precio_con_descuento = New System.Windows.Forms.TextBox()
        Me.chb_itbis = New System.Windows.Forms.CheckBox()
        Me.cbo_categoria = New System.Windows.Forms.ComboBox()
        Me.pciture_producto = New System.Windows.Forms.PictureBox()
        Me.lbl_id_producto = New System.Windows.Forms.Label()
        Me.btn_eliminar = New CTSkinet.CTSkinetButton()
        Me.btn_agregar = New CTSkinet.CTSkinetButton()
        Me.txt_cantidad_por_mayoreo_a_vender = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txt_punto_DE_reorden = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_producto = New System.Windows.Forms.TextBox()
        Me.txt_precio_mayoreo = New System.Windows.Forms.TextBox()
        Me.txt_precio_de_venta = New System.Windows.Forms.TextBox()
        Me.txt_precio_de_compra = New System.Windows.Forms.TextBox()
        Me.txt_description_producto = New System.Windows.Forms.TextBox()
        Me.txt_codigo_de_barra = New System.Windows.Forms.TextBox()
        Me.check_no_aplica_fecha = New System.Windows.Forms.CheckBox()
        Me.txtfecha_DE_vencimeinto = New System.Windows.Forms.DateTimePicker()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.rb_por_libra = New System.Windows.Forms.RadioButton()
        Me.rb_por_unidad = New System.Windows.Forms.RadioButton()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.btn_actualizar_datos = New CTSkinet.CTSkinetButton()
        Me.btn_cerrar = New CTSkinet.CTSkinetButton()
        Me.btn_guardar_productos = New CTSkinet.CTSkinetButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.grb_registro_producto.SuspendLayout()
        CType(Me.pciture_producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_registro_producto
        '
        Me.grb_registro_producto.Controls.Add(Me.CHB_DESCUENTO_POR_MONTO)
        Me.grb_registro_producto.Controls.Add(Me.chb_descuento_activo)
        Me.grb_registro_producto.Controls.Add(Me.Label3)
        Me.grb_registro_producto.Controls.Add(Me.Label2)
        Me.grb_registro_producto.Controls.Add(Me.txt_descuento)
        Me.grb_registro_producto.Controls.Add(Me.txt_precio_con_descuento)
        Me.grb_registro_producto.Controls.Add(Me.chb_itbis)
        Me.grb_registro_producto.Controls.Add(Me.cbo_categoria)
        Me.grb_registro_producto.Controls.Add(Me.pciture_producto)
        Me.grb_registro_producto.Controls.Add(Me.lbl_id_producto)
        Me.grb_registro_producto.Controls.Add(Me.btn_eliminar)
        Me.grb_registro_producto.Controls.Add(Me.btn_agregar)
        Me.grb_registro_producto.Controls.Add(Me.txt_cantidad_por_mayoreo_a_vender)
        Me.grb_registro_producto.Controls.Add(Me.Label53)
        Me.grb_registro_producto.Controls.Add(Me.txt_punto_DE_reorden)
        Me.grb_registro_producto.Controls.Add(Me.txt_cantidad_producto)
        Me.grb_registro_producto.Controls.Add(Me.txt_precio_mayoreo)
        Me.grb_registro_producto.Controls.Add(Me.txt_precio_de_venta)
        Me.grb_registro_producto.Controls.Add(Me.txt_precio_de_compra)
        Me.grb_registro_producto.Controls.Add(Me.txt_description_producto)
        Me.grb_registro_producto.Controls.Add(Me.txt_codigo_de_barra)
        Me.grb_registro_producto.Controls.Add(Me.check_no_aplica_fecha)
        Me.grb_registro_producto.Controls.Add(Me.txtfecha_DE_vencimeinto)
        Me.grb_registro_producto.Controls.Add(Me.Label38)
        Me.grb_registro_producto.Controls.Add(Me.Label14)
        Me.grb_registro_producto.Controls.Add(Me.Label49)
        Me.grb_registro_producto.Controls.Add(Me.rb_por_libra)
        Me.grb_registro_producto.Controls.Add(Me.rb_por_unidad)
        Me.grb_registro_producto.Controls.Add(Me.Label63)
        Me.grb_registro_producto.Controls.Add(Me.Label64)
        Me.grb_registro_producto.Controls.Add(Me.Label65)
        Me.grb_registro_producto.Controls.Add(Me.Label66)
        Me.grb_registro_producto.Controls.Add(Me.Label67)
        Me.grb_registro_producto.Controls.Add(Me.Label68)
        Me.grb_registro_producto.Controls.Add(Me.Label69)
        Me.grb_registro_producto.Location = New System.Drawing.Point(9, 32)
        Me.grb_registro_producto.Name = "grb_registro_producto"
        Me.grb_registro_producto.Size = New System.Drawing.Size(920, 243)
        Me.grb_registro_producto.TabIndex = 379
        Me.grb_registro_producto.TabStop = False
        '
        'CHB_DESCUENTO_POR_MONTO
        '
        Me.CHB_DESCUENTO_POR_MONTO.AutoSize = True
        Me.CHB_DESCUENTO_POR_MONTO.Location = New System.Drawing.Point(655, 168)
        Me.CHB_DESCUENTO_POR_MONTO.Name = "CHB_DESCUENTO_POR_MONTO"
        Me.CHB_DESCUENTO_POR_MONTO.Size = New System.Drawing.Size(170, 17)
        Me.CHB_DESCUENTO_POR_MONTO.TabIndex = 593
        Me.CHB_DESCUENTO_POR_MONTO.Text = "Poner Descuento Por Monto $"
        Me.CHB_DESCUENTO_POR_MONTO.UseVisualStyleBackColor = True
        '
        'chb_descuento_activo
        '
        Me.chb_descuento_activo.AutoSize = True
        Me.chb_descuento_activo.Location = New System.Drawing.Point(655, 142)
        Me.chb_descuento_activo.Name = "chb_descuento_activo"
        Me.chb_descuento_activo.Size = New System.Drawing.Size(110, 17)
        Me.chb_descuento_activo.TabIndex = 592
        Me.chb_descuento_activo.Text = "Descuento activo"
        Me.chb_descuento_activo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(455, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 591
        Me.Label3.Text = "Precio con descuento $:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 590
        Me.Label2.Text = "Descuento %:"
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(384, 140)
        Me.txt_descuento.MaxLength = 3
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(66, 20)
        Me.txt_descuento.TabIndex = 589
        '
        'txt_precio_con_descuento
        '
        Me.txt_precio_con_descuento.Enabled = False
        Me.txt_precio_con_descuento.Location = New System.Drawing.Point(580, 139)
        Me.txt_precio_con_descuento.Name = "txt_precio_con_descuento"
        Me.txt_precio_con_descuento.Size = New System.Drawing.Size(66, 20)
        Me.txt_precio_con_descuento.TabIndex = 588
        '
        'chb_itbis
        '
        Me.chb_itbis.AutoSize = True
        Me.chb_itbis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.chb_itbis.Location = New System.Drawing.Point(464, 94)
        Me.chb_itbis.Name = "chb_itbis"
        Me.chb_itbis.Size = New System.Drawing.Size(148, 17)
        Me.chb_itbis.TabIndex = 587
        Me.chb_itbis.Text = "APLICAR 18% DEL ITBIS"
        Me.chb_itbis.UseVisualStyleBackColor = True
        '
        'cbo_categoria
        '
        Me.cbo_categoria.FormattingEnabled = True
        Me.cbo_categoria.Location = New System.Drawing.Point(174, 140)
        Me.cbo_categoria.Name = "cbo_categoria"
        Me.cbo_categoria.Size = New System.Drawing.Size(82, 21)
        Me.cbo_categoria.TabIndex = 586
        Me.cbo_categoria.Text = "ABARROTES"
        '
        'pciture_producto
        '
        Me.pciture_producto.Image = Global.punto_de_venta.My.Resources.Resources.SIN_IMAGEN
        Me.pciture_producto.Location = New System.Drawing.Point(716, 20)
        Me.pciture_producto.Name = "pciture_producto"
        Me.pciture_producto.Size = New System.Drawing.Size(185, 110)
        Me.pciture_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pciture_producto.TabIndex = 585
        Me.pciture_producto.TabStop = False
        '
        'lbl_id_producto
        '
        Me.lbl_id_producto.AutoSize = True
        Me.lbl_id_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_id_producto.ForeColor = System.Drawing.Color.Black
        Me.lbl_id_producto.Location = New System.Drawing.Point(802, 195)
        Me.lbl_id_producto.Name = "lbl_id_producto"
        Me.lbl_id_producto.Size = New System.Drawing.Size(23, 20)
        Me.lbl_id_producto.TabIndex = 584
        Me.lbl_id_producto.Text = "id"
        Me.lbl_id_producto.Visible = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.White
        Me.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_eliminar.FlatAppearance.BorderSize = 0
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_eliminar.Location = New System.Drawing.Point(624, 103)
        Me.btn_eliminar.MainColor = System.Drawing.Color.White
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(86, 23)
        Me.btn_eliminar.TabIndex = 583
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.White
        Me.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_agregar.FlatAppearance.BorderSize = 0
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_agregar.Location = New System.Drawing.Point(624, 19)
        Me.btn_agregar.MainColor = System.Drawing.Color.White
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(86, 23)
        Me.btn_agregar.TabIndex = 583
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'txt_cantidad_por_mayoreo_a_vender
        '
        Me.txt_cantidad_por_mayoreo_a_vender.Location = New System.Drawing.Point(384, 117)
        Me.txt_cantidad_por_mayoreo_a_vender.MaxLength = 6
        Me.txt_cantidad_por_mayoreo_a_vender.Name = "txt_cantidad_por_mayoreo_a_vender"
        Me.txt_cantidad_por_mayoreo_a_vender.Size = New System.Drawing.Size(66, 20)
        Me.txt_cantidad_por_mayoreo_a_vender.TabIndex = 582
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(270, 118)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(107, 13)
        Me.Label53.TabIndex = 581
        Me.Label53.Text = "Cantida por mayoreo:"
        '
        'txt_punto_DE_reorden
        '
        Me.txt_punto_DE_reorden.Location = New System.Drawing.Point(384, 164)
        Me.txt_punto_DE_reorden.MaxLength = 6
        Me.txt_punto_DE_reorden.Name = "txt_punto_DE_reorden"
        Me.txt_punto_DE_reorden.Size = New System.Drawing.Size(66, 20)
        Me.txt_punto_DE_reorden.TabIndex = 580
        '
        'txt_cantidad_producto
        '
        Me.txt_cantidad_producto.Location = New System.Drawing.Point(174, 165)
        Me.txt_cantidad_producto.MaxLength = 6
        Me.txt_cantidad_producto.Name = "txt_cantidad_producto"
        Me.txt_cantidad_producto.Size = New System.Drawing.Size(82, 20)
        Me.txt_cantidad_producto.TabIndex = 579
        '
        'txt_precio_mayoreo
        '
        Me.txt_precio_mayoreo.Location = New System.Drawing.Point(174, 115)
        Me.txt_precio_mayoreo.MaxLength = 6
        Me.txt_precio_mayoreo.Name = "txt_precio_mayoreo"
        Me.txt_precio_mayoreo.Size = New System.Drawing.Size(82, 20)
        Me.txt_precio_mayoreo.TabIndex = 578
        '
        'txt_precio_de_venta
        '
        Me.txt_precio_de_venta.Location = New System.Drawing.Point(384, 92)
        Me.txt_precio_de_venta.MaxLength = 6
        Me.txt_precio_de_venta.Name = "txt_precio_de_venta"
        Me.txt_precio_de_venta.Size = New System.Drawing.Size(66, 20)
        Me.txt_precio_de_venta.TabIndex = 577
        '
        'txt_precio_de_compra
        '
        Me.txt_precio_de_compra.Location = New System.Drawing.Point(174, 92)
        Me.txt_precio_de_compra.MaxLength = 6
        Me.txt_precio_de_compra.Name = "txt_precio_de_compra"
        Me.txt_precio_de_compra.Size = New System.Drawing.Size(81, 20)
        Me.txt_precio_de_compra.TabIndex = 576
        '
        'txt_description_producto
        '
        Me.txt_description_producto.Location = New System.Drawing.Point(174, 44)
        Me.txt_description_producto.MaxLength = 48
        Me.txt_description_producto.Name = "txt_description_producto"
        Me.txt_description_producto.Size = New System.Drawing.Size(410, 20)
        Me.txt_description_producto.TabIndex = 575
        '
        'txt_codigo_de_barra
        '
        Me.txt_codigo_de_barra.Location = New System.Drawing.Point(174, 20)
        Me.txt_codigo_de_barra.MaxLength = 25
        Me.txt_codigo_de_barra.Name = "txt_codigo_de_barra"
        Me.txt_codigo_de_barra.Size = New System.Drawing.Size(221, 20)
        Me.txt_codigo_de_barra.TabIndex = 574
        '
        'check_no_aplica_fecha
        '
        Me.check_no_aplica_fecha.AutoSize = True
        Me.check_no_aplica_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.check_no_aplica_fecha.ForeColor = System.Drawing.Color.Black
        Me.check_no_aplica_fecha.Location = New System.Drawing.Point(279, 191)
        Me.check_no_aplica_fecha.Name = "check_no_aplica_fecha"
        Me.check_no_aplica_fecha.Size = New System.Drawing.Size(102, 24)
        Me.check_no_aplica_fecha.TabIndex = 561
        Me.check_no_aplica_fecha.Text = "No aplica"
        Me.check_no_aplica_fecha.UseVisualStyleBackColor = True
        '
        'txtfecha_DE_vencimeinto
        '
        Me.txtfecha_DE_vencimeinto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfecha_DE_vencimeinto.Location = New System.Drawing.Point(174, 192)
        Me.txtfecha_DE_vencimeinto.Name = "txtfecha_DE_vencimeinto"
        Me.txtfecha_DE_vencimeinto.Size = New System.Drawing.Size(99, 20)
        Me.txtfecha_DE_vencimeinto.TabIndex = 560
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(66, 192)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(105, 16)
        Me.Label38.TabIndex = 546
        Me.Label38.Text = "Fecha de Venc :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(96, 165)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 16)
        Me.Label14.TabIndex = 548
        Me.Label14.Text = "Existencia :"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(264, 163)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(113, 15)
        Me.Label49.TabIndex = 541
        Me.Label49.Text = "Punto de Reorden :"
        '
        'rb_por_libra
        '
        Me.rb_por_libra.AutoSize = True
        Me.rb_por_libra.Location = New System.Drawing.Point(336, 71)
        Me.rb_por_libra.Name = "rb_por_libra"
        Me.rb_por_libra.Size = New System.Drawing.Size(140, 17)
        Me.rb_por_libra.TabIndex = 564
        Me.rb_por_libra.TabStop = True
        Me.rb_por_libra.Text = "A granel (usa decimales)"
        Me.rb_por_libra.UseVisualStyleBackColor = True
        '
        'rb_por_unidad
        '
        Me.rb_por_unidad.AutoSize = True
        Me.rb_por_unidad.Location = New System.Drawing.Point(182, 70)
        Me.rb_por_unidad.Name = "rb_por_unidad"
        Me.rb_por_unidad.Size = New System.Drawing.Size(109, 17)
        Me.rb_por_unidad.TabIndex = 563
        Me.rb_por_unidad.TabStop = True
        Me.rb_por_unidad.Text = "Por Unidad/Pieza"
        Me.rb_por_unidad.UseVisualStyleBackColor = True
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(38, 115)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(133, 16)
        Me.Label63.TabIndex = 544
        Me.Label63.Text = "Precio Mayoreo C/U:"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(289, 92)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(89, 16)
        Me.Label64.TabIndex = 549
        Me.Label64.Text = "Precio venta :"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(20, 93)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(149, 16)
        Me.Label65.TabIndex = 550
        Me.Label65.Text = "Precio de Compra C/U :"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(56, 20)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(112, 16)
        Me.Label66.TabIndex = 556
        Me.Label66.Text = "Codigo de barra :"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(83, 45)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(86, 16)
        Me.Label67.TabIndex = 557
        Me.Label67.Text = "Descripcion :"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(98, 72)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(72, 16)
        Me.Label68.TabIndex = 543
        Me.Label68.Text = "Se vende :"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Black
        Me.Label69.Location = New System.Drawing.Point(98, 139)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(73, 16)
        Me.Label69.TabIndex = 558
        Me.Label69.Text = "Categoria :"
        '
        'btn_actualizar_datos
        '
        Me.btn_actualizar_datos.BackColor = System.Drawing.Color.White
        Me.btn_actualizar_datos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_actualizar_datos.FlatAppearance.BorderSize = 0
        Me.btn_actualizar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar_datos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar_datos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_actualizar_datos.Location = New System.Drawing.Point(843, 286)
        Me.btn_actualizar_datos.MainColor = System.Drawing.Color.White
        Me.btn_actualizar_datos.Name = "btn_actualizar_datos"
        Me.btn_actualizar_datos.Size = New System.Drawing.Size(86, 23)
        Me.btn_actualizar_datos.TabIndex = 583
        Me.btn_actualizar_datos.Text = "Editar"
        Me.btn_actualizar_datos.UseVisualStyleBackColor = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(909, -1)
        Me.btn_cerrar.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(33, 30)
        Me.btn_cerrar.TabIndex = 573
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'btn_guardar_productos
        '
        Me.btn_guardar_productos.BackColor = System.Drawing.Color.White
        Me.btn_guardar_productos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_guardar_productos.FlatAppearance.BorderSize = 0
        Me.btn_guardar_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar_productos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_productos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_guardar_productos.Location = New System.Drawing.Point(9, 285)
        Me.btn_guardar_productos.MainColor = System.Drawing.Color.White
        Me.btn_guardar_productos.Name = "btn_guardar_productos"
        Me.btn_guardar_productos.Size = New System.Drawing.Size(86, 23)
        Me.btn_guardar_productos.TabIndex = 555
        Me.btn_guardar_productos.Text = "Guardar"
        Me.btn_guardar_productos.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 35)
        Me.Panel1.TabIndex = 380
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(388, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 586
        Me.Label1.Text = "REGISTRO DE PRODUCTO"
        '
        'dlg
        '
        Me.dlg.FileName = "dlg"
        '
        'frm_registro_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(941, 328)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grb_registro_producto)
        Me.Controls.Add(Me.btn_actualizar_datos)
        Me.Controls.Add(Me.btn_guardar_productos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1920, 1040)
        Me.Name = "frm_registro_producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de productos"
        Me.grb_registro_producto.ResumeLayout(False)
        Me.grb_registro_producto.PerformLayout()
        CType(Me.pciture_producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grb_registro_producto As GroupBox
    Friend WithEvents lbl_id_producto As Label
    Friend WithEvents btn_actualizar_datos As CTSkinet.CTSkinetButton
    Friend WithEvents txt_cantidad_por_mayoreo_a_vender As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents txt_punto_DE_reorden As TextBox
    Friend WithEvents txt_cantidad_producto As TextBox
    Friend WithEvents txt_precio_mayoreo As TextBox
    Friend WithEvents txt_precio_de_venta As TextBox
    Friend WithEvents txt_precio_de_compra As TextBox
    Friend WithEvents txt_description_producto As TextBox
    Friend WithEvents txt_codigo_de_barra As TextBox
    Friend WithEvents btn_cerrar As CTSkinet.CTSkinetButton
    Friend WithEvents check_no_aplica_fecha As CheckBox
    Friend WithEvents txtfecha_DE_vencimeinto As DateTimePicker
    Friend WithEvents Label38 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents btn_guardar_productos As CTSkinet.CTSkinetButton
    Friend WithEvents rb_por_libra As RadioButton
    Friend WithEvents rb_por_unidad As RadioButton
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pciture_producto As PictureBox
    Friend WithEvents btn_eliminar As CTSkinet.CTSkinetButton
    Friend WithEvents btn_agregar As CTSkinet.CTSkinetButton
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents cbo_categoria As ComboBox
    Friend WithEvents chb_itbis As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_descuento As TextBox
    Friend WithEvents txt_precio_con_descuento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chb_descuento_activo As CheckBox
    Friend WithEvents CHB_DESCUENTO_POR_MONTO As CheckBox
End Class
