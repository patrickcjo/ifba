using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Fatorial
    {

        public int n { get; set; }
        public int fatorial { get; set; }

        public Fatorial()
        {

        }

        public int CalcFatorial(int resultado)
        {
            for (int i = 0; i < n; i++)
            {
                resultado = n * (n - 1);
                fatorial = resultado;
            }

            return resultado;
        }

    }
}
