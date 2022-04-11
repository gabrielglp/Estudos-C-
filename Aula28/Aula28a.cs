using System;

public class Jogador
{
  public int energia;
  public bool vivo;
  public int vida;
  public Jogador()
  {
    energia = 100;
    vivo = true;
    vida = 100;
  }
  public Jogador(int e)
  {
    energia = e;
    vivo = true;
    vida = 100;
  }
  public Jogador(int e, bool v)
  {
    energia = e;
    vivo = v;
    vida = 100;
  }
  public Jogador(int e, bool v, int vd)
  {
    energia = e;
    vivo = v;
    vida = vd;
  }
  public void info()
  {
    Console.WriteLine("Energia Jogador: {0}", energia);
    Console.WriteLine("Vida Jogador...: {0}", vivo);
    Console.WriteLine("Estado Jogador.: {0}\n", vida);
  }
}
class Aula28
{
  static void Main()
  {
    Jogador j1 = new Jogador();
    Jogador j2 = new Jogador(100);
    Jogador j3 = new Jogador(100, true, 90);

    j1.info();
    j2.info();
    j3.info();
  }
}