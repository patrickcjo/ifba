using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifba;
using Xunit;

namespace ifbaxunit
{
    public class UnitFibonacci
    {
        [Fact]

        public void CalcularFibonacci7()
        { 
        
            Fibonacci fibonacci = new Fibonacci();

            int resultado = fibonacci.CalcularFibonacci(7);
            Assert.True(resultado == 21);
        }

        [Fact]

        public void CalcularFibonacci0()
        {

            Fibonacci fibonacci = new Fibonacci();

            int resultado = fibonacci.CalcularFibonacci(0);
            Assert.True(resultado == 0);
        }

        [Fact]

        public void CalcularFibonacci1()
        {

            Fibonacci fibonacci = new Fibonacci();

            int resultado = fibonacci.CalcularFibonacci(1);
            Assert.True(resultado == 1);
        }
        [Fact]

        public void CalcularFibonacci2()
        {

            Fibonacci fibonacci = new Fibonacci();

            int resultado = fibonacci.CalcularFibonacci(2);
            Assert.True(resultado == 1);
        }
    }
}
