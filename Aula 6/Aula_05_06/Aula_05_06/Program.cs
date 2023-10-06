using System;
using System.Dynamic;

namespace Aula_05_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AULA 6 - DIA 05/06/2020 - EXPLICAÇÃO");
            Console.WriteLine();
            //ENTRADA DE DADOS EM C#      //LEMBRE-SE QUE QUEBRA DE LINHA SERIA APERTAR A TECLA ENTER

            Console.WriteLine("ENTRADA DE DADOS EM C#: ");
            Console.WriteLine();
            //EXEMPLO 1 
            Console.WriteLine("EXEMPLO 1:");
            Console.Write("Digite uma palavra qualquer: ");
            string a = Console.ReadLine();   //Console.ReadLine só serve para variável string, LEMBRE-SE!!
            Console.WriteLine();
            Console.WriteLine("Você digitou: " + a);
            Console.WriteLine();

            //O .Parse serve para você fazer com que a váriavel string que o usuário digitou (sempre será string) converta-se para o tipo
            //da variável que você deseja.

            //EXEMPLO 2
            Console.WriteLine("EXEMPLO 2:");
            Console.WriteLine("Digite dois núemeros, um double e um inteiro");
            Console.WriteLine();
            Console.Write("Digite o número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite o número double: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Você digitou: " + num);
            Console.WriteLine("Você digitou: " + num2);
            Console.WriteLine();
            Console.WriteLine();

            //COMANDO SPLIT
            //PEGA A STRING E DIVIDE EM PARTES MENORES
            Console.WriteLine("COMANDO SPLIT:");
            Console.WriteLine();
            Console.WriteLine("Informe o nome de três vegetais, que devem estar separados por espaço:");
            string s = Console.ReadLine();
            string[] vegetais = s.Split(' ');
            string p1 = vegetais[0];
            string p2 = vegetais[1];
            string p3 = vegetais[2];
            Console.WriteLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine("Ocorrência 1 = " + p1);
            Console.WriteLine("Ocorrência 2 = " + p2);
            Console.WriteLine("Ocorrência 3 = " + p3);
            Console.WriteLine();
            Console.WriteLine();

            //COMANDO SPLIT - MELHORADO
            Console.WriteLine("COMANDO SPLIT MELHORADO");
            Console.WriteLine();
            Console.WriteLine("Informe o nome de três vegetais, que devem estar separados por traço:");
            string [] vegetais2 = Console.ReadLine().Split('-');
            string p1exemplo2 = vegetais2[0];
            string p2exemplo2 = vegetais2[1];
            string p3exemplo2 = vegetais2[2];
            Console.WriteLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine("Ocorrência 1 = " + p1exemplo2);
            Console.WriteLine("Ocorrência 2 = " + p2exemplo2);
            Console.WriteLine("Ocorrência 3 = " + p3exemplo2);
        }
    }
}
