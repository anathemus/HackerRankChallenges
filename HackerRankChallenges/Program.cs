using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareTheTriplets compare = new CompareTheTriplets();

            string strA = "17 28 30";
            string strB = "99 16 8";

            string[] compareArgs = { strA, strB };

            compare.GetTripletsResult(compareArgs).ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
