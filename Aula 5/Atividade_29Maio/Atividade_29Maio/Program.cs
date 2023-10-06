using System;

namespace Atividade_29Maio
{
    class Program
    {
        static void Main(string[] args)
        {
            //LEMBRE-SE SEMPRE DA IMPORTÂNCIA DA VARIÁVEL DOUBLE, AINDA MAIS EM RAÍZ QUADRADA, SEMPRE VALE-SE LEMBRAR QUE PODE DAR NÚMERO QUEBRADO, ENTÃO ELE DEVE SER DOUBLE
            //TODA VEZ QUE VOCÊ USAR UMA VARIÁVEL TIPO DOUBLE, DEVE-SE, OBRIGATÓRIAMENTE, COLOCAR O .0 ( ISTO GARANTE A SUA NOTA).

            //ENUNCIADO DO PROBLEMA
            Console.WriteLine("EQUAÇÃO DO SEGUNDO GRAU: ");
            Console.WriteLine();
            Console.WriteLine("Lembre-se da fórmula:");
            Console.WriteLine("x = -b + ou - raíz de delta / 2.a");
            Console.WriteLine();
            Console.WriteLine("Resolva a equação sendo: ");
            double a =  1.0;
            double b = -3.0;
            double c = -4.0;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine();


            //DESCOBRINDO O VALOR DE DELTA:
            double indice = 2.0;
            double delta = Math.Pow(b, indice) - ((4 * a )* c);
            Console.WriteLine("O valor de delta é: " + delta);
            Console.WriteLine();


            //SUBSTITUINDO OS VALORES NA FÓRMULA
            Console.WriteLine("Substituindo os valores na fórmula:");
            Console.WriteLine($"x = -({b}) + ou - raíz de {delta} /2.{a}");
            Console.WriteLine();

            //RESULTADOS:
            Console.WriteLine("Resultado:");
            double xl = (-b + Math.Sqrt(delta)) / 2.0 * a;
            Console.WriteLine("xl é igual a: " + xl);
            double xll = (-b - Math.Sqrt(delta)) / 2.0 * a;
            Console.WriteLine("xll é igual a: " + xll);


        }
    }
}
