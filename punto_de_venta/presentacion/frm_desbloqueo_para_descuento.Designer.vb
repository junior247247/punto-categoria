﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_desbloqueo_para_descuento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_desbloqueo_para_descuento))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New CTSkinet.CTSkinetButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_desbloquear = New CTSkinet.CTSkinetButton()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_cerrar)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(384, 30)
        Me.Panel2.TabIndex = 20
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(351, 0)
        Me.btn_cerrar.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(33, 30)
        Me.btn_cerrar.TabIndex = 574
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(144, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Desbloquear"
        '
        'btn_desbloquear
        '
        Me.btn_desbloquear.BackColor = System.Drawing.Color.White
        Me.btn_desbloquear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_desbloquear.FlatAppearance.BorderSize = 0
        Me.btn_desbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_desbloquear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desbloquear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_desbloquear.Location = New System.Drawing.Point(268, 59)
        Me.btn_desbloquear.MainColor = System.Drawing.Color.White
        Me.btn_desbloquear.Name = "btn_desbloquear"
        Me.btn_desbloquear.Size = New System.Drawing.Size(112, 20)
        Me.btn_desbloquear.TabIndex = 30
        Me.btn_desbloquear.Text = "Desbloquear"
        Me.btn_desbloquear.UseVisualStyleBackColor = False
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(112, 56)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(151, 26)
        Me.txt_pass.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Contraseña:"
        '
        'frm_desbloqueo_para_descuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 102)
        Me.Controls.Add(Me.btn_desbloquear)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_desbloqueo_para_descuento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desbloqueo para descuento"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_cerrar As CTSkinet.CTSkinetButton
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_desbloquear As CTSkinet.CTSkinetButton
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label1 As Label
End Class
