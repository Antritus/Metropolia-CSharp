using System;
using System.Collections.Generic;

namespace Metropolia_CSharp
{
    internal class T10_2
    {
        public static void Run(string[] args)
        {
            Console.Write("Kirjoita lause: ");
            var Sentence = Convert.ToString(Console.ReadLine());
            Console.WriteLine(MyJoin(MySplit(Sentence, ' '), ','));
            Console.WriteLine(MyJoin(MySplit(Sentence, ' '), '\n'));
        }

        static string[] MySplit(string str, char split)
        {
            char[] chars = str.ToCharArray();
            List<string> strings = new List<string>();

            int lastIndex = 0;
            int currentIndex = 0;

            while (currentIndex < str.Length)
            {
                if (chars[currentIndex] == split)
                {
                    string build = "";
                    for (int i = lastIndex; i < currentIndex; i++)
                    {
                        build += chars[i];
                    }
                    strings.Add(build);
                    lastIndex = currentIndex + 1;
                }
                currentIndex++;
            }

            strings.Add(str.Substring(lastIndex));

            return strings.ToArray();
        }

        static string MyJoin(string[] strings, char join)
        {
            string joint = null;
            foreach (var str in strings)
            {
                if (joint != null)
                {
                    joint += join;
                }
                else
                {
                    joint = "";
                }
                joint += str;
            }

            return joint;
        }
    }
}