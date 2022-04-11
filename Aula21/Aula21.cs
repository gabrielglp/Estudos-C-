using System;
class Aula21
{
  public static void Main()
  {
    /*int num = 5;
    while (num < 5)
    {
      Console.WriteLine("CFB CURSOS");
    }
    // ele teste antes de ver se é falso ou não.
    do
    {
      Console.WriteLine("CFB CURSOS");
    } while (num < 5);*/

    string senha = "123"; // variavel principal para ativar o while
    string senhauser; // variavel a ser comparada
    int tentativas = 0; // variavel que conta as tentativa

    do
    {
      Console.Clear();
      Console.Write("Digite sua senha: ");
      senhauser = Console.ReadLine();
      tentativas++;
    } while (senha != senhauser); // se senha for != diferente de senhauser, não executa

    Console.Clear();
    Console.WriteLine("Senha correta, tentativas: {0}", tentativas);
  }
}

// SINTAXE
// chamando esse repetidor DO ele testa antes de executar o WHILE
// neste caso de cima se não for algo igual a variavel ele não executa

//do
//{
//
//} while ();
