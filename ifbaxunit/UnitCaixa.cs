using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;

namespace ifbaxunit
{
    public class UnitCaixa
    {

        [Fact(Skip = "Not ready yet")]
        public void Saque80()
        {
            Caixa caixa = new Caixa();

            caixa.valor = 80;
            caixa.CalcularNotas();
            Assert.True(caixa.nota100 == 0 && caixa.nota50 == 1 && caixa.nota20 == 1 && caixa.nota10 == 1);
        }

        [Fact]
        public void Saque460()
        {
            Caixa caixa = new Caixa();
            caixa.valor = 460;
            caixa.CalcularNotas();
            Assert.True(caixa.nota100 == 4 && caixa.nota50 == 1 && caixa.nota20 == 0 && caixa.nota10 == 1);
        }
        [Fact]
        public void Saque130()
        {
            Caixa caixa = new Caixa();
            caixa.valor = 130;
            caixa.CalcularNotas();
            Assert.True(caixa.nota100 == 1 && caixa.nota50 == 0 && caixa.nota20 == 1 && caixa.nota10 == 1);
        }
    }
}
