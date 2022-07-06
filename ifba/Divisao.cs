using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Divisao
    {
        public int dividendo { get; set; }
        public int divisor { get; set; }
        public int quociente { get; set; }
        public int resto { get; set; }

        public int CalcularDivisao(int dividendo_, int divisor_)
        {

            dividendo = dividendo_;
            divisor = divisor_;
            quociente = dividendo / divisor;
            return quociente;
        }


        public int CalcularResto(int dividendo_, int divisor_)
        {
            divisor = divisor_;
            dividendo = dividendo_;
            resto = dividendo % divisor;
            return resto;
        }

        public Divisao()
        {

        }
    }
}
