using conteudoEncapsulamento;
using System.Globalization;

Produto p = new Produto("TV", 500.00, 10);

p.SetNome("TV 4K");

Console.WriteLine(p.GetNome());
