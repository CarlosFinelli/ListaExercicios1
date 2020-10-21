using System;
using System.Collections.Generic;
using System.Text;

namespace Questao20
{
    class Ano
    {
        public int ano;


        public String bissexto()
        {
            if (ano % 400 == 0 || ano % 4 == 0 && ano % 100 != 0)
            {
                return "Este ano é bissexto.";
            }
            else
            {
                return "Este ano não é bissexto.";
            }
        }
    }
}
