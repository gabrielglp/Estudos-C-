using System;
class Aula25
{
  static void Main()
  {
    int num = 10;
    dobrar1(ref num);
    Console.WriteLine(num);
  }

  static void dobrar(int valor)
  {
    valor *= 2;
  }

  static void dobrar1(ref int valor)
  {
    valor *= 3;
  }
}

// SINTAXE
// REF

// ele passa a referencia de valores para um outro scopo ou bloco, segue o exemplo a cima