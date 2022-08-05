using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;

namespace ifbaxunit
{
    public class UnitSoma
    {

        [Fact]

        public void CalcularSoma100()
        {
        
            Soma  soma = new Soma();
            soma.numero = 100;
            int retorno  = soma.CalcularSoma(100);
            Assert.True(retorno == 5050);

        }

        [Fact]

        public void CalcularSoma10()
        {

            Soma soma = new Soma();
            soma.numero = 10;
            int retorno = soma.CalcularSoma(10);
            Assert.True(retorno == 55);

        }
    }
}
