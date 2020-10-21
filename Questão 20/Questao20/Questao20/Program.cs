using System;

namespace Questao20
{
    class Program
    {
        static void Main(string[] args)
        {
            Ano ano = new Ano();
            Console.Write("Insira o ano que deseja verificar: ");
            ano.ano = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(ano.bissexto());
        }
    }
}
