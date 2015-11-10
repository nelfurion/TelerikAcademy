/*
Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. Example:

{C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
*/

namespace ExtractOddOccurences
{
    using System;
    using System.Collections.Generic;

    class ExtractOddOccurences
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            char[] delimiters = { ' ', ',' };
            string[] input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

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

            HashSet<string> odds = new HashSet<string>(); //trying out set

            foreach (var item in occurences)
            {
                if (item.Value % 2 != 0)
                {
                    odds.Add(item.Key);
                }
            }

            Console.Write("{ ");
            foreach (var item in odds)
            {
                Console.Write(item + ' ');
            }
            Console.Write('}');
        }
    }
}
