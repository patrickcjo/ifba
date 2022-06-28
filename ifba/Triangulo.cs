using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Triangulo

    {
        public int lado1 { get; set; }
        public int lado2 { get; set; }
        public int lado3 { get; set; }

        public Triangulo()
        {

        }

        public Triangulo(int _lado1, int _lado2, int _lado3)
        {
            lado1 = _lado1;
            lado2 = _lado2;
            lado3 = _lado3;
        }

        public int CalcularPerimetro()
        {
            int perimetro = 0;
            perimetro = lado1 + lado2 + lado3;
            return perimetro;
        }

    }

}
