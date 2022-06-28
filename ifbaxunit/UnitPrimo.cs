using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;


namespace ifbaxunit
{
    public class UnitPrimo
    {
        [Fact]
        public void CalcularPrimo12()
        {
            Primo primo = new Primo();
            Assert.False(primo.ONumeroEPrimo(12));
        }

        [Fact]
        public void CalcularPrimo7()
        {
            Primo primo = new Primo();
            Assert.True(primo.ONumeroEPrimo(7));
        }

        [Fact]
        public void CalcularPrimo0()
        {
            Primo primo = new Primo();
            Assert.False(primo.ONumeroEPrimo(0));
        }

        [Fact]
        public void QntPrimos()
        {
            Primo primo = new Primo();
            Assert.True(primo.QntPrimos(10) == 4);
        }
    }
}