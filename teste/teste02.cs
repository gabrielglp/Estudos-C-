using System;
public class Jogador
{
  public int energia = 100;
  public string nome;
  public bool vida = true;
  public Jogador()
  {
    energia = 100;
    vida = true;
    nome = "Jogador";
  }
  public Jogador(string n)
  {
    energia = 100;
    vida = true;
    nome = n;
  }
  public Jogador(string n, int e)
  {
    energia = e;
    vida = true;
    nome = n;
  }
  public Jogador(string n, int e, bool v)
  {
    energia = e;
    vida = v;
    nome = n;
  }
  public void info()
  {
    Console.WriteLine("Nome do Jogador...: {0}", nome);
    Console.WriteLine("Energia do Jogador: {0}", energia);
    Console.WriteLine("Status do Jogador.: {0}\n", vida);
  }
}
class Teste02
{
  static void Main()
  {
    Jogador j1 = new Jogador();
    Jogador j2 = new Jogador("Gabriel", 92, true);
    Jogador j3 = new Jogador("Glauber", 100, true);
    Jogador j4 = new Jogador("Sadraque", 0, false);

    j1.info();
    j2.info();
    j3.info();
    j4.info();
  }
}