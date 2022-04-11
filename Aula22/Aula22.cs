using System;
class Aula22
{
  public static void Main()
  {

    //foreach in (sempre para ler algo, e não para inicializar o elemento.)
    int[] num = new int[5] { 11, 22, 33, 44, 55 };

    foreach (int i in num)
    {
      Console.WriteLine(i);
    }

    for (int i = 0; i < num.Length; i++)
    {
      Console.WriteLine("{0}, {1}", num[i], i);
    }
  }
}

// SINTAXE
// FOREACH IN

// exemplo de leitura ARRAY

// foreach (int nome_da_variavel in nome_do_array)
//{
//  i;
//}