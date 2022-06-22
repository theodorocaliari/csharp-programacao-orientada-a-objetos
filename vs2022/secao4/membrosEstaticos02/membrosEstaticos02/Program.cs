using membrosEstaticos02;
using System.Globalization;

Console.Write("Entre o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circ = Calculadora.Circunferencia(raio);
double vol = Calculadora.Volume(raio);
double pi = Calculadora.Pi;

Console.WriteLine($"Circunferencia: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Valor de Pi: {pi.ToString("F2", CultureInfo.InvariantCulture)}");