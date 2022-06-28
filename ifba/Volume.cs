using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Volume
    {

        public int altura { get; set; }
        public int raio { get; set; }

        public double CalcularVolume()
        {
            Circulo area = new Circulo();
            area.raio = raio;
            double volume = 0;
            volume = area.CalcularArea() * altura;
            return volume;
        }
    }
}
