using System;
class Aula08
{
  static void Main()
  {
    int v1, v2, soma;
    string nome;

    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();
    Console.Write("Olá {0}, digite o primeiro valor: ", nome);
    //converter string para numero int.
    v1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o Segundo Valor: ");
    v2 = int.Parse(Console.ReadLine());
    soma = v1 + v2;

    Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);
  }
}