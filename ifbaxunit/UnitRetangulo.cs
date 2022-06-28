using ifba;
using Xunit;

namespace ifbaxunit
{
    public class Testaretangulo
    {
        [Fact]
        public void CalcularAreaDoRetanguloDeveRetornarOvalorCorreto()
        {
            int resultado = 0;

            Retangulo retangulo = new Retangulo();

            retangulo.Base = 2;
            retangulo.Altura = 3;
            resultado = retangulo.CalcularArea();
            Assert.True(resultado == 6);
        }

        [Fact]
        public void CalcularPerimetroDoRetanguloDeveRetornarValorCorreto()
        {
            decimal resultado = 0;

            Retangulo retangulo = new Retangulo(2, 3);

            resultado = retangulo.CalcularPerimetro();
            Assert.True(resultado == 10);
        }
    }
}