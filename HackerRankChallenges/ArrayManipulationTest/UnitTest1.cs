using NUnit.Framework;
using System;
using ArrayManipulation;

namespace Tests
{
    public class Tests : Solution
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArrayTest1()
        {
            int[][] testArray = new int[3][];
            testArray[0] = Array.ConvertAll("1 2 100".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            testArray[1] = Array.ConvertAll("2 5 100".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            testArray[2] = Array.ConvertAll("3 4 100".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));

            Console.WriteLine(arrayManipulation(5, testArray));
            Assert.AreEqual(arrayManipulation(5, testArray), 200);
        }

        [Test]
        public void ArrayTest2()
        {
            int[][] testArray = new int[100000][];
            string[] fileLines = System.IO.File.ReadAllLines(@"D:\Source\HackerRankChallenges\HackerRankChallenges\ArrayManipulationTest\bin\input13.txt");

            for (int i = 0; i < 100000; i++)
            {
                testArray[i] = Array.ConvertAll(fileLines[i + 1].Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }
        
            Console.WriteLine(arrayManipulation(10000000, testArray));
            Assert.AreEqual(arrayManipulation(10000000, testArray), 2490686975);
        }

        [Test]
        public void ArrayTest3()
        {
            int[][] testArray = new int[3][];
            testArray[0] = Array.ConvertAll("2 3 603".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            testArray[1] = Array.ConvertAll("1 1 286".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            testArray[2] = Array.ConvertAll("4 4 882".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));

            Console.WriteLine(arrayManipulation(4, testArray));
            Assert.AreEqual(arrayManipulation(4, testArray), 882);
        }
    }
}