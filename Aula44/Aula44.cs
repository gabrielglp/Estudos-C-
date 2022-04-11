using System;

struct Carro
{
    public string marca;

    public string modelo;

    public string cor;

    public Carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info()
    {
        Console.WriteLine("Marca do Carro.: {0}", marca);
        Console.WriteLine("Modelo do Carro: {0}", modelo);
        Console.WriteLine("Cor do carro...: {0}", cor);
    }
}

class Aula44
{
    static void Main()
    {
        Carro carro = new Carro("Honda", "HRV", "Preto");

        carro.info();

        /*carro.marca = "VW";
        carro.modelo = "Golf";
        carro.cor = "Branco";*/
    }
}

// struct
//
// struct nao é class por mais que a ideia seja parecida.
