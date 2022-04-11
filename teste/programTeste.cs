using System;
class ProgramTeste
{
  public static void Main()
  {
    string novamente = "n";
    string tentar;
    int tentativas = 0;

    do
    {
      string notas = " ";
      int mediaNota = 0;
      int totalNotas = 0;
      string resultado;

      int[] nota = new int[4];
      int i;

      for (i = 0; i < nota.Length; i++)
      {
        Console.Clear();
        Console.WriteLine("[{0}]", notas);
        Console.Write("Digite sua {0}° nota: ", i + 1);
        nota[i] = int.Parse(Console.ReadLine());
        notas += " " + nota[i];
        totalNotas += nota[i];
      }

      Console.Clear();
      mediaNota = totalNotas / 4;

      if (mediaNota >= 6)
      {
        resultado = "Aprovado";
      }
      else if (mediaNota >= 4)
      {
        resultado = "Recuperação";
      }
      else
      {
        resultado = "Reprovado";
      }
      Console.WriteLine("Notas: [{0}, {1}, {2}, {3}]", nota[0], nota[1], nota[2], nota[3]);
      Console.WriteLine("Total da sua nota: {0}", totalNotas);
      Console.WriteLine("Sua media final é: {0} - {1}", mediaNota, resultado);

      Console.Write("Deseja tentar novamente? [s/n]: ");
      tentar = Console.ReadLine();
      tentativas++;
    } while (novamente != tentar);

    Console.Clear();
    Console.WriteLine("Foram feito {0} testes", tentativas);
    Console.WriteLine("Fim do Programa.");
  }
}