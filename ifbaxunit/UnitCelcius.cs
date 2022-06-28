using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;

namespace ifbaxunit
{
    public class UnitCelcius
    {
        [Fact]
        public void CalcularFahrenheit150()
        {
            Celcius celcius = new Celcius();

            celcius.fahrenheit = 150;
            celcius.CalcularCelcius();
            Assert.True(Math.Round(celcius.celcius, 2) == 65.56);
        }
    }
}
