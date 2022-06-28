using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Primo
    {
        public int divisor { get; set; }
        public int contador { get; set; }
        public int dividendo { get; set; }
        public int count { get; set; }

        public Primo()
        {

        }

        public bool ONumeroEPrimo(int entrada)
        {

            contador = 0;
            if (entrada <= 1)
            {
                return false;
            }
            for (int i = 1; i <= entrada; i++)
            {
                Debug.WriteLine($"Essa é minha iteração {i}");
                if (entrada % i == 0)
                {
                    contador++;
                }
            }
            if (contador > 2)
            {
                return false;
            }
            return true;
        }

        public int QntPrimos(int entrada)
        {
            var primos = 0;
            for (int i = 0; i <= entrada; i++)
            {
                if (ONumeroEPrimo(i) == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
