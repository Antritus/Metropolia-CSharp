using System;
using System.Collections.Generic;

namespace Metropolia_CSharp
{
    internal class T7_2
    {
        public static void Run(string[] args)
        {
            List<string> nimet = new List<string> {"Torvalds", "Musk", "Gates", "Buffet", "Dorsey"};
            
            nimet.Clear();
            nimet.Add("Jobs");
            nimet.Add("Musk");
            nimet.Add("McAfee");
            nimet.Add("Buffet");
            nimet.Add("Wozniak");
            
            foreach (string nimi in nimet)
            {
                Console.WriteLine(nimi);
            }
        }
    }
}