using System;

namespace Questao18
{
    class Program
    {
        static void Main(string[] args)
        {
            Latao latao = new Latao();
            Console.Write("Insira a quantidade de latão que deseja: ");
            latao.qtd = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            latao.Total();
            Console.WriteLine($"Para conseguir {latao.qtd} de latão, você precisará de {latao.cobre} de cobre e {latao.zinco} de zinco");
        }
    }
}
