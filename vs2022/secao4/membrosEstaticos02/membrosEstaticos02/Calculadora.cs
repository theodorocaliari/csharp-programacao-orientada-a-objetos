using System;

namespace membrosEstaticos02
{
  internal class Calculadora
  {
  //acrescentando static permite que eu utilize a classe sem precisar estanciar o objeto
    public static double Pi = 3.14;

    public static double Circunferencia(double r){
      return 2.0 * Pi * r;
    }
    public static double Volume(double r){
      return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
    }

  }
}
