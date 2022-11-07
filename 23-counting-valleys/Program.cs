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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int valleys = 0;
        int previousStep = 0;
        int currentStep = 0;

        for (int i = 0; i < path.Length; i++)
        {
            previousStep = currentStep;

            if (path[i] == 'U')
            {
                currentStep++;
            }
            if (path[i] == 'D')
            {
                currentStep--;
            }

            if (previousStep < 0 && currentStep == 0)
            {
                valleys++;
            }

        }
            return valleys;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = 8;

        string path = "UDDDUDUU";

        int result = Result.countingValleys(steps, path);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
