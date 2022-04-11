using System;
class Aula12
{
  static void Main()
  {
    // if, forma de se ler é SE
    // se expressão logica for verdadeira, executa os comandos do bloco
    // if(e_l){bloco}
    // > < >= <= == !=

    int n1, n2, n3, n4, res;
    res = n1 = n2 = n3 = n4 = 0;
    int notaMedia = 0;
    string resultado = "Reprovado";

    Console.Write("Digite sua primeira nota: ", n1);
    n1 = int.Parse(Console.ReadLine());

    Console.Write("Digite sua segunda nota: ", n2);
    n2 = int.Parse(Console.ReadLine());

    Console.Write("Digite sua terceira nota: ", n3);
    n3 = int.Parse(Console.ReadLine());

    Console.Write("Digite sua quarta nota: ", n4);
    n4 = int.Parse(Console.ReadLine());

    res = n1 + n2 + n3 + n4;
    notaMedia = res / 4;

    if (notaMedia >= 6)
    {
      resultado = "Aprovado";
    }

    Console.WriteLine("Sua media é {0}, você foi -> {1} <-", notaMedia, resultado);
  }
}

// SINTAXE

// if (valriavel = quantidade que voce quer comparar)
//{
// chama a string que voce criou neste caso/ resultado = "Aprovado"
//}