using System;

class Veiculo // classe base - Pai
{
  private int rodas;
  public int velMax;
  private bool ligado;
  public Veiculo(int rodas)
  {
    this.rodas = rodas;
    AbastercerCombustivel();
  }
  private void AbastercerCombustivel()
  {

  }
  public void Ligar()
  {
    ligado = true;
  }
  public void Desligar()
  {
    ligado = false;
  }
  public string getLigado()
  {
    return (ligado ? "Sim" : "Não");
    /* if (ligado)
     {
       return "Sim";
     }
     else
     {
       return "Não";
     }*/
  }
  public int getRodas()
  {
    return rodas;
  }
}

class Carro : Veiculo // classe derivada - Filha
{
  public string nome;
  public string cor;
  public Carro(string nome, string cor) : base(4)
  {
    Ligar();
    velMax = 120;
    this.nome = nome;
    this.cor = cor;
  }

  public void info()
  {

    Console.WriteLine("Cor..............: {0}", cor);
    Console.WriteLine("Nome.............: {0}", nome);
    Console.WriteLine("Rodas............: {0}", getRodas());
    Console.WriteLine("Velocidade Maxima: {0}", velMax);
    Console.WriteLine("Ligado...........: {0}", getLigado());
    Console.WriteLine();
  }
}
class Aula35
{
  static void Main()
  {
    Carro c1 = new Carro("BMW", "Vermelho");

    c1.Desligar();

    c1.info();

  }
}


// construtor de herança, classe base.

// operador ternario