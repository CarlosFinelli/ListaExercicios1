using System;

namespace Questão6
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.Write("Por favor, insira o primeiro valor: ");
            calculadora.num1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o segundo valor: ");
            calculadora.num2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o terceiro valor: ");
            calculadora.num3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            calculadora.Soma();
            Console.WriteLine($"A soma entre {calculadora.num1}, {calculadora.num2}, {calculadora.num3} é igual a: {calculadora.resultado}");
            calculadora.Multiplicacao();
            Console.WriteLine($"O produto entre {calculadora.num1}, {calculadora.num2} e {calculadora.num3} é igual a: {calculadora.resultado}");
            calculadora.Divisao();
            Console.WriteLine($"O Quociente entre {calculadora.num1}, {calculadora.num2} e {calculadora.num3} é igual a: {calculadora.resultado}");
            Console.ReadKey();
        }
    }
}
