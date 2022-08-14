using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;

namespace ifbaxunit
{
    public class UnitClimaTempo
    {

        [Fact]

        public void CalcularMedia()
        {
            List<int> tempo = new List<int>() { 21, 20, 34, 12, 20, 21, 21, 27, 27, 35, 14, 29, 21, 25, 26, 21, 30, 27, 22, 28, 18, 13, 33, 13, 19, 19, 27, 17, 17, 23, 15, 22, 12, 20, 31, 22, 20, 34, 14, 26, 24, 28, 17, 23, 23, 23, 13, 18, 19, 18 };

            ClimaTempo clima = new ClimaTempo();
            clima.CalcularTemp(tempo);
            Assert.True(clima.maiorTemp == 35);
            Assert.True(clima.menorTemp == 12);
            Assert.True(ClimaTempo.CalcularMedia(tempo) == 22.0);
        }
    }
}
