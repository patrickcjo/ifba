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
            n = resultado;
            if (resultado == 0 || resultado == 1)
            {
                return 1;
            }
            else if (resultado < 0)
            {
                throw new SystemException("Fatorial nao pode ser menor que 0 animal");
            }
            for (int i = resultado; i > 1; i--)
            {
                n = n * (i - 1);
                n*= (i - 1);
            }

            return n;
        }
    }
}
