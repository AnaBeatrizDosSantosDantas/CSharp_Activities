using System;
using System.Globalization;

namespace Exercicio1_Aula13
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2.00) + Math.Pow(Altura, 2.00));
        }

        public override string ToString()
        {
            return Area().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
