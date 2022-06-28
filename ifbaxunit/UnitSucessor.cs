using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ifba;

namespace ifbaxunit
{
    public class UnitSucessor
    {
        [Fact]

        public void NumeroSucessor()
        {
            int sucessor = 0;

            Sucessor proximo = new Sucessor();
          
            sucessor = proximo.NumeroSucessor(3);
            Assert.True(sucessor == 4);
        }
        [Fact]

        public void NumeroSucessor5()
        {
            int sucessor = 0;

            Sucessor proximo = new Sucessor();

            sucessor = proximo.NumeroSucessor(4);
            Assert.True(sucessor == 5);
        }
    }
}
