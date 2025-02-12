Module Module1

    Sub Main()
        'Imprimir limites conocidos
        For totalDiasSemana As Integer = 1 To 7
            '+ se usa con valores del mismo tipo
            '& se usa con valores de diferente tipo
            Console.WriteLine("Conteo = " + CStr(totalDiasSemana))

            'If totalDiasSemana = 5 Then
            '   Exit For
            'End If

        Next


        'Carga de un archivo
        Dim porcentaje As Integer = 0

        While porcentaje < 100

            Console.Write("|")
            porcentaje = porcentaje + 1

        End While
        Console.WriteLine()
        Console.WriteLine("Archivo subido con exito")


        Dim numeroAleatorio As New Random()
        Dim numeroAleatorioLeido As Integer
        numeroAleatorioLeido = numeroAleatorio.Next(1, 100)

        Console.WriteLine("El numero leido es: " & numeroAleatorioLeido)

        Console.ReadLine()
    End Sub

End Module
