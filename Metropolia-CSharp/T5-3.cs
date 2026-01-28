using System;

namespace Metropolia_CSharp
{
    internal class T5_3
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Valitse:");
            Console.WriteLine("1) Vesi\n2) Mehu\n3) Limonadi\n4) Lopeta");
            int drink = Convert.ToInt32(Console.ReadLine());

            switch (drink)
            {
                case 1:
                    Console.WriteLine("Valitsit Vesi.");
                    break;
                case 2:
                    Console.WriteLine("Valitsit Mehu.");
                    break;
                case 3:
                    Console.WriteLine("Valitsit Limonadi.");
                    break;
                case 4:
                    Console.WriteLine("Lopetus!");
                    break;
            }
        }
    }
}