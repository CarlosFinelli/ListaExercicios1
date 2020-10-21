using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Questao15
{
    class Numero
    {
        public double A, B, C;

        public String Maior()
        {
            if (A > B && A > C)
            {
                return "A";
            }
            if (B > A && B > C)
            {
                return "B";
            }
            if (C > A && C > B)
            {
                return "C";
            }
            if (A == B || A == C || B == C)
            {
                return "Um ou mais valores são iguais";
            }
            return "";
        }
    }
}
