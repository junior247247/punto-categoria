<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_buscar_product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_buscar_product))
        Me.datalistado_productos = New System.Windows.Forms.DataGridView()
        Me.lblbuscar = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_seleccionar = New CTSkinet.CTSkinetButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New CTSkinet.CTSkinetButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.datalistado_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.datalistado_productos.Location = New System.Drawing.Point(4, 82)
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
        Me.datalistado_productos.Size = New System.Drawing.Size(688, 266)
        Me.datalistado_productos.TabIndex = 18
        '
        'lblbuscar
        '
        Me.lblbuscar.AutoSize = True
        Me.lblbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbuscar.Location = New System.Drawing.Point(12, 56)
        Me.lblbuscar.Name = "lblbuscar"
        Me.lblbuscar.Size = New System.Drawing.Size(53, 16)
        Me.lblbuscar.TabIndex = 19
        Me.lblbuscar.Text = "Buscar:"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(67, 56)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(250, 20)
        Me.txt_buscar.TabIndex = 20
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_seleccionar.BackColor = System.Drawing.Color.White
        Me.btn_seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_seleccionar.FlatAppearance.BorderSize = 0
        Me.btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seleccionar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seleccionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_seleccionar.Location = New System.Drawing.Point(564, 41)
        Me.btn_seleccionar.MainColor = System.Drawing.Color.White
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(132, 35)
        Me.btn_seleccionar.TabIndex = 21
        Me.btn_seleccionar.Text = "Seleccionar"
        Me.btn_seleccionar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(287, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Listado de productos"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(662, -2)
        Me.btn_cerrar.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(33, 30)
        Me.btn_cerrar.TabIndex = 574
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 31)
        Me.Panel1.TabIndex = 0
        '
        'frm_buscar_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(696, 357)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.lblbuscar)
        Me.Controls.Add(Me.datalistado_productos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_buscar_product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar producto"
        CType(Me.datalistado_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datalistado_productos As DataGridView
    Friend WithEvents lblbuscar As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents btn_seleccionar As CTSkinet.CTSkinetButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cerrar As CTSkinet.CTSkinetButton
    Friend WithEvents Panel1 As Panel
End Class
