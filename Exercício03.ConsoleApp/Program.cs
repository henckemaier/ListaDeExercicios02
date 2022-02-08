using System;

namespace Exercício03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Calculador IMC====");
            Console.ReadLine();

            Console.Write("Digite a sua altura: ");
            string altura = Console.ReadLine();

            double alt = Convert.ToDouble(altura);

            Console.Write("Digite a seu peso: ");
            string peso = Console.ReadLine();

            double pes = Convert.ToDouble(peso);

            ///////////////////////

            double IMC;

            IMC = pes / (alt * alt);

            ////////////////////////

            if (IMC < 18.5)
            {
            Console.WriteLine("Seu resultado foi: Abaixo de peso");
            Console.ReadLine();
            }
            else if (IMC > 18.5 && IMC <= 25)
            {
                Console.WriteLine("Seu resultado foi: Peso normal");
                Console.ReadLine();
            }
            else if (IMC > 25 && IMC <= 30)
            {
                Console.WriteLine("Seu resultado foi: Acima do peso");
                Console.ReadLine();
            }
            else if (IMC > 30)
            {
                Console.WriteLine("Seu resultado foi: Obeso");
                Console.ReadLine();
            }
        }
    }
}
