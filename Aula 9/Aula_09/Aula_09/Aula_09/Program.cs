using System;

namespace Aula_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int resultado = MaiorInteiro(n1, n2, n3);
            Console.WriteLine("O número maior é igual a: " + resultado);
            
            //Outro modo de fazer a mesma coisa sem o usuário digitar os valores
            //Console.WriteLine();
            //Console.WriteLine("Verificando outros números: ");
            //int resultado2 = MaiorInteiroInteiro(25, 64, 55);
            //Console.WriteLine("O número maior do segundo teste é igual a: " + resultado2);

        }

        static int MaiorInteiro(int a, int b, int c)
        {
            int maior;

            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            return maior;

        }
    }
}
