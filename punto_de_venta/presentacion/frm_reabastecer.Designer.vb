<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reabastecer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_reabastecer))
        Me.lbl_producto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New CTSkinet.CTSkinetButton()
        Me.txt_reabastecer = New System.Windows.Forms.TextBox()
        Me.txt_existencia = New System.Windows.Forms.TextBox()
        Me.btn_reabastecer = New CTSkinet.CTSkinetButton()
        Me.lbl_id_producto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlmacen = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_producto
        '
        Me.lbl_producto.AutoSize = True
        Me.lbl_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_producto.Location = New System.Drawing.Point(140, 44)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(216, 24)
        Me.lbl_producto.TabIndex = 0
        Me.lbl_producto.Text = "Agua planeta azul 18onz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Existencia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Reabastecer:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 36)
        Me.Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(177, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Reabastecer producto"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(439, 3)
        Me.btn_cerrar.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(33, 30)
        Me.btn_cerrar.TabIndex = 575
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'txt_reabastecer
        '
        Me.txt_reabastecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reabastecer.Location = New System.Drawing.Point(136, 121)
        Me.txt_reabastecer.MaxLength = 7
        Me.txt_reabastecer.Name = "txt_reabastecer"
        Me.txt_reabastecer.Size = New System.Drawing.Size(100, 26)
        Me.txt_reabastecer.TabIndex = 5
        '
        'txt_existencia
        '
        Me.txt_existencia.Enabled = False
        Me.txt_existencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_existencia.Location = New System.Drawing.Point(136, 84)
        Me.txt_existencia.Name = "txt_existencia"
        Me.txt_existencia.Size = New System.Drawing.Size(100, 26)
        Me.txt_existencia.TabIndex = 6
        '
        'btn_reabastecer
        '
        Me.btn_reabastecer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_reabastecer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_reabastecer.FlatAppearance.BorderSize = 0
        Me.btn_reabastecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reabastecer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reabastecer.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_reabastecer.Location = New System.Drawing.Point(174, 166)
        Me.btn_reabastecer.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_reabastecer.Name = "btn_reabastecer"
        Me.btn_reabastecer.Size = New System.Drawing.Size(150, 23)
        Me.btn_reabastecer.TabIndex = 7
        Me.btn_reabastecer.Text = "Reabastecer"
        Me.btn_reabastecer.UseVisualStyleBackColor = False
        '
        'lbl_id_producto
        '
        Me.lbl_id_producto.AutoSize = True
        Me.lbl_id_producto.Location = New System.Drawing.Point(378, 149)
        Me.lbl_id_producto.Name = "lbl_id_producto"
        Me.lbl_id_producto.Size = New System.Drawing.Size(39, 13)
        Me.lbl_id_producto.TabIndex = 8
        Me.lbl_id_producto.Text = "Label1"
        Me.lbl_id_producto.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Almacen:"
        '
        'txtAlmacen
        '
        Me.txtAlmacen.Enabled = False
        Me.txtAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlmacen.Location = New System.Drawing.Point(338, 84)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Size = New System.Drawing.Size(100, 26)
        Me.txtAlmacen.TabIndex = 6
        '
        'frm_reabastecer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(475, 204)
        Me.Controls.Add(Me.lbl_id_producto)
        Me.Controls.Add(Me.btn_reabastecer)
        Me.Controls.Add(Me.txtAlmacen)
        Me.Controls.Add(Me.txt_existencia)
        Me.Controls.Add(Me.txt_reabastecer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_producto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_reabastecer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reabastecer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_producto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_cerrar As CTSkinet.CTSkinetButton
    Friend WithEvents txt_reabastecer As TextBox
    Friend WithEvents txt_existencia As TextBox
    Friend WithEvents btn_reabastecer As CTSkinet.CTSkinetButton
    Friend WithEvents lbl_id_producto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAlmacen As TextBox
End Class
