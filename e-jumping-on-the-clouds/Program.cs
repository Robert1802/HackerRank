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
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        // 0 0 1 0 0 1 0
        // 0 0 0 1 0 0

        int currentCloud = 0;
        int nextCloud = 0;
        int jumps = 0;
        int size = c.Count - 1;

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(i);
            if (i + 2 <= size)
            {
                if (c[i+2] == 0)
                {
                    Console.WriteLine(c[i + 2]);
                    jumps++;
                    i++;
                    continue;
                }
            }
            if (i + 1 <= size)
            {
                if (c[i + 1] == 0)
                {
                    Console.WriteLine(c[i + 2]);
                    jumps++;
                }
            }
        }

        return jumps;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
