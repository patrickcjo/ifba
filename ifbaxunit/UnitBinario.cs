using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;

namespace ifbaxunit
{
    public class UnitBinario
    {
        [Fact]

        public void ConvertBinario()
        {
            Binario binario = new Binario();

            List<int> myValues = new List<int>(new int[] { 1, 0, 1 });

            var retorno = binario.ConvertBinario(5);
            Assert.True(retorno.SequenceEqual(myValues));

        }

        [Fact]

        public void ConvertBinario350()
        {
            Binario binario = new Binario();

            List<int> myValues = new List<int>(new int[] { 1, 0, 1, 0, 1, 1, 1, 1, 0 });

            var retorno = binario.ConvertBinario(350);
            Assert.True(retorno.SequenceEqual(myValues));

        }
    }
}
