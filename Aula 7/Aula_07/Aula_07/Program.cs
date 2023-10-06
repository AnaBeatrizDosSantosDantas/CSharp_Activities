using System;
using System.Globalization;

namespace Aula_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //ATIVIDADES
            Console.WriteLine("Atividades da Aula 7 de C# - dia 19/06/2020");
            Console.WriteLine();

            //EXERCÍCIO 1 - TRANSFORMANDO UMA DATA NO FORMATO DOS EUA PARA O FORMATO BRASILEIRO
            Console.Write("1-) Digite uma data no formato dos EUA, ou seja, [MM/DD/AAAA] separadas por barra ( / ), e em seguida tecle <enter>: ");
            string[] data = Console.ReadLine().Split('/');
            string mes = data[0];
            string dia = data[1];
            string ano = data[2];
            Console.WriteLine();
            Console.WriteLine("A data que você informou é: " + mes + "/" + dia + "/" + ano);
            Console.WriteLine();
            Console.WriteLine("Esta data no formato brasileiro, ou seja [DD/MM/AAAA], transforma-se para: " + dia + "/" + mes + "/" + ano);
            Console.WriteLine();
            Console.WriteLine();

            //EXEMPLO 2 - 
            Console.WriteLine("2-) Saída de dados – Exemplo de fixação ");
            Console.WriteLine();
            Console.WriteLine("a-) Informe um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("b-) Informe uma letra qualquer ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("c-) Informe um número double, com casas após o ponto decimal: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("d-) Informe um nome, sexo <F ou M>, idade e altura, na mesma linha e separados por espaço" +
            " e só depois tecle <enter>.");

            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine("Um número inteiro: " + n1);
            Console.WriteLine("Uma letra qualquer: " + ch);
            Console.WriteLine("Um número double: " + n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Um nome: " + nome);
            Console.WriteLine("Informou o sexo da pessoa: " + sexo);
            Console.WriteLine("Informou a idade da pessoa: " + idade);
            Console.WriteLine("Informou a altura da pessoa: " + altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
