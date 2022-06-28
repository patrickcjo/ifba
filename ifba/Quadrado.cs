using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Quadrado
    {
        public int Lado { get; set; }

        public Quadrado()
        {

        }

        public int CalcularAreaQuadrado()
        { 
            int area= 0;
            area = Lado * Lado;
            return area;
        }

        public int CalcularPerimetroQuadrado()
        { 
            int perimetro = 0;
            perimetro = Lado * 4;
            return perimetro;
        }
    }


}
