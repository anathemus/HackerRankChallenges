using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_RansomNote
{
    public class Solution
    {

        // Complete the checkMagazine function below.
        //public static bool checkMagazine(string[] magazine, string[] note)
        public static void checkMagazine(string[] magazine, string[] note)
        {
            Hashtable noteCheckHash = new Hashtable();
            bool canMakeNote = true;
            foreach (var word in magazine)
            {
                if (!noteCheckHash.ContainsKey(word))
                {
                    noteCheckHash.Add(word, 1);
                }
                else
                {
                    noteCheckHash[word] = noteCheckHash[word].GetHashCode() + 1;
                }
            }

            foreach (var word in note)
            {
                if (noteCheckHash.ContainsKey(word))
                {
                    noteCheckHash[word] = noteCheckHash[word].GetHashCode() - 1;
                    if (noteCheckHash[word].GetHashCode() < 0)
                    {
                        canMakeNote = false;
                    }
                }
                else
                {
                    canMakeNote = false;
                }
            }

            if (canMakeNote)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            //return canMakeNote;
        }

        static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }
    }
}
