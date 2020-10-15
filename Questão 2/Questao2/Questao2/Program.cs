using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas notas = new Notas();
            Console.WriteLine("Questão 2");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Por favor, insira a nota da primeira prova (De 1 a 10): ");
            notas.nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira a nota da segunda prova (De 1 a 10): ");
            notas.nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira a nota da terceira prova (De 1 a 10): ");
            notas.nota3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            notas.CalculoMedia();
            Console.WriteLine($"Situaçaõ do aluno: {notas.situacao}");
            
        }
    }
}
