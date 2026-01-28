using System;

namespace Metropolia_CSharp
{
    internal class T6_5
    {
        public static void Run(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("Torakka-Jalka-Ydinase. Valitse 1-4. \n1) Torakka 2) Jalka 3) Ydinase 4) Poistu");
                int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Torakka!");
                        break;
                    case 2:
                        Console.WriteLine("Jalka!");
                        break;
                    case 3:
                        Console.WriteLine("Ydinase!");
                        break;
                    case 4:
                        return;
                }
                
                int random = rnd.Next(1, 4);
                Console.Write("Tietokone valitsi: ");
                switch (random)
                {
                    case 1:
                        Console.Write("Torakka!");
                        break;
                    case 2:
                        Console.Write("Jalka!");
                        break;
                    case 3:
                        Console.Write("Ydinase!");
                        break;
                }

                if (userInput == random)
                {
                    Console.WriteLine(" Tasapeli!");
                }

                if (userInput == 1 && random == 2
                    || userInput == 3 && random == 2
                    || userInput == 1 && random == 3
                    )
                {
                    Console.WriteLine("Voitit pelin!");
                } else {
                    Console.WriteLine("Hävisit pelin!");
                }
                Console.WriteLine();
            }
        }
    }
}