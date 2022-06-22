﻿using exercicioProposto02;
using System.Globalization;
Funcionario f1, f2;

f1 = new Funcionario();
f2 = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
f1.Nome = Console.ReadLine();
Console.Write("Salário: ");
f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
f2.Nome = Console.ReadLine();
Console.Write("Salário: ");
f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Salário médio = {((f1.Salario + f2.Salario) / 2).ToString("F2", CultureInfo.InvariantCulture)}");