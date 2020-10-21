using System;
using System.Collections.Generic;
using System.Text;

namespace Questao8
{
    class Progressao
    {
        public int R, X, Y;
        private int Result = 0;

        public int Soma()
        {
            Result = ((X + Y) * R) / 2;
            return Result;
        }
    }
}
