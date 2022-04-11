using System;
class Aula16
{
  static void Main()
  {

    // goto, retorna o programa.

    int tempo = 0;
    char escolha;

  inicio:

    Console.Clear();

    Console.WriteLine("Belo Horizonte/MG e Vitória/ES");
    Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Onibus");
    Console.Write("Coloca a letra do tranporte: ");
    escolha = char.Parse(Console.ReadLine());

    switch (escolha)
    {
      case 'a':
      case 'A':
        tempo = 50;
        break;
      case 'c':
      case 'C':
        tempo = 480;
        break;
      case 'o':
      case 'O':
        tempo = 660;
        break;
      default:
        tempo = -1;
        break;
    }

    if (tempo < 0)
    {
      Console.WriteLine("Transporte indisponivel");
    }
    else
    {
      Console.WriteLine("{0} minutos", tempo);
    }
  
    Console.Write("Calcular outro transporte? [s/n]: ");
    escolha = char.Parse(Console.ReadLine());

    if (escolha == 's' || escolha == 'S')
    {
      goto inicio;
    }
    if (escolha == 'n' || escolha == 'N')
    {
      Console.Clear();
      Console.WriteLine("Fim do programa");
    }
    else
    {
      Console.Clear();
      Console.WriteLine("Fim do programa");
    }

  }
}