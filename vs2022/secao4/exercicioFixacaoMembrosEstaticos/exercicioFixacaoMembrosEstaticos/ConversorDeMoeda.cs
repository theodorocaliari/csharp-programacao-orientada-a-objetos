using System;


namespace exercicioFixacaoMembrosEstaticos
{
  internal class ConversorDeMoeda
  {
    
    public static double Iof = 0.06; // 6% = 6/100
    public static double Cotacao(double precoDolar, double quantidadeDolar)
    {
      
      double total = (quantidadeDolar * precoDolar);
      double taxa = total * Iof;
      return total + taxa;
    }
  }
}
