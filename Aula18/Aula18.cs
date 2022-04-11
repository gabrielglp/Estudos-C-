using System;
class Aula18
{
  static void Main()
  {

    int[,] num = new int[2, 2] { { 10, 20 }, { 30, 40 } };

    Console.WriteLine(num[0, 1]);

    // Matrizes / vetores bidimensionais
    int[,] n = new int[3, 5]; //{ { 10, 20, 30, 40, 50 }, { 60, 70, 80, 90, 99 }, { 12, 22, 33, 44, 55 } }; // duas formas

    n[0, 0] = 10; n[0, 1] = 20; n[0, 2] = 30; n[0, 3] = 40; n[0, 4] = 50;
    n[1, 0] = 60; n[1, 1] = 70; n[1, 2] = 80; n[1, 3] = 90; n[1, 4] = 99;
    n[2, 0] = 12; n[2, 1] = 22; n[2, 2] = 33; n[2, 3] = 44; n[2, 4] = 55;

    Console.WriteLine(n[2, 1]);

    //matrizes seria tipo achar o carro numero 30, daí existem 3 pátios(ou 3 andares) que vão do carro(ou vaga) 1 ao 50 cada (ou 1 até 150 no total), Podemos criar um array bidimensional [3][50], o primeiro numero seria a quantidade de pátios(ou andares) que podemos acessar e o segundo a quantidade de carros(ou vagas) em cada.


  }
}