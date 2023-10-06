using System;
using System.Globalization;

namespace Aula_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            double salariobruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Funcionario funcionario = new Funcionario(nome, salariobruto, imposto);

            Console.WriteLine("Funcionário: " + funcionario);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem_declarada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentarSalario(porcentagem_declarada);
            Console.WriteLine();

            Console.Write("Dados atualizados: " + funcionario);
            Console.WriteLine();

        }
    }
}

