using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;

namespace ifbaxunit
{
    public class UnitPA
    {
        [Fact]

        public void CalcularSeEh()
        {
            List<int> list = new List<int>() { 1, 3, 5, 7, 9 , 11 , 13};
            PA pa = new PA();
            Assert.True(pa.CalcularPA(list) == true);
        }

        [Fact]

        public void CalcularSeEhPA()
        {
            List<int> list = new List<int>() { 1, 3, 5, 7, 9, 11, 16 };
            PA pa = new PA();
            Assert.True(pa.CalcularPA(list) == false);
        }
    }
}
