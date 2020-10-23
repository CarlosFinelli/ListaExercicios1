using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Gastos gastos = new Gastos();
            Console.Write("Insira o número de anos que você fuma: ");
            gastos.anos = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o número de cigarros que fuma por dia: ");
            gastos.cigarroDia = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o preço da carteira de cigarros: ");
            gastos.precoCigarro = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            gastos.GastoTotal();
            Console.WriteLine($"Até hoje você já gastou: {gastos.resultado} com cigarros.");
            Console.ReadKey();
        }
    }
}
