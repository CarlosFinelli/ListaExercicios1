using System;
using System.Collections.Generic;
using System.Text;

namespace Questao4
{
    class Calculadora
    {
        public int A;
        public int B;
        public double quociente1;
        public double quociente2;
        public int resto1;
        public int resto2;
        public void Divisao()
        {
            quociente1 = A / B;
            quociente2 = B / A;
        }
        public void Resto()
        {
            resto1 = A % B;
            resto2 = B % A;
        }
    }
}
