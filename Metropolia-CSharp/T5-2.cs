using System;

namespace Metropolia_CSharp
{
    internal class T5_2
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Syötä ensimmäinen numero: ");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Syötä toinen numero: ");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            if (firstValue > secondValue)
            {
                Console.WriteLine("Numero 1 on suurempi kuin numero 2.");
            } else if (firstValue < secondValue)
            {
                Console.WriteLine("Numero 2 on suurempi kuin numero 1.");
            } else if (firstValue == secondValue)
            {
                Console.WriteLine("Numerot ovat yhtä suuret.");
            }
        }
    }
}