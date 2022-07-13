using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{

    //*converter string em array de inteiros
    
    public class Numeros
    {
        public Numeros()
        {

        }

        public static int Ehfeliz(int entrada)
        {
            string novaentrada = entrada.ToString();
            var meuarray = novaentrada.Select(x => Int32.Parse(x.ToString())).ToList();
            var resultado = Math.Pow(meuarray[0], 2) + Math.Pow(meuarray[1], 2) + Math.Pow(meuarray[2], 2);
            return Convert.ToInt32(resultado);
        }


    }
}
