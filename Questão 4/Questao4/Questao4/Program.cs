using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.Write("Por favor, insira o valor do primeiro número: ");
            calculadora.A = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o valor do segundo número: ");
            calculadora.B = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            calculadora.Divisao();
            calculadora.Resto();
            Console.WriteLine($"O quociente da divisão entre {calculadora.A} e {calculadora.B} é: {calculadora.quociente1}");
            Console.WriteLine($"O resto da divisão entre {calculadora.A} e {calculadora.B} é: {calculadora.resto1}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"O quociente da divisão entre {calculadora.B} e {calculadora.A} é: {calculadora.quociente2}");
            Console.WriteLine($"O resto da divisão entre {calculadora.B} e {calculadora.A} é: {calculadora.resto2}");
            Console.ReadKey();
        }
    }
}
