Module Module1

    Sub Main()

        'Integer, String, Boolean, Date, Double, Decimal, Maquina, Persona

        Dim objPersona As New Persona()
        Dim objSupervisor As New Persona()

        'Se llenan las propiedadades
        objPersona.Nombre = "Esteban"
        objPersona.Edad = 20
        objPersona.Altura = 1.7

        'se mandas a ejecutar las acciones
        objPersona.Caminar()
        objPersona.Comer()
        objPersona.Hablar()
        objPersona.ConsultaTelefono()

        Console.WriteLine()

        '--------------------------------
        objSupervisor.Nombre = "Jorge"
        objSupervisor.Edad = 30
        objSupervisor.Altura = 1.65
        objSupervisor.Caminar()
        objSupervisor.Comer()
        objSupervisor.Hablar()
        objSupervisor.ConsultaTelefono()

        Console.WriteLine()

        Dim objMaquina As New Maquina()
        objMaquina.Marca = "Oijs"
        objMaquina.Moneda = "Q"
        objMaquina.Capacidad = 100
        objMaquina.Vacio = False
        objMaquina.ConsultaVacio()
        objMaquina.Cobro(6)
        objMaquina.ConsultaVacio()


        Console.ReadLine()
    End Sub

End Module
