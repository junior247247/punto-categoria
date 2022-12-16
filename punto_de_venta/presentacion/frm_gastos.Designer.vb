<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gastos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegistrarNuevoGasto = New CTSkinet.CTSkinetButton()
        Me.datalistado_gastos = New System.Windows.Forms.DataGridView()
        Me.btnExportaraexcell = New CTSkinet.CTSkinetButton()
        Me.btnImprimir = New CTSkinet.CTSkinetButton()
        Me.txtfecha1 = New System.Windows.Forms.DateTimePicker()
        Me.txtfecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.datalistado_gastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRegistrarNuevoGasto)
        Me.Panel1.Location = New System.Drawing.Point(12, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 38)
        Me.Panel1.TabIndex = 3
        '
        'btnRegistrarNuevoGasto
        '
        Me.btnRegistrarNuevoGasto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrarNuevoGasto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRegistrarNuevoGasto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRegistrarNuevoGasto.FlatAppearance.BorderSize = 0
        Me.btnRegistrarNuevoGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarNuevoGasto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarNuevoGasto.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarNuevoGasto.Location = New System.Drawing.Point(514, 3)
        Me.btnRegistrarNuevoGasto.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRegistrarNuevoGasto.Name = "btnRegistrarNuevoGasto"
        Me.btnRegistrarNuevoGasto.Size = New System.Drawing.Size(182, 31)
        Me.btnRegistrarNuevoGasto.TabIndex = 614
        Me.btnRegistrarNuevoGasto.Text = "Registrar nuevo gasto"
        Me.btnRegistrarNuevoGasto.UseVisualStyleBackColor = False
        '
        'datalistado_gastos
        '
        Me.datalistado_gastos.AllowUserToAddRows = False
        Me.datalistado_gastos.AllowUserToDeleteRows = False
        Me.datalistado_gastos.AllowUserToResizeColumns = False
        Me.datalistado_gastos.AllowUserToResizeRows = False
        Me.datalistado_gastos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datalistado_gastos.BackgroundColor = System.Drawing.Color.White
        Me.datalistado_gastos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado_gastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistado_gastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_gastos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_gastos.ColumnHeadersHeight = 25
        Me.datalistado_gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datalistado_gastos.GridColor = System.Drawing.SystemColors.Control
        Me.datalistado_gastos.Location = New System.Drawing.Point(12, 164)
        Me.datalistado_gastos.Name = "datalistado_gastos"
        Me.datalistado_gastos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_gastos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_gastos.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.datalistado_gastos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_gastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_gastos.Size = New System.Drawing.Size(705, 260)
        Me.datalistado_gastos.TabIndex = 605
        '
        'btnExportaraexcell
        '
        Me.btnExportaraexcell.BackColor = System.Drawing.Color.White
        Me.btnExportaraexcell.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExportaraexcell.FlatAppearance.BorderSize = 0
        Me.btnExportaraexcell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportaraexcell.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportaraexcell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnExportaraexcell.Location = New System.Drawing.Point(10, 431)
        Me.btnExportaraexcell.MainColor = System.Drawing.Color.White
        Me.btnExportaraexcell.Name = "btnExportaraexcell"
        Me.btnExportaraexcell.Size = New System.Drawing.Size(136, 29)
        Me.btnExportaraexcell.TabIndex = 606
        Me.btnExportaraexcell.Text = "Exportar a Excel"
        Me.btnExportaraexcell.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.BackColor = System.Drawing.Color.White
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnImprimir.Location = New System.Drawing.Point(606, 126)
        Me.btnImprimir.MainColor = System.Drawing.Color.White
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(109, 29)
        Me.btnImprimir.TabIndex = 607
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'txtfecha1
        '
        Me.txtfecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha1.Location = New System.Drawing.Point(67, 135)
        Me.txtfecha1.Name = "txtfecha1"
        Me.txtfecha1.Size = New System.Drawing.Size(97, 20)
        Me.txtfecha1.TabIndex = 608
        '
        'txtfecha2
        '
        Me.txtfecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha2.Location = New System.Drawing.Point(225, 136)
        Me.txtfecha2.Name = "txtfecha2"
        Me.txtfecha2.Size = New System.Drawing.Size(100, 20)
        Me.txtfecha2.TabIndex = 609
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 610
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 611
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 612
        Me.Label3.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(57, 27)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(18, 20)
        Me.lblTotal.TabIndex = 613
        Me.lblTotal.Text = "0"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ELIMINARToolStripMenuItem, Me.EDITARToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 48)
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'EDITARToolStripMenuItem
        '
        Me.EDITARToolStripMenuItem.Name = "EDITARToolStripMenuItem"
        Me.EDITARToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.EDITARToolStripMenuItem.Text = "EDITAR"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Items.AddRange(New Object() {"OTRO", "INVERSION", "TODOS"})
        Me.cboCategoria.Location = New System.Drawing.Point(381, 134)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cboCategoria.TabIndex = 614
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(340, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 611
        Me.Label4.Text = "Tipo:"
        '
        'frm_gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 614)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfecha2)
        Me.Controls.Add(Me.txtfecha1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnExportaraexcell)
        Me.Controls.Add(Me.datalistado_gastos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_gastos"
        Me.Text = "Gastos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.datalistado_gastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents datalistado_gastos As DataGridView
    Friend WithEvents btnExportaraexcell As CTSkinet.CTSkinetButton
    Friend WithEvents btnImprimir As CTSkinet.CTSkinetButton
    Friend WithEvents txtfecha1 As DateTimePicker
    Friend WithEvents txtfecha2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnRegistrarNuevoGasto As CTSkinet.CTSkinetButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents Label4 As Label
End Class
