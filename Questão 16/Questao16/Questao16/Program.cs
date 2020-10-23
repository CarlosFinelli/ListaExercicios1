using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Questao16
{
    class Program
    {

        static List<Ordenar> ordenar = new List<Ordenar>();
        static void Main(string[] args)
        {
            /*  for (int i = 0; i < 3; i++)
              {
                  Ordenar numeros = new Ordenar();
                  Console.Write($"Insira o valor {i}:");
                  numeros.num = Convert.ToInt16(Console.ReadLine());
                  Console.Clear();
                  ordenar.Add(numeros);
              }
             // ordenar.Sort();
             // ordenar.ForEach(numeros => Console.WriteLine(numeros));
              foreach (Ordenar numeros in ordenar)
              {
                  Console.WriteLine(numeros.num);
              } */
            Ordenar ordenar = new Ordenar();
            Console.Write($"Insira o valor 1: ");
            ordenar.A = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write($"Insira o valor 2: ");
            ordenar.B = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write($"Insira o valor 3: ");
            ordenar.C = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            ordenar.Nums();
            Console.WriteLine(ordenar.valorMenor);
            Console.WriteLine(ordenar.valorMedio);
            Console.WriteLine(ordenar.valorMaior);
        }
    }
}
