using System;

public static class Jogador
{
    public static int energia;

    public static bool vivo;

    public static int vida;

    public static string nome;

    public static void iniciar(string n) //Construtor
    {
        energia = 100;
        vivo = true;
        vida = 100;
        nome = n;
    }

    public static void info()
    {
        Console.WriteLine("Nome Jogador...: {0}", nome);
        Console.WriteLine("Energia Jogador: {0}", energia);
        Console.WriteLine("Vida Jogador...: {0}", vida);
        Console.WriteLine("Estado Jogador.: {0}\n", vivo);
    }
}

public class Inimigo
{
    public static bool alerta;

    public string nome;

    public Inimigo(string n)
    {
        alerta = false;
        nome = n;
    }

    public void info()
    {
        Console.WriteLine (nome);
        Console.WriteLine (alerta);
        Console.WriteLine("----------------------");
    }
}

class Aula31
{
    static void Main()
    {
        Jogador.iniciar("Bruno");
        Jogador.info();

        Inimigo.alerta = true;

        Inimigo i1 = new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Louco");
        Inimigo i3 = new Inimigo("Pirado");

        i1.info();
        i2.info();
        i3.info();
    }
}

// Classe static nao pode ter objetos instanciada, no caso não pode ter construtores pois usa uma posição fixa na memoria
