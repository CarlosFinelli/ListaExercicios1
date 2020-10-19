using System;
using System.Collections.Generic;
using System.Text;

namespace Questao14
{
    class Calc
    {
        public int A, B, result;

        public double Divisao()
        {
            if (B == 0)
            {
                Console.WriteLine("Divisão por zero");
                return 0;
            }
            else 
            {
                result = A / B;
                return result;
            }
        }
    }
}
