using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;

namespace ifbaxunit
{
    public class UnitNumeros
    {
        [Fact]

        public void NFelizes130()
        {
            var resultado = Numeros.Ehfeliz(130);
            Assert.True(resultado == 10);
        }
    }
}
