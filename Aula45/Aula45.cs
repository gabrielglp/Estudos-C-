using System;

struct Carro
{
    public string modelo;

    public string marca;

    public string cor;

    public void info()
    {
        Console.WriteLine("Modelo: {0}", modelo);
        Console.WriteLine("Marca.: {0}", marca);
        Console.WriteLine("Cor...: {0}", cor);
        Console.WriteLine("-----------------------------");
    }
}

class Aula45
{
    static void Main()
    {
        Carro[] carros = new Carro[5];

        carros[0].modelo = "GOLF";
        carros[0].marca = "VW";
        carros[0].cor = "PRETO";

        carros[1].modelo = "JETTA";
        carros[1].marca = "VW";
        carros[1].cor = "BRANCO";

        carros[2].modelo = "CULLINAN";
        carros[2].marca = "ROLLS ROYCE";
        carros[2].cor = "VERMELHO";

        carros[3].modelo = "GOLF";
        carros[3].marca = "VW";
        carros[3].cor = "PRETO";

        carros[4].modelo = "GOLF";
        carros[4].marca = "VW";
        carros[4].cor = "PRETO";

        for (int i = 0; i < carros.Length; i++)
        {
            carros[i].info();
        }
    }
}
