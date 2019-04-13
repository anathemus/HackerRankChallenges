using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    // Prefix Sum Array cut calculations by a ton!
    public class Solution
    {

        // Complete the arrayManipulation function below.
        public static long arrayManipulation(int n, int[][] queries)
        {
            long highestSum = 0;
            long[] sumArray = new long[n + 2];
            long x = 0;

            for (int j = 0; j < n; j++)
            {
                sumArray[j] = 0;
            }

            for (int i = 0; i < queries.Length; i++)
            {
                sumArray[(queries[i][0]) - 1] += queries[i][2];
                if (queries[i][1] <= n)
                {
                    sumArray[queries[i][1]] -= queries[i][2];
                }
                //int a = queries[i][0];
                //int b = queries[i][1];
                //int k = queries[i][2];
                //for (int j = (a - 1); j <= (b - 1); j++)
                //{
                //    sumArray[j] += k;
                //    if (sumArray[j] > highestSum)
                //    {
                //        highestSum = sumArray[j];
                //    }
                //}
            }

            for (int l = 0; l < sumArray.Length; l++)
            {
                x += sumArray[l];
                if (x > highestSum)
                {
                    highestSum = x;
                }
            }

            return highestSum;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
