using System.Globalization;

namespace exercicioAdicional02
{
  internal class CaixaEletronico
  {
    private double valorSaque = 0; 
    private double resto = 0;
    private double divisao = 0;
    private int[] notas = { 2, 5, 10, 20, 50, 100 };

    public double ValorSaque
    {
      get { return valorSaque; }
      private set { valorSaque = value; }
    }

    public void ContaNotas(double valor)
    {

      for (int i = notas.Length - 1; i >= 0; i--)
      {
        if (valor > notas[i])
        {
          if (i == notas.Length - 1)
          {
            resto = valor % notas[i];
            divisao = (int) valor / notas[i];
            Console.WriteLine($"nota:{notas[i]} resto:{resto}, divisao:{divisao}");
            Console.WriteLine($"resto:{resto}, divisao:{divisao}");
          }
          else{
            divisao = resto / notas[i];
            resto = resto % notas[i];
            Console.WriteLine($"nota:{notas[i]} resto:{resto}, divisao:{divisao}");
            Console.WriteLine($"resto:{resto}, divisao:{divisao}");
          }

          
        }
      }


    }

  }
}
