using System;
class teste1
{
  public static void Main()
  {
    int Aprovado = 0;
    string notas = " ";
    int totalNotas = 0;
    int mediaNotas = 0;
    int i;
    int[] nota = new int[4];

  inicio:

    Console.Clear();

    for (i = 0; i < nota.Length; i++)
    {
      Console.Clear();
      Console.WriteLine("[{0}]", notas);

      Console.Write("Digite a sua nota {0}°: ", i + 1);
      nota[i] = int.Parse(Console.ReadLine());

      notas += " " + nota[i];
      totalNotas += nota[i];
    }

    Console.Clear();
    mediaNotas = totalNotas / 4;

    Console.WriteLine("Notas: [{0},{1},{2},{3}]", nota[0], nota[1], nota[2], nota[3]);
    Console.WriteLine("Total das Notas: {0}", totalNotas);
    Console.WriteLine("Sua Media: {0}", mediaNotas);

    Console.Write("Deseja começar novamente? [s/n]: ");
    i = int.Parse(Console.ReadLine());

    if (nota[i] > 10)
    {
      resultado = "Aprovado";
    }
    if (nota[i] < 5)
    {
      resultado = "Reprovado";
    }

    if (i == 's' || i == 'S')
    {
      goto inicio;
    }
    if (i == 'n' || i == 'N')
    {
      Console.Clear();
      Console.WriteLine("Fim do programa");
    }
  }
}