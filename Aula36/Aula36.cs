using System;

class
Veiculo // base
{
    public int velAtual;

    private int velMax;

    protected bool ligado;

    public Veiculo(int velMax)
    {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public bool getLigado()
    {
        return ligado;
    }

    public int getVelMax()
    {
        return velMax;
    }
}

class Carro : Veiculo
{
    public string nome;

    public Carro(string nome, int velocidade_Max) :
        base(velocidade_Max)
    {
        this.nome = nome;
        ligado = true;
    }
}

class Aula36
{
    static void Main()
    {
        Carro carro = new Carro("Bonitão", 120);

        Console.WriteLine("Nome......: {0}", carro.nome);
        Console.WriteLine("Vel.Máxima: {0}", carro.getVelMax());
        Console.WriteLine("Ligado....: {0}", carro.getLigado());
    }
}

// diveferença do protected para o private, é que o private nao aceita ir para outras classes ja o protected aceita.
