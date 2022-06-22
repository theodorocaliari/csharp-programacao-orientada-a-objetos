using System.Globalization;


namespace problemaExemplo2
{
  internal class Produto
  {

    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque()
    {
      return Preco * Quantidade;
    }

    public void AdicionarProduto(int quantity)
    {
      Quantidade += quantity;
    }

    public void RemoverProduto(int quantity)
    {
      Quantidade -= quantity;
    }

    public void CadastrarProduto()
    {
      Console.WriteLine("Metodo Cadastrar");

    }

    public void ListaProduto()
    {
      Console.WriteLine("Metodo Listar");
    }

    //sobreposicao de ToString
    //configuramos como seria a exibição em string
    public override string ToString()
    {
      return $"Nome: {Nome}\n" +
             $"Preço: ${Preco.ToString("F2", CultureInfo.InvariantCulture)}\n" +
             $"Quantidade: {Quantidade} unidades\n" +
             $"Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
    }

  }
}
