<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_buscar_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_buscar_cliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_seleccionar = New CTSkinet.CTSkinetButton()
        Me.btn_cerrar = New CTSkinet.CTSkinetButton()
        Me.datalistado_clientes = New System.Windows.Forms.DataGridView()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_registrar_link = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.datalistado_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_registrar_link)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 28)
        Me.Panel1.TabIndex = 0
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
        Me.btn_seleccionar.Location = New System.Drawing.Point(575, 36)
        Me.btn_seleccionar.MainColor = System.Drawing.Color.White
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(113, 35)
        Me.btn_seleccionar.TabIndex = 22
        Me.btn_seleccionar.Text = "Seleccionar"
        Me.btn_seleccionar.UseVisualStyleBackColor = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(659, 0)
        Me.btn_cerrar.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(33, 30)
        Me.btn_cerrar.TabIndex = 575
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'datalistado_clientes
        '
        Me.datalistado_clientes.AllowUserToAddRows = False
        Me.datalistado_clientes.AllowUserToDeleteRows = False
        Me.datalistado_clientes.AllowUserToResizeColumns = False
        Me.datalistado_clientes.AllowUserToResizeRows = False
        Me.datalistado_clientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datalistado_clientes.BackgroundColor = System.Drawing.Color.White
        Me.datalistado_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistado_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_clientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_clientes.ColumnHeadersHeight = 25
        Me.datalistado_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datalistado_clientes.GridColor = System.Drawing.SystemColors.Control
        Me.datalistado_clientes.Location = New System.Drawing.Point(3, 77)
        Me.datalistado_clientes.Name = "datalistado_clientes"
        Me.datalistado_clientes.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_clientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_clientes.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.datalistado_clientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_clientes.Size = New System.Drawing.Size(685, 263)
        Me.datalistado_clientes.TabIndex = 23
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(59, 46)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(198, 20)
        Me.txt_buscar.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Buscar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(290, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "LISTADO DE CLIENTES"
        '
        'lbl_registrar_link
        '
        Me.lbl_registrar_link.AutoSize = True
        Me.lbl_registrar_link.ForeColor = System.Drawing.Color.White
        Me.lbl_registrar_link.LinkColor = System.Drawing.Color.White
        Me.lbl_registrar_link.Location = New System.Drawing.Point(8, 7)
        Me.lbl_registrar_link.Name = "lbl_registrar_link"
        Me.lbl_registrar_link.Size = New System.Drawing.Size(70, 13)
        Me.lbl_registrar_link.TabIndex = 26
        Me.lbl_registrar_link.TabStop = True
        Me.lbl_registrar_link.Text = "REGISTRAR"
        '
        'frm_buscar_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(692, 347)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.datalistado_clientes)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_buscar_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datalistado_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_seleccionar As CTSkinet.CTSkinetButton
    Friend WithEvents btn_cerrar As CTSkinet.CTSkinetButton
    Friend WithEvents datalistado_clientes As DataGridView
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_registrar_link As LinkLabel
End Class
