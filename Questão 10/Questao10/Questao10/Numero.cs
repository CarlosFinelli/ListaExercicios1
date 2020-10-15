using System;
using System.Collections.Generic;
using System.Text;

namespace Questao10
{
    class Numero
    {
        public double A, B;
        public String resultado;
        public void VerificaMaior()
        {
            if (A > B)
            {
                resultado = $"{A}";
            }
            if (A < B)
            {
                resultado = $"{B}";
            }
            if (A == B)
            {
                resultado = $"{A}={B}";
            }
        }
    }
}
