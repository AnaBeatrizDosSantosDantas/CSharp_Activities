using System;
using System.Globalization;

namespace Aula_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno aluno = new Aluno(nome, nota1, nota2, nota3);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
