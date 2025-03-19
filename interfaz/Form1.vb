Public Class Form1
    Private Sub txbDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txbDescripcion.TextChanged

    End Sub

    Private Sub botGuardar_Click(sender As Object, e As EventArgs) Handles botGuardar.Click

        MessageBox.Show("La información se guardo con exito")
    End Sub

    Private Sub botCambiarEtiqueta_Click(sender As Object, e As EventArgs) Handles botCambiarEtiqueta.Click
        Label1.Text = "Ingrese su carnet"
    End Sub

    Private Sub botLeerTexto_Click(sender As Object, e As EventArgs) Handles botLeerTexto.Click

        If txbNombre.Text.Length > 0 Then
            Dim strTextoLeido As String
            strTextoLeido = txbNombre.Text
            MessageBox.Show("Texto leido: " & strTextoLeido)
        Else

            MessageBox.Show("Ingrese el valor del nombre")

        End If


    End Sub
End Class
