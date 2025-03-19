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
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.txbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.botGuardar = New System.Windows.Forms.Button()
        Me.botLeerTexto = New System.Windows.Forms.Button()
        Me.botCambiarEtiqueta = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbNombre
        '
        Me.txbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre.ForeColor = System.Drawing.Color.Fuchsia
        Me.txbNombre.Location = New System.Drawing.Point(39, 61)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(290, 29)
        Me.txbNombre.TabIndex = 0
        '
        'txbDescripcion
        '
        Me.txbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDescripcion.ForeColor = System.Drawing.Color.Fuchsia
        Me.txbDescripcion.Location = New System.Drawing.Point(39, 297)
        Me.txbDescripcion.Name = "txbDescripcion"
        Me.txbDescripcion.Size = New System.Drawing.Size(383, 111)
        Me.txbDescripcion.TabIndex = 3
        Me.txbDescripcion.Text = "ingrese aca su descripcion"
        '
        'txbTelefono
        '
        Me.txbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTelefono.ForeColor = System.Drawing.Color.Fuchsia
        Me.txbTelefono.Location = New System.Drawing.Point(39, 179)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(298, 29)
        Me.txbTelefono.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese su nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ingrese su numero telefonico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Describete:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Elige tu carrera:"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Items.AddRange(New Object() {"Civil", "Quimica", "Mecanica", "Electrica", "Industrial", "Sistemas", "Electronica"})
        Me.ListBox1.Location = New System.Drawing.Point(24, 62)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(183, 196)
        Me.ListBox1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(467, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 284)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'botGuardar
        '
        Me.botGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botGuardar.Location = New System.Drawing.Point(518, 312)
        Me.botGuardar.Name = "botGuardar"
        Me.botGuardar.Size = New System.Drawing.Size(156, 46)
        Me.botGuardar.TabIndex = 9
        Me.botGuardar.Text = "Guardar Datos"
        Me.botGuardar.UseVisualStyleBackColor = True
        '
        'botLeerTexto
        '
        Me.botLeerTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botLeerTexto.Location = New System.Drawing.Point(620, 364)
        Me.botLeerTexto.Name = "botLeerTexto"
        Me.botLeerTexto.Size = New System.Drawing.Size(139, 46)
        Me.botLeerTexto.TabIndex = 11
        Me.botLeerTexto.Text = "Leer Valor"
        Me.botLeerTexto.UseVisualStyleBackColor = True
        '
        'botCambiarEtiqueta
        '
        Me.botCambiarEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botCambiarEtiqueta.Location = New System.Drawing.Point(453, 364)
        Me.botCambiarEtiqueta.Name = "botCambiarEtiqueta"
        Me.botCambiarEtiqueta.Size = New System.Drawing.Size(124, 59)
        Me.botCambiarEtiqueta.TabIndex = 12
        Me.botCambiarEtiqueta.Text = "Cambiar Etiqueta"
        Me.botCambiarEtiqueta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 450)
        Me.Controls.Add(Me.botCambiarEtiqueta)
        Me.Controls.Add(Me.botLeerTexto)
        Me.Controls.Add(Me.botGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.txbDescripcion)
        Me.Controls.Add(Me.txbNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbNombre As TextBox
    Friend WithEvents txbDescripcion As RichTextBox
    Friend WithEvents txbTelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents botGuardar As Button
    Friend WithEvents botLeerTexto As Button
    Friend WithEvents botCambiarEtiqueta As Button
End Class
