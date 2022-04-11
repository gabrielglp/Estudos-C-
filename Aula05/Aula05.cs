using System;

class Aula05
{

  static void Main()
  {

    bool res1 = 10 < 5;
    bool res2 = 10 > 5;
    // operador relacional >, <, =, >=, <=
    Console.WriteLine(res1);
    Console.WriteLine(res2);

    int num = 10;
    //num = num + 1;
    //ou
    num++;
    //num += 2, num /= 2, num *= 2, num -= 2.
    Console.WriteLine(num);

    int res = (10 + 5) * 2;
    Console.WriteLine(res);

    bool res3 = (5 > 3)(10 < 5);
    // & = END / E (toda tem que ser verdaderia) = TRUE
    // | = OR / OU (uma delas for verdadeira) = TRUE
    Console.WriteLine(res3);
  }
}