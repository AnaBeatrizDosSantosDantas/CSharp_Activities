using System;

namespace CorrigirTarefaAula6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite <Bom dia>: ");
            string frase = Console.ReadLine();
            Console.Write("Digite três palavras e tecle enter após informar cada uma - <Vermelho>, " +
                "<Verde> e <Azul>: ");

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.Write("Digite três palavras separadas por espaço e depois tecle enter <Amarelo>, " +
                "<Laranja> e <Cinza>");
            string[] cores = Console.ReadLine().Split(' ');
            string a = cores[0];
            string b = cores[1];
            string c = cores[2];
            Console.WriteLine();

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
