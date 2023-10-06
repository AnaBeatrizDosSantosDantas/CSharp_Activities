using System;
using System.Globalization;

namespace Exercicio1_Aula13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a largura e a altura do retângulo:");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            //Teste do construtor = Ok!
            //Retangulo retangulo = new Retangulo(10.0, 5.0);
            //Console.WriteLine(retangulo);

            Retangulo retangulo = new Retangulo(largura, altura);
            Console.WriteLine("ÁREA = " + retangulo);
            Console.WriteLine("PERÍMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
