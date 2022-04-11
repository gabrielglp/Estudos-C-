using System;
class Aula10
{
  //enumeradores

  enum diasSemanas { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado };
  static void Main()
  {
    diasSemanas ds = diasSemanas.Domingo;
    // diasSemanas ds = {diasSemanas}2;

    Console.WriteLine(ds);
  }
}

// SINTAXE

//enum algo {objeto1,objeto2,objeto3,objeto4... };

// chama o nome do enum

//  algo (com alguma variavel) = algo.obejto1;