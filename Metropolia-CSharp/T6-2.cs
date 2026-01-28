using System;

namespace Metropolia_CSharp
{
    internal class T6_2
    {
        public static void Run(string[] args)
        {
            int sum = 0;
            while (sum < 200)
            {
                Console.Write($"Summa on nyt {sum}. Syöte: ");
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Saavutettiin 200. Summa oli {sum}.");
        }
    }
}