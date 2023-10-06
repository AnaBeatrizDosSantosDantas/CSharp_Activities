using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Aula14
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double DolarReal(double quant, double valor)
        {
            double total = quant * valor;
            return total + total * Iof / 100.0;
        }
    }
}
