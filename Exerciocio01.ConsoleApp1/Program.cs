using System;

namespace Exercício01.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("=====Calculo e comparação===== ");
            Console.ReadLine();

            Console.Write("Digite o valor A: ");
            string valorA = Console.ReadLine();

            decimal numA = Convert.ToDecimal(valorA);

            Console.Write("Digite o valor B: ");
            string valorB = Console.ReadLine();

            decimal numB = Convert.ToDecimal(valorB);

            Console.Write("Digite o valor C: ");
            string valorC = Console.ReadLine();

            decimal numC = Convert.ToDecimal(valorC);

            decimal resultado = numA + numB;

            if(numC > resultado)
            {
                Console.Write("A soma de A+B é menor que a C");
                Console.ReadLine();
            }
            else
            {
                Console.Write("A soma de A+B é maior que a C");
                Console.ReadLine();
            }
        }
    }
}
