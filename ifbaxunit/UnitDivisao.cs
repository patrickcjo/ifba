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
            divisao.CalcularDivisao(20, 5);
            divisao.CalcularResto(20, 5);
            Assert.True(divisao.resto == 0);
            Assert.True(divisao.quociente == 4);
        }

        [Fact]

        public void CalcularDivisao98_4()
        {
            Divisao divisao = new Divisao();
            divisao.CalcularDivisao(98, 4);
            divisao.CalcularResto(98, 4);
            Assert.True(divisao.resto == 2);
            Assert.True(divisao.quociente == 24);
        }
    }
}
