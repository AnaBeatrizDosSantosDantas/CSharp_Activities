using System;
using System.Globalization;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {

            String nome = "Sérgio R. Souza";
            Object obj1 = "Sérgio Souza";
            Object obj2 = 4.5f;
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int n1 = int.MaxValue;
            int n2 = int.MinValue;
            int n3 = 2147483646;
            n3++;
            sbyte n4 = sbyte.MinValue;
            sbyte n5 = sbyte.MaxValue;
            decimal n6 = decimal.MaxValue;
            decimal n7 = decimal.MinValue;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);

            int salario_do_funcionario = 500;
            Console.WriteLine(salario_do_funcionario);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("saída de dados!!");
            double x = 10.35784;
            int y = 55;
            char sexo = 'F';
            Console.WriteLine(y);
            Console.WriteLine(sexo);
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));  //tem que ser F, mostra quantas casas depois da , tu quer mostrar

            //função que desliga a configuração de idioma do pc, fazendo com que assuma o padrão original da linguagem
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            //ESCREVENDO MENSAGENS
            Console.WriteLine();
            double saldo = 910.35784;
            int idade = 55;

            Console.WriteLine();

            //Método PLACEHOLDER
            Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} Reais.", nome, idade, saldo);

            Console.WriteLine();

            //Método de INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual a {saldo:F2} Reais.");

            Console.WriteLine();

            //Método CONTATENAÇÃO = JUNTAR
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " Reais.");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " Reais.");
        }
    }
}
