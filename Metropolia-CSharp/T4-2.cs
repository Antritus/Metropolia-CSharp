using System;

namespace Metropolia_CSharp
{
    internal class T4_2
    {
        public static void Run(string[] args)
        {
            sbyte var1 = 0;
            long var2 = 0;
            ushort var3 = 0;
            double var4 = 0.0f;
            
            if (var1.GetType() == typeof(SByte))
            {
                Console.WriteLine("var1 tyyppi ok.");
            }

            if (var2.GetType() == typeof(Int64))
            {
                Console.WriteLine("var2 tyyppi ok.");
            }

            if (var3.GetType() == typeof(UInt16))
            {
                Console.WriteLine("var3 tyyppi ok.");
            }

            if (var4.GetType() == typeof(Double))
            {
                Console.WriteLine("var4 tyyppi ok.");
            }
        }
    }
}