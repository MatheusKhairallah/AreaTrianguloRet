using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Um triângulo retângulo possui uma báse de 3 e altura 5, qual é o valor de sua área?");
            double B=3;
            double A=5;
            double resultado=B * A;
            double resultado2=resultado / 2;
            Console.WriteLine($"{resultado2}");
        }
    }
}
