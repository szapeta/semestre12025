Module Module1

    Sub Main()
        'Clase #5 25 feb 2025

        'Definicion de una variable tipo String
        Dim numTelefono As String

        Console.WriteLine("Escribe tu numero de telefono: ")
        numTelefono = Console.ReadLine()

        '+ utilizado con tipos de datos iguales
        '& utilizado con tipos de datos diferentes
        Console.WriteLine("Valor ingresado:" & numTelefono)

        '------------------------------------------
        'Limpieza de espacios en blanco
        Dim textoLimpio As String

        textoLimpio = numTelefono.Trim()
        '-------------------------------------------

        '------------------------------------------------
        '123456-7 -> debe devolver 7 caracteres y no 8
        Dim txtLimpiov2 As String
        txtLimpiov2 = textoLimpio.Replace("-", "")
        Console.WriteLine("Texto despues del replace: " & txtLimpiov2)

        '--------------------------------------------------

        'numTelefono = 12345 -> Length = 5
        If txtLimpiov2.Length = 8 And IsNumeric(txtLimpiov2) Then
            'bloque cuando la condicion es verdadera
            Console.WriteLine("Numero de telefono valido")
        Else
            'bloque cuando la condicion es false
            Console.WriteLine("Numero de telefono no es valido")
            Console.WriteLine("El telefono ingresado tiene " & txtLimpiov2.Length & " digitos")
        End If

        Console.WriteLine()

        Dim correo As String
        Console.WriteLine("Escriba su correo:")
        correo = Console.ReadLine()

        Console.WriteLine("uds ingreso el correo: " & correo.ToLower)

        If correo.Contains("@") Then
            'bloque verdadero
            Console.WriteLine("correo valido")
        Else
            'bloque falso
            Console.WriteLine("correo no valido")
        End If




        Console.ReadKey()
    End Sub

End Module
