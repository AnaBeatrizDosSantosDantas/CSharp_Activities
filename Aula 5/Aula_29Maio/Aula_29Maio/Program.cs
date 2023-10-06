using System;

namespace Aula_29Maio
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES ARITMÉTICOS
            //ADIÇÃO (+), SUBTRAÇÃO (-), MULTIPLICAÇÃO (*), DIVISÃO (/), RESTO DA DIVISÃO OU MOD (%)
            Console.WriteLine("OPERADORES ARITMÉTICOS:");
            Console.WriteLine();
            int a;
            int b;
            int c;
            a = 3 + 4 * 2;
            b = (3 + 4) * 2;
            c = ((3 + 4) * (2 + 5)) / 3;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine();

            //se eu atribuir um valor a uma variável, e depois fazer outra conta com a mesma variável, o valor
            //prevalecerá será o da última variável

            //Exemplo:
            //int a;
            //a = 3 + 4 * 2;
            //a = (3 + 4) * 2;
            //Console.WriteLine(a);
            //Console.WriteLine(a);
            //O resultado aparecerá 14 duas vezes, ignorando o primeiro a, que daria 11, já que a última variável prevalece

            //OPERADORES DE ATRIBUIÇÃO (COPIAR DO POWER POINT TODOS COMO NA LINHA 10
            Console.WriteLine("OPERADORES DE ATRIBUIÇÃO:");
            Console.WriteLine();
            int d = 10;
            Console.WriteLine(d);
            d += 2;
            Console.WriteLine(d);
            d -= 2;
            Console.WriteLine(d);
            d *= 2;
            Console.WriteLine(d);
            d /= 2;
            Console.WriteLine(d);
            d %= 2;      //O resultado seria 0
            Console.WriteLine(d);
            d %= 3;     //O resultado seria 1
            Console.WriteLine(d);

            string texto = "ABC";
            Console.WriteLine(texto);
            texto += "DEF";
            Console.WriteLine(texto);
            Console.WriteLine();


            //OPERADORES ARITMÉTICOS / ATRIBUIÇÃO
            Console.WriteLine("OPERADORES ARITMÉTICOS / ATRIBUIÇÃO");
            Console.WriteLine();

            //EXEMPLO 1:
            Console.WriteLine("EXEMPLO 1:");
            int a1 = 10;
            a1++;
            Console.WriteLine(a1);
            Console.WriteLine();
            Console.WriteLine();

            //EXEMPLO 2:
            Console.WriteLine("EXEMPLO 2:");
            int e = 10;
            Console.WriteLine("Valor original de e: " + e);
            int f = e++;
            Console.WriteLine("Mostrando o valor da variável e, depois que ela foi incrementada: " + e);
            Console.WriteLine(f);
            Console.WriteLine();
            Console.WriteLine();

            //EXEMPLO 3:
            Console.WriteLine("EXEMPLO 3:");
            int e2 = 10;
            Console.WriteLine("Valor original de e: " + e2);
            int f2 = ++e2;
            Console.WriteLine("Mostrando o valor da variável e, depois que ela foi incrementada: " + e2);
            Console.WriteLine(f2);
            Console.WriteLine();

            //CONVERSÃO IMPLÍCITA:
            Console.WriteLine("CONVERSÃO IMPLÍCITA:");
            Console.WriteLine("");

            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);
            Console.WriteLine();


            //pegando uma variavel double e armazenando em uma variável float
            double i = 5.1;
            float j = (float)i;
            Console.WriteLine(j);
            Console.WriteLine();

            //pegando uma variavel double e armazenando em uma variável int (que irá acabar com o decimal
            double i2 = 5.1;
            int j2 = (int)i2;
            Console.WriteLine(j2);

            //CASTING:
            Console.WriteLine("CASTING: ");

            int k = 5;
            int l = 2;
            double resultado = k / l;
            Console.WriteLine(resultado);

            Console.WriteLine("EXEMPLO 2:");
            int k2 = 5;
            int l2 = 2;
            double resultado2 = (double)k2 / l2;
            Console.WriteLine(resultado2);


            Console.WriteLine("TESTANDO A TEORIA EM UM NOVO PROGRAMA:");
            Console.WriteLine();

            Console.WriteLine("~FUNÇÕES MATEMÁTICAS:");
            Console.WriteLine("POTENCIAÇÃO:");
            //POTENCIAÇÃO
            double a3 = 9;
            double indice = 2;
            double resultado3 = Math.Pow(a3, indice);
            Console.WriteLine(resultado3);

            double raiz = Math.Sqrt(resultado3);
            Console.WriteLine(raiz);
        }
    }
}
