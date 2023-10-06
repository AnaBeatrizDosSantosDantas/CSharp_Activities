using System;
using System.Globalization;

namespace Correcao_Exercicios_Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 1
            Console.WriteLine("Correção dos Exercícios de C# - Data 26/06/2020");
            Console.WriteLine();
            Console.Write("1-) Informe um número inteiro: ");
            Console.WriteLine();
            int num = int.Parse(Console.ReadLine());
            
            if(num < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não negativo");
            }
            Console.WriteLine();
            Console.WriteLine();

            //EXERCÍCIO 2
            Console.Write("2-) Informe dois números inteiros em ordem crescente ou decrescente: ");
            Console.WriteLine();
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Múltiplos");
            }
            else
            {
                Console.WriteLine("Não São Múltiplos");
            }
            Console.WriteLine();
            Console.WriteLine();

            //EXERCÍCIO 3
            Console.Write("Informe a hora inicial e a hora final do jogo: ");
            Console.WriteLine();
            string[] horas = Console.ReadLine().Split(' ');
            int hora_inicial = int.Parse(horas[0]);
            int hora_final = int.Parse(horas[1]);
            int tempo;

            if (hora_inicial < hora_final)
            {
                tempo = hora_final - hora_inicial;
                Console.WriteLine("O jogo durou: " + tempo + "horas");
            }
            else 
            {
                tempo = 24 - hora_inicial + hora_final;
                Console.WriteLine("O jogo durou: " + tempo + "horas");
            }
            Console.WriteLine();
            Console.WriteLine();

            //EXERCÍCIO 4
            Console.Write("Informe um número qualquer com duas casas decimais depois do ponto: ");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num1 < 0.0 || num > 100.00)
            {
                Console.WriteLine("Número fora de intervalo");
            }
            else if (num1 <= 25.00)
            {
                Console.WriteLine("Dentro do intervalo [0,25]");
            }
            else if (num1 <= 50.00)
            {
                Console.WriteLine("Dentro do intervalo [25,50]");
            }
            else if (num1 <= 75.00)
            {
                Console.WriteLine("Dentro do intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Dentro do intervalo [75.100]");
            }





        }

    }
}
