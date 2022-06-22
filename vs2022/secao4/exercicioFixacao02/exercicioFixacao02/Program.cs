using exercicioFixacao02;
using System.Globalization;

Funcionario f1 = new Funcionario();

Console.Write("Nome: ");
f1.Nome = Console.ReadLine();
Console.Write("Salário Bruto: ");
f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Funcionario: {f1.ToString()}");

Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
double p = double.Parse(Console.ReadLine());
f1.AumentaSalario(p);

Console.WriteLine(f1.ToString());