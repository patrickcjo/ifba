using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;


namespace ifbaxunit
{
    public class UnitVolume
    {
        [Fact]
        public void CalcularVolumeR3H5()
        {
            Volume cilindro = new Volume();
            double volume = 0;
            cilindro.raio = 3;
            cilindro.altura = 5;
            volume = cilindro.CalcularVolume();
            Assert.True(Math.Round(volume, 2) == 141.37);
        }
    }
}
