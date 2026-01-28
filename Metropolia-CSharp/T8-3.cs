using System;
using System.IO;

namespace Metropolia_CSharp
{
    internal class T8_3
    {
        public static void Run(string[] args)
        {
            Console.Write("Tiedosto johon lisätään: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Syötä tiedostoon {name} lisättävä sisältö:");
            String content = Console.ReadLine();

            File.AppendAllText(name, content + "\n");
        }
    }
}