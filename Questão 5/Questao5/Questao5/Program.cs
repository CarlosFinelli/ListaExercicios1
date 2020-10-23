using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            Console.Write("Por favor, insira a base lateral do cilindro: ");
            cilindro.aLateral = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira a área da base do cilindro: ");
            cilindro.aBase = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            cilindro.AreaTotal();
            Console.WriteLine($"A área total é igual a: {cilindro.aTotal}");
            Console.ReadKey();
        }
    }
}
