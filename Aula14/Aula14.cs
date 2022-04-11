using System;
class Aula14
{
  static void Main()
  {
    int n1, n2, n3, n4, res;
    res = n1 = n2 = n3 = n4 = 0;
    string resultado;

    Console.Write("Digite sua primeira nota: ", n1);
    n1 = int.Parse(Console.ReadLine());

    Console.Write("Digite sua segunda nota: ", n2);
    n2 = int.Parse(Console.ReadLine());

    Console.Write("Digite sua terceira nota: ", n3);
    n3 = int.Parse(Console.ReadLine());

    Console.Write("Digite sua quarta nota: ", n4);
    n4 = int.Parse(Console.ReadLine());

    res = n1 + n2 + n3 + n4;

    if (res >= 60)
    {
      if (res >= 90)
      {
        if (res >= 99)
        {
          resultado = "Aprovado com super louvor";
        }
        else
        {
          resultado = "Aprovado com louvor";
        }
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

    Console.WriteLine("Sua nota é: {0} - {1}", res, resultado);
  }
}

// SINTAXE

// if dentro de if

/* if ()
    {
      if ()
      {
        if ()
        {
          resultado = "Apro";
        }
        else
        {
          resultado = "Apro";
        }
      }
      else
      {
        resultado = "Aprovado";
      }
    }
    else
    {
      if ()
      {
        resultado = "Recuperação";
      }
      else
      {
        resultado = "Reprovado";
      }
    }
*/