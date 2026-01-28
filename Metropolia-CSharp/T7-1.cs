using System;
using System.Collections.Generic;

namespace Metropolia_CSharp
{
    internal class T7_1
    {
        public static void Run(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                Console.Write("Syötä numero:");
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    break;
                }
                list.Add(input);
            }
            Console.Write("Syöttämäsi numerot: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}