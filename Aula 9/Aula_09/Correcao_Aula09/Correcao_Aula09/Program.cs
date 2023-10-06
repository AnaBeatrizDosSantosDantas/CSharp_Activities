using System;

namespace Correcao_Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Informe um número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string resultado = verPar(num1);
            Console.WriteLine(resultado);
        }

        static string verPar(int num)
        {
            string mensagem = "";

            if (num % 2 == 0)
            {
                mensagem = "Este número é PAR";
            }
            else
            {
                mensagem = "Este número é ÍMPAR";
            }

            return mensagem;
        }
    }
}
