//using System;

namespace criandoMetodo
{
  internal class Triangulo
  {
    public double A;
    public double B;
    public double C;

    public double Area()
    {
      double p = (A + B + C) / 2.0;
      return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); ;
    }

    public bool ChecaExistencia()
    {
      if (A + B > C && A + C > B && B + C > A)
      {
        return true;
      }
      return false;
    }

    public string Tipo()
    {
      if (A == B && A == C && B == C)
      {
        return "Equilátero";
      }
      else if (A == B || A == C || B == C)
      {
        return "Isósceles";
      }
      else
      {
        return "Escaleno";
      }
    }
  }
}
