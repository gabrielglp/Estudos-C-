using System;
public class Jogador
{
  public int energia;
  public bool vivo;
  public int vida;
  public string nome;
  public Jogador() //Construtor
  {
    energia = 100;
    vivo = true;
    vida = 100;
    nome = "Jogador";
  }
  public Jogador(string n) //Construtor
  {
    energia = 100;
    vivo = true;
    vida = 100;
    nome = n;
  }
  public Jogador(string n, int e) //Construtor
  {
    energia = e;
    vivo = true;
    vida = 100;
    nome = n;
  }
  public Jogador(string n, int e, bool v) //Construtor
  {
    energia = e;
    vivo = v;
    vida = 100;
    nome = n;
  }
  public Jogador(string n, int e, bool v, int vi) //Construtor
  {
    energia = e;
    vivo = v;
    vida = vi;
    nome = n;
  }
  public void info()
  {
    Console.WriteLine("Nome Jogador...: {0}", nome);
    Console.WriteLine("Energia Jogador: {0}", energia);
    Console.WriteLine("Vida Jogador...: {0}", vida);
    Console.WriteLine("Estado Jogador.: {0}\n", vivo);
  }
}
class Aula30
{
  static void Main()
  {
    Jogador j1 = new Jogador();
    Jogador j2 = new Jogador("Matheus");
    Jogador j3 = new Jogador("Rodrigo", 85);
    Jogador j4 = new Jogador("Mario", 100, true);
    Jogador j5 = new Jogador("Lucas", 0, false, 0);

    j1.info();
    j2.info();
    j3.info();
    j4.info();
    j5.info();
  }
}
