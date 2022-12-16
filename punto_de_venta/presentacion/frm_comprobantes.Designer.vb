<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_comprobantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_comprobantes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New CTSkinet.CTSkinetButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_desde = New System.Windows.Forms.TextBox()
        Me.txt_hasta = New System.Windows.Forms.TextBox()
        Me.txt_ultimo_disponible = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_numeor_de_comprobantes_disponibles = New System.Windows.Forms.Label()
        Me.btn_agregar_comprobantes = New CTSkinet.CTSkinetButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 30)
        Me.Panel1.TabIndex = 0
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(406, 0)
        Me.btn_cerrar.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(33, 30)
        Me.btn_cerrar.TabIndex = 574
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(160, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Comprobantes"
        '
        'txt_desde
        '
        Me.txt_desde.Location = New System.Drawing.Point(73, 70)
        Me.txt_desde.Name = "txt_desde"
        Me.txt_desde.Size = New System.Drawing.Size(100, 20)
        Me.txt_desde.TabIndex = 1
        '
        'txt_hasta
        '
        Me.txt_hasta.Location = New System.Drawing.Point(73, 95)
        Me.txt_hasta.Name = "txt_hasta"
        Me.txt_hasta.Size = New System.Drawing.Size(100, 20)
        Me.txt_hasta.TabIndex = 2
        '
        'txt_ultimo_disponible
        '
        Me.txt_ultimo_disponible.Enabled = False
        Me.txt_ultimo_disponible.Location = New System.Drawing.Point(327, 45)
        Me.txt_ultimo_disponible.Name = "txt_ultimo_disponible"
        Me.txt_ultimo_disponible.Size = New System.Drawing.Size(100, 20)
        Me.txt_ultimo_disponible.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ultimo disponible:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(226, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Disponibles:"
        '
        'lbl_numeor_de_comprobantes_disponibles
        '
        Me.lbl_numeor_de_comprobantes_disponibles.AutoSize = True
        Me.lbl_numeor_de_comprobantes_disponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numeor_de_comprobantes_disponibles.Location = New System.Drawing.Point(320, 75)
        Me.lbl_numeor_de_comprobantes_disponibles.Name = "lbl_numeor_de_comprobantes_disponibles"
        Me.lbl_numeor_de_comprobantes_disponibles.Size = New System.Drawing.Size(18, 20)
        Me.lbl_numeor_de_comprobantes_disponibles.TabIndex = 6
        Me.lbl_numeor_de_comprobantes_disponibles.Text = "0"
        '
        'btn_agregar_comprobantes
        '
        Me.btn_agregar_comprobantes.BackColor = System.Drawing.Color.White
        Me.btn_agregar_comprobantes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_agregar_comprobantes.FlatAppearance.BorderSize = 0
        Me.btn_agregar_comprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar_comprobantes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_comprobantes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_agregar_comprobantes.Location = New System.Drawing.Point(163, 134)
        Me.btn_agregar_comprobantes.MainColor = System.Drawing.Color.White
        Me.btn_agregar_comprobantes.Name = "btn_agregar_comprobantes"
        Me.btn_agregar_comprobantes.Size = New System.Drawing.Size(114, 34)
        Me.btn_agregar_comprobantes.TabIndex = 584
        Me.btn_agregar_comprobantes.Text = "Agregar"
        Me.btn_agregar_comprobantes.UseVisualStyleBackColor = False
        '
        'frm_comprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(439, 180)
        Me.Controls.Add(Me.btn_agregar_comprobantes)
        Me.Controls.Add(Me.lbl_numeor_de_comprobantes_disponibles)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_ultimo_disponible)
        Me.Controls.Add(Me.txt_hasta)
        Me.Controls.Add(Me.txt_desde)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_comprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobantes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_desde As TextBox
    Friend WithEvents txt_hasta As TextBox
    Friend WithEvents txt_ultimo_disponible As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_numeor_de_comprobantes_disponibles As Label
    Friend WithEvents btn_agregar_comprobantes As CTSkinet.CTSkinetButton
    Friend WithEvents btn_cerrar As CTSkinet.CTSkinetButton
End Class
