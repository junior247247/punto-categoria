<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_usuarios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_ver_usuarios = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_turno = New System.Windows.Forms.ComboBox()
        Me.lbL_id_usaurio = New System.Windows.Forms.Label()
        Me.cbo_permisos = New System.Windows.Forms.ComboBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_nombre_y_apellido = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_guardar = New CTSkinet.CTSkinetButton()
        Me.btn_editar = New CTSkinet.CTSkinetButton()
        Me.btn_cambiar_password_admin = New CTSkinet.CTSkinetButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_ver_usuarios)
        Me.Panel1.Location = New System.Drawing.Point(8, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 28)
        Me.Panel1.TabIndex = 1
        '
        'btn_ver_usuarios
        '
        Me.btn_ver_usuarios.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ver_usuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ver_usuarios.AutoSize = True
        Me.btn_ver_usuarios.LinkColor = System.Drawing.Color.White
        Me.btn_ver_usuarios.Location = New System.Drawing.Point(604, 8)
        Me.btn_ver_usuarios.Name = "btn_ver_usuarios"
        Me.btn_ver_usuarios.Size = New System.Drawing.Size(88, 13)
        Me.btn_ver_usuarios.TabIndex = 8
        Me.btn_ver_usuarios.TabStop = True
        Me.btn_ver_usuarios.Text = "VER USAURIOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NOMBRE Y APELLIDO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CONTRASEÑA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PERMISO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "USUARIO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbo_turno)
        Me.GroupBox1.Controls.Add(Me.lbL_id_usaurio)
        Me.GroupBox1.Controls.Add(Me.cbo_permisos)
        Me.GroupBox1.Controls.Add(Me.txt_password)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_y_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_usuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 152)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO DE USUARIO"
        '
        'cbo_turno
        '
        Me.cbo_turno.FormattingEnabled = True
        Me.cbo_turno.Items.AddRange(New Object() {"T1", "T2", "T3"})
        Me.cbo_turno.Location = New System.Drawing.Point(407, 48)
        Me.cbo_turno.Name = "cbo_turno"
        Me.cbo_turno.Size = New System.Drawing.Size(46, 21)
        Me.cbo_turno.TabIndex = 8
        Me.cbo_turno.Text = "T1"
        '
        'lbL_id_usaurio
        '
        Me.lbL_id_usaurio.AutoSize = True
        Me.lbL_id_usaurio.Location = New System.Drawing.Point(569, 26)
        Me.lbL_id_usaurio.Name = "lbL_id_usaurio"
        Me.lbL_id_usaurio.Size = New System.Drawing.Size(39, 13)
        Me.lbL_id_usaurio.TabIndex = 8
        Me.lbL_id_usaurio.Text = "Label5"
        Me.lbL_id_usaurio.Visible = False
        '
        'cbo_permisos
        '
        Me.cbo_permisos.FormattingEnabled = True
        Me.cbo_permisos.Items.AddRange(New Object() {"ADMINISTRADOR", "CAJERO"})
        Me.cbo_permisos.Location = New System.Drawing.Point(157, 106)
        Me.cbo_permisos.Name = "cbo_permisos"
        Me.cbo_permisos.Size = New System.Drawing.Size(121, 21)
        Me.cbo_permisos.TabIndex = 8
        Me.cbo_permisos.Text = "ADMINISTRADOR"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(157, 78)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(181, 22)
        Me.txt_password.TabIndex = 7
        '
        'txt_nombre_y_apellido
        '
        Me.txt_nombre_y_apellido.Location = New System.Drawing.Point(157, 23)
        Me.txt_nombre_y_apellido.Name = "txt_nombre_y_apellido"
        Me.txt_nombre_y_apellido.Size = New System.Drawing.Size(366, 20)
        Me.txt_nombre_y_apellido.TabIndex = 6
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(157, 52)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(182, 20)
        Me.txt_usuario.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(351, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TURNO:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.White
        Me.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_guardar.Location = New System.Drawing.Point(19, 248)
        Me.btn_guardar.MainColor = System.Drawing.Color.White
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(89, 35)
        Me.btn_guardar.TabIndex = 6
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.White
        Me.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_editar.FlatAppearance.BorderSize = 0
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_editar.Location = New System.Drawing.Point(19, 248)
        Me.btn_editar.MainColor = System.Drawing.Color.White
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(89, 35)
        Me.btn_editar.TabIndex = 7
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'btn_cambiar_password_admin
        '
        Me.btn_cambiar_password_admin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cambiar_password_admin.BackColor = System.Drawing.Color.White
        Me.btn_cambiar_password_admin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cambiar_password_admin.FlatAppearance.BorderSize = 0
        Me.btn_cambiar_password_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cambiar_password_admin.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cambiar_password_admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_cambiar_password_admin.Location = New System.Drawing.Point(426, 248)
        Me.btn_cambiar_password_admin.MainColor = System.Drawing.Color.White
        Me.btn_cambiar_password_admin.Name = "btn_cambiar_password_admin"
        Me.btn_cambiar_password_admin.Size = New System.Drawing.Size(274, 35)
        Me.btn_cambiar_password_admin.TabIndex = 8
        Me.btn_cambiar_password_admin.Text = "Cambiar Contraeña Admin"
        Me.btn_cambiar_password_admin.UseVisualStyleBackColor = False
        '
        'frm_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(716, 575)
        Me.Controls.Add(Me.btn_cambiar_password_admin)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_usuarios"
        Me.Text = "Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_permisos As ComboBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_nombre_y_apellido As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents btn_guardar As CTSkinet.CTSkinetButton
    Friend WithEvents btn_editar As CTSkinet.CTSkinetButton
    Friend WithEvents btn_ver_usuarios As LinkLabel
    Friend WithEvents lbL_id_usaurio As Label
    Friend WithEvents cbo_turno As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_cambiar_password_admin As CTSkinet.CTSkinetButton
End Class
