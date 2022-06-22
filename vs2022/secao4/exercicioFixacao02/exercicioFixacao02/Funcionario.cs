using System.Globalization;

namespace exercicioFixacao02
{
  internal class Funcionario
  {
    public string Nome;
    public double Salario;
    public double Imposto;

    public double SalarioLiquido()
    {
      return Salario - Imposto;
    }
    public void AumentaSalario(double porcentagem)
    {
      Salario = Salario + (Salario * porcentagem / 100.00);
    }

    public override string ToString()
    {
      return $"{Nome}, R$ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}"; 
    }
  }
}
