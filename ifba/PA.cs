using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class PA
    {

        public int razao { get; set; }
        public bool ehpa { get; set; }
        public PA()
        {

        }

        public bool CalcularPA(List<int> minhalista)
        {
            razao = minhalista[1] - minhalista[0];
            for (int i = 0; i < minhalista.Count; i++)
            {
                if (i+1 < minhalista.Count)
                {
                    if (razao == (minhalista[i + 1] - minhalista[i]))
                    {
                        ehpa = true;
                    }
                    else
                    {
                        ehpa = false;
                        return ehpa;
                    }
                }
            }
            return ehpa;
        }
    }
}
