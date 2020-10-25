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
            double D = X + ((Y - 1) * R);
            double Result = (y * (X+D)) / 2;
            return Result;
        }
    }
}
