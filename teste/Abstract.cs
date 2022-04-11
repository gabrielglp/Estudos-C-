using System;

abstract class Veiculo
{
    protected bool

            ligado,
            parado;

    protected int

            velMax,
            velAtual;

    public Veiculo()
    {
        ligado = true;
        parado = false;
        velMax = 130;
        velAtual = 32;
    }

    public void setVelAtual(int num)
    {
        if (ligado && num <= velMax)
        {
            velAtual = num;

            if (velAtual <= num)
            {
                parado = false;
            }
        }
    }

    public void Ligar()
    {
        ligado = true;
    }

    public void Deligar()
    {
        ligado = false;
    }

    public string getLigado()
    {
        return (ligado ? "Sim" : "Não");
    }

    public void Stop()
    {
        parado = true;
    }

    public void Moviment()
    {
        parado = false;
    }

    public string getParado()
    {
        return (parado ? "Sim" : "Não");
    }

    public int getVelAtual()
    {
        return velAtual;
    }

    /*public void SetVelMax(int num)
    {
        velMax = num;
    }*/
    public int getVelMax
    {
        get
        {
            return velMax;
        }
    }

    public void info()
    {
        Console.WriteLine("O Veiculo está ligado?: {0}", getLigado());
        Console.WriteLine("O Veiculo está parado?: {0}", getParado());
        Console.WriteLine("Velocidade Atual......: {0}", velAtual);
        Console.WriteLine("Velocidade Maxima.....: {0}", getVelMax);
    }
}

class Carro : Veiculo
{
    public Carro()
    {
        info();
    }
}

class Abstract
{
    static void Main()
    {
        Carro carro = new Carro();
    }
}
