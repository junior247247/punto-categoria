<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_provedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_provedor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_guardar = New CTSkinet.CTSkinetButton()
        Me.lbl_id_proveedor = New System.Windows.Forms.Label()
        Me.txt_nombre_o_razon_social = New System.Windows.Forms.TextBox()
        Me.btn_editar = New CTSkinet.CTSkinetButton()
        Me.txt_numero_de_doc = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.cbo_tipo_de_documento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_lista_de_proveedores = New CTSkinet.CTSkinetButton()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.lbl_id_proveedor)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_o_razon_social)
        Me.GroupBox1.Controls.Add(Me.btn_editar)
        Me.GroupBox1.Controls.Add(Me.txt_numero_de_doc)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_de_documento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 179)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.BackColor = System.Drawing.Color.White
        Me.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_guardar.Location = New System.Drawing.Point(587, 133)
        Me.btn_guardar.MainColor = System.Drawing.Color.White
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(106, 35)
        Me.btn_guardar.TabIndex = 2
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'lbl_id_proveedor
        '
        Me.lbl_id_proveedor.AutoSize = True
        Me.lbl_id_proveedor.Location = New System.Drawing.Point(420, 79)
        Me.lbl_id_proveedor.Name = "lbl_id_proveedor"
        Me.lbl_id_proveedor.Size = New System.Drawing.Size(28, 13)
        Me.lbl_id_proveedor.TabIndex = 2
        Me.lbl_id_proveedor.Text = "SSS"
        Me.lbl_id_proveedor.Visible = False
        '
        'txt_nombre_o_razon_social
        '
        Me.txt_nombre_o_razon_social.BackColor = System.Drawing.Color.White
        Me.txt_nombre_o_razon_social.Location = New System.Drawing.Point(206, 33)
        Me.txt_nombre_o_razon_social.Name = "txt_nombre_o_razon_social"
        Me.txt_nombre_o_razon_social.Size = New System.Drawing.Size(353, 20)
        Me.txt_nombre_o_razon_social.TabIndex = 4
        '
        'btn_editar
        '
        Me.btn_editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_editar.BackColor = System.Drawing.Color.White
        Me.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_editar.FlatAppearance.BorderSize = 0
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_editar.Location = New System.Drawing.Point(588, 133)
        Me.btn_editar.MainColor = System.Drawing.Color.White
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(106, 35)
        Me.btn_editar.TabIndex = 2
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'txt_numero_de_doc
        '
        Me.txt_numero_de_doc.Location = New System.Drawing.Point(206, 86)
        Me.txt_numero_de_doc.MaxLength = 15
        Me.txt_numero_de_doc.Name = "txt_numero_de_doc"
        Me.txt_numero_de_doc.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero_de_doc.TabIndex = 3
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(206, 112)
        Me.txt_telefono.MaxLength = 10
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 2
        '
        'cbo_tipo_de_documento
        '
        Me.cbo_tipo_de_documento.FormattingEnabled = True
        Me.cbo_tipo_de_documento.Items.AddRange(New Object() {"Dni", "Cedula", "Nit", "Otro"})
        Me.cbo_tipo_de_documento.Location = New System.Drawing.Point(206, 59)
        Me.cbo_tipo_de_documento.Name = "cbo_tipo_de_documento"
        Me.cbo_tipo_de_documento.Size = New System.Drawing.Size(100, 21)
        Me.cbo_tipo_de_documento.TabIndex = 1
        Me.cbo_tipo_de_documento.Text = "Dni"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(125, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Numero de Doc:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo de documento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre o Razon social:"
        '
        'btn_lista_de_proveedores
        '
        Me.btn_lista_de_proveedores.BackColor = System.Drawing.Color.White
        Me.btn_lista_de_proveedores.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_lista_de_proveedores.FlatAppearance.BorderSize = 0
        Me.btn_lista_de_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_lista_de_proveedores.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lista_de_proveedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_lista_de_proveedores.Location = New System.Drawing.Point(9, 296)
        Me.btn_lista_de_proveedores.MainColor = System.Drawing.Color.White
        Me.btn_lista_de_proveedores.Name = "btn_lista_de_proveedores"
        Me.btn_lista_de_proveedores.Size = New System.Drawing.Size(225, 35)
        Me.btn_lista_de_proveedores.TabIndex = 3
        Me.btn_lista_de_proveedores.Text = "Lista de proveedores"
        Me.btn_lista_de_proveedores.UseVisualStyleBackColor = False
        '
        'frm_provedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(716, 575)
        Me.Controls.Add(Me.btn_lista_de_proveedores)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_provedor"
        Me.Text = "Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_tipo_de_documento As ComboBox
    Friend WithEvents txt_nombre_o_razon_social As TextBox
    Friend WithEvents txt_numero_de_doc As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents btn_guardar As CTSkinet.CTSkinetButton
    Friend WithEvents btn_editar As CTSkinet.CTSkinetButton
    Friend WithEvents lbl_id_proveedor As Label
    Friend WithEvents btn_lista_de_proveedores As CTSkinet.CTSkinetButton
End Class
