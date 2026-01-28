using System;

namespace Metropolia_CSharp
{
    internal class T10_1
    {
        private int[] products = { 10, 14, 22, 33, 44, 13, 22, 55, 66, 77 };
        public static void Run(string[] args)
        {
            T10_1 t10_1 = new T10_1();
            t10_1.run();
        }

        public void run()
        {
            int price = 0;
            Console.WriteLine("Supermarket");
            Console.WriteLine("===========");
            while (true)
            {
                Console.Write("Valitse tuote (1-10) 0 lopetus:");
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                if (input > 10)
                {
                    Console.WriteLine("Anna tuote oikein väliltä (1-10)");
                    continue;
                }
                Console.WriteLine($"tuote: {input} Hinta: {products[input-1]}");
                price += products[input-1];
            }

            Console.WriteLine($"Yhteensä: {price}");
            Console.Write("Maksu: ");
            int payed = int.Parse(Console.ReadLine());
            Console.WriteLine($"Vaihto: {payed-price}");
        }
    }
}