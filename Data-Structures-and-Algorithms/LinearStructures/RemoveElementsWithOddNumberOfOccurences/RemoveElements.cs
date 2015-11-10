using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsWithOddNumberOfOccurences
{
    class Removeelements
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(',').ToList();

            Dictionary<string, int> repeats = new Dictionary<string, int>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (repeats.ContainsKey(elements[i]))
                {
                    repeats[elements[i]]++;
                }
                else
                {
                    repeats.Add(elements[i], 1);
                }
            }

            foreach (var key in repeats.Keys)
            {
                if (repeats[key] % 2 == 1)
                {
                    elements.RemoveAll(x => x == key);
                }
            }

            Console.Write(elements[0].Trim());

            for (int i = 1; i < elements.Count; i++)
            {
                Console.Write(',');
                Console.Write(elements[i].Trim());
            }

            Console.WriteLine();
        }
    }
}
