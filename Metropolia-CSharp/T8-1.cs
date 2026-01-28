using System;
using System.IO;

namespace Metropolia_CSharp
{
    internal class T8_1
    {
        public static void Run(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Ei tiedostonimeä!");
                return;
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine("Tiedostoa ei löytynyt!");
                return;
            }

            string content = File.ReadAllText(args[0]);
            Console.WriteLine(content);
        }
    }
}