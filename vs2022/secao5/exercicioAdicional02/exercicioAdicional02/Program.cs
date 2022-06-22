//https://github.com/diogoschimm/Desafio-Exercicio-Caixa-Eletronico

using System.Globalization;
using exercicioAdicional02;

Console.Write("Entre o valor para saque: ");
double valor = double.Parse(Console.ReadLine());

CaixaEletronico c1 = new CaixaEletronico();

c1.ContaNotas(valor);
