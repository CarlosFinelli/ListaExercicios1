using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2
{
    class Notas
    {
        public double nota1;
        public double nota2;
        public double nota3;
        public double media;
        public String situacao;

        public void CalculoMedia()
        {
            media = ((nota1 + nota2 + nota3) / 3);
            if (media < 5)
            {
                situacao = "Reprovado";
            }
            if (media >= 5 && media < 7)
            {
                situacao = "Recuperação";
            }
            if (media >= 7)
            {
                situacao = "Aprovado";
            }
        }
    }
}
