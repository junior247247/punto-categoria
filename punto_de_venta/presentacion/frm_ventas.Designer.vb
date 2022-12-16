<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ventas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_nueva_venta = New CTSkinet.CTSkinetButton()
        Me.datalistado_ventas = New System.Windows.Forms.DataGridView()
        Me.txt_buscar_venta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_imprimir_ticket = New CTSkinet.CTSkinetButton()
        Me.btn_mantenimiento = New CTSkinet.CTSkinetButton()
        Me.btn_facturas_a_creditos = New CTSkinet.CTSkinetButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VERARTICULOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalBar = New System.Windows.Forms.Label()
        Me.lblTotalGomera = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.datalistado_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(9, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 28)
        Me.Panel1.TabIndex = 0
        '
        'btn_nueva_venta
        '
        Me.btn_nueva_venta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_nueva_venta.BackColor = System.Drawing.Color.White
        Me.btn_nueva_venta.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_nueva_venta.FlatAppearance.BorderSize = 0
        Me.btn_nueva_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nueva_venta.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nueva_venta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_nueva_venta.Location = New System.Drawing.Point(620, 38)
        Me.btn_nueva_venta.MainColor = System.Drawing.Color.White
        Me.btn_nueva_venta.Name = "btn_nueva_venta"
        Me.btn_nueva_venta.Size = New System.Drawing.Size(89, 35)
        Me.btn_nueva_venta.TabIndex = 1
        Me.btn_nueva_venta.Text = "Nueva"
        Me.btn_nueva_venta.UseVisualStyleBackColor = False
        '
        'datalistado_ventas
        '
        Me.datalistado_ventas.AllowUserToAddRows = False
        Me.datalistado_ventas.AllowUserToDeleteRows = False
        Me.datalistado_ventas.AllowUserToResizeColumns = False
        Me.datalistado_ventas.AllowUserToResizeRows = False
        Me.datalistado_ventas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datalistado_ventas.BackgroundColor = System.Drawing.Color.Silver
        Me.datalistado_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado_ventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistado_ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_ventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_ventas.ColumnHeadersHeight = 25
        Me.datalistado_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datalistado_ventas.GridColor = System.Drawing.SystemColors.Control
        Me.datalistado_ventas.Location = New System.Drawing.Point(9, 151)
        Me.datalistado_ventas.Name = "datalistado_ventas"
        Me.datalistado_ventas.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_ventas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_ventas.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.datalistado_ventas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_ventas.Size = New System.Drawing.Size(699, 341)
        Me.datalistado_ventas.TabIndex = 18
        '
        'txt_buscar_venta
        '
        Me.txt_buscar_venta.Location = New System.Drawing.Point(66, 125)
        Me.txt_buscar_venta.Name = "txt_buscar_venta"
        Me.txt_buscar_venta.Size = New System.Drawing.Size(221, 20)
        Me.txt_buscar_venta.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Buscar:"
        '
        'btn_imprimir_ticket
        '
        Me.btn_imprimir_ticket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_imprimir_ticket.BackColor = System.Drawing.Color.White
        Me.btn_imprimir_ticket.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_imprimir_ticket.FlatAppearance.BorderSize = 0
        Me.btn_imprimir_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir_ticket.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir_ticket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_imprimir_ticket.Location = New System.Drawing.Point(615, 110)
        Me.btn_imprimir_ticket.MainColor = System.Drawing.Color.White
        Me.btn_imprimir_ticket.Name = "btn_imprimir_ticket"
        Me.btn_imprimir_ticket.Size = New System.Drawing.Size(93, 35)
        Me.btn_imprimir_ticket.TabIndex = 21
        Me.btn_imprimir_ticket.Text = "IMPRIMIR"
        Me.btn_imprimir_ticket.UseVisualStyleBackColor = False
        '
        'btn_mantenimiento
        '
        Me.btn_mantenimiento.BackColor = System.Drawing.Color.White
        Me.btn_mantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_mantenimiento.FlatAppearance.BorderSize = 0
        Me.btn_mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mantenimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mantenimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_mantenimiento.Location = New System.Drawing.Point(12, 38)
        Me.btn_mantenimiento.MainColor = System.Drawing.Color.White
        Me.btn_mantenimiento.Name = "btn_mantenimiento"
        Me.btn_mantenimiento.Size = New System.Drawing.Size(181, 35)
        Me.btn_mantenimiento.TabIndex = 22
        Me.btn_mantenimiento.Text = " Mantenimiento"
        Me.btn_mantenimiento.UseVisualStyleBackColor = False
        '
        'btn_facturas_a_creditos
        '
        Me.btn_facturas_a_creditos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_facturas_a_creditos.BackColor = System.Drawing.Color.White
        Me.btn_facturas_a_creditos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_facturas_a_creditos.FlatAppearance.BorderSize = 0
        Me.btn_facturas_a_creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_facturas_a_creditos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facturas_a_creditos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_facturas_a_creditos.Location = New System.Drawing.Point(528, 498)
        Me.btn_facturas_a_creditos.MainColor = System.Drawing.Color.White
        Me.btn_facturas_a_creditos.Name = "btn_facturas_a_creditos"
        Me.btn_facturas_a_creditos.Size = New System.Drawing.Size(181, 35)
        Me.btn_facturas_a_creditos.TabIndex = 23
        Me.btn_facturas_a_creditos.Text = "FACTURAS A CREDITO"
        Me.btn_facturas_a_creditos.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VERARTICULOSToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 26)
        '
        'VERARTICULOSToolStripMenuItem
        '
        Me.VERARTICULOSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.VERARTICULOSToolStripMenuItem.Name = "VERARTICULOSToolStripMenuItem"
        Me.VERARTICULOSToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.VERARTICULOSToolStripMenuItem.Text = "VER ARTICULOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(293, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "DESDE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(445, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "HASTA:"
        '
        'txtDesde
        '
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesde.Location = New System.Drawing.Point(352, 121)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(87, 20)
        Me.txtDesde.TabIndex = 24
        '
        'txtHasta
        '
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHasta.Location = New System.Drawing.Point(503, 120)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(87, 20)
        Me.txtHasta.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 506)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Total Bar:"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 524)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Total Gomera:"
        Me.Label5.Visible = False
        '
        'lblTotalBar
        '
        Me.lblTotalBar.AutoSize = True
        Me.lblTotalBar.Location = New System.Drawing.Point(84, 506)
        Me.lblTotalBar.Name = "lblTotalBar"
        Me.lblTotalBar.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalBar.TabIndex = 25
        Me.lblTotalBar.Text = "0"
        Me.lblTotalBar.Visible = False
        '
        'lblTotalGomera
        '
        Me.lblTotalGomera.AutoSize = True
        Me.lblTotalGomera.Location = New System.Drawing.Point(84, 526)
        Me.lblTotalGomera.Name = "lblTotalGomera"
        Me.lblTotalGomera.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalGomera.TabIndex = 25
        Me.lblTotalGomera.Text = "0"
        Me.lblTotalGomera.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 542)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Total:"
        Me.Label6.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(84, 544)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "0"
        Me.lblTotal.Visible = False
        '
        'frm_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(716, 575)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotalGomera)
        Me.Controls.Add(Me.lblTotalBar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.btn_facturas_a_creditos)
        Me.Controls.Add(Me.btn_mantenimiento)
        Me.Controls.Add(Me.btn_imprimir_ticket)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_buscar_venta)
        Me.Controls.Add(Me.datalistado_ventas)
        Me.Controls.Add(Me.btn_nueva_venta)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_ventas"
        Me.Text = "Ventas"
        CType(Me.datalistado_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_nueva_venta As CTSkinet.CTSkinetButton
    Friend WithEvents datalistado_ventas As DataGridView
    Friend WithEvents txt_buscar_venta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_imprimir_ticket As CTSkinet.CTSkinetButton
    Friend WithEvents btn_mantenimiento As CTSkinet.CTSkinetButton
    Friend WithEvents btn_facturas_a_creditos As CTSkinet.CTSkinetButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents VERARTICULOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDesde As DateTimePicker
    Friend WithEvents txtHasta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalBar As Label
    Friend WithEvents lblTotalGomera As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotal As Label
End Class
