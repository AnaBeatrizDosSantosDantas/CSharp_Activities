using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula_15
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public Funcionario(string nome, double salariobruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salariobruto;
            Imposto = imposto;

        }

        public Funcionario()
        {
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem) / 100.0;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
