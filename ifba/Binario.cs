using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Binario
    {

        //public int dividendo { get; set; }
        public List<int> binario { get; set; }
        //public int quociente { get; set; }
        private List<int> binarioPrivada { get; set; }

        public Binario()
        {
            binario = new List<int>();
            binarioPrivada = new List<int>();
        }

        public List<int> ConvertBinario(int entrada)
        {

            Divisao div = new Divisao();
            div.divisor = 2;
            div.dividendo = entrada;
            while (div.dividendo >= 2)
            {
                binarioPrivada.Add(div.CalcularResto());
                div.dividendo = div.CalcularDivisao();

                if (div.dividendo < div.divisor)
                {
                    binarioPrivada.Add(div.dividendo);
                }
            }
            for (int i = binarioPrivada.Count -1; i >= 0; i--)
            {
                binario.Add(binarioPrivada[i]);
            }
            
            return binario;
        }

    }
}
