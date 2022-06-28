using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifba
{
    public class Aniversario
    {
        public double Anos { get; set; }
        public double Meses { get; set; }
        public double Dias { get; set; }

        public void CalcularData(int idadedias)
        {

            Anos = Math.Round(idadedias / 365.0);
            Meses = Math.Round((idadedias % 365.0) / 12);
            Dias = (idadedias % 365.0) % 12;
        }
    }
}
