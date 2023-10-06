using System;

namespace Exercicio3_Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 3 - Aula 10 C# - 10/07/2020");
            Console.WriteLine();
            Console.Write("Informe sua preferência de combustível - 1.Álcool 2.Gasolina 3.Diesel 4.Para finalizar o programa: ");
            int preferencia_cliente = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (preferencia_cliente != 4)

            {
                while (preferencia_cliente < 1 || preferencia_cliente > 4)
                {
                    Console.WriteLine();
                    Console.Write("O número que você informou é inválido. Informe novamente ou encerre o programa apertando a tecla 4: ");
                    preferencia_cliente = int.Parse(Console.ReadLine());
                }
                while (preferencia_cliente == 1) //QUANDO A PREFERÊNCIA FOR ALCOOL
                {
                    alcool++;
                    Console.WriteLine();
                    Console.Write("Informe sua preferência de combustível - 1.Álcool 2.Gasolina 3.Diesel 4.Para finalizar o programa: ");
                    preferencia_cliente = int.Parse(Console.ReadLine());
                }
                while (preferencia_cliente == 2)//QUANDO A PREFERÊNCIA FOR GASOLINA
                {
                    gasolina++;
                    Console.WriteLine();
                    Console.Write("Informe sua preferência de combustível - 1.Álcool 2.Gasolina 3.Diesel 4.Para finalizar o programa: ");
                    preferencia_cliente = int.Parse(Console.ReadLine());
                }
                while (preferencia_cliente == 3)//QUANDO A PREFERÊNCIA FOR DIESEL
                {
                    diesel++;
                    Console.WriteLine();
                    Console.Write("Informe sua preferência de combustível - 1.Álcool 2.Gasolina 3.Diesel 4.Para finalizar o programa: ");
                    preferencia_cliente = int.Parse(Console.ReadLine());
                }



            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Muito Obrigado(a).");
            Console.WriteLine();
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);


        }

    }
}
