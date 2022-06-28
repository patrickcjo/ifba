using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ifba;


namespace ifbaxunit
{
    public class UnitDivisao
    {
        [Fact]

        public void CalcularDivisao20_5()
        { 

            Divisao divisao = new Divisao();

            divisao.dividendo = 20;
            divisao.divisor = 5;
            divisao.CalcularDivisao();
            divisao.CalcularResto();
            Assert.True(divisao.resto == 0);
            Assert.True(divisao.quociente == 4);
        }

        [Fact]

        public void CalcularDivisao98_4()
        {

            Divisao divisao = new Divisao();

            divisao.dividendo = 98;
            divisao.divisor = 4;
            divisao.CalcularDivisao();
            divisao.CalcularResto();
            Assert.True(divisao.resto == 2);
            Assert.True(divisao.quociente == 24);
        }
    }
}
