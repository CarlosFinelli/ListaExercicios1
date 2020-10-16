using System;
using System.Collections.Generic;
using System.Text;

namespace Questao12
{
    class Fiscalizacao
    {
        public int velocidadeMax, velocidadeMotorista;
        public String retorno = String.Empty;

        public void ValorMulta()
        {
            if (velocidadeMotorista <= velocidadeMax)
            {
                retorno = "Não há multa";
            }
            if (velocidadeMotorista > velocidadeMax && velocidadeMotorista <= velocidadeMax + 10)
            {
                retorno = "O valor da multa é de R$ 50,00";
            }
            if (velocidadeMotorista > velocidadeMax + 10 && velocidadeMotorista <= velocidadeMax + 30)
            {
                retorno = "O valor da multa é de R$ 100,00";
            }
            if (velocidadeMotorista > velocidadeMax + 31)
            {
                retorno = "O valor da multa é de R$ 200,00";
            }
        }
    }
}
