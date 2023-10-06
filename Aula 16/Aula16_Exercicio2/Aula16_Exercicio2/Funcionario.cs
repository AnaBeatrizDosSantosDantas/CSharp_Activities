using System;
using System.Globalization;

namespace Aula16_Exercicio2
{
    class Funcionario
    {
        private string _nome;
        private double _salariobruto;
        private double _imposto;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double SalarioBruto
        {
            get { return _salariobruto; }
            set
            {
                if (value != 0 && value > 1)
                {
                    _salariobruto = value;
                }
            }
        }

        public double Imposto
        {
            get { return _imposto; }
            set
            {
                if (value != 0 && value > 1)
                {
                    _imposto = value;
                }
            }
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
