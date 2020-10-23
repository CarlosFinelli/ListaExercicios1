using System;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Console.Write("Por favor, insira o valor do primeiro número: ");
            numero.num1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o valor do segundo número: ");
            numero.num2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o valor do terceiro número: ");
            numero.num3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            numero.Maior();
            Console.WriteLine(numero.resultado);
            Console.ReadKey();
        }
    }
}
