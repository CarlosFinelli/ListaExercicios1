using System;

namespace Questao19
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Console.Write("Insira o valor de A: ");
            numero.A = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de B: ");
            numero.B = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de C: ");
            numero.C = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de D: ");
            numero.D = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"A soma dos elementos pares é igual a: {numero.Soma()}");
        }
    }
}
