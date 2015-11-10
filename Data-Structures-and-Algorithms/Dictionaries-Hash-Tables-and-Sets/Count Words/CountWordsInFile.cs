/*
Write a program that counts how many times each word from given text file words.txt appears in it. The character casing differences should be ignored. The result words should be ordered by their number of occurrences in the text. Example:

This is the TEXT. Text, text, text – THIS TEXT! Is this the text?

is -> 2

the -> 2

this -> 3

text -> 6
*/

namespace Count_Words
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class CountWordsInFile
    {
        static void Main(string[] args)
        {
            string text = ReadFile(@"C:\Users\radostin\Documents\Visual Studio 2013\Projects\Dictionaries-Hash-Tables-and-Sets\test.txt");
            CountWords(text);
        }

        static string ReadFile(string filePath)
        {
            string text;

            using (StreamReader reader = new StreamReader(filePath))
            {
                text = reader.ReadToEnd();
            }

            return text;
        }

        static void CountWords(string text)
        {
            char[] delimiters = { ' ', ',' };
            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> repeats = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (repeats.ContainsKey(word))
                {
                    repeats[word]++;
                }
                else
                {
                    repeats[word] = 1;
                }
            }

            Func<int, int, int> Sort = (x, y) => x - y;

            repeats = repeats.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in repeats)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
