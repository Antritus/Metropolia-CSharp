using System;

namespace Metropolia_CSharp
{
    internal class T4_1
    {
        public static void Run(string[] args)
        {
            short var1 = 1;
            byte  var2 = 1;
            float var3 = 1.0f;
            char var4 = 'a';
            bool var5 = true;
            ulong  var6 = 1;
            decimal  var7 = 1;
            
            Console.WriteLine("Var1 on tyyppiä " + var1.GetType());
            Console.WriteLine("Var2 on tyyppiä " + var2.GetType());
            Console.WriteLine("Var3 on tyyppiä " + var3.GetType());
            Console.WriteLine("Var4 on tyyppiä " + var4.GetType());
            Console.WriteLine("Var5 on tyyppiä " + var5.GetType());
            Console.WriteLine("Var6 on tyyppiä " + var6.GetType());
            Console.WriteLine("Var7 on tyyppiä " + var7.GetType());
        }
    }
}