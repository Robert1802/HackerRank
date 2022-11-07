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

class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        int minRecord = 0;
        int maxRecord = 0;

        int minBreak = 0;
        int maxBreak = 0;

        for (int i = 0; i < scores.Count ; i++)
        {
            if (i == 0)
            {
                minRecord = scores[i];
                maxRecord = scores[i];
            }

            else
            {
                if ((scores[i] < minRecord))
                {
                    minRecord = (scores[i]);
                    minBreak++;
                }

                if ((scores[i] > maxRecord))
                {
                    maxRecord = (scores[i]);
                    maxBreak++;
                }
            }
        }

        List<int>  Result = new List<int>();
        Result.Add(maxBreak);
        Result.Add(minBreak);
        return Result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));

    }
}
