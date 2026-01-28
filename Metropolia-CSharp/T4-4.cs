using System;

namespace Metropolia_CSharp
{
    internal class T4_4
    {
        public static void Run(string[] args)
        {
            int x = 10;
            int y = 10;
            int z = 11;
            string s = "C";
            
            if (((x >= y) && (y < z)) || ((x > y) && (s == "A")) )
            {
                if (s == "C")
                {
                    Console.WriteLine("Onnistui!");
                }
                else
                {
                    Console.WriteLine("Melkein!");
                }
            }
            else
            {
                Console.WriteLine("Ei iha, yritä vielä!");
            }
        }
    }
}