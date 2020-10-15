using System;
using System.Collections.Generic;
using System.Text;

namespace Questao8
{
    class Progressao
    {
        public int R, X, Y;

        public void Soma()
        {
            for (int i = 0; i < Y; i++)
            {
                X += R;
            }
        }
    }
}
