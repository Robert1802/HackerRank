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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var values = s.Split(':').Select(x => x.Substring(0, 2)).ToList();
        var isPM = s.Remove(0, 8) == "PM";
        var hours = int.Parse(values[0]);
        if (isPM || hours == 12)
            hours = (hours + 12) % 24;
        if (isPM && hours < 12)
            hours += 12;

        values[0] = hours.ToString("00");
        return string.Join(":", values);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
