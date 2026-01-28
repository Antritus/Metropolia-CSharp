using System;

namespace Metropolia_CSharp
{
    internal class T5_1
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Syötä ikäsi, ole hyvä: ");
            string userInput = Console.ReadLine();
            if (Int32.Parse(userInput) >= 18)
            {
                Console.WriteLine("Voit äänestää!");
            }
        }
    }
}