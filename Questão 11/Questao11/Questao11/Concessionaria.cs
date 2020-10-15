using System;
using System.Collections.Generic;
using System.Text;

namespace Questao11
{
    class Concessionaria
    {
        public double lucro, imposto, valor;

        public void Calculos()
        {
            imposto = valor * 0.45;
            lucro = valor * 0.12;
        }
    }
}
