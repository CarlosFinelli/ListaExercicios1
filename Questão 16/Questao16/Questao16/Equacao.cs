using System;
using System.Collections.Generic;
using System.Text;

namespace Questao16
{
    class Equacao
    {
        public int A, B, C;
        public double x1, x2;

        public void Raiz()
        {
            x1 = (-B + Math.Sqrt(B * B - (4 * A * C))) / 2 * A;
            x2 = (-B - Math.Sqrt(B * B - (4 * A * C))) / 2 * A;
        }
    }
}
