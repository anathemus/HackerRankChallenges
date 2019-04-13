using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Minimum_Bribes
{
    public class Solution
    {

        // Complete the minimumBribes function below.
        // public static string minimumBribes(int[] q)
        public static void minimumBribes(int[] q)
        {
            int numBribes = 0;
            int bribePositions;
            int position = 0;
            bool chaotic = false;

            for (int i = q.Length - 1; i >= 0; i--)
            {
                int j = 0;

                bribePositions = q[position] - (position + 1);
                if (bribePositions > 2)
                {
                    chaotic = true;
                }

                if (q[i] - 2 > 0)
                {
                    j = q[i] - 2;
                }

                while (j <= i)
                {
                    if (q[j] > q[i])
                    {
                        numBribes++;
                    }
                    j++;
                }
                position++;
            }
            if (chaotic == false)
            {
                Console.WriteLine(numBribes);
            }
            else
            {
                Console.WriteLine("Too chaotic");
            }
        }
            // return numBribes.ToString();
            //int currentQSize = q.Count();
            //if (currentQSize == 1)
            //{
            //    Console.WriteLine(q[0]);
            //    return q[0].ToString();
            //}
            //else
            //{
                
            //    bool chaotic = false;
            //    for (int j = 0; j < currentQSize; j++)
            //    {
            //        if (q[j] != j + 1)
            //        {
            //            if (q[j] < j - 3 || q[j] > j + 3)
            //            {
            //                chaotic = true;
            //                break;
            //            }
            //            else if (q[j] > j + 1)
            //            {
            //                numBribes += q[j] - (j + 1);
            //            }
            //        }
            //    }

            //    if (chaotic == true)
            //    {
            //        Console.WriteLine("Too chaotic");
            //        return "Too chaotic";
            //    }
            //    else
            //    {
            //        Console.WriteLine(numBribes);
            //        return numBribes.ToString();
            //    }
            //}

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                minimumBribes(q);
            }
            Console.ReadLine();
        }
    }
}
