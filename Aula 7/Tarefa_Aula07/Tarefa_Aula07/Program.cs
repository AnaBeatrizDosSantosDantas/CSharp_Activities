using System;
using System.Globalization;

namespace Tarefa_Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA
            //Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho,
            //e depois mostrar os dados na tela.
            Console.WriteLine("TAREFA");
            Console.WriteLine();
            Console.WriteLine("Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho," + 
            " e depois mostrar os dados na tela:");
            Console.WriteLine();
            Console.WriteLine("Entre com seu nome completo: ");
            string nome_completo = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int numero_quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco_produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');
            string ultimo_nome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SAÍDA ESPERADA (NÚMEROS REAIS COM DUAS CASAS DECIMAIS): ");
            Console.WriteLine();
            Console.WriteLine(nome_completo);
            Console.WriteLine(numero_quartos);
            Console.WriteLine(preco_produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimo_nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
