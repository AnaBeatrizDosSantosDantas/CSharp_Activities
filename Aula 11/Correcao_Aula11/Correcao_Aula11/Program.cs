using System;
using System.Globalization;

namespace Correcao_Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números você deseja testar?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.Write("Informe três valores reais separados por espaço - TESTE #{0}: ", i);
                string[] testes = Console.ReadLine().Split(' ');
                double a = double.Parse(testes[0], CultureInfo.InvariantCulture);
                double b = double.Parse(testes[1], CultureInfo.InvariantCulture);
                double c = double.Parse(testes[2], CultureInfo.InvariantCulture);
                double media = (a * 2.0) + (b * 3.0) + (c * 5.0) / 10;
                Console.WriteLine();
                Console.WriteLine("A média ponderada dos valores informados é: "
                    + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }

        }
    }
}
