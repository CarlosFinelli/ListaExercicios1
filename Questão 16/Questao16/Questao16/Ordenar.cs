using System;
using System.Collections.Generic;
using System.Text;

namespace Questao16
{
    class Ordenar
    {
        public double A, B, C;
        public double valorMaior, valorMenor, valorMedio;

        public void Nums()
        {
            valorMaior = Math.Max(Math.Max(A, B), C);
            valorMenor = Math.Min(Math.Min(A, B), C);
            if (A > valorMenor && A < valorMaior)
            {
                valorMedio = A;
            } else if (B > valorMenor && B < valorMaior)
            {
                valorMedio = B;
            } else if (C > valorMenor && C < valorMaior)
            {
                valorMedio = C;
            }
        }
    }
}
