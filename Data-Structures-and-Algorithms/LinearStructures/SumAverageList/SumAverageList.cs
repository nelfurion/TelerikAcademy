using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAverageList
{
    class SumAverageList
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

            Console.WriteLine("sum: {0}", numbers.Sum());
            Console.WriteLine("average: {0}", numbers.Average());
        }
    }
}
