using System.Globalization;

class Program
{
  //como estou usando o Pi em funcoes(metodos estatico ele deve ser estatito para ser aceito nos metodos)
  static double Pi = 3.14;
  static void Main(string[] args)
  {
    Console.Write("Entre o valor do raio: ");
    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine($"Circunferencia: {Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"Volume: {Volume(raio).ToString("F2", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"Valor de Pi: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");
  }

  //funcao auxiliar
  static double Circunferencia(double r)
  {
    return 2 * Pi * r;
  }

  //funcao auxiliar
  static double Volume(double r)
  {
    return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
  }

}
