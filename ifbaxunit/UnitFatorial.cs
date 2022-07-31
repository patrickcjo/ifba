using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;

namespace ifbaxunit
{
    public class UnitFatorial
    {

        [Fact]

        public void CalcularFat4()
        {

            Fatorial fatorial = new Fatorial();

            var retorno = fatorial.CalcFatorial(4);
            Assert.True(retorno == 24);
        }

        [Fact]

        public void CalcularFatExcecao()
        {

            Fatorial fatorial = new Fatorial();
            try
            {
                var retorno = fatorial.CalcFatorial(-4);
            }
            catch (Exception ex)
            {
                Assert.True(ex.Message == "Fatorial nao pode ser menor que 0 animal");

            }

        }

    }
}
