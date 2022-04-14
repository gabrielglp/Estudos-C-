using System;

class Aula51
{
    static void Main(string[] args)
    {
        int res = 0;
        if (args.Length > 0)
        {
            Console.WriteLine("QTDR de argumentos {0}", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                res += Int32.Parse(args[i]);
                Console.WriteLine("Argumento {0} : {1}", i, args[i]);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Soma: {0}", res);
        }
        else
        {
            Console.WriteLine("Não foram passado passados argumentos");
        }
    }
}

//Argumentos de entrada do programa

//.\algo 10 30 20
