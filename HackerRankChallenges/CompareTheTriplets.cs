using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace HackerRankChallenges
{
    public class CompareTheTriplets
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> score = new List<int>();
            score.Add(0);
            score.Add(0);
            int newScore;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    newScore = score.ElementAt<int>(0) + 1;
                    score.RemoveAt(0);
                    score.Insert(0, newScore);
                }
                else if (a[i] < b[i])
                {
                    newScore = score.ElementAt<int>(1) + 1;
                    score.RemoveAt(1);
                    score.Insert(1, newScore);
                }
            }
            return score;
        }

        public List<int> GetTripletsResult(string[] args)
        {
            List<int> a = args[0].TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = args[1].TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            return result;
        }

    }
}
