using System;

namespace Questao14
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.Write("Insira o primeiro valor: ");
            calc.A = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o segundo valor: ");
            calc.B = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"O resultado da divisão entre {calc.A} e {calc.B} é igual a: {calc.Divisao()}");
        }
    }
}
