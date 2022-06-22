Console.WriteLine("Digite 3 numeros:");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

int resultado = Maior(n1, n2, n3);

Console.WriteLine("Maior = " + resultado);


//funcao
static int Maior(int a, int b, int c) {
    int m;
    if(a > b && a > c)
    {
        m = a;
    }else if (b > c) 
    {
        m = b;
    }
    else
    {
        m = c;
    }
    return m;
}
