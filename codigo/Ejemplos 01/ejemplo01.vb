imports System

Module Prueba01

    Sub Main()
        Dim valor = true
        dim s = if(valor,  "Es True" , "Es False")  'var s = valor ? "Es True" : "Es False";
        Console.WriteLine(s)
    End Sub
end Module
