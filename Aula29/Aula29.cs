using System;
public class Jogador
{
  public int energia;
  public bool vivo;
  public int vida;
  public string nome;
  public Jogador(string n) //Construtor
  {
    energia = 100;
    vivo = true;
    vida = 100;
    nome = n;
  }
  ~Jogador() //Destrutor
  {
    Console.WriteLine("O jogador {0} foi removido.", nome);
  }
}
class Aula29
{
  static void Main()
  {
    Console.Write("Digite o seu nome: ");
    string nome = Console.ReadLine();
    Jogador j1 = new Jogador(nome);
    Jogador j2 = new Jogador("Matheus");
    Jogador j3 = new Jogador("Rodrigo");

    j1.energia = 85;

    Console.WriteLine("O jogador 1° - {0}: {1}MP / {2}HP / vivo = {3}", j1.nome, j1.energia, j1.vida, j1.vivo);
    Console.WriteLine("O jogador 2° - {0}: {1}MP", j2.nome, j2.energia);
    Console.WriteLine("O jogador 3° - {0}:", j3.nome);
  }
}

// SEGUE O MESMO EXEMPLO POREM ADICIONANDO A CLASSE DESTRUTOR.