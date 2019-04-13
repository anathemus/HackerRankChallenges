using NUnit.Framework;
using HashTable_RansomNote;
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
        public void HashRansomTest1()
        {
            string[] magazine = "give me one grand today night".Split(' ');
            string[] note = "give one grand today".Split(' ');
            Assert.True(checkMagazine(magazine, note));
        }

        [Test]
        public void HashRansomTest2()
        {
            string[] magazine = "two times three is not four".Split(' ');
            string[] note = "two times two is four".Split(' ');
            Assert.False(checkMagazine(magazine, note));
        }

        [Test]
        public void HashRansomTest3()
        {
            string[] magazine = "ive got a lovely bunch of coconuts".Split(' ');
            string[] note = "ive got some coconuts".Split(' ');
            Assert.False(checkMagazine(magazine, note));
        }

        [Test]
        public void HashRansomTest4()
        {
            string[] magazine = new string[30000];
            string[] note = new string[20000];
            string[] fileAsString = System.IO.File.ReadAllText(@"D:\Source\HackerRankChallenges\HackerRankChallenges\HashTable_RansomNote_Test\bin\input18.txt").Split(' ');
            for (int i = 0; i < magazine.Length; i++)
            {
                magazine[i] = fileAsString[i + 2];
            }
            for (int i = 0; i < note.Length; i++)
            {
                note[i] = fileAsString[magazine.Length + i];
            }

            Assert.False(checkMagazine(magazine, note));
        }

        [Test]
        public void HashRansomTest5()
        {
            string[] magazine = new string[30000];
            string[] note = new string[10000];
            string[] fileAsString = System.IO.File.ReadAllText(@"D:\Source\HackerRankChallenges\HackerRankChallenges\HashTable_RansomNote_Test\bin\input14.txt").Split(' ');
            for (int i = 0; i < magazine.Length; i++)
            {
                magazine[i] = fileAsString[i + 2];
            }
            for (int i = 0; i < note.Length; i++)
            {
                note[i] = fileAsString[magazine.Length + i];
            }

            Assert.True(checkMagazine(magazine, note));
        }
    }
}