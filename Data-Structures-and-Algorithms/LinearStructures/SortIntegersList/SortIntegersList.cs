using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortIntegersList
{
    class SortIntegersList
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string line = Console.ReadLine();

            while (line != String.Empty)
            {
                int next = int.Parse(line);
                numbers.Add(next);
                line = Console.ReadLine();
            }

            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
