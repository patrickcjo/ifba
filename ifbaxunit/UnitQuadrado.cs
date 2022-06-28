using ifba;
using Xunit;

namespace ifbaxunit
{
    public class TestaQuadrado
    {

        [Fact]

        public void CalcularAreaDoQuadradoDeveRetornarOValorCorreto()
        { 
            int resultado = 0;  

            Quadrado quadrado = new Quadrado();

            quadrado.Lado = 2;
            resultado = quadrado.CalcularAreaQuadrado();
            Assert.True(resultado == 4);
        }

        [Fact]
        public void CalcularPerimetroDoQuadradoDeveRetornaroValorCorreto()
        {

            int resultado = 0;
            Quadrado Quadrado = new Quadrado(); 
            Quadrado.Lado = 4;
            resultado = Quadrado.CalcularPerimetroQuadrado();
            Assert.True(resultado >= 16);
        }
    }
}
