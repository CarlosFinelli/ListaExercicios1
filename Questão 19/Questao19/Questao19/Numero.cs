using System;
using System.Collections.Generic;
using System.Text;

namespace Questao19
{
    class Numero
    {
        public int A, B, C, D, result;

        public int Soma()
        {
            if (A % 2 == 0)
            {
                result += A;
            }
            if (B % 2 == 0) {
                result += B;
            }
            if (C % 2 == 0)
            {
                result += C;
            }
            if (D % 2 == 0)
            {
                result += D;
            }
            return result;
        }
    }
}
