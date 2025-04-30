<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labNuevo = New System.Windows.Forms.Label()
        Me.labError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'txbUsuario
        '
        Me.txbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbUsuario.Location = New System.Drawing.Point(57, 110)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(195, 26)
        Me.txbUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'txbPass
        '
        Me.txbPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPass.Location = New System.Drawing.Point(57, 206)
        Me.txbPass.Name = "txbPass"
        Me.txbPass.Size = New System.Drawing.Size(195, 26)
        Me.txbPass.TabIndex = 3
        Me.txbPass.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(100, 266)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(94, 41)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sistema de inventario"
        '
        'labNuevo
        '
        Me.labNuevo.AutoSize = True
        Me.labNuevo.Location = New System.Drawing.Point(199, 351)
        Me.labNuevo.Name = "labNuevo"
        Me.labNuevo.Size = New System.Drawing.Size(116, 13)
        Me.labNuevo.TabIndex = 6
        Me.labNuevo.Text = "Crea una cuenta aca..."
        '
        'labError
        '
        Me.labError.AutoSize = True
        Me.labError.ForeColor = System.Drawing.Color.Red
        Me.labError.Location = New System.Drawing.Point(13, 346)
        Me.labError.Name = "labError"
        Me.labError.Size = New System.Drawing.Size(0, 13)
        Me.labError.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 371)
        Me.Controls.Add(Me.labError)
        Me.Controls.Add(Me.labNuevo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txbPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents labNuevo As Label
    Friend WithEvents labError As Label
End Class
