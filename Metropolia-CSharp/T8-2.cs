using System;
using System.IO;

namespace Metropolia_CSharp
{
    internal class T8_2
    {
        public static void Run(string[] args)
        {
            Console.Write("Tiedostonimi: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Sisalto tiedostolle {name}:");
            String content = Console.ReadLine();

            File.WriteAllText(name, content);
        }
    }
}