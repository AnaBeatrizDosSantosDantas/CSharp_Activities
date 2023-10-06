using System;

namespace Atividade_Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade da aula 6 de C# - dia 05/06/2020");
            Console.WriteLine();
            Console.WriteLine("Prática 1: Checklist");
            Console.WriteLine();

            //PASSO 1: Leia um texto (frase) até a quebra de linha e armazene em uma váriavel
            Console.Write("1-) Digite um texto (frase) de sua preferência: ");
            string frase = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Você digitou a seguinte frase: " + frase);
            Console.WriteLine();
            Console.WriteLine();

            //PASSO 2: Leia três palavras, uma em cada linha, armazenando cada uma em uma váriavel
            Console.WriteLine("2-) Digite três palavras (cores): ");
            Console.WriteLine();
            Console.Write("Digite a cor 1: ");
            string x = Console.ReadLine();
            Console.Write("Digite a cor 2: ");
            string y = Console.ReadLine();
            Console.Write("Digite a cor 3: ");
            string z = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("A cor 1 que você digitou é: " + x);
            Console.WriteLine("A cor 2 que você digitou é: " + y);
            Console.WriteLine("A cor 3 que você digitou é: " + z);
            Console.WriteLine();
            Console.WriteLine();

            //PASSO 3: Leia três palavras na mesma linha, separadas por espaço, armazenando cada uma em uma váriavel

            Console.WriteLine("3-) Digite o nome de três palavras (cores), que devem estar separadas por espaço:");
            string[] palavras = Console.ReadLine().Split(' ');
            string a = palavras[0];
            string b = palavras[1];
            string c = palavras[2];
            Console.WriteLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine("Ocorrência 1 = " + a);
            Console.WriteLine("Ocorrência 2 = " + b);
            Console.WriteLine("Ocorrência 3 = " + c);
        }
    }
}
