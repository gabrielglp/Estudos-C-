using System;
class Aula13
{
  static void Main()
  {
    // if, forma de se ler é SE
    // else, testa a condição igual ao if 
    // se expressão logica for verdadeira, executa os comandos do bloco
    // if(e_l){bloco}
    // > < >= <= == !=

    float n1, n2, n3, n4, res;
    res = n1 = n2 = n3 = n4 = 0f;
    float notaMedia = 0f;
    string resultado;

    Console.Write("Digite sua primeira nota: ", n1);
    n1 = float.Parse(Console.ReadLine());

    Console.Write("Digite sua segunda nota: ", n2);
    n2 = float.Parse(Console.ReadLine());

    Console.Write("Digite sua terceira nota: ", n3);
    n3 = float.Parse(Console.ReadLine());

    Console.Write("Digite sua quarta nota: ", n4);
    n4 = float.Parse(Console.ReadLine());

    res = n1 + n2 + n3 + n4;
    notaMedia = res / 4;

    if (notaMedia >= 6)
    {
      resultado = "Aprovado";
    }
    else if (notaMedia >= 4)
    {
      resultado = "Recuperação";
    }
    else
    {
      resultado = "Reprovado";
    }

    Console.WriteLine("Com o total de {0} pontos, você foi -> {1} <-", notaMedia, resultado);
  }
}

// SINTAXE

// if(variavel = valor que voce quer comparar)
//{
// chama a string / resultado = "Aprovado";
//} 
// else if (variavel = valor que voce quer comparar) - conhecido com OU SE
//{
// chama a string / resultado = "Recuperação"; 
//}
// else - conhecido como OU 
//{
//  chama a string / resulrado = "Reprovado";
//} 