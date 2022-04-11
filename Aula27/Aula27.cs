using System;
class Aula27
{
  static void Main()
  {
    soma(10, 30, 55, 20, 48, 11, 28, 42);
  }
  static void soma(params int[] n)
  {
    int res = 0;

    if (n.Length < 1)
    {
      Console.WriteLine("Não existem valores a serem somados");
    }
    else if (n.Length < 2)
    {
      Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
    }
    else
    {
      for (int i = 0; i < n.Length; i++)
      {
        res += n[i]; // percorre pelo meu array.
      }
      Console.WriteLine("A soma dos valores é: {0}", res);
    }

  }

}

/* mult(1,2,3,4,5,6);  //chama o metodo e define seus valores, dentro do parametro
            Console.ReadKey();
        }

        static void mult(params int[] n) //Define um parametro, ou seja, array dentro do metodo de tipo INT e nome N
        {   
         int res = 0;
         

            if(n.Length <= 1){ 
                Console.WriteLine("Multiplicação não possivel por falta de argumentos");
            }
            else if(n.Length > 1){
                for (int x = 0; x < n.Length; x++) //For só ira rodar e adicionar ah N  no parametro
                {
                    res += n[x];  //O for vai rodar o codigo 6 vezes, assim N[recebendo de 0 a 5] pulando casas
                                  //Res vai sempre recebe a variavel anterior de N, somando a proxima*/