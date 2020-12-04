imports System

Module Prueba01

    Sub Main()
        Dim valor = true
        dim s = if(valor,  "Es True" , "Es False")  'var s = valor ? "Es True" : "Es False";
        Console.WriteLine(s)

        Console.WriteLine("Prueba2")
        Prueba2
    End Sub

    sub Prueba2()
        Dim valor = True

        Dim s = ""
        If valor Then
            s = "Es True"
        Else
            s = "Es False"
        End If
        Console.WriteLine(s)
    end sub
end Module
