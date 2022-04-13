using System;

delegate int Op(int n1, int n2);

class Mat
{
    public static int Soma(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Multiplicação(int n1, int n2)
    {
        return n1 * n2;
    }
}

class Aula50
{
    static void Main()
    {
        int res;
        Op d1 = new Op(Mat.Soma);
        res = d1(10, 50);

        Console.WriteLine("Soma: {0}", res);

        d1 = new Op(Mat.Multiplicação);
        res = d1(10, 50);

        Console.WriteLine("Multiplicação: {0}", res);
    }
}
//dúvida: vc pode add vários métodos no delegate e chamar apena o delegate, é tipo cleancode...
