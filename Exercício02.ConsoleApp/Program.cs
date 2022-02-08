using System;

namespace Exercício02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("=====Ordenação de números inteiros===== ");
            Console.ReadLine();

            
            Console.Write("Digite o valor A: ");
            string valorA = Console.ReadLine();

            int numA = Convert.ToInt32(valorA);

            Console.Write("Digite o valor B: ");
            string valorB = Console.ReadLine();

            int numB = Convert.ToInt32(valorB);

            Console.Write("Digite o valor C: ");
            string valorC = Console.ReadLine();

            int numC = Convert.ToInt32(valorC);

            int ordem;

            if (numA < numB)
            {
                ordem = numA;
                numA = numB;
                numB = ordem;
            }
            if (numB < numC)
            {
                ordem = numB;
                numB = numC;
                numC = ordem;
            }
            if (numA < numB)
            {
                ordem = numA;
                numA = numB;
                numB = ordem;
            }

            Console.WriteLine("Os número em ordem decrescente são: " + numA + " " + numB + " " + numC);
            Console.ReadLine();
        }
    }
}
