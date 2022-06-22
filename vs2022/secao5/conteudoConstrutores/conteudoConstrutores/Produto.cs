﻿using System.Globalization;


namespace conteudoConstrutores
{
  internal class Produto
  {
    public string Nome;
    public double Preco;
    public int Quantidade;

    //CONSTRUTOR - "OBRIGA" O OBJETO SER INICIADO COM VALORES E NÃO COM INFORMAÇÕES "VAZIAS"
    public Produto(string nome, double preco, int quantidade){
      Nome = nome;
      Preco = preco;
      Quantidade = quantidade;
    }
    public double ValorTotalEmEstoque()
    {
      return Preco * Quantidade;
    }
    public void AdicionarProdutos(int quantidade)
    {
      Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade)
    {
      Quantidade -= quantidade;
    }
    public override string ToString()
    {
      return Nome
      + ", $ "
      + Preco.ToString("F2", CultureInfo.InvariantCulture)
      + ", "
      + Quantidade
      + " unidades, Total: $ "
      + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}
