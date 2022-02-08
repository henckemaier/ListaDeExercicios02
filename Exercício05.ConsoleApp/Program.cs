using System;

namespace Exercício05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Não sei mais o que por de título===");
            Console.ReadLine();

            Console.WriteLine("Insira o valor A: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o valor A: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            int numC;

            if (numA == numB)
            {
                numC = numA + numB;
            }
            else
            {
                numC = numA * numB;
            }

            Console.WriteLine("O resultado da variável C é: " + numC);
            Console.ReadLine();
        }
    }
}
