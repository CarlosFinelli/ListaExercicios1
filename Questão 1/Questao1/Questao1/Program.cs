﻿using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 1");
            Console.WriteLine("");
            Console.WriteLine("");
            Sucessor num = new Sucessor();
            Console.Write("Por favor, digite um número: ");
            num.num = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"O Sucessor de {num.num} é: {num.sucessor()}");
        }
    }
}
