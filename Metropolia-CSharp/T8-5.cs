using System;
using System.IO;

namespace Metropolia_CSharp
{
    internal class T8_5
    {
        public static void Run(string[] args)
        {
            string[] files = Directory.GetFiles(".");


            int deleted = 0;
            foreach (var file in files)
            {
                if (file.EndsWith(".dat"))
                {
                    File.Delete(file);
                    deleted++;
                }
            }
            Console.WriteLine($"{deleted} tiedosto(a) poistettu.");
        }
    }
}