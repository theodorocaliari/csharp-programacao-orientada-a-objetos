﻿using System.Globalization;

namespace conteudoAutoProperties
{
  internal class Produto
  {
    private string _nome;

    //autoproperties
    public double Preco { get; private set; }
    public int Quantidade { get; private set; }

    public Produto() { }
    public Produto(string nome, double preco, int quantidade)
    {
      _nome = nome;
      Preco = preco;
      Quantidade = quantidade;
    }

    //properties
    public string Nome
    {
      get { return _nome; }
      set
      {
        if (value != null && value.Length > 0)
        {
          _nome = value;

        }
      }
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
      return _nome
      + ", $ "
      + Preco.ToString("F2", CultureInfo.InvariantCulture)
      + ", "
      + Quantidade
      + " unidades, Total: $ "
      + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}
