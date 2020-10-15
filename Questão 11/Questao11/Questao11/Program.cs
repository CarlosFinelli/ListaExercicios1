using System;

namespace Questao11
{
    class Program
    {
        static void Main(string[] args)
        {
            Concessionaria concessionaria = new Concessionaria();
            Console.Write("Insira o valor do carro: ");
            concessionaria.valor = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            concessionaria.Calculos();
            Console.WriteLine($"O valor do imposto é: {concessionaria.imposto}");
            Console.WriteLine($"O valor do lucro é: {concessionaria.lucro}");
        }
    }
}
