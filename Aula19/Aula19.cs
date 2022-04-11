using System;
class Aula19
{
  static void Main()
  {
    //inicio:

    int[] num = new int[15];

    int i;
    for (i = 0; i < num.Length; i++)
    {
      //num[i] = 0;
      Console.WriteLine("valor de num na pos{0}: {1}", i, num[i]);
    }

    /*for (i = 0; i < num.Length; i++)
    {
      Console.WriteLine("valor de num na pos{0}: {1}", i, num[i]);
    }*/
    /*int num;
    for (num = 0; num < 10; num++)
    {
      Console.WriteLine("Olá, Mundo!");
    }

    Console.Write("Selecione sua opção [s/n]: ");
    num = int.Parse(Console.ReadLine());

    if (num == 's' || num == 'S')
    {
      goto inicio;
    }
    if (num == 'n' || num == 'N')
    {
      Console.Clear();
      Console.WriteLine("Fim do programa");
    }*/

  }
}

// SINTAXE

// for ele repete tudo dentro do bloco quantas vezes necessario.
// neste caso iremos repetir numeros de um array.

// int[] nome_do_array = new int[15];
// int nome_da_variavel;
// for(nome_da_variavel = 0; nome_da_variavel = nome_do_array.Lenght; nome_da_variavel++) 
//{
//  nome_do_array[nome_da_variavel] = 0;
//  Console.WriteLine(nome_do_array);
//  Console.WriteLine("Meu Array está na posição - {0}, e mostra o valor - {1}",nome_da_variavel, nome_do_array[nome_da_variavel]);
//}