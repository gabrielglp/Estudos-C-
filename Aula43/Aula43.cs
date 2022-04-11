using System;

public interface Veiculo
{
    void ligar();

    void desligar();

    void info();
}

public interface Combate
{
    void disparar();
}

class Carro : Veiculo, Combate
{
    public bool ligado;

    private int municao;

    public Carro()
    {
        setMunicao(100);
    }

    public void setMunicao(int qtde)
    {
        this.municao = qtde;
    }

    public void ligar()
    {
        this.ligado = true;
    }

    public void desligar()
    {
        this.ligado = false;
    }

    public void disparar()
    {
    }

    public void info()
    {
    }
}

class Aula43
{
    static void Main()
    {
        Carro carro = new Carro();
    }
}

//herança em C# só é suportada uma herança por classe
// já a interface não existe limite, ou seja tu pode implementar diversas interfaces em uma só classe.

//interface serve apenas pra legibilidade de código?
