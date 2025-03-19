
Public Class Maquina

    'Propiedades o caracteristicas
    Public Marca As String
    Public Capacidad As Integer
    Public Moneda As String
    Public CantidadProductos As Integer
    Public Vacio As Boolean



    'Metodos o acciones
    Public Sub Cobro(codProducto As Integer)
        Console.WriteLine("Se cobra Q" & codProducto * 2)
        Capacidad = Capacidad - 1
        'Capacidad -= 1
    End Sub

    Public Sub GenerarFactura(NIT As String)
        Console.WriteLine("Generando factura para nit: " & NIT)
    End Sub

    Public Sub DespacharProducto(codProducto As Integer)
        Console.WriteLine("Entregando producto con codigo " & codProducto)
    End Sub

    Public Sub ConsultaVacio()
        Console.WriteLine("Se cuenta con " & Capacidad & " productos")
    End Sub

End Class
