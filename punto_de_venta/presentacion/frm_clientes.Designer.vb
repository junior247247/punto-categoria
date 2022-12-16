<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_clientes))
        Me.datalistado_clientes = New System.Windows.Forms.DataGridView()
        Me.txt_buscar_clientes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_nuevo_cliente = New CTSkinet.CTSkinetButton()
        Me.c_menu_clientes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.datalistado_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c_menu_clientes.SuspendLayout()
        Me.SuspendLayout()
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
        Me.datalistado_clientes.Location = New System.Drawing.Point(5, 139)
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
        Me.datalistado_clientes.Size = New System.Drawing.Size(688, 385)
        Me.datalistado_clientes.TabIndex = 17
        '
        'txt_buscar_clientes
        '
        Me.txt_buscar_clientes.Location = New System.Drawing.Point(72, 113)
        Me.txt_buscar_clientes.Name = "txt_buscar_clientes"
        Me.txt_buscar_clientes.Size = New System.Drawing.Size(255, 20)
        Me.txt_buscar_clientes.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Buscar:"
        '
        'btn_nuevo_cliente
        '
        Me.btn_nuevo_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_nuevo_cliente.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_cliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_nuevo_cliente.FlatAppearance.BorderSize = 0
        Me.btn_nuevo_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo_cliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_nuevo_cliente.Location = New System.Drawing.Point(588, 47)
        Me.btn_nuevo_cliente.MainColor = System.Drawing.Color.White
        Me.btn_nuevo_cliente.Name = "btn_nuevo_cliente"
        Me.btn_nuevo_cliente.Size = New System.Drawing.Size(100, 21)
        Me.btn_nuevo_cliente.TabIndex = 20
        Me.btn_nuevo_cliente.Text = "Nuevo"
        Me.btn_nuevo_cliente.UseVisualStyleBackColor = False
        '
        'c_menu_clientes
        '
        Me.c_menu_clientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.c_menu_clientes.Name = "c_menu_clientes"
        Me.c_menu_clientes.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(4, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 28)
        Me.Panel1.TabIndex = 21
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 536)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_nuevo_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_buscar_clientes)
        Me.Controls.Add(Me.datalistado_clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.datalistado_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c_menu_clientes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datalistado_clientes As DataGridView
    Friend WithEvents txt_buscar_clientes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_nuevo_cliente As CTSkinet.CTSkinetButton
    Friend WithEvents c_menu_clientes As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
