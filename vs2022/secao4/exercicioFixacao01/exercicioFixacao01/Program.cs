using exercicioFixacao01;
using System.Globalization;

Retangulo r1 = new Retangulo();

Console.WriteLine("Etre a largura e altura do retângulo:");
r1.Largura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r1.Altura = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Area = " + r1.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Perimetro = " + r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Diagonal = " + r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
