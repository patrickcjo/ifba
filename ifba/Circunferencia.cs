using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Circulo
    {
        public int raio { get; set; }

        public Circulo()
        {

        }

        public double CalcularPerimetro()
        {
            double perimetro = 0;
            perimetro = 2 * Math.PI * raio;
            return perimetro;
        }

        public double CalcularArea()
        { 
            double area = 0;
            area = Math.PI * Math.Pow(raio, 2);
            return area;   

        }

    }
}
