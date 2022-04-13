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
}

class Aula47
{
    static void Main()
    {
        Calc calc = new Calc();
        var res = calc.soma(10.2, 5.5);
        Console.WriteLine (res);
    }
}

// SOBRE CARGA DE METODOS
