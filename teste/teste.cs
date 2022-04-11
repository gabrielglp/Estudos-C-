using System;
class teste
{
  static void Main()
  {
    int n1, n2, n3, n4, res;
    res = n1 = n2 = n3 = n4 = 0;
    string resultado;

    Console.Write("digite o 1: ", n1);
    n1 = int.Parse(Console.ReadLine());

    Console.Write("digite o 2: ", n2);
    n2 = int.Parse(Console.ReadLine());

    Console.Write("digite o 3: ", n3);
    n3 = int.Parse(Console.ReadLine());

    Console.Write("digite o 4: ", n4);
    n4 = int.Parse(Console.ReadLine());

    res = n1 + n2 + n3 + n4;

    if (res >= 60)
    {
      if (res >= 99)
      {
        resultado = "Aprovado com super louvor";
      }
      if (res >= 90)
      {
        resultado = "Aprovado com louvor";
      }
      else
      {
        resultado = "Aprovado";
      }
    }
    else
    {
      if (res >= 40)
      {
        resultado = "Recuperação";
      }
      else
      {
        resultado = "Reprovado";
      }
    }
    Console.WriteLine("A sua nota é: {0} - {1}", res, resultado);
  }
}