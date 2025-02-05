Module Module1

    Sub Main()
        'Pedir ingresar la edad
        Console.WriteLine("Ingresa tu edad:")

        'Definir el espacio para edad
        Dim edad As Integer

        'leer texto ingresado guardarlo en edad
        edad = Console.ReadLine()

        'comparar si es mayor o igual a 18
        If edad >= 18 Then
            'bloque de verdadero
            Console.WriteLine("Se entrega DPI")
        Else
            'bloque falso
            Console.WriteLine("Se entrega Fe edad")
        End If

        'acciones finales

        Console.ReadKey()
    End Sub

End Module
