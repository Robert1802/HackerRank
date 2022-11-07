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
     * Complete the 'timeInWords' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER h
     *  2. INTEGER m
     */

    public static string timeInWords(int h, int m)
    {
        var numbers = new[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty",
            "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine", "thirty"};

        //special case x:00 => x o' clock
        if (m == 0)
            return $"{numbers[h]} o' clock";

        if (m == 0)
            return (numbers[h] + " o' clock");
        else if (m < 30)
        {
            if (m == 1)
                return (numbers[m] + " minute past " + numbers[h]);
            else if (m == 15)
                return ("quarter" + " past " + numbers[h]);
            else
                return (numbers[m] + " minutes past " + numbers[h]);
        }
        else if (m == 30)
        {
            return ("half past " + numbers[h]);
        }
        else if (m < 45)
        {
            if (h + 1 > 12)
                h -= 12;
            return (numbers[60 - m] + " minutes to " + numbers[h + 1]);
        }
        else if (m == 45)
        {
            if (h + 1 > 12)
                h -= 12;
            return ("quarter to " + numbers[h + 1]);
        }
        else 
        {
            if (h + 1 > 12)
                h -= 12;
            if (60 - m == 1)
                return (numbers[60 - m] + " minute to " + numbers[h + 1]);
            else
                return (numbers[60 - m] + " minutes to " + numbers[h + 1]);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int h = Convert.ToInt32(Console.ReadLine().Trim());

        int m = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.timeInWords(h, m);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
