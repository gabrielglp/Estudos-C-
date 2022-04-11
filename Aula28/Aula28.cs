using System;

public class Jogador
{
    public int energia = 100;

    public bool vivo = true;

    public int vida = 100;
}

class Aula28
{
    static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 85;

        Console
            .WriteLine("A energia do jogador 1: {0}MP / {1}HP / vivo = {2}",
            j1.energia,
            j1.vida,
            j1.vivo);
        Console.WriteLine("A energia do jogador 2: {0}MP", j2.energia);
        Console.WriteLine("Jogador 3 esta vivo? {0}", j3.vivo);
    }
}

// POO / CONVERSANDO ENTRE CLASSES, POREM O QUE DEU A ENTENDER SÓ POSSO PEGAR ARGUMENTO SE A TAL CLASSE FOR ATRIBUIDO O VALOR PUBLIC

//public class Carro
//{
//  public int gasolina = 100;
//}
//class Teste
//{
//  static void Main()
// {
//    Carro c1 = new Carro();
//
//    c1.gasolina;
//    Console.WriteLine("Gasolina - {0}%", c1.gasolina);
//  }
//}
