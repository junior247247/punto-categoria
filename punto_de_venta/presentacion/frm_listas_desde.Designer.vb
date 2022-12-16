<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listas_desde
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listas_desde))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New CTSkinet.CTSkinetButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGastos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_retirados = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_ventas = New System.Windows.Forms.Label()
        Me.lbl_compras = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_ganancias = New System.Windows.Forms.Label()
        Me.lbl_mantenimiento = New System.Windows.Forms.Label()
        Me.lbl_recargas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_total_de_ingresos = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblGastosMenosIngresos = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotalInversion = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblOtrosGastos = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotalMENOSGASTOS = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 29)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(291, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 575
        Me.Label4.Text = "Ingresos"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(656, -1)
        Me.btn_cerrar.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(33, 30)
        Me.btn_cerrar.TabIndex = 574
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGastos)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbl_retirados)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_ventas)
        Me.GroupBox1.Controls.Add(Me.lbl_compras)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_ganancias)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 93)
        Me.GroupBox1.TabIndex = 575
        Me.GroupBox1.TabStop = False
        '
        'lblGastos
        '
        Me.lblGastos.AutoSize = True
        Me.lblGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastos.Location = New System.Drawing.Point(323, 61)
        Me.lblGastos.Name = "lblGastos"
        Me.lblGastos.Size = New System.Drawing.Size(17, 18)
        Me.lblGastos.TabIndex = 3
        Me.lblGastos.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(249, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Gastos:"
        '
        'lbl_retirados
        '
        Me.lbl_retirados.AutoSize = True
        Me.lbl_retirados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_retirados.Location = New System.Drawing.Point(111, 61)
        Me.lbl_retirados.Name = "lbl_retirados"
        Me.lbl_retirados.Size = New System.Drawing.Size(17, 18)
        Me.lbl_retirados.TabIndex = 3
        Me.lbl_retirados.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Compras:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Retirados:"
        '
        'lbl_ventas
        '
        Me.lbl_ventas.AutoSize = True
        Me.lbl_ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ventas.Location = New System.Drawing.Point(93, 20)
        Me.lbl_ventas.Name = "lbl_ventas"
        Me.lbl_ventas.Size = New System.Drawing.Size(16, 16)
        Me.lbl_ventas.TabIndex = 0
        Me.lbl_ventas.Text = "0"
        '
        'lbl_compras
        '
        Me.lbl_compras.AutoSize = True
        Me.lbl_compras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_compras.Location = New System.Drawing.Point(321, 21)
        Me.lbl_compras.Name = "lbl_compras"
        Me.lbl_compras.Size = New System.Drawing.Size(16, 16)
        Me.lbl_compras.TabIndex = 0
        Me.lbl_compras.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ventas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(454, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ganancias:"
        '
        'lbl_ganancias
        '
        Me.lbl_ganancias.AutoSize = True
        Me.lbl_ganancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ganancias.Location = New System.Drawing.Point(547, 21)
        Me.lbl_ganancias.Name = "lbl_ganancias"
        Me.lbl_ganancias.Size = New System.Drawing.Size(16, 16)
        Me.lbl_ganancias.TabIndex = 0
        Me.lbl_ganancias.Text = "0"
        '
        'lbl_mantenimiento
        '
        Me.lbl_mantenimiento.AutoSize = True
        Me.lbl_mantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mantenimiento.Location = New System.Drawing.Point(486, 36)
        Me.lbl_mantenimiento.Name = "lbl_mantenimiento"
        Me.lbl_mantenimiento.Size = New System.Drawing.Size(17, 18)
        Me.lbl_mantenimiento.TabIndex = 1
        Me.lbl_mantenimiento.Text = "0"
        Me.lbl_mantenimiento.Visible = False
        '
        'lbl_recargas
        '
        Me.lbl_recargas.AutoSize = True
        Me.lbl_recargas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_recargas.Location = New System.Drawing.Point(104, 35)
        Me.lbl_recargas.Name = "lbl_recargas"
        Me.lbl_recargas.Size = New System.Drawing.Size(17, 18)
        Me.lbl_recargas.TabIndex = 1
        Me.lbl_recargas.Text = "0"
        Me.lbl_recargas.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(364, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Mantenimiento:"
        Me.Label7.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Recargas:"
        Me.Label5.Visible = False
        '
        'txt_fecha1
        '
        Me.txt_fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha1.Location = New System.Drawing.Point(12, 59)
        Me.txt_fecha1.Name = "txt_fecha1"
        Me.txt_fecha1.Size = New System.Drawing.Size(103, 20)
        Me.txt_fecha1.TabIndex = 576
        '
        'txt_fecha2
        '
        Me.txt_fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha2.Location = New System.Drawing.Point(587, 59)
        Me.txt_fecha2.Name = "txt_fecha2"
        Me.txt_fecha2.Size = New System.Drawing.Size(93, 20)
        Me.txt_fecha2.TabIndex = 576
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(457, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Total de ingresos:"
        '
        'lbl_total_de_ingresos
        '
        Me.lbl_total_de_ingresos.AutoSize = True
        Me.lbl_total_de_ingresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_de_ingresos.Location = New System.Drawing.Point(571, 216)
        Me.lbl_total_de_ingresos.Name = "lbl_total_de_ingresos"
        Me.lbl_total_de_ingresos.Size = New System.Drawing.Size(14, 13)
        Me.lbl_total_de_ingresos.TabIndex = 4
        Me.lbl_total_de_ingresos.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(464, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Ventas - gastos:"
        '
        'lblGastosMenosIngresos
        '
        Me.lblGastosMenosIngresos.AutoSize = True
        Me.lblGastosMenosIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastosMenosIngresos.Location = New System.Drawing.Point(570, 184)
        Me.lblGastosMenosIngresos.Name = "lblGastosMenosIngresos"
        Me.lblGastosMenosIngresos.Size = New System.Drawing.Size(14, 13)
        Me.lblGastosMenosIngresos.TabIndex = 3
        Me.lblGastosMenosIngresos.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(74, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "GASTOS INVERSION:"
        '
        'lblTotalInversion
        '
        Me.lblTotalInversion.AutoSize = True
        Me.lblTotalInversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInversion.Location = New System.Drawing.Point(215, 179)
        Me.lblTotalInversion.Name = "lblTotalInversion"
        Me.lblTotalInversion.Size = New System.Drawing.Size(14, 13)
        Me.lblTotalInversion.TabIndex = 3
        Me.lblTotalInversion.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(101, 209)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "OTROS GASTOS:"
        '
        'lblOtrosGastos
        '
        Me.lblOtrosGastos.AutoSize = True
        Me.lblOtrosGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtrosGastos.Location = New System.Drawing.Point(215, 209)
        Me.lblOtrosGastos.Name = "lblOtrosGastos"
        Me.lblOtrosGastos.Size = New System.Drawing.Size(14, 13)
        Me.lblOtrosGastos.TabIndex = 3
        Me.lblOtrosGastos.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 237)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(191, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "GANANCIAS - OTROS GASTOS:"
        '
        'lblTotalMENOSGASTOS
        '
        Me.lblTotalMENOSGASTOS.AutoSize = True
        Me.lblTotalMENOSGASTOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMENOSGASTOS.Location = New System.Drawing.Point(215, 237)
        Me.lblTotalMENOSGASTOS.Name = "lblTotalMENOSGASTOS"
        Me.lblTotalMENOSGASTOS.Size = New System.Drawing.Size(14, 13)
        Me.lblTotalMENOSGASTOS.TabIndex = 3
        Me.lblTotalMENOSGASTOS.Text = "0"
        '
        'frm_listas_desde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(692, 277)
        Me.Controls.Add(Me.lblGastosMenosIngresos)
        Me.Controls.Add(Me.lblTotalMENOSGASTOS)
        Me.Controls.Add(Me.lblOtrosGastos)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTotalInversion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_total_de_ingresos)
        Me.Controls.Add(Me.txt_fecha2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_mantenimiento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_recargas)
        Me.Controls.Add(Me.txt_fecha1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_listas_desde"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_listas_desde"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cerrar As CTSkinet.CTSkinetButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_fecha1 As DateTimePicker
    Friend WithEvents txt_fecha2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_ganancias As Label
    Friend WithEvents lbl_ventas As Label
    Friend WithEvents lbl_compras As Label
    Friend WithEvents lbl_recargas As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_mantenimiento As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_retirados As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_total_de_ingresos As Label
    Friend WithEvents lblGastos As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblGastosMenosIngresos As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotalInversion As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblOtrosGastos As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTotalMENOSGASTOS As Label
End Class
