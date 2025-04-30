Public Class CreacionUsurio
    Private Sub CreacionUsurio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click

        If txbPass.Text = txbPass2.Text Then

            If txbNombreUsuario.Text.Trim() = "" Then
                labError.Text = "Ingrese un valor en el campo Nombre"
            Else
                If txbCorreo.Text.Trim() = "" Then
                    labError.Text = "Ingrese un valor en el campo Correo"
                Else
                    Dim query As String
                    Dim objConexion As New ConexionBD()

                    query = "Insert into Usuario (NombreUsuario, Pass, EstaEnSistema, Reintentos, Estado, Correo, codigoRol) 
                    values ('" & txbNombreUsuario.Text & "', '" & txbPass.Text & "', 'NO', 0,'Activo', '" & txbCorreo.Text & "', 3)"
                    objConexion.InsertarDatos(query)

                    MessageBox.Show("Usuario registrado exitosamente")

                    txbNombreUsuario.Text = ""
                    txbPass.Text = ""
                    txbPass2.Text = ""
                    txbCorreo.Text = ""
                    labError.Text = ""

                    Dim pantallaProductos As New Productos
                    pantallaProductos.Show()

                End If
            End If
        Else
            labError.Text = "Contraseñas no son iguales"
        End If

    End Sub
End Class