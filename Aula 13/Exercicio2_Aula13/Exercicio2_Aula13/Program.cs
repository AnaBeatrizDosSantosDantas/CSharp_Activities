using System;
using System.Globalization;

namespace Exercicio2_Aula13
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
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
