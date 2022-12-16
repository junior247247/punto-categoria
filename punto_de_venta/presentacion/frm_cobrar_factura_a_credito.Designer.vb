<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cobrar_factura_a_credito
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cobrar_factura_a_credito))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datalistado_articulos = New System.Windows.Forms.DataGridView()
        Me.btn_cerrar = New CTSkinet.CTSkinetButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_id_factura = New System.Windows.Forms.Label()
        Me.btn_cobrar = New CTSkinet.CTSkinetButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.lbl_pendiente = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_pagado = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_forma_de_pago = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.datalistado_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 33)
        Me.Panel1.TabIndex = 0
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
        Me.datalistado_articulos.Location = New System.Drawing.Point(5, 134)
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
        Me.datalistado_articulos.Size = New System.Drawing.Size(792, 339)
        Me.datalistado_articulos.TabIndex = 19
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(767, 1)
        Me.btn_cerrar.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(33, 30)
        Me.btn_cerrar.TabIndex = 575
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CLIENTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ID FACTURA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(326, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Cobrar factura"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_cliente.Location = New System.Drawing.Point(122, 50)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(18, 20)
        Me.lbl_cliente.TabIndex = 20
        Me.lbl_cliente.Text = "0"
        '
        'lbl_id_factura
        '
        Me.lbl_id_factura.AutoSize = True
        Me.lbl_id_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_factura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_id_factura.Location = New System.Drawing.Point(122, 71)
        Me.lbl_id_factura.Name = "lbl_id_factura"
        Me.lbl_id_factura.Size = New System.Drawing.Size(18, 20)
        Me.lbl_id_factura.TabIndex = 20
        Me.lbl_id_factura.Text = "0"
        '
        'btn_cobrar
        '
        Me.btn_cobrar.BackColor = System.Drawing.Color.White
        Me.btn_cobrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cobrar.FlatAppearance.BorderSize = 0
        Me.btn_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cobrar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cobrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_cobrar.Location = New System.Drawing.Point(688, 39)
        Me.btn_cobrar.MainColor = System.Drawing.Color.White
        Me.btn_cobrar.Name = "btn_cobrar"
        Me.btn_cobrar.Size = New System.Drawing.Size(109, 35)
        Me.btn_cobrar.TabIndex = 22
        Me.btn_cobrar.Text = "COBRAR"
        Me.btn_cobrar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(621, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "MONTO:"
        '
        'txt_monto
        '
        Me.txt_monto.Location = New System.Drawing.Point(697, 111)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(100, 20)
        Me.txt_monto.TabIndex = 23
        '
        'lbl_pendiente
        '
        Me.lbl_pendiente.AutoSize = True
        Me.lbl_pendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pendiente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_pendiente.Location = New System.Drawing.Point(122, 112)
        Me.lbl_pendiente.Name = "lbl_pendiente"
        Me.lbl_pendiente.Size = New System.Drawing.Size(18, 20)
        Me.lbl_pendiente.TabIndex = 20
        Me.lbl_pendiente.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(6, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "PENDIENTE $:"
        '
        'lbl_pagado
        '
        Me.lbl_pagado.AutoSize = True
        Me.lbl_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pagado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_pagado.Location = New System.Drawing.Point(122, 91)
        Me.lbl_pagado.Name = "lbl_pagado"
        Me.lbl_pagado.Size = New System.Drawing.Size(18, 20)
        Me.lbl_pagado.TabIndex = 20
        Me.lbl_pagado.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(27, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "PAGADO $:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(368, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Articulos"
        '
        'cbo_forma_de_pago
        '
        Me.cbo_forma_de_pago.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cbo_forma_de_pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_forma_de_pago.ForeColor = System.Drawing.Color.White
        Me.cbo_forma_de_pago.FormattingEnabled = True
        Me.cbo_forma_de_pago.Items.AddRange(New Object() {"EFECTIVO"})
        Me.cbo_forma_de_pago.Location = New System.Drawing.Point(697, 86)
        Me.cbo_forma_de_pago.Name = "cbo_forma_de_pago"
        Me.cbo_forma_de_pago.Size = New System.Drawing.Size(100, 21)
        Me.cbo_forma_de_pago.TabIndex = 24
        Me.cbo_forma_de_pago.Text = "EFECTIVO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(610, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Forma de pago:"
        '
        'frm_cobrar_factura_a_credito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 481)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbo_forma_de_pago)
        Me.Controls.Add(Me.txt_monto)
        Me.Controls.Add(Me.btn_cobrar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_pagado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_pendiente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_id_factura)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datalistado_articulos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cobrar_factura_a_credito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobrar factura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datalistado_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents datalistado_articulos As DataGridView
    Friend WithEvents btn_cerrar As CTSkinet.CTSkinetButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_id_factura As Label
    Friend WithEvents btn_cobrar As CTSkinet.CTSkinetButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_monto As TextBox
    Friend WithEvents lbl_pendiente As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_pagado As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo_forma_de_pago As ComboBox
    Friend WithEvents Label4 As Label
End Class
