using System;

namespace Metropolia_CSharp
{
    internal class T3_2
    {
        public static void Run(string[] args)
        {
            Console.Write("Mikä on lempihedelmäsi? ");
            string value = Console.ReadLine();
            Console.WriteLine("Lempihedelmäsi on " + value);
        }
    }
}