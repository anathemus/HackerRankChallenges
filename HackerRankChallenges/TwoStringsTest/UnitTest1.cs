using NUnit.Framework;
using TwoStrings;
using System;

namespace Tests
{
    public class Tests : Solution
    {
        [SetUp]
        public void Setup()
        {
        }

        private string[] FileAsString = System.IO.File.ReadAllText(@"D:\Source\HackerRankChallenges\HackerRankChallenges\TwoStringsTest\bin\input05.txt").Split(' ');

        [Test]
        public void TwoStringsTest1()
        {
            string s1 = "hello";
            string s2 = "world";
            Assert.AreEqual("YES", twoStrings(s1, s2));
        }

        [Test]
        public void TwoStringsTest2()
        {
            string s1 = "hi";
            string s2 = "world";
            Assert.AreEqual("NO", twoStrings(s1, s2));
        }

        [Test]
        public void TwoStringsTest3()
        {
            string s1 = FileAsString[1];
            string s2 = FileAsString[2];
            Assert.AreEqual("YES", twoStrings(s1, s2));
        }

        [Test]
        public void TwoStringsTest4()
        {
            string s3 = FileAsString[3];
            string s4 = FileAsString[4];
            Assert.AreEqual("YES", twoStrings(s3, s4));
        }

        [Test]
        public void TwoStringsTest5()
        {
            string s5 = FileAsString[5];
            string s6 = FileAsString[6];
            Assert.AreEqual("NO", twoStrings(s5, s6));
        }
    }
}