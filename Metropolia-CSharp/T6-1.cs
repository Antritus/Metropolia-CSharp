using System;

namespace Metropolia_CSharp
{
    internal class T6_1
    {
        public static void Run(string[] args)
        {
            int n = int.Parse(args[0]);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}