using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Soma
    {
        public int numero { get; set; }

        public Soma()
        {

        }

        public int CalcularSoma(int resultado)
        {
            
            for (int i = 0; i < numero; i++)
            {
                resultado = resultado + i;
            
            }
            return resultado;
        }
    }
}
