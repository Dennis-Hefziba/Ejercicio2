Module Module1
    'Escriba un programa que determine si un número es positivo o negativo.
    Sub Main()


        Console.WriteLine("------------------------------------------------------------------------------")
        Console.WriteLine("Te ayudamos a determinar si el numero que ingresaste es negativo o positivo")


        Dim retorno As Boolean = True

        Do
            Console.WriteLine("")
            Console.WriteLine("Ingresa un numero")
            Dim numeroTxt As String = Console.ReadLine()
            Dim numero As Integer

            If Integer.TryParse(numeroTxt, numero) Then

                If numero < 0 Then
                    Console.WriteLine("El numero que ingresaste es negativo")
                    Console.WriteLine("------------------------------------------------------------------------------")
                ElseIf numero > 0 Then
                    Console.WriteLine("El numero ingresado es positivo")
                    Console.WriteLine("------------------------------------------------------------------------------")
                Else
                    Console.WriteLine("El numero ingresado es igual a cero")
                    Console.WriteLine("------------------------------------------------------------------------------")
                End If

            Else
                Console.WriteLine("No se admiten letras")
            End If

            Console.WriteLine("")
            Console.WriteLine("Si desea seguir comprobando numeros presione cualquier")
            Console.WriteLine("Si desea salir presione Q")
            Console.WriteLine("")
            Dim respuesta As ConsoleKeyInfo = Console.ReadKey()

            If respuesta.Key = ConsoleKey.Q Then
                Exit Do
            End If

        Loop While retorno = True


    End Sub

End Module
