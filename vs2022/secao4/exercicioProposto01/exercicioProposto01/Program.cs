﻿using exercicioProposto01;

Pessoa p1, p2;

p1 = new Pessoa();
p2 = new Pessoa();

Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome: ");
p1.Nome = Console.ReadLine();
Console.Write("Idade: ");
p1.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("Dados da segunda pessoa:");
Console.Write("Nome: ");
p2.Nome = Console.ReadLine();
Console.Write("Idade: ");
p2.Idade = int.Parse(Console.ReadLine());

if(p1.Idade > p2.Idade)
{
    Console.WriteLine("Pessoa com mais idade: " + p1.Nome);
}
else
{
    Console.WriteLine("Pessoa com mais idade: " + p2.Nome);

}