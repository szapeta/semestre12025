Public Class Form1
    Private Sub labNuevo_Click(sender As Object, e As EventArgs) Handles labNuevo.Click
        Dim pantallaCreacion As New CreacionUsurio
        pantallaCreacion.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim resultado As New DataTable

        If txbUsuario.Text <> "" And txbPass.Text <> "" Then
            Dim query = "select * from Usuario where NombreUsuario = '" & txbUsuario.Text.Trim() & "' and Pass = '" & txbPass.Text.Trim() & "' and Estado = 'Activo'"
            Dim objBDD As New ConexionBD

            resultado = objBDD.SelectQuery(query)

            If resultado IsNot Nothing And resultado.Rows.Count = 1 Then

                Dim pantallaProductos As New Productos
                pantallaProductos.Show()

            Else
                labError.Text = "Error en credenciales"
            End If
        End If


    End Sub
End Class
