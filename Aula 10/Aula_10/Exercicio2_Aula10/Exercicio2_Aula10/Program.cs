using System;

namespace Exercicio2_Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2 - Aula 10 C# - 10/07/2020");
            Console.WriteLine();
            Console.Write("Informe as coordenadas x e y, respectivamente, separadas por espaço "
                + " para saber a qual quadrante pertencem: ");
            string[] coordenadas = Console.ReadLine().Split(' ');
            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                while (x > 0 && y > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Essas coordenadas pertencem ao: Primeiro Quadrante.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Informe as coordenadas x e y, respectivamente, separadas por espaço "
                + " para saber a qual quadrante pertencem: ");
                    coordenadas = Console.ReadLine().Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);

                }

                while (x < 0 && y < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Essas coordenadas pertencem ao: Terceiro Quadrante.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Informe as coordenadas x e y, respectivamente, separadas por espaço "
               + " para saber a qual quadrante pertencem: ");
                    coordenadas = Console.ReadLine().Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);
                }

                while (x < 0 && y > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Essas coordenadas pertencem ao: Segundo Quadrante.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Informe as coordenadas x e y, respectivamente, separadas por espaço "
               + " para saber a qual quadrante pertencem: ");
                    coordenadas = Console.ReadLine().Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);


                }

                while (x > 0 && y < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Essas coordenadas pertencem ao: Quarto Quadrante.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Informe as coordenadas x e y, respectivamente, separadas por espaço "
                + " para saber a qual quadrante pertencem: ");
                    coordenadas = Console.ReadLine().Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);


                }

            }
            Console.WriteLine();
            Console.WriteLine("Um dos números indicados foi nulo. Fim do programa.");

        }
    }
}

