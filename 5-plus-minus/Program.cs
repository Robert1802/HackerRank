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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double positives = 0;
        double negatives = 0;
        double zeroes = 0;
        int n = arr.Count;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == 0) { zeroes++; }
            if (arr[i] > 0) { positives++; }
            if (arr[i] < 0) { negatives++; }
        }


        Console.WriteLine($"{positives / n:0.000000}");
        Console.WriteLine($"{negatives / n:0.000000}");
        Console.WriteLine($"{zeroes / n:0.000000}");

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
