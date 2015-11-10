/*
    We are given numbers N and M and the following operations:

    N = N+1
    N = N+2
    N = N*2

    Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.

    Hint: use a queue.
    Example: N = 5, M = 16
    Sequence: 5 → 7 → 8 → 16
*/

namespace ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    class ShortestSequenceOfOperations
    {
        //TODO: Implement with queue
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Stack<int> transformSequence = new Stack<int>();
            transformSequence.Push(m);

            while (m > n)
            {
                if (m % 2 == 0 && m / 2 >= n)
                {
                    m /= 2;
                    transformSequence.Push(m);
                }
                else if (m - 2 >= n)
                {
                    m -= 2;
                    transformSequence.Push(m);
                }
                else if (m - 1 >= n)
                {
                    m -= 1;
                    transformSequence.Push(m);
                }
            }

            while (transformSequence.Count > 0)
            {
                Console.WriteLine(transformSequence.Pop());
            }
        }
    }
}
