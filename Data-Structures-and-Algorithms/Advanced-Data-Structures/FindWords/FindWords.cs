/*
Write a program that finds a set of words (e.g. 1000 words) in a large text (e.g. 100 MB text file).
Print how many times each word occurs in the text.
Hint: you may find a C# trie in Internet.
*/
namespace FindWords
{
    using System;
    using rm.Trie;
    using System.IO;
    using System.Collections;
    using System.Collections.Generic;

    class FindWords
    {
        static void Main(string[] args)
        {
            var trie = TrieFactory.CreateTrie();
            HashSet<string> words = new HashSet<string>();

            using (StreamReader reader = new StreamReader("../../100MB.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    foreach (var word in line.Split(' '))
                    {
                        words.Add(word);
                        trie.AddWord(word);
                    }
                }
                
            }

            foreach (var word in words)
            {
                Console.WriteLine("{0} - {1} times", word, trie.WordCount(word));
            }
        }
    }
}
