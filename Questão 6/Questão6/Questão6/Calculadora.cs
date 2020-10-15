using System;
using System.Collections.Generic;
using System.Text;

namespace Questão6
{
    class Calculadora
    {
        public double num1;
        public double num2;
        public double num3;
        public double resultado;

        public void Soma()
        {
            resultado = num1 + num2 + num3;
        }

        public void Multiplicacao()
        {
            resultado = num1 * num2 * num3;
        }

        public void Divisao()
        {
            resultado = (num1 / num2) / num3;
        }
    }
}
