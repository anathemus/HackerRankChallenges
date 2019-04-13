using System.IO;
using System;

namespace Minimum_Swaps_InsertionSort
{
    public class Solution
    {

        // Complete the minimumSwaps function below.
        public static int minimumSwaps(int[] arr)
        {
            int swapCount = 0;

            for (int i = 0; i < arr.Length - 1;)
            {
                if (arr[i] != i + 1)
                {
                    int temp = arr[arr[i] - 1];
                    arr[arr[i] - 1] = arr[i];
                    arr[i] = temp;
                    swapCount++;
                }
                else
                {
                    i++;
                }
            }

            return swapCount;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);

            textWriter.WriteLine(res);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}