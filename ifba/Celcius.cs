using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Celcius
    {
        public double celcius { get; set; }
        public double fahrenheit { get; set; }

        public double CalcularCelcius()
        {
            celcius = (fahrenheit - 32) / 1.8;
            return celcius;
        }

        public Celcius()
        {

        }


    }
}
