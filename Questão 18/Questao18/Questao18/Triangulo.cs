using System;
using System.Collections.Generic;
using System.Text;

namespace Questao18
{
    class Triangulo
    {
        public double A, B, C;
        private String Result;

        public String Tipo()
        {
            if (A == B && A != C || A != B && A == C || A != B && B == C)
            {
                Result = "Isósceles";
            }
            if (A != B && A != C && B != C)
            {
                Result = "Escaleno";
            }
            if (A == B && A == C)
            {
                Result = "Equilátero";
            }
            return Result;
        }
    }
}
