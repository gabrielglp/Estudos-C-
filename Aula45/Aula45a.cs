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
        Console.Clear();

        for (int i = 0; i < carros.Length; i++)
        {
            //Console.WriteLine("[{0}]", carros);
            Console.Write("Digite a sua nota {0}: ");
            carros[i] = Console.ReadLine();
            //carros += " " + carros[i];
        }
        //carros[i].info();
    }
}
