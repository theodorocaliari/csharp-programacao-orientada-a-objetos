using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAdicional01
{
  internal class Pessoa
  {

    private int idade = 0;

    public string Nome { get; set; }
    public int Idade
    {
      get { return idade; }
      set
      {
        if (value > 0)
        {
          idade = value;
        }
        else{
          idade = 0;
        }
      }
    }

    public Pessoa() { }
    public Pessoa(string nome, int idade)
    {
      Nome = nome;
      Idade = idade;
    }

    public string ExibeDados()
    {
      return $"Nome:{Nome}, Idade:{Idade}";
    }

  }
}
