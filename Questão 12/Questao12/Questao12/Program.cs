using System;

namespace Questao12
{
    class Program
    {
        static void Main(string[] args)
        {
            Fiscalizacao fiscalizacao = new Fiscalizacao();
            Console.Write("Por favor, insira a velocidade máxima permitida: ");
            fiscalizacao.velocidadeMax = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira a velocidade do motorista: ");
            fiscalizacao.velocidadeMotorista = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(fiscalizacao.ValorMulta());
        }
    }
}
