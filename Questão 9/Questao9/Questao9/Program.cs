using System;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            Nome nome = new Nome();
            Console.Write("Por favor, insira o nome: ");
            nome.nome = Convert.ToString(Console.ReadLine());
            Console.Clear();
            nome.ConfereNome();
            Console.WriteLine(nome.resultado);
            Console.ReadKey();
        }
    }
}
