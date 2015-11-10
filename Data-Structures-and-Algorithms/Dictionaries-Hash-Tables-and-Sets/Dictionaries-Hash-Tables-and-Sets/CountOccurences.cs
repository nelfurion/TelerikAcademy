/*
Write a program that counts in a given array of double values the number of occurrences of each value. Use Dictionary<TKey,TValue>.

Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}

-2.5 -> 2 times

3 -> 4 times

4 -> 3 times
*/

namespace Dictionaries_Hash_Tables_and_Sets
{
    using System;
    using System.Collections.Generic;

    class CountOccurences
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split(' ');

            foreach (string item in input)
            {
                if (occurences.ContainsKey(item))
                {
                    occurences[item]++;
                }
                else
                {
                    occurences[item] = 1;
                }
            }

            foreach (var item in occurences)
            {
                Console.WriteLine("{0} - {1} times", item.Key, item.Value);
            }
        }
    }
}
