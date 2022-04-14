using System;

delegate int Op(int numero1, int numero2);

namespace Adicao
{
    class Adi
    {
        public static int Adic(int numero1, int numero2)
        {
            if (numero1 == 0 || numero2 == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a zero");
            }
            return numero1 + numero2;
        }
    }
}

namespace Multiplicacao
{
    class Mult
    {
        public static int Multi(int numero1, int numero2)
        {
            if (numero1 == 0 || numero2 == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a zero");
            }
            return numero1 * numero2;
        }
    }
}

namespace Divisao
{
    class Div
    {
        public static int Divi(int numero1, int numero2)
        {
            if (numero1 == 0 || numero2 == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a zero");
            }
            return numero1 / numero2;
        }
    }
}

namespace Subtracao
{
    class Sub
    {
        public static int Subt(int numero1, int numero2)
        {
            if (numero1 == 0 || numero2 == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a zero");
            }
            return numero1 - numero2;
        }
    }
}

class Calculadora
{
    static void Main()
    {
        char escolha;
        int resultado = 0;
        int
            n1,
            n2 = 0;
        Op d1 = new Op(Adicao.Adi.Adic);
        Op d2 = new Op(Multiplicacao.Mult.Multi);
        Op d3 = new Op(Divisao.Div.Divi);
        Op d4 = new Op(Subtracao.Sub.Subt);

        Console.Write("Digite seu numero: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite seu numero: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escolha as opções");
        Console
            .WriteLine("Escolha: [a]Adição | [b]Multiplicação | [c]Divisão | [d]Subtração");
        Console.Write("Letra: ");
        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
            case 'A':
                resultado = d1(n1, n2);
                break;
            case 'b':
            case 'B':
                resultado = d2(n1, n2);
                break;
            case 'c':
            case 'C':
                resultado = d3(n1, n2);
                break;
            case 'd':
            case 'D':
                resultado = d4(n1, n2);
                break;
            default:
                resultado = -1;
                break;
        }
        Console.Clear();
        Console.WriteLine("Seu Resultado é: {0}", resultado);
    }
}
