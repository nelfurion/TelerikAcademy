using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackReversenumbers
{
    class StackReversenumbers
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            int count = int.Parse(Console.ReadLine());
            int number;

            for (int i = 0; i < count; i++)
            {
                number = int.Parse(Console.ReadLine());
                numbers.Push(number);
            }

            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
