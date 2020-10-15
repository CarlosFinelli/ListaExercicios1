using System;

namespace Questao10
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Console.Write("Por favor, insira o valor de A: ");
            numero.A = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o valor de B: ");
            numero.B = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            numero.VerificaMaior();
            {
                Console.WriteLine(numero.resultado);
            }
        }
    }
}
