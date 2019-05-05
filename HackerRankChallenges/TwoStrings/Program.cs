using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStrings
{
    public class Solution
    {

        // Complete the twoStrings function below.
        public static string twoStrings(string s1, string s2)
        {
            bool containsSubString = false;

            for (int i = Convert.ToInt32('a'); i < Convert.ToInt32('a') + 25; i++)
            {
                if (s1.IndexOf(Convert.ToChar(i)) != -1 && s2.IndexOf(Convert.ToChar(i)) != -1)
                {
                    containsSubString = true;
                    break;
                }
            }

            if (containsSubString)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
