using System;
class Aula20
{
  public static void Main()
  {

    // repetidor WHILE
    int[] num = new int[10];

    int i = 0;
    while (i < num.Length)
    {
      num[i] = 0;
      Console.WriteLine(num[i]);
      Console.WriteLine("CFB Cursos");
      i++;
    }
    Console.WriteLine("Fim do Programa");
  }
}

// SINTAXE
// repetidor while, a variavel tem que ser declarada fora dele.

//int[] nome_do_array = new int[10];
//int nome_da_variavel = 0;
//while (nome_da_variavel < nome_do_array)
//{
//  nome_do_array[nome_da_variavel] = 0;
//  Console.WriteLine(nome_do_array[nome_da_variavel]);
//  nome_da_variavel++;
//}