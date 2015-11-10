/*
    Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.

    Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    2 → 2 times
    3 → 4 times
    4 → 3 times
*/
namespace NumberOfOccurences
{
    using System;
    using System.Collections.Generic;

    class NumberOfOccurences
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            char[] delimiters = {' ', ','};

            string[] numbers = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

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
            }

            foreach (var occurence in occurences)
            {
                Console.WriteLine("{0} → {1}", occurence.Key, occurence.Value);
            }
        }
    }
}
