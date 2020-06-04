using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o valor da báse e a altura de um triangulo que então será calculado a área do mesmo");
            Console.Write("Báse:");
            double B=Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura:");
            double A=Convert.ToDouble(Console.ReadLine());
            double resultado=B * A;
            double resultado2=resultado / 2;
            Console.Clear();
            Console.WriteLine($"A área deste triangulo é= {resultado2}");
        }
    }
}
