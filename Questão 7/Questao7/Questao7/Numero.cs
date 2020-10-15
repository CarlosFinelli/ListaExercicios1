using System;
using System.Collections.Generic;
using System.Text;

namespace Questao7
{
    class Numero
    {
        public double num1, num2, num3;
        public String resultado;
        public void Maior()
        {
            if (num1 > (num2 + num3)) {
                resultado = $"O número {num1} é maior que a soma de {num2} e {num3}";
            } else
            {
                resultado = $"O número {num1} não é maior que a soma de {num2} e {num3}";
            }
        }
    }
}
