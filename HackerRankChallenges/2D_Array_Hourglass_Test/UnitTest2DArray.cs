using NUnit.Framework;
using Program;
using System;
using System.Diagnostics;

namespace Tests
{
    public class Tests : Solution
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test2DArray()
        {
            int[][] arr = new int[6][];
            string[] arrStr = new string[6];
            arrStr[0] = "1 1 1 0 0 0";
            arrStr[1] = "0 1 0 0 0 0";
            arrStr[2] = "1 1 1 0 0 0";
            arrStr[3] = "0 0 2 4 4 0";
            arrStr[4] = "0 0 0 2 0 0";
            arrStr[5] = "0 0 1 2 4 0";

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(arrStr[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = HourglassSum(arr);

            Debug.WriteLine(result);

            Assert.IsTrue(result == 19);
        }
    }
}