using System.Globalization;
using exercicioFixacaoMembrosEstaticos;

Console.Write("Qual é a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade de dólares que você vai comprar? ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double resultado = ConversorDeMoeda.Cotacao(cotacao, quantia);
Console.WriteLine($"Valor a ser pago em reais = {resultado.ToString("F2",CultureInfo.InvariantCulture)}");
