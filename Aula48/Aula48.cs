using System;

class Calc
{
    public int soma(params int[] n)
    {
        int somador = 0;
        for (int i = 0; i < n.Length; i++)
        {
            somador += n[i];
        }
        return somador;
    }

    public double soma(params double[] n)
    {
        double somador = 0;
        for (int i = 0; i < n.Length; i++)
        {
            somador += n[i];
        }
        return somador;
    }

    public int fat(int n)
    {
        int res;
        if (n <= 1)
        {
            res = 1;
        }
        else
        {
            res = n * fat(n - 1);
        }
        return res;
    }
}

class Aula48
{
    static void Main()
    {
        Calc calc = new Calc();
        var res = calc.fat(5);
        Console.WriteLine (res);
    }
}

// RECURSIVIDADE.
// É UMA FUNÇÃO CHAMANDO ELA MESMO.
