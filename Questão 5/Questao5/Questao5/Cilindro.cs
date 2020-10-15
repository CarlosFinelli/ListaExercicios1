using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Questao5
{
    class Cilindro
    {
        public double aLateral;
        public double aBase;
        public double aTotal;

        public void AreaTotal()
        {
            aTotal = aLateral + (2 * aBase);
        }
    }
}
