using System;

class Veiculo // classe base - Pai
{
  public int rodas;
  public int velMax;
  private bool ligado;

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
    if (ligado)
    {
      return "Sim";
    }
    else
    {
      return "Não";
    }
  }
}

class Carro : Veiculo // classe derivada - Filha
{
  public string nome;
  public string cor;
  public Carro(string nome, string cor)
  {
    Ligar();
    rodas = 4;
    velMax = 120;
    this.nome = nome;
    this.cor = cor;
  }
}
class Aula34
{
  static void Main()
  {
    Carro c1 = new Carro("BMW", "Vermelho");

    Console.WriteLine("Cor..............: {0}", c1.cor);
    Console.WriteLine("Nome.............: {0}", c1.nome);
    Console.WriteLine("Rodas............: {0}", c1.rodas);
    Console.WriteLine("Velocidade Maxima: {0}", c1.velMax);
    Console.WriteLine("Ligado...........: {0}", c1.getLigado());
  }
}