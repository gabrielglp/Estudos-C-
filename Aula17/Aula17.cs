using System;
class Aula17
{
  static void Main()
  {
    int[] n = new int[5] { 11, 22, 33, 44, 55 };
    int[] num = new int[3] { 55, 77, 99 };
    int[] num2 = { 55, 77, 99, 101 };
    string[] veiculos = { "Carro", "Avião", "Onibus" };

    //n[0] = 11;
    //n[1] = 22;
    //n[2] = 33;
    //n[3] = 44;
    //n[4] = 55;

    Console.WriteLine(n[0]);
    Console.WriteLine(num[2]);
    Console.WriteLine(num2[3]);
    Console.WriteLine(veiculos[1]);
  }
}

// SINTAXE

// string[] nome_do_array = {"Gabriel", "Pedro", "Sadraque"}; // dentro de chaves voce coloca os valores que tem dentro do seu array
// string[,] nome_do_array = {"Porsche", "Camaro", "Palio", "Celta"}, {"Corsa", "ONIX", "CRUZE", "VERACRUZ"}

// forma de chamar seu array nome_do_array[2];
// nome_do_array[0,3];