using System;

namespace Metropolia_CSharp
{
    internal class T5_4
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Löydä xy-akseleilla olevan pisteen kvadrantti:");
            Console.Write("X-koordinaatti: ");
            int x =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Y-koordinaatti: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x < 0 && y < 0)
            {
                Console.WriteLine($"Koordinaattipiste ({x},{y}) on kvadrantissa 3.");
            } else if (x > 0 && y > 0)
            {
                Console.WriteLine($"Koordinaattipiste ({x},{y}) on kvadrantissa 1.");
            } else if (x == 0 && y == 0)
            {
                Console.WriteLine($"Koordinaattipiste ({x},{y}) on origossa.");
            } else if (x > 0 && y < 0)
            {
                Console.WriteLine($"Koordinaattipiste ({x},{y}) on kvadrantissa 4.");                
            } else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Koordinaattipiste ({x},{y}) on kvadrantissa 2.");
            }
        }
    }
}