using System;

namespace Exercicio1_Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1 - Aula 10 C# - 10/07/2020");
            Console.WriteLine();
            Console.Write("Informe a senha para obter acesso ao sistema: ");

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine();
                Console.WriteLine("Senha Inválida.");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Informe outra senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Acesso Permitido.");
        }
    }
}
