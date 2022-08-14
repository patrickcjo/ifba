using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class ClimaTempo
    {
        public int maiorTemp { get; set; }
        public int menorTemp { get; set; }
        public double media { get; set; }

        public ClimaTempo()
        {

        }

        public void CalcularTemp(List<int> minhalista)
        {

            int soma = 0;
            menorTemp = 1000;
            maiorTemp = -500;
            foreach (var item in minhalista)
            {
                soma += item;
                if (item < menorTemp)
                {
                    menorTemp = item;
                }
                if (item > maiorTemp)
                {
                    maiorTemp = item;
                }
            }
            media = soma / minhalista.Count;

        }
        public static double CalcularMedia(List<int> minhalista)
        {
            int soma = 0;
            foreach (var item in minhalista)
            {
                soma += item;
            }
            var newmedia = soma / minhalista.Count;
            return newmedia;
        }
    }
}
