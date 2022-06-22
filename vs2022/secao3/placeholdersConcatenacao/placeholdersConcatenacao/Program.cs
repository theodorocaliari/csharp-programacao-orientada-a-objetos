using System.Globalization;

int idade = 32;
string nome = "Maria";
double saldo = 10.23593;

Console.WriteLine("{0} tem {1} anos e saldo igual a {2} reais", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("{0} tem {1} anos e saldo igual a {2:F2} reais", nome, idade, saldo);