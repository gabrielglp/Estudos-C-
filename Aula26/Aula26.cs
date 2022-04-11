using System;
class Aula25
{
  static void Main()
  {

    /*int[] quoc = new int[1];
    int n;
    int dividendo = 0;
    int divisor = 3;
    int resto = 0;
    int res = 0;
    int res1 = 0;
    for (n = 0; n < quoc.Length; n++)
    {
      Console.Clear();
      Console.Write("Dividindo: ");
      quoc[n] = int.Parse(Console.ReadLine());

      dividendo += quoc[n];
      resto += quoc[n];
    }
    res1 = resto % divisor;
    res = dividendo / divisor;

    Console.WriteLine("{0}/{1}: quociente = {2} e resto = {3}", dividendo, divisor, res, res1);*/


    // out da a possibilidade de retornar mais que um valor de saida.
    int divid, divis, quoc, rest;
    divid = 10;
    divis = 3;
    quoc = divide(divid, divis, out rest);
    Console.WriteLine("{0}/{1}: quociente = {2} e resto = {3}", divid, divis, quoc, rest);

  }

  static int divide(int dividendo, int divisor, out int resto)
  {
    int quociente = dividendo / divisor;
    resto = dividendo % divisor;
    return quociente;
  }
}