using System;
using System.Collections.Generic;
using System.Text;

namespace Questao9
{
    class Nome
    {
        public String nome, resultado;
        public void ConfereNome()
        {
            if (nome == "Carlos" || nome == "carlos")
            {
                resultado = "Nome correto";
            }
            else
            {
                resultado = "Nome incorreto";
            }
        }
    }
}
