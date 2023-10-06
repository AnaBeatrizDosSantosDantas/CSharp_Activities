using System;
using System.Globalization;
using System.Text;

namespace Aula_10
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int contador = 1;
            Console.Write("Informe um número para iniciar a série: ");
            int num = int.Parse(Console.ReadLine());

            while (contador <= 50)
            {
                Console.WriteLine(num);
                num++;
                contador++;
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Informe um número para descobrir sua raíz quadrada: ");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (num1 >= 0.00)
            {
                double raiz = Math.Sqrt(num1);
                Console.WriteLine("A raíz quadrada de " + num1.ToString("F3", CultureInfo.InvariantCulture) + " é igual a: " + raiz.ToString("F3", CultureInfo.InvariantCulture));

                Console.WriteLine("Informe outro número: ");
                num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            }
            Console.WriteLine();
            Console.WriteLine("Foi informado um número negativo.");



        }
    }
}
