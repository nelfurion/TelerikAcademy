using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLargestSubsequence
{
    class ListLargestSubsequence
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string line = Console.ReadLine();

            Console.WriteLine("Input numbers to list and end with new line :)");

            while (line != String.Empty)
            {
                int next = int.Parse(line);
                numbers.Add(next);
                line = Console.ReadLine();
            }

            int longestSequenceIndex = 0;
            int currentNumber, sequenceLength = 0, newSequenceLength = 1;

            currentNumber = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != currentNumber)
                {
                    if (newSequenceLength > sequenceLength)
                    {
                        longestSequenceIndex += sequenceLength;
                        sequenceLength = newSequenceLength;
                    }
                    currentNumber = numbers[i];
                    newSequenceLength = 0;
                }

                newSequenceLength++;
            }

            List<int> longestSequence = new List<int>();
            for (int i = 0; i < sequenceLength; i++)
            {
                longestSequence.Add(numbers[longestSequenceIndex]);
                Console.WriteLine(longestSequence[i]);
            }
        }
    }
}
