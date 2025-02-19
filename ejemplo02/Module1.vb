Module Module1
    Dim objRamdom As New Random()

    '1er. metodo
    Sub Main()
        Dim val1 As Integer
        val1 = 9
        Dim valDOS As Integer = 2

        'quitar comillas para que funcione
        'sumar(val1, valDOS)
        'imprimirResultados()


        Console.WriteLine("Obtencion de valor par Aleatorio")
        Dim par1 As Integer = obtenerAleatorioPar()
        Console.WriteLine("1er. Par: " & par1)

        Dim par2 As Integer = obtenerAleatorioPar()
        Console.WriteLine("2do. Par: " & par2)

        Dim par3 As Integer = obtenerAleatorioPar()
        Console.WriteLine("3er. Par: " & par3)

        Console.ReadLine()
    End Sub

    '2do. metodo
    Sub sumar(num1 As Integer, num2 As Integer)
        Dim resultado As Integer
        Console.WriteLine("Metodo Sumar")
        resultado = num1 + num2
        Console.WriteLine("El resultado de la suma es: " + CStr(resultado))
        Console.WriteLine("El resultado de la suma es: " & resultado)
    End Sub

    '3er. metodo
    Sub imprimirResultados()
        Console.WriteLine("Metodo Imprimir Resultados")
        Console.WriteLine()
    End Sub

    Function obtenerAleatorioPar() As Integer
        Dim valorAleatorio = objRamdom.Next(1, 1000)

        While valorAleatorio Mod 2 <> 0
            valorAleatorio = objRamdom.Next(1, 1000)
        End While

        Return valorAleatorio
    End Function

End Module
