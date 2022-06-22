using problemaExemplo2;
using System.Globalization;

Produto p = new Produto();

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Produto cadastrado:\n{p}");

Console.WriteLine("Qual operação deseja realizar?");
Console.WriteLine("1 - Adicionar ao Estoque;\n2 - Remover do Estoque;\n3 - Cadastrar Produto;\n4 - Listar Produtos Cadastrados;\n5 - Finalizar Programa");
int opcao = int.Parse(Console.ReadLine());

while (opcao < 0 && opcao > 5)
{
  Console.Write("Opção Inválida! Tente novamente.");
  Console.WriteLine("Qual operação deseja realizar?");
  Console.WriteLine("1 - Adicionar ao Estoque;\n2 - Remover do Estoque;\n3 - Cadastrar Produto;\n4 - Listar Produtos Cadastrados;\n5 - Finalizar Programa");
  opcao = int.Parse(Console.ReadLine());
}

while (opcao < 5)
{
  switch (opcao)
  {
    case 1:
      Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
      int adicionar = int.Parse(Console.ReadLine());
      p.AdicionarProduto(adicionar);
      Console.WriteLine($"Dados atualizados:\n{p}");

      break;
    case 2:
      Console.WriteLine("Digite o número de produtos a ser remover ao estoque:");
      int remover = int.Parse(Console.ReadLine());
      p.RemoverProduto(remover);
      Console.WriteLine($"Dados atualizados:\n{p}");

      break;
    case 3:
      p.CadastrarProduto();
      break;
    case 4:
      p.ListaProduto();
      break;
    case 5:
    default:
      break;
  }

  Console.WriteLine("Qual operação deseja realizar?");
  Console.WriteLine("1 - Adicionar ao Estoque;\n2 - Remover do Estoque;\n3 - Cadastrar Produto;\n4 - Listar Produtos Cadastrados;\n5 - Finalizar Programa");
  opcao = int.Parse(Console.ReadLine());

}

Console.WriteLine("Programa finalizado com sucesso!");