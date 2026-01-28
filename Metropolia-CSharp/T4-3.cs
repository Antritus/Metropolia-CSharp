using System;

namespace Metropolia_CSharp
{
    internal class T4_3
    {
        public static void Run(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = -1;
            if ( (a != b) && (a < b) )
            {
                if (a > c)
                {
                    Console.WriteLine("Onnistui!");
                }
            }
            else
            {
                Console.WriteLine("Yritä uudestaan!");
            }
        }
    }
}