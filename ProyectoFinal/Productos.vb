Public Class Productos
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objProductos As New ConexionBD
        Dim query As String
        query = "select * from Producto"
        dgvProductos.DataSource = objProductos.SelectQuery(query)
    End Sub
End Class