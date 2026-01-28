using System;
using System.Collections.Generic;

namespace Metropolia_CSharp
{
    internal class T9_1
    {
        public static void Run(string[] args)
        {
            List<T9_1Leffa> leffat = new List<T9_1Leffa>() { };
            leffat.Add(new T9_1Leffa("Robocop", 102, 1987));
            leffat.Add(new T9_1Leffa("Robocop 2", 117, 1990));
            leffat.Add(new T9_1Leffa("Robocop 3", 104, 1993));

            foreach (var leffa in leffat)
            {
                Console.WriteLine("Nimi: " + leffa.Nimi + ", kesto: " + leffa.Kesto + "min, vuosi: " + leffa.Vuosi);
            }
        }
    }
    [Serializable]
    class T9_1Leffa{
        public string Nimi;
        public int Kesto;
        public int Vuosi;
        
        public T9_1Leffa(string name, int length, int released)
        {
            Nimi = name;
            Kesto = length;
            Vuosi = released;
        }
    }
}