using System;
using System.Collections.Generic;
using System.Text;

namespace Questao8
{
    class Progressao
    {
        public int R, X, Y;
        private double Result = 0;

        public double Soma()
        {
            double D = X + ((Y - 1) * R);
            double Result = (Y * (X+D)) / 2;
            return Result;
        }
    }
}
