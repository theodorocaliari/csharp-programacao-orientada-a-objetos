﻿using problemaExemploComOO;
using System.Globalization;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triangulo X:");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triangulo Y:");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (x.A + x.B + x.C) / 2.0;
double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
p = (y.A + y.B + y.C) / 2.0;
double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));


Console.WriteLine("Area Triangulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Area Triangulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if(areaX > areaY)
{
    Console.WriteLine("Triangulo X tem a area maior");
}
else
{
    Console.WriteLine("Triangulo Y tem a area maior");
}

/*
3.00
4.00
5.00

7.50
4.50
4.02
*/
