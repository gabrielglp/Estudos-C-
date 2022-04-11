using System;

class Aula03{
    static void Main(){
        //byte n1 = 10; // 0 a 255
        //int num = 0;
        //char letra = 'c';
        //float valor = 1.2f;
        //string nome = "Bruno";

        int num1=10, num2=2, res;
        
        //num1 = 10;
        //num2 = 2;
        res = num1 * num2;

        Console.WriteLine("A multiplicação de " + num1 + " vezes " + num2 + " é igual a: " + res);
        Console.WriteLine("A multiplicação de " + num1 + " com " + num2 + " é igual a: " + num1*num2);

        var aux = 10; // não estou expecificando a minha variavel.

        Console.WriteLine("Valor da variavel: " + aux + "...");
    }
}