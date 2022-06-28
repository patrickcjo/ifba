using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ifba;


namespace ifbaxunit
{
    public class UnitAniversario
    {

        [Fact]

        public void CalcularData()

        {
            int idadedias = 13250;
            
            Aniversario aniversario = new Aniversario(); 

            aniversario.CalcularData(idadedias);
            Assert.True(aniversario.Anos == 36);
            Assert.True(aniversario.Meses == 9);
            Assert.True(aniversario.Dias == 2);            
        }

        [Fact]
        public void CalcularData2()

        {
            int idadedias = 13165;

            Aniversario aniversario = new Aniversario();

            aniversario.CalcularData(idadedias);
            Assert.True(aniversario.Anos == 36);
            Assert.True(aniversario.Meses == 2);
            Assert.True(aniversario.Dias == 1);
        }
    }
}
