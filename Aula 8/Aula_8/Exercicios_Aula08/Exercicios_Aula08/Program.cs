using System;
using System.Globalization;

namespace Exercicios_Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 1 - Fazer um programa para ler m número inteiro, e depois dizer se ele é negativo ou não.
            Console.WriteLine("Exercícios Aula 8 de C#  -  Data: 26/06/2020");
            Console.WriteLine();
            Console.WriteLine("Exercício 1 - Fazer um programa para ler um número inteiro," +
            " e depois dizer se ele é negativo ou não.");
            Console.WriteLine();

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (numero < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não negativo");
            }
            Console.WriteLine();
            Console.WriteLine();


            //EXERCÍCIO 4 - Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem
            //dizendo em qual dos seguintes intervalos ([0,25], [25,50], [50,75], [75,100]) este valor se encontra.
            //Obviamente, se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem
            //"Fora de intervalo".

            Console.WriteLine("Exercício 4 - Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem" +
            " dizendo em qual dos seguintes intervalos ([0,25], [25,50], [50,75], [75,100]) este valor se encontra." +
            "Obviamente, se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem" +
            " 'Fora de intervalo'.");
            Console.WriteLine();
            Console.Write("Digite um valor qualquer com duas casas decimais após o ponto final: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine();


            if (valor > 0.0 && valor <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor > 25.0 && valor <= 50.0)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (valor > 50.0 && valor <= 75.0)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (valor > 75.0 && valor <= 100.0)
            {
                Console.WriteLine("Intervalo [75, 100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }


        }
    }
}
