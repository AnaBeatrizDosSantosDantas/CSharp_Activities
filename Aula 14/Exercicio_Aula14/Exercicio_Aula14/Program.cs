using System;
using System.Globalization;

namespace Exercicio_Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o valor do dólar? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Você deseja adquirir quantos dólares? ");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarReal(quant, valor);
            Console.WriteLine("O valor que deve ser pago em reais seria: R$" + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
