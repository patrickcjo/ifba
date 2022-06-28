using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ifba;

namespace ifbaxunit
{
    public class UniCirculo
    {

        [Fact]

        public void CalcularPerimetro()
        {

            double perimetro = 0;

            Circulo circulo = new Circulo();
            circulo.raio = 3;
            perimetro = circulo.CalcularPerimetro();
            Assert.True(Math.Round(perimetro, 2) == 18.85);
        }

        [Fact]

        public void CalcularAreaCirculo()
        {

            double areaCirculo = 0;

            Circulo circulo = new Circulo();
            circulo.raio = 3;
            areaCirculo = circulo.CalcularArea();
            Assert.True(Math.Round(areaCirculo, 2) == 28.27);

        }

    }
}
