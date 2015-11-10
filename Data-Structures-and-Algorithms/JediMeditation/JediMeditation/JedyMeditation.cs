using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMeditation
{
    class JedyMeditation
    {
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());
            List<string> jedy = Console.ReadLine().Split(' ').ToList();
            jedy = jedy.OrderBy(x => Math.Abs('m' - x[0])).ToList();

            foreach (var singleJedy in jedy)
            {
                Console.Write(singleJedy + ' ');
            }*/

            //SECOND SOLUTION
            string a = Console.ReadLine();
            char[] delimiters = {' '};

            HashSet<string> test = new HashSet<string>(Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => 'm' - x[0]));

            foreach (var singleJedy in test)
            {
                Console.Write(singleJedy + ' ');
            }
        }
    }
}
