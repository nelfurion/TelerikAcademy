/*
    The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.

    Write a program to find the majorant of given array (if exists).
    Example:
    {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
*/

namespace FindMajorant
{
    using System;
    using System.Collections.Generic;
    class FindMajorant
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            char[] delimiters = { ' ', ',' };

            var numbers = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < numbers.Length; i++)
            {
                int nextNumber = int.Parse(numbers[i]);
                if (nextNumber < 1000 && nextNumber >= 0)
                {
                    if (occurences.ContainsKey(numbers[i]))
                    {
                        occurences[numbers[i]]++;
                    }
                    else
                    {
                        occurences[numbers[i]] = 1;
                    }
                }

                if (occurences[numbers[i]] >= numbers.Length / 2 + 1)
                {
                    int majorant = int.Parse(numbers[i]);
                    Console.WriteLine("The majorant is: {0}", majorant);
                    break;
                }
            }
        }
    }
}
