using System;
using System.Collections.Generic;
using System.Text;

namespace Questao12
{
    class Fiscalizacao
    {
        public int velocidadeMax, velocidadeMotorista;
        public String retorno = String.Empty;

        public String ValorMulta()
        {
            if (velocidadeMotorista <= velocidadeMax)
            {
                return "Não há multa";
            }
            if (velocidadeMotorista > velocidadeMax && velocidadeMotorista <= velocidadeMax + 10)
            {
                return "O valor da multa é de R$ 50,00";
            }
            if (velocidadeMotorista > velocidadeMax + 10 && velocidadeMotorista <= velocidadeMax + 30)
            {
                return "O valor da multa é de R$ 100,00";
            }
            if (velocidadeMotorista > velocidadeMax + 31)
            {
                return "O valor da multa é de R$ 200,00";
            }
            return "";
        }
    }
}
