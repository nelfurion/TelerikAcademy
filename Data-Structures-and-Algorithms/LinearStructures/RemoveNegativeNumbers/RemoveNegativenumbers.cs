using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativenumbers
{
    class RemoveNegativenumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string line = Console.ReadLine();

            //We could just ignore the negative numbers, which would technically be ok, and faster, but there is no point in this
            while (line != String.Empty)
            {
                int next = int.Parse(line);
                numbers.Add(next);
                line = Console.ReadLine();
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
