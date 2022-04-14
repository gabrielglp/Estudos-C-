using System;

namespace Calc1
{
    class Area
    {
        public static double Quad(double bas, double alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a zero");
            }
            return bas * alt;
        }
    }
}

namespace Calc2
{
    class Area
    {
        public static double Quad(double bas, double alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a zero");
            }
            return bas * alt;
        }
    }
}

class Aula53
{
    static void Main()
    {
        double area = 0;
        try
        {
            area = Calc2.Area.Quad(10.2, 0);
            Console.WriteLine("Area do quadrado - {0}", area);
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR : {0}", e.Message);
        }
        finally
        {
            Console.WriteLine("FIM DO PROCESSO");
        }
    }
}

// Namespace - organização do scopo
