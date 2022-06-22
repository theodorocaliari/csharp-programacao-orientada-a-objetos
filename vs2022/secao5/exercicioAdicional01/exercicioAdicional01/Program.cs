//exercicio retirado do site - https://dfilitto.com.br/desenvolvimento/c-sharp/lista-de-exercicios-de-programacao-orientada-a-objetos-em-c-1-parte/

using exercicioAdicional01;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();
Pessoa p3 = new Pessoa();

for (int i = 1; i <= 3; i++)
{
  Console.Write("Nome: ");
  string nome = Console.ReadLine();
  Console.Write("Idade: ");
  int idade = int.Parse(Console.ReadLine());

  if (i == 1)
  {
    p1 = new Pessoa(nome, idade);
  }
  else if (i == 2)
  {
    p2 = new Pessoa(nome, idade);
  }
  else
  {
    p3 = new Pessoa(nome, idade);
  }
}


if (p1.Idade > p2.Idade && p1.Idade > p3.Idade)
{
  Console.WriteLine(p1.ExibeDados());
}
else if (p2.Idade > p3.Idade)
{
  Console.WriteLine(p2.ExibeDados());
}
else
{
  Console.WriteLine(p3.ExibeDados());
}
