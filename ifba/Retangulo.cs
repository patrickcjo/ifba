using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Retangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public Retangulo()
        {

        }

        public Retangulo(int _base, int _altura)
        {
            Base = _base;
            Altura = _altura;   
        }

        public int CalcularArea()
        {
            int area = 0;
            area = Base * Altura;
            return area;
        }

        public decimal CalcularPerimetro()
        {
            decimal perimetro = 0;
            perimetro = (Base * 2) + (Altura * 2);
            return perimetro;
        }

    }
}
