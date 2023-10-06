using System;
using System.Collections.Generic;
using System.Text;

namespace Aula16_Exercicio1
{
    class Retangulo
    {
        private double _largura;
        private double _altura;

        public double Largura
        {
            get { return _largura; }
            set
            {
                if (value != 0 && value > 1)
                {
                    _largura = value;
                }
            }
        }

        public double Altura
        {
            get { return _altura; }
            set
            {
                if (value != 0 && value > 1)
                {
                    _altura = value;
                }
            }
        }

        public double Area()
        {
            return (Largura * Altura);
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2.00) + Math.Pow(Altura, 2.00));
        }
    }
}