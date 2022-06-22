using System.Globalization;

namespace exercicioFixacao01
{
  internal class ContaBancaria
  {
    public int NumeroConta { get; private set; }
    public string TitularConta { get; set; }
    public double Saldo { get; private set; }


    //o this() reaproveita o construtor padrao e adiciona saldo ao construtor de 2 argumentos
    public ContaBancaria(int numeroConta, string titularConta)
    {
      NumeroConta = numeroConta;
      TitularConta = titularConta;
    }

    public ContaBancaria(int numeroConta, string titularConta, double depositoInicial) : this(numeroConta, titularConta)
    {
      Deposito(depositoInicial);
    }

    public void Deposito(double valor)
    {
      Saldo += valor;
    }

    public void Saque(double valor)
    {
      double taxa = 5.00;
      Saldo = Saldo - valor - taxa;
    }

    public override string ToString()
    {
      return $"Conta: {NumeroConta}, Titular: {TitularConta}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }

  }


}
