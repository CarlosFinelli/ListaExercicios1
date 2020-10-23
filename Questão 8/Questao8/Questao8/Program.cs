using System;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            Progressao progressao = new Progressao();
            Console.Write("Insira a razão da progressão: ");
            progressao.R = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o primeiro termo da progressão: ");
            progressao.X = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o número de termos que deseja ter na progressão: ");
            progressao.Y = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            progressao.Soma();
            Console.WriteLine($"A soma de todos os itens da progressão é igual a: {progressao.Soma()}");
            Console.ReadKey();
        }
    }
}
