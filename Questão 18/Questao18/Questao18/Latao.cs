using System;
using System.Collections.Generic;
using System.Text;

namespace Questao18
{
    class Latao
    {
        public double cobre, zinco, qtd;

        public void Total()
        {
            cobre = qtd * 0.7;
            zinco = qtd * 0.3;
        }
    }
}
