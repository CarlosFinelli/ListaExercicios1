using System;

namespace Questao15
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Console.Write("Insira o valor de A: ");
            numero.A = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de B: ");
            numero.B = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de C: ");
            numero.C = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(numero.Maior());
        }
    }
}
