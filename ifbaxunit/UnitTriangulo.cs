using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;


namespace ifbaxunit
{
    public class UnitTriangulo
    {

        [Fact]
        public void CalcularPerimetroTeste()
        {
            int perimetro = 0;

            Triangulo triangulo = new Triangulo(6, 4, 4);

            perimetro = triangulo.CalcularPerimetro();
            Assert.True(perimetro == 14);
        }
    }
}
