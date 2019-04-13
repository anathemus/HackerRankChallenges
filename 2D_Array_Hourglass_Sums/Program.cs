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

namespace Program
{
    public class Solution
    {
        // Complete the hourglassSum function below.
        public static int HourglassSum(int[][] arr)
        {
            int maxHourglassSum = int.MinValue;
            int currentHourglassSum = 0;

            // 6 rows, minus 1 because for loops sum whole hourglass each iteration
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int k = j, kMax = j + 3;
                    while(k < kMax)
                    { 
                        if (k == j + 1)
                        {
                            currentHourglassSum += arr[i][k];
                            currentHourglassSum += arr[i + 1][k];
                            currentHourglassSum += arr[i + 2][k];
                        }
                        else
                        {
                            currentHourglassSum += arr[i][k];
                            currentHourglassSum += arr[i + 2][k];
                        }
                        k++;
                    }

                    if (currentHourglassSum > maxHourglassSum)
                    {
                        maxHourglassSum = currentHourglassSum;
                    }

                    currentHourglassSum = 0;
                }
            }
            return maxHourglassSum;
        }

        static void Main(string[] args)
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = HourglassSum(arr);
            Console.WriteLine(result);
            Console.ReadLine();

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
