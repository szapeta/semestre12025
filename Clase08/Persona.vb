Public Class Persona

    'Propiedades o caracteristicas
    Public Nombre As String
    Public Edad As Integer
    Public Altura As Double
    Public Peso As Double
    Private Tel As String

    'Acciones o metodos
    Public Sub Caminar()
        Console.WriteLine(Nombre & " esta caminando")
    End Sub

    Public Sub Hablar()
        Console.WriteLine(Nombre & " esta hablando")
    End Sub

    Public Sub Comer()
        Console.WriteLine(Nombre & " esta comiendo")
    End Sub

    Private Sub generacionTelefono()
        Tel = "55669878"
    End Sub


    Public Sub ConsultaTelefono()
        generacionTelefono()
        Console.WriteLine("Telefono asignado: " & Tel)
    End Sub


End Class
