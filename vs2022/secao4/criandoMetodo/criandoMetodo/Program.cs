using criandoMetodo;
using System.Globalization;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triangulo X:");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triangulo Y:");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();
double areaY = y.Area();

bool trianguloX = x.ChecaExistencia();
bool trianguloY = y.ChecaExistencia();

string tipoX = x.Tipo();
string tipoY = y.Tipo();

if (trianguloX && trianguloY)
{
  Console.WriteLine("Area Triangulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
  Console.WriteLine("Area Triangulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
  if (areaX > areaY)
  {
    Console.WriteLine("Triangulo X tem a area maior");
    Console.WriteLine($"Tipo do Triangulo X é: {tipoX}");
  }
  else
  {
    Console.WriteLine("Triangulo Y tem a area maior");
    Console.WriteLine($"Tipo do Triangulo Y é: {tipoY}");
  }
}else{
  if(trianguloX == false){
    Console.WriteLine("Não existe triangulo para os valores de X");
  }else if(trianguloY == false){ 
    Console.WriteLine("Não existe triangulo para os valores de Y");
  }
}

