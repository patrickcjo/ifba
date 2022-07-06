using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Fibonacci
    {

        public int n1 { get; set; }
        public int n2 { get; set; }
        public int soma { get; set; }
        public int enesimo { get; set; }

        public Fibonacci()
        {

        }

        public int CalcularFibonacci(int entrada)
        {
            n1 = 0;
            n2 = 1;
            enesimo = entrada;

            for (int i = 0; i < enesimo; i++)
            {
                soma = n1 + n2;
                n1 = n2;
                n2 = soma;
            }

            return soma;
        }


    }
}