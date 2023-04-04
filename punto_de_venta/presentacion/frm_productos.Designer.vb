<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productos))
        Me.datalistado_productos = New System.Windows.Forms.DataGridView()
        Me.txt_buscar_proctos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_nuevo = New CTSkinet.CTSkinetButton()
        Me.c_menu_productos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReabastecerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNuevoCombo = New System.Windows.Forms.Button()
        Me.btnStarCount = New System.Windows.Forms.Button()
        Me.btnExell = New System.Windows.Forms.Button()
        Me.datalistado_inventory = New System.Windows.Forms.DataGridView()
        CType(Me.datalistado_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c_menu_productos.SuspendLayout()
        CType(Me.datalistado_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.datalistado_productos.Location = New System.Drawing.Point(6, 126)
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
        Me.datalistado_productos.Size = New System.Drawing.Size(700, 437)
        Me.datalistado_productos.TabIndex = 16
        '
        'txt_buscar_proctos
        '
        Me.txt_buscar_proctos.Location = New System.Drawing.Point(73, 100)
        Me.txt_buscar_proctos.Name = "txt_buscar_proctos"
        Me.txt_buscar_proctos.Size = New System.Drawing.Size(202, 20)
        Me.txt_buscar_proctos.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar:"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_nuevo.BackColor = System.Drawing.Color.White
        Me.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_nuevo.FlatAppearance.BorderSize = 0
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_nuevo.Location = New System.Drawing.Point(615, 32)
        Me.btn_nuevo.MainColor = System.Drawing.Color.White
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(97, 23)
        Me.btn_nuevo.TabIndex = 19
        Me.btn_nuevo.Text = "NUEVO"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'c_menu_productos
        '
        Me.c_menu_productos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.ReabastecerToolStripMenuItem})
        Me.c_menu_productos.Name = "c_menu_productos"
        Me.c_menu_productos.Size = New System.Drawing.Size(138, 70)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ReabastecerToolStripMenuItem
        '
        Me.ReabastecerToolStripMenuItem.Name = "ReabastecerToolStripMenuItem"
        Me.ReabastecerToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ReabastecerToolStripMenuItem.Text = "Reabastecer"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(12, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 28)
        Me.Panel1.TabIndex = 20
        '
        'btnNuevoCombo
        '
        Me.btnNuevoCombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevoCombo.FlatAppearance.BorderSize = 0
        Me.btnNuevoCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnNuevoCombo.Location = New System.Drawing.Point(589, 95)
        Me.btnNuevoCombo.Name = "btnNuevoCombo"
        Me.btnNuevoCombo.Size = New System.Drawing.Size(123, 23)
        Me.btnNuevoCombo.TabIndex = 22
        Me.btnNuevoCombo.Text = "NUEVO COMBO"
        Me.btnNuevoCombo.UseVisualStyleBackColor = True
        '
        'btnStarCount
        '
        Me.btnStarCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnStarCount.FlatAppearance.BorderSize = 0
        Me.btnStarCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStarCount.ForeColor = System.Drawing.Color.White
        Me.btnStarCount.Location = New System.Drawing.Point(12, 32)
        Me.btnStarCount.Name = "btnStarCount"
        Me.btnStarCount.Size = New System.Drawing.Size(153, 23)
        Me.btnStarCount.TabIndex = 23
        Me.btnStarCount.Text = "INICIAR INVENTARIO"
        Me.btnStarCount.UseVisualStyleBackColor = False
        '
        'btnExell
        '
        Me.btnExell.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExell.FlatAppearance.BorderSize = 0
        Me.btnExell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExell.ForeColor = System.Drawing.Color.White
        Me.btnExell.Location = New System.Drawing.Point(189, 32)
        Me.btnExell.Name = "btnExell"
        Me.btnExell.Size = New System.Drawing.Size(133, 23)
        Me.btnExell.TabIndex = 24
        Me.btnExell.Text = "Excell"
        Me.btnExell.UseVisualStyleBackColor = False
        Me.btnExell.Visible = False
        '
        'datalistado_inventory
        '
        Me.datalistado_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado_inventory.Location = New System.Drawing.Point(394, 13)
        Me.datalistado_inventory.Name = "datalistado_inventory"
        Me.datalistado_inventory.Size = New System.Drawing.Size(10, 20)
        Me.datalistado_inventory.TabIndex = 25
        Me.datalistado_inventory.Visible = False
        '
        'frm_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(716, 575)
        Me.Controls.Add(Me.datalistado_inventory)
        Me.Controls.Add(Me.btnExell)
        Me.Controls.Add(Me.btnStarCount)
        Me.Controls.Add(Me.btnNuevoCombo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_buscar_proctos)
        Me.Controls.Add(Me.datalistado_productos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_productos"
        CType(Me.datalistado_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c_menu_productos.ResumeLayout(False)
        CType(Me.datalistado_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datalistado_productos As DataGridView
    Friend WithEvents txt_buscar_proctos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_nuevo As CTSkinet.CTSkinetButton
    Friend WithEvents c_menu_productos As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNuevoCombo As Button
    Friend WithEvents ReabastecerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnStarCount As Button
    Friend WithEvents btnExell As Button
    Friend WithEvents datalistado_inventory As DataGridView
End Class
