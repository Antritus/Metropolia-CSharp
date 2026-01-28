using System;

namespace Metropolia_CSharp
{
    internal class T6_4
    {
        public static void Run(string[] args)
        {
            int[] numbers = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                numbers[i] = int.Parse(args[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}