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
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        var day = 13; //default day is 13 because 256-31-28-31-30-31-30-31-31=13 (days of month)
        var month = 9;
        if (year < 1918)
        { //julian calender
            if (year % 4 == 0)
                day--;
        }
        else if (year == 1918)
        {
            day += 13; //skipped 13 days
        }
        else
        { //year > 1918
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                day--;
        }
        return $"{day:00}.{month:00}.{year:0000}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
