﻿using System.CodeDom.Compiler;
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
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int pageCount(int n, int p)
    {
        int start = 0;
        int finish = 0;

        for (int i = 1; i < n; i = i + 2)
        {
            Console.WriteLine(i);
            if (p <= i)
            {
                break;
            }

            start++;
        }
        Console.WriteLine("");
        for (int j = n;j > 0; j = j - 2)
        {
            if (j % 2 != 0)
            {
                j--;
            }
            Console.WriteLine(j);
            if (p >= j)
            {
                break;
            }

            finish++;
        }

        if (start >= finish)
        {
            return finish;
        }
        else
        {
            return start;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
