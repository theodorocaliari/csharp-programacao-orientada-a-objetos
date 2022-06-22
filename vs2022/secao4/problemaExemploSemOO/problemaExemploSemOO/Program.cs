using System.Globalization;
float xA, xB, xC, yA, yB, yC;

Console.WriteLine("Entre com as medidas do triangulo X");
xA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xC = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triangulo Y");
yA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xA + xB + xC) / 2.0;
double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

p = (yA + yB + yC) / 2.0;
double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

Console.WriteLine("Area de x = {0}", areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Area de y = {0}", areaY.ToString("F4", CultureInfo.InvariantCulture));

if(areaX > areaY)
{
    Console.WriteLine("Maior Area: X");
}
else
{
    Console.WriteLine("Maior Area: Y");
}

