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
     * Complete the 'encryption' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string encryption(string s)
    {
        var rows = (int)Math.Ceiling(Math.Sqrt(s.Length));

        var lines = new string[rows];
        for (int i = 0; i < s.Length; i++)
            lines[i % rows] += s[i];

        return string.Join(" ", lines);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = "chillout";

        string result = Result.encryption(s);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
