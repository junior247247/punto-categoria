<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_compras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_compras))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.datalistado_productos = New System.Windows.Forms.DataGridView()
        Me.txt_codigo_de_barra = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_numero_de_doc = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_articulos = New System.Windows.Forms.TextBox()
        Me.cbo_proveedor = New System.Windows.Forms.ComboBox()
        Me.cbo_tipo_de_ingreso = New System.Windows.Forms.ComboBox()
        Me.cbo_comprobante = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_guardar = New CTSkinet.CTSkinetButton()
        Me.btn_historial_de_compras = New CTSkinet.CTSkinetButton()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblprecio_de_compra = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(9, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 38)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_codigo_de_barra)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_numero_de_doc)
        Me.GroupBox1.Controls.Add(Me.txt_precio)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad)
        Me.GroupBox1.Controls.Add(Me.txt_articulos)
        Me.GroupBox1.Controls.Add(Me.cbo_proveedor)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_de_ingreso)
        Me.GroupBox1.Controls.Add(Me.cbo_comprobante)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 193)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.datalistado_productos)
        Me.GroupBox2.Location = New System.Drawing.Point(147, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 97)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_productos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_productos.ColumnHeadersHeight = 25
        Me.datalistado_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datalistado_productos.GridColor = System.Drawing.SystemColors.Control
        Me.datalistado_productos.Location = New System.Drawing.Point(-1, 4)
        Me.datalistado_productos.Name = "datalistado_productos"
        Me.datalistado_productos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_productos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_productos.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.datalistado_productos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_productos.Size = New System.Drawing.Size(394, 97)
        Me.datalistado_productos.TabIndex = 17
        '
        'txt_codigo_de_barra
        '
        Me.txt_codigo_de_barra.Location = New System.Drawing.Point(147, 72)
        Me.txt_codigo_de_barra.Name = "txt_codigo_de_barra"
        Me.txt_codigo_de_barra.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo_de_barra.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Codigo de barra:"
        '
        'txt_numero_de_doc
        '
        Me.txt_numero_de_doc.Location = New System.Drawing.Point(441, 122)
        Me.txt_numero_de_doc.Name = "txt_numero_de_doc"
        Me.txt_numero_de_doc.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero_de_doc.TabIndex = 2
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(441, 96)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio.TabIndex = 2
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(147, 98)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 2
        '
        'txt_articulos
        '
        Me.txt_articulos.Location = New System.Drawing.Point(147, 47)
        Me.txt_articulos.MaxLength = 48
        Me.txt_articulos.Name = "txt_articulos"
        Me.txt_articulos.Size = New System.Drawing.Size(394, 20)
        Me.txt_articulos.TabIndex = 2
        '
        'cbo_proveedor
        '
        Me.cbo_proveedor.FormattingEnabled = True
        Me.cbo_proveedor.Items.AddRange(New Object() {"Compra", "Consumo interno"})
        Me.cbo_proveedor.Location = New System.Drawing.Point(441, 148)
        Me.cbo_proveedor.Name = "cbo_proveedor"
        Me.cbo_proveedor.Size = New System.Drawing.Size(100, 21)
        Me.cbo_proveedor.TabIndex = 1
        Me.cbo_proveedor.Text = "Proveedor"
        '
        'cbo_tipo_de_ingreso
        '
        Me.cbo_tipo_de_ingreso.FormattingEnabled = True
        Me.cbo_tipo_de_ingreso.Items.AddRange(New Object() {"Compra", "Consumo interno"})
        Me.cbo_tipo_de_ingreso.Location = New System.Drawing.Point(147, 151)
        Me.cbo_tipo_de_ingreso.Name = "cbo_tipo_de_ingreso"
        Me.cbo_tipo_de_ingreso.Size = New System.Drawing.Size(121, 21)
        Me.cbo_tipo_de_ingreso.TabIndex = 1
        Me.cbo_tipo_de_ingreso.Text = "Compra"
        '
        'cbo_comprobante
        '
        Me.cbo_comprobante.FormattingEnabled = True
        Me.cbo_comprobante.Items.AddRange(New Object() {"Factura", "Recibo", "Remision"})
        Me.cbo_comprobante.Location = New System.Drawing.Point(147, 124)
        Me.cbo_comprobante.Name = "cbo_comprobante"
        Me.cbo_comprobante.Size = New System.Drawing.Size(121, 21)
        Me.cbo_comprobante.TabIndex = 1
        Me.cbo_comprobante.Text = "Factura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(348, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Proveedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tipo de ingreso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(376, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Precio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(364, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Numero:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Comprobante:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cantidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Articulo:"
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.BackColor = System.Drawing.Color.White
        Me.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_guardar.Location = New System.Drawing.Point(559, 305)
        Me.btn_guardar.MainColor = System.Drawing.Color.White
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(150, 35)
        Me.btn_guardar.TabIndex = 19
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_historial_de_compras
        '
        Me.btn_historial_de_compras.BackColor = System.Drawing.Color.White
        Me.btn_historial_de_compras.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_historial_de_compras.FlatAppearance.BorderSize = 0
        Me.btn_historial_de_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_historial_de_compras.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_historial_de_compras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_historial_de_compras.Location = New System.Drawing.Point(9, 304)
        Me.btn_historial_de_compras.MainColor = System.Drawing.Color.White
        Me.btn_historial_de_compras.Name = "btn_historial_de_compras"
        Me.btn_historial_de_compras.Size = New System.Drawing.Size(262, 35)
        Me.btn_historial_de_compras.TabIndex = 20
        Me.btn_historial_de_compras.Text = "Historial de compras"
        Me.btn_historial_de_compras.UseVisualStyleBackColor = False
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(414, 459)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(39, 13)
        Me.lblid.TabIndex = 21
        Me.lblid.Text = "Label9"
        Me.lblid.Visible = False
        '
        'lblprecio_de_compra
        '
        Me.lblprecio_de_compra.AutoSize = True
        Me.lblprecio_de_compra.Location = New System.Drawing.Point(216, 487)
        Me.lblprecio_de_compra.Name = "lblprecio_de_compra"
        Me.lblprecio_de_compra.Size = New System.Drawing.Size(39, 13)
        Me.lblprecio_de_compra.TabIndex = 22
        Me.lblprecio_de_compra.Text = "Label9"
        Me.lblprecio_de_compra.Visible = False
        '
        'frm_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(716, 575)
        Me.Controls.Add(Me.lblprecio_de_compra)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.btn_historial_de_compras)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_compras"
        Me.Text = "Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.datalistado_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_comprobante As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_numero_de_doc As TextBox
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents txt_articulos As TextBox
    Friend WithEvents cbo_tipo_de_ingreso As ComboBox
    Friend WithEvents cbo_proveedor As ComboBox
    Friend WithEvents datalistado_productos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_guardar As CTSkinet.CTSkinetButton
    Friend WithEvents btn_historial_de_compras As CTSkinet.CTSkinetButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_codigo_de_barra As TextBox
    Friend WithEvents lblid As Label
    Friend WithEvents lblprecio_de_compra As Label
End Class
