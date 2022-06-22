
namespace exercicioFixacao01
{
  internal class Retangulo
  {
    public float Largura;
    public float Altura;

    public float Area(){
      return Largura * Altura;
    }
    public float Perimetro(){
      return 2 * (Largura +  Altura);
    }
    public double Diagonal(){
      return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
    }
  }
}
