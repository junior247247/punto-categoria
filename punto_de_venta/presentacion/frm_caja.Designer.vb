<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_caja))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.lbl_dinero_encaja = New System.Windows.Forms.Label()
        Me.btn_cerrar_turno = New CTSkinet.CTSkinetButton()
        Me.btn_anular_ticket = New CTSkinet.CTSkinetButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.lbl_ganancia_en_ventas = New System.Windows.Forms.Label()
        Me.datalistado_caja = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_total_ventas_card_y_efeec = New System.Windows.Forms.Label()
        Me.lbl_devolucioneS_efectivos = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.lbl_contador_ventas = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.lbl_dinero_en_caja = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_fondo_en_caja = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.datalistado_caja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label89)
        Me.GroupBox6.Controls.Add(Me.lbl_dinero_encaja)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 83)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(278, 44)
        Me.GroupBox6.TabIndex = 598
        Me.GroupBox6.TabStop = False
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(5, 14)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(133, 21)
        Me.Label89.TabIndex = 598
        Me.Label89.Text = "En ventas del dia :"
        '
        'lbl_dinero_encaja
        '
        Me.lbl_dinero_encaja.AutoSize = True
        Me.lbl_dinero_encaja.BackColor = System.Drawing.Color.White
        Me.lbl_dinero_encaja.Enabled = False
        Me.lbl_dinero_encaja.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_dinero_encaja.Location = New System.Drawing.Point(146, 20)
        Me.lbl_dinero_encaja.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_dinero_encaja.Name = "lbl_dinero_encaja"
        Me.lbl_dinero_encaja.Size = New System.Drawing.Size(25, 13)
        Me.lbl_dinero_encaja.TabIndex = 191
        Me.lbl_dinero_encaja.Text = "123"
        '
        'btn_cerrar_turno
        '
        Me.btn_cerrar_turno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar_turno.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar_turno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar_turno.FlatAppearance.BorderSize = 0
        Me.btn_cerrar_turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar_turno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar_turno.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar_turno.Location = New System.Drawing.Point(488, 157)
        Me.btn_cerrar_turno.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar_turno.Name = "btn_cerrar_turno"
        Me.btn_cerrar_turno.Size = New System.Drawing.Size(232, 39)
        Me.btn_cerrar_turno.TabIndex = 601
        Me.btn_cerrar_turno.Text = "Cerrar Turno"
        Me.btn_cerrar_turno.UseVisualStyleBackColor = False
        '
        'btn_anular_ticket
        '
        Me.btn_anular_ticket.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_anular_ticket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_anular_ticket.FlatAppearance.BorderSize = 0
        Me.btn_anular_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_anular_ticket.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anular_ticket.ForeColor = System.Drawing.Color.White
        Me.btn_anular_ticket.Location = New System.Drawing.Point(15, 157)
        Me.btn_anular_ticket.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_anular_ticket.Name = "btn_anular_ticket"
        Me.btn_anular_ticket.Size = New System.Drawing.Size(232, 39)
        Me.btn_anular_ticket.TabIndex = 601
        Me.btn_anular_ticket.Text = "Anular Ticket"
        Me.btn_anular_ticket.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.Label92)
        Me.GroupBox9.Controls.Add(Me.lbl_ganancia_en_ventas)
        Me.GroupBox9.Location = New System.Drawing.Point(116, 23)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(278, 44)
        Me.GroupBox9.TabIndex = 603
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Visible = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(6, 14)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(88, 21)
        Me.Label92.TabIndex = 598
        Me.Label92.Text = "Ganancias :"
        '
        'lbl_ganancia_en_ventas
        '
        Me.lbl_ganancia_en_ventas.AutoSize = True
        Me.lbl_ganancia_en_ventas.BackColor = System.Drawing.Color.White
        Me.lbl_ganancia_en_ventas.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ganancia_en_ventas.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_ganancia_en_ventas.Location = New System.Drawing.Point(100, 16)
        Me.lbl_ganancia_en_ventas.Name = "lbl_ganancia_en_ventas"
        Me.lbl_ganancia_en_ventas.Size = New System.Drawing.Size(21, 20)
        Me.lbl_ganancia_en_ventas.TabIndex = 576
        Me.lbl_ganancia_en_ventas.Text = " 0"
        '
        'datalistado_caja
        '
        Me.datalistado_caja.AllowUserToAddRows = False
        Me.datalistado_caja.AllowUserToDeleteRows = False
        Me.datalistado_caja.AllowUserToResizeColumns = False
        Me.datalistado_caja.AllowUserToResizeRows = False
        Me.datalistado_caja.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datalistado_caja.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.datalistado_caja.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistado_caja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistado_caja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_caja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado_caja.ColumnHeadersHeight = 25
        Me.datalistado_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datalistado_caja.GridColor = System.Drawing.SystemColors.Control
        Me.datalistado_caja.Location = New System.Drawing.Point(15, 345)
        Me.datalistado_caja.Name = "datalistado_caja"
        Me.datalistado_caja.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado_caja.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado_caja.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.datalistado_caja.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado_caja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado_caja.Size = New System.Drawing.Size(705, 240)
        Me.datalistado_caja.TabIndex = 604
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Controls.Add(Me.lbl_total_ventas_card_y_efeec)
        Me.Panel5.Controls.Add(Me.lbl_devolucioneS_efectivos)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label83)
        Me.Panel5.Controls.Add(Me.lbl_contador_ventas)
        Me.Panel5.Controls.Add(Me.Label94)
        Me.Panel5.Controls.Add(Me.lbl_dinero_en_caja)
        Me.Panel5.Controls.Add(Me.Label77)
        Me.Panel5.Controls.Add(Me.Label75)
        Me.Panel5.Location = New System.Drawing.Point(15, 202)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(714, 125)
        Me.Panel5.TabIndex = 595
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(9, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 57)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 596
        Me.PictureBox3.TabStop = False
        '
        'lbl_total_ventas_card_y_efeec
        '
        Me.lbl_total_ventas_card_y_efeec.AutoSize = True
        Me.lbl_total_ventas_card_y_efeec.BackColor = System.Drawing.Color.Yellow
        Me.lbl_total_ventas_card_y_efeec.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_ventas_card_y_efeec.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_total_ventas_card_y_efeec.Location = New System.Drawing.Point(238, 71)
        Me.lbl_total_ventas_card_y_efeec.Name = "lbl_total_ventas_card_y_efeec"
        Me.lbl_total_ventas_card_y_efeec.Size = New System.Drawing.Size(17, 20)
        Me.lbl_total_ventas_card_y_efeec.TabIndex = 576
        Me.lbl_total_ventas_card_y_efeec.Text = "0"
        '
        'lbl_devolucioneS_efectivos
        '
        Me.lbl_devolucioneS_efectivos.AutoSize = True
        Me.lbl_devolucioneS_efectivos.BackColor = System.Drawing.Color.Yellow
        Me.lbl_devolucioneS_efectivos.Enabled = False
        Me.lbl_devolucioneS_efectivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_devolucioneS_efectivos.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_devolucioneS_efectivos.Location = New System.Drawing.Point(573, 14)
        Me.lbl_devolucioneS_efectivos.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_devolucioneS_efectivos.Name = "lbl_devolucioneS_efectivos"
        Me.lbl_devolucioneS_efectivos.Size = New System.Drawing.Size(18, 20)
        Me.lbl_devolucioneS_efectivos.TabIndex = 191
        Me.lbl_devolucioneS_efectivos.Text = "0"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel6.Location = New System.Drawing.Point(274, 249)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(119, 1)
        Me.Panel6.TabIndex = 193
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.Black
        Me.Label83.Location = New System.Drawing.Point(423, 13)
        Me.Label83.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(133, 20)
        Me.Label83.TabIndex = 192
        Me.Label83.Text = "Ventas anuladas:"
        '
        'lbl_contador_ventas
        '
        Me.lbl_contador_ventas.AutoSize = True
        Me.lbl_contador_ventas.Enabled = False
        Me.lbl_contador_ventas.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_contador_ventas.Location = New System.Drawing.Point(236, 49)
        Me.lbl_contador_ventas.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_contador_ventas.Name = "lbl_contador_ventas"
        Me.lbl_contador_ventas.Size = New System.Drawing.Size(19, 13)
        Me.lbl_contador_ventas.TabIndex = 191
        Me.lbl_contador_ventas.Text = "34"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.ForeColor = System.Drawing.Color.Black
        Me.Label94.Location = New System.Drawing.Point(187, 76)
        Me.Label94.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(37, 13)
        Me.Label94.TabIndex = 192
        Me.Label94.Text = "Total :"
        '
        'lbl_dinero_en_caja
        '
        Me.lbl_dinero_en_caja.AutoSize = True
        Me.lbl_dinero_en_caja.Enabled = False
        Me.lbl_dinero_en_caja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_dinero_en_caja.ForeColor = System.Drawing.Color.Black
        Me.lbl_dinero_en_caja.Location = New System.Drawing.Point(233, 14)
        Me.lbl_dinero_en_caja.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_dinero_en_caja.Name = "lbl_dinero_en_caja"
        Me.lbl_dinero_en_caja.Size = New System.Drawing.Size(29, 20)
        Me.lbl_dinero_en_caja.TabIndex = 191
        Me.lbl_dinero_en_caja.Text = "56"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label77.ForeColor = System.Drawing.Color.Black
        Me.Label77.Location = New System.Drawing.Point(83, 14)
        Me.Label77.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(142, 20)
        Me.Label77.TabIndex = 192
        Me.Label77.Text = "Dinero en CAJA:"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.ForeColor = System.Drawing.Color.Black
        Me.Label75.Location = New System.Drawing.Point(75, 49)
        Me.Label75.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(149, 13)
        Me.Label75.TabIndex = 192
        Me.Label75.Text = "Cobros de ventas en efectivo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbl_fondo_en_caja)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(442, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 44)
        Me.GroupBox1.TabIndex = 605
        Me.GroupBox1.TabStop = False
        '
        'lbl_fondo_en_caja
        '
        Me.lbl_fondo_en_caja.AutoSize = True
        Me.lbl_fondo_en_caja.BackColor = System.Drawing.Color.White
        Me.lbl_fondo_en_caja.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fondo_en_caja.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_fondo_en_caja.Location = New System.Drawing.Point(142, 17)
        Me.lbl_fondo_en_caja.Name = "lbl_fondo_en_caja"
        Me.lbl_fondo_en_caja.Size = New System.Drawing.Size(21, 20)
        Me.lbl_fondo_en_caja.TabIndex = 576
        Me.lbl_fondo_en_caja.Text = " 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 21)
        Me.Label1.TabIndex = 598
        Me.Label1.Text = "Fondo de la caja :"
        '
        'frm_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 614)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datalistado_caja)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.btn_anular_ticket)
        Me.Controls.Add(Me.btn_cerrar_turno)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_caja"
        Me.Text = "Caja"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.datalistado_caja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lbl_total_ventas_card_y_efeec As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_contador_ventas As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents lbl_dinero_en_caja As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents lbl_devolucioneS_efectivos As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label89 As Label
    Friend WithEvents lbl_dinero_encaja As Label
    Friend WithEvents btn_cerrar_turno As CTSkinet.CTSkinetButton
    Friend WithEvents btn_anular_ticket As CTSkinet.CTSkinetButton
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label92 As Label
    Friend WithEvents lbl_ganancia_en_ventas As Label
    Friend WithEvents datalistado_caja As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_fondo_en_caja As Label
    Friend WithEvents Label1 As Label
End Class
