using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Caixa
    {

        public int valor { get; set; }
        public int nota100 { get; set; }
        public int nota50 { get; set; }
        public int nota20 { get; set; }
        public int nota10 { get; set; }

        public Caixa()
        {

        }

        public void CalcularNotas()
        {
            while (valor > 0)
            {
                if (valor >= 100)
                {
                    nota100 = valor / 100;
                    valor = valor - (nota100 * 100);
                }
                else if (valor >= 50)
                {
                    nota50 = valor / 50;
                    valor = valor - (nota50 * 50);
                }
                else if (valor >= 20)
                {
                    nota20 = valor / 20;
                    valor = valor - (nota20 * 20);
                }
                else if (valor >= 10)
                { 
                    nota10 = valor / 10;
                    valor = valor - (nota10 * 10);
                }
            }

        }

    }
}
