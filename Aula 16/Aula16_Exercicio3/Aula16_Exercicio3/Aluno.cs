using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula16_Exercicio3
{
    class Aluno
    {
        private string _nome;
        private double _nota1;
        private double _nota2;
        private double _nota3;

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

        public double Nota1
        {
            get { return _nota1; }
            set
            {
                if (value != 0 && value > 1)
                {
                    _nota1 = value;
                }
            }
        }

        public double Nota2
        {
            get { return _nota2; }
            set
            {
                if (value != 0 && value > 1)
                {
                    _nota2 = value;
                }
            }
        }

        public double Nota3
        {
            get { return _nota3; }
            set
            {
                if (value != 0 && value > 1)
                {
                    _nota3 = value;
                }
            }
        }


        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}