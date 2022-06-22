using System.Globalization;
using exercicioFixacao01;

double saldo = 0;
Console.Write("Entre o número da conta: ");
int nConta = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n): ");
char perguntaSaldo = char.Parse(Console.ReadLine());

if (perguntaSaldo == 's' || perguntaSaldo == 'S')
{
  Console.Write("Entre o valor de depósito inicial: ");
  saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

ContaBancaria c1 = new ContaBancaria(nConta, titular, saldo);
Console.WriteLine("\nDados da Conta: ");
Console.WriteLine(c1.ToString());

Console.Write("\nEntre com um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
c1.Deposito(quantia);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(c1.ToString());

Console.Write("\nEntre com um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
c1.Saque(quantia);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(c1.ToString());