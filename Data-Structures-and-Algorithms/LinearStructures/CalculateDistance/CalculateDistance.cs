/*
    (*) We are given a labyrinth of size N x N.

    Some of its cells are empty (0) and some are full (x).
    We can move from an empty cell to another empty cell if they share common wall.
    Given a starting position (*) calculate and fill in the array the minimal distance from this position to any other cell in the array. Use "u" for all unreachable cells.
    Example:
*/
namespace CalculateDistance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CalculateDistance
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] field = new int[rows, cols];

            int[,] sampleField = {
                                     {'0', '0', '0', 'x', '0', 'x'},
                                     {'0', 'x', '0', 'x', '0', 'x'},
                                     {'0', '*', 'x', '0', 'x', '0'},
                                     {'0', 'x', '0', '0', '0', '0'},
                                     {'0', '0', '0', 'x', 'x', '0'},
                                     {'0', '0', '0', 'x', '0', 'x'}
                                 };

            field = sampleField;

            //fill field
            /*for (int i = 0; i < rows; i++)
            {
                for (int i = 0; i < cols; i++)
                {
                    field[i, j] = Console.ReadLine();
                }
            }*/
        }
    }
}
