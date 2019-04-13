using Minimum_Swaps_InsertionSort;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests : Solution
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSwaps1()
        {
            int[] arr = { 7, 1, 3, 2, 4, 5, 6 };
            Assert.AreEqual(minimumSwaps(arr), 5);
        }

        [Test]
        public void TestSwaps2()
        {
            int[] arr = { 2, 3, 4, 1, 5 };
            Assert.AreEqual(minimumSwaps(arr), 3);
        }
    }
}