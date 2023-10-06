using System;
using System.Globalization;

namespace Exercicio_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {

            funcionario primeiro_funcionario = new funcionario();
            funcionario segundo_funcionario = new funcionario();

            Console.WriteLine("Exercício C# - Cálculo médio do salário");
            Console.WriteLine();


            Console.Write("Informe o nome do(a) primeiro(a) funcionário(a): ");
            primeiro_funcionario.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Informe o salário do(a) primeiro(a) funcionário(a): ");
            primeiro_funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Informe o nome do(a) segundo(a) funcionário(a): ");
            segundo_funcionario.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Informe o salário do(a) segundo(a) funcionário(a): ");
            segundo_funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine();

            double media_salario = (primeiro_funcionario.Salario + segundo_funcionario.Salario) / 2.0;
            Console.WriteLine("O salário médio é igual a =  " + media_salario);

        }
    }
}
