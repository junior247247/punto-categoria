<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_password_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_password_admin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New CTSkinet.CTSkinetButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_repetir_password = New System.Windows.Forms.TextBox()
        Me.txt_password_nueva = New System.Windows.Forms.TextBox()
        Me.txt_password_actual = New System.Windows.Forms.TextBox()
        Me.btn_cambiar_password = New CTSkinet.CTSkinetButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(463, 34)
        Me.Panel1.TabIndex = 2
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(428, -1)
        Me.btn_cerrar.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(33, 30)
        Me.btn_cerrar.TabIndex = 575
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(137, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CAMBIAR PASSWORD ADMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CONTRASEÑA ACTUAL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CONTRASEÑA NUEVA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "REPETIR LA CONTRASEÑA :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_repetir_password)
        Me.GroupBox1.Controls.Add(Me.txt_password_nueva)
        Me.GroupBox1.Controls.Add(Me.txt_password_actual)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 116)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambiar Contraseña admin"
        '
        'txt_repetir_password
        '
        Me.txt_repetir_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_repetir_password.Location = New System.Drawing.Point(170, 81)
        Me.txt_repetir_password.Name = "txt_repetir_password"
        Me.txt_repetir_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_repetir_password.Size = New System.Drawing.Size(164, 21)
        Me.txt_repetir_password.TabIndex = 6
        '
        'txt_password_nueva
        '
        Me.txt_password_nueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password_nueva.Location = New System.Drawing.Point(169, 56)
        Me.txt_password_nueva.Name = "txt_password_nueva"
        Me.txt_password_nueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password_nueva.Size = New System.Drawing.Size(166, 21)
        Me.txt_password_nueva.TabIndex = 5
        '
        'txt_password_actual
        '
        Me.txt_password_actual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password_actual.Location = New System.Drawing.Point(169, 32)
        Me.txt_password_actual.Name = "txt_password_actual"
        Me.txt_password_actual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password_actual.Size = New System.Drawing.Size(166, 21)
        Me.txt_password_actual.TabIndex = 4
        '
        'btn_cambiar_password
        '
        Me.btn_cambiar_password.BackColor = System.Drawing.Color.White
        Me.btn_cambiar_password.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cambiar_password.FlatAppearance.BorderSize = 0
        Me.btn_cambiar_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cambiar_password.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cambiar_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_cambiar_password.Location = New System.Drawing.Point(112, 163)
        Me.btn_cambiar_password.MainColor = System.Drawing.Color.White
        Me.btn_cambiar_password.Name = "btn_cambiar_password"
        Me.btn_cambiar_password.Size = New System.Drawing.Size(204, 28)
        Me.btn_cambiar_password.TabIndex = 24
        Me.btn_cambiar_password.Text = "CAMBIAR PASSWORD"
        Me.btn_cambiar_password.UseVisualStyleBackColor = False
        '
        'frm_password_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(463, 204)
        Me.Controls.Add(Me.btn_cambiar_password)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_password_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cerrar As CTSkinet.CTSkinetButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_repetir_password As TextBox
    Friend WithEvents txt_password_nueva As TextBox
    Friend WithEvents txt_password_actual As TextBox
    Friend WithEvents btn_cambiar_password As CTSkinet.CTSkinetButton
End Class
