using System;

namespace Aula_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo 1 ");
            int a = 10;
            bool c1 = a < 10;
            Console.WriteLine(c1);//FALSE
            Console.WriteLine();

            //OPERADORES LÓGICOS
            Console.WriteLine("OPERADORES LÓGICOS");
            bool c5 = 2 > 3 || 4!=5; //TRUE
            Console.WriteLine(c5);
            bool c6 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c6);

        }
    }
}
