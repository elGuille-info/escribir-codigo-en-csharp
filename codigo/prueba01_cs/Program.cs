using System;

var valor = true;
var s = valor ? "Es True" : "Es False";
Console.WriteLine(s);

Console.WriteLine("Prueba2");
Prueba2();

Console.WriteLine("Prueba2");
Prueba3();

static void Prueba2()
{
    var valor = true;

    var s = "";
    if (valor)
        s = "Es True";
    else
        s = "Es False";

    Console.WriteLine(s);
}

static void Prueba3()
{
    var valor = true;

    var s = "";
    if (valor)
    {
        s = "Es True";
    }
    else
    {
        s = "Es False";
    }
}
