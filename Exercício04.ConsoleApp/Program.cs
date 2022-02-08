using System;

namespace Exercício04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Identificador de Par/Impar===");
            Console.ReadLine();

            Console.Write("Digite o seu número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.Write("O número " + num + " é par");
                Console.ReadLine();
            }
            else
            {
                Console.Write("O número " + num + " é ímpar");
                Console.ReadLine();
            }

        }
    }
}
