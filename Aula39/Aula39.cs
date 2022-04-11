using System;

abstract class Veiculo
{
    protected int velMaxima;

    protected int velAtual;

    protected bool ligado;

    public Veiculo()
    {
        ligado = false;
        velAtual = 0;
    }

    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }

    public int getVelAtual()
    {
        return velAtual;
    }

    public abstract void aceleracao(int mult);
}

class Carro : Veiculo
{
    public Carro()
    {
        velMaxima = 120;
    }

    public override void aceleracao(int mult)
    {
        velAtual += 10 * mult;
    }
}

class Aula39
{
    static void Main()
    {
        Carro carro1 = new Carro();
        carro1.aceleracao(3);
        carro1.aceleracao(-3);

        Console.WriteLine(carro1.getVelAtual());
    }
}

//abstract = roteiro de classe (ou um molde) - modo de entender.
