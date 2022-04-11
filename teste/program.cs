using System;

public class Program
{
  public static void Main()
  {

    string resultado;
    int[] nota = new int[5];
    Console.WriteLine("Informe quatro notas? ");
    for (int i = 1; i < nota.Length; i++)
    {

      Console.Write("Digite a {0}ª nota: ", i);
      nota[i] = int.Parse(Console.ReadLine());
      Console.Clear();
      //Console.Write("Suas {0}ª Nota foi {1} ", i, nota[i]);

    }
    if (nota > 5)
    {
      resultado = "Aprovado";
    }
    else
    {
      resultado = "Reprovado";
    }
    Console.WriteLine(resultado);
  }

}
