using System;

namespace ExercícioTabuada_Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Exerício 1 - Aula 11 C# - 17/07/2020");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Informe a primeira tabuada: ");
            int tab_inicio = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Informe a última tabuada: ");
            int tab_fim = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine();

            while (tab_inicio <= tab_fim)
            {
                while (num <= 10)
                {

                    Console.WriteLine(tab_inicio + " X " + num + " = " + tab_inicio * num);
                    num++;

                }
                tab_inicio++;
                num = 1;
                Console.WriteLine();
            }

        }
    }
}

