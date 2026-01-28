using System;
using System.IO;

namespace Metropolia_CSharp
{
    internal class T8_4
    {
        public static void Run(string[] args)
        {
            string[] files = Directory.GetFiles(".");

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}