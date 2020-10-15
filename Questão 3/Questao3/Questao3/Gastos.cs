using System;
using System.Collections.Generic;
using System.Text;

namespace Questao3
{
    class Gastos
    {
        public int anos;
        public int cigarroDia;
        public double precoCigarro;
        public double resultado;
        public double maco = 20;

        public void GastoTotal()
        {
            resultado = ((anos * 365) / (maco / cigarroDia)) * precoCigarro;
        }
    }
}
