using System;

public class Program1
{
  public static void Main()
  {
    string notasS = "";
    int totalNota = 0;
    int mediaNota = 0;
    int[] nota = new int[4];

    Console.WriteLine("Informe 5 notas:");

    for (int i = 0; i < nota.Length; i++)
    {
      Console.Clear();

      Console.WriteLine("[{0}]", notasS);

      Console.Write("Digite a {0}ª nota: ", i + 1);
      nota[i] = int.Parse(Console.ReadLine());

      notasS += " " + nota[i];
      totalNota += nota[i];

    }
    Console.Clear();

    Console.WriteLine("Notas [ {0},{1},{2},{3} ]", nota[0], nota[1], nota[2], nota[3]);
    mediaNota = (totalNota / 4);

    Console.WriteLine("Total de notas: {0}", totalNota);
    Console.WriteLine("Total de notas: {0}", mediaNota);

  }
}