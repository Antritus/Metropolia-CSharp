using System;
using System.Linq;

namespace Metropolia_CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Vaihda komento argumentteja");
                Console.WriteLine(" - VA");
                Console.WriteLine("C#-ohjelmien kirjoittaminen");
                Console.WriteLine(" - T3-1, T3-2, T3-3");
                Console.WriteLine("Muuttujat, tietotyypit ja operaattorit");
                Console.WriteLine(" - T4-1, T4-2, T4-3, T4-4");
                Console.WriteLine("Ehtolauseet");
                Console.WriteLine(" - T5-1, T5-2, T5-3, T5-4");
                Console.WriteLine("Silmukkarankenteet");
                Console.WriteLine(" - T6-1, T6-2, T6-3, T6-4, T6-5");
                Console.Write("Valitse ohjelma: ");
                string program = Console.ReadLine();
                Console.WriteLine();

                if (program == "VA")
                {
                    Console.WriteLine("Kirjoita uudet argumentit");
                    string newArgs = Console.ReadLine();
                    if (newArgs == null)
                    {
                        args = new string[0];
                    }
                    else
                    {
                        if (args.Contains(" "))
                        {
                            args = newArgs.Split(' ');
                        }
                        else
                        {
                            args = new[] { newArgs };
                        }
                    }
                } else if (program == "T3-1")
                {
                    T3_1.Run(args);
                } else if (program == "T3-2")
                {
                    T3_2.Run(args);
                } else if (program == "T3-3")
                {
                    T3_3.Run(args);
                } else if (program == "T4-1")
                {
                    T4_1.Run(args);
                } else if (program == "T4-2")
                {
                    T4_2.Run(args);
                } else if (program == "T4-3")
                {
                    T4_3.Run(args);
                } else if (program == "T4-4")
                {
                    T4_4.Run(args);
                } else if (program == "T5-1")
                {
                    T5_1.Run(args);
                } else if (program == "T5-2")
                {
                    T5_2.Run(args);
                } else if (program == "T5-3")
                {
                    T5_3.Run(args);
                } else if (program == "T5-4")
                {
                    T5_4.Run(args);
                } else if (program == "T6-1")
                {
                    T6_1.Run(args);
                } else if (program == "T6-2")
                {
                    T6_2.Run(args);
                } else if (program == "T6-3")
                {
                    T6_3.Run(args);
                } else if (program == "T6-4")
                {
                    T6_4.Run(args);
                } else if (program == "T6-5")
                {
                    T6_5.Run(args);
                }
                Console.WriteLine();
            }
        }
    }
}