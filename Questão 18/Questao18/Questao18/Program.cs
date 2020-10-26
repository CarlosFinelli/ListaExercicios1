using System;

namespace Questao18
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            Console.Write("Insira o valor do lado A do triângulo: ");
            triangulo.A = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor do lado B do triângulo: ");
            triangulo.B = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor do lado C do triângulo: ");
            triangulo.C = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Os valores digitados pertencem a um triângulo: {triangulo.Tipo()}");
            Console.ReadKey();
        }
    }
}
