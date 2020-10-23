using System;

namespace Questao17
{
    class Program
    {
        static void Main(string[] args)
        {
            Equacao equacao = new Equacao();
            Console.Write("Insira o valor de A: ");
            equacao.A = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de B: ");
            equacao.B = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de C: ");
            equacao.C = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            equacao.Raiz();
            Console.WriteLine($"As raizes dessa equação são: {equacao.x2} e {equacao.x1}. ");
        }
    }
}
